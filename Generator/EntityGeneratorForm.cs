using CCWin;
using Npgsql;
using System.Data;
using System.Text;

namespace PostgresqlGenerator
{
    public partial class EntityGeneratorForm : CCSkinMain
    {
        public EntityGeneratorForm()
        {
            InitializeComponent();
        }

        private string connectionString = string.Empty;
        private string tableName = string.Empty;
        private string entityName = string.Empty;

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // 获取用户输入的参数
            connectionString = txtConnectionString.Text;

            if (!string.IsNullOrEmpty(txtTableName.Text))
            {
                tableName = txtTableName.Text;
            }
            else
            {
                tableName = cboTableList.SelectedItem?.ToString();
            }

            entityName = txtEntityName.Text;

            if (string.IsNullOrEmpty(connectionString) || string.IsNullOrEmpty(tableName) || string.IsNullOrEmpty(entityName))
            {
                MessageBoxEx.Show("请填写完整信息！");
                return;
            }

            // 调用生成实体类代码的方法
            string entityCode = GenerateEntityCode(connectionString, tableName, entityName);

            // 将生成的实体类代码输出到 textarea 中
            txtEntityCode.Text = entityCode;
        }

        private string GetPropertyType(string dataType)
        {
            // 根据数据类型生成属性类型
            switch (dataType)
            {
                case "bigint":
                    return "long";

                case "bigserial":
                    return "long";

                case "bit":
                    return "bool";

                case "boolean":
                    return "bool";

                case "box":
                    return "object";

                case "bytea":
                    return "byte[]";

                case "character":
                    return "string";

                case "character varying":
                    return "string";

                case "cid":
                    return "uint";

                case "cidr":
                    return "object";

                case "circle":
                    return "object";

                case "date":
                    return "DateTime";

                case "daterange":
                    return "object";

                case "decimal":
                    return "decimal";

                case "double precision":
                    return "double";

                case "float4":
                    return "float";

                case "float8":
                    return "double";

                case "inet":
                    return "object";

                case "int":
                    return "int";

                case "int2":
                    return "short";

                case "int4":
                    return "int";

                case "int8":
                    return "long";

                case "integer":
                    return "int";

                case "interval":
                    return "TimeSpan";

                case "json":
                    return "object";

                case "jsonb":
                    return "object";

                case "line":
                    return "object";

                case "lseg":
                    return "object";

                case "macaddr":
                    return "object";

                case "money":
                    return "decimal";

                case "numeric":
                    return "decimal";

                case "oid":
                    return "uint";

                case "path":
                    return "object";

                case "point":
                    return "object";

                case "polygon":
                    return "object";

                case "real":
                    return "float";

                case "serial":
                    return "int";

                case "serial2":
                    return "short";

                case "serial4":
                    return "int";

                case "serial8":
                    return "long";

                case "smallint":
                    return "short";

                case "smallserial":
                    return "short";

                case "text":
                    return "string";

                case "time":
                    return "TimeSpan";

                case "time with time zone":
                    return "DateTimeOffset";

                case "timestamp":
                    return "DateTime";

                case "timestamp with time zone":
                    return "DateTimeOffset";

                case "tsquery":
                    return "object";

                case "tsvector":
                    return "object";

                case "txid_snapshot":
                    return "object";

                case "uuid":
                    return "Guid";

                case "xml":
                    return "string";

                default:
                    return "object";
            }
        }

        private string GenerateEntityCode(string connectionString, string tableName, string entityName)
        {
            try
            {
                // 连接到数据库
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // 检索表的结构
                    DataTable schemaTable = connection.GetSchema("Columns", new string[] { null, null, tableName });

                    // 生成实体类代码
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("public class " + entityName);
                    sb.AppendLine("{");

                    foreach (DataRow row in schemaTable.Rows)
                    {
                        string columnName = row["column_name"].ToString();
                        string dataType = row["data_type"].ToString();

                        // 根据数据类型生成属性类型
                        string propertyType = GetPropertyType(dataType);

                        sb.AppendLine("\tpublic " + propertyType + " " + columnName + " { get; set; }");
                    }

                    sb.AppendLine("}");

                    //将代码输出到文件或复制到剪贴板中，或文本框里
                    return sb.ToString();
                }
            }
            catch (Exception)
            {
                return String.Empty;
            }
        }

        private void btnLoadTableList_Click(object sender, EventArgs e)
        {
            // 获取用户输入的参数
            connectionString = txtConnectionString.Text;
        
            try
            { // 连接到数据库
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    // 打开数据库连接
                    connection.Open();
                    // 获取所有表的列表
                    DataTable table = connection.GetSchema("Tables");

                    //清空列表数据
                    cboTableList.Items.Clear();
                    cboTableList.Text= "-请选择表-";
                    // 添加表名到下拉框
                    foreach (DataRow row in table.Rows)
                    {
                        string tableName = row["TABLE_NAME"].ToString();
                        cboTableList.Items.Add(tableName);
                    }
                }
            }
            catch (Exception ex)
                {
                    MessageBoxEx.Show(ex.Message);
                }
           
        }


        private void cboTableList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tableName = cboTableList.SelectedItem?.ToString();
            txtEntityName.Text= tableName+"Entity";
            #region 获取所选表的所有列
            //try
            //{
            //    // 获取用户输入的参数
            //    connectionString = txtConnectionString.Text;
            //    // 连接到数据库
            //    using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            //    {
            //        // 打开数据库连接
            //        connection.Open();
            //        // 获取所选表的所有列
            //        string tableName = cboTableList.SelectedItem.ToString();
            //        string sql = $"SELECT column_name FROM information_schema.columns WHERE table_name='{tableName}'";
            //        NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);
            //        NpgsqlDataReader reader = cmd.ExecuteReader();
            //        // 将所有列添加到 txtColumns 文本框中
            //        string columns = "";
            //        while (reader.Read())
            //        {
            //            columns += reader.GetString(0) + ", ";
            //        }
            //        columns = columns.TrimEnd(new char[] { ',', ' ' });
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //} 
            #endregion
        }
    }
}
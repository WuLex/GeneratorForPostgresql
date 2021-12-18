using CCWin;
using Microsoft.EntityFrameworkCore;
using NPOI.OpenXmlFormats.Wordprocessing;
using NPOI.XWPF.UserModel;
using PostgresqlGenerator.Helper;
using PostgresqlGenerator.Models;
using System.Data;
using System.Data.Common;

namespace PostgresqlGenerator
{
    public partial class DataFormMain : CCSkinMain
    {
        #region 私有

        private DataTable dataTable;

        #endregion 私有

        #region 构造方法

        public DataFormMain()
        {
            InitializeComponent();
            dataTable = new DataTable();
        }

        #endregion 构造方法

        #region 自定义方法

        private ReturnMessage CheckCnnString(string cnnString)
        {
            ReturnMessage retMsg = new ReturnMessage(string.Empty, true);

            try
            {
                using (var metaverseDbContext = new MetaverseDbContext())
                {
                    retMsg.isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                retMsg.isSuccess = false;
                retMsg.Messages = ex.Message;
                return retMsg;
            }
            finally
            {
            }

            return retMsg;
        }

        private ReturnMessage GetInfo(string cnnString)
        {
            ReturnMessage retMsg = new ReturnMessage(string.Empty, true);
            dataTable.Rows.Clear();

            #region SQL语句

            string strQuery = @"";

            //数据表每个字段都需要写字段说明
            string query = " SELECT A.attnum AS \"字段序号\","
                                       // + "		   C.relname AS \"表名\","
                                       + "		   CASE WHEN A.attnum = 1 THEN C.relname ELSE '' END AS \"表名\","
                                       + "		   CAST ( obj_description ( relfilenode, \'pg_class\' ) AS VARCHAR ) AS \"表名描述\","
                                       + "			A.attname AS \"字段名\","
                                       + "		CASE"
                                       + "				A.attnotnull "
                                       + "				WHEN \'t\' THEN"
                                       + "				\'是\' "
                                       + "				WHEN \'f\' THEN"
                                       + "				\'否\' "
                                       + "			END AS 是否必填,"
                                       + "			concat_ws ( \'\', T.typname, SUBSTRING ( format_type ( A.atttypid, A.atttypmod ) FROM \'\\(.*\\)\' ) ) AS \"数据类型\","
                                       + "			d.description AS \"字段说明\" "
                                       + "		FROM"
                                       + "			pg_class C,"
                                       + "			pg_attribute A,"
                                       + "			pg_type T,"
                                       + "			pg_description d "
                                       + "		WHERE C.relname IN (select relname as tabname  from pg_class cc  where  relkind = \'r\' and relname not like \'pg_%\' and relname not like \'sql_%\' order by relname)"
                                       + "			AND A.attnum > 0 "
                                       + "			AND A.attrelid = C.oid "
                                       + "			AND A.atttypid = T.oid "
                                       + "			AND d.objoid = A.attrelid "
                                       + "			AND d.objsubid = A.attnum;";

            #endregion SQL语句

            using (var _metaverseDbContext = new MetaverseDbContext())
            {
                //获取数据库的上下文连接
                Console.WriteLine(_metaverseDbContext.Database);
                var conn = _metaverseDbContext.Database.GetDbConnection();
                conn.ConnectionString = cnnString;

                //var  contextid=  _metaverseDbContext.ContextId;
                //conn.Database.GetDbConnection().ConnectionString =”数据库连接字符串”;
                try
                {
                    //打开数据库连接
                    conn.Open();
                    //建立连接，因为非委托资源，所以需要使用using进行内存资源的释放
                    using (var command = conn.CreateCommand())
                    {
                        command.CommandText = query; //赋值需要执行的SQL语句

                        #region SqlDataAdapter方式

                        DbDataAdapter adapter = DbProviderFactories.GetFactory(conn).CreateDataAdapter();
                        if (adapter != null)
                        {
                            adapter.SelectCommand = command;
                            adapter.Fill(dataTable);
                        }

                        dgvData.DataSource = dataTable;

                        #endregion SqlDataAdapter方式

                        #region DbDataReader方式

                        //DbDataReader reader = await command.ExecuteReaderAsync();
                        ////执行命令
                        //if (reader.HasRows)//判断是否有返回行
                        //{       //读取行数据，将返回值填充到视图模型中
                        //    while (await reader.ReadAsync())
                        //    {
                        //        var row = new EnrollmentDateGroupDto
                        //        {
                        //            EnrollmentDate = reader.GetDateTime(0),
                        //            StudentCount = reader.GetInt32(1)
                        //        };
                        //        //groups.Add(row);
                        //    }
                        //}
                        ////释放使用的所有资源
                        //reader.Dispose();

                        #endregion DbDataReader方式 
                    }

                    return retMsg;
                }
                catch (Exception ex)
                {
                    retMsg.isSuccess = false;
                    retMsg.Messages = ex.Message;
                    return retMsg;
                }
                finally
                {
                    //关闭数据库连接
                    conn.Close();
                }
            }

            #region Ado.net方式
            //try
            //{
            //    #region 加载数据

            //    SqlDataAdapter da = new SqlDataAdapter(strQry, cnnString);
            //    da.Fill(dataTable);
            //    dgvData.DataSource = dataTable;

            //    #endregion 加载数据

            //    return retMsg;
            //}
            //catch (Exception ex)
            //{
            //    retMsg.isSuccess = false;
            //    retMsg.Messages = ex.Message;
            //    return retMsg;
            //} 
            #endregion
        }

        private ReturnMessage WriteDoc()
        {
            ReturnMessage retMsg = new ReturnMessage(string.Empty, true);
            FileStream fs = null;
            try
            {
                XWPFDocument doc = new XWPFDocument();
                XWPFTable? table = null;
                int index = 1;
                //把内存中的DataTable写到Docx文件里
                foreach (DataRow dr in dataTable.Rows)
                {
                    if (dr["表名"] != DBNull.Value && !string.IsNullOrEmpty(dr["表名"].ToString()))
                    {
                        //表名，以段落表示
                        CT_P ctp = doc.Document.body.AddNewP();
                        //XWPFParagraph p = doc.CreateParagraph();
                        XWPFParagraph p = new XWPFParagraph(ctp, doc);
                        XWPFRun r = p.CreateRun();
                        //设置字体
                        r.GetCTR().AddNewRPr().AddNewRFonts().ascii = "宋体";
                        r.GetCTR().AddNewRPr().AddNewRFonts().eastAsia = "宋体";
                        r.GetCTR().AddNewRPr().AddNewRFonts().hint = ST_Hint.eastAsia;
                        r.GetCTR().AddNewRPr().AddNewSz().val = (ulong)32; //3号字体;
                        r.GetCTR().AddNewRPr().AddNewSzCs().val = (ulong)32;
                        //设置行间距
                        //单倍为默认值（240twip）不需设置，1.5倍=240X1.5=360twip，2倍=240X2=480twip
                        ctp.AddNewPPr().AddNewSpacing().line = "720";
                        //ctp.AddNewPPr().AddNewSpacing().lineRule = ST_LineSpacingRule.exact;
                        //设置段落文本
                        r.SetText(index.ToString() + "." + dr["表名"].ToString());

                        //表结构，以表格显示
                        CT_Tbl m_CTTbl = doc.Document.body.AddNewTbl();
                        table = doc.CreateTable(1, dr.ItemArray.Length);
                        //标题行(固定)
                        //列宽
                        CT_TcPr mPr = table.GetRow(0).GetCell(0).GetCTTc().AddNewTcPr();
                        mPr.tcW = new CT_TblWidth { w = "900", type = ST_TblWidth.dxa };
                        mPr = table.GetRow(0).GetCell(1).GetCTTc().AddNewTcPr();
                        mPr.tcW = new CT_TblWidth { w = "1500", type = ST_TblWidth.dxa };
                        mPr = table.GetRow(0).GetCell(2).GetCTTc().AddNewTcPr();
                        mPr.tcW = new CT_TblWidth { w = "500", type = ST_TblWidth.dxa };
                        mPr = table.GetRow(0).GetCell(3).GetCTTc().AddNewTcPr();
                        mPr.tcW = new CT_TblWidth { w = "1000", type = ST_TblWidth.dxa };
                        mPr = table.GetRow(0).GetCell(4).GetCTTc().AddNewTcPr();
                        mPr.tcW = new CT_TblWidth { w = "500", type = ST_TblWidth.dxa };
                        mPr = table.GetRow(0).GetCell(5).GetCTTc().AddNewTcPr();
                        mPr.tcW = new CT_TblWidth { w = "900", type = ST_TblWidth.dxa };
                        mPr = table.GetRow(0).GetCell(6).GetCTTc().AddNewTcPr();
                        mPr.tcW = new CT_TblWidth { w = "800", type = ST_TblWidth.dxa };
                        //mPr = table.GetRow(0).GetCell(7).GetCTTc().AddNewTcPr();
                        //mPr.tcW = new CT_TblWidth {w = "1500", type = ST_TblWidth.dxa};
                        //填充文字
                        table.GetRow(0).GetCell(0).SetText("字段序号");
                        table.GetRow(0).GetCell(1).SetText("表名");
                        table.GetRow(0).GetCell(2).SetText("表名描述");
                        table.GetRow(0).GetCell(3).SetText("字段名");
                        //table.GetRow(0).GetCell(2).SetText("主键");
                        table.GetRow(0).GetCell(4).SetText("是否必填");
                        table.GetRow(0).GetCell(5).SetText("数据类型");
                        table.GetRow(0).GetCell(6).SetText("字段说明");
                        //内容行
                        XWPFTableRow row = table.CreateRow();
                        row.GetCell(0).SetText(dr["字段序号"].ToString());
                        row.GetCell(1).SetText(dr["表名"].ToString());
                        row.GetCell(2).SetText(dr["表名描述"].ToString());
                        row.GetCell(3).SetText(dr["字段名"].ToString());
                        //row.GetCell(2).SetText(dr["主键"].ToString());
                        row.GetCell(4).SetText(dr["是否必填"].ToString());
                        row.GetCell(5).SetText(dr["数据类型"].ToString());
                        row.GetCell(6).SetText(dr["字段说明"].ToString());
                        //
                        index++;
                    }
                    else
                    {
                        if (table != null)
                        {
                            //内容行
                            XWPFTableRow row = table.CreateRow();
                            row.GetCell(0).SetText(dr["字段序号"].ToString());
                            row.GetCell(1).SetText(dr["字段名"].ToString());
                            row.GetCell(2).SetText(dr["表名描述"].ToString());
                            row.GetCell(3).SetText(dr["字段名"].ToString());
                            //row.GetCell(2).SetText(dr["主键"].ToString());
                            row.GetCell(4).SetText(dr["是否必填"].ToString());
                            row.GetCell(5).SetText(dr["数据类型"].ToString());
                            row.GetCell(6).SetText(dr["字段说明"].ToString());
                        }
                    }
                }

                //输出保存
                string docAllPath = Application.StartupPath + "\\SqlDBDicFile.docx";
                if (File.Exists(docAllPath))
                {
                    File.Delete(docAllPath);
                }

                fs = File.OpenWrite(docAllPath);
                doc.Write(fs);
                doc.Close();
                return retMsg;
            }
            catch (Exception ex)
            {
                retMsg.isSuccess = false;
                retMsg.Messages = ex.Message;
                return retMsg;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                    fs.Dispose();
                }
            }
        }

        #endregion 自定义方法

        #region 按钮点击事件

        private void btnBulid_Click(object sender, EventArgs e)
        {
            Cursor currCursor = this.Cursor;
            this.Cursor = Cursors.WaitCursor;

            ReturnMessage retMsg = CheckCnnString(txtCnnString.Text.Trim());
            if (!retMsg.isSuccess)
            {
                MessageBoxEx.Show("数据库连接字符串错误，信息为：" + retMsg.Messages, "", MessageBoxButtons.OK);
                this.Cursor = currCursor;
                return;
            }

            retMsg = GetInfo(txtCnnString.Text.Trim());
            if (!retMsg.isSuccess)
            {
                MessageBoxEx.Show("读取数据库表结构错误，信息为：" + retMsg.Messages, "", MessageBoxButtons.OK);
                this.Cursor = currCursor;
                return;
            }

            retMsg = WriteDoc();
            if (retMsg.isSuccess)
            {
                MessageBoxEx.Show("Word文档生成成功!请在程序根目录查找文档!", "", MessageBoxButtons.OK);
            }
            else
            {
                MessageBoxEx.Show("Word文档生成失败，信息为：" + retMsg.Messages, "", MessageBoxButtons.OK);
            }

            this.Cursor = currCursor;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            #region 验证连接是否正确
            Cursor currCursor = this.Cursor;
            this.Cursor = Cursors.WaitCursor;

            ReturnMessage retMsg = CheckCnnString(txtCnnString.Text.Trim());
            if (!retMsg.isSuccess)
            {
                MessageBoxEx.Show("数据库连接字符串错误，信息为：" + retMsg.Messages, "", MessageBoxButtons.OK);
                this.Cursor = currCursor;
                return;
            }

            retMsg = GetInfo(txtCnnString.Text.Trim());
            if (!retMsg.isSuccess)
            {
                MessageBoxEx.Show("读取数据库表结构错误，信息为：" + retMsg.Messages, "", MessageBoxButtons.OK);
                this.Cursor = currCursor;
                return;
            }
            #endregion

            #region 导出数据
            DataSet ds = new DataSet();
            ds.Tables.Add(dataTable);
            retMsg = ExeclHelper.DataSetToExcel(ds);
            if (retMsg.isSuccess)
            {
                MessageBoxEx.Show("Excel文档生成成功!请在程序根目录查找文档!","",MessageBoxButtons.OK);
            }
            else
            {
                MessageBoxEx.Show("Excel文档生成失败，信息为：" + retMsg.Messages, "", MessageBoxButtons.OK);
            }

            this.Cursor = currCursor;
            #endregion
        }

        #endregion 按钮点击事件


    }
}
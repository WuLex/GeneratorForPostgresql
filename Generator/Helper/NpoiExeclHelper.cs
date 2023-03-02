using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgresqlGenerator.Helper
{
    /// <summary>
    /// Class ExeclHelper.
    /// </summary>
    public class ExeclHelper
    {
        /// <summary>
        /// Datas the set to excel.
        /// </summary>
        /// <param name="ds">The ds.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static ReturnMessage DataSetToExcel(DataSet ds)
        {
            //返回对象
            ReturnMessage retMsg = new ReturnMessage(string.Empty, true);

            try
            {
                string fileName = "DBDictionary-"+DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".xlsx";
                //string urlPath = "Upload/ExcelFiles/";
                //string filePath =  HttpContext.Current.Server.MapPath("\\" + urlPath);  //Web取路径
                string filePath = Application.StartupPath + "\\Upload\\";
                Directory.CreateDirectory(filePath);
                string Path = filePath + fileName;

                FileStream? fs = null;
                XSSFWorkbook workbook = new XSSFWorkbook();
                for (int i = 0; i < ds.Tables.Count; i++)
                {
                    XSSFSheet sheet = (XSSFSheet)workbook.CreateSheet(ds.Tables[i].TableName);
                    XSSFCellStyle dateStyle = (XSSFCellStyle)workbook.CreateCellStyle();
                    XSSFDataFormat format = (XSSFDataFormat)workbook.CreateDataFormat();
                    dateStyle.DataFormat = format.GetFormat("yyyy-mm-dd");

                    int rowIndex = 0;

                    #region 新建表，填充表头，填充列头，样式

                    if (rowIndex == 0)
                    {
                        #region 列头及样式

                        XSSFRow headerRow = (XSSFRow)sheet.CreateRow(0);
                        XSSFCellStyle headStyle = (XSSFCellStyle)workbook.CreateCellStyle();
                        headStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;

                        XSSFFont font = (XSSFFont)workbook.CreateFont();
                        font.FontHeightInPoints = 12;
                        font.Boldweight = 700;
                        headStyle.SetFont(font);
                        //自定义表头
                        for (var j = 0; j < ds.Tables[i].Columns.Count; j++)
                        {
                            sheet.SetColumnWidth(j, 30 * 256);
                            headerRow.CreateCell(j).SetCellValue(ds.Tables[i].Columns[j].ColumnName);
                            headerRow.GetCell(j).CellStyle = headStyle;
                        }

                        #endregion

                        rowIndex = 1;
                    }

                    #endregion
                    ICellStyle cellstyle = workbook.CreateCellStyle();
                    cellstyle.VerticalAlignment = VerticalAlignment.Center;
                    cellstyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                    foreach (DataRow row in ds.Tables[i].Rows)
                    {
                        XSSFRow dataRow = (XSSFRow)sheet.CreateRow(rowIndex);

                        #region 填充内容

                        foreach (DataColumn column in ds.Tables[i].Columns)
                        {
                            XSSFCell newCell = (XSSFCell)dataRow.CreateCell(column.Ordinal);
                            string? type = row[column].GetType()?.FullName;
                            newCell.SetCellValue(GetValue(row[column]?.ToString(), type));
                            newCell.CellStyle = cellstyle;
                        }

                        #endregion

                        rowIndex++;
                    }
                }

                using (fs = File.OpenWrite(Path))
                {
                    workbook.Write(fs);

                    retMsg.isSuccess = true;
                    retMsg.Messages = Path;
                    return retMsg;
                }
            }
            catch
            {
                retMsg.isSuccess = false;
                retMsg.Messages = "";
                return retMsg;
                //return "";
            }
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <param name="cellValue">The cell value.</param>
        /// <param name="type">The type.</param>
        /// <returns>System.String.</returns>
        private static string? GetValue(string cellValue, string type)
        {
            object value = string.Empty;
            switch (type)
            {
                case "System.String"://字符串类型
                    value = cellValue;
                    break;
                case "System.DateTime"://日期类型
                    System.DateTime dateV;
                    System.DateTime.TryParse(cellValue, out dateV);
                    value = dateV;
                    break;
                case "System.Boolean"://布尔型
                    bool boolV = false;
                    bool.TryParse(cellValue, out boolV);
                    value = boolV;
                    break;
                case "System.Int16"://整型
                case "System.Int32":
                case "System.Int64":
                case "System.Byte":
                    int intV = 0;
                    int.TryParse(cellValue, out intV);
                    value = intV;
                    break;
                case "System.Decimal"://浮点型
                case "System.Double":
                    double doubV = 0;
                    double.TryParse(cellValue, out doubV);
                    value = doubV;
                    break;
                case "System.DBNull"://空值处理
                    value = string.Empty;
                    break;
                default:
                    value = string.Empty;
                    break;
            }
            return value?.ToString();
        }
    }
}

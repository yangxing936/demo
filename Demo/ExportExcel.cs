using NPOI.HPSF;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public static class ExportExcel
    {
         /// <summary>
        /// 导出Excel
         /// </summary>
         /// <param name="data"></param>
         /// <param name="fileName"></param>
         /// <param name="sheetName"></param>
         /// <returns></returns>
        public static bool ExportToHSSFExcelFromDataTable(DataTable data, string fileName, string sheetName)
        {
            try
            {


                HSSFWorkbook workbook = new HSSFWorkbook();
                ISheet sheet = workbook.CreateSheet(sheetName);
                IRow rowHead = sheet.CreateRow(0);

                //填写表头
                for (int i = 0; i < data.Columns.Count; i++)
                {
                    rowHead.CreateCell(i, CellType.String).SetCellValue(data.Columns[i].ToString());
                }
                //填写内容
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    IRow row = sheet.CreateRow(i + 1);
                    for (int j = 0; j < data.Columns.Count; j++)
                    {
                        row.CreateCell(j, CellType.String).SetCellValue(data.Rows[i][j].ToString());
                    }
                }

                using (FileStream stream = File.OpenWrite(fileName))
                {
                    workbook.Write(stream);
                    stream.Close();
                }

             
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool ExportToXSSFExcelFromDataTable(DataTable data, string fileName, string sheetName)
        {
            try
            {


                XSSFWorkbook workbook = new XSSFWorkbook();
                ISheet sheet = workbook.CreateSheet(sheetName);
                IRow rowHead = sheet.CreateRow(0);

                //填写表头
                for (int i = 0; i < data.Columns.Count; i++)
                {
                    rowHead.CreateCell(i, CellType.String).SetCellValue(data.Columns[i].ToString());
                }
                //填写内容
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    IRow row = sheet.CreateRow(i + 1);
                    for (int j = 0; j < data.Columns.Count; j++)
                    {
                        row.CreateCell(j, CellType.String).SetCellValue(data.Rows[i][j].ToString());
                    }
                }

                using (FileStream stream = File.OpenWrite(fileName))
                {
                    workbook.Write(stream);
                    stream.Close();
                }


                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

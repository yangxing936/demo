using System;
using System.Data;
using System.IO;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace Demo
{
    public static class ExcelHelper
    {

        private static IWorkbook GetWorkBook(string fileFullName, FileStream fs)
        {
            IWorkbook workbook = null;
            try
            {
                if (fileFullName.IndexOf(".xlsx", StringComparison.Ordinal) > 0) // 2007版本
                    workbook = new XSSFWorkbook(fs);
                else if (fileFullName.IndexOf(".xls", StringComparison.Ordinal) > 0) // 2003版本
                    workbook = new HSSFWorkbook(fs);
            }
            catch (Exception e)
            {
                workbook = null;
            }

            return workbook;
        }

        // <summary>
        // 将excel中的数据导入到DataTable中
        // </summary>
        // <param name="sheetName">excel工作薄sheet的名称</param>
        // <param name="isFirstRowColumn">第一行是否是DataTable的列名</param>
        // <param name="errorMsg"></param>
        // <returns>返回的DataTable</returns>
        public static DataTable ExcelToDataTable(string fileFullName, string sheetName, int sheetIndex, bool isFirstRowColumn, out string errorMsg)
        {
            errorMsg = "";
            DataTable data = new DataTable();
            try
            {

                using (FileStream fs = File.Open(fileFullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    IWorkbook workbook = GetWorkBook(fileFullName, fs);
                    ISheet sheet = null;

                    if (!string.IsNullOrWhiteSpace(sheetName) && workbook != null)
                    {
                        sheet = workbook.GetSheet(sheetName) ?? workbook.GetSheetAt(sheetIndex);
                    }
                    if (sheet != null)
                    {
                        IRow firstRow = sheet.GetRow(0);
                        int cellCount = firstRow.LastCellNum; //一行最后一个cell的编号 即总的列数

                        var startRow = 0;
                        if (isFirstRowColumn)
                        {
                            for (int i = firstRow.FirstCellNum; i < cellCount; ++i)
                            {
                                ICell cell = firstRow.GetCell(i);
                                string cellValue = cell?.StringCellValue;
                                if (cellValue != null)
                                {
                                    DataColumn column = new DataColumn(cellValue);
                                    data.Columns.Add(column);
                                }
                            }
                            startRow = sheet.FirstRowNum + 1;
                        }
                        else
                        {
                            startRow = sheet.FirstRowNum;
                        }

                        //最后一列的标号
                        int rowCount = sheet.LastRowNum;
                        for (int i = startRow; i <= rowCount; ++i)
                        {
                            IRow row = sheet.GetRow(i);
                            if (row == null) continue; //没有数据的行默认是null　　　　　　　

                            DataRow dataRow = data.NewRow();
                            for (int j = row.FirstCellNum; j < cellCount; ++j)
                            {
                                var cell = row.GetCell(j, MissingCellPolicy.RETURN_NULL_AND_BLANK);
                                if (cell != null)
                                {
                                    try
                                    {
                                        switch (cell.CellType)
                                        {
                                            case CellType.Blank:
                                                dataRow[j] = cell.ToString();
                                                break;
                                            case CellType.Boolean:
                                                dataRow[j] = cell.BooleanCellValue;
                                                break;
                                            case CellType.Error:
                                                dataRow[j] = cell.ErrorCellValue;
                                                break;
                                            case CellType.Formula:
                                                dataRow[j] = cell.StringCellValue;
                                                break;
                                            case CellType.String:
                                                dataRow[j] = cell.StringCellValue;
                                                break;
                                            case CellType.Unknown:
                                                dataRow[j] = cell.ToString();
                                                break;
                                            case CellType.Numeric:
                                                dataRow[j] = cell.NumericCellValue;
                                                break;
                                            default:
                                                dataRow[j] = cell.ToString();
                                                break;
                                        }
                                    }
                                    catch (Exception e)
                                    {
                                        dataRow[j] = "error";
                                    }

                                }
                            }
                            data.Rows.Add(dataRow);
                        }
                    }
                    else
                    {
                        throw new Exception($"未找到符合名称的工作簿[{sheetName}]");
                    }

                    return data;
                }
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;
                return null;
            }
        }

        /// <summary>
        /// 获取第一行第一列的值
        /// </summary>
        /// <param name="fileFullName"></param>
        /// <param name="sheetName"></param>
        /// <param name="errorMsg"></param>
        /// <returns></returns>
        public static string ExecuteScalar(string fileFullName, string sheetName, out string errorMsg)
        {
            errorMsg = "";
            try
            {
                using (FileStream fs = File.Open(fileFullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    IWorkbook workbook = GetWorkBook(fileFullName, fs);

                    ISheet sheet = null;
                    if (!string.IsNullOrWhiteSpace(sheetName) && workbook != null)
                    {
                        sheet = workbook.GetSheet(sheetName);
                    }
                    if (sheet != null)
                    {
                        IRow firstRow = sheet.GetRow(0);
                        ICell cell = firstRow.GetCell(0);
                        string cellValue = cell?.StringCellValue;
                        if (cellValue != null)
                        {
                            return cellValue;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                errorMsg = e.Message;
            }
            return null;
        }

        /// <summary>
        /// 获取第一行第一列的值
        /// </summary>
        /// <param name="fileFullName"></param>
        /// <param name="sheetIndex"></param>
        /// <param name="errorMsg"></param>
        /// <returns></returns>
        public static string ExecuteScalar(string fileFullName, int sheetIndex, out string errorMsg)
        {
            errorMsg = "";
            try
            {
                using (FileStream fs = File.Open(fileFullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    IWorkbook workbook = GetWorkBook(fileFullName, fs);

                    ISheet sheet = null;
                    if (sheetIndex >= 0 && workbook != null)
                    {
                        sheet = workbook.GetSheetAt(0);
                    }
                    if (sheet != null)
                    {
                        IRow firstRow = sheet.GetRow(0);
                        ICell cell = firstRow.GetCell(0);
                        string cellValue = cell?.StringCellValue;
                        if (cellValue != null)
                        {
                            return cellValue;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                errorMsg = e.Message;
            }
            return null;
        }


        /// <summary>
        /// 获取某行某的值
        /// </summary>
        /// <param name="fileFullName"></param>
        /// <param name="sheetIndex"></param>
        /// <param name="rowId"></param>
        /// <param name="errorMsg"></param>
        /// <param name="colId"></param>
        /// <returns></returns>
        public static string ExecuteScalar(string fileFullName, int sheetIndex, int rowId, int colId, out string errorMsg)
        {
            errorMsg = "";
            try
            {
                using (FileStream fs = File.Open(fileFullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    IWorkbook workbook = GetWorkBook(fileFullName, fs);

                    ISheet sheet = null;
                    if (sheetIndex >= 0 && workbook != null)
                    {
                        sheet = workbook.GetSheetAt(0);
                    }
                    if (sheet != null)
                    {
                        IRow firstRow = sheet.GetRow(rowId);
                        ICell cell = firstRow.GetCell(colId);
                        //string cellValue = cell?.StringCellValue;
                        object value = "";
                        if (cell != null)
                        {
                            switch (cell.CellType)
                            {
                                case CellType.Blank:
                                    value = cell.ToString();
                                    break;
                                case CellType.Boolean:
                                    value = cell.BooleanCellValue;
                                    break;
                                case CellType.Error:
                                    value = cell.ErrorCellValue;
                                    break;
                                case CellType.Formula:
                                    value = cell.StringCellValue;
                                    break;
                                case CellType.String:
                                    value = cell.StringCellValue;
                                    break;
                                case CellType.Unknown:
                                    value = cell.ToString();
                                    break;
                                case CellType.Numeric:
                                    value = cell.NumericCellValue;
                                    break;
                                default:
                                    value = cell.ToString();
                                    break;
                            }
                            return value.ToString();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                errorMsg = e.Message;
            }
            return null;
        }

        // <summary>
        // 将excel中的数据导入到DataTable中
        // </summary>
        // <param name="sheetName">excel工作薄sheet的名称</param>
        // <param name="isFirstRowColumn">第一行是否是DataTable的列名</param>
        // <param name="errorMsg"></param>
        // <returns>返回的DataTable</returns>
        public static DataTable ExcelToDataTable(string fileFullName, string sheetName, int firstRowId, out string errorMsg)
        {
            errorMsg = "";
            DataTable data = new DataTable();
            try
            {
                using (FileStream fs = File.Open(fileFullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    IWorkbook workbook = GetWorkBook(fileFullName, fs);
                    ISheet sheet = null;
                    if (!string.IsNullOrWhiteSpace(sheetName) && workbook != null)
                    {
                        sheet = workbook.GetSheet(sheetName);
                    }

                    if (sheet != null)
                    {
                        IRow firstRow = sheet.GetRow(firstRowId);
                        if (firstRow == null)
                        {
                            throw new Exception("Excel表格式不正确。");
                        }
                        int cellCount = firstRow.LastCellNum; //一行最后一个cell的编号 即总的列数
                        for (int i = firstRow.FirstCellNum; i < cellCount; ++i)
                        {
                            ICell cell = firstRow.GetCell(i);
                            string cellValue = cell?.StringCellValue;
                            if (cellValue != null)
                            {
                                DataColumn column = new DataColumn(cellValue);
                                switch (cell.CellType)
                                {
                                    case CellType.Blank:
                                    case CellType.Error:
                                    case CellType.Formula:
                                    case CellType.String:
                                    case CellType.Unknown:
                                        column.DataType = typeof(string);
                                        break;
                                    case CellType.Boolean:
                                        column.DataType = typeof(bool);
                                        break;
                                    case CellType.Numeric:
                                        column.DataType = typeof(decimal);
                                        break;
                                    default:
                                        column.DataType = typeof(string);
                                        break;
                                }
                                data.Columns.Add(column);
                            }
                        }
                        int startRow = firstRowId + 1;

                        //最后一列的标号
                        int rowCount = sheet.LastRowNum;
                        for (int i = startRow; i <= rowCount; ++i)
                        {
                            IRow row = sheet.GetRow(i);
                            if (row == null) continue; //没有数据的行默认是null　　　　　　　

                            DataRow dataRow = data.NewRow();
                            for (int j = row.FirstCellNum; j < cellCount; ++j)
                            {
                                try
                                {
                                    var cell = row.GetCell(j, MissingCellPolicy.RETURN_NULL_AND_BLANK);
                                    if (cell != null)
                                    {
                                        try
                                        {
                                            switch (cell.CellType)
                                            {
                                                case CellType.Boolean:
                                                    dataRow[j] = cell.BooleanCellValue;
                                                    break;
                                                case CellType.Error:
                                                    dataRow[j] = cell.ErrorCellValue;
                                                    break;
                                                case CellType.Formula:
                                                case CellType.String:
                                                    dataRow[j] = cell.StringCellValue;
                                                    break;
                                                case CellType.Blank:
                                                case CellType.Unknown:
                                                    dataRow[j] = cell.ToString();
                                                    break;
                                                case CellType.Numeric:
                                                    dataRow[j] = cell.NumericCellValue;
                                                    break;
                                                default:
                                                    dataRow[j] = cell.ToString();
                                                    break;
                                            }
                                        }
                                        catch (Exception)
                                        {
                                            dataRow[j] = "";
                                        }
                                    }
                                }
                                catch (Exception e)
                                {
                                    dataRow[j] = "";
                                }
                            }
                            data.Rows.Add(dataRow);
                        }
                    }
                    else
                    {
                        throw new Exception($"未找到符合名称的工作簿[{sheetName}]");
                    }

                    return data;
                }
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;
                return null;
            }
        }


        // <summary>
        // 将excel中的数据导入到DataTable中
        // </summary>
        // <param name="sheetName">excel工作薄sheet的名称</param>
        // <param name="isFirstRowColumn">第一行是否是DataTable的列名</param>
        // <param name="errorMsg"></param>
        // <returns>返回的DataTable</returns>
        public static DataTable ExcelToDataTable(string fileFullName, uint sheetIndex, int firstRowId, out string errorMsg)
        {
            errorMsg = "";
            DataTable data = new DataTable();
            try
            {

                using (FileStream fs = File.Open(fileFullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    IWorkbook workbook = GetWorkBook(fileFullName, fs);
                    ISheet sheet = null;
                    if (workbook != null)
                    {
                        sheet = workbook.GetSheetAt((int)sheetIndex);
                    }

                    if (sheet != null)
                    {
                        IRow firstRow = sheet.GetRow(firstRowId);
                        if (firstRow == null)
                        {
                            throw new Exception("Excel表格式不正确。");
                        }
                        int cellCount = firstRow.LastCellNum; //一行最后一个cell的编号 即总的列数
                        for (int i = firstRow.FirstCellNum; i < cellCount; ++i)
                        {
                            ICell cell = firstRow.GetCell(i);
                            string cellValue = (cell?.CellType == CellType.Numeric ? cell.NumericCellValue.ToString() : cell.StringCellValue);
                            if (cellValue != null)
                            {
                                DataColumn column = new DataColumn(cellValue);
                                switch (cell.CellType)
                                {
                                    case CellType.Blank:
                                    case CellType.Error:
                                    case CellType.Formula:
                                    case CellType.String:
                                    case CellType.Unknown:
                                        column.DataType = typeof(string);
                                        break;
                                    case CellType.Boolean:
                                        column.DataType = typeof(bool);
                                        break;
                                    case CellType.Numeric:
                                        column.DataType = typeof(decimal);
                                        break;
                                    default:
                                        column.DataType = typeof(string);
                                        break;
                                }
                                data.Columns.Add(column);
                            }
                        }
                        int startRow = firstRowId + 1;

                        //最后一列的标号
                        int rowCount = sheet.LastRowNum;
                        for (int i = startRow; i <= rowCount; ++i)
                        {
                            IRow row = sheet.GetRow(i);
                            if (row == null) continue; //没有数据的行默认是null　　　　　　　

                            DataRow dataRow = data.NewRow();
                            for (int j = row.FirstCellNum; j < cellCount; ++j)
                            {
                                try
                                {
                                    var cell = row.GetCell(j, MissingCellPolicy.RETURN_NULL_AND_BLANK);
                                    if (cell != null)
                                    {
                                        try
                                        {
                                            switch (cell.CellType)
                                            {
                                                case CellType.Boolean:
                                                    dataRow[j] = cell.BooleanCellValue;
                                                    break;
                                                case CellType.Error:
                                                    dataRow[j] = cell.ErrorCellValue;
                                                    break;
                                                case CellType.Formula:
                                                case CellType.String:
                                                    dataRow[j] = cell.StringCellValue;
                                                    break;
                                                case CellType.Blank:
                                                case CellType.Unknown:
                                                    dataRow[j] = cell.ToString();
                                                    break;
                                                case CellType.Numeric:
                                                    dataRow[j] = cell.NumericCellValue;
                                                    break;
                                                default:
                                                    dataRow[j] = cell.ToString();
                                                    break;
                                            }
                                        }
                                        catch (Exception)
                                        {
                                            dataRow[j] = "";
                                        }
                                    }
                                }
                                catch (Exception e)
                                {
                                    dataRow[j] = "";
                                }

                            }
                            data.Rows.Add(dataRow);
                        }
                    }
                    else
                    {
                        throw new Exception($"未找到符合名称的工作簿[{sheetIndex}]");
                    }

                    return data;
                }
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;
                return null;
            }
        }
    }
}

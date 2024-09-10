using OfficeOpenXml;

namespace SAFV.Helper.TestData
{
    internal class DataSet
    {
        private readonly ColumnList columnList;

        // Constructor to initialize DataSet with a ColumnList instance.
        public DataSet(ColumnList columnList)
        {
            this.columnList = columnList;
        }

        // Method to read data from an Excel file and return it as a list of dictionaries.
        public List<Dictionary<string, string>> ReadData(string filePath)
        {
            var dataList = new List<Dictionary<string, string>>();

            // If you use EPPlus in a noncommercial context
            // according to the Polyform Noncommercial license:
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            // Load the Excel file.
            var fileInfo = new FileInfo(filePath);
            using (var package = new ExcelPackage(fileInfo))
            {
                // Check if the worksheet exists.
                if (package.Workbook.Worksheets.Count < 1)
                {
                    throw new Exception("No worksheets found in the Excel file.");
                }

                // Access the first worksheet.
                var worksheet = package.Workbook.Worksheets[0];

                var rowCount = worksheet.Dimension.Rows;
                var colCount = worksheet.Dimension.Columns;

                var headers = new Dictionary<int, string>();

                // Read the header row to identify columns.
                for (var col = 1; col <= colCount; col++)
                {
                    var headerText = worksheet.Cells[1, col].Text.Trim();
                    var columnKey = columnList.GetColumnKey(headerText);
                    if (columnKey != null)
                    {
                        headers[col] = columnKey;
                    }
                }

                // Read the data rows.
                for (var row = 2; rowCount >= row; row++)
                {
                    var rowData = new Dictionary<string, string>();
                    foreach (var header in headers)
                    {
                        rowData[header.Value] = worksheet.Cells[row, header.Key].Text.Trim();
                    }
                    dataList.Add(rowData);
                }
            }

            return dataList;
        }
    }
}

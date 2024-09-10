namespace SAFV.Helper.TestData
{
    internal class ColumnList
    {
        // Dictionary to store column mappings, where the key is an identifier and the value is the column name.
        private readonly Dictionary<string, string> columns;

        public ColumnList()
        {
            columns = new Dictionary<string, string>();
        }

        // Method to add a column mapping.
        public void AddColumn(string key, string columnName)
        {
            columns[key] = columnName;
        }

        // Method to get the key associated with a column name.
        public string GetColumnKey(string columnName)
        {
            foreach (var columnMapping in columns)
            {
                if (columnMapping.Value.Equals(columnName, StringComparison.OrdinalIgnoreCase))
                {
                    return columnMapping.Key;
                }
            }
            return null;
        }
    }
}

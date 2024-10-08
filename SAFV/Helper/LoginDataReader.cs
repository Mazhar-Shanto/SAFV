using SAFV.Helper.TestData;
using SAFV.Utility;

namespace SAFV.Helper
{
    internal class LoginDataReader
    {
        public static List<Dictionary<string, string>> ReadLoginData()
        {
            // Read dataset
            var loginColumnList = new ColumnList();
            loginColumnList.AddColumn("Username", "Username");
            loginColumnList.AddColumn("Password", "Password");
            loginColumnList.AddColumn("Username2", "Username2");
            loginColumnList.AddColumn("Password2", "Password2");
            loginColumnList.AddColumn("JudgeUsername", "JudgeUsername");
            loginColumnList.AddColumn("JudgePassword", "JudgePassword");

            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/login data.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(loginColumnList);
            var loginData = dataSet.ReadData(filePath);

            return loginData;
        }

        public static List<Dictionary<string, string>> ReadAdminLoginData()
        {
            // Read dataset
            var loginColumnList = new ColumnList();
            loginColumnList.AddColumn("Username", "Username");
            loginColumnList.AddColumn("Password", "Password");

            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/admin login data.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(loginColumnList);
            var loginData = dataSet.ReadData(filePath);

            return loginData;
        }
    }
}

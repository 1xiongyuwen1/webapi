using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TopSeller.Core.Common.Helper;

namespace TopSeller.Core.Repository.Sugar
{
    public class BaseDBConfig
    {
        static string sqlServerConnection = Appsettings.app(new string[] { "AppSettings", "SqlServer", "SqlServerConnection" });//获取连接字符串

        public static string ConnectionString = File.Exists(@"D:\my-file\dbCountPsw1.txt") ? File.ReadAllText(@"D:\my-file\dbCountPsw1.txt").Trim() : (!string.IsNullOrEmpty(sqlServerConnection) ? sqlServerConnection : "server=.;uid=sa;pwd=sa;database=WMBlogDB");

    }
}

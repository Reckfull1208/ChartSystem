using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartSystem.Model
{
    public class AppGloble
    {
        ///<summary>
        ///依据连接串名字connectionName返回数据连接字符串
        ///</summary>
        ///<param name="connectionName">连接串名字</param>
        ///<returns></returns>
        public static string GetConnectionStringsConfig(string connectionName)
        {
            string connectionString =
                ConfigurationManager.ConnectionStrings[connectionName].ConnectionString.ToString();
            return connectionString;
        }
    }
}

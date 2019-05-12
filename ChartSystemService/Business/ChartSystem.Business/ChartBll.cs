using ChartSystem.Business.Helper;
using ChartSystem.Data;
using ChartSystem.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartSystem.Business
{
    public class ChartBll
    {
         

        public bool Login(string UserCode, string UserPwd)
        {
            var client = new ChartDAL();
            var md5 = MD5Helper.Md5Encrypt(UserPwd);
            return client.GetAll<T_Core_User>().Where(x => x.UserCode == UserCode && x.UserPWD == UserPwd).FirstOrDefault() == null ? false : true;
        }
    }
}

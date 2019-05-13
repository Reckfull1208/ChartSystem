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
         
        /// <summary>
        /// 用户账号密码验证
        /// </summary>
        /// <param name="UserCode"></param>
        /// <param name="UserPwd"></param>
        /// <returns></returns>
        public bool Login(string UserCode, string UserPwd)
        {
            var client = new ChartDAL();
            var md5 = MD5Helper.Md5Encrypt(UserPwd);
            return client.GetAll<T_Core_User>().Where(x => x.UserCode == UserCode && x.UserPWD == UserPwd).FirstOrDefault() == null ? false : true;
        }

        /// <summary>
        /// 新增，修改用户表
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public bool ModifyUserInfo(string json)
        {
            var client = new ChartDAL();
            var entity = JsonConvert.DeserializeObject<T_Core_User>(json);
            entity.UserPWD = MD5Helper.Md5Encrypt(entity.UserPWD);
            return client.InsertOrUpdate<T_Core_User>(entity);
        }

    }
}

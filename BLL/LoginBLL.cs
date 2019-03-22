using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using Model;
using System.Data;

namespace BLL
{
    public class LoginBLL
    {
        public static DataTable SelectLogin(string id, string pwd)//判断是否登陆成功
        {
            return DAL.LoginDAL.SelectLogin(id,pwd);
        }
        public static User selectUser(int id)
        {
            return DAL.LoginDAL.SelectUser(id);
        }
        public static bool InsertLogin(string id,string pwd,User u)//判断是否添加成功
        {
            return DAL.LoginDAL.InsertLoign(id,pwd,u);
        }
    }
}

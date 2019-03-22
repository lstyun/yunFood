using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;
using System.Data;

namespace DAL
{
    public class LoginDAL
    {
        public static DataTable SelectLogin(string id,string pwd)//判断是否登陆成功
        {
            string sql = string.Format("select * from login where UserName='{0}' and possword='{1}'", id,pwd);
            return DBhelper.GetDataTable(sql);
        }
        public static User SelectUser(int id)//根据用户ID查询信息
        {
            try
            {
                string sql = string.Format("select * from [user] where UserId ={0}",id);
                User use = new User();
                DataTable t = DBhelper.GetDataTable(sql);
                use.UserId =int.Parse(t.Rows[0][0].ToString());
                use.Email = t.Rows[0][1].ToString();
                use.Phone =int.Parse(t.Rows[0][2].ToString());
                use.Address = t.Rows[0][3].ToString();
                use.Sex = t.Rows[0][4].ToString();
                use.Name = t.Rows[0][5].ToString();
                use.Img = t.Rows[0][6].ToString();
                use.Jtime =DateTime.Parse(t.Rows[0][7].ToString());
                use.GRsm = t.Rows[0][8].ToString();
                return use;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static bool InsertLoign(string id,string pwd,User u)
        {
            try
            {
                string sql = string.Format("insert login values('{0}','{1}')",id,pwd);
                string sql1 = string.Format("insert[User](Email,Phone) values('{0}', '{1}')", u.Email,u.Phone);
                if (DBhelper.ExecuteNonQuery(sql) == true && DBhelper.ExecuteNonQuery(sql1) == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}

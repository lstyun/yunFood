using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Login
    {
        public int UserId { get; set; }//ID
        public string UserName { get; set; }//账号
        public string Possword { get; set; }//密码
        public static int UserL { get; set; }//登陆状态
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class User
    {
        public int UserId { get; set; }//用户ID
        public string Email { get; set; }//邮箱
        public int Phone { get; set; }//电话
        public string Address { get; set; }//地址 
        public string Sex { get; set; }//性别
        public string Name { get; set; }//呢称
        public string Img { get; set; }//头像
        public DateTime Jtime { get; set; }//注册时间
        public string GRsm { get; set; }//个人说明
    }
}

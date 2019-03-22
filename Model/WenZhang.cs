using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class WenZhang
    {     
        public int UserId { get; set; }//发表文章用户ID
        public int Neirou { get; set; }//文章内容
        public int Imgs { get; set; }//文章图片
        public int WZ_typeId { get; set; }//文章类型ID
    }
}

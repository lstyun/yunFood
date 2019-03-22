using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class pinglun
    {
        public int PLId { get; set; }//评论ID
        public int SId { get; set; }//上级ID
        public int zId { get; set; }//最上级ID
        public int FoodId { get; set; }//食品ID
        public int UserId { get; set; }//评论用户ID
        public string Review { get; set; }//评论内容
        public DateTime PingTime { get; set; }//评论时间
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Food
    {
        public int FoodId { get; set; }//食品ID
        public string FoodName { get; set; }//食品名称
        public int F_TypeId { get; set; }//食品类型
        public string Photo { get; set; }//食品图片
        public int UserID { get; set; }//发布人ID
        public string FoodJs { get; set; }//食品介绍
    }
}

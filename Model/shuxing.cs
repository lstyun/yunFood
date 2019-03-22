using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class shuxing
    {
        public string Process { get; set; }//工艺
        public string Taste { get; set; }//口味
        public string Difficulty { get; set; }//难度
        public int N_Pren { get; set; }//人数
        public string ZBtime { get; set; }//准备时间
        public string PRtime { get; set; }//烹饪时间
        public int FoodId { get; set; }//食品ID
    }
}

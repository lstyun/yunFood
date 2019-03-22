using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FoodCL
    {
        public int FoodId { get; set; }//食品ID
        public string FoodCLM { get; set; }//材料名
        public string FoodCLT { get; set; }//材料图
        public string FoodCLS { get; set; }//材料数量
        public int ZF { get; set; }//分别主副
    }
}

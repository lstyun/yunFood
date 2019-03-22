using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class SXtype
    {
        public int SXid { get; set; }//属性 ID
        public string SXname { get; set; }//属性 名称
        public int SXids { get; set; }// 上级属性 ID
    }
}

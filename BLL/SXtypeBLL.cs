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
    public class SXtypeBLL
    {
        public static List<SXtype> SelectType(int i)
        {
            return DAL.SCCPDAL.SelectType(i);
        }
        public static List<SXtype> SelectType()
        {
            return DAL.SCCPDAL.SelectType();
        }
    }
}

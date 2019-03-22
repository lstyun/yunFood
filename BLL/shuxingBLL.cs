using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;
using DAL;

namespace BLL
{
    public class shuxingBLL
    {
        public static shuxing selectSX(int i)//查询属性数据
        {
            return DAL.shuxingDAL.selectSX(i);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;
using DAL;

namespace BLL
{
    public class FoodCLBLL
    {
        public static List<FoodCL> selectFoodCL(int id,int i)
        {
            return DAL.FoodCLDAL.selectFoodCL(id, i);
        }
    }
}

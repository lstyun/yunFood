using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using Model;

namespace BLL
{
   public class FoodTypeBLL
    {
        public static List<FoodType> selectFoodType()
        {
            return DAL.FoodTypeDAL.selectFoodType();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using DAL;
using Model;

namespace BLL
{
    public class FoodZFBLL
    {
        public static DataTable selectFoodZF(int i)
        {
            return DAL.FoodZFDAL.selectFoodZF(i);
        }
        public static List<FoodZF> SelectFoodZF()
        {
            return DAL.FoodZFDAL.SelectFoodZF();
        }
    }
}

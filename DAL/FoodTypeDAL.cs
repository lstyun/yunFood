using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;
using System.Data;

namespace DAL
{
    public class FoodTypeDAL
    {
        public static List<FoodType> selectFoodType()//查询所有食品类型信息
        {
            try
            {
                string sql = string.Format("select * from FoodType");
                DataTable dt = DBhelper.GetDataTable(sql);
                List<FoodType> list = new List<FoodType>();
                if (dt.Rows.Count >= 1 && dt != null)
                {
                    foreach (DataRow t in dt.Rows)
                    {
                        FoodType foodType = new FoodType();
                        foodType.F_TypeId= int.Parse(t["F_TypeId"].ToString());
                        foodType.F_TypeName= t["F_TypeName"].ToString();
                        list.Add(foodType);
                    }
                    return list;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

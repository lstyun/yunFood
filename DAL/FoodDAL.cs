using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;
using System.Data;

namespace DAL
{
    public class FoodDAL
    {
        public static List<Food> selectFood()//查询所有食品信息
        {
            try
            {
                string sql = string.Format("select * from Food");
                DataTable dt = DBhelper.GetDataTable(sql);
                List<Food> list = new List<Food>();
                if (dt.Rows.Count >= 1 && dt != null)
                {
                    foreach (DataRow t in dt.Rows)
                    {
                        Food food = new Food();
                        food.FoodId = int.Parse(t["FoodId"].ToString());
                        food.FoodName = t["FoodName"].ToString();
                        food.F_TypeId = int.Parse(t["F_TypeId"].ToString());
                        food.Photo = t["photo"].ToString().Trim();
                        list.Add(food);
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
        public static List<Food> selectFood(int i)//重载根据食品类型查询
        {
            try
            {
                string sql = string.Format("select * from Food where F_TypeId={0}",i);
                DataTable dt = DBhelper.GetDataTable(sql);
                List<Food> list = new List<Food>();
                if (dt.Rows.Count >= 1 && dt != null)
                {
                    foreach (DataRow t in dt.Rows)
                    {
                        Food food = new Food();
                        food.FoodId = int.Parse(t["FoodId"].ToString());
                        food.FoodName = t["FoodName"].ToString();
                        food.F_TypeId = int.Parse(t["F_TypeId"].ToString());
                        food.Photo = t["photo"].ToString().Trim();
                        list.Add(food);
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
        public static List<Food> selectFood(string name)//重载根据食品名查询
        {
            try
            {
                string sql = string.Format("select * from Food where FoodName like '%{0}%'", name);
                DataTable dt = DBhelper.GetDataTable(sql);
                List<Food> list = new List<Food>();
                if (dt.Rows.Count >= 1 && dt != null)
                {
                    foreach (DataRow t in dt.Rows)
                    {
                        Food food = new Food();
                        food.FoodId = int.Parse(t["FoodId"].ToString());
                        food.FoodName = t["FoodName"].ToString();
                        food.F_TypeId = int.Parse(t["F_TypeId"].ToString());
                        food.Photo = t["photo"].ToString().Trim();
                        list.Add(food);
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
        public static List<Food> selectFoodIndex(int i)//分页
        {
            try
            {
                string sql = string.Format("select top 9 * from Food Where FoodId not in (select top " + ( i - 1 ) * 9 + "FoodId from Food)");
                DataTable dt = DBhelper.GetDataTable(sql);
                List<Food> list = new List<Food>();
                if (dt.Rows.Count >= 1 && dt != null)
                {
                    foreach (DataRow t in dt.Rows)
                    {
                        Food food = new Food();
                        food.FoodId = int.Parse(t["FoodId"].ToString());
                        food.FoodName = t["FoodName"].ToString();
                        food.F_TypeId = int.Parse(t["F_TypeId"].ToString());
                        food.Photo = t["photo"].ToString().Trim();
                        list.Add(food);
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
        public static List<Food> selectFoodIndex(int i,int id)//分页根据类型
        {
            try
            {
                string sql = string.Format("select top 9 * from Food Where F_TypeId="+id+" and FoodId not in (select top " + (i - 1) * 9 + "FoodId from Food)");
                DataTable dt = DBhelper.GetDataTable(sql);
                List<Food> list = new List<Food>();
                if (dt.Rows.Count >= 1 && dt != null)
                {
                    foreach (DataRow t in dt.Rows)
                    {
                        Food food = new Food();
                        food.FoodId = int.Parse(t["FoodId"].ToString());
                        food.FoodName = t["FoodName"].ToString();
                        food.F_TypeId = int.Parse(t["F_TypeId"].ToString());
                        food.Photo = t["photo"].ToString().Trim();
                        list.Add(food);
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
        public static List<Food> selectFoodIndex(int i, string name)//分页根据名字
        {
            try
            {
                string sql = string.Format("select top 9 * from Food Where FoodName like '%" + name + "%' and FoodId not in (select top " + (i - 1) * 9 + "FoodId from Food)");
                DataTable dt = DBhelper.GetDataTable(sql);
                List<Food> list = new List<Food>();
                if (dt.Rows.Count >= 1 && dt != null)
                {
                    foreach (DataRow t in dt.Rows)
                    {
                        Food food = new Food();
                        food.FoodId = int.Parse(t["FoodId"].ToString());
                        food.FoodName = t["FoodName"].ToString();
                        food.F_TypeId = int.Parse(t["F_TypeId"].ToString());
                        food.Photo = t["photo"].ToString().Trim();
                        list.Add(food);
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
        public static Food Food(int i)//根据编号查询食品信息
        {
            try
            {
                string sql = string.Format("select * from Food where FoodId={0}", i);
                DataTable dt = DBhelper.GetDataTable(sql);
                Food Food = new Food();
                Food.FoodId =int.Parse(dt.Rows[0][0].ToString());
                Food.FoodName = dt.Rows[0][1].ToString();
                Food.F_TypeId = int.Parse(dt.Rows[0][2].ToString());
                Food.Photo = dt.Rows[0][3].ToString();
                Food.FoodId =int.Parse(dt.Rows[0][4].ToString());
                Food.FoodJs = dt.Rows[0][5].ToString();
                return Food;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static int FoodID()
        {
            try
            {
                string sql = string.Format("select top 1 FoodId from Food order by FoodId desc");
                return int.Parse(DBhelper.GetDataTable(sql).Rows[0][0].ToString()) + 1;
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}

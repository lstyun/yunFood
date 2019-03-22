using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;

namespace BLL
{
    public class FoodBLL
    {
        public static List<Food> selectFood()//查询食品信息
        {
            return DAL.FoodDAL.selectFood();
        }
        public static List<Food> selectFood(int i)//查询固定类型食品信息
        {

            return DAL.FoodDAL.selectFood(i);
        }
        public static List<Food> selectFood(string name)//查询固定食品名信息
        {

            return DAL.FoodDAL.selectFood(name);
        }
        public static List<Food> selectFoodIndex(int i)//分页
        {
            return DAL.FoodDAL.selectFoodIndex(i);
        }
        public static List<Food> selectFoodIndex(int i, int id)//分页根据类型
        {
            return DAL.FoodDAL.selectFoodIndex(i,id);
        }
        public static List<Food> selectFoodIndex(int i, string name)//分页根据名字
        {
            return DAL.FoodDAL.selectFoodIndex(i,name);
        }
        public static Food Food(int i)//根究食品编号名查信息
        {
            return DAL.FoodDAL.Food(i);
        }
        public static int FoodID()//查询要新增的菜名ID
        {
            return DAL.FoodDAL.FoodID();
        }
    }
}

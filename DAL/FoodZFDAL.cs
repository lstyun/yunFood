using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Model;

namespace DAL
{
    public class FoodZFDAL
    {
        public static DataTable selectFoodZF(int i)//食品做法
        {
            try
            {
                string sql = string.Format("select * from FoodZF where FoodID={0}",i);
                return DBhelper.GetDataTable(sql);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static List<FoodZF> SelectFoodZF()//查询步骤
        {
            try
            { 
            string sql = string.Format("select * from FoodZF where FoodID not in(select FoodID from FoodZF)");
            DataTable dt = DBhelper.GetDataTable(sql);
            List<FoodZF> list = new List<FoodZF>();
                if (dt.Rows.Count >= 1 && dt != null)
                {
                    return null;
                }
                else
                {
                    FoodZF fz = new FoodZF();
                    fz.FoodID = int.Parse(DBhelper.GetDataTable(@"select FoodID from FoodZF
                    order by FoodID desc").Rows[0][0].ToString() )+ 1;
                    fz.FoodSU = 1;
                    fz.FoodZFM = "";
                    fz.FoodZFT = "";
                    list.Add(fz);
                    return list;
                }
        }
            catch (Exception)
            {

                throw;
            }
}
    }
}

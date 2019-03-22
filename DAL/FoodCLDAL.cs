using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Model;

namespace DAL
{
    public class FoodCLDAL
    {
        public static List<FoodCL> selectFoodCL(int id,int  i)//根据食品ID的主副类型查询
        {
            try
            {
                string sql = string.Format("select * from FoodCL where ZF={0} and FoodId={1}", i,id);
                DataTable dt = DBhelper.GetDataTable(sql);
                List<FoodCL> list = new List<FoodCL>();
                if (dt.Rows.Count >= 1 && dt != null)
                {
                    foreach (DataRow t in dt.Rows)
                    {
                        FoodCL CL = new FoodCL();
                        CL.FoodId = int.Parse(t["FoodId"].ToString());
                        CL.FoodCLM = t["FoodCLM"].ToString();
                        CL.FoodCLT = t["FoodCLT"].ToString();
                        CL.FoodCLS = t["FoodCLS"].ToString();
                        list.Add(CL);
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

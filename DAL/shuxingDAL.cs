using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;
using System.Data;

namespace DAL
{
    public class shuxingDAL
    {
        public static shuxing selectSX(int i)
        {
            try
            {
                string sql = string.Format("select * from shuxing where FoodId={0}", i);
                DataTable dt = DBhelper.GetDataTable(sql);
                shuxing sx = new shuxing();
                sx.Process = dt.Rows[0][0].ToString();
                sx.Taste = dt.Rows[0][1].ToString();
                sx.Difficulty = dt.Rows[0][2].ToString();
                sx.N_Pren = int.Parse(dt.Rows[0][3].ToString());
                sx.ZBtime = dt.Rows[0][4].ToString();
                sx.PRtime = dt.Rows[0][5].ToString();
                sx.FoodId = int.Parse(dt.Rows[0][6].ToString());
                return sx;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

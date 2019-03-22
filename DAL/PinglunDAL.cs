using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Model;

namespace DAL
{
    public class PinglunDAL
    {
        public static DataTable Selectpinglun(int i)//查询评论者
        {
            try
            {
                string sql = string.Format(@"select a.PLId,a.SId,a.FoodId,a.Review,a.PingTime,b.Name,b.Img from pinglun a,[User] b
                where a.UserId = b.UserId and FoodId = {0} and SId is null ", i);
                return DBhelper.GetDataTable(sql);

            }
            catch (Exception)
            {

                throw;
            }
        }
        public static List<PL> Selectpinglun(int i,int id)//查询回复者
        {
            try
            {
                string sql = string.Format(@"Select a.PLId as FID,a.FoodId,b.PLId as HID,b.Review as Content,c.Name as 
                FName,d.Name as HName,b.PingTime as SJ ,b.ZId as ZID ,c.Img as FImg,d.Img as HImg from pinglun a,pinglun 
                b,[User] c,[User] d where a.PLId=b.SId and a.UserId=c.UserId and b.UserId=d.UserId and B.ZId={0} and
                a.FoodId={1} ", id,i);
                DataTable dt=DBhelper.GetDataTable(sql);
                List<PL> list = new List<PL>();
                if (dt.Rows.Count >= 1 && dt != null)
                {
                    foreach (DataRow t in dt.Rows)
                    {
                        PL P = new PL();
                        P.FID= int.Parse(t["FID"].ToString());
                        P.FoodID= int.Parse(t["FoodID"].ToString());
                        P.HID= int.Parse(t["HID"].ToString());
                        P.Content = t["Content"].ToString();
                        P.FName= t["FName"].ToString();
                        P.HName= t["Hname"].ToString();
                        P.SJ = DateTime.Parse(t["SJ"].ToString());
                        P.ZID= int.Parse(t["ZID"].ToString());
                        P.FImg= t["FImg"].ToString();
                        P.HImg= t["HImg"].ToString();
                        list.Add(P);
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
        public static bool Insertpinlun(pinglun p)
        {
            try
            {
                string sql = string.Format("insert pinglun(FoodId,UserId,Review,PingTime) values({0},{1},'{2}','{3}')",p.FoodId,p.UserId,p.Review,p.PingTime);
                return DBhelper.ExecuteNonQuery(sql);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static bool InsertpinlunH(pinglun p)
        {
            try
            {
                string sql = string.Format("insert pinglun(SId,FoodId,UserId,Review,PingTime,ZId) values({0},{1},{2},'{3}','{4}',{5})",p.SId,p.FoodId,p.UserId,p.Review,p.PingTime,p.zId);
                return DBhelper.ExecuteNonQuery(sql);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

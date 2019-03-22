using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;
using System.Data;

namespace DAL
{
    public class SCCPDAL
    {
        public static List<SXtype> SelectType(int i)//根据类型ID查询属性
        {
            try
            {
                string sql = string.Format("select * from SXtype where SXids={0}",i);
                DataTable dt = DBhelper.GetDataTable(sql);
                List<SXtype> list = new List<SXtype>();
                if (dt.Rows.Count >= 1 && dt != null)
                {
                    foreach (DataRow t in dt.Rows)
                    {
                        SXtype ty = new SXtype();
                        ty.SXid= int.Parse(t["SXid"].ToString());
                        ty.SXname = t["SXname"].ToString();
                        ty.SXids= int.Parse(t["SXids"].ToString());
                        list.Add(ty);
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
        public static List<SXtype> SelectType()//查询类型ID属性
        {
            try
            {
                string sql = string.Format("select * from SXtype where SXid not in (select SXid from SXtype where SXid=1) and SXids is null");
                DataTable dt = DBhelper.GetDataTable(sql);
                List<SXtype> list = new List<SXtype>();
                if (dt.Rows.Count >= 1 && dt != null)
                {
                    foreach (DataRow t in dt.Rows)
                    {
                        SXtype ty = new SXtype();
                        ty.SXid = int.Parse(t["SXid"].ToString());
                        ty.SXname = t["SXname"].ToString();
                        if(t["SXids"]==DBNull.Value)
                        {
                            ty.SXids = 0;
                        }
                        else
                        {
                            ty.SXids = int.Parse(t["SXids"].ToString());
                        }
                        list.Add(ty);
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

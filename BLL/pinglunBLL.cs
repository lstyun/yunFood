using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;
using System.Data;

namespace BLL
{
   public class PinglunBLL
    {
        public static DataTable SelectpinglunBLL(int i)
        {
            return DAL.PinglunDAL.Selectpinglun(i);
        }
        public static List<PL> SelectpinglunBLL(int i,int id)
        {
            return DAL.PinglunDAL.Selectpinglun(i,id);
        }
        public static bool Insertpinglun(pinglun p)
        {
            return DAL.PinglunDAL.Insertpinlun(p);
        }
        public static bool InsertpinglunH(pinglun p)
        {
            return DAL.PinglunDAL.InsertpinlunH(p);
        }
    }
}

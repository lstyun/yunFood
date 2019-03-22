using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBhelper
    {
        //链接数据库字符串
        public static string connstring = "server=.; database=Hi-yo; uid=sa ;pwd=123456;";
        private static SqlConnection conn = null;
        //验证是否链接 如果链接失败则重新链接
        public static void a()
        {
            if (conn == null)
            {
                conn = new SqlConnection(connstring);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            if (conn.State == ConnectionState.Broken)
            {
                conn.Close();
                conn.Open();
            }
        }
        //增删改
        public static bool ExecuteNonQuery(string sql)
        {
            try
            {
                a();
                SqlCommand cmd = new SqlCommand(sql, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            
        }
        //验证数据库对象
        public static SqlDataReader GetDataReader(string sql)
        {
            a();
            SqlCommand cmd = new SqlCommand(sql, conn);
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        //查询表
        public static DataTable GetDataTable(string sql)
        {
            a();
            DataTable table = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            dap.Fill(table);
            conn.Close();
            return table;
        }
        //计算返回行
        public int SqlServerCount(string sql)
        {
            a();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = conn;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            int RecordCount = 0;
            while (dr.Read())
            {
                RecordCount = RecordCount + 1;
            }
            a();
            conn.Close();
            return RecordCount;
        }
    }
}

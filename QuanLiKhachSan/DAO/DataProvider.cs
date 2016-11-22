using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
   public class DataProvider
    {
        public static SqlConnection KetNoi()
        {
            string sChuoiKetNoi = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLiKhachSan;Integrated Security=True";
            SqlConnection con = new SqlConnection(sChuoiKetNoi);
            con.Open();
            return con;
        }

        public static void DongKetNoi(SqlConnection con)
        {
            con.Close();
        }

        public static DataTable LayDataTable(string sTruyVan, SqlConnection con)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sTruyVan, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public static void ThucThiTruyVanNonQuery(string sTruyVan, SqlConnection con)
        {
            SqlCommand com = new SqlCommand(sTruyVan, con);
            com.ExecuteNonQuery();
        }
    }
}

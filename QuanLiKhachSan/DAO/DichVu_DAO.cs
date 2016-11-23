using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
   public class DichVu_DAO
    {
        public static SqlConnection con;

        public static DataTable LoadDuLieu()
        {
            string sTruyVan = "Select * From DichVu";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }
        public static DataTable LoadDuLieuTheoMa(string ma)
        {
            string sTruyVan = "Select * From DichVu where MaDV="+ma;
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }


        public static bool Them(DichVu_DTO DV)
        {
            try
            {
                string sTruyVan = string.Format("Insert into DichVu(TenDV,GiaDV) values(N'{0}','{1}')",DV.TenDV,DV.GiaDV);
                con = DataProvider.KetNoi();
                DataProvider.ThucThiTruyVanNonQuery(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Sua(DichVu_DTO DV)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Update DichVu set TenDV= N'{0}',GiaDV='{1}' where MaDV='{2}'",DV.TenDV,DV.GiaDV,DV.MaDV);
                DataProvider.ThucThiTruyVanNonQuery(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Xoa(DichVu_DTO DV)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Delete From  DichVu  where MaDV = '{0}'", DV.MaDV);
                DataProvider.ThucThiTruyVanNonQuery(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

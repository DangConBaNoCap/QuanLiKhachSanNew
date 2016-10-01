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
    public class ThuePhong_DAO
    {
        public static SqlConnection con;

        public static DataTable LoadDuLieu()
        {
            string sTruyVan = "Select * From ThuePhong";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }

        public static bool Them(ThuePhong_DTO TP)
        {
            try
            {
                string sTruyVan = string.Format("Insert into ThuePhong(MaNV,NgayThue,MaKH) values('{0}','{1}','{2}')", TP.MaNV,TP.NgayThue,TP.MaKH);
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

        public static bool Sua(ThuePhong_DTO TP)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Update ThuePhong set MaNV= '{0}',NgayThue='{1}',MaKH='{2}' where MaHD='{3}'", TP.MaNV, TP.NgayThue, TP.MaKH,TP.MaHD);
                DataProvider.ThucThiTruyVanNonQuery(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Xoa(ThuePhong_DTO TP)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Delete From  ThuePhong  where MaHD = '{0}'", TP.MaHD);
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

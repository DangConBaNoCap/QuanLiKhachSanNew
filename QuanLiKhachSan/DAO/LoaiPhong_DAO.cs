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
    public class LoaiPhong_DAO
    {
        public static SqlConnection con;

        public static DataTable LoadDuLieu()
        {
            string sTruyVan = "Select * From LoaiPhong";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }

        public static bool Them(LoaiPhong_DTO LP)
        {
            try
            {
                string sTruyVan = string.Format("Insert into LoaiPhong(LoaiPhong,GiaTien) values(N'{0}','{1}')",LP.LoaiPhong,LP.GiaTien);
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

        public static bool Sua(LoaiPhong_DTO LP)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Update LoaiPhong set LoaiPhong= N'{0}',GiaTien='{1}' where MaLoaiPhong='{1}'",LP.LoaiPhong,LP.GiaTien,LP.MaLoaiPhong);
                DataProvider.ThucThiTruyVanNonQuery(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Xoa(LoaiPhong_DTO LP)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Delete From LoaiPhong  where MaLoaiPhong = '{0}'", LP.MaLoaiPhong);
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

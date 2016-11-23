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
    public class ChiTietThuePhong_DAO
    {
        public static SqlConnection con;

        public static DataTable LoadDuLieu()
        {
            string sTruyVan = "Select * From ChiTietThuePhong";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }
        public static DataTable LayHDTheoMa(string MaHD)
        {
            string sTruyVan = "Select * From ChiTietThuePhong where MaHD=";
            sTruyVan += MaHD;
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }
        public static DataTable LayHDTheoMaPhong(string MaHD)
        {
            string sTruyVan = "Select * From ChiTietThuePhong where MaPhong=N'";
            sTruyVan += MaHD+"' and NgayTra is NULL";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }
        public static DataTable LayDSPhongTheoHD(int idYeuCau)
        {
            string sTruyVan = string.Format("select Phong from Phong a,ChiTietThuePhong b where b.MaHD = '{0}' and b.MaPhong=a.MaPhong ", idYeuCau);
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            return dt;
        }

        public static bool Them(ChiTietThuePhong_DTO CTTP)
        {
            try
            {
                string sTruyVan = string.Format("Insert into ChiTietThuePhong(MaHD,MaPhong,NgayTra) values('{0}','{1}','{2}')", CTTP.MaHD,CTTP.MaPhong,CTTP.NgayTra);
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

        public static bool Them1(ChiTietThuePhong_DTO CTTP)
        {
            try
            {
                string sTruyVan = string.Format("Insert into ChiTietThuePhong(MaHD,MaPhong) values('{0}','{1}')", CTTP.MaHD, CTTP.MaPhong);
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
        public static bool Sua(ChiTietThuePhong_DTO CTTP)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Update ChiTietThuePhong set NgayTra= '{0}' where MaHD='{1}'and MaPhong='{2}'",CTTP.NgayTra,CTTP.MaHD,CTTP.MaPhong);
                DataProvider.ThucThiTruyVanNonQuery(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Xoa(ChiTietThuePhong_DTO CTTP)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Delete From  ChiTietThuePhong  where MaHD = '{0}'and MaPhong='{1}'", CTTP.MaHD, CTTP.MaPhong);
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

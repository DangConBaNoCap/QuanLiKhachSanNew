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
    public class Phong_DAO
    {
        public static SqlConnection con;

        public static DataTable LoadDuLieu()
        {
            string sTruyVan = "Select * From Phong";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }
        public static DataTable LoadDuLieuPhongTrong()
        {
            string sTruyVan = "Select * From Phong where TinhTrang=0";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }
        public static DataTable LoadDuLieuTheoLoaiPhong(string MaLP)
        {
            string sTruyVan = "Select * From Phong where MaLoaiPhong=";
            sTruyVan += MaLP;
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }
        public static DataTable LayThongTinPhong(int IDPhong)
        {
            DataTable dt = new DataTable();
            string sTruyVan = string.Format("select a.MaPhong,a.TinhTrang,d.LoaiPhong,b.MaHD,e.HoTenKH from Phong a,ChiTietThuePhong b, ThuePhong c,LoaiPhong d,KhachHang e where c.MaKH=e.MaKH and a.MaLoaiPhong=d.MaLoaiPhong and a.MaPhong={0} and a.MaPhong=b.MaPhong and b.MaHD= c.MaHD", IDPhong);
            con = DataProvider.KetNoi();
            dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }
        public static DataTable LayDSDichVuPhong(int IDPhong)
        {
            DataTable dt = new DataTable();
            string sTruyVan = string.Format("select  c.MaDV,c.TenDV,b.SoLuong,c.GiaDV,c.GiaDV*b.SoLuong ThanhTien,b.MaNV from ChiTietThuePhong a,DichVu c,SuDungDV b  where a.MaPhong = '{0}' and a.MaHD = b.MaHD and b.MaDV =c.MaDV", IDPhong);
            con = DataProvider.KetNoi();
            dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }
        public static bool Them(Phong_DTO P)
        {
            try
            {
                string sTruyVan = string.Format("Insert into Phong(MaLoaiPhong,TinhTrang) values('{0}','{1}')",P.MaLoaiPhong,P.TinhTrang);
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

        public static bool SuaPhong(Phong_DTO P)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Update Phong set TinhTrang='{0}' where MaPhong='{1}'", P.TinhTrang, P.MaPhong);
                DataProvider.ThucThiTruyVanNonQuery(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Sua(Phong_DTO P)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Update Phong set MaLoaiPhong='{0}',TinhTrang='{1}' where MaPhong='{2}'",P.MaLoaiPhong,P.TinhTrang,P.MaPhong);
                DataProvider.ThucThiTruyVanNonQuery(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Xoa(Phong_DTO P)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Delete From  Phong  where MaPhong = '{0}'", P.MaPhong);
                DataProvider.ThucThiTruyVanNonQuery(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static DataTable LayDuLieu()
        {
            string sTruyVan = "Select MaPhong,Phong.MaLoaiPhong,GiaTien,TinhTrang From Phong,LoaiPhong Where Phong.MaLoaiPhong=LoaiPhong.MaLoaiPhong";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }
        public static DataTable LayLoaiPhong(string dk)
        {
            string sTruyVan = "Select MaLoaiPhong,LoaiPhong,GiaTien From LoaiPhong "+dk;
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }

        public static DataTable TimKiem(string dk)
        {
            string sTruyVan = "SELECT  Phong.MaPhong, Phong.TinhTrang, Phong.MaLoaiPhong, LoaiPhong.GiaTien "+
             "FROM  Phong INNER JOIN LoaiPhong ON Phong.MaLoaiPhong = LoaiPhong.MaLoaiPhong "+dk;
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }

    }
}

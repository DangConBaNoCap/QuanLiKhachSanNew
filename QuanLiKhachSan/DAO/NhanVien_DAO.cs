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
    public class NhanVien_DAO
    {
        public static SqlConnection con;

        public static DataTable LoadDuLieu()
        {
            string sTruyVan = "Select * From NhanVien";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }

        public static bool Them(NhanVien_DTO NV)
        {
            try
            {
                string sTruyVan = string.Format("Insert into NhanVien(HoTenNV,NgaySinh,GioiTinh,DiaChi) values(N'{0}','{1}',N'{2}',N'{3}')", NV.HoTenNV, NV.NgaySinh, NV.GioiTinh, NV.DiaChi);
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

        public static bool Sua(NhanVien_DTO NV)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Update NhanVien set HoTenNV= N'{0}',NgaySinh='{1}',GioiTinh=N'{2}',DiaChi=N'{3}' where MaNV='{4}'", NV.HoTenNV, NV.NgaySinh, NV.GioiTinh, NV.DiaChi, NV.MaNV);
                DataProvider.ThucThiTruyVanNonQuery(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Xoa(NhanVien_DTO NV)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Delete From  NhanVien  where MaNV = '{0}'", NV.MaNV);
                DataProvider.ThucThiTruyVanNonQuery(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static DataTable LoadDuLieu(string where)
        {
            string sTruyVan = "Select * From NhanVien " + where;
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class KhachHang_DAO
    {
        public static SqlConnection con;

        public static DataTable LoadDuLieu()
        {
            string sTruyVan = "Select * From KhachHang";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }

        public static bool Them(KhachHang_DTO DV)
        {
            try
            {
                string sTruyVan = string.Format("Insert into KhachHang(HoTenKH,DiaChi,DienThoai,GioiTinh,CMND) values(N'{0}',N'{1}','{2}','{3}','{4}')",DV.HoTenKH,DV.DiaChi,DV.DienThoai,DV.GioiTinh,DV.CMND);
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

        public static bool Sua(KhachHang_DTO DV)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Update KhachHang set HoTenKH= N'{0}',DiaChi=N'{1}',DienThoai='{2}',GioiTinh='{3}',CMND='{4}' where MaKH='{5}'", DV.HoTenKH,DV.DiaChi,DV.DienThoai,DV.GioiTinh,DV.CMND,DV.MaKH);
                DataProvider.ThucThiTruyVanNonQuery(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Xoa(KhachHang_DTO DV)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Delete From  KhachHang  where MaKH = '{0}'", DV.MaKH);
                DataProvider.ThucThiTruyVanNonQuery(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return true;
            }
            catch(Exception ex)
            {
                string message = ex.Message;
                return false;
            }
        }
    }
}

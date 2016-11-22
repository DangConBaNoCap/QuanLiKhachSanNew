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
    public class SuDungDV_DAO
    {
        public static SqlConnection con;

        public static DataTable LoadDuLieu()
        {
            string sTruyVan = "Select * From SuDungDV";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }
        public static DataTable LoadDuLieuTheoMa(string MaHD)
        {
            string sTruyVan = "Select b.TenDV,b.GiaDV,a.SoLuong,ThanhTien=a.SoLuong*b.GiaDV From SuDungDV a,DichVu b where a.MaDV=b.MaDV and MaHD=";
            sTruyVan += MaHD;
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }
        public static bool Them(SuDungDV_DTO DV)
        {
            try
            {
                string sTruyVan = string.Format("Insert into SuDungDV(MaHD,MaDV,SoLuong,MaNV) values('{0}','{1}','{2}','{3}')", DV.MaHD,DV.MaDV,DV.SoLuong,DV.MaNV);
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

        public static bool Sua(SuDungDV_DTO DV)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Update SuDungDV set SoLuong= '{0}',MaNV='{1}' where MaHD='{2}' and MaDV='{3}'", DV.SoLuong, DV.MaNV, DV.MaHD,DV.MaDV);
                DataProvider.ThucThiTruyVanNonQuery(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Xoa(SuDungDV_DTO DV)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Delete From  SuDungDV  where MaHD='{0}' and MaDV = '{1}'",DV.MaHD, DV.MaDV);
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

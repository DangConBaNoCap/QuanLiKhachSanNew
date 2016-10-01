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
    public class TrangBiPhong_DAO
    {

        public static SqlConnection con;

        public static DataTable LoadDuLieu()
        {
            string sTruyVan = "Select * From TrangBiPhong";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }

        public static bool Them(TrangBiPhong_DTO KH)
        {
            try
            {
                string sTruyVan = string.Format("Insert into TrangBiPhong(MaLoaiPhong,MaTB,SoLuong) values('{0}','{1}','{2}')", KH.MaLoaiPhong,KH.MaTB,KH.SoLuong);
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

        public static bool Sua(TrangBiPhong_DTO KH)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Update TrangBiPhong set SoLuong= '{0}' where MaLoaiPhong='{1}'and MaTB='{2}'", KH.SoLuong, KH.MaLoaiPhong, KH.MaTB);
                DataProvider.ThucThiTruyVanNonQuery(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Xoa(TrangBiPhong_DTO KH)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Delete From TrangBiPhong  where MaLoaiPhong='{0}' and MaTB = '{1}'", KH.MaLoaiPhong,KH.MaTB);
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

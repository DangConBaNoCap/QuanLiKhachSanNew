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
    public class TaiKhoan_DAO
    {
        public static SqlConnection con;

        public static DataTable LoadDuLieu()
        {
            string sTruyVan = "Select * From TaiKhoan";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }

        public static bool Them(TaiKhoan_DTO DV)
        {
            try
            {
                string sTruyVan = string.Format("Insert into TaiKhoan(TaiKhoan,MatKhau,MaNV) values(N'{0}',N'{1}','{2}')", DV.TaiKhoan,DV.MatKhau,DV.MaNV);
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

        public static bool Sua(TaiKhoan_DTO DV)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Update TaiKhoan set MatKhau=N'{0}',MaNV='{1}' where TaiKhoan=N'{2}'", DV.MatKhau,DV.MaNV,DV.TaiKhoan);
                DataProvider.ThucThiTruyVanNonQuery(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Xoa(TaiKhoan_DTO DV)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Delete From  TaiKhoan  where TaiKhoan = '{0}'", DV.TaiKhoan);
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

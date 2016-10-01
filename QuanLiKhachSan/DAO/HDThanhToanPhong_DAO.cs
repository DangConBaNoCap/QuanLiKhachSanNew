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
    public class HDThanhToanPhong_DAO
    {
        public static SqlConnection con;

        public static DataTable LoadDuLieu()
        {
            string sTruyVan = "Select * From HDThanhToanPhong";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }

        public static bool Them(HDThanhToanPhong_DTO HDTTP)
        {
            try
            {
                string sTruyVan = string.Format("Insert into HDThanhToanPhong(MaHD,MaNV,NgayThanhToan,TienPhong) values('{0}','{1}','{2}','{3}')", HDTTP.MaHD,HDTTP.MaNV,HDTTP.NgayThanhToan,HDTTP.TienPhong);
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

        public static bool Sua(HDThanhToanPhong_DTO HDTTP)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Update  HDThanhToanPhong set MaHD= N'{0}',MaNV='{1}',NgayThanhToan='{2}',TienPhong='{3}' where MaThanhToan='{4}'", HDTTP.MaHD,HDTTP.MaNV,HDTTP.NgayThanhToan,HDTTP.TienPhong,HDTTP.MaThanhToan);
                DataProvider.ThucThiTruyVanNonQuery(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Xoa(HDThanhToanPhong_DTO HDTTP)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Delete From   HDThanhToanPhong where MaThanhToan = '{0}'", HDTTP.MaThanhToan);
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

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
   public class ThietBi_DAO
    {
        public static SqlConnection con;

        public static DataTable LoadDuLieu()
        {
            string sTruyVan = "Select * From ThietBi";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }

        public static bool Them(ThietBi_DTO KH)
        {
            try
            {
                string sTruyVan = string.Format("Insert into ThietBi(TenThietBi,GiaTB) values(N'{0}','{1}')", KH.TenThietBi,KH.GiaTB);
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

        public static bool Sua(ThietBi_DTO KH)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Update ThietBi set TenThietBi= N'{0}',GiaTB='{1}' where MaTB='{5}'", KH.TenThietBi,KH.GiaTB,KH.MaTB);
                DataProvider.ThucThiTruyVanNonQuery(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Xoa(ThietBi_DTO KH)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Delete From ThietBi  where MaTB = '{0}'", KH.MaTB);
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

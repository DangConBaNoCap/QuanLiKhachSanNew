﻿using System;
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

        public static bool Them(Phong_DTO P)
        {
            try
            {
                string sTruyVan = string.Format("Insert into Phong(MaLoaiPhong,TinhTrang) values('{0}',N'{1}')",P.MaLoaiPhong,P.TinhTrang);
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

        public static bool Sua(Phong_DTO P)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Update Phong set MaLoaiPhong='{0}',TinhTrang=N'{1}' where MaPhong='{2}'",P.MaLoaiPhong,P.TinhTrang,P.MaPhong);
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
    }
}

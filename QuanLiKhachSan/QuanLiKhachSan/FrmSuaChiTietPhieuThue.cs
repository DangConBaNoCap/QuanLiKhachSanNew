using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;
namespace QuanLiKhachSan
{
    public partial class FrmSuaChiTietPhieuThue : Form
    {
        private int MaHDon;
        private int MaPhg;
        private DateTime NgayTra;
        public FrmSuaChiTietPhieuThue(string MaHD,string MaPhong)
        {
            MaHDon = int.Parse(MaHD);
            MaPhg = int.Parse(MaPhong);
            InitializeComponent();
        }

        private void FrmSuaChiTietPhieuThue_Load(object sender, EventArgs e)
        {
            DataTable ct = ChiTietThuePhong_DAO.LoadDuLieu1(MaHDon.ToString(), MaPhg.ToString());
            if (ct.Rows[0][2].ToString() == "")
            {
                NgayTra = DateTime.Now;
            }
            else
            {
                NgayTra = DateTime.Parse(ct.Rows[0][2].ToString());
            }
            txtMaHD.Text = MaHDon.ToString();
            txtPhong.Text = MaPhg.ToString();
            dtThoiGian.Value = NgayTra;
        }

        private void btnLUU_Click(object sender, EventArgs e)
        {
            ChiTietThuePhong_DTO tp = new ChiTietThuePhong_DTO();
            tp.MaHD = MaHDon;
            tp.MaPhong = MaPhg;
            tp.NgayTra = dtThoiGian.Value;
            ChiTietThuePhong_DAO.Sua(tp);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

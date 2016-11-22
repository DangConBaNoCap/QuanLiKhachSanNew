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
     
        public FrmSuaChiTietPhieuThue(string MaHD,string MaPhong)
        {
            MaHDon = int.Parse(MaHD);
            MaPhg = int.Parse(MaPhong);
            InitializeComponent();
        }

        private void FrmSuaChiTietPhieuThue_Load(object sender, EventArgs e)
        {
            Phong_DTO p = new Phong_DTO();
            p.MaPhong = MaPhg;
            p.TinhTrang = 0;
            Phong_DAO.SuaPhong(p);
            txtMaHD.Text = MaHDon.ToString();
            cboPhong.DataSource = Phong_DAO.LoadDuLieuPhongTrong();
            cboPhong.DisplayMember = "MaPhong";
            cboPhong.ValueMember = "MaPhong";
            cboPhong.SelectedValue = MaPhg;           
           
        }

        private void btnLUU_Click(object sender, EventArgs e)
        {
            ChiTietThuePhong_DTO tp = new ChiTietThuePhong_DTO();
            tp.MaHD = MaHDon;
            tp.MaPhong = int.Parse(cboPhong.SelectedValue.ToString());
            ChiTietThuePhong_DAO.Sua(tp);
            Phong_DTO p = new Phong_DTO();
            p.MaPhong = int.Parse(cboPhong.SelectedValue.ToString());
            p.TinhTrang = 1;
            Phong_DAO.Sua(p);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

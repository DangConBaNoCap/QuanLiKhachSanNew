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
    public partial class FrmSuaPhieuThue : Form
    {
        private int MaHDon;
        private int MaNV;
        private int MaKH;
        private DateTime NgayThue;
        public FrmSuaPhieuThue(string MaHD)
        {
            MaHDon = int.Parse(MaHD);
            InitializeComponent();
        }

        private void FrmSuaPhieuThue_Load(object sender, EventArgs e)
        {
            DataTable dt = ThuePhong_DAO.LoadDuLieuTheoMa(MaHDon.ToString());
            MaNV = int.Parse(dt.Rows[0][1].ToString());
            MaKH = int.Parse(dt.Rows[0][3].ToString());
            NgayThue = DateTime.Parse(dt.Rows[0][2].ToString());

            cboNhanVien.DataSource = NhanVien_DAO.LoadDuLieu();
            cboNhanVien.DisplayMember = "HoTenNV";
            cboNhanVien.ValueMember = "MaNV";
            //Khach Hang
            cboKhachHang.DataSource = KhachHang_DAO.LoadDuLieu();
            cboKhachHang.DisplayMember = "HoTenKH";
            cboKhachHang.ValueMember = "MaKH";
            LoadDL();
        }
        private void LoadDL()
        {
            txtMaHD.Text = MaHDon.ToString();
            cboNhanVien.SelectedValue = MaNV;
            cboKhachHang.SelectedValue = MaKH;
            dtThoiGian.Value = NgayThue;
        }
        private void Sua()
        {
            MaNV = int.Parse(cboNhanVien.SelectedValue.ToString());
            MaKH = int.Parse(cboKhachHang.SelectedValue.ToString());
            NgayThue = dtThoiGian.Value;
        }
        private void btnLUU_Click(object sender, EventArgs e)
        {
            Sua();
            ThuePhong_DTO tp = new ThuePhong_DTO();
            tp.MaHD = MaHDon;
            tp.MaKH = MaKH;
            tp.MaNV = MaNV;
            tp.NgayThue = NgayThue;
            ThuePhong_DAO.Sua(tp);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

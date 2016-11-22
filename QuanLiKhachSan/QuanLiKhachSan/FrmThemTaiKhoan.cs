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
using System.Data.SqlClient;
namespace QuanLiKhachSan
{
    public partial class FrmThemTaiKhoan : Form
    {
        public FrmThemTaiKhoan()
        {
            InitializeComponent();
        }
        public void ReLoad()
        {
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            txtNhapLaiMatKhau.Text = "";
            cboNhanVien.Text = "";
        }
        private void FrmThemTaiKhoan_Load(object sender, EventArgs e)
        {
            cboNhanVien.DataSource = NhanVien_DAO.LoadDuLieu();
            cboNhanVien.ValueMember = "MaNV";
            cboNhanVien.DisplayMember = "HoTenNV";
        }
        public bool CheckTaiKhoan()
        {
            SqlConnection con = DataProvider.KetNoi();
            string s = string.Format("Select * from TaiKhoan where TaiKhoan = '{0}'", txtTenDangNhap.Text);
            SqlDataAdapter sda = new SqlDataAdapter(s, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "" || txtNhapLaiMatKhau.Text == "" || txtTenDangNhap.Text == "" || cboNhanVien.Text == "")
            {
                MessageBox.Show("Bạn cần nhập đủ thông tin");
                return;
            }
            if (CheckTaiKhoan() == false)
            {
                MessageBox.Show("Tài khoản này đã tồn tại");
                ReLoad();
                return;
            }
            if (txtMatKhau.Text != txtNhapLaiMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu không khớp");
                ReLoad();
                return;
            }
            SqlConnection con = DataProvider.KetNoi();
            string s = string.Format("Insert TaiKhoan(TaiKhoan,MatKhau,MaNV) values('{0}','{1}','{2}')", txtTenDangNhap.Text, txtMatKhau.Text, 1, cboNhanVien.SelectedValue);
            SqlCommand cmd = new SqlCommand(s, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Thêm tài khoản thành công");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

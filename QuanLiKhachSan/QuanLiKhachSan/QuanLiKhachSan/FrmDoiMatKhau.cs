using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using DAO;
namespace QuanLiKhachSan
{
    public partial class FrmDoiMatKhau : Form
    {
        public FrmDoiMatKhau()
        {
            InitializeComponent();
            txtTenTaiKhoan.Text = frmDangNhap.TenDangNhap;
        }
        public void ReLoad()
        {
            txtTenTaiKhoan.Text = frmDangNhap.TenDangNhap;
            txtMatKhauCu.Text = "";
            txtMatKhauMoi.Text = "";
            txtNhapLaiMatKhau.Text = "";
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtMatKhauCu.Text == "" || txtMatKhauMoi.Text == "" || txtNhapLaiMatKhau.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập đủ thông tin");
                ReLoad();
                return;
            }
            if (txtMatKhauCu.Text != frmDangNhap.MatKhau)
            {
                // MessageBox.Show("Mật khẩu cũ không đúng");
                lbKT.Text = "Mật khẩu cũ không đúng";
                ReLoad();
                return;
            }
            if (txtMatKhauMoi.Text != txtNhapLaiMatKhau.Text)
            {
                // MessageBox.Show("Nhập lại mật khẩu không khớp");
                lbKT.Text = "Nhập lại mật khẩu không khớp";
                ReLoad();
                return;
            }
            SqlConnection con = DataProvider.KetNoi();
            string Scommand = string.Format("update tblTaiKhoan set MatKhau = '{0}' where TenDangNhap = '{1}'", txtMatKhauMoi.Text, txtTenTaiKhoan.Text);
            SqlCommand com = new SqlCommand(Scommand, con);
            com.ExecuteNonQuery();
            DataProvider.DongKetNoi(con);
            MessageBox.Show("Đổi mật khẩu thành công ! Khởi động lại chương trình");
            this.Close();
            Application.Restart();
        }

        private void txtNhapLaiMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnXacNhan_Click(null, null);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}

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
    public partial class frmDangNhap : Form
    {
        public static int MaNV;
        public static string TenDangNhap;
        public static string MatKhau;
        private SqlConnection conn;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            conn = DataProvider.KetNoi();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text != "")
            {
                string command = string.Format("select * from TaiKhoan where TaiKhoan = '{0}'", txtTenDangNhap.Text);
                SqlDataAdapter sda = new SqlDataAdapter(command, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    //MessageBox.Show("Sai tên tài khoản");
                    lbThongBao.Text = "Sai Tài Khoản!!!";
                }
                else if (dt.Rows[0][1].ToString().Trim() != txtMatKhau.Text)
                {
                    // MessageBox.Show("Sai tên mật khẩu ");
                    lbThongBao.Text = "Sai mật khẩu!!!";
                }
                else
                {
                    MaNV = int.Parse(dt.Rows[0][2].ToString());
                    TenDangNhap = txtTenDangNhap.Text;
                    MatKhau = txtMatKhau.Text;
                    frmChinh frm = new frmChinh();
                    frm.Show();
                    this.Hide();
                }
            }
            else
            {
                lbThongBao.Text = "Bạn chưa nhập dữ liệu!!!";
            }
        }

        private void chkHienThi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThi.Checked == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
                txtMatKhau.UseSystemPasswordChar = true;
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(null, null);
            }
        }

    }
}

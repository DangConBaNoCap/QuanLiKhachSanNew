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


namespace QuanLiKhachSan.Quan_Li_Khach
{
    public partial class FrmSuaDivhVu : Form
    {
        private int MaDichVu;
        public FrmSuaDivhVu(string MaDVu)
        {
            MaDichVu = int.Parse(MaDVu);
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
          
            string DonGia = txtDonGia.Text;
            try
            {
                int m = Convert.ToInt32(DonGia);
            }
            catch
            {
                MessageBox.Show("Đơn giá nhập vào chưa đúng định dạng");
                return;
            }

            DichVu_DTO dv = new DichVu_DTO();
            dv.MaDV = MaDichVu;
            dv.TenDV = txtTenDichVu.Text;
            dv.GiaDV = decimal.Parse(DonGia);
            DichVu_DAO.Sua(dv);
        }

        private void FrmSuaDivhVu_Load(object sender, EventArgs e)
        {
            txtMaDV.Text = MaDichVu.ToString();
            DataTable dt = DichVu_DAO.LoadDuLieuTheoMa(MaDichVu.ToString());
            txtTenDichVu.Text = dt.Rows[0][1].ToString();
            txtDonGia.Text = dt.Rows[0][2].ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

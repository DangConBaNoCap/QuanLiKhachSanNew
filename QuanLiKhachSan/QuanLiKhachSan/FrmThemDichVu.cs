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
    public partial class FrmThemDichVu : Form
    {
        DataTable dt = DichVu_DAO.LoadDuLieu();
        public FrmThemDichVu()
        {
            InitializeComponent();
        }

        private void FrmThemDichVu_Load(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string TenDV = txtTenDichVu.Text;
            for(int i=0;i<dt.Rows.Count;i++)
            {
                if(TenDV==dt.Rows[i][1].ToString())
                {
                    MessageBox.Show("Dịch vụ này đã có trong hệ thống!");
                    return;
                }
            }
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
            dv.TenDV = TenDV;
            dv.GiaDV = decimal.Parse(DonGia);
            DichVu_DAO.Them(dv);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

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
namespace QuanLiKhachSan
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }
        private void LoadDSPhong()
        {
            DataTable dt = Phong_DAO.LoadDuLieu();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = new ListViewItem("Phòng " + dt.Rows[i][0].ToString(), int.Parse(dt.Rows[i][2].ToString())); // 0--idban,3--trang thai
                lsvPhong.Items.Add(lvi);
            }
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDoiMatKhau _frmDoiMK = new FrmDoiMatKhau();
            _frmDoiMK.ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmThemTaiKhoan _frmThemTK = new FrmThemTaiKhoan();
            _frmThemTK.ShowDialog();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void frmChinh_Load(object sender, EventArgs e)
        {
            LoadDSPhong();
        }
        ListViewItem itemSelect;
        private void lsvPhong_Click(object sender, EventArgs e)
        {
            try
            {
                itemSelect = lsvPhong.SelectedItems[0];
                foreach (ListViewItem item in lsvPhong.SelectedItems)
                {
                    string[] s = item.SubItems[0].Text.Split(' ');
                    int idPhong = int.Parse(s[1]);
                    LayThongTinPhong(idPhong);
                    LayDSDichVuPhong(idPhong);
                }
            }
            catch
            {
                return;
            }
        }

        private void LayThongTinPhong(int idPhong)
        {
            try
            {
                DataTable dt = Phong_DAO.LayThongTinPhong(idPhong);
                txtPhongSo.Text = dt.Rows[0][0].ToString();
                txtLoaiPhong.Text = dt.Rows[0][2].ToString();
                txtIDKhachHang.Text = dt.Rows[0][4].ToString();
                txtIDyeuCau.Text = dt.Rows[0][3].ToString();
          
                if (dt.Rows[0][1].ToString() == "1")
                {
                    txtTinhTrang.Text = "Có khách";
                }
                else if (dt.Rows[0][1].ToString() == "2")
                {
                    txtTinhTrang.Text = "Đã đặt";
                }
                else
                {
                    txtTinhTrang.Text = "Phòng trống";
                    txtIDyeuCau.Text = "";               
                    txtIDKhachHang.Text = "";
                }
            }
            catch
            {
                txtPhongSo.Text = idPhong.ToString();
                DataTable dt = LoaiPhong_DAO.LoadTenPhong(idPhong.ToString());
                txtLoaiPhong.Text = dt.Rows[0][0].ToString();
                txtIDKhachHang.Text = "";
                txtIDyeuCau.Text = "";           
                txtTinhTrang.Text = "Phòng trống";
            }
        }

        private void LayDSDichVuPhong(int idPhong)
        {
            if (txtIDyeuCau.Text == "")
            {
                dgvDSDichVu.DataSource = null;
                dgvDSDichVu.Refresh();
                return;
            }
            DataTable dt = Phong_DAO.LayDSDichVuPhong(idPhong);
            dgvDSDichVu.DataSource = dt;
            dgvDSDichVu.Columns["MaDV"].HeaderText = "Mã dịch vụ";
            dgvDSDichVu.Columns["TenDV"].HeaderText = "Tên dịch vụ";
            dgvDSDichVu.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvDSDichVu.Columns["GiaDV"].HeaderText = "Đơn giá";
            dgvDSDichVu.Columns["ThanhTien"].HeaderText = "Thành Tiền";
        }

    }
}

using DAO;
using DevExpress.XtraEditors;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiKhachSan.Quan_Li_Khach
{
    public partial class KhachHangEditView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private bool isEdit = false;
        public KhachHangEditView()
        {
            InitializeComponent();
            this.Text = "Thêm Mới Khách Hàng";
            isEdit = false;
        }
        public KhachHangEditView(KhachHang_DTO currentKH)
        {
            InitializeComponent();
            this.Text = "Sửa Thông Tin Khách Hàng";
            initForm(currentKH);
            isEdit = true;
        }
        private void initForm(KhachHang_DTO temp)
        {
            teMaKH.Text = temp.ToString();
            teHoTenKH.Text = temp.HoTenKH;
            teDiaChi.Text = temp.DiaChi;
            teDienThoai.Text = temp.DienThoai;
            cbGioiTinh.SelectedValue = temp.GioiTinh;
            teCMND.Text = temp.CMND.ToString();

        }

        private void sbLuu_Click(object sender, EventArgs e)
        {
            KhachHang_DTO temp = new KhachHang_DTO();
            temp.MaKH = string.IsNullOrEmpty(teMaKH.Text) ? -1 : Convert.ToInt32(teMaKH.Text);
            temp.HoTenKH = teHoTenKH.Text;
            temp.DiaChi = teDiaChi.Text;
            temp.DienThoai = teDienThoai.Text;
            temp.GioiTinh = cbGioiTinh.SelectedIndex;
            temp.CMND = Convert.ToInt32(teCMND.Text);

            try
            {
                if (isEdit)
                {
                    KhachHang_DAO.Sua(temp);
                }
                else KhachHang_DAO.Them(temp);
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show( ex.Message,"Thống Báo");
                return;
            }
            XtraMessageBox.Show( isEdit? "Cập nhật":"Thêm Mới" + " thành công", "Thống Báo");
            this.Close();
        }

        private void sbThoat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(teHoTenKH.Text))
            {
                DialogResult dr = XtraMessageBox.Show("Xóa Sẽ Mất Dữ Liệu. Bạn Có Muốn Xóa", "Cảnh Báo", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else this.Close();
        }
    }
}

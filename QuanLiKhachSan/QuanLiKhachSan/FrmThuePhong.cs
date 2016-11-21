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
    public partial class FrmThuePhong : Form
    {
        int IDYeuCau;
        public FrmThuePhong()
        {
            InitializeComponent();
        }
        public void LoadDL()
        {//Nhan vien
            cboNhanVien.DataSource = NhanVien_DAO.LoadDuLieu();
            cboNhanVien.DisplayMember = "HoTenNV";
            cboNhanVien.ValueMember = "MaNV";
          //Khach Hang
            cboKH.DataSource = KhachHang_DAO.LoadDuLieu();
            cboKH.DisplayMember = "HoTenKH";
            cboKH.ValueMember = "MaKH";
           //Loai Phong
            cboLoaiPhong.DataSource = LoaiPhong_DAO.LoadDuLieu();
            cboLoaiPhong.DisplayMember = "LoaiPhong";
            cboLoaiPhong.ValueMember = "MaLoaiPhong";
            

        }
        private void LoadDSDichVu()
        {
            DataTable dt = DichVu_DAO.LoadDuLieu();
            AutoCompleteStringCollection ac = new AutoCompleteStringCollection();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(dt.Rows[i][1].ToString()); //Tên dich vu
                ac.Add(dt.Rows[i][1].ToString());
                item.SubItems.Add(dt.Rows[i][2].ToString()); // don gia
                item.SubItems.Add(dt.Rows[i][0].ToString());//Mã dịch vụ
                lsvDSDichVu.Items.Add(item);
            }
            txtTimDichVu.AutoCompleteCustomSource = ac;
        }
        ListViewItem selectItem;
        private void lsvDSDichVu_Click(object sender, EventArgs e)
        {
            txtTenDV.Text = lsvDSDichVu.SelectedItems[0].SubItems[0].Text;
            txtDonGia.Text = lsvDSDichVu.SelectedItems[0].SubItems[1].Text;
            selectItem = lsvDSDichVu.SelectedItems[0];
            txtTenDV.ReadOnly = true;
            txtDonGia.ReadOnly = true;
            txtSoLuong.ReadOnly = false;
        }
        public void ThemPhieuThuePhong()
        {
            ThuePhong_DTO tp = new ThuePhong_DTO();           
            tp.MaKH = int.Parse(cboKH.SelectedValue.ToString());
            tp.MaNV = int.Parse(cboNhanVien.SelectedValue.ToString());
            tp.NgayThue = DateTime.Now;
            ThuePhong_DAO.Them(tp);
            IDYeuCau = ThuePhong_DAO.LayIDPhieuMoiNhat();
        }

        private void FrmThuePhong_Load(object sender, EventArgs e)
        {
            deThoiGian.DateTime = DateTime.Now;        
            LoadDL();
            LoadDSDichVu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bool kt = false;
            for (int i = 0; i < lsvDSDichVuPhong.Items.Count; i++)
            {
                if (txtTenDV.Text == lsvDSDichVuPhong.Items[i].SubItems[0].Text)
                {
                    int soluong = int.Parse(lsvDSDichVuPhong.Items[i].SubItems[1].Text) + int.Parse(txtSoLuong.Text);
                    kt = true;
                    lsvDSDichVuPhong.Items[i].SubItems[1].Text = soluong.ToString();
                    lsvDSDichVuPhong.Items[i].SubItems[3].Text = (soluong * int.Parse(lsvDSDichVuPhong.Items[i].SubItems[2].Text)).ToString();
                    lsvDSDichVuPhong.Items[i].SubItems[5].Text = cboNhanVien.SelectedValue.ToString();
                    SuaDichVu(lsvDSDichVuPhong.Items[i]);
                }
            }
            if (kt == false)
            {
                ListViewItem item = new ListViewItem(txtTenDV.Text);
                item.SubItems.Add(txtSoLuong.Text);
                item.SubItems.Add(txtDonGia.Text);
                int ThanhTien = int.Parse(txtDonGia.Text) * int.Parse(txtSoLuong.Text);
                item.SubItems.Add(ThanhTien.ToString());
                item.SubItems.Add(selectItem.SubItems[2].Text);//Mã dich vụ
                item.SubItems.Add(cboNhanVien.SelectedValue.ToString());
                lsvDSDichVuPhong.Items.Add(item);
                ThemDichVu(item);
            }
        }
        private void lsvDSDichVuPhong_Click(object sender, EventArgs e)
        {
            selectItem = lsvDSDichVuPhong.SelectedItems[0];
            txtTenDV.Text = selectItem.SubItems[0].Text;
            txtSoLuong.Text = selectItem.SubItems[1].Text;
            txtDonGia.Text = selectItem.SubItems[2].Text;
            cboNhanVien.SelectedValue = selectItem.SubItems[5].Text;
            txtTenDV.ReadOnly = true;
            txtSoLuong.ReadOnly = true;
            txtDonGia.ReadOnly = true;
        }

        private void ThemDichVu(ListViewItem item)
        {
            SuDungDV_DTO ctyc = new SuDungDV_DTO();
            ctyc.MaHD = IDYeuCau;
            ctyc.MaDV = int.Parse(item.SubItems[4].Text);
            ctyc.SoLuong = int.Parse(item.SubItems[1].Text);
            ctyc.MaNV = int.Parse(cboNhanVien.SelectedValue.ToString());
            SuDungDV_DAO.Them(ctyc);
        }

        private void SuaDichVu(ListViewItem item)
        {
            SuDungDV_DTO ctyc = new SuDungDV_DTO();
            ctyc.MaHD = IDYeuCau;
            ctyc.MaDV = int.Parse(item.SubItems[4].Text);
            ctyc.SoLuong = int.Parse(item.SubItems[1].Text);
            ctyc.MaNV = int.Parse(cboNhanVien.SelectedValue.ToString());
            SuDungDV_DAO.Sua(ctyc);

        }

        private void XoaDichVu(ListViewItem item)
        {
            SuDungDV_DTO ctyc = new SuDungDV_DTO();
            ctyc.MaHD = IDYeuCau;
            ctyc.MaDV = int.Parse(item.SubItems[4].Text);
            ctyc.SoLuong = int.Parse(item.SubItems[1].Text);
            ctyc.MaNV = int.Parse(item.SubItems[5].Text);
            SuDungDV_DAO.Xoa(ctyc);
            txtTenDV.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
        }     
      
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            ListViewItem i = lsvDSDichVu.FindItemWithText(txtTimDichVu.Text);
            lsvDSDichVu.TopItem = i;
            lsvDSDichVu.Top = 1;
            i.BackColor = Color.Blue;
        }

        private void keyTimKiem(object sender, KeyEventArgs e)
        {
            ListViewItem i = lsvDSDichVu.FindItemWithText(txtTimDichVu.Text);
            lsvDSDichVu.TopItem = i;
            lsvDSDichVu.Top = 1;
            i.BackColor = Color.Blue;
        }

        private void btnSuaThucDonChon_Click(object sender, EventArgs e)
        {
            txtSoLuong.ReadOnly = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            try
            {
                lsvDSDichVuPhong.Items.Remove(selectItem);
                XoaDichVu(selectItem);
            }
            catch
            {
                MessageBox.Show("Bạn chưa chọn dịch vụ để xóa");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            lsvDSDichVuPhong.SelectedItems[0].SubItems[1].Text = txtSoLuong.Text;
            txtSoLuong.ReadOnly = true;
            SuaDichVu(lsvDSDichVuPhong.SelectedItems[0]);
        }
    }
}

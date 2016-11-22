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
        private int IDYeuCau;
        public static string[] Phongchon;
        public static bool loadcboPhong = false;
        private bool KiemTra=false;
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
            txtSoLuong.Text = "1";
        }
        public void ThemPhieuThuePhong()
        {
            if (KiemTra == false)
            {
                ThuePhong_DTO tp = new ThuePhong_DTO();
                tp.MaKH = int.Parse(cboKH.SelectedValue.ToString());
                tp.MaNV = int.Parse(cboNhanVien.SelectedValue.ToString());
                tp.NgayThue = DateTime.Now;
                ThuePhong_DAO.Them(tp);
                IDYeuCau = ThuePhong_DAO.LayIDPhieuMoiNhat();
                KiemTra = true;

            }

        }
        private void SuaThongTinPhong()
        {
            ChiTietThuePhong_DTO tp = new ChiTietThuePhong_DTO();
            tp.MaHD = IDYeuCau;
            
            for (int i = 0; i < cboPhong.Items.Count; i++)
            {
                string[] s = cboPhong.Items[i].ToString().Split(' ');
               Phong_DTO ba = new Phong_DTO();
                ba.MaPhong = int.Parse(s[1]);
                tp.MaPhong = ba.MaPhong;
               ChiTietThuePhong_DAO.Them1(tp);
                ba.TinhTrang= 1;
                if (cboTrangThai.Text == "Đặt phòng")
                {
                    ba.TinhTrang = 2;
                }
               Phong_DAO.SuaPhong(ba);
            }
        }

        private void FrmThuePhong_Load(object sender, EventArgs e)
        {
            deThoiGian.DateTime = DateTime.Now;        
            LoadDL();
            LoadDSDichVu();
        }
        private void ThemDichVuPhong()
        {
             int ktsoluong=0;
              int.TryParse(txtSoLuong.Text, out ktsoluong);
                if (ktsoluong == 0)
                {
                    MessageBox.Show("Đề nghị bạn nhập lại số lượng!");
                    return;
                }           
    
            ListViewItem item1 = lsvDSDichVuPhong.FindItemWithText(txtTenDV.Text);
            if(item1 != null)
            {
                int slg=int.Parse(item1.SubItems[1].Text) + int.Parse(txtSoLuong.Text);
                item1.SubItems[1].Text = slg.ToString();
                item1.SubItems[3].Text = (slg * int.Parse(item1.SubItems[2].Text)).ToString();
                return;
            }
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTra == false) { MessageBox.Show("Chưa hoàn tất phần thông tin!"); return; }
            ThemDichVuPhong();
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
            lsvDSDichVuPhong.SelectedItems[0].SubItems[3].Text = (int.Parse(txtSoLuong.Text) * int.Parse(lsvDSDichVuPhong.SelectedItems[0].SubItems[2].Text)).ToString();
            txtSoLuong.ReadOnly = true;
            SuaDichVu(lsvDSDichVuPhong.SelectedItems[0]);
        }
        
        private void btnThemPhong_Click(object sender, EventArgs e)
        {
         FrmChonPhong  frm = new FrmChonPhong(cboLoaiPhong.SelectedValue.ToString());
            frm.ShowDialog();
            if (loadcboPhong == true)
            {
              //  cboPhong.Items.Clear();
                for (int i = 0; i < Phongchon.Length; i++)
                {
                    cboPhong.Items.Add(Phongchon[i]);
                }
            }
            loadcboPhong = false;
        }
        bool isHoanTat = false;
        private void btnHoanTat_Click(object sender, EventArgs e)
        {        
            if (cboKH.Text==null)
            {
                MessageBox.Show("Nhập lại Khách");
                return;
            }
            if (cboLoaiPhong.Text == null)
            {
                MessageBox.Show("Chọn Loại Phòng");
                return;
            }
           
            if (cboPhong.Items.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn Phòng");
                return;
            }
            if (lsvDSDichVuPhong.Items.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn dịch vụ");
                return;
            }
            isHoanTat = true;
            SuaThongTinPhong();
            
            MessageBox.Show("Đã gửi yêu cầu thuê phòng");
            this.Close();
        }

        private void frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (isHoanTat == false)
            //{
            //    ThuePhong_DTO pyc = new ThuePhong_DTO();
            //    pyc.MaHD = ThuePhong_DAO.LayIDPhieuMoiNhat();
            //    ThuePhong_DAO.Xoa(pyc);
            //}
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            ThemPhieuThuePhong();
        }
    }
}

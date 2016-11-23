using DAO;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLiKhachSan.Thanh_Toan
{
    public partial class ThanhToanView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private float chiPhi = 0f;
        private float chiPhiPhong = 0f;
        private string currentMaHD;
        private DataRow CurrentRow
        {
            get
            {
                if (gridView2.FocusedRowHandle < 0) return null;
                return gridView2.GetRow(gridView1.FocusedRowHandle) as DataRow;
            }
        }

        public ThanhToanView()
        {
            InitializeComponent();
            initDatabase();
        }

        private void initDatabase()
        {
            gleNhanVien.Properties.DataSource = NhanVien_DAO.LoadDuLieu();
            gleNhanVien.Properties.DisplayMember = "HoTenNV";
            gleNhanVien.Properties.ValueMember = "MaNV";
            repositoryItemGridLookUpEdit1.DataSource = NhanVien_DAO.LoadDuLieu();
            repositoryItemGridLookUpEdit1.DisplayMember = "HoTenNV";
            repositoryItemGridLookUpEdit1.ValueMember = "MaNV";
            gleNhanVien.EditValue = 1;
            deThoiGianTra.EditValue = DateTime.Now;
        }

        private object getCode()
        {
            if (string.IsNullOrEmpty(teCode.Text))
            {
                MessageBox.Show("Chưa Nhập Dữ Liệu", "Thông Báo");
                return null;
            }
            object code = null;
            if (rbTheoPhong.Checked)
            {
                try { code = Convert.ToInt32(teCode.Text); }
                catch
                {
                    MessageBox.Show("Chỉ Nhập Số", "Thông Báo");
                    teCode.Text = "0";
                    return null;
                }
            }
            else
            {
                code = (int)KhachHang_DAO.LoadDuLieuTheoTen(teCode.Text)
                    .Rows[0]["MaKH"];
            }
            return code;
        }

        private void btnLayDuLieu_Click(object sender, EventArgs e)
        {
            object code = getCode();
            if (code == null) return;
            if (rbTheoPhong.Checked)
            {
                DataTable temp = Phong_DAO.LoadDuLieu("where MaPhong=N'" + code.ToString() + "'");
                if (temp.Rows.Count == 0 || (int)temp.Rows[0]["TinhTrang"] != 2)
                {
                    MessageBox.Show("Phòng chưa được thuê hoặc không tồn tại", "Thông Báo");
                    ClearController();
                    return;
                }
                else
                {
                    DataTable chiTietThuePhong = ChiTietThuePhong_DAO.LayHDTheoMaPhong(temp.Rows[0]["MaPhong"].ToString());
                    if (chiTietThuePhong.Rows.Count != 0)
                    {
                        currentMaHD = chiTietThuePhong.Rows[0]["MaHD"].ToString();
                        DataTable hoaDon = ThuePhong_DAO.LoadDuLieuTheoMa(chiTietThuePhong.Rows[0]["MaHD"].ToString());

                        string maKhachHang = hoaDon.Rows[0]["MaKH"].ToString();
                        hoaDon = ThuePhong_DAO.LoadDuLieuTheoMaKH(maKhachHang);
                        DataTable khachHang = KhachHang_DAO.LoadDuLieu(maKhachHang);

                        gcThuePhong.DataSource = hoaDon;
                        if (khachHang.Rows.Count != 0) teTenKH.Text = khachHang.Rows[0]["HoTenKH"].ToString();

                        DataTable dichVu = DichVu_DAO.LoadDuLieu(chiTietThuePhong.Rows[0]["MaHD"].ToString());
                        gcDichVu.DataSource = dichVu;

                        chiPhi = 0f;
                        for (int i = 0; i < dichVu.Rows.Count; i++)
                        {
                            chiPhi += float.Parse(dichVu.Rows[i]["GiaDV"].ToString()) * int.Parse(dichVu.Rows[i]["SoLuong"].ToString());
                        }
                        if (chiPhi != 0f) teThanhTien.Text = chiPhi.ToString("N0") + "Đ";

                        chiPhiPhong = 0f;
                        //tinh chi phi phong
                        for(int i = 0; i<hoaDon.Rows.Count;i++)
                        {
                            float giaPhong = float.Parse(LoaiPhong_DAO.LoadDuLieu().Rows[0]["GiaTien"].ToString());
                            chiPhiPhong += giaPhong * (DateTime.Now.Day - Convert.ToDateTime(hoaDon.Rows[i]["NgayThue"].ToString()).Day);
                        }
                        teChiPhi.Text = (chiPhiPhong + chiPhi).ToString("N0") + "Đ";
                    }
                }
            }
        }

        private void ClearController()
        {
            teCode.ResetText();
            gcThuePhong.DataSource = null;
            gcDichVu.DataSource = null;
            deThoiGianTra.ResetText();
            teCode.ResetText();
            teThanhTien.ResetText();
        }

        private void teCode_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void gridView2_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (CurrentRow != null)
            {
                DataTable dichVu = DichVu_DAO.LoadDuLieu(CurrentRow["MaHD"].ToString());
                gcDichVu.DataSource = dichVu;
            }
        }

        private void gleNhanVien_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void sbThanhToan_Click(object sender, EventArgs e)
        {
            if((chiPhiPhong + chiPhi)==0f)
            {
                return;
            }else
            {
                HDThanhToanPhong_DTO hd = new HDThanhToanPhong_DTO();
                if(!string.IsNullOrEmpty(currentMaHD))
                {
                    hd.MaHD = int.Parse(currentMaHD);
                    hd.MaNV = 1;
                    hd.NgayThanhToan = DateTime.Now;
                    hd.TienPhong = (decimal)(chiPhiPhong + chiPhi);
                    HDThanhToanPhong_DAO.Them(hd);

                    MessageBox.Show("Đã thanh toán", "Thông Báo");

                    DataTable chitietThuePhong = ChiTietThuePhong_DAO.LayHDTheoMa(currentMaHD);
                    for(int i=0;i<chitietThuePhong.Rows.Count;i++)
                    {
                        Phong_DTO temp = new Phong_DTO() { MaPhong = int.Parse(chitietThuePhong.Rows[i]["MaPhong"].ToString())
                            , TinhTrang = 0 };
                        Phong_DAO.SuaTinhTrang(temp);
                    }
                    this.Close();
                }
            }
        }
    }
}
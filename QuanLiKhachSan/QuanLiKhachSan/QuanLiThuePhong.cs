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
    public partial class QuanLiThuePhong : Form
    {
        private string MaHD = "";
        private string MaPhong;
      //  private int MaLoaiPhong;
        public QuanLiThuePhong()
        {
            InitializeComponent();
        }
    //    private bool KiemTra=false;
        private void QuanLiThuePhong_Load(object sender, EventArgs e)
        {
            grdThuePhong.DataSource = ThuePhong_DAO.LoadChiTiet();
        }

        private void grdThuePhong_Click(object sender, EventArgs e)
        {
            try
            {
          
                //KiemTra = true;
                MaHD = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaHD").ToString();
               grdChiTietThuePhong.DataSource = ChiTietThuePhong_DAO.LayHDTheoMa(MaHD);
               grdSuDungDV.DataSource = SuDungDV_DAO.LoadDuLieuTheoMa(MaHD);
             }
            catch (Exception ex)
            {
                MessageBox.Show("Không có dữ liệu", "THÔNG BÁO", MessageBoxButtons.OK);
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            //Sửa Phiếu Thuê
            try
            {

                FrmSuaPhieuThue frm = new FrmSuaPhieuThue(MaHD);
                frm.ShowDialog();
                grdThuePhong.DataSource = ThuePhong_DAO.LoadChiTiet();

            }
            catch
            {
                MessageBox.Show("Bạn chưa chọn phiếu thuê!");
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Sửa chi tiết phiếu thuê
            try
            {

                FrmSuaChiTietPhieuThue frm = new FrmSuaChiTietPhieuThue(MaHD,MaPhong);
                frm.ShowDialog();
                grdChiTietThuePhong.DataSource = ChiTietThuePhong_DAO.LayHDTheoMa(MaHD);

            }
            catch
            {
                MessageBox.Show("Bạn chưa chọn phiếu thuê!");
            }
        }

        private void grdChiTietThuePhong_Click(object sender, EventArgs e)
        {
          
            try
            {
                MaPhong = gridView2.GetRowCellValue(gridView1.FocusedRowHandle, "MaPhong").ToString();      
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có dữ liệu", "THÔNG BÁO", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnReLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grdThuePhong.DataSource = ThuePhong_DAO.LoadChiTiet();
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ShowPrintPreview();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Xóa Chi Tiết
            try
            {
                ChiTietThuePhong_DTO ct = new ChiTietThuePhong_DTO();
                ct.MaHD = int.Parse(MaHD);
                ct.MaPhong = int.Parse(MaPhong);
                ChiTietThuePhong_DAO.Xoa(ct);
                grdSuDungDV.DataSource = SuDungDV_DAO.LoadDuLieuTheoMa(MaHD);
            }
            catch
            {
                MessageBox.Show("Bạn chưa chọn phiếu thuê!");
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Sửa dịch vụ
            try
            {

                FrmSuaHoaDonDV frm = new FrmSuaHoaDonDV(int.Parse(MaPhong), int.Parse(MaHD));
                frm.ShowDialog();
                grdSuDungDV.DataSource = SuDungDV_DAO.LoadDuLieuTheoMa(MaHD);

            }
            catch
            {
                MessageBox.Show("Bạn chưa chọn phiếu thuê!");
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Xóa
                 try
            {

            SuDungDV_DTO sd = new SuDungDV_DTO();
            sd.MaHD =int.Parse( MaHD);
            SuDungDV_DAO.Xoa1(sd);
            ChiTietThuePhong_DTO ct = new ChiTietThuePhong_DTO();
            ct.MaHD = int.Parse(MaHD);
            ChiTietThuePhong_DAO.Xoa1(ct);
            ThuePhong_DTO tp = new ThuePhong_DTO();
            tp.MaHD = int.Parse(MaHD);
            ThuePhong_DAO.Xoa(tp);
            grdThuePhong.DataSource = ThuePhong_DAO.LoadChiTiet();
            }
                 catch
                 {
                     MessageBox.Show("Bạn chưa chọn phiếu thuê!");
                 }


        }
    }
}

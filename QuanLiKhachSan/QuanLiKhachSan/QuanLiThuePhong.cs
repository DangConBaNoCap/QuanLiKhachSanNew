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
                MaPhong = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MaPhong").ToString();      
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có dữ liệu", "THÔNG BÁO", MessageBoxButtons.OK);
            }
        }
    }
}

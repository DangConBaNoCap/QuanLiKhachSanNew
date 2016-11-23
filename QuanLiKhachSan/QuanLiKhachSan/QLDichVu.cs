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
    public partial class QLDichVu : Form
    {
        private string MaDichV = "";
        public QLDichVu()
        {
            InitializeComponent();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void QLDichVu_Load(object sender, EventArgs e)
        {
            grdDV.DataSource = DichVu_DAO.LoadDuLieu();
         }

        private void QLDichVu_Click(object sender, EventArgs e)
        {
            MaDichV=gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaDV").ToString();  
        }

        private void bbiThemKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmThemDichVu frm = new FrmThemDichVu();
            frm.ShowDialog();
            grdDV.DataSource = DichVu_DAO.LoadDuLieu();
        }

        private void bbiSuaKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Quan_Li_Khach.FrmSuaDivhVu frm = new Quan_Li_Khach.FrmSuaDivhVu(MaDichV);
                frm.ShowDialog();
                grdDV.DataSource = DichVu_DAO.LoadDuLieu();

            }
            catch
            {
                MessageBox.Show("Bạn chưa chọn dịch vụ cần sửa");
            }
        }

        private void bbiXoaKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                SuDungDV_DTO sd = new SuDungDV_DTO();
                sd.MaDV = int.Parse(MaDichV);
                SuDungDV_DAO.Xoa2(sd);
                DichVu_DTO dv = new DichVu_DTO();
                dv.MaDV = int.Parse(MaDichV);
                DichVu_DAO.Xoa(dv);
                grdDV.DataSource = DichVu_DAO.LoadDuLieu();
            }
            catch
            {
                MessageBox.Show("Bạn chưa chọn dịch vụ cần sửa");
            }

        }

    }
}

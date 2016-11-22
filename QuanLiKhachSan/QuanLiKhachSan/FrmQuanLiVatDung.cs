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
    public partial class FrmQuanLiVatDung : Form
    {
        public FrmQuanLiVatDung()
        {
            InitializeComponent();
        }
       
      
      
       void khoadk()
        {
            txtMaTB.Enabled = false;
            txtTenTB.Enabled = false;
            txtSoluong.Enabled = false;
            txtGiaTB.Enabled = false;

            btnThem.Enabled = true;
            btnLuu.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }
        void modk()
       {
           txtMaTB.Enabled = true;
           txtTenTB.Enabled = true;
           txtSoluong.Enabled = true;
           txtGiaTB.Enabled = true;

           btnThem.Enabled = false;
           btnLuu.Enabled = true;
           btnXoa.Enabled = false;
           btnSua.Enabled = false;
       }
        bool them;
        private void FrmQuanLiVatDung_Load(object sender, EventArgs e)
        {
            dgvVatdung.DataSource = Phong_DAO.LayDuLieu();
            DataTable p = Phong_DAO.LayLoaiPhong("");
            cboLoaiphong.DataSource = p;
            cboLoaiphong.DisplayMember = "LoaiPhong";
            cboLoaiphong.ValueMember = "MaLoaiPhong";
            khoadk();
        }

       

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            modk();
        }
       

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
           
        }
        private void toolTimMa_Click(object sender, EventArgs e)
        {

        }
    }
}

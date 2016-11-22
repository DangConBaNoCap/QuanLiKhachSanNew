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
    public partial class FrmQuanLiPhong : Form
    {
      
        public FrmQuanLiPhong()
        {
            InitializeComponent();
        }
        Phong_DAO busphong = new Phong_DAO();
        Phong_DTO entiphong = new Phong_DTO();
        void khoadk()
        {
            txtMaPhong.Enabled = false;
            txtGiatien.Enabled = false;
            txtTinhtrang.Enabled = false;
            cboLoaiphong.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }
        void modk()
        {
            txtMaPhong.Enabled = false;
            txtGiatien.Enabled = false;
            txtTinhtrang.Enabled = true;
            cboLoaiphong.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }
        void gannull()
        {
            txtMaPhong.Text = "";
            txtGiatien.Text = "";
            txtTinhtrang.Text = "";
        }
        bool them;
        string LoaiPhong;
        private void FrmQuanLiPhong_Load(object sender, EventArgs e)
        {
            dgvPhong.DataSource = Phong_DAO.LayDuLieu();
            DataTable p = Phong_DAO.LayLoaiPhong("");
            cboLoaiphong.DataSource = p;
            cboLoaiphong.DisplayMember = "LoaiPhong";
            cboLoaiphong.ValueMember = "MaLoaiPhong";
            LoaiPhong = cboLoaiphong.SelectedText.ToString();
            khoadk();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            modk();
            them = true;
            

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            modk();
            them = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            entiphong.TinhTrang = int.Parse(txtTinhtrang.Text.ToString());
            entiphong.MaLoaiPhong = int.Parse(cboLoaiphong.SelectedValue.ToString());
            if(them==true)
            {
                Phong_DAO.Them(entiphong);
            }
            else
            {
                Phong_DAO.Sua(entiphong);
            }
            dgvPhong.DataSource = Phong_DAO.LayDuLieu();
            khoadk();
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            txtMaPhong.Text = dgvPhong.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
            cboLoaiphong.SelectedValue = dgvPhong.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
            txtGiatien.Text = dgvPhong.Rows[e.RowIndex].Cells["Column3"].Value.ToString();
            txtTinhtrang.Text = dgvPhong.Rows[e.RowIndex].Cells["Column4"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                entiphong.MaPhong =int.Parse( txtMaPhong.Text.ToString());
                Phong_DAO.Xoa(entiphong);
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi " + ex.Message);
            }
            gannull();
            khoadk();
            dgvPhong.DataSource = Phong_DAO.LayDuLieu();
           
        }

       
        private void toolTimLP_TextChanged(object sender, EventArgs e)
        {
            string dk = toolTimLP.Text.ToString();
            if (dk == string.Empty)
            {
                dgvPhong.DataSource = Phong_DAO.LayDuLieu();
            }
            else
            dgvPhong.DataSource = Phong_DAO.TimKiem("where Phong.MaLoaiPhong=" + dk.Trim());
        }

        private void toolTimGia_TextChanged(object sender, EventArgs e)
        {
            string dk = toolTimGia.Text.ToString();
            if (dk == string.Empty)
            {
                dgvPhong.DataSource = Phong_DAO.LayDuLieu();
            }
            else
                dgvPhong.DataSource = Phong_DAO.TimKiem("where LoaiPhong.GiaTien=" + dk.Trim());
        }

        private void toolTimMaphong_TextChanged(object sender, EventArgs e)
        {
            string dk = toolTimMaphong.Text.ToString();
            if (dk == string.Empty)
            {
                dgvPhong.DataSource = Phong_DAO.LayDuLieu();
            }
            else dgvPhong.DataSource = Phong_DAO.TimKiem("where Phong.MaPhong=" + dk.Trim());
        }

       

       

       

      
        
    }
}

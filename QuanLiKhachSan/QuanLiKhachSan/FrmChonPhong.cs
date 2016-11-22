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
    public partial class FrmChonPhong : Form
    {
        private string MaLoaiPhong;
        public FrmChonPhong(string MaLP)
        {
            MaLoaiPhong = MaLP;
            InitializeComponent();
        }

        private void FrmChonPhong_Load(object sender, EventArgs e)
        {
            bool kt = false;
            DataTable dt = Phong_DAO.LoadDuLieuTheoLoaiPhong(MaLoaiPhong);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][2].ToString() == "0")
                {
                    kt = true;
                    clbBan.Items.Add("Phòng " + dt.Rows[i][0].ToString() );
                }

            }
            if(kt==false)
            {
                this.Close();
                MessageBox.Show("Hết phòng loại đây!","Thông báo");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
          FrmThuePhong.loadcboPhong = true;
           FrmThuePhong.Phongchon = new string[clbBan.CheckedItems.Count];
            for (int i = 0; i < clbBan.CheckedItems.Count; i++)
            {
               FrmThuePhong.Phongchon[i] = clbBan.CheckedItems[i].ToString();
            }
            this.Close();
        }


    }
}

using DAO;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DTO;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLiKhachSan.Quan_Li_Khach
{
    public partial class KhachHangListView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private List<KhachHang_DTO> _listKhachHang = new List<KhachHang_DTO>();

        private KhachHang_DTO CurrentKhachHang
        {
            get
            {
                if (gridView1.FocusedRowHandle < 0) return null;
                return gridView1.GetRow(gridView1.FocusedRowHandle) as KhachHang_DTO;
            }
        }

        private bool AllowEdit
        {
            get
            {
                if (CurrentKhachHang == null) return false;
                if (gridView1.SelectedRowsCount == 1) return gridView1.FocusedRowHandle == gridView1.GetSelectedRows()[0];
                return gridView1.SelectedRowsCount == 2;
            }
        }

        public KhachHangListView()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            gcListKhachHang.DataSource = GetAllData();
            bbiSuaKH.Enabled = false;
        }

        private object GetKHsData()
        {
            IEnumerable ret = from _khachHang in _listKhachHang
                              select _khachHang;
            return ret.Cast<KhachHang_DTO>().ToList();
        }

        private object ConverToListKH(DataTable ds)

        {
            _listKhachHang.Clear();
            for (int i = 0; i < ds.Rows.Count; i++)
            {
                KhachHang_DTO temp = new KhachHang_DTO();
                temp.MaKH = (int)ds.Rows[i]["MaKH"];
                temp.HoTenKH = ds.Rows[i]["HoTenKH"].ToString();
                temp.DiaChi = ds.Rows[i]["DiaChi"].ToString();
                temp.DienThoai = ds.Rows[i]["DienThoai"].ToString();
                temp.GioiTinh = (int)ds.Rows[i]["GioiTinh"];
                temp.CMND = (int)ds.Rows[i]["CMND"];
                _listKhachHang.Add(temp);
            }
            return null;
        }

        private object GetAllData()
        {
            DataTable listKhachHang = new DataTable();

            listKhachHang = KhachHang_DAO.LoadDuLieu();
            if (listKhachHang != null) ConverToListKH(listKhachHang);

            return GetKHsData();
        }

        private void EnabledActionButtons()
        {
            if (CurrentKhachHang != null)
                EnabledFlagButtons(true, AllowEdit);
            else EnabledFlagButtons(false, AllowEdit);
        }

        internal void EnabledFlagButtons(bool enabledCurrentTask, bool enabledEdit)
        {
            bbiXoaKH.Enabled = enabledCurrentTask;
            bbiSuaKH.Enabled = enabledEdit;
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            EnabledActionButtons();
        }

        private void bbiXoaKH_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("Xóa Sẽ Mất Dữ Liệu. Bạn Có Muốn Xóa", "Cảnh Báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                RemoveCurrentKH(_listKhachHang);
            }
            init();
        }

        private void RemoveCurrentKH(List<KhachHang_DTO> list)
        {
            if (gridView1.SelectedRowsCount == 0 && CurrentKhachHang != null) list.Remove(CurrentKhachHang);
            else
            {
                List<KhachHang_DTO> selectedTasks = new List<KhachHang_DTO>();
                foreach (int index in gridView1.GetSelectedRows())
                {
                    KhachHang_DTO task = gridView1.GetRow(index) as KhachHang_DTO;
                    if (task != null) selectedTasks.Add(task);
                }
                foreach (KhachHang_DTO task in selectedTasks)
                {
                    if(!KhachHang_DAO.Xoa(task)) XtraMessageBox.Show("Khách hàng đang đặt phòng,không thể xóa",
                        "Thông Báo");
                    list.Remove(task);
                }
            }
        }

        private void bbiSuaKH_ItemClick(object sender, ItemClickEventArgs e)
        {
            KhachHangEditView temp = new KhachHangEditView(CurrentKhachHang);
            temp.ShowDialog();
            init();
        }

        private void bbiThemKH_ItemClick(object sender, ItemClickEventArgs e)
        {
            KhachHangEditView temp = new KhachHangEditView();
            temp.ShowDialog();
            init();
        }
    }
}
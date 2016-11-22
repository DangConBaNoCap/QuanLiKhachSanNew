using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang_DTO
    {
        private int _MaKH;

        public int MaKH
        {
            get { return _MaKH; }
            set { _MaKH = value; }
        }
        private string _HoTenKH;

        public string HoTenKH
        {
            get { return _HoTenKH; }
            set { _HoTenKH = value; }
        }
        private string _DiaChi;

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        private string _DienThoai;

        public string DienThoai
        {
            get { return _DienThoai; }
            set { _DienThoai = value; }
        }
        private int _GioiTinh;

        public int GioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }
        private int _CMND;

        public int CMND
        {
            get { return _CMND; }
            set { _CMND = value; }
        }
    }
}

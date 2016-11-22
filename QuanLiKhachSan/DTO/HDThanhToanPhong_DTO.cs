using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HDThanhToanPhong_DTO
    {
        private int _MaThanhToan;

        public int MaThanhToan
        {
            get { return _MaThanhToan; }
            set { _MaThanhToan = value; }
        }
        private int _MaHD;

        public int MaHD
        {
            get { return _MaHD; }
            set { _MaHD = value; }
        }
        private int _MaNV;

        public int MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
        private DateTime _NgayThanhToan;

        public DateTime NgayThanhToan
        {
            get { return _NgayThanhToan; }
            set { _NgayThanhToan = value; }
        }
        private decimal _TienPhong;

        public decimal TienPhong
        {
            get { return _TienPhong; }
            set { _TienPhong = value; }
        }
    }
}

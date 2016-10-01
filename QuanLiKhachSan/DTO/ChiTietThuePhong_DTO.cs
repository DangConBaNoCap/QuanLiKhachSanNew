using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietThuePhong_DTO
    {
        private int _MaHD;

        public int MaHD
        {
            get { return _MaHD; }
            set { _MaHD = value; }
        }
        private int _MaPhong;

        public int MaPhong
        {
            get { return _MaPhong; }
            set { _MaPhong = value; }
        }
        private DateTime _NgayTra;

        public DateTime NgayTra
        {
            get { return _NgayTra; }
            set { _NgayTra = value; }
        }

    }
}

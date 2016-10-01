using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TrangBiPhong_DTO
    {
        private int _MaLoaiPhong;

        public int MaLoaiPhong
        {
            get { return _MaLoaiPhong; }
            set { _MaLoaiPhong = value; }
        }
        private int _MaTB;

        public int MaTB
        {
            get { return _MaTB; }
            set { _MaTB = value; }
        }
        private int _SoLuong;

        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }
    }
}

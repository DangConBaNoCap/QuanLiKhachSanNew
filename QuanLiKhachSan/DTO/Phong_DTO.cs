using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public class Phong_DTO
    {
        private int _MaPhong;

        public int MaPhong
        {
            get { return _MaPhong; }
            set { _MaPhong = value; }
        }
        private int _MaLoaiPhong;

        public int MaLoaiPhong
        {
            get { return _MaLoaiPhong; }
            set { _MaLoaiPhong = value; }
        }
        private int _TinhTrang;

        public int TinhTrang
        {
            get { return _TinhTrang; }
            set { _TinhTrang = value; }
        }

    
    }
}

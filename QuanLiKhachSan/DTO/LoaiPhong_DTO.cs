using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiPhong_DTO
    {
        private int _MaLoaiPhong;

        public int MaLoaiPhong
        {
            get { return _MaLoaiPhong; }
            set { _MaLoaiPhong = value; }
        }
        private string _LoaiPhong;

        public string LoaiPhong
        {
            get { return _LoaiPhong; }
            set { _LoaiPhong = value; }
        }
        private decimal _GiaTien;

        public decimal GiaTien
        {
            get { return _GiaTien; }
            set { _GiaTien = value; }
        }
    }
}

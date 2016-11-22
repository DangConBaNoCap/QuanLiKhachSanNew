using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class TaiKhoan_DTO
    {
        private string _TaiKhoan;

        public string TaiKhoan
        {
            get { return _TaiKhoan; }
            set { _TaiKhoan = value; }
        }
        private string _MatKhau;

        public string MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }
        private int _MaNV;

        public int MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
    }
}

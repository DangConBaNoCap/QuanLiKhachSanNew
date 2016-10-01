using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SuDungDV_DTO
    {
        private int _MaHD;

        public int MaHD
        {
            get { return _MaHD; }
            set { _MaHD = value; }
        }
        private int _MaDV;

        public int MaDV
        {
            get { return _MaDV; }
            set { _MaDV = value; }
        }
        private int _SoLuong;

        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }
        private int _MaNV;

        public int MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
    }
}

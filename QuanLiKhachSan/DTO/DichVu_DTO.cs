using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DichVu_DTO
    {
        private int _MaDV;

        public int MaDV
        {
            get { return _MaDV; }
            set { _MaDV = value; }
        }
        private string _TenDV;

        public string TenDV
        {
            get { return _TenDV; }
            set { _TenDV = value; }
        }
        private decimal _GiaDV;

        public decimal GiaDV
        {
            get { return _GiaDV; }
            set { _GiaDV = value; }
        }
    }
}

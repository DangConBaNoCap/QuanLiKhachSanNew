using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class ThietBi_DTO
    {
        private int _MaTB;

        public int MaTB
        {
            get { return _MaTB; }
            set { _MaTB = value; }
        }
        private string _TenThietBi;

        public string TenThietBi
        {
            get { return _TenThietBi; }
            set { _TenThietBi = value; }
        }
        private decimal _GiaTB;

        public decimal GiaTB
        {
            get { return _GiaTB; }
            set { _GiaTB = value; }
        }
    }
}

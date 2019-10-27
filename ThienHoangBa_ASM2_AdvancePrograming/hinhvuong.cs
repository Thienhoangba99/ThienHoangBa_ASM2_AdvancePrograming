using System;
using System.Collections.Generic;
using System.Text;

namespace thienApp_AD_ASM_2
{
    class hinhvuong : hinhtugiaccan
    {   
        public hinhvuong(int length) : base(length)
        {
          
        }
        public int tinhdientich(int length)
        {
            return length * length;
        }
        public int tinhchuvi(int length)
        {
            return (length * 4);
        }
    }
}

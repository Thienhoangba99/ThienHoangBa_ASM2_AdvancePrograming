using System;
using System.Collections.Generic;
using System.Text;

namespace thienApp_AD_ASM_2
{
    class hinhchunhat : hinhtugiaccan
    {
        public hinhchunhat(int length, int width) : base(length, width)
        {
            
        }
        public int tinhdientich(int length,int width)
        {
            return length * width;
        }
        public int tinhchuvi(int length,int width)
        {
            return (length + width)*2;
        }
    }
}

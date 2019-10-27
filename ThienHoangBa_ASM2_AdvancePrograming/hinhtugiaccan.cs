using System;
using System.Collections.Generic;
using System.Text;

namespace thienApp_AD_ASM_2
{
    class hinhtugiaccan
    {
        private int height;
        private int weight;
        public hinhtugiaccan(int height, int weight)
        {
            this.height = height;
            this.weight = weight;
        }
        public int tinhdientich()
        {
            return height * weight;
        }
        public int tinhchuvi()
        {
            return (height + weight) * 2;
        }
    }
}

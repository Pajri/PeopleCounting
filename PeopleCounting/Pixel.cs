using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCounting
{
    class Pixel
    {
        public int x { get; set; }
        public int y { get; set; }
        public byte value { get; set; }
        public String label { get; set; }

        /*
         * Params
         * x : index col
         * y : indec row
         */ 
        public Pixel(int y, int x, byte value)
        {
            this.x = x;
            this.y = y;
            this.value = value;
        }
        
    }
}

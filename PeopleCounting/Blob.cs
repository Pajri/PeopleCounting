using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCounting
{
    class Blob
    {
        public string label { get; set; }
        public List<Pixel> pixelList { get; set; }

    

        public Blob(string label, List<Pixel> pixelList)
        {
            this.label = label;
            this.pixelList = pixelList;
        }
    }
}

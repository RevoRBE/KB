using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Gallery.Models
{
    public class Sculpture : ArtWork
    {
        public Sculpture()
        {
            this.Pictures = new List<byte[]>();
        }

        public List<byte[]> Pictures { get; set; }
    }
}

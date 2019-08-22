using System;
using System.Collections.Generic;
using System.Text;

namespace Gallery.Models
{
    public class ArtWork
    {
        public int Id { get; set; }

        public int TypeId { get; set; }
        public int SecondaryTypeId { get; set; }
        // public ArtWorkType Type { get; set; }

        public int SizeX { get; set; }
        public int SizeY { get; set; }
        public int? SizeZ { get; set; }

        public ICollection<Material> Material { get; set; }

        //TODO: Tag
        public ICollection<Tag> Tag { get; set; }

        //public Style Style { get; set; }
    }
}

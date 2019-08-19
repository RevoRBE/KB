using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gallery.Models
{
    public class GalleryUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}

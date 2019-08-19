using System;
using System.Collections.Generic;
using System.Text;
using Gallery.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Gallery.Data
{
    public class GalleryDbContext : IdentityDbContext<GalleryUser>
    {
        public GalleryDbContext(DbContextOptions<GalleryDbContext> options)
            : base(options)
        {
        }
    }
}

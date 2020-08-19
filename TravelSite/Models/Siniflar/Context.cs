using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace TravelSite.Models.Siniflar
{
    public class Context : DbContext
    {
        public DbSet<Admin> admins { get; set; }
        public DbSet<AdresBlog> adresBlogs { get; set; }
        public DbSet<AnaSayfa> anaSayfas { get; set; }
        public DbSet<Blog> blogs { get; set; }
        public DbSet<Hakkimizda> hakkimizdas { get; set; }
        public DbSet<Iletisim> iletisims { get; set; }
        public DbSet<Yorumlar> yorumlars { get; set; }



    }
}
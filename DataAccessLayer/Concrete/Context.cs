using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS;database=CoreBlogDb;integrated security=true;");
        }
        public DbSet<Blog> BlogVT { get; set; }
        public DbSet<Hakkinda> HakkindaVT { get; set; }
        public DbSet<Iletisim> IletisimVT { get; set; }
        public DbSet<Kategori> KategoriVT { get; set; }
        public DbSet<Yazar> YazarVT { get; set; }
        public DbSet<Yorum> YorumVT { get; set; }
    }
}

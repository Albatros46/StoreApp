using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Data.Concrete
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products => Set<Product>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {//Test verilerini ekleme islemi DataSeeding icin 
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .HasData(
                new List<Product>() 
                    {  
                        new (){ Id=1,Name="iPhone Pro 14 Pro",Price=1400,Description="Yeni nesil Iphone",Category="Telefon"},
                        new (){ Id=2,Name="reMarkable 3.0",Price=500,Description="Digital not defteri",Category="Tablet"},
                        new (){ Id=3,Name="reMarkable 2.0",Price=300,Description="Digital not defteri",Category="Tablet"},
                        new (){ Id=4,Name="MacBook Pro",Price=3000,Description="Laptop",Category="Laptop"},
                        new (){ Id=5,Name="Asus Rog Game ",Price=2700,Description="Yeni nesil Game Laptop",Category="Laptop"},
                        new (){ Id=6,Name="NOC Bildschirm 21 Zoll",Price=485,Description="Oyucnular icin hizli monitor",Category="Monitor"},
                        new (){ Id=7,Name="Samsung 65 inc TV",Price=1252,Description="OLED TV",Category="TV"},
                        new (){ Id=8,Name="Dyson 14",Price=250,Description="Yeni nesil elektrikli süpürge",Category="Elektrikli ev Aletleri"},
                    }
                );
        }
    }
}

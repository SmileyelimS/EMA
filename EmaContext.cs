using EMA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMA
{
    public class EmaContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=EmaDatabase;user=user;password=EmaPassWord");
        }

        public DbSet<Dealer> Dealers { get; set; }
        public DbSet<CustomerData> CustomerDatas { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderedItem> OrderedItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Dealer>(x =>
            {
                x.ToTable("dealer").HasKey(k => k.DealerID);
                x.Property(p => p.DealerID).HasColumnName("ID");
            });

            modelBuilder.Entity<CustomerData>(x =>
            {
                x.ToTable("customerdata").HasKey(k => k.CustomerDataID);
                x.Property(p => p.CustomerDataID).HasColumnName("ID");
            }); 
            
            modelBuilder.Entity<Item>(x =>
            {
                x.ToTable("items").HasKey(k => k.ItemID);
                x.Property(p => p.ItemID).HasColumnName("ID");
                x.Ignore(p => p.ComboboxList);
            }); 
            
            modelBuilder.Entity<Order>(x =>
            {
                x.ToTable("orders").HasKey(k => k.OrdersID);
                x.Property(p => p.OrdersID).HasColumnName("ID");
            }); 
            
            modelBuilder.Entity<OrderedItem>(x =>
            {
                x.ToTable("ordereditems").HasKey("OrdersID", "ItemsID");
                x.Property(p => p.OrdersID).HasColumnName("OrdersID");
                x.Property(p => p.ItemsID).HasColumnName("ItemsID");
            });
        }
    }
}

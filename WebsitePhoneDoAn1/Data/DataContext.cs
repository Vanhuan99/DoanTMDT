using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebsitePhoneDoAn1.Models;
using WebsitePhoneDoAn1.Models.Domain;

namespace WebsitePhoneDoAn1.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>().HasData(
                   new Category()
                   {
                      CategoryId = 1,
                      CategoryName = "Iphone"
                   },
                   new Category()
                   {
                       CategoryId = 2,
                       CategoryName = "Xiaomi"
                   },
                   new Category()
                   {
                       CategoryId = 3,
                       CategoryName = "Huawei"
                   },
                   new Category()
                   {
                       CategoryId = 4,
                       CategoryName = "Oppo"
                   },
                  new Category()
                   {
                      CategoryId = 5,
                      CategoryName = "Vivo"
                   },
                  new Category()
                   {
                      CategoryId = 6,
                      CategoryName = "Vsmart"
                   },
                   new Category()
                   {
                      CategoryId = 7,
                      CategoryName = "SamSung"
                   });

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Name = "Visitor",
                    NormalizedName = "VISITOR"
                },
                new IdentityRole
                {
                    Name = "Administrator",
                    NormalizedName = "ADMINNISTRATOR"
                });      
        }
    }
}

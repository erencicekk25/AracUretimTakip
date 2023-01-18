using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UretimTakip.Entities;
using Type = UretimTakip.Entities.Type;

namespace UretimTakip.DataAccess
{
    public class xContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-DAF3DSF2\\SQLEXPRESS;database=UretimProje;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Data Seed
            modelBuilder.Entity<Admin>().HasData(new Admin
            {
                ID = 1,
                NameSurname = "Admin",
                UserName = "admin",
                Password = "123456789"
            });

            modelBuilder.Entity<User>().HasData(new User
            {
                ID = 1,
                NameSurname = "User",
                UserName = "user",
                Password = "123456789"
            });
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Type> Types { get; set; }
    }
}

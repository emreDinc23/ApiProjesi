using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.EntityLayer.Concreate;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.DataAccessLayer.Concrate
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"server=DESKTOP-KB1DL1B\EMREDINC;initial catalog=ApiDb;integrated security=true");
        }

        public DbSet<Portföy> Portföys { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Testimonial> Testimonials{ get; set; }
    }
}

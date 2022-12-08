using baiquanlyweb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace baiquanlyweb.Context
{
    public class quanlydbcontext : DbContext
    {
        public DbSet<quanly> quanlies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = LAPTOP-I5RNPV3S\SQLEXPRESS01;Initial Catalog = quanlydb;Integrated Security = true");
        }
        
    }
}

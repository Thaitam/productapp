using Microsoft.EntityFrameworkCore;
using productapp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace productapp.Context
{
    public class productDbcontext : DbContext
    {
        public DbSet<Product> products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = LAPTOP-I5RNPV3S\SQLEXPRESS01;Initial Catalog=ProductDB;Integrated Security=true");
        }
    }
}

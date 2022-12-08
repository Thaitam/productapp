using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ontap.Core.Models;

namespace Ontap.Core.Context
{
    public class HrDbContext : DbContext //add source SQL cua may vao 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Data Source=DESKTOP-K7ED08D\\SQLEXPRESS;initial catalog=Hr;" +
               "user id=sa;password=abc123!;MultipleActiveResultSets=True;");
        }
        public DbSet<Employee> Employees { get; set; }    
    }
}

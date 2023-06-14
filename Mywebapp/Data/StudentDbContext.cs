using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mywebapp.Model;

namespace Mywebapp.Data
{
    public class StudentDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=.\SQLEXPRESS01;Database=StudentDb;Trusted_Connection=True;Encrypt=False");
        }
        public DbSet<Student>? Students {get;set;}
    }
}
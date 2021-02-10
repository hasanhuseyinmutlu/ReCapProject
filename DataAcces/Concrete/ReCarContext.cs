using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Concrete
{
    public class ReCarContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"(localdb)\MSSQLLocalDB;Database=ReCarProjectDb;Truseted_Connection=true") ;
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}

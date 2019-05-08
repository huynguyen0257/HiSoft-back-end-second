using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using HiSoft.Model;
using Microsoft.EntityFrameworkCore;

namespace HiSoft.Data
{
    public class HiSoftDbContext: IdentityDbContext<MyUser>
    {
        public HiSoftDbContext() : base((new DbContextOptionsBuilder())
            .UseLazyLoadingProxies()
            .UseSqlServer(@"Server=.;Database=VASDB;user id=.;password=.;Trusted_Connection=True;Integrated Security=false;")
            .Options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public void Commit()
        {
            base.SaveChanges();
        }
    }
}

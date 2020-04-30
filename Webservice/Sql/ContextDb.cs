using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webservice.Model;

namespace Webservice.Sql
{
    public class ContextDb : DbContext
    {
        public ContextDb(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Lab> TblLabs { get; set; }
        public DbSet<SyncTable> SyncTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Lab>().HasKey(f => f.LabID);
            modelBuilder.Entity<SyncTable>().HasKey(f => f.ID);
        }
    }
}

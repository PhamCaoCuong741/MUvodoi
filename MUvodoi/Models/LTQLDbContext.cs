using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GiaiptBac1.Models
{
    public partial class LTQLDbContext : DbContext

    {
        public LTQLDbContext() : base("name=LTQLDbContext")
        {
        }
        public virtual DbSet<Account> Students { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(e => e.Studentname)
                .IsUnicode(false)
        }
        public virtual DbSet<Account> Accounts { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
            .Property(e => e.Username)
            .IsUnicode(false);
        }
    }
}
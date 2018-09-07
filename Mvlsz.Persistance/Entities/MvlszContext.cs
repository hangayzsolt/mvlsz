using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Mvlsz.Persistance.Configurations;

namespace Mvlsz.Persistance.Entities
{
    public class MvlszContext : DbContext
    {
        protected MvlszContext()
        {
        }

        public MvlszContext(DbContextOptions options) : base(options)
        {
        }

        #region public properties
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
            {
                throw new ArgumentNullException(nameof(modelBuilder));
            }

            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserConfiguration(modelBuilder.Entity<User>()));
            modelBuilder.ApplyConfiguration(new RoleConfiguration(modelBuilder.Entity<Role>()));
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration(modelBuilder.Entity<UserRole>()));
        }
    }
}

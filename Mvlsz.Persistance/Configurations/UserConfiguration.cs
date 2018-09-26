using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mvlsz.Persistance.Entities;

namespace Mvlsz.Persistance.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public UserConfiguration(EntityTypeBuilder<User> builder)
        {
            Configure(builder);
        }


        public void Configure(EntityTypeBuilder<User> entity)
        {
            entity.Property(e => e.UserName).HasMaxLength(20).IsRequired();
            entity.Property(e => e.Email).HasMaxLength(40).IsRequired();
            entity.Property(e => e.Name).HasMaxLength(50).IsRequired();
            entity.Property(e => e.EmailConfirmed).HasDefaultValue(false);
            entity.Property(e => e.IsActive).HasDefaultValue(false);
            entity.Property(e => e.PasswordHash).HasMaxLength(64);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mvlsz.Persistance.Entities;

namespace Mvlsz.Persistance.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public UserRoleConfiguration(EntityTypeBuilder<UserRole> builder)
        {
            Configure(builder);
        }

        public void Configure(EntityTypeBuilder<UserRole> entity)
        {
            entity.Property(e => e.UserId).IsRequired();
            entity.Property(e => e.RoleId).IsRequired();
        }
    }
}

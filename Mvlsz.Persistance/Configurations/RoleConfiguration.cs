using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mvlsz.Persistance.Entities;

namespace Mvlsz.Persistance.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public RoleConfiguration(EntityTypeBuilder<Role> builder)
        {
            Configure(builder);
        }

        public void Configure(EntityTypeBuilder<Role> entity)
        {
            entity.Property(e => e.RoleType)
                .IsRequired()
                .HasMaxLength(20);
        }
    }
}

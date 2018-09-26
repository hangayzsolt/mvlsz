using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mvlsz.Persistance.Entities;

namespace Mvlsz.Persistance.Configurations
{
    public class MatchConfiguration : IEntityTypeConfiguration<Match>
    {
        public MatchConfiguration(EntityTypeBuilder<Match> builder)
        {
            Configure(builder);
        }

        public void Configure(EntityTypeBuilder<Match> entity)
        {
            entity.Property(e => e.Place).IsRequired().HasMaxLength(30);
            entity.Property(e => e.DateTime).HasColumnType("datetime2");
            entity.Property(e => e.Division).IsRequired().HasMaxLength(15);
            entity.Property(e => e.HomeTeam).IsRequired().HasMaxLength(40);
            entity.Property(e => e.VisitorTeam).IsRequired().HasMaxLength(40);
            entity.Property(e => e.IsClosed).HasDefaultValue(false);
        }
    }
}

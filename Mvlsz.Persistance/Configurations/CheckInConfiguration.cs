using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mvlsz.Persistance.Entities;

namespace Mvlsz.Persistance.Configurations
{
    public class CheckInConfiguration : IEntityTypeConfiguration<CheckIn>
    {
        public CheckInConfiguration(EntityTypeBuilder<CheckIn> builder)
        {
            Configure(builder);
        }

        public void Configure(EntityTypeBuilder<CheckIn> entity)
        {
            entity.Property(e => e.UserId).IsRequired();
            entity.Property(e => e.MatchId).IsRequired();

            entity.HasOne(d => d.Match)
                .WithMany(p => p.CheckIn)
                .HasForeignKey(d => d.MatchId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CheckIn_Match");


        }
    }
}

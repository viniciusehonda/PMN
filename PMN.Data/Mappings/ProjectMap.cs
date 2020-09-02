using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PMN.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PMN.Data.Mappings
{
    public class ProjectMap : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(t => t.NidProject);
            builder.Property(t => t.TidProject).HasMaxLength(80);
            builder.Property(t => t.DesProject).HasMaxLength(240);
        }
    }
}

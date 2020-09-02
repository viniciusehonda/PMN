using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PMN.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PMN.Data.Mappings
{
    public class ProjectTaskMap : IEntityTypeConfiguration<ProjectTask>
    {
        public void Configure(EntityTypeBuilder<ProjectTask> builder)
        {
            builder.HasKey(a => a.NidTask);
            builder.HasOne(a => a.Project)
                .WithMany(a => a.ProjectTasks)
                .HasForeignKey(a => a.NidProject);

            builder.Property(a => a.TidTask).HasMaxLength(140);
        }
    }
}

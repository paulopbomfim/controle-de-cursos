using ControleDeCursos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleDeCursos.Data.Mappings;

public class LeadMap : IEntityTypeConfiguration<Lead>
{
    public void Configure(EntityTypeBuilder<Lead> builder)
    {
        builder.ToTable("Leads");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();
        
        builder.Property(x => x.Name)
            .IsRequired()
            .HasColumnType("NVARCHAR")
            .HasMaxLength(100);
        builder.Property(x => x.Email)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(320);
        builder.Property(x => x.CPF)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(11);
        
        builder.HasIndex(x => x.Email, "IX_Lead_Email")
            .IsUnique();
        builder.HasIndex(x => x.CPF, "IX_Lead_CPF")
            .IsUnique();

        builder.HasMany(x => x.Courses)
            .WithMany(x => x.Leads)
            .UsingEntity<Dictionary<string, object>>(
                "LeadCourse",
                Lead => Lead.HasOne<Course>()
                    .WithMany()
                    .HasForeignKey("LeadId")
                    .HasConstraintName("FK_LeadCourse_LeadId")
                    .OnDelete(DeleteBehavior.Cascade),
                
                Course => Course.HasOne<Lead>()
                    .WithMany()
                    .HasForeignKey("CourseId")
                    .HasConstraintName("FK_LeadCourse_CourseId")
                    .OnDelete(DeleteBehavior.Cascade)
            );
    }
}
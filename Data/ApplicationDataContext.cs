using ControleDeCursos.Data.Mappings;
using ControleDeCursos.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleDeCursos.Data;

public class ApplicationDataContext : DbContext, IApplicationDataContext
{
  public virtual DbSet<Course> Courses { get; set; }
  public virtual DbSet<Lead> Leads { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder options)
  {
    var connectionString = Environment.GetEnvironmentVariable("DOTNET_CONNECTION_STRING");

    if (connectionString is null) {
      throw new ArgumentException("Connection string not found");
    }

    options.UseSqlServer(connectionString);
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.ApplyConfiguration(new CourseMap());
    modelBuilder.ApplyConfiguration(new LeadMap());
  }
}
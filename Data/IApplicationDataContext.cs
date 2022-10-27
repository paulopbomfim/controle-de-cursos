using Microsoft.EntityFrameworkCore;
using ControleDeCursos.Models;

namespace ControleDeCursos.Data;

public interface IApplicationDataContext
{
    public DbSet<Course> Courses { get; set; }
    public DbSet<Lead> Leads { get; set; }
    public int SaveChanges();
}
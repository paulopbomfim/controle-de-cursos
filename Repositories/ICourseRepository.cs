using ControleDeCursos.Models;

namespace ControleDeCursos.Repositories;

public interface ICourseRepository
{
    public Course Add(Course course);
    public IList<Course> GetAll();
    public Course? GetById(int id);
    // public Course GetByEmail(string email);
    public Course? Update(Course course);
    // public bool Delete(int id);
}
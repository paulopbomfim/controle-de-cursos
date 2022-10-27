using ControleDeCursos.Data;
using ControleDeCursos.Models;

namespace ControleDeCursos.Repositories;

public class CourseRepository
{
    protected readonly ApplicationDataContext _context;

    public CourseRepository(ApplicationDataContext context)
    {
        this._context = context;
    }

    public bool Create(Course course)
    {
        _context.Add(course);
       int response = _context.SaveChanges();
       if (response > 0) return true;
       return false;
    }

    // public IEnumerable<Course> GetAll()
    // {

    // }

    // public Course GetById(int id)
    // {

    // }

    // public Course GetByEmail(string email)
    // {

    // }

    // public Course Update(int id)
    // {

    // }

    // public bool Delete(int id)
    // {

    // }
}
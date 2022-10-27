using Microsoft.EntityFrameworkCore;

using ControleDeCursos.Data;
using ControleDeCursos.Models;

namespace ControleDeCursos.Repositories;

public class CourseRepository : ICourseRepository
{
    protected readonly ApplicationDataContext _context;

    public CourseRepository(ApplicationDataContext context)
    {
        this._context = context;
    }

    public Course Add(Course course)
    {
        _context.Courses.Add(course);
        _context.SaveChanges();
        return course;
       
    }

    public IList<Course> GetAll()
    {
        return _context.Courses.ToList();
    }

    public Course? GetById(int id)
    {
        var course = _context.Courses.AsNoTracking().Include(x => x.Leads).FirstOrDefault(x => x.Id == id);
        return course;
    }

    // public Course GetByEmail(string email)
    // {

    // }

    public Course? Update(Course course)
    {
        Course? courseFound = GetById(course.Id);
        
        if (courseFound == null)
        {
            throw new Exception("Houve um erro ao tentar atualizar o curso");
        }

        courseFound.Name = course.Name;
        courseFound.Name = course.Description;
        _context.SaveChanges();

        return courseFound;
    }

    // public bool Delete(int id)
    // {

    // }
}
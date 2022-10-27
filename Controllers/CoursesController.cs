using Microsoft.AspNetCore.Mvc;
using ControleDeCursos.Models;
using ControleDeCursos.Repositories;

namespace ControleDeCursos.Controllers;

public class CoursesController : Controller
{
    private readonly ICourseRepository _courseRepository;

    public CoursesController(ICourseRepository courseRepository)
    {
        _courseRepository = courseRepository;
    }

    public IActionResult Index()
    {
        IList<Course> courses = _courseRepository.GetAll();
        return View(courses);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Course course)
    {
        _courseRepository.Add(course);
        return RedirectToAction("Index");
    }

    public IActionResult Edit(int id) {
        Course? course = _courseRepository.GetById(id);
        return View(course);
    }

    [HttpPut]
    public IActionResult Update(Course course) {
        _courseRepository.Update(course);
        return RedirectToAction("Index");
    }

    public IActionResult Details(int id) {
        Course? course = _courseRepository.GetById(id);
        return View(course);
    }
}

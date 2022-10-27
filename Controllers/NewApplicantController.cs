using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ControleDeCursos.Models;

namespace ControleDeCursos.Controllers;

public class NewApplicantController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}

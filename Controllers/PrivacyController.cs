using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using controle_de_cursos.Models;

namespace controle_de_cursos.Controllers;

public class PrivacyController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

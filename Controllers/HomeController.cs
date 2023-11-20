using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using portafolio.Models;
using Portfolio.Models;

namespace portafolio.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // var persona = new Persona(){
        //     Name = "Juan Facundo Tam",
        //     Career = "FullStack Developer"
        // };
        // return View("index", persona);
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

private List<Proyecto> ObtenerProyectos()
{
    return new List<Proyecto>() {
        new Proyecto
        {
            Id = 1,
            Title = "Spotify Clone",
            Description = "EN CONSTRUCCION - App clon de Spotify desarrollada con Typescript, Angular y Node",
            Image = "foto7",
            ImageAlt = "foto proyecto 1",
            Link = "https://spotify-angular-xi.vercel.app/",
            TechArray = new string[] { /* tus elementos de HTML aquí */"" }
        }
    };
}

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

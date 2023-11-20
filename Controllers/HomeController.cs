using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using portafolio.Models;
using portafolio.Servicios;
// using Portfolio.Models;

namespace portafolio.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ProyectRepository proyectRepository;

    public HomeController(ILogger<HomeController> logger, ProyectRepository proyectRepository)
    {
        _logger = logger;
        this.proyectRepository = proyectRepository;
    }

    public IActionResult Index()
    {
        // var persona = new Persona(){
        //     Name = "Juan Facundo Tam",
        //     Career = "FullStack Developer"
        // };
        // return View("index", persona);
        var proyectRepository = new ProyectRepository();
       var proyectos = proyectRepository.ObtenerProyectos().Take(3).ToList();
        var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
        return View(modelo);
    }

    public IActionResult Privacy()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using portafolio.Models;

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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

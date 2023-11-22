using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging; // Asegúrate de tener esta importación para ILogger
using portafolio.Models;
using portafolio.Servicios;

namespace portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProyectRepository _proyectRepository;


        public HomeController(
            ILogger<HomeController> logger,
            ProyectRepository proyectRepository)
        {
            _logger = logger;
            _proyectRepository = proyectRepository;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Este es un mensaje de log");
            var proyectos = _proyectRepository.ObtenerProyectos().Take(3).ToList();

 

            var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
            return View(modelo);
        }

        public IActionResult Proyectos()
        {
            var proyectos = _proyectRepository.ObtenerProyectos();
            return View(proyectos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

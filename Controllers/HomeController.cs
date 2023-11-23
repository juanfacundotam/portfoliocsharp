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
        private readonly IServicioEmail servicioEmail;

        public HomeController(
            ILogger<HomeController> logger,
            ProyectRepository proyectRepository, IServicioEmail servicioEmail)
        {
            _logger = logger;
            _proyectRepository = proyectRepository;
            this.servicioEmail = servicioEmail;
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

        [HttpGet] //En realidad todas son Get por eso no se suele poner, porque viene por defecto
        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost] // si es otro si se pone
        public async Task<ActionResult> Contacto(ContactoViewModel contactoViewModel)
        {
            await servicioEmail.Enviar(contactoViewModel);
            return RedirectToAction("Gracias");
        }
        public IActionResult Gracias()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

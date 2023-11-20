using portafolio.Models;

namespace portafolio.Servicios
{

    public interface IProyectRepository
    {
        List<Proyecto> ObtenerProyectos();
    }

    public class ProyectRepository : IProyectRepository
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() {
        new Proyecto
        {
            Id = 1,
            Title = "Spotify Clone",
            Description = "EN CONSTRUCCION - App clon de Spotify desarrollada con Typescript, Angular y Node",
            Image = "/imagenes/foto7.webp",
            ImageAlt = "foto proyecto 1",
            Link = "https://spotify-angular-xi.vercel.app/",
            TechArray = new string[] { /* tus elementos de HTML aquí */"" }
        },
        new Proyecto
        {
            Id = 2,
            Title = "Car Shop",
            Description = "EN CONSTRUCCION - App ecommerce para la venta de autos",
            Image = "/imagenes/foto6.webp",
            ImageAlt = "foto proyecto 2",
            Link = "https://car-showcase-cyan-eight.vercel.app/",
            TechArray = new string[] { /* tus elementos de HTML aquí */"" }
        },
        new Proyecto
        {
            Id = 3,
            Title = "Chat estilo Discord",
            Description = "Proyecto Freelance Personal - Chat estilo Discord con tecnologia RealTime",
            Image = "/imagenes/foto5.webp",
            ImageAlt = "foto proyecto 5",
            Link = "https://react-firebase-app-d4e2b.web.app/login",
            TechArray = new string[] { /* tus elementos de HTML aquí */"" }
        },
        new Proyecto
        {
            Id = 4,
            Title = "Social Media Lab IA",
            Description = "VERSION DESKTOP - En colaboración con el equipo de la startup europea Social Media Lab IA, desarrollamos una plataforma de gestión para empleados. Me involucré activamente en el desarrollo, abarcando tanto el frontend como el backend, así como la configuración de la base de datos. Juntos, logramos crear una solución integral que cumple con los objetivos y requisitos de la startup.",
            Image = "/imagenes/foto1.webp",
            ImageAlt = "foto proyecto 1",
            Link = "https://sml-employees.vercel.app/",
            TechArray = new string[] { /* tus elementos de HTML aquí */"" }
        },
        new Proyecto
        {
            Id = 5,
            Title = "Food Recipes App",
            Description = "Como parte del bootcamp de Soy Henry, llevé a cabo un desafiante proyecto individual fullstack. Me encargué de desarrollar tanto el frontend, el backend, como tambien la BDD, abarcando todas las etapas del proceso. Fue una oportunidad invaluable para aplicar mis habilidades y adquirir experiencia práctica en el desarrollo de aplicaciones web completas. Se demora mucho en traer recetas, debido al servidor gratuito.",
            Image = "/imagenes/foto2.webp",
            ImageAlt = "foto proyecto 5",
            Link = "https://food-app-client.netlify.app",
            TechArray = new string[] { /* tus elementos de HTML aquí */"" }
        },
        new Proyecto
        {
            Id = 6,
            Title = "Rick and Morty App",
            Description = "Realicé un emocionante proyecto fullstack como parte de la integración de la primera parte del bootcamp de Soy Henry. Desarrollé habilidades tanto en el frontend como en el backend, abarcando un enfoque completo del desarrollo web. Fue una experiencia enriquecedora que me permitió aplicar mis conocimientos y adquirir una visión holística de la construcción de aplicaciones web.",
            Image = "/imagenes/foto3.webp",
            ImageAlt = "foto proyecto 6",
            Link = "https://rick-and-morty-app-henry.netlify.app/",
            TechArray = new string[] { /* tus elementos de HTML aquí */"" }
        },
        new Proyecto
        {
            Id = 7,
            Title = "Pokedex App Mobile",
            Description = "LINK VIDEO - En este proyecto desarrollé una aplicación móvil fullstack utilizando React Native y consumiendo la API oficial de Pokemon. La app fue realizada en una capacitacion de la startUp donde trabajo actualmente",
            Image = "/imagenes/foto4.webp",
            ImageAlt = "foto proyecto 7",
            Link = "https://www.youtube.com/watch?v=X-ULTdYthE0",
            TechArray = new string[] { /* tus elementos de HTML aquí */"" }
        },
    };
        }
    }
}
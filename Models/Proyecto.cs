namespace Portfolio.Models
{
    public class Proyecto {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string ImageAlt { get; set; }
        public string Link { get; set; }
        public string[] TechArray { get; set; }
    }
}


    // {
    //   id: 2,
    //   tittle: "Car Shop",
    //   description: "EN CONSTRUCCION - App ecommerce para la venta de autos",
    //   // description: "En mi participación en el proyecto para Social Media Lab IA, asumí un papel integral como desarrollador fullstack. Me encargué del frontend, backend y la configuración de la base de datos. En el frontend, creé una interfaz de usuario atractiva y receptiva, utilizando tecnologías modernas. En el backend, implementé la lógica de negocio y aseguré un rendimiento óptimo. Además, configuré una base de datos eficiente para almacenar y gestionar los datos de manera segura. Fue una experiencia enriquecedora en la que pude demostrar mis habilidades en todas las áreas del desarrollo web.",
    //   image: "foto6",
    //   imagealt: "foto proyecto 2",
    //   link: "https://car-showcase-cyan-eight.vercel.app/",
    //   tecnology: [<SiTypescript className={style.icon}/>, <SiMongodb className={style.icon}/>, <SiReact className={style.icon}/>, <SiNextdotjs className={style.icon}/>, <SiTailwindcss className={style.icon}/>],
    // },
    // {
    //   id: 3,
    //   tittle: "Chat estilo Discord",
    //   // description: "En mi participación en el proyecto para Social Media Lab IA, asumí un papel integral como desarrollador fullstack. Me encargué del frontend, backend y la configuración de la base de datos. En el frontend, creé una interfaz de usuario atractiva y receptiva, utilizando tecnologías modernas. En el backend, implementé la lógica de negocio y aseguré un rendimiento óptimo. Además, configuré una base de datos eficiente para almacenar y gestionar los datos de manera segura. Fue una experiencia enriquecedora en la que pude demostrar mis habilidades en todas las áreas del desarrollo web.",
    //   description: "Proyecto Freelance Personal - Chat estilo Discord con tecnologia RealTime",
    //   image: "foto5",
    //   imagealt: "foto proyecto 3",
    //   link: "https://react-firebase-app-d4e2b.web.app/login",
    //   tecnology: [<SiJavascript className={style.icon}/>, <SiReact className={style.icon}/>, <SiFirebase className={style.icon}/>, <SiTailwindcss className={style.icon}/>],
    // },
    // {
    //   id: 4,
    //   tittle: "Social Media Lab IA",
    //   // description: "En mi participación en el proyecto para Social Media Lab IA, asumí un papel integral como desarrollador fullstack. Me encargué del frontend, backend y la configuración de la base de datos. En el frontend, creé una interfaz de usuario atractiva y receptiva, utilizando tecnologías modernas. En el backend, implementé la lógica de negocio y aseguré un rendimiento óptimo. Además, configuré una base de datos eficiente para almacenar y gestionar los datos de manera segura. Fue una experiencia enriquecedora en la que pude demostrar mis habilidades en todas las áreas del desarrollo web.",
    //   description: "VERSION DESKTOP - En colaboración con el equipo de la startup europea Social Media Lab IA, desarrollamos una plataforma de gestión para empleados. Me involucré activamente en el desarrollo, abarcando tanto el frontend como el backend, así como la configuración de la base de datos. Juntos, logramos crear una solución integral que cumple con los objetivos y requisitos de la startup.",
    //   image: "foto1",
    //   imagealt: "foto proyecto 4",
    //   link: "https://sml-employees.vercel.app/",
    //   tecnology: [<SiJavascript className={style.icon}/>, <SiReact className={style.icon}/>, <SiRedux className={style.icon}/>, <SiExpress className={style.icon}/>, <SiMongodb className={style.icon}/>, <SiTailwindcss className={style.icon}/>],
    // },
    // {
    //   id: 5,
    //   tittle: "Food Recipes App",
    //   description: "Como parte del bootcamp de Soy Henry, llevé a cabo un desafiante proyecto individual fullstack. Me encargué de desarrollar tanto el frontend, el backend, como tambien la BDD, abarcando todas las etapas del proceso. Fue una oportunidad invaluable para aplicar mis habilidades y adquirir experiencia práctica en el desarrollo de aplicaciones web completas. Se demora mucho en traer recetas, debido al servidor gratuito.",
    //   image: "foto2",
    //   imagealt: "foto proyecto 5",
    //   link: "https://food-app-client.netlify.app",
    //   tecnology: [<SiJavascript className={style.icon}/>, <SiReact className={style.icon}/>, <SiRedux className={style.icon}/>, <SiExpress className={style.icon}/>, <SiPostgresql className={style.icon}/>, <SiSequelize className={style.icon}/>],
    // },
    // {
    //   id: 6,
    //   tittle: "Rick and Morty App",
    //   description: "Realicé un emocionante proyecto fullstack como parte de la integración de la primera parte del bootcamp de Soy Henry. Desarrollé habilidades tanto en el frontend como en el backend, abarcando un enfoque completo del desarrollo web. Fue una experiencia enriquecedora que me permitió aplicar mis conocimientos y adquirir una visión holística de la construcción de aplicaciones web.",
    //   image: "foto3",
    //   imagealt: "foto proyecto 6",
    //   link: "https://rick-and-morty-app-henry.netlify.app/",
    //   tecnology: [<SiJavascript className={style.icon}/>, <SiReact className={style.icon}/>, <SiRedux className={style.icon}/>, <SiExpress className={style.icon}/>, <SiPostgresql className={style.icon}/>, <SiSequelize className={style.icon}/>],
    // },
    // {
    //   id: 7,
    //   tittle: "Pokedex App Mobile",
    //   description: "LINK VIDEO - En este proyect desarrollé una aplicación móvil fullstack utilizando React Native y consumiendo la API oficial de Pokemon. La app fue realizada en una capacitacion de la startUp donde trabajo actualmente",
    //   image: "foto4",
    //   imagealt: "foto proyecto 7",
    //   link: "https://www.youtube.com/watch?v=X-ULTdYthE0",
    //   tecnology: [<SiReact className={style.icon}/>, <SiReact className={style.icon}/>, <SiReact className={style.icon}/>],
    // },
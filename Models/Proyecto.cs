namespace portafolio.Models
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


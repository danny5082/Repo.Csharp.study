namespace SmartFactory_MinProject.Models
{
    public class Codeboard
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Contents { get; set; }
        public DateTime Date { get; set; } = DateTime.Now.Date;
    }
}

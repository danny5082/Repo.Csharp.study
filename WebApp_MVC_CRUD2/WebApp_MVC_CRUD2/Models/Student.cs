using System.ComponentModel.DataAnnotations;

namespace WebApp_MVC_CRUD2.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Hp { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace WebAppMVC_Diary.Models
{
    public class Diarys
    {
        [Key]
        public int No { get; set; }
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        public string Content { get; set; }
        public DateTime Date { get; set; } = DateTime.Now.Date;
    }
}

using System.ComponentModel.DataAnnotations;

namespace WebAppValidationAttribute.Models
{
    public class Student
    {

        [Required(ErrorMessage = "이름이 없습니다.")]
        [StringLength(15,MinimumLength =2)]
        public string Name { get; set; }
    }
}

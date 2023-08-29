using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace WebApplQuiz6.Models
{
    public class Score
    {
        [Required]
        public string rnrdj { get; set; }
        public string duddj { get; set; }
        public string tngkr { get; set; }
        public string tkghl { get; set; }
        public string rhkgkr { get; set; }

    }
}

namespace WebAppTagHelpers_forms02.Models
{
    public class Student
    {
        public String NAME { get; set; }
        public Gender Gender { get; set; }
        public int AGE { get; set; }
        public String HP { get; set; }

        public String IsEmployed { get; set; }

        public string Description { get; set; }
    }
    public enum Gender
    {
        남,
        여
    }
}

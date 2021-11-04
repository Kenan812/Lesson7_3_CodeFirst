namespace Lesson7_3_CodeFirst.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Gender Gender { get; set; }

        public Mark Mark { get; set; }
    }

    public enum Gender
    {
        Male, Female
    }
}





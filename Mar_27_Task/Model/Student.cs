using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Student
    {
        public int StudentId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
} 
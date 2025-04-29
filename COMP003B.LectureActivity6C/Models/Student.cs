using System.ComponentModel.DataAnnotations;

namespace COMP003B.LectureActivity6C.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        //collection navigation property
        public virtual ICollection<Enrollment>? Enrollments { get; set; }

        public int Age { get; set; }
    }
}

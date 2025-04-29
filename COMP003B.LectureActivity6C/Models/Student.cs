using System.ComponentModel.DataAnnotations;

namespace COMP003B.LectureAcvtivity6.Models
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
    }
}

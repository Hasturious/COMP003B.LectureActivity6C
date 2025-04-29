using System.ComponentModel.DataAnnotations;

namespace COMP003B.LectureAcvtivity6.Models
{
    public class Course
    {
        public int CourseID { get; set; }

        [Required]
        public string Title { get; set; }

        //collection navigation property
        public virtual ICollection<Enrollment>? Enrollments { get; set; }
    }
}

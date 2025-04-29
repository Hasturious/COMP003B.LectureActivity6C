using System.ComponentModel.DataAnnotations;

namespace COMP003B.LectureActivity6C.Models
{
    public class Enrollment
    {
        public int ID { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }

        //collection navigation property
        public virtual ICollection<Enrollment>? Enrollments { get; set; }
    }
}

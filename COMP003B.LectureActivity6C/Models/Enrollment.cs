using System.ComponentModel.DataAnnotations;

namespace COMP003B.LectureAcvtivity6.Models
{
    public class Enrollments 
    {
        public int ID { get; set; }
        public string StudentID { get; set; }
        public string CourseID { get; set; }

        //collection navigation property
        //public virtual ICollection<Enrollment>? Enrollments { get; set; }
    }
}

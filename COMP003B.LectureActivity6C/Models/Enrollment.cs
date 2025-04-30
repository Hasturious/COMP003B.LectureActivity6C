using System.ComponentModel.DataAnnotations;

namespace COMP003B.LectureActivity6C.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        //collection navigation property
        public virtual Student? Student { get; set; }
        public virtual Course? Course { get; set; }
    }
}

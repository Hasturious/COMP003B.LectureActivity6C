using COMP003B.LectureAcvtivity6.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP003B.LectureAcvtivity6.Data
{
    public class WebDevAcademyContext : DbContext
    {
        public WebDevAcademyContext(DbContextOptions<WebDevAcademyContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollments> Enrollments { get; set; }
    }
}

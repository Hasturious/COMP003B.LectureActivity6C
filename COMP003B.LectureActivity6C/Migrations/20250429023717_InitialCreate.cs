using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace COMP003B.LectureActivity6C.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                    table.ForeignKey(
                        name: "FK_Students_Students_StudentID1",
                        column: x => x.StudentID1,
                        principalTable: "Students",
                        principalColumn: "StudentID");
                });

            migrationBuilder.CreateTable(
                name: "Enrollments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseID1 = table.Column<int>(type: "int", nullable: true),
                    EnrollmentID = table.Column<int>(type: "int", nullable: true),
                    StudentID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Enrollments_Courses_CourseID1",
                        column: x => x.CourseID1,
                        principalTable: "Courses",
                        principalColumn: "CourseID");
                    table.ForeignKey(
                        name: "FK_Enrollments_Enrollments_EnrollmentID",
                        column: x => x.EnrollmentID,
                        principalTable: "Enrollments",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Enrollments_Students_StudentID1",
                        column: x => x.StudentID1,
                        principalTable: "Students",
                        principalColumn: "StudentID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_CourseID1",
                table: "Enrollments",
                column: "CourseID1");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_EnrollmentID",
                table: "Enrollments",
                column: "EnrollmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_StudentID1",
                table: "Enrollments",
                column: "StudentID1");

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentID1",
                table: "Students",
                column: "StudentID1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enrollments");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}

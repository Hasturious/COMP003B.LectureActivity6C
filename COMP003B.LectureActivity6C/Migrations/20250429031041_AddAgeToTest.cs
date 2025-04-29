using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace COMP003B.LectureActivity6C.Migrations
{
    /// <inheritdoc />
    public partial class AddAgeToTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Courses_CourseID1",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Students_StudentID1",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Students_StudentID1",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_StudentID1",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_CourseID1",
                table: "Enrollments");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_StudentID1",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "StudentID1",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CourseID1",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "StudentID1",
                table: "Enrollments");

            migrationBuilder.AlterColumn<int>(
                name: "StudentID",
                table: "Enrollments",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "CourseID",
                table: "Enrollments",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_CourseID",
                table: "Enrollments",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_StudentID",
                table: "Enrollments",
                column: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Courses_CourseID",
                table: "Enrollments",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Students_StudentID",
                table: "Enrollments",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Courses_CourseID",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Students_StudentID",
                table: "Enrollments");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_CourseID",
                table: "Enrollments");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_StudentID",
                table: "Enrollments");

            migrationBuilder.AddColumn<int>(
                name: "StudentID1",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StudentID",
                table: "Enrollments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CourseID",
                table: "Enrollments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CourseID1",
                table: "Enrollments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentID1",
                table: "Enrollments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentID1",
                table: "Students",
                column: "StudentID1");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_CourseID1",
                table: "Enrollments",
                column: "CourseID1");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_StudentID1",
                table: "Enrollments",
                column: "StudentID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Courses_CourseID1",
                table: "Enrollments",
                column: "CourseID1",
                principalTable: "Courses",
                principalColumn: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Students_StudentID1",
                table: "Enrollments",
                column: "StudentID1",
                principalTable: "Students",
                principalColumn: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Students_StudentID1",
                table: "Students",
                column: "StudentID1",
                principalTable: "Students",
                principalColumn: "StudentID");
        }
    }
}

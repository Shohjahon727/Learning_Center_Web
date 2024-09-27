using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_School.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CourseName",
                table: "Students",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AppUserId", "CourseName", "CoursePrice", "Description", "ImageUrl", "TeacherImageUrl", "TeacherName" },
                values: new object[,]
                {
                    { 1, null, "Ingliz tili", 500.0, "Kursimiz haqida toliqroq malumot olish ushun tel : +998-95-215-72-27 ", "", "", "Mr Abdurahmon" },
                    { 2, null, "Ona tili", 500.0, "Kursimiz haqida toliqroq malumot olish ushun tel : +998-95-215-72-27 ", "", "", "Mahbubaxon Sultonova" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "AppUserId", "CourseName", "Description", "FullName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Qoqon", null, "Ingliz tili", "03.06.2003 yil tugilgan , Otasining ismi : Ulugbek , Otasining telefon raqami : 99-721-72-27", "Shohjahon Alijonov", "90-307-78-47" },
                    { 2, "Qoqon", null, "Ona tili", "03.06.2006 yil tugilgan , Otasining ismi : Ulugbek , Otasining telefon raqami : 99-721-72-27", "Nodirbek Alijonov", "90-307-78-47" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "AppUserId", "Description", "FullName", "ImageUrl", "Subject" },
                values: new object[,]
                {
                    { 1, null, " Erishgan natijalari Ielts darajasi : 8.5. 3 yillik tajribaga ega ", "Nasriddinov Abdurahmon", "", "Ingliz tili oqituvchisi" },
                    { 2, null, "5 yillik tajribaga ega bolgan oqituvchi. Minglab oquvchilarimizga dars bergan ", "Sultonova Mahbubaxon", "", "Ona tili" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "CourseName",
                table: "Students");
        }
    }
}

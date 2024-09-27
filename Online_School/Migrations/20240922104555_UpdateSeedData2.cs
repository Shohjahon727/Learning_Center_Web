using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_School.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "FullName",
                value: "Sultonova \nMahbubaxon");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "FullName",
                value: "Sultonova Mahbubaxon");
        }
    }
}

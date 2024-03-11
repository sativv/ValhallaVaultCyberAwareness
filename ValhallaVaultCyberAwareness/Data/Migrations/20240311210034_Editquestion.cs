using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ValhallaVaultCyberAwareness.Migrations
{
    /// <inheritdoc />
    public partial class Editquestion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 14,
                column: "Title",
                value: "Forskningsdata om ny teknologi stulen");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 14,
                column: "Title",
                value: "Statssponsrade hackers");
        }
    }
}

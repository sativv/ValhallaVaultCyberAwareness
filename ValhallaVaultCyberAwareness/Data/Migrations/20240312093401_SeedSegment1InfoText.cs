using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ValhallaVaultCyberAwareness.Migrations
{
    /// <inheritdoc />
    public partial class SeedSegment1InfoText : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 1,
                column: "InfoText",
                value: "Bedrägerier är handlingar där en person eller grupp försöker vilseleda, lura eller bedranågon annan för personlig vinning. Det kan omfatta olika platformar samt olika metoder som exempelvisinternet, telefon, e-post och personlig interaktion.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 1,
                column: "InfoText",
                value: null);
        }
    }
}

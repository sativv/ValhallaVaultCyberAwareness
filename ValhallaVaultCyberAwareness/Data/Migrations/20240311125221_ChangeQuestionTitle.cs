using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ValhallaVaultCyberAwareness.Migrations
{
    /// <inheritdoc />
    public partial class ChangeQuestionTitle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "Oväntat telefonsamtal");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "Begäran om pengar från datingsida");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Title",
                value: "Exklusivt investeringserbjudande");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "Oidentifierade transaktioner");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Title",
                value: "Konfidentiella dokument läcker till konkurrenter");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Title",
                value: "Sårbarhet i programvara");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Title",
                value: "DDoS-attack");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Title",
                value: "Ökning av säkerhetsincidenter vid distansarbete");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Title",
                value: "Cyberangrepp som krypterar patientdata");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Title",
                value: "Maersk");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 11,
                column: "Title",
                value: "Känslig politisk kommunikation har läckt");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 12,
                column: "Title",
                value: "Skadeprogramskampanj");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 13,
                column: "Title",
                value: "Interna säkerhetsprotokoll");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 14,
                column: "Title",
                value: "Statssponsrade hackers");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 15,
                column: "Title",
                value: "Någon efterfrågar personlig finansiell information");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 16,
                column: "Title",
                value: "Hur kommunicerar finansiella institutioner");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 17,
                column: "Title",
                value: "Skydda dig mot telefonbedrägeri");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 18,
                column: "Title",
                value: "Säkerställa anställdas ansvar");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 19,
                column: "Title",
                value: "Otrygga Wi-Fi-nätvärk");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 20,
                column: "Title",
                value: "Åtgärd mot e-postbaserade intrång");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 21,
                column: "Title",
                value: "Mest effektiva försvarsstrategi");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 22,
                column: "Title",
                value: "Upptäck och motverka insiderhot");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 23,
                column: "Title",
                value: "Skydd mot cyberspionage");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "Kreditkortsbedrägeri");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "Romansbedrägeri");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Title",
                value: "Investeringsbedrägeri");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "Telefonbedrägeri");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Title",
                value: "Digital säkerhet på företag");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Title",
                value: "Risker och beredskap");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Title",
                value: "Aktörer inom cyberbrott");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Title",
                value: "Ökad digital närvaro och distansarbete");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Title",
                value: "Cyberangrepp mot känsliga sektorer");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Title",
                value: "Cyberrånet mot Mersk");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 11,
                column: "Title",
                value: "Allmänt om cyberspionage");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 12,
                column: "Title",
                value: "Metoder för cyberspionage");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 13,
                column: "Title",
                value: "Säkerhetsskyddslagen");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 14,
                column: "Title",
                value: "Cyberspionagets aktörer");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 15,
                column: "Title",
                value: "Kreditkortsbedrägeri");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 16,
                column: "Title",
                value: "Kreditkortsbedrägeri");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 17,
                column: "Title",
                value: "Kreditkortsbedrägeri");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 18,
                column: "Title",
                value: "Digital säkerhet på företag");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 19,
                column: "Title",
                value: "Digital säkerhet på företag");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 20,
                column: "Title",
                value: "Digital säkerhet på företag");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 21,
                column: "Title",
                value: "Allmänt om cyberspionage");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 22,
                column: "Title",
                value: "Allmänt om cyberspionage");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 23,
                column: "Title",
                value: "Allmänt om cyberspionage");
        }
    }
}

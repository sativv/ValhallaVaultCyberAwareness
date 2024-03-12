using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ValhallaVaultCyberAwareness.Migrations
{
    /// <inheritdoc />
    public partial class AddSegmentInfTextToAllSegments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 2,
                column: "InfoText",
                value: "Bedrägerier kan inträffa i hemmet, genom oönskad försäljning eller stöld. Nätfiske är en specifik form av bedrägeri som utförs online genom e-post, meddelandeappar eller sociala medier, med syftet att lura offret att lämna ut personlig information.");

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 3,
                column: "InfoText",
                value: "Vid fakturabedrägerier är det vanligt att olika annonsföretag försöker lura småföretagare med påstridiga och otydliga metoder. Det sker ofta genom att de skickar ut bluffakturor. Ransomware är en form av skadlig programvarasom krypterar filer på en organisations eller persons dator och kräver en lösensumma för att återställa tillgången till filerna.");

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 4,
                column: "InfoText",
                value: "Digital säkerhet handlar om att skydda datorer, nätverk, mobiltelefoner och andra digitala enheter från skadlig verksamhet och obehörig åtkomst. Detta är viktigt då det krävs kunskap och expertis för att kunna sydda sig självoch sin organisation mot cyberattacker.");

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 5,
                column: "InfoText",
                value: "Genom att utge sig för att vara en legitm organisation, som en bank, en regeringsbyrå eller ett företag, försöker bedragaren lura offret att lämna ut personlig information, som lösenord eller kreditkortsuppgifter, eller att utföra obehöriga transaktioner.");

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 6,
                column: "InfoText",
                value: "Dataintrång innebär att obehöriga parter kan få åtkomst till en dator ett nätverk eller annan digital enhet utan tillstånd.Detta kan ske genom skadlig programvara eller skadlig kod så kallada virus och trojaner. Dessa termer är alla relaterade till säkerhetsrisker på digitala plattformar och är viktiga att förstå för att kunna skydda sig själv och sina enheter mot cyberbrott.");

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 7,
                column: "InfoText",
                value: "Attacker mot servrar kan orsaka allvarliga konsekvenser, inklusive förlust av data, otillgänglighet av tjänster, stöld av känslig information eller skadegörelse. Detta kräver robusta säkerhetsåtgärder för att skydda digitala system och infrastrukturer mot attacker samt behovet av att snabbt hantera incidenter när de inträffar för att minimera skadorna.");

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 8,
                column: "InfoText",
                value: "Cyberspionage är en form av spionage där information och data samlas in från digitala system och nätverk för strategiska eller ekonomiska syften. Det utförs oftast av stater, organiserade brottsliga grupper eller företag och kan rikta sig mot regeringar, företag eller enskilda personer.");

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 9,
                column: "InfoText",
                value: " Påverkanskampanjer är planerade och koordinerade aktiviteter för att påverka människors åsikter eller beslut, ofta genom användning av desinformation. Affärsspionage innebär att en organisation eller individ stjäl konfidentiell affärsinformation från ett annat företag för ekonomisk vinning eller konkurrensfördel. Dessa aktiviteter utgör ett allvarligt hot mot företag, organisationer och samhället som helhet.");

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 10,
                column: "InfoText",
                value: " För att bekämpa cyberspionage krävs samverkan mellan olika aktörer såsom underrättelsetjänster, myndigheter, företag och akademiska institutioner.  Genom att dela information och samarbeta kring säkerhetsåtgärder kan man förbättra förmågan att upptäcka, förebygga och motverka hotet från cyberspionage.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 2,
                column: "InfoText",
                value: null);

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 3,
                column: "InfoText",
                value: null);

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 4,
                column: "InfoText",
                value: null);

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 5,
                column: "InfoText",
                value: null);

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 6,
                column: "InfoText",
                value: null);

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 7,
                column: "InfoText",
                value: null);

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 8,
                column: "InfoText",
                value: null);

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 9,
                column: "InfoText",
                value: null);

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 10,
                column: "InfoText",
                value: null);
        }
    }
}

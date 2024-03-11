using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ValhallaVaultCyberAwareness.Migrations
{
    /// <inheritdoc />
    public partial class changeDbStructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Segments_SegmentId",
                table: "Questions");

            migrationBuilder.RenameColumn(
                name: "SegmentId",
                table: "Questions",
                newName: "SubCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Questions_SegmentId",
                table: "Questions",
                newName: "IX_Questions_SubCategoryId");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InfoText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SegmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_Segments_SegmentId",
                        column: x => x.SegmentId,
                        principalTable: "Segments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "SubCategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                column: "SubCategoryId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                column: "SubCategoryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5,
                column: "SubCategoryId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6,
                column: "SubCategoryId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7,
                column: "SubCategoryId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8,
                column: "SubCategoryId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9,
                column: "SubCategoryId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10,
                column: "SubCategoryId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 11,
                column: "SubCategoryId",
                value: 36);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 12,
                column: "SubCategoryId",
                value: 37);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 13,
                column: "SubCategoryId",
                value: 38);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 14,
                column: "SubCategoryId",
                value: 39);

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "Image", "InfoText", "SegmentId", "Title" },
                values: new object[,]
                {
                    { 1, null, null, 1, "Kreditkortsbedrägeri" },
                    { 2, null, null, 1, "Romansbedrägeri" },
                    { 3, null, null, 1, "Investeringsbedrägeri" },
                    { 4, null, null, 1, "Telefonbedrägeri" },
                    { 5, null, null, 2, "Bedrägerier i hemmet" },
                    { 6, null, null, 2, "Identitetsstöld" },
                    { 7, null, null, 2, "Nätfiske och bluffmejl" },
                    { 8, null, null, 2, "Investeringsbedrägeri på nätet" },
                    { 9, null, null, 3, "Abonnemangsfällor och falska fakturor" },
                    { 10, null, null, 3, "Ransomware" },
                    { 11, null, null, 3, "Statistik och förhållningssätt" },
                    { 12, null, null, 4, "Digital säkerhet på företag" },
                    { 13, null, null, 4, "Risker och beredskap" },
                    { 14, null, null, 4, "Aktörer inom cyberbrott" },
                    { 15, null, null, 4, "Ökad digital närvaro och distansarbete" },
                    { 16, null, null, 4, "Cyberangrepp mot känsliga sektorer" },
                    { 17, null, null, 4, "Cyberrånet mot Mersk" },
                    { 18, null, null, 5, "Social engineering" },
                    { 19, null, null, 5, "Nätfiske och skräppost" },
                    { 20, null, null, 5, "Vishing" },
                    { 21, null, null, 5, "Varning för vishing" },
                    { 22, null, null, 5, "Identifiera VD-mejl" },
                    { 23, null, null, 5, "Öneangreoo och presentkortsbluffar" },
                    { 24, null, null, 6, "Virus, maskar och trojaner" },
                    { 25, null, null, 6, "Så kan det gå till" },
                    { 26, null, null, 6, "Nätverksintrång" },
                    { 27, null, null, 6, "Dataintrång" },
                    { 28, null, null, 6, "Hackad!" },
                    { 29, null, null, 6, "Vägarna in" },
                    { 30, null, null, 7, "Utpressningsvirus" },
                    { 31, null, null, 7, "Attacker mot servrar" },
                    { 32, null, null, 7, "Cyberangrepp i Norden" },
                    { 33, null, null, 7, "It-brottslingarnas verktyg" },
                    { 34, null, null, 7, "Mirai, Wannacry och fallet Düsseldorf" },
                    { 35, null, null, 7, "De sårbara molnen" },
                    { 36, null, null, 8, "Allmänt om cyberspionage" },
                    { 37, null, null, 8, "Metoder för cyberspionage" },
                    { 38, null, null, 8, "Säkerhetsskyddslagen" },
                    { 39, null, null, 8, "Cyberspionagets aktörer" },
                    { 40, null, null, 9, "Värvningsförsök" },
                    { 41, null, null, 9, "Affärsspionage" },
                    { 42, null, null, 9, "Påverkanskampanjer" },
                    { 43, null, null, 10, "Svensk underrättelsetjänst och cyberförsvar" },
                    { 44, null, null, 10, "Signalspaning, informationssäkerhet och 5G" },
                    { 45, null, null, 10, "Samverkan mot cyberspionage" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "ExplanationText", "SubCategoryId", "Text", "Title" },
                values: new object[,]
                {
                    { 15, "Det säkraste sättet att hantera potentiella telefonbedrägerier är att avsluta samtalet och sedan själv ringa upp din bank via ett telefonnummer du vet är korrekt (till exempel från deras officiella webbplats eller ditt bankkort) för att verifiera om samtalet var legitimt.", 1, "Vad bör du göra omedelbart efter att ha mottagit ett misstänkt telefonsamtal där någon frågar efter personlig finansiell information?", "Kreditkortsbedrägeri" },
                    { 16, "Kommunikationen från banker och finansiella institutioner innehåller aldrig förfrågningar om känslig information som lösenord eller kontonummer via osäkra kanaler som telefon eller e-post. Detta är en grundläggande säkerhetsprincip.", 1, "Vilket av följande påståenden är sant angående hur finansiella institutioner kommunicerar med sina kunder?", "Kreditkortsbedrägeri" },
                    { 17, "Genom att ha förutbestämda säkerhetsfrågor med din bank kan du och banken ha en säker metod för att bekräfta varandras identitet under telefonsamtal. Detta minskar risken för att bli lurad av bedragare som inte kan svara på dessa frågor.", 1, "Hur kan du bäst skydda dig mot telefonbedrägerier?", "Kreditkortsbedrägeri" },
                    { 18, "En automatisk policy för lösenordsändring tvingar fram regelbundna uppdateringar och säkerställer att lösenorden hålls starka och svåra att knäcka, vilket minskar risken för obehörig åtkomst.", 12, "Vilken åtgärd är mest effektiv för att säkerställa att anställda regelbundet uppdaterar sina lösenord till starkare och mer komplexa versioner?", "Digital säkerhet på företag" },
                    { 19, "Genom att använda VPN kan anställda säkert ansluta till företagets nätverk även från otrygga Wi-Fi-nätverk, vilket krypterar dataöverföring och skyddar mot avlyssning och andra cyberhot.", 12, "Hur kan företaget effektivt minska risken för att anställda oavsiktligt exponerar företagsdata via otrygga Wi-Fi-nätverk?", "Digital säkerhet på företag" },
                    { 20, "Avancerade e-postsäkerhetslösningar kan effektivt identifiera och blockera skadlig programvara och phishing-försök, vilket minskar risken för att anställda oavsiktligt exponerar företagets system och data för cyberhot.", 12, "Vilken åtgärd bör ett företag ta för att skydda sig mot intrång via e-postbaserade hot som phishing?", "Digital säkerhet på företag" },
                    { 21, "Kryptering är en kraftfull metod för att skydda känslig information under överföring och lagring, vilket gör det extremt svårt för obehöriga att få tillgång till och förstå informationen, även om de lyckas avlyssna kommunikationen.\nInsiderhot är en av de svåraste säkerhetsutmaningarna att identifiera och förebygga. Dessa hot kan komma från anställda som, oavsett om det är avsiktligt eller oavsiktligt, läcker känslig information som kan utnyttjas för cyberspionage. Att använda avancerade verktyg för beteendeanalys och anomalidetektering kan ge tidiga varningar om potentiella säkerhetsbrott.", 36, "Vilken försvarsstrategi är mest effektiv mot cyberspionage som riktar sig mot känslig kommunikation?", "Allmänt om cyberspionage" },
                    { 22, "Program för beteendeanalys och anomalidetektering kan effektivt identifiera ovanligt beteende eller aktiviteter som kan tyda på insiderhot eller obehörig åtkomst till känslig information, vilket är ett kritiskt steg för att förhindra cyberspionage.\nMjukvarusårbarheter är ofta den svaga länken som utnyttjas i cyberspionageattacker. Utan snabba och regelbundna säkerhetsuppdateringar och patchar, kan dessa sårbarheter lämna dörrarna vidöppna för angripare. Att hålla programvara och system uppdaterade är en grundläggande men kritisk del av ett effektivt cybersäkerhetsförsvar.", 36, "Hur kan organisationer bäst upptäcka och motverka insiderhot som bidrar till cyberspionage?", "Allmänt om cyberspionage" },
                    { 23, "Regelbundna uppdateringar och patchning av mjukvara och operativsystem är avgörande för att stänga säkerhetshål som annars kan utnyttjas av cyberspioner. Detta minskar risken för intrång och dataläckor avsevärt.", 36, "Vilken åtgärd är viktigast för att skydda sig mot cyberspionage genom utnyttjande av mjukvarusårbarheter?", "Allmänt om cyberspionage" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrectAnswer", "QuestionId", "Text" },
                values: new object[,]
                {
                    { 43, false, 15, "Ge dem informationen de ber om, för säkerhets skull" },
                    { 44, true, 15, "Avsluta samtalet och kontakta din bank direkt via ett officiellt nummer du vet är korrekt" },
                    { 45, false, 15, "Vänta på att de ska ringa tillbaka för att bekräfta deras legitimitet" },
                    { 46, false, 16, "Banker skickar ofta e-postmeddelanden som ber kunder att direkt ange lösenord och kontonummer för verifiering." },
                    { 47, false, 16, "Banker ringer regelbundet sina kunder för att be dem upprepa sina kontouppgifter för säkerhetsuppdateringar." },
                    { 48, true, 16, "Banker och finansiella institutioner kommer aldrig att be dig om ditt lösenord eller kontonummer via telefon eller e-post." },
                    { 49, false, 17, "Installera en app som blockerar misstänkta samtal" },
                    { 50, false, 17, "Aldrig svara på samtal från okända nummer" },
                    { 51, true, 17, "Upprätta starka säkerhetsfrågor med din bank som krävs för att identifiera dig över telefon" },
                    { 52, false, 18, "Manuellt kontrollera varje anställds lösenord en gång per år" },
                    { 53, true, 18, "Implementera en policy för lösenordskomplexitet som kräver automatiska lösenordsändringar var 90:e dag" },
                    { 54, false, 18, "Uppmana anställda att välja lättihågda lösenord för att undvika att skriva ner dem" },
                    { 55, false, 19, "Förbjuda användning av offentliga Wi-Fi-nätverk helt och hållet" },
                    { 56, true, 19, "Utrusta alla anställdas enheter med VPN (Virtual Private Network)-tjänster" },
                    { 57, false, 19, "Endast tillåta anställda att arbeta offline när de inte är på kontoret" },
                    { 58, false, 20, "Blockera all inkommande e-post från externa källor" },
                    { 59, true, 20, "Installera och uppdatera regelbundet e-postsäkerhetslösningar som filtrerar bort skadlig programvara och misstänkta länkar" },
                    { 60, false, 20, "Låta anställda använda personliga e-postkonton för arbete för att minska risken för företagets e-postservers säkerhet" },
                    { 61, true, 21, "Öka användningen av kryptering för all intern och extern kommunikation" },
                    { 62, false, 21, "Förbjuda all användning av e-post och återgå till fysisk korrespondens" },
                    { 63, false, 21, "Installera antivirusprogram på alla datorer" },
                    { 64, false, 22, "Genomföra strikta bakgrundskontroller av alla anställda" },
                    { 65, true, 22, "Implementera ett omfattande program för beteendeanalys och anomalidetektering" },
                    { 66, false, 22, "Begränsa internetanvändningen på arbetsplatsen till arbetsrelaterade aktiviteter" },
                    { 67, false, 23, "Genomföra regelbundna medvetenhetsträningar för alla anställda om cybersäkerhet" },
                    { 68, true, 23, "Hålla all mjukvara och operativsystem uppdaterade med de senaste säkerhetspatcharna" },
                    { 69, false, 23, "Endast använda egenutvecklad mjukvara för alla verksamhetsprocesser" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_SegmentId",
                table: "SubCategories",
                column: "SegmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_SubCategories_SubCategoryId",
                table: "Questions",
                column: "SubCategoryId",
                principalTable: "SubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_SubCategories_SubCategoryId",
                table: "Questions");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.RenameColumn(
                name: "SubCategoryId",
                table: "Questions",
                newName: "SegmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Questions_SubCategoryId",
                table: "Questions",
                newName: "IX_Questions_SegmentId");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "SegmentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                column: "SegmentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                column: "SegmentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5,
                column: "SegmentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6,
                column: "SegmentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7,
                column: "SegmentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8,
                column: "SegmentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9,
                column: "SegmentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10,
                column: "SegmentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 11,
                column: "SegmentId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 12,
                column: "SegmentId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 13,
                column: "SegmentId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 14,
                column: "SegmentId",
                value: 8);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Segments_SegmentId",
                table: "Questions",
                column: "SegmentId",
                principalTable: "Segments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

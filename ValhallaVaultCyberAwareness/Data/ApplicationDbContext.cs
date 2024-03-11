using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberAwareness.Models;

namespace ValhallaVaultCyberAwareness.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<AnswerModel> Answers { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<QuestionModel> Questions { get; set; }
        public DbSet<ResponseModel> Responses { get; set; }
        public DbSet<SegmentModel> Segments { get; set; }
        public DbSet<SubCategoryModel> SubCategories { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ResponseModel>().HasKey(r => new { r.UserId, r.QuestionId });


            //Seeda dummy-data
            builder.Entity<CategoryModel>().HasData(
                new CategoryModel()
                {
                    Id = 1,
                    Name = "Att skydda sig mot bedrägerier"
                },
                new CategoryModel()
                {
                    Id = 2,
                    Name = "Cybersäkerhet för företag"
                },
                new CategoryModel()
                {
                    Id = 3,
                    Name = "Cyberspionage"
                });

            builder.Entity<SegmentModel>().HasData(
                new SegmentModel()
                {
                    Id = 1,
                    Name = "Del 1",
                    CategoryId = 1,

                },
                new SegmentModel()
                {
                    Id = 2,
                    Name = "Del 2",
                    CategoryId = 1,

                },
                new SegmentModel()
                {
                    Id = 3,
                    Name = "Del 3",
                    CategoryId = 1,

                },
                new SegmentModel()
                {
                    Id = 4,
                    Name = "Del 1",
                    CategoryId = 2,

                },
                new SegmentModel()
                {
                    Id = 5,
                    Name = "Del 2",
                    CategoryId = 2,

                },
                new SegmentModel()
                {
                    Id = 6,
                    Name = "Del 3",
                    CategoryId = 2,

                },
                new SegmentModel()
                {
                    Id = 7,
                    Name = "Del 4",
                    CategoryId = 2,

                },
                new SegmentModel()
                {
                    Id = 8,
                    Name = "Del 1",
                    CategoryId = 3,

                },
                new SegmentModel()
                {
                    Id = 9,
                    Name = "Del 2",
                    CategoryId = 3,

                },
                new SegmentModel()
                {
                    Id = 10,
                    Name = "Del 3",
                    CategoryId = 3,

                });

            builder.Entity<SubCategoryModel>().HasData(
                new SubCategoryModel()
                {
                    Id = 1,
                    Title = "Kreditkortsbedrägeri",
                    SegmentId = 1,
                },
                new SubCategoryModel()
                {
                    Id = 2,
                    Title = "Romansbedrägeri",
                    SegmentId = 1,
                },
                new SubCategoryModel()
                {
                    Id = 3,
                    Title = "Investeringsbedrägeri",
                    SegmentId = 1,
                },
                new SubCategoryModel()
                {
                    Id = 4,
                    Title = "Telefonbedrägeri",
                    SegmentId = 1,
                },
                new SubCategoryModel()
                {
                    Id = 5,
                    Title = "Bedrägerier i hemmet",
                    SegmentId = 2,
                },
                new SubCategoryModel()
                {
                    Id = 6,
                    Title = "Identitetsstöld",
                    SegmentId = 2,
                },
                new SubCategoryModel()
                {
                    Id = 7,
                    Title = "Nätfiske och bluffmejl",
                    SegmentId = 2,
                },
                new SubCategoryModel()
                {
                    Id = 8,
                    Title = "Investeringsbedrägeri på nätet",
                    SegmentId = 2,
                },
                new SubCategoryModel()
                {
                    Id = 9,
                    Title = "Abonnemangsfällor och falska fakturor",
                    SegmentId = 3,
                },
                new SubCategoryModel()
                {
                    Id = 10,
                    Title = "Ransomware",
                    SegmentId = 3,
                },
                new SubCategoryModel()
                {
                    Id = 11,
                    Title = "Statistik och förhållningssätt",
                    SegmentId = 3,
                },
                new SubCategoryModel()
                {
                    Id = 12,
                    Title = "Digital säkerhet på företag",
                    SegmentId = 4,
                },
                new SubCategoryModel()
                {
                    Id = 13,
                    Title = "Risker och beredskap",
                    SegmentId = 4,
                },
                new SubCategoryModel()
                {
                    Id = 14,
                    Title = "Aktörer inom cyberbrott",
                    SegmentId = 4,
                },
                new SubCategoryModel()
                {
                    Id = 15,
                    Title = "Ökad digital närvaro och distansarbete",
                    SegmentId = 4,
                },
                new SubCategoryModel()
                {
                    Id = 16,
                    Title = "Cyberangrepp mot känsliga sektorer",
                    SegmentId = 4,
                },
                new SubCategoryModel()
                {
                    Id = 17,
                    Title = "Cyberrånet mot Mersk",
                    SegmentId = 4,
                },
                new SubCategoryModel()
                {
                    Id = 18,
                    Title = "Social engineering",
                    SegmentId = 5,
                },
                new SubCategoryModel()
                {
                    Id = 19,
                    Title = "Nätfiske och skräppost",
                    SegmentId = 5,
                },
                new SubCategoryModel()
                {
                    Id = 20,
                    Title = "Vishing",
                    SegmentId = 5,
                },
                new SubCategoryModel()
                {
                    Id = 21,
                    Title = "Varning för vishing",
                    SegmentId = 5,
                },
                new SubCategoryModel()
                {
                    Id = 22,
                    Title = "Identifiera VD-mejl",
                    SegmentId = 5,
                },
                new SubCategoryModel()
                {
                    Id = 23,
                    Title = "Öneangreoo och presentkortsbluffar",
                    SegmentId = 5,
                },
                new SubCategoryModel()
                {
                    Id = 24,
                    Title = "Virus, maskar och trojaner",
                    SegmentId = 6,
                },
                new SubCategoryModel()
                {
                    Id = 25,
                    Title = "Så kan det gå till",
                    SegmentId = 6,
                },
                new SubCategoryModel()
                {
                    Id = 26,
                    Title = "Nätverksintrång",
                    SegmentId = 6,
                },
                new SubCategoryModel()
                {
                    Id = 27,
                    Title = "Dataintrång",
                    SegmentId = 6,
                },
                new SubCategoryModel()
                {
                    Id = 28,
                    Title = "Hackad!",
                    SegmentId = 6,
                },
                new SubCategoryModel()
                {
                    Id = 29,
                    Title = "Vägarna in",
                    SegmentId = 6,
                },
                new SubCategoryModel()
                {
                    Id = 30,
                    Title = "Utpressningsvirus",
                    SegmentId = 7,
                },
                new SubCategoryModel()
                {
                    Id = 31,
                    Title = "Attacker mot servrar",
                    SegmentId = 7,
                },
                new SubCategoryModel()
                {
                    Id = 32,
                    Title = "Cyberangrepp i Norden",
                    SegmentId = 7,
                },
                new SubCategoryModel()
                {
                    Id = 33,
                    Title = "It-brottslingarnas verktyg",
                    SegmentId = 7,
                },
                new SubCategoryModel()
                {
                    Id = 34,
                    Title = "Mirai, Wannacry och fallet Düsseldorf",
                    SegmentId = 7,
                },
                new SubCategoryModel()
                {
                    Id = 35,
                    Title = "De sårbara molnen",
                    SegmentId = 7,
                },
                new SubCategoryModel()
                {
                    Id = 36,
                    Title = "Allmänt om cyberspionage",
                    SegmentId = 8,
                },
                new SubCategoryModel()
                {
                    Id = 37,
                    Title = "Metoder för cyberspionage",
                    SegmentId = 8,
                },
                new SubCategoryModel()
                {
                    Id = 38,
                    Title = "Säkerhetsskyddslagen",
                    SegmentId = 8,
                },
                new SubCategoryModel()
                {
                    Id = 39,
                    Title = "Cyberspionagets aktörer",
                    SegmentId = 8,
                },
                new SubCategoryModel()
                {
                    Id = 40,
                    Title = "Värvningsförsök",
                    SegmentId = 9,
                },
                new SubCategoryModel()
                {
                    Id = 41,
                    Title = "Affärsspionage",
                    SegmentId = 9,
                },
                new SubCategoryModel()
                {
                    Id = 42,
                    Title = "Påverkanskampanjer",
                    SegmentId = 9,
                },
                new SubCategoryModel()
                {
                    Id = 43,
                    Title = "Svensk underrättelsetjänst och cyberförsvar",
                    SegmentId = 10,
                },
                new SubCategoryModel()
                {
                    Id = 44,
                    Title = "Signalspaning, informationssäkerhet och 5G",
                    SegmentId = 10,
                },
                new SubCategoryModel()
                {
                    Id = 45,
                    Title = "Samverkan mot cyberspionage",
                    SegmentId = 10,
                });



            builder.Entity<QuestionModel>().HasData(
                new QuestionModel()
                {
                    Id = 1,
                    Title = "Oväntat telefonsamtal",
                    Text = "Du får ett oväntat telefonsamtal från någon som påstår sig vara från din bank. Personen ber dig bekräfta ditt kontonummer och lösenord för att \"säkerställa din kontos säkerhet\" efter en påstådd säkerhetsincident. Hur bör du tolka denna situation?",
                    ExplanationText = "Banker och andra finansiella institutioner begär aldrig känslig information såsom kontonummer eller lösenord via telefon. Detta är ett klassiskt tecken på telefonbedrägeri.",
                    SubCategoryId = 1,
                },
                new QuestionModel()
                {
                    Id = 2,
                    Title = "Begäran om pengar från datingsida",
                    Text = "Efter flera månader av daglig kommunikation med någon du träffade på en datingsida, börjar personen berätta om en plötslig finansiell kris och ber om din hjälp genom att överföra pengar. Vad indikerar detta mest sannolikt?",
                    ExplanationText = "Begäran om pengar, särskilt under omständigheter där två personer aldrig har träffats fysiskt, är ett vanligt tecken på romansbedrägeri.",
                    SubCategoryId = 2,
                },
                new QuestionModel()
                {
                    Id = 3,
                    Title = "Exklusivt investeringserbjudande",
                    Text = "Du får ett e-postmeddelande/samtal om ett exklusivt erbjudande att investera i ett startup-företag som påstås ha en revolutionerande ny teknologi, med garantier om exceptionellt hög avkastning på mycket kort tid. Hur bör du förhålla dig till erbjudandet?",
                    ExplanationText = "Erbjudanden som lovar hög avkastning med liten eller ingen risk, särskilt via oönskade e-postmeddelanden, är ofta tecken på investeringsbedrägerier",
                    SubCategoryId = 3,
                },
                new QuestionModel()
                {
                    Id = 4,
                    Title = "Oidentifierade transaktioner",
                    ExplanationText = "Oidentifierade transaktioner på ditt kreditkortsutdrag är en stark indikation på att ditt kortnummer har komprometterats och använts för obehöriga köp, vilket är typiskt för kreditkortsbedrägeri",
                    Text = "Efter en online-shoppingrunda märker du oidentifierade transaktioner på ditt kreditkortsutdrag från företag du aldrig handlat från. Vad indikerar detta mest sannolikt?",
                    SubCategoryId = 4,

                },
                new QuestionModel()
                {
                    Id = 5,
                    Title = "Konfidentiella dokument läcker till konkurrenter",
                    ExplanationText = "Utbildning i digital säkerhet är avgörande för att hjälpa anställda att känna igen och undvika säkerhetshot som phishing, vilket är en vanlig attackvektor.",
                    Text = "Inom företaget märker man att konfidentiella dokument regelbundet läcker ut till konkurrenter. Efter en intern granskning upptäcks det att en anställd omedvetet har installerat skadlig programvara genom att klicka på en länk i ett phishing-e-postmeddelande. Vilken åtgärd bör prioriteras för att förhindra framtida incidenter?",
                    SubCategoryId = 12
                }, new QuestionModel()
                {
                    Id = 6,
                    Title = "Sårbarhet i programvara",
                    ExplanationText = "Transparent kommunikation och rådgivning om tillfälliga åtgärder är avgörande för att skydda användarna medan en permanent lösning utvecklas.",
                    Text = "Inom företaget upptäckts det en sårbarhet i vår programvara som kunde möjliggöra obehörig åtkomst till användardata. Företaget har inte omedelbart en lösning. Vilken är den mest lämpliga första åtgärden?",
                    SubCategoryId = 13
                }, new QuestionModel()
                {
                    Id = 7,
                    Title = "DDoS-attack",
                    ExplanationText = "DDoS-attacker kräver ofta betydande resurser och koordinering, vilket är karakteristiskt för organiserade cyberbrottsliga grupper.",
                    Text = "Vårt företag blir måltavla för en DDoS-attack som överväldigar våra servers och gör våra tjänster otillgängliga för kunder. Vilken typ av aktör är mest sannolikt ansvarig för denna typ av attack?",
                    SubCategoryId = 14
                }, new QuestionModel()
                {
                    Id = 8,
                    Title = "Ökning av säkerhetsincidenter vid distansarbete",
                    ExplanationText = " Stärkt autentisering är kritisk för att säkra fjärråtkomst och skydda mot obehörig åtkomst i en distribuerad arbetsmiljö.",
                    Text = "Med övergången till distansarbete upptäcker vårt företag en ökning av säkerhetsincidenter, inklusive obehörig åtkomst till företagsdata. Vilken åtgärd bör företaget vidta för att adressera denna nya riskmiljö?",
                    SubCategoryId = 15
                }, new QuestionModel()
                {
                    Id = 9,
                    Title = "Cyberangrepp som krypterar patientdata",
                    ExplanationText = "Ransomware-angrepp involverar kryptering av offerdata och kräver lösen för dekryptering, vilket är särskilt skadligt för kritiska sektorer som hälsovård.",
                    Text = "Hälsovårdsmyndigheten utsätts för ett cyberangrepp som krypterar patientdata och kräver lösen för att återställa åtkomsten. Vilken typ av angrepp har de sannolikt blivit utsatta för?",
                    SubCategoryId = 16
                }, new QuestionModel()
                {
                    Id = 10,
                    Title = "Maersk",
                    ExplanationText = "Maersk utsattes för NotPetya ransomware-angreppet, som ledde till omfattande störningar och förluster genom att kryptera företagets globala system. Maersk rapporterade att företaget led ekonomiska förluster på grund av NotPetya ransomware-angreppet som uppskattades till cirka 300 miljoner USD. Denna siffra reflekterar de omfattande kostnaderna för störningar i deras globala verksamheter, återställande av system och data, samt förlust av affärer under tiden systemen var nere. NotPetya-angreppet anses vara ett av de mest kostsamma cyberangreppen mot ett enskilt företag och tjänar som en kraftfull påminnelse om de potentiella konsekvenserna av cyberhot.",
                    Text = "Det globala fraktbolaget Maersk blev offer för ett omfattande cyberangrepp som avsevärt störde deras verksamhet världen över. Vilken typ av malware var primärt ansvarig för denna incident?",
                    SubCategoryId = 17
                }, new QuestionModel()
                {
                    Id = 11,
                    Title = "Känslig politisk kommunikation har läckt",
                    ExplanationText = " Cyberspionage avser aktiviteter där aktörer, ofta statliga, engagerar sig i övervakning och datainsamling genom cybermedel för att erhålla hemlig information utan målets medgivande, typiskt för politiska, militära eller ekonomiska fördelar.",
                    Text = "Regeringen upptäcker att känslig politisk kommunikation har läckt och misstänker elektronisk övervakning. Vilket fenomen beskriver bäst denna situation?",
                    SubCategoryId = 36
                }, new QuestionModel()
                {
                    Id = 12,
                    Title = "Skadeprogramskampanj",
                    ExplanationText = "Riktade cyberattacker som utnyttjar noll-dagars Zero-day sårbarheter är en avancerad metod för cyberspionage där angriparen specifikt riktar in sig på ett mål för att komma åt känslig information eller data genom att utnyttja tidigare okända sårbarheter i programvara.",
                    Text = "Regeringen blir varse om en sofistikerad skadeprogramskampanj som utnyttjar Zero-day sårbarheter för att infiltrera deras nätverk och stjäla oerhört viktig data. Vilken metod för cyberspionage används sannolikt här?",
                    SubCategoryId = 37
                }, new QuestionModel()
                {
                    Id = 13,
                    Title = "Interna säkerhetsprotokoll",
                    ExplanationText = "Säkerhetsskyddslagen är en svensk lagstiftning som syftar till att skydda nationellt känslig information från spioneri, sabotage, terroristbrott och andra säkerhetshot. Lagen ställer krav på säkerhetsskyddsåtgärder för verksamheter av betydelse för Sveriges säkerhet.",
                    Text = "Regeringen i Sverige ökar sitt interna säkerhetsprotokoll för att skydda sig mot utländska underrättelsetjänsters infiltration. Vilken lagstiftning ger ramverket för detta skydd?",
                    SubCategoryId = 38
                },
                new QuestionModel()
                {
                    Id = 14,
                    Title = "Statssponsrade hackers",
                    ExplanationText = "Lunds universitet upptäcker att forskningsdata om ny teknologi har stulits. Undersökningar tyder på en välorganiserad grupp med kopplingar till en utländsk stat. Vilken typ av aktör ligger sannolikt bakom detta?",
                    Text = "Statssponsrade hackers är aktörer som arbetar på uppdrag av eller med stöd från en regering för att genomföra cyberspionage, ofta riktat mot utländska intressen, organisationer eller regeringar för att få strategiska fördelar.",
                    SubCategoryId = 39
                },
                new QuestionModel()
                {
                    Id = 15,
                    Title = "Någon efterfrågar personlig finansiell information",
                    ExplanationText = "Det säkraste sättet att hantera potentiella telefonbedrägerier är att avsluta samtalet och sedan själv ringa upp din bank via ett telefonnummer du vet är korrekt (till exempel från deras officiella webbplats eller ditt bankkort) för att verifiera om samtalet var legitimt.",
                    Text = "Vad bör du göra omedelbart efter att ha mottagit ett misstänkt telefonsamtal där någon frågar efter personlig finansiell information?",
                    SubCategoryId = 1
                },
                new QuestionModel()
                {
                    Id = 16,
                    Title = "Hur kommunicerar finansiella institutioner",
                    ExplanationText = "Kommunikationen från banker och finansiella institutioner innehåller aldrig förfrågningar om känslig information som lösenord eller kontonummer via osäkra kanaler som telefon eller e-post. Detta är en grundläggande säkerhetsprincip.",
                    Text = "Vilket av följande påståenden är sant angående hur finansiella institutioner kommunicerar med sina kunder?",
                    SubCategoryId = 1
                },
                new QuestionModel()
                {
                    Id = 17,
                    Title = "Skydda dig mot telefonbedrägeri",
                    ExplanationText = "Genom att ha förutbestämda säkerhetsfrågor med din bank kan du och banken ha en säker metod för att bekräfta varandras identitet under telefonsamtal. Detta minskar risken för att bli lurad av bedragare som inte kan svara på dessa frågor.",
                    Text = "Hur kan du bäst skydda dig mot telefonbedrägerier?",
                    SubCategoryId = 1
                },
                new QuestionModel()
                {
                    Id = 18,
                    Title = "Säkerställa anställdas ansvar",
                    ExplanationText = "En automatisk policy för lösenordsändring tvingar fram regelbundna uppdateringar och säkerställer att lösenorden hålls starka och svåra att knäcka, vilket minskar risken för obehörig åtkomst.",
                    Text = "Vilken åtgärd är mest effektiv för att säkerställa att anställda regelbundet uppdaterar sina lösenord till starkare och mer komplexa versioner?",
                    SubCategoryId = 12
                },
                new QuestionModel()
                {
                    Id = 19,
                    Title = "Otrygga Wi-Fi-nätvärk",
                    ExplanationText = "Genom att använda VPN kan anställda säkert ansluta till företagets nätverk även från otrygga Wi-Fi-nätverk, vilket krypterar dataöverföring och skyddar mot avlyssning och andra cyberhot.",
                    Text = "Hur kan företaget effektivt minska risken för att anställda oavsiktligt exponerar företagsdata via otrygga Wi-Fi-nätverk?",
                    SubCategoryId = 12
                },
                new QuestionModel()
                {
                    Id = 20,
                    Title = "Åtgärd mot e-postbaserade intrång",
                    ExplanationText = "Avancerade e-postsäkerhetslösningar kan effektivt identifiera och blockera skadlig programvara och phishing-försök, vilket minskar risken för att anställda oavsiktligt exponerar företagets system och data för cyberhot.",
                    Text = "Vilken åtgärd bör ett företag ta för att skydda sig mot intrång via e-postbaserade hot som phishing?",
                    SubCategoryId = 12
                },
                new QuestionModel()
                {
                    Id = 21,
                    Title = "Mest effektiva försvarsstrategi",
                    ExplanationText = "Kryptering är en kraftfull metod för att skydda känslig information under överföring och lagring, vilket gör det extremt svårt för obehöriga att få tillgång till och förstå informationen, även om de lyckas avlyssna kommunikationen.\nInsiderhot är en av de svåraste säkerhetsutmaningarna att identifiera och förebygga. Dessa hot kan komma från anställda som, oavsett om det är avsiktligt eller oavsiktligt, läcker känslig information som kan utnyttjas för cyberspionage. Att använda avancerade verktyg för beteendeanalys och anomalidetektering kan ge tidiga varningar om potentiella säkerhetsbrott.",
                    Text = "Vilken försvarsstrategi är mest effektiv mot cyberspionage som riktar sig mot känslig kommunikation?",
                    SubCategoryId = 36
                },
                new QuestionModel()
                {
                    Id = 22,
                    Title = "Upptäck och motverka insiderhot",
                    ExplanationText = "Program för beteendeanalys och anomalidetektering kan effektivt identifiera ovanligt beteende eller aktiviteter som kan tyda på insiderhot eller obehörig åtkomst till känslig information, vilket är ett kritiskt steg för att förhindra cyberspionage.\nMjukvarusårbarheter är ofta den svaga länken som utnyttjas i cyberspionageattacker. Utan snabba och regelbundna säkerhetsuppdateringar och patchar, kan dessa sårbarheter lämna dörrarna vidöppna för angripare. Att hålla programvara och system uppdaterade är en grundläggande men kritisk del av ett effektivt cybersäkerhetsförsvar.",
                    Text = "Hur kan organisationer bäst upptäcka och motverka insiderhot som bidrar till cyberspionage?",
                    SubCategoryId = 36
                },
                new QuestionModel()
                {
                    Id = 23,
                    Title = "Skydd mot cyberspionage",
                    ExplanationText = "Regelbundna uppdateringar och patchning av mjukvara och operativsystem är avgörande för att stänga säkerhetshål som annars kan utnyttjas av cyberspioner. Detta minskar risken för intrång och dataläckor avsevärt.",
                    Text = "Vilken åtgärd är viktigast för att skydda sig mot cyberspionage genom utnyttjande av mjukvarusårbarheter?",
                    SubCategoryId = 36
                }
                );

            builder.Entity<AnswerModel>().HasData(
                new AnswerModel()
                {
                    Id = 1,
                    QuestionId = 1,
                    Text = "Ett legitimt försök från banken att skydda ditt konto",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 2,
                    QuestionId = 1,
                    Text = "En informationsinsamling för en marknadsundersökning",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 3,
                    QuestionId = 1,
                    Text = "Ett potentiellt telefonbedrägeri",
                    IsCorrectAnswer = true
                },
                new AnswerModel()
                {
                    Id = 4,
                    QuestionId = 2,
                    Text = "En legitim begäran om hjälp från en person i nöd",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 5,
                    QuestionId = 2,
                    Text = "Ett romansbedrägeri",
                    IsCorrectAnswer = true
                },
                new AnswerModel()
                {
                    Id = 6,
                    QuestionId = 2,
                    Text = "En tillfällig ekonomisk svårighet",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 7,
                    QuestionId = 3,
                    Text = "Genomföra omedelbar investering för att inte missa möjligheten",
                    IsCorrectAnswer = false
                }, new AnswerModel()
                {
                    Id = 8,
                    QuestionId = 3,
                    Text = "Investeringsbedrägeri",
                    IsCorrectAnswer = true

                },
                new AnswerModel()
                {
                    Id = 9,
                    QuestionId = 3,
                    Text = "Begära mer information för att utföra en noggrann ‘’due diligence’’",
                    IsCorrectAnswer = false

                },
                new AnswerModel()
                {
                    Id = 10,
                    QuestionId = 4,
                    Text = "Ett misstag av kreditkortsföretaget",
                    IsCorrectAnswer = false
                }, new AnswerModel()
                {
                    Id = 11,
                    QuestionId = 4,
                    Text = "Kreditkortsbedrägeri",
                    IsCorrectAnswer = true

                },
                new AnswerModel()
                {
                    Id = 12,
                    QuestionId = 4,
                    Text = "Obehöriga köp av en familjemedlem",
                    IsCorrectAnswer = false

                },
                new AnswerModel()
                {
                    Id = 13,
                    QuestionId = 5,
                    Text = "Utbildning i digital säkerhet för alla anställda",
                    IsCorrectAnswer = true

                },
                new AnswerModel()
                {
                    Id = 14,
                    QuestionId = 5,
                    Text = "Installera en starkare brandvägg",
                    IsCorrectAnswer = false

                },
                new AnswerModel()
                {
                    Id = 15,
                    QuestionId = 5,
                    Text = " Byta ut all IT-utrustning",
                    IsCorrectAnswer = false

                },
                new AnswerModel()
                {
                    Id = 16,
                    QuestionId = 6,
                    Text = " Informera alla användare om sårbarheten och rekommendera temporära skyddsåtgärder",
                    IsCorrectAnswer = true
                },
                new AnswerModel()
                {
                    Id = 17,
                    QuestionId = 6,
                    Text = "Ignorera problemet tills en patch kan utvecklas",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 18,
                    QuestionId = 6,
                    Text = "Stänga ner tjänsten tillfälligt",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 19,
                    QuestionId = 7,
                    Text = "En enskild hackare med ett personligt vendetta",
                    IsCorrectAnswer = false
                }, new AnswerModel()
                {
                    Id = 20,
                    QuestionId = 7,
                    Text = "En konkurrerande företagsentitet",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 21,
                    QuestionId = 7,
                    Text = "Organiserade cyberbrottsliga grupper",
                    IsCorrectAnswer = true
                },
                new AnswerModel()
                {
                    Id = 22,
                    QuestionId = 8,
                    Text = "Återgå till kontorsarbete",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 23,
                    QuestionId = 8,
                    Text = "Införa striktare lösenordspolicyer och tvåfaktorsautentisering för fjärråtkomst",
                    IsCorrectAnswer = true
                },
                new AnswerModel()
                {
                    Id = 24,
                    QuestionId = 8,
                    Text = "Förbjuda användning av personliga enheter för arbete",
                    IsCorrectAnswer = false
                }, new AnswerModel()
                {
                    Id = 25,
                    QuestionId = 9,
                    Text = "Phishing",
                    IsCorrectAnswer = false

                },
                new AnswerModel()
                {
                    Id = 26,
                    QuestionId = 9,
                    Text = "Ransomware",
                    IsCorrectAnswer = true

                },
                new AnswerModel()
                {
                    Id = 27,
                    QuestionId = 9,
                    Text = "Spyware",
                    IsCorrectAnswer = false

                },
                new AnswerModel()
                {
                    Id = 28,
                    QuestionId = 10,
                    Text = "Spyware",
                    IsCorrectAnswer = false

                },
                new AnswerModel()
                {
                    Id = 29,
                    QuestionId = 10,
                    Text = "Ransomware",
                    IsCorrectAnswer = true

                },
                new AnswerModel()
                {
                    Id = 30,
                    QuestionId = 10,
                    Text = "Adware",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 31,
                    QuestionId = 11,
                    Text = "Cyberkriminalitet",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 32,
                    QuestionId = 11,
                    Text = "Cyberspionage",
                    IsCorrectAnswer = true
                },
                new AnswerModel()
                {
                    Id = 33,
                    QuestionId = 11,
                    Text = "Cyberterrorism",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 34,
                    QuestionId = 12,
                    Text = "Social ingenjörskonst",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 35,
                    QuestionId = 12,
                    Text = "Massövervakning",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 36,
                    QuestionId = 12,
                    Text = "Riktade cyberattacker",
                    IsCorrectAnswer = true
                },

                new AnswerModel()
                {
                    Id = 37,
                    QuestionId = 13,
                    Text = "GDPR",
                    IsCorrectAnswer = false

                },
                new AnswerModel()
                {
                    Id = 38,
                    QuestionId = 13,
                    Text = "Säkerhetsskyddslagen",
                    IsCorrectAnswer = true

                },
                new AnswerModel()
                {
                    Id = 39,
                    QuestionId = 13,
                    Text = "IT-säkerhetslagen",
                    IsCorrectAnswer = false

                },
                new AnswerModel()
                {
                    Id = 40,
                    QuestionId = 14,
                    Text = "Oberoende hackare",
                    IsCorrectAnswer = false

                },
                new AnswerModel()
                {
                    Id = 41,
                    QuestionId = 14,
                    Text = "Aktivistgrupper",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 42,
                    QuestionId = 14,
                    Text = "Statssponsrade hackers",
                    IsCorrectAnswer = true

                },
                new AnswerModel()
                {
                    Id = 43,
                    QuestionId = 15,
                    Text = "Ge dem informationen de ber om, för säkerhets skull",
                    IsCorrectAnswer = false

                },
                new AnswerModel()
                {
                    Id = 44,
                    QuestionId = 15,
                    Text = "Avsluta samtalet och kontakta din bank direkt via ett officiellt nummer du vet är korrekt",
                    IsCorrectAnswer = true
                },
                new AnswerModel()
                {
                    Id = 45,
                    QuestionId = 15,
                    Text = "Vänta på att de ska ringa tillbaka för att bekräfta deras legitimitet",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 46,
                    QuestionId = 16,
                    Text = "Banker skickar ofta e-postmeddelanden som ber kunder att direkt ange lösenord och kontonummer för verifiering.",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 47,
                    QuestionId = 16,
                    Text = "Banker ringer regelbundet sina kunder för att be dem upprepa sina kontouppgifter för säkerhetsuppdateringar.",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 48,
                    QuestionId = 16,
                    Text = "Banker och finansiella institutioner kommer aldrig att be dig om ditt lösenord eller kontonummer via telefon eller e-post.",
                    IsCorrectAnswer = true
                },
                new AnswerModel()
                {
                    Id = 49,
                    QuestionId = 17,
                    Text = "Installera en app som blockerar misstänkta samtal",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 50,
                    QuestionId = 17,
                    Text = "Aldrig svara på samtal från okända nummer",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 51,
                    QuestionId = 17,
                    Text = "Upprätta starka säkerhetsfrågor med din bank som krävs för att identifiera dig över telefon",
                    IsCorrectAnswer = true
                },
                new AnswerModel()
                {
                    Id = 52,
                    QuestionId = 18,
                    Text = "Manuellt kontrollera varje anställds lösenord en gång per år",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 53,
                    QuestionId = 18,
                    Text = "Implementera en policy för lösenordskomplexitet som kräver automatiska lösenordsändringar var 90:e dag",
                    IsCorrectAnswer = true
                },
                new AnswerModel()
                {
                    Id = 54,
                    QuestionId = 18,
                    Text = "Uppmana anställda att välja lättihågda lösenord för att undvika att skriva ner dem",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 55,
                    QuestionId = 19,
                    Text = "Förbjuda användning av offentliga Wi-Fi-nätverk helt och hållet",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 56,
                    QuestionId = 19,
                    Text = "Utrusta alla anställdas enheter med VPN (Virtual Private Network)-tjänster",
                    IsCorrectAnswer = true
                },
                new AnswerModel()
                {
                    Id = 57,
                    QuestionId = 19,
                    Text = "Endast tillåta anställda att arbeta offline när de inte är på kontoret",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 58,
                    QuestionId = 20,
                    Text = "Blockera all inkommande e-post från externa källor",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 59,
                    QuestionId = 20,
                    Text = "Installera och uppdatera regelbundet e-postsäkerhetslösningar som filtrerar bort skadlig programvara och misstänkta länkar",
                    IsCorrectAnswer = true
                },
                new AnswerModel()
                {
                    Id = 60,
                    QuestionId = 20,
                    Text = "Låta anställda använda personliga e-postkonton för arbete för att minska risken för företagets e-postservers säkerhet",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 61,
                    QuestionId = 21,
                    Text = "Öka användningen av kryptering för all intern och extern kommunikation",
                    IsCorrectAnswer = true
                },
                new AnswerModel()
                {
                    Id = 62,
                    QuestionId = 21,
                    Text = "Förbjuda all användning av e-post och återgå till fysisk korrespondens",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 63,
                    QuestionId = 21,
                    Text = "Installera antivirusprogram på alla datorer",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 64,
                    QuestionId = 22,
                    Text = "Genomföra strikta bakgrundskontroller av alla anställda",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 65,
                    QuestionId = 22,
                    Text = "Implementera ett omfattande program för beteendeanalys och anomalidetektering",
                    IsCorrectAnswer = true
                },
                new AnswerModel()
                {
                    Id = 66,
                    QuestionId = 22,
                    Text = "Begränsa internetanvändningen på arbetsplatsen till arbetsrelaterade aktiviteter",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 67,
                    QuestionId = 23,
                    Text = "Genomföra regelbundna medvetenhetsträningar för alla anställda om cybersäkerhet",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 68,
                    QuestionId = 23,
                    Text = "Hålla all mjukvara och operativsystem uppdaterade med de senaste säkerhetspatcharna",
                    IsCorrectAnswer = true
                },
                new AnswerModel()
                {
                    Id = 69,
                    QuestionId = 23,
                    Text = "Endast använda egenutvecklad mjukvara för alla verksamhetsprocesser",
                    IsCorrectAnswer = false
                }
                );
        }
    }
}

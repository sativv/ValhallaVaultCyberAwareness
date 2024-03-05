using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
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
        //public DbSet<SubCategoryModel> SubCategories { get; set; }
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


            builder.Entity<QuestionModel>().HasData(
                new QuestionModel()
                {
                    Id = 1,
                    Title = "Kreditkortsbedrägeri",
                    Text = "Du får ett oväntat telefonsamtal från någon som påstår sig vara från din bank. Personen ber dig bekräfta ditt kontonummer och lösenord för att \"säkerställa din kontos säkerhet\" efter en påstådd säkerhetsincident. Hur bör du tolka denna situation?",
                    ExplanationText = "Banker och andra finansiella institutioner begär aldrig känslig information såsom kontonummer eller lösenord via telefon. Detta är ett klassiskt tecken på telefonbedrägeri.",
                    SegmentId = 1,
                },
                new QuestionModel()
                {
                    Id = 2,
                    Title = "Romansbedrägeri",
                    Text = "Efter flera månader av daglig kommunikation med någon du träffade på en datingsida, börjar personen berätta om en plötslig finansiell kris och ber om din hjälp genom att överföra pengar. Vad indikerar detta mest sannolikt?",
                    ExplanationText = "Begäran om pengar, särskilt under omständigheter där två personer aldrig har träffats fysiskt, är ett vanligt tecken på romansbedrägeri.",
                    SegmentId = 1,
                },
                new QuestionModel()
                {
                    Id = 3,
                    Title = "Investeringsbedrägeri",
                    Text = "Du får ett e-postmeddelande/samtal om ett exklusivt erbjudande att investera i ett startup-företag som påstås ha en revolutionerande ny teknologi, med garantier om exceptionellt hög avkastning på mycket kort tid. Hur bör du förhålla dig till erbjudandet?",
                    ExplanationText = "Erbjudanden som lovar hög avkastning med liten eller ingen risk, särskilt via oönskade e-postmeddelanden, är ofta tecken på investeringsbedrägerier",
                    SegmentId = 1,
                },
                new QuestionModel()
                {
                    Id = 4,
                    Title = "Telefonbedrägeri",
                    ExplanationText = "Oidentifierade transaktioner på ditt kreditkortsutdrag är en stark indikation på att ditt kortnummer har komprometterats och använts för obehöriga köp, vilket är typiskt för kreditkortsbedrägeri",
                    Text = "Efter en online-shoppingrunda märker du oidentifierade transaktioner på ditt kreditkortsutdrag från företag du aldrig handlat från. Vad indikerar detta mest sannolikt?",
                    SegmentId = 1,

                },
                new QuestionModel()
                {
                    Id = 5,
                    Title = "Digital säkerhet på företag",
                    ExplanationText = "Utbildning i digital säkerhet är avgörande för att hjälpa anställda att känna igen och undvika säkerhetshot som phishing, vilket är en vanlig attackvektor.",
                    Text = "Inom företaget märker man att konfidentiella dokument regelbundet läcker ut till konkurrenter. Efter en intern granskning upptäcks det att en anställd omedvetet har installerat skadlig programvara genom att klicka på en länk i ett phishing-e-postmeddelande. Vilken åtgärd bör prioriteras för att förhindra framtida incidenter?",
                    SegmentId = 4
                }, new QuestionModel()
                {
                    Id = 6,
                    Title = "Risker och beredskap",
                    ExplanationText = "Transparent kommunikation och rådgivning om tillfälliga åtgärder är avgörande för att skydda användarna medan en permanent lösning utvecklas.",
                    Text = "Inom företaget upptäckts det en sårbarhet i vår programvara som kunde möjliggöra obehörig åtkomst till användardata. Företaget har inte omedelbart en lösning. Vilken är den mest lämpliga första åtgärden?",
                    SegmentId = 4
                }, new QuestionModel()
                {
                    Id = 7,
                    Title = "Aktörer inom cyberbrott",
                    ExplanationText = "DDoS-attacker kräver ofta betydande resurser och koordinering, vilket är karakteristiskt för organiserade cyberbrottsliga grupper.",
                    Text = "Vårt företag blir måltavla för en DDoS-attack som överväldigar våra servers och gör våra tjänster otillgängliga för kunder. Vilken typ av aktör är mest sannolikt ansvarig för denna typ av attack?",
                    SegmentId = 4
                }, new QuestionModel()
                {
                    Id = 8,
                    Title = "Ökad digital närvaro och distansarbete",
                    ExplanationText = " Stärkt autentisering är kritisk för att säkra fjärråtkomst och skydda mot obehörig åtkomst i en distribuerad arbetsmiljö.",
                    Text = "Med övergången till distansarbete upptäcker vårt företag en ökning av säkerhetsincidenter, inklusive obehörig åtkomst till företagsdata. Vilken åtgärd bör företaget vidta för att adressera denna nya riskmiljö?",
                    SegmentId = 4
                }, new QuestionModel()
                {
                    Id = 9,
                    Title = "Cyberangrepp mot känsliga sektorer",
                    ExplanationText = "Ransomware-angrepp involverar kryptering av offerdata och kräver lösen för dekryptering, vilket är särskilt skadligt för kritiska sektorer som hälsovård.",
                    Text = "Hälsovårdsmyndigheten utsätts för ett cyberangrepp som krypterar patientdata och kräver lösen för att återställa åtkomsten. Vilken typ av angrepp har de sannolikt blivit utsatta för?",
                    SegmentId = 4
                }, new QuestionModel()
                {
                    Id = 10,
                    Title = "Cyberrånet mot Mersk",
                    ExplanationText = "Maersk utsattes för NotPetya ransomware-angreppet, som ledde till omfattande störningar och förluster genom att kryptera företagets globala system. Maersk rapporterade att företaget led ekonomiska förluster på grund av NotPetya ransomware-angreppet som uppskattades till cirka 300 miljoner USD. Denna siffra reflekterar de omfattande kostnaderna för störningar i deras globala verksamheter, återställande av system och data, samt förlust av affärer under tiden systemen var nere. NotPetya-angreppet anses vara ett av de mest kostsamma cyberangreppen mot ett enskilt företag och tjänar som en kraftfull påminnelse om de potentiella konsekvenserna av cyberhot.",
                    Text = "Det globala fraktbolaget Maersk blev offer för ett omfattande cyberangrepp som avsevärt störde deras verksamhet världen över. Vilken typ av malware var primärt ansvarig för denna incident?",
                    SegmentId = 4
                }, new QuestionModel()
                {
                    Id = 11,
                    Title = "Allmänt om cyberspionage",
                    ExplanationText = " Cyberspionage avser aktiviteter där aktörer, ofta statliga, engagerar sig i övervakning och datainsamling genom cybermedel för att erhålla hemlig information utan målets medgivande, typiskt för politiska, militära eller ekonomiska fördelar.",
                    Text = "Regeringen upptäcker att känslig politisk kommunikation har läckt och misstänker elektronisk övervakning. Vilket fenomen beskriver bäst denna situation?",
                    SegmentId = 8
                }, new QuestionModel()
                {
                    Id = 12,
                    Title = "Metoder för cyberspionage",
                    ExplanationText = "Riktade cyberattacker som utnyttjar noll-dagars Zero-day sårbarheter är en avancerad metod för cyberspionage där angriparen specifikt riktar in sig på ett mål för att komma åt känslig information eller data genom att utnyttja tidigare okända sårbarheter i programvara.",
                    Text = "Regeringen blir varse om en sofistikerad skadeprogramskampanj som utnyttjar Zero-day sårbarheter för att infiltrera deras nätverk och stjäla oerhört viktig data. Vilken metod för cyberspionage används sannolikt här?",
                    SegmentId = 8
                }, new QuestionModel()
                {
                    Id = 13,
                    Title = "Säkerhetsskyddslagen",
                    ExplanationText = "Säkerhetsskyddslagen är en svensk lagstiftning som syftar till att skydda nationellt känslig information från spioneri, sabotage, terroristbrott och andra säkerhetshot. Lagen ställer krav på säkerhetsskyddsåtgärder för verksamheter av betydelse för Sveriges säkerhet.",
                    Text = "Regeringen i Sverige ökar sitt interna säkerhetsprotokoll för att skydda sig mot utländska underrättelsetjänsters infiltration. Vilken lagstiftning ger ramverket för detta skydd?",
                    SegmentId = 8
                },
                 new QuestionModel()
                 {
                     Id = 14,
                     Title = "Cyberspionagets aktörer",
                     ExplanationText = "Lunds universitet upptäcker att forskningsdata om ny teknologi har stulits. Undersökningar tyder på en välorganiserad grupp med kopplingar till en utländsk stat. Vilken typ av aktör ligger sannolikt bakom detta?",
                     Text = "Statssponsrade hackers är aktörer som arbetar på uppdrag av eller med stöd från en regering för att genomföra cyberspionage, ofta riktat mot utländska intressen, organisationer eller regeringar för att få strategiska fördelar.",
                     SegmentId = 8
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
                    IsCorrectAnswer = false

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
                    IsCorrectAnswer = true
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
                    IsCorrectAnswer = true
                },
                new AnswerModel()
                {
                    Id = 23,
                    QuestionId = 8,
                    Text = "Införa striktare lösenordspolicyer och tvåfaktorsautentisering för fjärråtkomst",
                    IsCorrectAnswer = false
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
                }, new AnswerModel()
                {
                    Id = 42,
                    QuestionId = 14,
                    Text = "Statssponsrade hackers",
                    IsCorrectAnswer = true

                });
        }

    }
}

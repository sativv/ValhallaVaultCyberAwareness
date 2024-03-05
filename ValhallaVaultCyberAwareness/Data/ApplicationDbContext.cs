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
                    Name = "Att skydda sig mot bedr�gerier"
                },
                new CategoryModel()
                {
                    Id = 2,
                    Name = "Cybers�kerhet f�r f�retag"
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
                    Title = "Kreditkortsbedr�geri",
                    Text = "Du f�r ett ov�ntat telefonsamtal fr�n n�gon som p�st�r sig vara fr�n din bank. Personen ber dig bekr�fta ditt kontonummer och l�senord f�r att \"s�kerst�lla din kontos s�kerhet\" efter en p�st�dd s�kerhetsincident. Hur b�r du tolka denna situation?",
                    ExplanationText = "Banker och andra finansiella institutioner beg�r aldrig k�nslig information s�som kontonummer eller l�senord via telefon. Detta �r ett klassiskt tecken p� telefonbedr�geri.",
                    SegmentId = 1,
                },
                new QuestionModel()
                {
                    Id = 2,
                    Title = "Romansbedr�geri",
                    Text = "Efter flera m�nader av daglig kommunikation med n�gon du tr�ffade p� en datingsida, b�rjar personen ber�tta om en pl�tslig finansiell kris och ber om din hj�lp genom att �verf�ra pengar. Vad indikerar detta mest sannolikt?",
                    ExplanationText = "Beg�ran om pengar, s�rskilt under omst�ndigheter d�r tv� personer aldrig har tr�ffats fysiskt, �r ett vanligt tecken p� romansbedr�geri.",
                    SegmentId = 1,
                },
                new QuestionModel()
                {
                    Id = 3,
                    Title = "Investeringsbedr�geri",
                    Text = "Du f�r ett e-postmeddelande/samtal om ett exklusivt erbjudande att investera i ett startup-f�retag som p�st�s ha en revolutionerande ny teknologi, med garantier om exceptionellt h�g avkastning p� mycket kort tid. Hur b�r du f�rh�lla dig till erbjudandet?",
                    ExplanationText = "Erbjudanden som lovar h�g avkastning med liten eller ingen risk, s�rskilt via o�nskade e-postmeddelanden, �r ofta tecken p� investeringsbedr�gerier",
                    SegmentId = 1,
                },
                new QuestionModel()
                {
                    Id = 4,
                    Title = "Telefonbedr�geri",
                    ExplanationText = "Oidentifierade transaktioner p� ditt kreditkortsutdrag �r en stark indikation p� att ditt kortnummer har komprometterats och anv�nts f�r obeh�riga k�p, vilket �r typiskt f�r kreditkortsbedr�geri",
                    Text = "Efter en online-shoppingrunda m�rker du oidentifierade transaktioner p� ditt kreditkortsutdrag fr�n f�retag du aldrig handlat fr�n. Vad indikerar detta mest sannolikt?",
                    SegmentId = 1,

                },
                new QuestionModel()
                {
                    Id = 5,
                    Title = "Digital s�kerhet p� f�retag",
                    ExplanationText = "Utbildning i digital s�kerhet �r avg�rande f�r att hj�lpa anst�llda att k�nna igen och undvika s�kerhetshot som phishing, vilket �r en vanlig attackvektor.",
                    Text = "Inom f�retaget m�rker man att konfidentiella dokument regelbundet l�cker ut till konkurrenter. Efter en intern granskning uppt�cks det att en anst�lld omedvetet har installerat skadlig programvara genom att klicka p� en l�nk i ett phishing-e-postmeddelande. Vilken �tg�rd b�r prioriteras f�r att f�rhindra framtida incidenter?",
                    SegmentId = 4
                }, new QuestionModel()
                {
                    Id = 6,
                    Title = "Risker och beredskap",
                    ExplanationText = "Transparent kommunikation och r�dgivning om tillf�lliga �tg�rder �r avg�rande f�r att skydda anv�ndarna medan en permanent l�sning utvecklas.",
                    Text = "Inom f�retaget uppt�ckts det en s�rbarhet i v�r programvara som kunde m�jligg�ra obeh�rig �tkomst till anv�ndardata. F�retaget har inte omedelbart en l�sning. Vilken �r den mest l�mpliga f�rsta �tg�rden?",
                    SegmentId = 4
                }, new QuestionModel()
                {
                    Id = 7,
                    Title = "Akt�rer inom cyberbrott",
                    ExplanationText = "DDoS-attacker kr�ver ofta betydande resurser och koordinering, vilket �r karakteristiskt f�r organiserade cyberbrottsliga grupper.",
                    Text = "V�rt f�retag blir m�ltavla f�r en DDoS-attack som �verv�ldigar v�ra servers och g�r v�ra tj�nster otillg�ngliga f�r kunder. Vilken typ av akt�r �r mest sannolikt ansvarig f�r denna typ av attack?",
                    SegmentId = 4
                }, new QuestionModel()
                {
                    Id = 8,
                    Title = "�kad digital n�rvaro och distansarbete",
                    ExplanationText = " St�rkt autentisering �r kritisk f�r att s�kra fj�rr�tkomst och skydda mot obeh�rig �tkomst i en distribuerad arbetsmilj�.",
                    Text = "Med �verg�ngen till distansarbete uppt�cker v�rt f�retag en �kning av s�kerhetsincidenter, inklusive obeh�rig �tkomst till f�retagsdata. Vilken �tg�rd b�r f�retaget vidta f�r att adressera denna nya riskmilj�?",
                    SegmentId = 4
                }, new QuestionModel()
                {
                    Id = 9,
                    Title = "Cyberangrepp mot k�nsliga sektorer",
                    ExplanationText = "Ransomware-angrepp involverar kryptering av offerdata och kr�ver l�sen f�r dekryptering, vilket �r s�rskilt skadligt f�r kritiska sektorer som h�lsov�rd.",
                    Text = "H�lsov�rdsmyndigheten uts�tts f�r ett cyberangrepp som krypterar patientdata och kr�ver l�sen f�r att �terst�lla �tkomsten. Vilken typ av angrepp har de sannolikt blivit utsatta f�r?",
                    SegmentId = 4
                }, new QuestionModel()
                {
                    Id = 10,
                    Title = "Cyberr�net mot Mersk",
                    ExplanationText = "Maersk utsattes f�r NotPetya ransomware-angreppet, som ledde till omfattande st�rningar och f�rluster genom att kryptera f�retagets globala system. Maersk rapporterade att f�retaget led ekonomiska f�rluster p� grund av NotPetya ransomware-angreppet som uppskattades till cirka 300 miljoner USD. Denna siffra reflekterar de omfattande kostnaderna f�r st�rningar i deras globala verksamheter, �terst�llande av system och data, samt f�rlust av aff�rer under tiden systemen var nere. NotPetya-angreppet anses vara ett av de mest kostsamma cyberangreppen mot ett enskilt f�retag och tj�nar som en kraftfull p�minnelse om de potentiella konsekvenserna av cyberhot.",
                    Text = "Det globala fraktbolaget Maersk blev offer f�r ett omfattande cyberangrepp som avsev�rt st�rde deras verksamhet v�rlden �ver. Vilken typ av malware var prim�rt ansvarig f�r denna incident?",
                    SegmentId = 4
                }, new QuestionModel()
                {
                    Id = 11,
                    Title = "Allm�nt om cyberspionage",
                    ExplanationText = " Cyberspionage avser aktiviteter d�r akt�rer, ofta statliga, engagerar sig i �vervakning och datainsamling genom cybermedel f�r att erh�lla hemlig information utan m�lets medgivande, typiskt f�r politiska, milit�ra eller ekonomiska f�rdelar.",
                    Text = "Regeringen uppt�cker att k�nslig politisk kommunikation har l�ckt och misst�nker elektronisk �vervakning. Vilket fenomen beskriver b�st denna situation?",
                    SegmentId = 8
                }, new QuestionModel()
                {
                    Id = 12,
                    Title = "Metoder f�r cyberspionage",
                    ExplanationText = "Riktade cyberattacker som utnyttjar noll-dagars Zero-day s�rbarheter �r en avancerad metod f�r cyberspionage d�r angriparen specifikt riktar in sig p� ett m�l f�r att komma �t k�nslig information eller data genom att utnyttja tidigare ok�nda s�rbarheter i programvara.",
                    Text = "Regeringen blir varse om en sofistikerad skadeprogramskampanj som utnyttjar Zero-day s�rbarheter f�r att infiltrera deras n�tverk och stj�la oerh�rt viktig data. Vilken metod f�r cyberspionage anv�nds sannolikt h�r?",
                    SegmentId = 8
                }, new QuestionModel()
                {
                    Id = 13,
                    Title = "S�kerhetsskyddslagen",
                    ExplanationText = "S�kerhetsskyddslagen �r en svensk lagstiftning som syftar till att skydda nationellt k�nslig information fr�n spioneri, sabotage, terroristbrott och andra s�kerhetshot. Lagen st�ller krav p� s�kerhetsskydds�tg�rder f�r verksamheter av betydelse f�r Sveriges s�kerhet.",
                    Text = "Regeringen i Sverige �kar sitt interna s�kerhetsprotokoll f�r att skydda sig mot utl�ndska underr�ttelsetj�nsters infiltration. Vilken lagstiftning ger ramverket f�r detta skydd?",
                    SegmentId = 8
                },
                 new QuestionModel()
                 {
                     Id = 14,
                     Title = "Cyberspionagets akt�rer",
                     ExplanationText = "Lunds universitet uppt�cker att forskningsdata om ny teknologi har stulits. Unders�kningar tyder p� en v�lorganiserad grupp med kopplingar till en utl�ndsk stat. Vilken typ av akt�r ligger sannolikt bakom detta?",
                     Text = "Statssponsrade hackers �r akt�rer som arbetar p� uppdrag av eller med st�d fr�n en regering f�r att genomf�ra cyberspionage, ofta riktat mot utl�ndska intressen, organisationer eller regeringar f�r att f� strategiska f�rdelar.",
                     SegmentId = 8
                 }
                );

            builder.Entity<AnswerModel>().HasData(
                new AnswerModel()
                {
                    Id = 1,
                    QuestionId = 1,
                    Text = "Ett legitimt f�rs�k fr�n banken att skydda ditt konto",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 2,
                    QuestionId = 1,
                    Text = "En informationsinsamling f�r en marknadsunders�kning",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 3,
                    QuestionId = 1,
                    Text = "Ett potentiellt telefonbedr�geri",
                    IsCorrectAnswer = true
                },
                new AnswerModel()
                {
                    Id = 4,
                    QuestionId = 2,
                    Text = "En legitim beg�ran om hj�lp fr�n en person i n�d",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 5,
                    QuestionId = 2,
                    Text = "Ett romansbedr�geri",
                    IsCorrectAnswer = true
                },
                new AnswerModel()
                {
                    Id = 6,
                    QuestionId = 2,
                    Text = "En tillf�llig ekonomisk sv�righet",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 7,
                    QuestionId = 3,
                    Text = "Genomf�ra omedelbar investering f�r att inte missa m�jligheten",
                    IsCorrectAnswer = false
                }, new AnswerModel()
                {
                    Id = 8,
                    QuestionId = 3,
                    Text = "Investeringsbedr�geri",
                    IsCorrectAnswer = false

                },
                new AnswerModel()
                {
                    Id = 9,
                    QuestionId = 3,
                    Text = "Beg�ra mer information f�r att utf�ra en noggrann ��due diligence��",
                    IsCorrectAnswer = false

                },
                new AnswerModel()
                {
                    Id = 10,
                    QuestionId = 4,
                    Text = "Ett misstag av kreditkortsf�retaget",
                    IsCorrectAnswer = false
                }, new AnswerModel()
                {
                    Id = 11,
                    QuestionId = 4,
                    Text = "Kreditkortsbedr�geri",
                    IsCorrectAnswer = true

                },
                new AnswerModel()
                {
                    Id = 12,
                    QuestionId = 4,
                    Text = "Obeh�riga k�p av en familjemedlem",
                    IsCorrectAnswer = false

                },
                new AnswerModel()
                {
                    Id = 13,
                    QuestionId = 5,
                    Text = "Utbildning i digital s�kerhet f�r alla anst�llda",
                    IsCorrectAnswer = true

                },
                new AnswerModel()
                {
                    Id = 14,
                    QuestionId = 5,
                    Text = "Installera en starkare brandv�gg",
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
                    Text = " Informera alla anv�ndare om s�rbarheten och rekommendera tempor�ra skydds�tg�rder",
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
                    Text = "St�nga ner tj�nsten tillf�lligt",
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
                    Text = "En konkurrerande f�retagsentitet",
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
                    Text = "�terg� till kontorsarbete",
                    IsCorrectAnswer = true
                },
                new AnswerModel()
                {
                    Id = 23,
                    QuestionId = 8,
                    Text = "Inf�ra striktare l�senordspolicyer och tv�faktorsautentisering f�r fj�rr�tkomst",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 24,
                    QuestionId = 8,
                    Text = "F�rbjuda anv�ndning av personliga enheter f�r arbete",
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
                    Text = "Social ingenj�rskonst",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 35,
                    QuestionId = 12,
                    Text = "Mass�vervakning",
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
                    Text = "S�kerhetsskyddslagen",
                    IsCorrectAnswer = true

                },
                new AnswerModel()
                {
                    Id = 39,
                    QuestionId = 13,
                    Text = "IT-s�kerhetslagen",
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

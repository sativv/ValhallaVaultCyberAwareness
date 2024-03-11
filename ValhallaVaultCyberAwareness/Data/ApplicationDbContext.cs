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

            builder.Entity<SubCategoryModel>().HasData(
                new SubCategoryModel()
                {
                    Id = 1,
                    Title = "Kreditkortsbedr�geri",
                    SegmentId = 1,
                },
                new SubCategoryModel()
                {
                    Id = 2,
                    Title = "Romansbedr�geri",
                    SegmentId = 1,
                },
                new SubCategoryModel()
                {
                    Id = 3,
                    Title = "Investeringsbedr�geri",
                    SegmentId = 1,
                },
                new SubCategoryModel()
                {
                    Id = 4,
                    Title = "Telefonbedr�geri",
                    SegmentId = 1,
                },
                new SubCategoryModel()
                {
                    Id = 5,
                    Title = "Bedr�gerier i hemmet",
                    SegmentId = 2,
                },
                new SubCategoryModel()
                {
                    Id = 6,
                    Title = "Identitetsst�ld",
                    SegmentId = 2,
                },
                new SubCategoryModel()
                {
                    Id = 7,
                    Title = "N�tfiske och bluffmejl",
                    SegmentId = 2,
                },
                new SubCategoryModel()
                {
                    Id = 8,
                    Title = "Investeringsbedr�geri p� n�tet",
                    SegmentId = 2,
                },
                new SubCategoryModel()
                {
                    Id = 9,
                    Title = "Abonnemangsf�llor och falska fakturor",
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
                    Title = "Statistik och f�rh�llningss�tt",
                    SegmentId = 3,
                },
                new SubCategoryModel()
                {
                    Id = 12,
                    Title = "Digital s�kerhet p� f�retag",
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
                    Title = "Akt�rer inom cyberbrott",
                    SegmentId = 4,
                },
                new SubCategoryModel()
                {
                    Id = 15,
                    Title = "�kad digital n�rvaro och distansarbete",
                    SegmentId = 4,
                },
                new SubCategoryModel()
                {
                    Id = 16,
                    Title = "Cyberangrepp mot k�nsliga sektorer",
                    SegmentId = 4,
                },
                new SubCategoryModel()
                {
                    Id = 17,
                    Title = "Cyberr�net mot Mersk",
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
                    Title = "N�tfiske och skr�ppost",
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
                    Title = "Varning f�r vishing",
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
                    Title = "�neangreoo och presentkortsbluffar",
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
                    Title = "S� kan det g� till",
                    SegmentId = 6,
                },
                new SubCategoryModel()
                {
                    Id = 26,
                    Title = "N�tverksintr�ng",
                    SegmentId = 6,
                },
                new SubCategoryModel()
                {
                    Id = 27,
                    Title = "Dataintr�ng",
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
                    Title = "V�garna in",
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
                    Title = "Mirai, Wannacry och fallet D�sseldorf",
                    SegmentId = 7,
                },
                new SubCategoryModel()
                {
                    Id = 35,
                    Title = "De s�rbara molnen",
                    SegmentId = 7,
                },
                new SubCategoryModel()
                {
                    Id = 36,
                    Title = "Allm�nt om cyberspionage",
                    SegmentId = 8,
                },
                new SubCategoryModel()
                {
                    Id = 37,
                    Title = "Metoder f�r cyberspionage",
                    SegmentId = 8,
                },
                new SubCategoryModel()
                {
                    Id = 38,
                    Title = "S�kerhetsskyddslagen",
                    SegmentId = 8,
                },
                new SubCategoryModel()
                {
                    Id = 39,
                    Title = "Cyberspionagets akt�rer",
                    SegmentId = 8,
                },
                new SubCategoryModel()
                {
                    Id = 40,
                    Title = "V�rvningsf�rs�k",
                    SegmentId = 9,
                },
                new SubCategoryModel()
                {
                    Id = 41,
                    Title = "Aff�rsspionage",
                    SegmentId = 9,
                },
                new SubCategoryModel()
                {
                    Id = 42,
                    Title = "P�verkanskampanjer",
                    SegmentId = 9,
                },
                new SubCategoryModel()
                {
                    Id = 43,
                    Title = "Svensk underr�ttelsetj�nst och cyberf�rsvar",
                    SegmentId = 10,
                },
                new SubCategoryModel()
                {
                    Id = 44,
                    Title = "Signalspaning, informationss�kerhet och 5G",
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
                    Title = "Ov�ntat telefonsamtal",
                    Text = "Du f�r ett ov�ntat telefonsamtal fr�n n�gon som p�st�r sig vara fr�n din bank. Personen ber dig bekr�fta ditt kontonummer och l�senord f�r att \"s�kerst�lla din kontos s�kerhet\" efter en p�st�dd s�kerhetsincident. Hur b�r du tolka denna situation?",
                    ExplanationText = "Banker och andra finansiella institutioner beg�r aldrig k�nslig information s�som kontonummer eller l�senord via telefon. Detta �r ett klassiskt tecken p� telefonbedr�geri.",
                    SubCategoryId = 1,
                },
                new QuestionModel()
                {
                    Id = 2,
                    Title = "Beg�ran om pengar fr�n datingsida",
                    Text = "Efter flera m�nader av daglig kommunikation med n�gon du tr�ffade p� en datingsida, b�rjar personen ber�tta om en pl�tslig finansiell kris och ber om din hj�lp genom att �verf�ra pengar. Vad indikerar detta mest sannolikt?",
                    ExplanationText = "Beg�ran om pengar, s�rskilt under omst�ndigheter d�r tv� personer aldrig har tr�ffats fysiskt, �r ett vanligt tecken p� romansbedr�geri.",
                    SubCategoryId = 2,
                },
                new QuestionModel()
                {
                    Id = 3,
                    Title = "Exklusivt investeringserbjudande",
                    Text = "Du f�r ett e-postmeddelande/samtal om ett exklusivt erbjudande att investera i ett startup-f�retag som p�st�s ha en revolutionerande ny teknologi, med garantier om exceptionellt h�g avkastning p� mycket kort tid. Hur b�r du f�rh�lla dig till erbjudandet?",
                    ExplanationText = "Erbjudanden som lovar h�g avkastning med liten eller ingen risk, s�rskilt via o�nskade e-postmeddelanden, �r ofta tecken p� investeringsbedr�gerier",
                    SubCategoryId = 3,
                },
                new QuestionModel()
                {
                    Id = 4,
                    Title = "Oidentifierade transaktioner",
                    ExplanationText = "Oidentifierade transaktioner p� ditt kreditkortsutdrag �r en stark indikation p� att ditt kortnummer har komprometterats och anv�nts f�r obeh�riga k�p, vilket �r typiskt f�r kreditkortsbedr�geri",
                    Text = "Efter en online-shoppingrunda m�rker du oidentifierade transaktioner p� ditt kreditkortsutdrag fr�n f�retag du aldrig handlat fr�n. Vad indikerar detta mest sannolikt?",
                    SubCategoryId = 4,

                },
                new QuestionModel()
                {
                    Id = 5,
                    Title = "Konfidentiella dokument l�cker till konkurrenter",
                    ExplanationText = "Utbildning i digital s�kerhet �r avg�rande f�r att hj�lpa anst�llda att k�nna igen och undvika s�kerhetshot som phishing, vilket �r en vanlig attackvektor.",
                    Text = "Inom f�retaget m�rker man att konfidentiella dokument regelbundet l�cker ut till konkurrenter. Efter en intern granskning uppt�cks det att en anst�lld omedvetet har installerat skadlig programvara genom att klicka p� en l�nk i ett phishing-e-postmeddelande. Vilken �tg�rd b�r prioriteras f�r att f�rhindra framtida incidenter?",
                    SubCategoryId = 12
                }, new QuestionModel()
                {
                    Id = 6,
                    Title = "S�rbarhet i programvara",
                    ExplanationText = "Transparent kommunikation och r�dgivning om tillf�lliga �tg�rder �r avg�rande f�r att skydda anv�ndarna medan en permanent l�sning utvecklas.",
                    Text = "Inom f�retaget uppt�ckts det en s�rbarhet i v�r programvara som kunde m�jligg�ra obeh�rig �tkomst till anv�ndardata. F�retaget har inte omedelbart en l�sning. Vilken �r den mest l�mpliga f�rsta �tg�rden?",
                    SubCategoryId = 13
                }, new QuestionModel()
                {
                    Id = 7,
                    Title = "DDoS-attack",
                    ExplanationText = "DDoS-attacker kr�ver ofta betydande resurser och koordinering, vilket �r karakteristiskt f�r organiserade cyberbrottsliga grupper.",
                    Text = "V�rt f�retag blir m�ltavla f�r en DDoS-attack som �verv�ldigar v�ra servers och g�r v�ra tj�nster otillg�ngliga f�r kunder. Vilken typ av akt�r �r mest sannolikt ansvarig f�r denna typ av attack?",
                    SubCategoryId = 14
                }, new QuestionModel()
                {
                    Id = 8,
                    Title = "�kning av s�kerhetsincidenter vid distansarbete",
                    ExplanationText = " St�rkt autentisering �r kritisk f�r att s�kra fj�rr�tkomst och skydda mot obeh�rig �tkomst i en distribuerad arbetsmilj�.",
                    Text = "Med �verg�ngen till distansarbete uppt�cker v�rt f�retag en �kning av s�kerhetsincidenter, inklusive obeh�rig �tkomst till f�retagsdata. Vilken �tg�rd b�r f�retaget vidta f�r att adressera denna nya riskmilj�?",
                    SubCategoryId = 15
                }, new QuestionModel()
                {
                    Id = 9,
                    Title = "Cyberangrepp som krypterar patientdata",
                    ExplanationText = "Ransomware-angrepp involverar kryptering av offerdata och kr�ver l�sen f�r dekryptering, vilket �r s�rskilt skadligt f�r kritiska sektorer som h�lsov�rd.",
                    Text = "H�lsov�rdsmyndigheten uts�tts f�r ett cyberangrepp som krypterar patientdata och kr�ver l�sen f�r att �terst�lla �tkomsten. Vilken typ av angrepp har de sannolikt blivit utsatta f�r?",
                    SubCategoryId = 16
                }, new QuestionModel()
                {
                    Id = 10,
                    Title = "Maersk",
                    ExplanationText = "Maersk utsattes f�r NotPetya ransomware-angreppet, som ledde till omfattande st�rningar och f�rluster genom att kryptera f�retagets globala system. Maersk rapporterade att f�retaget led ekonomiska f�rluster p� grund av NotPetya ransomware-angreppet som uppskattades till cirka 300 miljoner USD. Denna siffra reflekterar de omfattande kostnaderna f�r st�rningar i deras globala verksamheter, �terst�llande av system och data, samt f�rlust av aff�rer under tiden systemen var nere. NotPetya-angreppet anses vara ett av de mest kostsamma cyberangreppen mot ett enskilt f�retag och tj�nar som en kraftfull p�minnelse om de potentiella konsekvenserna av cyberhot.",
                    Text = "Det globala fraktbolaget Maersk blev offer f�r ett omfattande cyberangrepp som avsev�rt st�rde deras verksamhet v�rlden �ver. Vilken typ av malware var prim�rt ansvarig f�r denna incident?",
                    SubCategoryId = 17
                }, new QuestionModel()
                {
                    Id = 11,
                    Title = "K�nslig politisk kommunikation har l�ckt",
                    ExplanationText = " Cyberspionage avser aktiviteter d�r akt�rer, ofta statliga, engagerar sig i �vervakning och datainsamling genom cybermedel f�r att erh�lla hemlig information utan m�lets medgivande, typiskt f�r politiska, milit�ra eller ekonomiska f�rdelar.",
                    Text = "Regeringen uppt�cker att k�nslig politisk kommunikation har l�ckt och misst�nker elektronisk �vervakning. Vilket fenomen beskriver b�st denna situation?",
                    SubCategoryId = 36
                }, new QuestionModel()
                {
                    Id = 12,
                    Title = "Skadeprogramskampanj",
                    ExplanationText = "Riktade cyberattacker som utnyttjar noll-dagars Zero-day s�rbarheter �r en avancerad metod f�r cyberspionage d�r angriparen specifikt riktar in sig p� ett m�l f�r att komma �t k�nslig information eller data genom att utnyttja tidigare ok�nda s�rbarheter i programvara.",
                    Text = "Regeringen blir varse om en sofistikerad skadeprogramskampanj som utnyttjar Zero-day s�rbarheter f�r att infiltrera deras n�tverk och stj�la oerh�rt viktig data. Vilken metod f�r cyberspionage anv�nds sannolikt h�r?",
                    SubCategoryId = 37
                }, new QuestionModel()
                {
                    Id = 13,
                    Title = "Interna s�kerhetsprotokoll",
                    ExplanationText = "S�kerhetsskyddslagen �r en svensk lagstiftning som syftar till att skydda nationellt k�nslig information fr�n spioneri, sabotage, terroristbrott och andra s�kerhetshot. Lagen st�ller krav p� s�kerhetsskydds�tg�rder f�r verksamheter av betydelse f�r Sveriges s�kerhet.",
                    Text = "Regeringen i Sverige �kar sitt interna s�kerhetsprotokoll f�r att skydda sig mot utl�ndska underr�ttelsetj�nsters infiltration. Vilken lagstiftning ger ramverket f�r detta skydd?",
                    SubCategoryId = 38
                },
                new QuestionModel()
                {
                    Id = 14,
                    Title = "Statssponsrade hackers",
                    ExplanationText = "Lunds universitet uppt�cker att forskningsdata om ny teknologi har stulits. Unders�kningar tyder p� en v�lorganiserad grupp med kopplingar till en utl�ndsk stat. Vilken typ av akt�r ligger sannolikt bakom detta?",
                    Text = "Statssponsrade hackers �r akt�rer som arbetar p� uppdrag av eller med st�d fr�n en regering f�r att genomf�ra cyberspionage, ofta riktat mot utl�ndska intressen, organisationer eller regeringar f�r att f� strategiska f�rdelar.",
                    SubCategoryId = 39
                },
                new QuestionModel()
                {
                    Id = 15,
                    Title = "N�gon efterfr�gar personlig finansiell information",
                    ExplanationText = "Det s�kraste s�ttet att hantera potentiella telefonbedr�gerier �r att avsluta samtalet och sedan sj�lv ringa upp din bank via ett telefonnummer du vet �r korrekt (till exempel fr�n deras officiella webbplats eller ditt bankkort) f�r att verifiera om samtalet var legitimt.",
                    Text = "Vad b�r du g�ra omedelbart efter att ha mottagit ett misst�nkt telefonsamtal d�r n�gon fr�gar efter personlig finansiell information?",
                    SubCategoryId = 1
                },
                new QuestionModel()
                {
                    Id = 16,
                    Title = "Hur kommunicerar finansiella institutioner",
                    ExplanationText = "Kommunikationen fr�n banker och finansiella institutioner inneh�ller aldrig f�rfr�gningar om k�nslig information som l�senord eller kontonummer via os�kra kanaler som telefon eller e-post. Detta �r en grundl�ggande s�kerhetsprincip.",
                    Text = "Vilket av f�ljande p�st�enden �r sant ang�ende hur finansiella institutioner kommunicerar med sina kunder?",
                    SubCategoryId = 1
                },
                new QuestionModel()
                {
                    Id = 17,
                    Title = "Skydda dig mot telefonbedr�geri",
                    ExplanationText = "Genom att ha f�rutbest�mda s�kerhetsfr�gor med din bank kan du och banken ha en s�ker metod f�r att bekr�fta varandras identitet under telefonsamtal. Detta minskar risken f�r att bli lurad av bedragare som inte kan svara p� dessa fr�gor.",
                    Text = "Hur kan du b�st skydda dig mot telefonbedr�gerier?",
                    SubCategoryId = 1
                },
                new QuestionModel()
                {
                    Id = 18,
                    Title = "S�kerst�lla anst�lldas ansvar",
                    ExplanationText = "En automatisk policy f�r l�senords�ndring tvingar fram regelbundna uppdateringar och s�kerst�ller att l�senorden h�lls starka och sv�ra att kn�cka, vilket minskar risken f�r obeh�rig �tkomst.",
                    Text = "Vilken �tg�rd �r mest effektiv f�r att s�kerst�lla att anst�llda regelbundet uppdaterar sina l�senord till starkare och mer komplexa versioner?",
                    SubCategoryId = 12
                },
                new QuestionModel()
                {
                    Id = 19,
                    Title = "Otrygga Wi-Fi-n�tv�rk",
                    ExplanationText = "Genom att anv�nda VPN kan anst�llda s�kert ansluta till f�retagets n�tverk �ven fr�n otrygga Wi-Fi-n�tverk, vilket krypterar data�verf�ring och skyddar mot avlyssning och andra cyberhot.",
                    Text = "Hur kan f�retaget effektivt minska risken f�r att anst�llda oavsiktligt exponerar f�retagsdata via otrygga Wi-Fi-n�tverk?",
                    SubCategoryId = 12
                },
                new QuestionModel()
                {
                    Id = 20,
                    Title = "�tg�rd mot e-postbaserade intr�ng",
                    ExplanationText = "Avancerade e-posts�kerhetsl�sningar kan effektivt identifiera och blockera skadlig programvara och phishing-f�rs�k, vilket minskar risken f�r att anst�llda oavsiktligt exponerar f�retagets system och data f�r cyberhot.",
                    Text = "Vilken �tg�rd b�r ett f�retag ta f�r att skydda sig mot intr�ng via e-postbaserade hot som phishing?",
                    SubCategoryId = 12
                },
                new QuestionModel()
                {
                    Id = 21,
                    Title = "Mest effektiva f�rsvarsstrategi",
                    ExplanationText = "Kryptering �r en kraftfull metod f�r att skydda k�nslig information under �verf�ring och lagring, vilket g�r det extremt sv�rt f�r obeh�riga att f� tillg�ng till och f�rst� informationen, �ven om de lyckas avlyssna kommunikationen.\nInsiderhot �r en av de sv�raste s�kerhetsutmaningarna att identifiera och f�rebygga. Dessa hot kan komma fr�n anst�llda som, oavsett om det �r avsiktligt eller oavsiktligt, l�cker k�nslig information som kan utnyttjas f�r cyberspionage. Att anv�nda avancerade verktyg f�r beteendeanalys och anomalidetektering kan ge tidiga varningar om potentiella s�kerhetsbrott.",
                    Text = "Vilken f�rsvarsstrategi �r mest effektiv mot cyberspionage som riktar sig mot k�nslig kommunikation?",
                    SubCategoryId = 36
                },
                new QuestionModel()
                {
                    Id = 22,
                    Title = "Uppt�ck och motverka insiderhot",
                    ExplanationText = "Program f�r beteendeanalys och anomalidetektering kan effektivt identifiera ovanligt beteende eller aktiviteter som kan tyda p� insiderhot eller obeh�rig �tkomst till k�nslig information, vilket �r ett kritiskt steg f�r att f�rhindra cyberspionage.\nMjukvarus�rbarheter �r ofta den svaga l�nken som utnyttjas i cyberspionageattacker. Utan snabba och regelbundna s�kerhetsuppdateringar och patchar, kan dessa s�rbarheter l�mna d�rrarna vid�ppna f�r angripare. Att h�lla programvara och system uppdaterade �r en grundl�ggande men kritisk del av ett effektivt cybers�kerhetsf�rsvar.",
                    Text = "Hur kan organisationer b�st uppt�cka och motverka insiderhot som bidrar till cyberspionage?",
                    SubCategoryId = 36
                },
                new QuestionModel()
                {
                    Id = 23,
                    Title = "Skydd mot cyberspionage",
                    ExplanationText = "Regelbundna uppdateringar och patchning av mjukvara och operativsystem �r avg�rande f�r att st�nga s�kerhetsh�l som annars kan utnyttjas av cyberspioner. Detta minskar risken f�r intr�ng och datal�ckor avsev�rt.",
                    Text = "Vilken �tg�rd �r viktigast f�r att skydda sig mot cyberspionage genom utnyttjande av mjukvarus�rbarheter?",
                    SubCategoryId = 36
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
                    IsCorrectAnswer = true

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
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 23,
                    QuestionId = 8,
                    Text = "Inf�ra striktare l�senordspolicyer och tv�faktorsautentisering f�r fj�rr�tkomst",
                    IsCorrectAnswer = true
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
                    Text = "Ge dem informationen de ber om, f�r s�kerhets skull",
                    IsCorrectAnswer = false

                },
                new AnswerModel()
                {
                    Id = 44,
                    QuestionId = 15,
                    Text = "Avsluta samtalet och kontakta din bank direkt via ett officiellt nummer du vet �r korrekt",
                    IsCorrectAnswer = true
                },
                new AnswerModel()
                {
                    Id = 45,
                    QuestionId = 15,
                    Text = "V�nta p� att de ska ringa tillbaka f�r att bekr�fta deras legitimitet",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 46,
                    QuestionId = 16,
                    Text = "Banker skickar ofta e-postmeddelanden som ber kunder att direkt ange l�senord och kontonummer f�r verifiering.",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 47,
                    QuestionId = 16,
                    Text = "Banker ringer regelbundet sina kunder f�r att be dem upprepa sina kontouppgifter f�r s�kerhetsuppdateringar.",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 48,
                    QuestionId = 16,
                    Text = "Banker och finansiella institutioner kommer aldrig att be dig om ditt l�senord eller kontonummer via telefon eller e-post.",
                    IsCorrectAnswer = true
                },
                new AnswerModel()
                {
                    Id = 49,
                    QuestionId = 17,
                    Text = "Installera en app som blockerar misst�nkta samtal",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 50,
                    QuestionId = 17,
                    Text = "Aldrig svara p� samtal fr�n ok�nda nummer",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 51,
                    QuestionId = 17,
                    Text = "Uppr�tta starka s�kerhetsfr�gor med din bank som kr�vs f�r att identifiera dig �ver telefon",
                    IsCorrectAnswer = true
                },
                new AnswerModel()
                {
                    Id = 52,
                    QuestionId = 18,
                    Text = "Manuellt kontrollera varje anst�llds l�senord en g�ng per �r",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 53,
                    QuestionId = 18,
                    Text = "Implementera en policy f�r l�senordskomplexitet som kr�ver automatiska l�senords�ndringar var 90:e dag",
                    IsCorrectAnswer = true
                },
                new AnswerModel()
                {
                    Id = 54,
                    QuestionId = 18,
                    Text = "Uppmana anst�llda att v�lja l�ttih�gda l�senord f�r att undvika att skriva ner dem",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 55,
                    QuestionId = 19,
                    Text = "F�rbjuda anv�ndning av offentliga Wi-Fi-n�tverk helt och h�llet",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 56,
                    QuestionId = 19,
                    Text = "Utrusta alla anst�lldas enheter med VPN (Virtual Private Network)-tj�nster",
                    IsCorrectAnswer = true
                },
                new AnswerModel()
                {
                    Id = 57,
                    QuestionId = 19,
                    Text = "Endast till�ta anst�llda att arbeta offline n�r de inte �r p� kontoret",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 58,
                    QuestionId = 20,
                    Text = "Blockera all inkommande e-post fr�n externa k�llor",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 59,
                    QuestionId = 20,
                    Text = "Installera och uppdatera regelbundet e-posts�kerhetsl�sningar som filtrerar bort skadlig programvara och misst�nkta l�nkar",
                    IsCorrectAnswer = true
                },
                new AnswerModel()
                {
                    Id = 60,
                    QuestionId = 20,
                    Text = "L�ta anst�llda anv�nda personliga e-postkonton f�r arbete f�r att minska risken f�r f�retagets e-postservers s�kerhet",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 61,
                    QuestionId = 21,
                    Text = "�ka anv�ndningen av kryptering f�r all intern och extern kommunikation",
                    IsCorrectAnswer = true
                },
                new AnswerModel()
                {
                    Id = 62,
                    QuestionId = 21,
                    Text = "F�rbjuda all anv�ndning av e-post och �terg� till fysisk korrespondens",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 63,
                    QuestionId = 21,
                    Text = "Installera antivirusprogram p� alla datorer",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 64,
                    QuestionId = 22,
                    Text = "Genomf�ra strikta bakgrundskontroller av alla anst�llda",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 65,
                    QuestionId = 22,
                    Text = "Implementera ett omfattande program f�r beteendeanalys och anomalidetektering",
                    IsCorrectAnswer = true
                },
                new AnswerModel()
                {
                    Id = 66,
                    QuestionId = 22,
                    Text = "Begr�nsa internetanv�ndningen p� arbetsplatsen till arbetsrelaterade aktiviteter",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 67,
                    QuestionId = 23,
                    Text = "Genomf�ra regelbundna medvetenhetstr�ningar f�r alla anst�llda om cybers�kerhet",
                    IsCorrectAnswer = false
                },
                new AnswerModel()
                {
                    Id = 68,
                    QuestionId = 23,
                    Text = "H�lla all mjukvara och operativsystem uppdaterade med de senaste s�kerhetspatcharna",
                    IsCorrectAnswer = true
                },
                new AnswerModel()
                {
                    Id = 69,
                    QuestionId = 23,
                    Text = "Endast anv�nda egenutvecklad mjukvara f�r alla verksamhetsprocesser",
                    IsCorrectAnswer = false
                }
                );
        }
    }
}

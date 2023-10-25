using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GMS.Migrations
{
    public partial class dodavanjeSuplemenata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Suplement",
                columns: new[] { "ID", "Cijena", "DobavljacID", "Gramaza", "KategorijaID", "Naziv", "Opis" },
                values: new object[,]
                {
                    { 1, 139f, 1, 2500f, 1, "100% Isolate Whey Protein", "Muscle Freak 100% Isolate Whey Protein je visokokvalitetni izolat proteina sirutke, koji smo kreirali kako bi zadovoljili potrebe i najzahtjevnijih vježbača. Nakon godina uspješnog rada i distribucije najvećih brendova na tržištu, mi u Muscle Freaku smo odlučili da je vrijeme da i naša linija proizvoda ugleda svjetlo dana i da vam u skladu s našom tradicijom ponudimo najbolje i najkvalitetnije proizvode s predznakom bosanski brend." },
                    { 2, 99f, 3, 809f, 1, "Gold Standard 100% Casein", "Korištenjem samo vrhunskog kazeina kao izvora proteina u svom 100% Gold Standard Casein-u, Optimum Nutrition je stvorio formulu koja postavlja standard za sve sporootpuštajuće proteine." },
                    { 3, 89f, 2, 900f, 1, "Nitro-Tech Ripped", "NITRO-TECH RIPPED™ je najnovija inovacija iz MuscleTech-a, branda koji oduševljava svojim proizvodima više od 20 godina. Ova napredna formula kombinuje proteinske peptide najviše kvalitete i izolat sa naučno testiranim sastojcima za gubitak težine. Ova 7 u 1 formula također sadrži CLA, trigliceride srednjeg lanca (MCT), L-carnitine L-tartrate, ekstrakt zelenog čaja, ekstrakt šipka i prah algi. MuscleTech® je napravio ovu jedinstvenu formula s ciljem objedinjavanja ultra-čistog proteina i gubitka težine - ovakvo nešto niste nikad prije vidjeli. Za razliku od konkurencije, svaka mjerica NITRO-TECH RIPPED™ sadrži naučno proučavanu dozu ključnih sastojaka za gubitak težine, C. canephora robusta, koja je potvrđena od strane dvije naučne studije i u čije rezultate ne morate sumnjati! Također, nevjerovatnog je okusa koji će Vas oduševiti!" },
                    { 4, 139f, 2, 1800f, 1, "Nitro-Tech Whey Protein", "NITRO-TECH® je naučno istražena, pojačana proteinska formula kreirana za sve sportiste koji žele veću mišićnu masu, više snage i bolje performanse. NITRO-TECH® sadrži protein čiji primarni izvor su peptidi i izolat sirutke – dva najčistija i najkvalitetnija dostupna izvora proteina, za razliku od ostalih proteinskih suplemenata koji možda sadrže tek par gama ovih lako probavljivih i visoke biološke vrijednosti proteina. NITRO-TECH® je takođe poboljšan i sa 3g kreatin monohidrata, najistraženijim oblikom kreatina, namjenjenim za još veću mišićnu masu i snagu." },
                    { 5, 89f, 2, 908f, 1, "Nitro-Tech 100% Whey Gold", "Preko 20 godina NITRO-TECH® je vodeći proteinski brend, izgrađen na temelju naučnih istraživanja i korištenja najmodernije tehnologija. Sada je isti istraživački i razvojni tim stvorio novu formulu whey proteina baziranu na superiornim izvorima proteina, kvaliteti i tehnici proizvodnje. Predstavljamo vam NITRO-TECH® 100% WHEY GOLD – čistu proteinsku formulu koja sadrži peptide i izolat sirutke." },
                    { 6, 119f, 2, 2000f, 1, "Platinum 8 - hour Protein", "Vrhunska proteinska mješavina za sve namjene u bilo koje vrijeme posebno formulirana za sportiste koji žele biti na vrhuncu svoje igre. Dizajniran s visokokvalitetnom, višefaznom mješavinom proteina, može se uzimati kad god je potrebno - nakon treninga, između obroka ili prije spavanja." },
                    { 7, 35f, 4, 250f, 2, "BCAA 2:1:1", "Vrhunski ukusan spoj esencijalnih aminokiselina. Ovaj proizvod ne samo da pruža izvanredan ukus, već je i obogaćen esencijalnim hranjivim sastojcima poput vitamina C i vitamina B6. BCAA je kritičan faktor koji vam može pomoći da postignete najbolje iz svojih treninga." },
                    { 8, 45f, 4, 900f, 2, "HMB", "Self Omninutrition HMB (beta-hidroksi-beta-metilbutirat) je metabolit leucina koji sprečava razgradnju proteina i promoviše hipertrofiju mišića (povećanje ćelija koje grade tkivo); također smanjuje moguće povrede mišića nakon treninga visokog intenziteta, čime se smanjuje postotak masnoće u tijelu. Nedavna istraživanja su također pokazala da uzimanje HMB povećava mišićnu snagu, smanjuje simptome prekomjernog treninga te pozitivno utiče na VO2max (maksimalna potrošnja kiseonika). Neki stručnjaci smatraju da je VO2max ključni faktor u sportskim takmičenjima sportista. HMB je vrijedan dodatak ishrani za snagu, performanse i izdržljivost." },
                    { 9, 75f, 2, 400f, 2, "Amino Build Performance", "Napunjene sa gradivnim elementima kako bi podržale brz oporavak. Imajući u vidu da su BCAA kao osnova u sastavu, ubrzat će period oporavka poslije treninga." },
                    { 10, 85f, 2, 594f, 2, "Cell Tech Elite", "Cell Tech Elite je visoko potentna formula koja pruža vrhunsku dozu od 5 g kreatinske matrice, koja uključuje kreatin monohidrat i kreatin hidroklorid. Osim toga, ova formula sadrži klinički dokazanu dozu od 400 mg Peak ATP-a, koji omogućava povećanje snage i veći broj ponavljanja u treningu. U kliničkoj studiji je dokazano da su ispitanici koji su koristili Peak ATP izgradili 90% više mišića u poređenju sa placebom, postižući impresivne rezultate u roku od 12 sedmica intenzivnog treninga." },
                    { 11, 85f, 5, 480f, 2, "CW Intra Surgence", "CW Intra Surgence je naučno formuliran Intra-Workout dodatak koji pruža visoko doziranu mješavinu punog spektra esencijalnih aminokiselina (EAA) i razgranatih lanaca aminokiselina (BCAA), zajedno s najnovijim hidratacijskim sastojcima i patentiranim dodacima za povećanje energije." },
                    { 12, 65f, 6, 433f, 2, "Amino X", "Amino X je specijalna aminokiselinska formula dizajnirana da pomogne tijelu u povećanju izdržljivosti tokom treninga i mišićnom oporavku nakon treninga. Sadrži kvalitetnu anaboličku mješavinu, koja spriječava katabolizam (propadanje mišićnih vlakna) te se brine za obnovu i rast mišića." },
                    { 13, 65f, 1, 300f, 3, "Power Reactor", "Muscle Freak Power Reactor je visokokvalitetni pre-workout, koji smo kreirali kako bi zadovoljili potrebe i najzahtjevnijih vježbača. Nakon godina uspješnog rada i distribucije najvećih brendova na tržištu, mi u Muscle Freaku smo odlučili da je vrijeme da i naša linija proizvoda ugleda svjetlo dana i da vam u skladu s našom tradicijom ponudimo najbolje i najkvalitetnije proizvode s predznakom bosanski brend." },
                    { 14, 69f, 2, 266f, 3, "Vapor X5 Next Gen", "VaporX5™ Next Gen je najkompletniji pre-workout dostupan na tržištu. Ovaj proizvod će vam pružiti nevjerovatnu energiju, ekstremni mišićni pump, nadrealno čulno iskustvo, poboljšati performanse i obezbijediti sastojke neophodne za izgradnju mišića. Ova intenzivna formula sadrži sve što želite u jednom pre-workoutu i ništa što ne želite, s klinički doziranim sastojcima i bez jeftinih filera." },
                    { 15, 85f, 7, 410f, 3, "C4 Ultimate", "Cellucor C4 Ultimate je dugi niz godina usavršavao pre-workoute, mnogo prije nego neki drugi brendovi u industriji sportskih suplemenata. Gotovo desetljeće brend C4® bio je prvi u kategoriji pre-workouta sa učinkom i eksplozivnom energijom, najboljim okusima, klinički proučenim sastojcima i vrhunskim formulama." },
                    { 16, 65f, 7, 180f, 3, "C4 Ripped", "C4 Ripped sadrži sličnu energetsku mješavinu kao i klasični C4, s ključnim sastojcima za energiju koji će vam pomoći da prođete kroz najteže vježbe." },
                    { 17, 69f, 6, 390f, 3, "N.O.-Xplode", "N.O.-XPLODE pomaže u održavanju mentalne budnosti i mišićne snage, donosi energiju i izdržljivost te pomaže sportistima poboljšati kapacitet na svim razinama." },
                    { 18, 69f, 2, 363f, 3, "Shatter", "MuscleTech Shatter™ je iznimno snažan i naučno osmišljen pre-workout suplement koji će Vam doslovno razderati majicu i poboljšati vaše performanse snage i izdržljivosti. Ova vrhunska formula pruža i snažnu energiju i kompleks koji će Vas potaknuti kroz svaki trening." },
                    { 19, 79f, 1, 1200f, 4, "Mega Mass", "Muscle Freak Mega Mass je visokokvalitetni gainer, koji smo kreirali kako bi zadovoljili potrebe i najzahtjevnijih vježbača. Nakon godina uspješnog rada i distribucije najvećih brendova na tržištu, mi u Muscle Freaku smo odlučili da je vrijeme da i naša linija proizvoda ugleda svjetlo dana i da vam u skladu s našom tradicijom ponudimo najbolje i najkvalitetnije proizvode s predznakom bosanski brend." },
                    { 20, 119f, 2, 3200f, 4, "Mass Tech ELITE", "Mass-Tech Elite je napredni mass gainer za one koji imaju problemasa povećanjem veličine ili žele da probiju svoje platoe snage..." },
                    { 21, 89f, 2, 2300f, 4, "100% Mass Gainer", "Iz najbolje američke kompanije za prodaju suplemenata, MuscleTech predstavlja Vam 100% Mass Gainer - visokoproteinski suplement za povećanje mišične mase. Ovaj dodatak, obogaćen prirodnim i umjetnim aromama, pruža Vam sve što je potrebno da unaprijedite mišiće, snagu i performanse, uz brži oporavak mišića." },
                    { 22, 99f, 3, 2700f, 4, "Serious Mass", "Vrh u formulama za povećanje tjelesne mase. Serious Mass vas opskrbljuje sa alatom neophodnim da napakujete kilograme i razvijete tijelo kakvo ste uvijek željeli." },
                    { 23, 119f, 8, 1000f, 4, "IsoGainz", "Evolite IsoGainz je ugljikohidratno-proteinski suplement visoke kvalitete namijenjen prvenstveno aktivnim osobama koji se sastoji od: odabrani ugljikohidrati (maltodextrin sa jako malim sadržajem šećera) proteina (izolat I koncentrat koji ne sadrže laktozu) .Proizvod se može koristiti kao dodatak svakodnevnoj prehrani. Idealno prikladan za korištenje nakon treninga kako bi se nadoknadile zalihe energije u mišićima. Protein doprinosi rastu mišične mase I pomaže u njenom održavanju." },
                    { 24, 159f, 9, 8000f, 4, "Hyper Mass", "Hyper Mass Professional je izuzetno moćan suplement s bogatim vitaminskim kompleksom, namijenjen da vam pomogne postići vaše ciljeve u izgradnji mišića! Ovaj preparat Hyper Mass, sa svojom vrhunskom kombinacijom sastojaka, idealan je izbor za sve koji žele dodati mišićnu masu, povećati snagu i izdržljivost tokom treninga." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Suplement",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Suplement",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Suplement",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Suplement",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Suplement",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Suplement",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Suplement",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Suplement",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Suplement",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Suplement",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Suplement",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Suplement",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Suplement",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Suplement",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Suplement",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Suplement",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Suplement",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Suplement",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Suplement",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Suplement",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Suplement",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Suplement",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Suplement",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Suplement",
                keyColumn: "ID",
                keyValue: 24);
        }
    }
}

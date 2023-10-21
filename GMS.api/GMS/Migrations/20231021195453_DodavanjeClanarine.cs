using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GMS.Migrations
{
    public partial class DodavanjeClanarine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clanarina",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cijena = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clanarina", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Korisnik_Clanarina",
                columns: table => new
                {
                    KorisnikID = table.Column<int>(type: "int", nullable: false),
                    ClanarinaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik_Clanarina", x => new { x.ClanarinaID, x.KorisnikID });
                    table.ForeignKey(
                        name: "FK_Korisnik_Clanarina_Clanarina_ClanarinaID",
                        column: x => x.ClanarinaID,
                        principalTable: "Clanarina",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Korisnik_Clanarina_Korisnik_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnik",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_Clanarina_KorisnikID",
                table: "Korisnik_Clanarina",
                column: "KorisnikID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Korisnik_Clanarina");

            migrationBuilder.DropTable(
                name: "Clanarina");
        }
    }
}

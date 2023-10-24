using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GMS.Migrations
{
    public partial class RecenzijaDodavanje : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recenzija",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zanimanje = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tekst = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recenzija", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Clanarina",
                keyColumn: "ID",
                keyValue: 1,
                column: "Naziv",
                value: "Basic");

            migrationBuilder.UpdateData(
                table: "Clanarina",
                keyColumn: "ID",
                keyValue: 2,
                column: "Naziv",
                value: "Studentska");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recenzija");

            migrationBuilder.UpdateData(
                table: "Clanarina",
                keyColumn: "ID",
                keyValue: 1,
                column: "Naziv",
                value: "Obična");

            migrationBuilder.UpdateData(
                table: "Clanarina",
                keyColumn: "ID",
                keyValue: 2,
                column: "Naziv",
                value: "Studenti");
        }
    }
}

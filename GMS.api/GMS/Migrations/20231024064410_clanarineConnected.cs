using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GMS.Migrations
{
    public partial class clanarineConnected : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Korisnik_Clanarina",
                columns: new[] { "ClanarinaID", "DatumUplate", "KorisnikID", "DatumIsteka" },
                values: new object[,]
                {
                    { 2, new DateTime(2023, 9, 1, 9, 15, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 10, 1, 9, 15, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2023, 10, 1, 7, 15, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 11, 1, 7, 15, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2023, 9, 1, 9, 15, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2023, 10, 1, 9, 15, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2023, 10, 1, 7, 15, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2023, 11, 1, 7, 15, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Korisnik_Clanarina",
                keyColumns: new[] { "ClanarinaID", "DatumUplate", "KorisnikID" },
                keyValues: new object[] { 2, new DateTime(2023, 9, 1, 9, 15, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.DeleteData(
                table: "Korisnik_Clanarina",
                keyColumns: new[] { "ClanarinaID", "DatumUplate", "KorisnikID" },
                keyValues: new object[] { 2, new DateTime(2023, 10, 1, 7, 15, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.DeleteData(
                table: "Korisnik_Clanarina",
                keyColumns: new[] { "ClanarinaID", "DatumUplate", "KorisnikID" },
                keyValues: new object[] { 2, new DateTime(2023, 9, 1, 9, 15, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.DeleteData(
                table: "Korisnik_Clanarina",
                keyColumns: new[] { "ClanarinaID", "DatumUplate", "KorisnikID" },
                keyValues: new object[] { 2, new DateTime(2023, 10, 1, 7, 15, 0, 0, DateTimeKind.Unspecified), 2 });
        }
    }
}

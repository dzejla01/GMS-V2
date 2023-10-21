using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GMS.Migrations
{
    public partial class dodavanjeslike : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Slika",
                table: "Korisnik",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slika",
                table: "Korisnik");
        }
    }
}

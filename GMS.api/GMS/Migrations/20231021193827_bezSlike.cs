using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GMS.Migrations
{
    public partial class bezSlike : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slika",
                table: "Korisnik");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Slika",
                table: "Korisnik",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}

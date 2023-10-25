using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GMS.Migrations
{
    public partial class spajanjeKateogrije : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Gramaza",
                table: "Suplement",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "KategorijaID",
                table: "Suplement",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Opis",
                table: "Suplement",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Suplement_KategorijaID",
                table: "Suplement",
                column: "KategorijaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Suplement_Kategorija_KategorijaID",
                table: "Suplement",
                column: "KategorijaID",
                principalTable: "Kategorija",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Suplement_Kategorija_KategorijaID",
                table: "Suplement");

            migrationBuilder.DropIndex(
                name: "IX_Suplement_KategorijaID",
                table: "Suplement");

            migrationBuilder.DropColumn(
                name: "Gramaza",
                table: "Suplement");

            migrationBuilder.DropColumn(
                name: "KategorijaID",
                table: "Suplement");

            migrationBuilder.DropColumn(
                name: "Opis",
                table: "Suplement");
        }
    }
}

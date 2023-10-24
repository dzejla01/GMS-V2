using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GMS.Migrations
{
    public partial class dodavanjeDobavljaca : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DobavljacID",
                table: "Suplement",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Dobavljac",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dobavljac", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Suplement_DobavljacID",
                table: "Suplement",
                column: "DobavljacID");

            migrationBuilder.AddForeignKey(
                name: "FK_Suplement_Dobavljac_DobavljacID",
                table: "Suplement",
                column: "DobavljacID",
                principalTable: "Dobavljac",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Suplement_Dobavljac_DobavljacID",
                table: "Suplement");

            migrationBuilder.DropTable(
                name: "Dobavljac");

            migrationBuilder.DropIndex(
                name: "IX_Suplement_DobavljacID",
                table: "Suplement");

            migrationBuilder.DropColumn(
                name: "DobavljacID",
                table: "Suplement");
        }
    }
}

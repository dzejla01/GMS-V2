using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GMS.Migrations
{
    public partial class dodajDobavljace : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dobavljac",
                columns: new[] { "ID", "Naziv" },
                values: new object[,]
                {
                    { 1, "MUSCLE FREAK" },
                    { 2, "MUSCLETECH" },
                    { 3, "OPTIMUM NUTRITION" },
                    { 4, "SELF OMNINUTRITION" },
                    { 5, "CW-CHEMICAL WARFARE" },
                    { 6, "BSN" },
                    { 7, "CELLUCOR" },
                    { 8, "EVOLITE" },
                    { 9, "SUPERIOR" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dobavljac",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dobavljac",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dobavljac",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dobavljac",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dobavljac",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dobavljac",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Dobavljac",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Dobavljac",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Dobavljac",
                keyColumn: "ID",
                keyValue: 9);
        }
    }
}

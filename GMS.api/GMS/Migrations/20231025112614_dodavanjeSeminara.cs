using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GMS.Migrations
{
    public partial class dodavanjeSeminara : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Nutricionist_Seminar",
                columns: new[] { "NutricionistID", "SeminarID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "Trener_Seminar",
                columns: new[] { "SeminarID", "TrenerID" },
                values: new object[,]
                {
                    { 5, 1 },
                    { 6, 1 },
                    { 4, 2 },
                    { 6, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Nutricionist_Seminar",
                keyColumns: new[] { "NutricionistID", "SeminarID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Nutricionist_Seminar",
                keyColumns: new[] { "NutricionistID", "SeminarID" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Nutricionist_Seminar",
                keyColumns: new[] { "NutricionistID", "SeminarID" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Nutricionist_Seminar",
                keyColumns: new[] { "NutricionistID", "SeminarID" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Trener_Seminar",
                keyColumns: new[] { "SeminarID", "TrenerID" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "Trener_Seminar",
                keyColumns: new[] { "SeminarID", "TrenerID" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "Trener_Seminar",
                keyColumns: new[] { "SeminarID", "TrenerID" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "Trener_Seminar",
                keyColumns: new[] { "SeminarID", "TrenerID" },
                keyValues: new object[] { 6, 2 });
        }
    }
}

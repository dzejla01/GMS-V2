using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GMS.Migrations
{
    public partial class treneriSeminari : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Nutricionist",
                columns: new[] { "ID", "BrojTelefona", "Ime", "Prezime" },
                values: new object[,]
                {
                    { 1, "062709689", "Marijana", "Zubac" },
                    { 2, "062709689", "Amela", "Ivković" }
                });

            migrationBuilder.InsertData(
                table: "Seminar",
                columns: new[] { "ID", "Datum", "Predavac", "Tema" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 12, 10, 9, 15, 0, 0, DateTimeKind.Unspecified), "Maja Gradinjan", "Metabolički Sindrom" },
                    { 2, new DateTime(2023, 4, 12, 9, 15, 0, 0, DateTimeKind.Unspecified), "Darija Topić", "Pravilna prehrana u službi zdravlja i sportskog razvoja" },
                    { 3, new DateTime(2020, 1, 10, 9, 15, 0, 0, DateTimeKind.Unspecified), "Tatjana Popović", "Snaga u vama" },
                    { 4, new DateTime(2019, 12, 10, 9, 15, 0, 0, DateTimeKind.Unspecified), "Ivan Račić", "CrossFit Level 3" },
                    { 5, new DateTime(2017, 6, 10, 9, 15, 0, 0, DateTimeKind.Unspecified), "Petar Klančir", "Pro Bodybuilding" },
                    { 6, new DateTime(2022, 1, 1, 12, 15, 0, 0, DateTimeKind.Unspecified), "Almir Tunić", "Samoodbrana" }
                });

            migrationBuilder.InsertData(
                table: "Trener",
                columns: new[] { "ID", "BrojTelefona", "Ime", "Prezime" },
                values: new object[,]
                {
                    { 1, "0644076290", "Kadir", "Keskin" },
                    { 2, "0644076290", "Azur", "Kahriman" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Nutricionist",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Nutricionist",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seminar",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Seminar",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seminar",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Seminar",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Seminar",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Seminar",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Trener",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trener",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eProdaja.Migrations
{
    public partial class novipodacipregled : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Narudzbe",
                columns: new[] { "NarudzbaID", "BrojNarudzbe", "Datum", "KupacID", "Otkazano", "Status" },
                values: new object[,]
                {
                    { 1, "AAA", new DateTime(2022, 2, 14, 22, 35, 42, 477, DateTimeKind.Local).AddTicks(2421), 1, false, true },
                    { 2, "BBB", new DateTime(2022, 2, 14, 22, 35, 42, 486, DateTimeKind.Local).AddTicks(8781), 1, false, true },
                    { 3, "CCC", new DateTime(2022, 2, 14, 22, 35, 42, 486, DateTimeKind.Local).AddTicks(9127), 2, false, true },
                    { 4, "DDD", new DateTime(2022, 2, 14, 22, 35, 42, 486, DateTimeKind.Local).AddTicks(9226), 2, false, true }
                });

            migrationBuilder.InsertData(
                table: "PregledNarudzbi",
                columns: new[] { "PregledNarudzbiId", "BrojNarudzbe", "DatumDo", "DatumOd", "IznosNarudzbe", "KupciId", "MinIznosNarudzbe", "ProizvodiId" },
                values: new object[,]
                {
                    { 1, "AAA", new DateTime(2022, 2, 14, 22, 35, 42, 488, DateTimeKind.Local).AddTicks(9794), new DateTime(2022, 2, 4, 22, 35, 42, 488, DateTimeKind.Local).AddTicks(9098), 1000m, 1, 10m, 1 },
                    { 2, "BBB", new DateTime(2022, 2, 14, 22, 35, 42, 489, DateTimeKind.Local).AddTicks(2560), new DateTime(2022, 2, 4, 22, 35, 42, 489, DateTimeKind.Local).AddTicks(2463), 1000m, 2, 10m, 2 }
                });

            migrationBuilder.InsertData(
                table: "Izlazi",
                columns: new[] { "IzlazID", "BrojRacuna", "Datum", "IznosBezPDV", "IznosSaPDV", "KorisnikID", "NarudzbaID", "SkladisteID", "Zakljucen" },
                values: new object[,]
                {
                    { 1, "AAA", new DateTime(2022, 2, 14, 22, 35, 42, 487, DateTimeKind.Local).AddTicks(7089), 950m, 1000m, 1, 1, 1, false },
                    { 2, "BBB", new DateTime(2022, 2, 14, 22, 35, 42, 488, DateTimeKind.Local).AddTicks(3660), 950m, 1000m, 1, 2, 2, false },
                    { 3, "CCC", new DateTime(2022, 2, 14, 22, 35, 42, 488, DateTimeKind.Local).AddTicks(4140), 950m, 1000m, 1, 3, 1, false },
                    { 4, "DDD", new DateTime(2022, 2, 14, 22, 35, 42, 488, DateTimeKind.Local).AddTicks(4330), 950m, 1000m, 1, 4, 1, false }
                });

            migrationBuilder.InsertData(
                table: "NarudzbaStavke",
                columns: new[] { "NarudzbaStavkaID", "Kolicina", "NarudzbaID", "ProizvodID" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 5, 2, 1, 2 },
                    { 2, 2, 2, 2 },
                    { 3, 3, 3, 3 },
                    { 4, 4, 4, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Izlazi",
                keyColumn: "IzlazID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Izlazi",
                keyColumn: "IzlazID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Izlazi",
                keyColumn: "IzlazID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Izlazi",
                keyColumn: "IzlazID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "NarudzbaStavke",
                keyColumn: "NarudzbaStavkaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NarudzbaStavke",
                keyColumn: "NarudzbaStavkaID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NarudzbaStavke",
                keyColumn: "NarudzbaStavkaID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NarudzbaStavke",
                keyColumn: "NarudzbaStavkaID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "NarudzbaStavke",
                keyColumn: "NarudzbaStavkaID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PregledNarudzbi",
                keyColumn: "PregledNarudzbiId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PregledNarudzbi",
                keyColumn: "PregledNarudzbiId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 4);
        }
    }
}

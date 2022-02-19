using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eProdaja.Migrations
{
    public partial class preglednarudzbiadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PregledNarudzbi",
                columns: table => new
                {
                    PregledNarudzbiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KupciId = table.Column<int>(type: "int", nullable: false),
                    ProizvodiId = table.Column<int>(type: "int", nullable: false),
                    MinIznosNarudzbe = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DatumOd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumDo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BrojNarudzbe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IznosNarudzbe = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PregledNarudzbi", x => x.PregledNarudzbiId);
                    table.ForeignKey(
                        name: "FK_PregledNarudzbi_Kupci_KupciId",
                        column: x => x.KupciId,
                        principalTable: "Kupci",
                        principalColumn: "KupacID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PregledNarudzbi_Proizvodi_ProizvodiId",
                        column: x => x.ProizvodiId,
                        principalTable: "Proizvodi",
                        principalColumn: "ProizvodID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PregledNarudzbi_KupciId",
                table: "PregledNarudzbi",
                column: "KupciId");

            migrationBuilder.CreateIndex(
                name: "IX_PregledNarudzbi_ProizvodiId",
                table: "PregledNarudzbi",
                column: "ProizvodiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PregledNarudzbi");
        }
    }
}

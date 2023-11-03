using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KbrTec.JiuJitsuSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class RelationshipAtletaCampeonatov1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InscricaoCampeonato",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AtletaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CampeonatoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InscricaoCampeonato", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InscricaoCampeonato_Atleta_AtletaId",
                        column: x => x.AtletaId,
                        principalTable: "Atleta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InscricaoCampeonato_Campeonato_CampeonatoId",
                        column: x => x.CampeonatoId,
                        principalTable: "Campeonato",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InscricaoCampeonato_AtletaId",
                table: "InscricaoCampeonato",
                column: "AtletaId");

            migrationBuilder.CreateIndex(
                name: "IX_InscricaoCampeonato_CampeonatoId",
                table: "InscricaoCampeonato",
                column: "CampeonatoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InscricaoCampeonato");
        }
    }
}

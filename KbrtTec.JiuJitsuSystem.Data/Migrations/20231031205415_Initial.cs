using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KbrTec.JiuJitsuSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Atleta",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "date", nullable: false),
                    Cpf = table.Column<string>(type: "varchar(11)", nullable: false),
                    Sexo = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", nullable: false),
                    Senha = table.Column<string>(type: "varchar(50)", nullable: false),
                    Equipe = table.Column<string>(type: "varchar(50)", nullable: false),
                    TipoFaixa = table.Column<int>(type: "int", nullable: false),
                    TipoPeso = table.Column<int>(type: "int", nullable: false),
                    DataIncricao = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atleta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Campeonato",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "varchar(100)", nullable: false),
                    Imagem = table.Column<string>(type: "varchar(50)", nullable: false),
                    Cidade = table.Column<string>(type: "varchar(50)", nullable: false),
                    Estado = table.Column<string>(type: "varchar(50)", nullable: false),
                    DataRealizacao = table.Column<DateTime>(type: "date", nullable: false),
                    Ginasio = table.Column<string>(type: "varchar(50)", nullable: false),
                    InformacoesGerais = table.Column<string>(type: "varchar(100)", nullable: false),
                    EntradaPublico = table.Column<bool>(type: "bit", nullable: true),
                    TipoCamepeonato = table.Column<int>(type: "int", nullable: false),
                    FaseCampeonato = table.Column<int>(type: "int", nullable: false),
                    StatusCampeonato = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campeonato", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", nullable: false),
                    Senha = table.Column<string>(type: "varchar(100)", nullable: false),
                    TipoUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Atleta");

            migrationBuilder.DropTable(
                name: "Campeonato");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}

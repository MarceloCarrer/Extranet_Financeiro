using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Extranet_Financeiro.API.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnoSemestres",
                columns: table => new
                {
                    AnoSemestreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnoSemestres", x => x.AnoSemestreId);
                });

            migrationBuilder.CreateTable(
                name: "Relatorios",
                columns: table => new
                {
                    RelatorioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mes = table.Column<int>(type: "int", nullable: false),
                    Ano = table.Column<int>(type: "int", nullable: false),
                    ValorPago = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PorcSenacrs = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PorcPolo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Devolucao = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PorcDevSenacrs = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PorcDevPolo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DataRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relatorios", x => x.RelatorioId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnoSemestres");

            migrationBuilder.DropTable(
                name: "Relatorios");
        }
    }
}

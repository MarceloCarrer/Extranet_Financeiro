using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Extranet_Financeiro.Persistence.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnoSemestres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnoSemestres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Relatorios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mes = table.Column<int>(type: "int", nullable: false),
                    Ano = table.Column<int>(type: "int", nullable: false),
                    ValorPago = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    PorcSenacrs = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    PorcPolo = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Devolucao = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    PorcDevSenacrs = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    PorcDevPolo = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    DataRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relatorios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PoloRelatorios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PoloId = table.Column<int>(type: "int", nullable: false),
                    Mes = table.Column<int>(type: "int", nullable: false),
                    Ano = table.Column<int>(type: "int", nullable: false),
                    DR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValorPago = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    PorcSenacrs = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    PorcPolo = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Devolucao = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    PorcDevSenacrs = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    PorcDevPolo = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    RelatorioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PoloRelatorios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PoloRelatorios_Relatorios_RelatorioId",
                        column: x => x.RelatorioId,
                        principalTable: "Relatorios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PoloTurmas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TurmaId = table.Column<int>(type: "int", nullable: false),
                    Turma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mes = table.Column<int>(type: "int", nullable: false),
                    Ano = table.Column<int>(type: "int", nullable: false),
                    ValorPago = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    PorcSenacrs = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    PorcPolo = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Devolucao = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    PorcDevSenacrs = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    PorcDevPolo = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    PercenSenacrs = table.Column<double>(type: "float", nullable: false),
                    PercenPolo = table.Column<double>(type: "float", nullable: false),
                    PoloRelatorioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PoloTurmas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PoloTurmas_PoloRelatorios_PoloRelatorioId",
                        column: x => x.PoloRelatorioId,
                        principalTable: "PoloRelatorios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PoloRelatorios_RelatorioId",
                table: "PoloRelatorios",
                column: "RelatorioId");

            migrationBuilder.CreateIndex(
                name: "IX_PoloTurmas_PoloRelatorioId",
                table: "PoloTurmas",
                column: "PoloRelatorioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnoSemestres");

            migrationBuilder.DropTable(
                name: "PoloTurmas");

            migrationBuilder.DropTable(
                name: "PoloRelatorios");

            migrationBuilder.DropTable(
                name: "Relatorios");
        }
    }
}

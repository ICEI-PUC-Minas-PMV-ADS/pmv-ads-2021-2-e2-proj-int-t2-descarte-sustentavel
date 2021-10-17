using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DescarteSustentavel.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SolicitacaoDescarteColeta",
                columns: table => new
                {
                    IDSolicitacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDDescartador = table.Column<int>(type: "int", nullable: false),
                    IDEcoponto = table.Column<int>(type: "int", nullable: false),
                    TipoDoMaterial = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    DataDaSolicitacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QtdeDeItens = table.Column<int>(type: "int", nullable: false),
                    DataDeEncerramento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitacaoDescarteColeta", x => x.IDSolicitacao);
                });

            migrationBuilder.CreateTable(
                name: "ItemDescarte",
                columns: table => new
                {
                    IDItem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoDoItem = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    descricaoDoItem = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    SolicitacaoDescarteColetaIDSolicitacao = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemDescarte", x => x.IDItem);
                    table.ForeignKey(
                        name: "FK_ItemDescarte_SolicitacaoDescarteColeta_SolicitacaoDescarteColetaIDSolicitacao",
                        column: x => x.SolicitacaoDescarteColetaIDSolicitacao,
                        principalTable: "SolicitacaoDescarteColeta",
                        principalColumn: "IDSolicitacao",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemDescarte_SolicitacaoDescarteColetaIDSolicitacao",
                table: "ItemDescarte",
                column: "SolicitacaoDescarteColetaIDSolicitacao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemDescarte");

            migrationBuilder.DropTable(
                name: "SolicitacaoDescarteColeta");
        }
    }
}

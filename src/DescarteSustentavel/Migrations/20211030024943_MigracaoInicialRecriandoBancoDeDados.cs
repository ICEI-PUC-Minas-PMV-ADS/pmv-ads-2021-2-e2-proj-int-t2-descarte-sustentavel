using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DescarteSustentavel.Migrations
{
    public partial class MigracaoInicialRecriandoBancoDeDados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SolicitacaoDescarteColeta",
                columns: table => new
                {
                    id_solicitacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descartador = table.Column<int>(type: "int", nullable: false),
                    ecoponto = table.Column<int>(type: "int", nullable: false),
                    tipo_material = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    data_solicitacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    qtd_itens = table.Column<int>(type: "int", nullable: false),
                    data_encerramento = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitacaoDescarteColeta", x => x.id_solicitacao);
                });

            migrationBuilder.CreateTable(
                name: "ItemDescarte",
                columns: table => new
                {
                    id_item = table.Column<int>(type: "int", nullable: false),
                    tipo_item = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    descricao_item = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    id_solicitacao_descarte_coleta = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemDescarte", x => x.id_item);
                    table.ForeignKey(
                        name: "FK_ItemDescarte_SolicitacaoDescarteColeta_id_solicitacao_descarte_coleta",
                        column: x => x.id_solicitacao_descarte_coleta,
                        principalTable: "SolicitacaoDescarteColeta",
                        principalColumn: "id_solicitacao",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemDescarte_id_solicitacao_descarte_coleta",
                table: "ItemDescarte",
                column: "id_solicitacao_descarte_coleta");
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

using Microsoft.EntityFrameworkCore.Migrations;

namespace DescarteSustentavel.Migrations
{
    public partial class corrigirCampoTipoDeSolicitacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "tipo_solicitacao",
                table: "SolicitacaoDescarteColeta",
                type: "nvarchar(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "tipo_solicitacao",
                table: "SolicitacaoDescarteColeta",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)");
        }
    }
}

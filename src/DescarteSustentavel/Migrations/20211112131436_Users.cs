using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace DescarteSustentavel.Migrations
{
    // https://docs.microsoft.com/en-us/ef/core/modeling/inheritance#table-per-type-configuration
    public partial class Users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    idUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    endereco = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    telefone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    senha = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.idUsuario);

                });
            migrationBuilder.CreateIndex(
                name: "INDEX_Email",
                table: "Usuario",
                column: "email",
                unique: false); //vamos checar se ja existe um email durante a parte de cadastro

            migrationBuilder.CreateTable(
                name: "Ecoponto",
                columns: table => new
                {
                    idEcoponto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idUsuario = table.Column<int>(type: "int", nullable: false),
                    cpfCnpj = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    tipo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),

                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ecoponto", x => x.idEcoponto);
                    table.ForeignKey(
                        name: "FK_Ecoponto_IdUsuario",
                        column: x => x.idUsuario,
                        principalTable: "Usuario",
                        principalColumn: "idUsuario",
                        onDelete: ReferentialAction.Restrict);
                });
            migrationBuilder.CreateTable(
                name: "Descartador",
                columns: table => new
                {
                    idDescartador = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idUsuario = table.Column<int>(type: "int", nullable: false),
                    dataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    qntSolicitacoes = table.Column<string>(type: "int"),

                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Descartador", x => x.idDescartador);
                    table.ForeignKey(
                       name: "FK_Descartador_IdUsuario",
                       column: x => x.idUsuario,
                       principalTable: "Usuario",
                       principalColumn: "idUsuario",
                       onDelete: ReferentialAction.Restrict);
                });
        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Descartador");
            migrationBuilder.DropTable(name: "Ecoponto");
            migrationBuilder.DropTable(name: "Usuario");
        }
    }
}

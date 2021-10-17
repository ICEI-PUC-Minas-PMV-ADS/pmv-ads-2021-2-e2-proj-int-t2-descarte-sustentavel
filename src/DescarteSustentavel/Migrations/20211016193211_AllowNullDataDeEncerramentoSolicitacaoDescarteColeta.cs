﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DescarteSustentavel.Migrations
{
    public partial class AllowNullDataDeEncerramentoSolicitacaoDescarteColeta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeEncerramento",
                table: "SolicitacaoDescarteColeta",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeEncerramento",
                table: "SolicitacaoDescarteColeta",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}

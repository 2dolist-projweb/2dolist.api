﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class AddColunaPrioridadeLista : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Prioridade",
                table: "Listas",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Prioridade",
                table: "Listas");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace contactos.Migrations
{
    public partial class AddEmailUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Usuario",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaCreado",
                table: "Usuario",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "email",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "fechaCreado",
                table: "Usuario");
        }
    }
}

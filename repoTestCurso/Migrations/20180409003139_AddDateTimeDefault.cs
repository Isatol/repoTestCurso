using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace repoTestCurso.Migrations
{
    public partial class AddDateTimeDefault : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Todos",
                nullable: true,
                defaultValue: new DateTime(2018, 4, 8, 19, 31, 39, 233, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ToDoDay",
                table: "Todos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ToDoDay",
                table: "Todos");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Todos",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2018, 4, 8, 19, 31, 39, 233, DateTimeKind.Local));
        }
    }
}

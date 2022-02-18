using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Back.Migrations
{
    public partial class update3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "fecha",
                table: "Receipt",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "fecha",
                table: "Receipt",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime));
        }
    }
}

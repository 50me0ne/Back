using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Back.Migrations
{
    public partial class migracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Receipt",
                columns: table => new
                {
                    receiptId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    proveedor = table.Column<string>(nullable: false),
                    monto = table.Column<double>(nullable: false),
                    moneda = table.Column<string>(nullable: true),
                    fecha = table.Column<DateTime>(nullable: false),
                    comentario = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipt", x => x.receiptId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    userId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userName = table.Column<string>(nullable: false),
                    userNameDisplay = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.userId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Receipt");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace baiquanlyweb.Migrations
{
    public partial class initialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "quanlies",
                columns: table => new
                {
                    masp = table.Column<int>(type: "int", maxLength: 6, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tensp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hansudung = table.Column<DateTime>(type: "datetime2", nullable: false),
                    nhasx = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    giaban = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_quanlies", x => x.masp);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "quanlies");
        }
    }
}

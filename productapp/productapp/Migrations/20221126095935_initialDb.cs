using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace productapp.Migrations
{
    public partial class initialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    MASANPHAM = table.Column<long>(type: "bigint", maxLength: 7, nullable: false),
                    TENSANPHAM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HANSUDUNG = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NHASANXUAT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GIABAN = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.MASANPHAM);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");
        }
    }
}

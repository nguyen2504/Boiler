using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Xn.Migrations
{
    public partial class QlNccs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QlNccs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DonGiaMua = table.Column<double>(nullable: false),
                    Dvt = table.Column<string>(nullable: true),
                    IdCty = table.Column<int>(nullable: false),
                    IdNcc = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    MaDonHang = table.Column<string>(nullable: true),
                    MaVt = table.Column<string>(nullable: true),
                    NgayGhi = table.Column<DateTime>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false),
                    TenHang = table.Column<string>(nullable: true),
                    TenNcc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QlNccs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QlNccs");
        }
    }
}

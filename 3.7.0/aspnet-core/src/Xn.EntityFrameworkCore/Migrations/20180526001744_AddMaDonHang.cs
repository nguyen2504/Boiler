using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Xn.Migrations
{
    public partial class AddMaDonHang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "QlXuatNhaps");

            migrationBuilder.DropColumn(
                name: "KeyUser",
                table: "QlXuatNhaps");

            migrationBuilder.DropColumn(
                name: "TenNv",
                table: "QlXuatNhaps");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "QlXuatNhaps",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "KeyUser",
                table: "QlXuatNhaps",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TenNv",
                table: "QlXuatNhaps",
                nullable: true);
        }
    }
}

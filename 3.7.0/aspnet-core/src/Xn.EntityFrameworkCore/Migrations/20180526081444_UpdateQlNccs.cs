using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Xn.Migrations
{
    public partial class UpdateQlNccs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdNv",
                table: "QlNccs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TenNv",
                table: "QlNccs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdNv",
                table: "QlNccs");

            migrationBuilder.DropColumn(
                name: "TenNv",
                table: "QlNccs");
        }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FSM.DataAccess.Migrations
{
    public partial class UpdateBaseObject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StatisticalCategories_User_UserId",
                table: "StatisticalCategories");

            migrationBuilder.DropIndex(
                name: "IX_StatisticalCategories_UserId",
                table: "StatisticalCategories");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "StatisticalCategories");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdated",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "User");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "StatisticalCategories",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_StatisticalCategories_UserId",
                table: "StatisticalCategories",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_StatisticalCategories_User_UserId",
                table: "StatisticalCategories",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

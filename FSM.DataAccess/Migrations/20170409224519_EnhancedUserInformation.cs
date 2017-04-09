using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FSM.DataAccess.Migrations
{
    public partial class EnhancedUserInformation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "User",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_User_UserName",
                table: "User",
                column: "UserName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_User_UserName",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "User");
        }
    }
}

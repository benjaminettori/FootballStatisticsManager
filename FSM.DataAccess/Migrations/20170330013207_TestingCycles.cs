using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FSM.DataAccess.Migrations
{
    public partial class TestingCycles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Country_User_UserId",
                table: "Country");

            migrationBuilder.DropForeignKey(
                name: "FK_League_User_UserId",
                table: "League");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "User",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "LeagueId",
                table: "League",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "Country",
                newName: "Id");

            migrationBuilder.AddColumn<Guid>(
                name: "CountryId",
                table: "League",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "League",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdated",
                table: "League",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Country",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdated",
                table: "Country",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Club",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    LastUpdated = table.Column<DateTime>(nullable: false),
                    LeagueId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    NickName = table.Column<string>(nullable: true),
                    SixLetterName = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Club", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Club_League_LeagueId",
                        column: x => x.LeagueId,
                        principalTable: "League",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Club_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    Height = table.Column<int>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    LastUpdated = table.Column<DateTime>(nullable: false),
                    LeftFootRating = table.Column<int>(nullable: false),
                    RightFootRating = table.Column<int>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    Weight = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Player_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Season",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    LastUpdated = table.Column<DateTime>(nullable: false),
                    LeagueId = table.Column<Guid>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Season", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Season_League_LeagueId",
                        column: x => x.LeagueId,
                        principalTable: "League",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Season_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StatisticalCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CategoryCode = table.Column<string>(nullable: true),
                    CategoryName = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    Format = table.Column<int>(nullable: false),
                    LastUpdated = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatisticalCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StatisticalCategories_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlayerAttributes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Attribute = table.Column<int>(nullable: false),
                    AttributeCode = table.Column<string>(nullable: true),
                    AttributeName = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    Current = table.Column<bool>(nullable: false),
                    LastUpdated = table.Column<DateTime>(nullable: false),
                    OnDate = table.Column<DateTime>(nullable: false),
                    PlayerId = table.Column<Guid>(nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerAttributes_Player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerAttributes_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlayerContract",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    ClubId = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Currency = table.Column<int>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    LastUpdated = table.Column<DateTime>(nullable: false),
                    PlayerId = table.Column<Guid>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerContract", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerContract_Club_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Club",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerContract_Player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerContract_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    LastUpdated = table.Column<DateTime>(nullable: false),
                    OnDate = table.Column<DateTime>(nullable: false),
                    PlayerId = table.Column<Guid>(nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Positions_Player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Positions_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlayerStatistics",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CategoryId = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    LastUpdated = table.Column<DateTime>(nullable: false),
                    OnDate = table.Column<DateTime>(nullable: false),
                    PlayerId = table.Column<Guid>(nullable: false),
                    SeasonId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    Value = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerStatistics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerStatistics_StatisticalCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "StatisticalCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerStatistics_Player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerStatistics_Season_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Season",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerStatistics_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlayerContractClause",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ClauseType = table.Column<int>(nullable: false),
                    ClauseValue = table.Column<decimal>(nullable: false),
                    ContractId = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    LastUpdated = table.Column<DateTime>(nullable: false),
                    SecondClauseValue = table.Column<decimal>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerContractClause", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerContractClause_PlayerContract_ContractId",
                        column: x => x.ContractId,
                        principalTable: "PlayerContract",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerContractClause_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_League_CountryId",
                table: "League",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Club_LeagueId",
                table: "Club",
                column: "LeagueId");

            migrationBuilder.CreateIndex(
                name: "IX_Club_UserId",
                table: "Club",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Player_UserId",
                table: "Player",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerAttributes_PlayerId",
                table: "PlayerAttributes",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerAttributes_UserId",
                table: "PlayerAttributes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerContract_ClubId",
                table: "PlayerContract",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerContract_PlayerId",
                table: "PlayerContract",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerContract_UserId",
                table: "PlayerContract",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerContractClause_ContractId",
                table: "PlayerContractClause",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerContractClause_UserId",
                table: "PlayerContractClause",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_PlayerId",
                table: "Positions",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_UserId",
                table: "Positions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerStatistics_CategoryId",
                table: "PlayerStatistics",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerStatistics_PlayerId",
                table: "PlayerStatistics",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerStatistics_SeasonId",
                table: "PlayerStatistics",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerStatistics_UserId",
                table: "PlayerStatistics",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Season_LeagueId",
                table: "Season",
                column: "LeagueId");

            migrationBuilder.CreateIndex(
                name: "IX_Season_UserId",
                table: "Season",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_StatisticalCategories_UserId",
                table: "StatisticalCategories",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Country_User_UserId",
                table: "Country",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_League_Country_CountryId",
                table: "League",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_League_User_UserId",
                table: "League",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Country_User_UserId",
                table: "Country");

            migrationBuilder.DropForeignKey(
                name: "FK_League_Country_CountryId",
                table: "League");

            migrationBuilder.DropForeignKey(
                name: "FK_League_User_UserId",
                table: "League");

            migrationBuilder.DropTable(
                name: "PlayerAttributes");

            migrationBuilder.DropTable(
                name: "PlayerContractClause");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "PlayerStatistics");

            migrationBuilder.DropTable(
                name: "PlayerContract");

            migrationBuilder.DropTable(
                name: "StatisticalCategories");

            migrationBuilder.DropTable(
                name: "Season");

            migrationBuilder.DropTable(
                name: "Club");

            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropIndex(
                name: "IX_League_CountryId",
                table: "League");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "League");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "League");

            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "League");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "Country");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "User",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "League",
                newName: "LeagueId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Country",
                newName: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Country_User_UserId",
                table: "Country",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_League_User_UserId",
                table: "League",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

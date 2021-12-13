using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C9_CostManager.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Costs",
                columns: table => new
                {
                    CostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CostAmount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    OwnerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Costs", x => x.CostId);
                });

            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    TripId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TripName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TripStatusComplete = table.Column<bool>(type: "bit", nullable: false),
                    TripPasscode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.TripId);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    TripMemberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TripId = table.Column<int>(type: "int", nullable: false),
                    TripModelTripId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.TripMemberId);
                    table.ForeignKey(
                        name: "FK_Members_Trips_TripModelTripId",
                        column: x => x.TripModelTripId,
                        principalTable: "Trips",
                        principalColumn: "TripId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CostModelTripMemberModel",
                columns: table => new
                {
                    CostsCostId = table.Column<int>(type: "int", nullable: false),
                    TripMembersTripMemberId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostModelTripMemberModel", x => new { x.CostsCostId, x.TripMembersTripMemberId });
                    table.ForeignKey(
                        name: "FK_CostModelTripMemberModel_Costs_CostsCostId",
                        column: x => x.CostsCostId,
                        principalTable: "Costs",
                        principalColumn: "CostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CostModelTripMemberModel_Members_TripMembersTripMemberId",
                        column: x => x.TripMembersTripMemberId,
                        principalTable: "Members",
                        principalColumn: "TripMemberId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CostModelTripMemberModel_TripMembersTripMemberId",
                table: "CostModelTripMemberModel",
                column: "TripMembersTripMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Members_TripModelTripId",
                table: "Members",
                column: "TripModelTripId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CostModelTripMemberModel");

            migrationBuilder.DropTable(
                name: "Costs");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "Trips");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Catherine.Api.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Citizens",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    VatNumber = table.Column<string>(maxLength: 11, nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Birthdate = table.Column<DateTime>(nullable: true),
                    Paycheck = table.Column<decimal>(type: "decimal(10, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citizens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    President = table.Column<string>(maxLength: 100, nullable: true),
                    PrimeMinister = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    IsCapital = table.Column<bool>(nullable: false),
                    CountryId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Citizenships",
                columns: table => new
                {
                    CitizenId = table.Column<long>(nullable: false),
                    CountryId = table.Column<long>(nullable: false),
                    ValidFrom = table.Column<DateTime>(nullable: false),
                    ValidTo = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citizenships", x => new { x.CitizenId, x.CountryId });
                    table.ForeignKey(
                        name: "FK_Citizenships_Citizens_CitizenId",
                        column: x => x.CitizenId,
                        principalTable: "Citizens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Citizenships_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Citizens",
                columns: new[] { "Id", "Birthdate", "CreatedAt", "FirstName", "LastName", "Paycheck", "UpdatedAt", "VatNumber" },
                values: new object[,]
                {
                    { 1L, new DateTime(1879, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 8, 10, 16, 28, 13, 147, DateTimeKind.Utc).AddTicks(7251), "Albert", "Einstein", 15000.00m, null, "11111111111" },
                    { 2L, new DateTime(1858, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 8, 10, 16, 28, 13, 148, DateTimeKind.Utc).AddTicks(2532), "Max", "Planck", 14000.00m, null, "11111111112" },
                    { 3L, new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 8, 10, 16, 28, 13, 148, DateTimeKind.Utc).AddTicks(2574), "Pero", "Peric", 16000.00m, null, "11111111113" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CreatedAt", "Name", "President", "PrimeMinister", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2019, 8, 10, 16, 28, 13, 149, DateTimeKind.Utc).AddTicks(7649), "Croatia", null, null, null },
                    { 2L, new DateTime(2019, 8, 10, 16, 28, 13, 149, DateTimeKind.Utc).AddTicks(7969), "USA", null, null, null },
                    { 3L, new DateTime(2019, 8, 10, 16, 28, 13, 149, DateTimeKind.Utc).AddTicks(7974), "Germany", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "CreatedAt", "IsCapital", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2019, 8, 10, 16, 28, 13, 150, DateTimeKind.Utc).AddTicks(3728), false, "Zagreb", null },
                    { 2L, 1L, new DateTime(2019, 8, 10, 16, 28, 13, 150, DateTimeKind.Utc).AddTicks(4241), false, "Karlovac", null },
                    { 3L, 3L, new DateTime(2019, 8, 10, 16, 28, 13, 150, DateTimeKind.Utc).AddTicks(4249), false, "Berlin", null }
                });

            migrationBuilder.InsertData(
                table: "Citizenships",
                columns: new[] { "CitizenId", "CountryId", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 3L, 1L, new DateTime(2019, 8, 10, 16, 28, 13, 150, DateTimeKind.Utc).AddTicks(816), null },
                    { 1L, 3L, new DateTime(2019, 8, 10, 16, 28, 13, 150, DateTimeKind.Utc).AddTicks(301), null },
                    { 2L, 3L, new DateTime(2019, 8, 10, 16, 28, 13, 150, DateTimeKind.Utc).AddTicks(807), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Citizens_VatNumber",
                table: "Citizens",
                column: "VatNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Citizenships_CountryId",
                table: "Citizenships",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_Name",
                table: "Countries",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Citizenships");

            migrationBuilder.DropTable(
                name: "Citizens");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}

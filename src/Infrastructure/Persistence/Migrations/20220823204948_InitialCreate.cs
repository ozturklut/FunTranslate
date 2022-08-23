using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RequestUrls",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestUrls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TranslateRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestUrlId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranslateRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TranslateRequests_RequestUrls_RequestUrlId",
                        column: x => x.RequestUrlId,
                        principalTable: "RequestUrls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TranslateResponses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TranslatedText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TranslateRequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranslateResponses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TranslateResponses_TranslateRequests_TranslateRequestId",
                        column: x => x.TranslateRequestId,
                        principalTable: "TranslateRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TranslateRequests_RequestUrlId",
                table: "TranslateRequests",
                column: "RequestUrlId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TranslateResponses_TranslateRequestId",
                table: "TranslateResponses",
                column: "TranslateRequestId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TranslateResponses");

            migrationBuilder.DropTable(
                name: "TranslateRequests");

            migrationBuilder.DropTable(
                name: "RequestUrls");
        }
    }
}

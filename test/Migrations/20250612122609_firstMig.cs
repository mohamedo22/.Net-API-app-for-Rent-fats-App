using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test.Migrations
{
    /// <inheritdoc />
    public partial class firstMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "Flat",
                columns: table => new
                {
                    FlatCodeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlatPrice = table.Column<int>(type: "int", nullable: false),
                    FlatBathrooms = table.Column<int>(type: "int", nullable: false),
                    FlatBedrooms = table.Column<int>(type: "int", nullable: false),
                    FloorNumber = table.Column<int>(type: "int", nullable: false),
                    FlatGovernorate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlatCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlatDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlatAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flat", x => x.FlatCodeId);
                });

            migrationBuilder.CreateTable(
                name: "SocialHouses",
                columns: table => new
                {
                    SocialHouseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    terms = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialHouses", x => x.SocialHouseId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    National_Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "FlatImages",
                columns: table => new
                {
                    FlatImagesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlatCodeId = table.Column<int>(type: "int", nullable: false),
                    Flatimage = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlatImages", x => x.FlatImagesId);
                    table.ForeignKey(
                        name: "FK_FlatImages_Flat_FlatCodeId",
                        column: x => x.FlatCodeId,
                        principalTable: "Flat",
                        principalColumn: "FlatCodeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FlatImagesDocs",
                columns: table => new
                {
                    FlatImagesDocsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlatCodeId = table.Column<int>(type: "int", nullable: false),
                    Flatimage = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlatImagesDocs", x => x.FlatImagesDocsId);
                    table.ForeignKey(
                        name: "FK_FlatImagesDocs_Flat_FlatCodeId",
                        column: x => x.FlatCodeId,
                        principalTable: "Flat",
                        principalColumn: "FlatCodeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SocialHouseImages",
                columns: table => new
                {
                    SocialHouseImagesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SocialHouseId = table.Column<int>(type: "int", nullable: false),
                    image = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialHouseImages", x => x.SocialHouseImagesId);
                    table.ForeignKey(
                        name: "FK_SocialHouseImages_SocialHouses_SocialHouseId",
                        column: x => x.SocialHouseId,
                        principalTable: "SocialHouses",
                        principalColumn: "SocialHouseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContactUsRequests",
                columns: table => new
                {
                    ContactUsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlatCodeId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    dataTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUsRequests", x => x.ContactUsId);
                    table.ForeignKey(
                        name: "FK_ContactUsRequests_Flat_FlatCodeId",
                        column: x => x.FlatCodeId,
                        principalTable: "Flat",
                        principalColumn: "FlatCodeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContactUsRequests_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactUsRequests_FlatCodeId",
                table: "ContactUsRequests",
                column: "FlatCodeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContactUsRequests_UserId",
                table: "ContactUsRequests",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FlatImages_FlatCodeId",
                table: "FlatImages",
                column: "FlatCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_FlatImagesDocs_FlatCodeId",
                table: "FlatImagesDocs",
                column: "FlatCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialHouseImages_SocialHouseId",
                table: "SocialHouseImages",
                column: "SocialHouseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "ContactUsRequests");

            migrationBuilder.DropTable(
                name: "FlatImages");

            migrationBuilder.DropTable(
                name: "FlatImagesDocs");

            migrationBuilder.DropTable(
                name: "SocialHouseImages");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Flat");

            migrationBuilder.DropTable(
                name: "SocialHouses");
        }
    }
}

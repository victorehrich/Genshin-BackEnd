using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GenshinApplication.Migrations
{
    /// <inheritdoc />
    public partial class creatingtables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharactersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Element = table.Column<int>(type: "int", nullable: false),
                    NumberOfStars = table.Column<int>(type: "int", nullable: false),
                    WeaponType = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharactersId);
                });

            migrationBuilder.CreateTable(
                name: "Set",
                columns: table => new
                {
                    SetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SetBonusOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SetBonusTwo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Set", x => x.SetId);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    WeaponId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Effect = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stars = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.WeaponId);
                });

            migrationBuilder.CreateTable(
                name: "Constelation",
                columns: table => new
                {
                    ConstelationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContellationLevel = table.Column<int>(type: "int", nullable: false),
                    Effect = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CharactersId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Constelation", x => x.ConstelationId);
                    table.ForeignKey(
                        name: "FK_Constelation_Characters_CharactersId",
                        column: x => x.CharactersId,
                        principalTable: "Characters",
                        principalColumn: "CharactersId");
                });

            migrationBuilder.CreateTable(
                name: "Artifacts",
                columns: table => new
                {
                    ArtifactsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SetId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArtifactsType = table.Column<int>(type: "int", nullable: false),
                    Stars = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artifacts", x => x.ArtifactsId);
                    table.ForeignKey(
                        name: "FK_Artifacts_Set_SetId",
                        column: x => x.SetId,
                        principalTable: "Set",
                        principalColumn: "SetId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artifacts_SetId",
                table: "Artifacts",
                column: "SetId");

            migrationBuilder.CreateIndex(
                name: "IX_Constelation_CharactersId",
                table: "Constelation",
                column: "CharactersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artifacts");

            migrationBuilder.DropTable(
                name: "Constelation");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropTable(
                name: "Set");

            migrationBuilder.DropTable(
                name: "Characters");
        }
    }
}

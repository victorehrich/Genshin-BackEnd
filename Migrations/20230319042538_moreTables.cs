using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GenshinApplication.Migrations
{
    /// <inheritdoc />
    public partial class moreTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Build",
                columns: table => new
                {
                    BuildId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FlowerArtifactsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PlumeArtifactsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SandsArtifactsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GobletArtifactsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CircletArtifactsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WeaponId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Build", x => x.BuildId);
                    table.ForeignKey(
                        name: "FK_Build_Artifacts_CircletArtifactsId",
                        column: x => x.CircletArtifactsId,
                        principalTable: "Artifacts",
                        principalColumn: "ArtifactsId");
                    table.ForeignKey(
                        name: "FK_Build_Artifacts_FlowerArtifactsId",
                        column: x => x.FlowerArtifactsId,
                        principalTable: "Artifacts",
                        principalColumn: "ArtifactsId");
                    table.ForeignKey(
                        name: "FK_Build_Artifacts_GobletArtifactsId",
                        column: x => x.GobletArtifactsId,
                        principalTable: "Artifacts",
                        principalColumn: "ArtifactsId");
                    table.ForeignKey(
                        name: "FK_Build_Artifacts_PlumeArtifactsId",
                        column: x => x.PlumeArtifactsId,
                        principalTable: "Artifacts",
                        principalColumn: "ArtifactsId");
                    table.ForeignKey(
                        name: "FK_Build_Artifacts_SandsArtifactsId",
                        column: x => x.SandsArtifactsId,
                        principalTable: "Artifacts",
                        principalColumn: "ArtifactsId");
                    table.ForeignKey(
                        name: "FK_Build_Weapons_WeaponId",
                        column: x => x.WeaponId,
                        principalTable: "Weapons",
                        principalColumn: "WeaponId");
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharactersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Element = table.Column<int>(type: "int", nullable: false),
                    NumberOfStars = table.Column<int>(type: "int", nullable: false),
                    WeaponTypeWeaponId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharactersId);
                    table.ForeignKey(
                        name: "FK_Characters_Weapons_WeaponTypeWeaponId",
                        column: x => x.WeaponTypeWeaponId,
                        principalTable: "Weapons",
                        principalColumn: "WeaponId");
                });

            migrationBuilder.CreateTable(
                name: "BuildCharacters",
                columns: table => new
                {
                    BuildId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CharactersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildCharacters", x => new { x.BuildId, x.CharactersId });
                    table.ForeignKey(
                        name: "FK_BuildCharacters_Build_BuildId",
                        column: x => x.BuildId,
                        principalTable: "Build",
                        principalColumn: "BuildId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuildCharacters_Characters_CharactersId",
                        column: x => x.CharactersId,
                        principalTable: "Characters",
                        principalColumn: "CharactersId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Build_CircletArtifactsId",
                table: "Build",
                column: "CircletArtifactsId");

            migrationBuilder.CreateIndex(
                name: "IX_Build_FlowerArtifactsId",
                table: "Build",
                column: "FlowerArtifactsId");

            migrationBuilder.CreateIndex(
                name: "IX_Build_GobletArtifactsId",
                table: "Build",
                column: "GobletArtifactsId");

            migrationBuilder.CreateIndex(
                name: "IX_Build_PlumeArtifactsId",
                table: "Build",
                column: "PlumeArtifactsId");

            migrationBuilder.CreateIndex(
                name: "IX_Build_SandsArtifactsId",
                table: "Build",
                column: "SandsArtifactsId");

            migrationBuilder.CreateIndex(
                name: "IX_Build_WeaponId",
                table: "Build",
                column: "WeaponId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildCharacters_CharactersId",
                table: "BuildCharacters",
                column: "CharactersId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_WeaponTypeWeaponId",
                table: "Characters",
                column: "WeaponTypeWeaponId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuildCharacters");

            migrationBuilder.DropTable(
                name: "Build");

            migrationBuilder.DropTable(
                name: "Characters");
        }
    }
}

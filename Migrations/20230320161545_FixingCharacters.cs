using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GenshinApplication.Migrations
{
    /// <inheritdoc />
    public partial class FixingCharacters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artifacts_Items_ItemId",
                table: "Artifacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Weapons_WeaponTypeWeaponId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Weapons_Items_ItemId",
                table: "Weapons");

            migrationBuilder.DropTable(
                name: "BuildCharacters");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Weapons_ItemId",
                table: "Weapons");

            migrationBuilder.DropIndex(
                name: "IX_Characters_WeaponTypeWeaponId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Artifacts_ItemId",
                table: "Artifacts");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "Weapons");

            migrationBuilder.DropColumn(
                name: "WeaponTypeWeaponId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "Artifacts");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Weapons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Stars",
                table: "Weapons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WeaponType",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "CharactersId",
                table: "Build",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Artifacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Stars",
                table: "Artifacts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Constelation",
                columns: table => new
                {
                    ConstelationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Effect = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CharactersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Constelation", x => x.ConstelationId);
                    table.ForeignKey(
                        name: "FK_Constelation_Characters_CharactersId",
                        column: x => x.CharactersId,
                        principalTable: "Characters",
                        principalColumn: "CharactersId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Build_CharactersId",
                table: "Build",
                column: "CharactersId");

            migrationBuilder.CreateIndex(
                name: "IX_Constelation_CharactersId",
                table: "Constelation",
                column: "CharactersId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Build_Characters_CharactersId",
                table: "Build",
                column: "CharactersId",
                principalTable: "Characters",
                principalColumn: "CharactersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Build_Characters_CharactersId",
                table: "Build");

            migrationBuilder.DropTable(
                name: "Constelation");

            migrationBuilder.DropIndex(
                name: "IX_Build_CharactersId",
                table: "Build");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Weapons");

            migrationBuilder.DropColumn(
                name: "Stars",
                table: "Weapons");

            migrationBuilder.DropColumn(
                name: "WeaponType",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "CharactersId",
                table: "Build");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Artifacts");

            migrationBuilder.DropColumn(
                name: "Stars",
                table: "Artifacts");

            migrationBuilder.AddColumn<Guid>(
                name: "ItemId",
                table: "Weapons",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "WeaponTypeWeaponId",
                table: "Characters",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ItemId",
                table: "Artifacts",
                type: "uniqueidentifier",
                nullable: true);

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

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stars = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_ItemId",
                table: "Weapons",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_WeaponTypeWeaponId",
                table: "Characters",
                column: "WeaponTypeWeaponId");

            migrationBuilder.CreateIndex(
                name: "IX_Artifacts_ItemId",
                table: "Artifacts",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildCharacters_CharactersId",
                table: "BuildCharacters",
                column: "CharactersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Artifacts_Items_ItemId",
                table: "Artifacts",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Weapons_WeaponTypeWeaponId",
                table: "Characters",
                column: "WeaponTypeWeaponId",
                principalTable: "Weapons",
                principalColumn: "WeaponId");

            migrationBuilder.AddForeignKey(
                name: "FK_Weapons_Items_ItemId",
                table: "Weapons",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "ItemId");
        }
    }
}

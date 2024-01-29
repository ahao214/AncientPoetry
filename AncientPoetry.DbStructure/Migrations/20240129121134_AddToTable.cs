using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AncientPoetry.DbStructure.Migrations
{
    /// <inheritdoc />
    public partial class AddToTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Poets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DynastyId = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Poets_Dynasties_DynastyId",
                        column: x => x.DynastyId,
                        principalTable: "Dynasties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Poems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PoetId = table.Column<int>(type: "int", nullable: false),
                    Preface = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Context = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Explain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Poems_Poets_PoetId",
                        column: x => x.PoetId,
                        principalTable: "Poets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Poems_PoetId",
                table: "Poems",
                column: "PoetId");

            migrationBuilder.CreateIndex(
                name: "IX_Poets_DynastyId",
                table: "Poets",
                column: "DynastyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Poems");

            migrationBuilder.DropTable(
                name: "Poets");
        }
    }
}

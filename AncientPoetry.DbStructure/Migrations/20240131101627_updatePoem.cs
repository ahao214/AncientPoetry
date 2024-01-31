using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AncientPoetry.DbStructure.Migrations
{
    /// <inheritdoc />
    public partial class updatePoem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Poems_Poets_PoetId",
                table: "Poems");

            migrationBuilder.DropIndex(
                name: "IX_Poems_PoetId",
                table: "Poems");

            migrationBuilder.DropColumn(
                name: "PoetId",
                table: "Poems");

            migrationBuilder.RenameColumn(
                name: "Preface",
                table: "Poems",
                newName: "DynastyName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Poems",
                newName: "Titel");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Poems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateBackground",
                table: "Poems",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Poems");

            migrationBuilder.DropColumn(
                name: "CreateBackground",
                table: "Poems");

            migrationBuilder.RenameColumn(
                name: "Titel",
                table: "Poems",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "DynastyName",
                table: "Poems",
                newName: "Preface");

            migrationBuilder.AddColumn<int>(
                name: "PoetId",
                table: "Poems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Poems_PoetId",
                table: "Poems",
                column: "PoetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Poems_Poets_PoetId",
                table: "Poems",
                column: "PoetId",
                principalTable: "Poets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

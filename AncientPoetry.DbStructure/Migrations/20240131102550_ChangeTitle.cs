using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AncientPoetry.DbStructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTitle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Titel",
                table: "Poems",
                newName: "Title");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Poems",
                newName: "Titel");
        }
    }
}

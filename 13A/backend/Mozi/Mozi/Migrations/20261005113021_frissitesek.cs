using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mozi.Migrations
{
    /// <inheritdoc />
    public partial class frissitesek : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KiadoNEv",
                table: "kidadok",
                newName: "KiadoNev");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KiadoNev",
                table: "kidadok",
                newName: "KiadoNEv");
        }
    }
}

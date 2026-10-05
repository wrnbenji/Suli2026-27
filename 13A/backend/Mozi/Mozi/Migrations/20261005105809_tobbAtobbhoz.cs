using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mozi.Migrations
{
    /// <inheritdoc />
    public partial class tobbAtobbhoz : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FilmId",
                table: "mufajok",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KiadoId",
                table: "filmek",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "FilmMufaj",
                columns: table => new
                {
                    FilmId = table.Column<int>(type: "int", nullable: false),
                    MufajId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmMufaj", x => new { x.FilmId, x.MufajId });
                    table.ForeignKey(
                        name: "FK_FilmMufaj_filmek_FilmId",
                        column: x => x.FilmId,
                        principalTable: "filmek",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmMufaj_mufajok_MufajId",
                        column: x => x.MufajId,
                        principalTable: "mufajok",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_mufajok_FilmId",
                table: "mufajok",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_filmek_KiadoId",
                table: "filmek",
                column: "KiadoId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmMufaj_MufajId",
                table: "FilmMufaj",
                column: "MufajId");

            migrationBuilder.AddForeignKey(
                name: "FK_filmek_kidadok_KiadoId",
                table: "filmek",
                column: "KiadoId",
                principalTable: "kidadok",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_mufajok_filmek_FilmId",
                table: "mufajok",
                column: "FilmId",
                principalTable: "filmek",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_filmek_kidadok_KiadoId",
                table: "filmek");

            migrationBuilder.DropForeignKey(
                name: "FK_mufajok_filmek_FilmId",
                table: "mufajok");

            migrationBuilder.DropTable(
                name: "FilmMufaj");

            migrationBuilder.DropIndex(
                name: "IX_mufajok_FilmId",
                table: "mufajok");

            migrationBuilder.DropIndex(
                name: "IX_filmek_KiadoId",
                table: "filmek");

            migrationBuilder.DropColumn(
                name: "FilmId",
                table: "mufajok");

            migrationBuilder.DropColumn(
                name: "KiadoId",
                table: "filmek");
        }
    }
}

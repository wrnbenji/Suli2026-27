using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iskoaliprogWB.Migrations
{
    /// <inheritdoc />
    public partial class javitas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "jelentkezesek",
                keyColumn: "ProgramTipusa",
                keyValue: null,
                column: "ProgramTipusa",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "ProgramTipusa",
                table: "jelentkezesek",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProgramTipusa",
                table: "jelentkezesek",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tanulok.Migrations
{
    /// <inheritdoc />
    public partial class Osztalyosszevonva : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "evfolyam",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "osztaly",
                table: "Students",
                newName: "Osztaly");

            migrationBuilder.AlterColumn<string>(
                name: "Osztaly",
                table: "Students",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(1)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Osztaly",
                table: "Students",
                newName: "osztaly");

            migrationBuilder.AlterColumn<string>(
                name: "osztaly",
                table: "Students",
                type: "varchar(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "evfolyam",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EBooksite.Migrations
{
    /// <inheritdoc />
    public partial class Four : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_BooksLogs_UserId",
                table: "BooksLogs");

            migrationBuilder.AlterColumn<double>(
                name: "Rating",
                table: "BooksLogs",
                type: "float",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BooksLogs_UserId_BookId",
                table: "BooksLogs",
                columns: new[] { "UserId", "BookId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_BooksLogs_UserId_BookId",
                table: "BooksLogs");

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "BooksLogs",
                type: "int",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BooksLogs_UserId",
                table: "BooksLogs",
                column: "UserId");
        }
    }
}

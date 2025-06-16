using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EBooksite.Migrations
{
    /// <inheritdoc />
    public partial class Seven : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Designation",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Testimonials",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Testimonials",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Testimonials_UserId",
                table: "Testimonials",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Testimonials_Users_UserId",
                table: "Testimonials",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Testimonials_Users_UserId",
                table: "Testimonials");

            migrationBuilder.DropIndex(
                name: "IX_Testimonials_UserId",
                table: "Testimonials");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Testimonials");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Testimonials");

            migrationBuilder.AlterColumn<string>(
                name: "Designation",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);
        }
    }
}

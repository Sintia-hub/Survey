using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Survey.Migrations
{
    /// <inheritdoc />
    public partial class RenameColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LikesBeefStirFry",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "LikesChickenStirFry",
                table: "Surveys");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Surveys",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Surveys",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Surveys",
                newName: "DateOfBirth");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Surveys",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Surveys",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "Surveys",
                newName: "Date");

            migrationBuilder.AddColumn<bool>(
                name: "LikesBeefStirFry",
                table: "Surveys",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LikesChickenStirFry",
                table: "Surveys",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}

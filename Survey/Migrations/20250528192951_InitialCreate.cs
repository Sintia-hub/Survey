using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Survey.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Surveys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LikesPizza = table.Column<bool>(type: "bit", nullable: false),
                    LikesPasta = table.Column<bool>(type: "bit", nullable: false),
                    LikesPapAndWors = table.Column<bool>(type: "bit", nullable: false),
                    LikesChickenStirFry = table.Column<bool>(type: "bit", nullable: false),
                    LikesBeefStirFry = table.Column<bool>(type: "bit", nullable: false),
                    LikesOther = table.Column<bool>(type: "bit", nullable: false),
                    EatOutRating = table.Column<int>(type: "int", nullable: false),
                    WatchMoviesRating = table.Column<int>(type: "int", nullable: false),
                    WatchTVRating = table.Column<int>(type: "int", nullable: false),
                    ListenToRadioRating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surveys", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Surveys");
        }
    }
}

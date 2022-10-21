using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VTC.Data.Migrations
{
    public partial class addstatusfield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EntityStatus",
                table: "Subjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EntityStatus",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EntityStatus",
                table: "QuestionAnswers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EntityStatus",
                table: "Packages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EntityStatus",
                table: "Levels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EntityStatus",
                table: "Lessons",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EntityStatus",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "EntityStatus",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "EntityStatus",
                table: "QuestionAnswers");

            migrationBuilder.DropColumn(
                name: "EntityStatus",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "EntityStatus",
                table: "Levels");

            migrationBuilder.DropColumn(
                name: "EntityStatus",
                table: "Lessons");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VTC.Data.Migrations
{
    public partial class SeparateName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ParentFullName",
                table: "ParentAgreements",
                newName: "ParentSecondName");

            migrationBuilder.RenameColumn(
                name: "ChildFullName",
                table: "ParentAgreements",
                newName: "ParentFirstName");

            migrationBuilder.AddColumn<string>(
                name: "ChildFirstName",
                table: "ParentAgreements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ChildSecondName",
                table: "ParentAgreements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChildFirstName",
                table: "ParentAgreements");

            migrationBuilder.DropColumn(
                name: "ChildSecondName",
                table: "ParentAgreements");

            migrationBuilder.RenameColumn(
                name: "ParentSecondName",
                table: "ParentAgreements",
                newName: "ParentFullName");

            migrationBuilder.RenameColumn(
                name: "ParentFirstName",
                table: "ParentAgreements",
                newName: "ChildFullName");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VTC.Data.Migrations
{
    public partial class addagreementform : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ParentAgreements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentDob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ParentIdNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentIdFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentSocialCard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentIdIssueddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChildFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChildBirthCertificate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntityStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentAgreements", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParentAgreements");
        }
    }
}

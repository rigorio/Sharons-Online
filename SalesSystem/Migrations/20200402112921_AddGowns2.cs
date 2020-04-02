using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesSystem.Migrations
{
    public partial class AddGowns2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gowns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    price = table.Column<double>(nullable: false),
                    status = table.Column<string>(nullable: true),
                    dateRented = table.Column<DateTime>(nullable: false),
                    dueDate = table.Column<DateTime>(nullable: false),
                    dateReturned = table.Column<DateTime>(nullable: false),
                    pickupDate = table.Column<DateTime>(nullable: false),
                    contact = table.Column<string>(nullable: true),
                    orNumber = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    partialPayment = table.Column<string>(nullable: true),
                    balance = table.Column<string>(nullable: true),
                    securityDeposit = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gowns", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gowns");
        }
    }
}

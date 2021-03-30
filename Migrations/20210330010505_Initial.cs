using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace drive_truck_web.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    registered_name = table.Column<string>(nullable: true),
                    fantasy_name = table.Column<string>(nullable: true),
                    employer_number = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    state = table.Column<string>(nullable: true),
                    zip_code = table.Column<string>(nullable: true),
                    country = table.Column<string>(nullable: true),
                    neighborhood = table.Column<string>(nullable: true),
                    landline_phone = table.Column<string>(nullable: true),
                    mobile_phone = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    manager = table.Column<string>(nullable: true),
                    contact_manager = table.Column<string>(nullable: true),
                    email_manager = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    registered_name = table.Column<string>(nullable: true),
                    fantasy_name = table.Column<string>(nullable: true),
                    employer_number = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    state = table.Column<string>(nullable: true),
                    country = table.Column<string>(nullable: true),
                    neighborhood = table.Column<string>(nullable: true),
                    landline_phone = table.Column<string>(nullable: true),
                    mobile_phone = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    manager = table.Column<string>(nullable: true),
                    contact_manager = table.Column<string>(nullable: true),
                    email_manager = table.Column<string>(nullable: true),
                    ClientId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customer_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Garage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    state = table.Column<string>(nullable: true),
                    zip_code = table.Column<string>(nullable: true),
                    country = table.Column<string>(nullable: true),
                    landline_phone = table.Column<string>(nullable: true),
                    mobile_phone = table.Column<string>(nullable: true),
                    neighborhood = table.Column<string>(nullable: true),
                    number = table.Column<string>(nullable: true),
                    ClientId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Garage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Garage_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Driver",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    number_cpf = table.Column<string>(nullable: true),
                    number_rg = table.Column<string>(nullable: true),
                    number_pis = table.Column<string>(nullable: true),
                    number_driver_license = table.Column<string>(nullable: true),
                    date_expire_driver_license = table.Column<DateTime>(nullable: false),
                    address = table.Column<string>(nullable: true),
                    number = table.Column<int>(nullable: false),
                    city = table.Column<string>(nullable: true),
                    state = table.Column<string>(nullable: true),
                    zip_code = table.Column<string>(nullable: true),
                    country = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    phone_emergency = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    GarageId = table.Column<int>(nullable: true),
                    ClientId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Driver", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Driver_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Driver_Garage_GarageId",
                        column: x => x.GarageId,
                        principalTable: "Garage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    car_license_plate = table.Column<string>(nullable: true),
                    model = table.Column<string>(nullable: true),
                    brand = table.Column<string>(nullable: true),
                    year_factory = table.Column<string>(nullable: true),
                    year_model = table.Column<string>(nullable: true),
                    GarageId = table.Column<int>(nullable: true),
                    ClientId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicles_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicles_Garage_GarageId",
                        column: x => x.GarageId,
                        principalTable: "Garage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_ClientId",
                table: "Customer",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Driver_ClientId",
                table: "Driver",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Driver_GarageId",
                table: "Driver",
                column: "GarageId");

            migrationBuilder.CreateIndex(
                name: "IX_Garage_ClientId",
                table: "Garage",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_ClientId",
                table: "Vehicles",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_GarageId",
                table: "Vehicles",
                column: "GarageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Driver");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Garage");

            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}

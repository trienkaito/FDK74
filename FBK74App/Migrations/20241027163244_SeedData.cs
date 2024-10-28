using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBK74App.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FootballFields",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballFields", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegistFindOppoents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Account1Id = table.Column<int>(type: "int", nullable: false),
                    Account2Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Power = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeOfFootballField = table.Column<int>(type: "int", nullable: false),
                    Deposit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistFindOppoents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegistFindOppoents_Accounts_Account1Id",
                        column: x => x.Account1Id,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegistFindOppoents_Accounts_Account2Id",
                        column: x => x.Account2Id,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FootballFieldSchedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FootballFieldId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballFieldSchedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FootballFieldSchedules_FootballFields_FootballFieldId",
                        column: x => x.FootballFieldId,
                        principalTable: "FootballFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegisteredFootballFields",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Deposit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Account1Id = table.Column<int>(type: "int", nullable: false),
                    Account2Id = table.Column<int>(type: "int", nullable: false),
                    RegistFindOppoentId = table.Column<int>(type: "int", nullable: false),
                    FootballFieldScheduleId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisteredFootballFields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegisteredFootballFields_Accounts_Account1Id",
                        column: x => x.Account1Id,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegisteredFootballFields_Accounts_Account2Id",
                        column: x => x.Account2Id,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegisteredFootballFields_FootballFieldSchedules_FootballFieldScheduleId",
                        column: x => x.FootballFieldScheduleId,
                        principalTable: "FootballFieldSchedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegisteredFootballFields_RegistFindOppoents_RegistFindOppoentId",
                        column: x => x.RegistFindOppoentId,
                        principalTable: "RegistFindOppoents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Invoice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredFootballFieldId = table.Column<int>(type: "int", nullable: false),
                    Account2Id = table.Column<int>(type: "int", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: true),
                    RegisteredFootballFieldId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bills_Accounts_Account2Id",
                        column: x => x.Account2Id,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bills_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bills_RegisteredFootballFields_RegisteredFootballFieldId",
                        column: x => x.RegisteredFootballFieldId,
                        principalTable: "RegisteredFootballFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bills_RegisteredFootballFields_RegisteredFootballFieldId1",
                        column: x => x.RegisteredFootballFieldId1,
                        principalTable: "RegisteredFootballFields",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    BillId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDetails_Bills_BillId",
                        column: x => x.BillId,
                        principalTable: "Bills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "CreatedDate", "Email", "Password", "PhoneNumber", "Status", "Type", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5231), "user1@example.com", "pass1", "1234567890", "Active", 0, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5243), "user1" },
                    { 2, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5247), "user2@example.com", "pass2", "1234567891", "Inactive", 1, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5248), "user2" },
                    { 3, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5251), "user3@example.com", "pass3", "1234567892", "Active", 0, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5252), "user3" },
                    { 4, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5254), "user4@example.com", "pass4", "1234567893", "Inactive", 1, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5255), "user4" },
                    { 5, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5257), "user5@example.com", "pass5", "1234567894", "Active", 0, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5258), "user5" }
                });

            migrationBuilder.InsertData(
                table: "FootballFields",
                columns: new[] { "Id", "Address", "CreatedDate", "Description", "Image", "Name", "Price", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Field1", 100.0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Field2", 200.0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Field3", 300.0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Field4", 400.0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Field5", 500.0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "Description", "Image", "Name", "Quantity", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5595), "Description1", "image1.jpg", "Product1", 10, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5596) },
                    { 2, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5599), "Description2", "image2.jpg", "Product2", 20, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5600) },
                    { 3, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5602), "Description3", "image3.jpg", "Product3", 30, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5603) },
                    { 4, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5605), "Description4", "image4.jpg", "Product4", 40, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5605) },
                    { 5, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5607), "Description5", "image5.jpg", "Product5", 50, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5608) }
                });

            migrationBuilder.InsertData(
                table: "FootballFieldSchedules",
                columns: new[] { "Id", "CreatedDate", "EndTime", "FootballFieldId", "StartTime", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5979), new DateTime(2024, 10, 28, 1, 32, 39, 855, DateTimeKind.Local).AddTicks(5978), 1, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5977), "Scheduled", new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5980) },
                    { 2, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5984), new DateTime(2024, 10, 28, 1, 32, 39, 855, DateTimeKind.Local).AddTicks(5983), 2, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5982), "Scheduled", new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5985) },
                    { 3, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5989), new DateTime(2024, 10, 28, 1, 32, 39, 855, DateTimeKind.Local).AddTicks(5988), 3, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5987), "Scheduled", new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5990) },
                    { 4, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5993), new DateTime(2024, 10, 28, 1, 32, 39, 855, DateTimeKind.Local).AddTicks(5992), 4, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5991), "Scheduled", new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5994) },
                    { 5, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5997), new DateTime(2024, 10, 28, 1, 32, 39, 855, DateTimeKind.Local).AddTicks(5996), 5, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5995), "Scheduled", new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5998) }
                });

            migrationBuilder.InsertData(
                table: "RegistFindOppoents",
                columns: new[] { "Id", "Account1Id", "Account2Id", "CreatedDate", "Date", "Deposit", "EndTime", "Name", "Phone", "Power", "StartTime", "Status", "TypeOfFootballField", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, 2, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5881), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5878), 100.0m, new DateTime(2024, 10, 28, 1, 32, 39, 855, DateTimeKind.Local).AddTicks(5870), "Opponent1", "1234567890", "High", new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5869), 1, 1, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5882) },
                    { 2, 2, 3, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5888), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5886), 200.0m, new DateTime(2024, 10, 28, 1, 32, 39, 855, DateTimeKind.Local).AddTicks(5885), "Opponent2", "1234567891", "Medium", new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5884), 2, 2, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5889) },
                    { 3, 3, 4, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5896), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5894), 300.0m, new DateTime(2024, 10, 28, 1, 32, 39, 855, DateTimeKind.Local).AddTicks(5893), "Opponent3", "1234567892", "Low", new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5892), 3, 3, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5897) },
                    { 4, 4, 5, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5903), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5901), 400.0m, new DateTime(2024, 10, 28, 1, 32, 39, 855, DateTimeKind.Local).AddTicks(5900), "Opponent4", "1234567893", "High", new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5899), 1, 1, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5903) },
                    { 5, 5, 1, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5909), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5907), 500.0m, new DateTime(2024, 10, 28, 1, 32, 39, 855, DateTimeKind.Local).AddTicks(5906), "Opponent5", "1234567894", "Medium", new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5905), 2, 2, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5909) }
                });

            migrationBuilder.InsertData(
                table: "RegisteredFootballFields",
                columns: new[] { "Id", "Account1Id", "Account2Id", "CreatedDate", "Date", "Deposit", "FootballFieldScheduleId", "Name", "Note", "RegistFindOppoentId", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, 2, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5809), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5807), 100.0m, 1, "Field1", "Note1", 1, "Active", new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5810) },
                    { 2, 2, 3, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5815), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5814), 200.0m, 2, "Field2", "Note2", 2, "Inactive", new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5816) },
                    { 3, 3, 4, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5820), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5819), 300.0m, 3, "Field3", "Note3", 3, "Active", new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5821) },
                    { 4, 4, 5, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5825), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5824), 400.0m, 4, "Field4", "Note4", 4, "Inactive", new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5825) },
                    { 5, 5, 1, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5830), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5828), 500.0m, 5, "Field5", "Note5", 5, "Active", new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5831) }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "Id", "Account2Id", "AccountId", "CreatedDate", "Invoice", "PaymentDate", "RegisteredFootballFieldId", "RegisteredFootballFieldId1", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5752), "INV001", new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5751), 1, null, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5753) },
                    { 2, 2, null, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5757), "INV002", new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5756), 2, null, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5758) },
                    { 3, 3, null, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5761), "INV003", new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5760), 3, null, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5762) },
                    { 4, 4, null, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5764), "INV004", new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5763), 4, null, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5765) },
                    { 5, 5, null, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5767), "INV005", new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5767), 5, null, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5768) }
                });

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "Id", "BillId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1, 5 },
                    { 2, 2, 2, 10 },
                    { 3, 3, 3, 15 },
                    { 4, 4, 4, 20 },
                    { 5, 5, 5, 25 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bills_Account2Id",
                table: "Bills",
                column: "Account2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_AccountId",
                table: "Bills",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_RegisteredFootballFieldId",
                table: "Bills",
                column: "RegisteredFootballFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_RegisteredFootballFieldId1",
                table: "Bills",
                column: "RegisteredFootballFieldId1");

            migrationBuilder.CreateIndex(
                name: "IX_FootballFieldSchedules_FootballFieldId",
                table: "FootballFieldSchedules",
                column: "FootballFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_BillId",
                table: "ProductDetails",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_ProductId",
                table: "ProductDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_RegisteredFootballFields_Account1Id",
                table: "RegisteredFootballFields",
                column: "Account1Id");

            migrationBuilder.CreateIndex(
                name: "IX_RegisteredFootballFields_Account2Id",
                table: "RegisteredFootballFields",
                column: "Account2Id");

            migrationBuilder.CreateIndex(
                name: "IX_RegisteredFootballFields_FootballFieldScheduleId",
                table: "RegisteredFootballFields",
                column: "FootballFieldScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_RegisteredFootballFields_RegistFindOppoentId",
                table: "RegisteredFootballFields",
                column: "RegistFindOppoentId");

            migrationBuilder.CreateIndex(
                name: "IX_RegistFindOppoents_Account1Id",
                table: "RegistFindOppoents",
                column: "Account1Id");

            migrationBuilder.CreateIndex(
                name: "IX_RegistFindOppoents_Account2Id",
                table: "RegistFindOppoents",
                column: "Account2Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductDetails");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "RegisteredFootballFields");

            migrationBuilder.DropTable(
                name: "FootballFieldSchedules");

            migrationBuilder.DropTable(
                name: "RegistFindOppoents");

            migrationBuilder.DropTable(
                name: "FootballFields");

            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivationCode = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MasterId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SelectedStatus = table.Column<int>(type: "int", nullable: false),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    County = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CustomerPhone = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CustomerAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CustomerIdentityNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CustomerPaymentDetails = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    MasterId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SelectedStatus = table.Column<int>(type: "int", nullable: false),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeFirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeLastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeePhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Position = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeAddres = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ShiftStart = table.Column<DateTime>(type: "date", nullable: false),
                    ShiftEnd = table.Column<DateTime>(type: "date", nullable: false),
                    WeeklyOfDate = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValue: "none"),
                    HasOverTime = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    WeeklyWorkedHours = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    TotalWorkedHours = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    HourlyWage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MonthlyWage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    MasterId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SelectedStatus = table.Column<int>(type: "int", nullable: false),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomNumber = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomCapacity = table.Column<int>(type: "int", nullable: false),
                    RoomBreakfast = table.Column<bool>(type: "bit", nullable: false),
                    PricePerNight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HasBalcony = table.Column<bool>(type: "bit", nullable: false),
                    HasMinibar = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    PackageType = table.Column<int>(type: "int", nullable: false),
                    HasAirConditioning = table.Column<bool>(type: "bit", nullable: false),
                    HasTV = table.Column<bool>(type: "bit", nullable: false),
                    HasHairDryer = table.Column<bool>(type: "bit", nullable: false),
                    HasWiFi = table.Column<bool>(type: "bit", nullable: false),
                    DataStasus = table.Column<int>(type: "int", nullable: false),
                    MasterId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SelectedStatus = table.Column<int>(type: "int", nullable: false),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shifts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShiftType = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ShiftDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MasterId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SelectedStatus = table.Column<int>(type: "int", nullable: false),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shifts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shifts_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PackageType = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    ReservationStatus = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    MasterId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SelectedStatus = table.Column<int>(type: "int", nullable: false),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpenseName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ExpenseAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExpenseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpenseDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ReservationId = table.Column<int>(type: "int", nullable: false),
                    MasterId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SelectedStatus = table.Column<int>(type: "int", nullable: false),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expenses_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false),
                    ReservationId = table.Column<int>(type: "int", nullable: false),
                    MasterId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SelectedStatus = table.Column<int>(type: "int", nullable: false),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "SelectedStatus", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Lianastad", "Slovakia (Slovak Republic)", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(3894), "85154 Dickens Station, Port Cydney, Bulgaria", "2", "BG84ADFV006614G1925807", "500.831.7416 x12679", "Lance82@yahoo.com", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(3905), "Samanta", "Gerlach", "e12b2340-4cfa-4121-9b0f-df635c0c22b6", "54168", 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(3905) },
                    { 2, "Keelytown", "Maldives", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(4774), "0048 O'Kon Bypass, Goodwinhaven, Guadeloupe", "6", "RS09676700558530337006", "916-365-6749 x072", "Felix.Ebert95@gmail.com", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(4774), "Bell", "Stamm", "53f811e1-22ec-43a7-8aee-d9660f805721", "06289-5895", 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(4775) },
                    { 3, "Paucekberg", "Norfolk Island", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(4990), "27880 Dino Shoal, Allieview, Norfolk Island", "10", "LI403007332ZC750V04O6", "804.917.1977", "Edyth79@gmail.com", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(4990), "Arvilla", "Nitzsche", "a95d2666-e299-4902-a1ad-745dfb3afcf0", "32871-0120", 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(4991) },
                    { 4, "Saigeside", "Swaziland", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(5176), "921 Marquardt Falls, West Ryley, Gambia", "11", "LU53005C6QG9R1034891", "950.491.2684", "Alexie_Lakin@gmail.com", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(5176), "Jevon", "Bailey", "b6e4cac4-494a-478d-877d-6bd8a987215c", "53777", 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(5177) },
                    { 5, "Enatown", "Ecuador", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(5341), "208 Hackett Dam, Schmidtview, Israel", "11", "SM20Y00887002422691421A0P21", "1-678-268-1250 x199", "Kariane_Windler81@hotmail.com", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(5341), "Nick", "Connelly", "db3b2209-88a1-4334-9b90-2b4d1eea6538", "58350", 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(5342) },
                    { 6, "New Wavachester", "Iceland", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(5524), "077 Lesch Lodge, Katelynnmouth, French Guiana", "11", "ME91665006700833006396", "377.327.3141 x7190", "Corbin.Murazik73@yahoo.com", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(5524), "Tate", "Kirlin", "d512ceaa-01d3-4c65-afd7-fff739b5de9f", "42531", 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(5524) },
                    { 7, "New Lucyville", "Burundi", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(5689), "396 Cartwright Circles, West Brycen, Jordan", "10", "XK946478078600430774", "307-950-2423", "Cynthia87@gmail.com", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(5689), "Akeem", "Padberg", "96b74421-8c4d-4bf4-9947-f9012d2b66e3", "21587", 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(5690) },
                    { 8, "East Catalina", "Chad", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(5839), "0197 Crist Glens, New Rollin, Saint Kitts and Nevis", "3", "QA54HYBC7Z6340U21445U04S3R732", "790-942-5228 x51279", "Kiarra.Nader31@yahoo.com", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(5839), "Major", "Gutkowski", "35238ac1-c11a-4787-a706-a3c6acd8b078", "18603", 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(5840) },
                    { 9, "South Maximillian", "Bosnia and Herzegovina", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(6003), "092 Karl Road, East Dellafurt, El Salvador", "4", "TR480699519718Z34912927996", "(546) 392-4175 x37887", "Natalia.Jacobi@yahoo.com", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(6004), "Bella", "Greenfelder", "e16774bf-d9d6-401b-8451-42e0b8db6e88", "24801", 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(6004) },
                    { 10, "Lake Germaine", "Cameroon", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(6167), "162 Waylon Terrace, East Korey, Slovenia", "5", "RO62MMLH468194NZQ4L30436", "(607) 438-8896", "Jacynthe.Cartwright10@gmail.com", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(6167), "Forrest", "Abbott", "622a96ef-324a-4833-a43d-53a0b759ebdf", "35721-3455", 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(6168) }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "HourlyWage", "MasterId", "MonthlyWage", "Position", "PostalCode", "SelectedStatus", "ShiftEnd", "ShiftStart", "Status", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Tekirdağ", "Libya", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(9839), "Aladogan99@yahoo.com", "Atatürk Bulvarı 53a, Ağrı, Kuzey İrlanda", "Çağatay", "Koçoğlu", "+90-149-018-90-21", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(9842), 0m, "1530f17d-d15d-4aeb-83ab-d1838228dea9", 0m, "Resepsiyon Görevlisi", "1", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(9842) },
                    { 2, "Erzurum", "Libya", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(511), "Bukusboga.Elmastasoglu77@yahoo.com", "Lütfi Karadirek Caddesi 52c, Kastamonu, Reunion, Fransa", "Barsurungu", "Arslanoğlu", "+90-901-571-02-53", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(512), 0m, "1a44ffd6-6728-434c-a08b-832104d2d251", 0m, "Resepsiyon Görevlisi", "0", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(512) },
                    { 3, "Nevşehir", "Dominik Cumhuriyeti", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(653), "Aglamis72@yahoo.com", "Bandak Sokak 65b, Ordu, Gambiya", "Akboğa", "Aybar", "+90-937-731-1-191", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(653), 0m, "a16d91f0-947a-4a74-bf51-118b0c225c70", 0m, "Resepsiyon Görevlisi", "1", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(654) },
                    { 4, "Nevşehir", "Haiti", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(748), "Barcadogmus_Akisik@hotmail.com", "İbn-i Sina Sokak 25a, Ankara, Antigua ve Barbuda", "Alayunt", "Küçükler", "+90-545-629-5-808", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(748), 0m, "e6175c16-1b0d-4ff8-b5da-88f4e8b6d51a", 0m, "Resepsiyon Görevlisi", "1", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(748) },
                    { 5, "Hatay", "Mayotte, Fransa", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(841), "Aki56@yahoo.com", "İsmet Paşa Caddesi 2, Balıkesir, Tunus", "Babur", "Numanoğlu", "+90-943-378-6-909", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(842), 0m, "a63aea0c-ee5d-40af-a2dc-ecccfa1824fe", 0m, "Resepsiyon Görevlisi", "0", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(842) },
                    { 6, "Şanlıurfa", "Brezilya", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(932), "Akkus_Orge@yahoo.com", "Fatih Sokak  95c, İçel (Mersin), Slovakya", "Atmaca", "Yalçın", "+90-140-645-1-259", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(932), 0m, "d9cf0a47-79f2-4beb-93fd-6f8bbc95b620", 0m, "Resepsiyon Görevlisi", "0", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(933) },
                    { 7, "Bolu", "Özbekistan", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(1014), "Alpilig_Akisik@yahoo.com", "Dağınık Evler Sokak 75c, Şırnak, Tunus", "Çağru", "Günday", "+90-090-815-07-76", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(1015), 0m, "fbe6f83b-7704-4207-93ec-33d22c6604ad", 0m, "Resepsiyon Görevlisi", "0", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(1015) },
                    { 8, "Sakarya", "Vanuatu", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(7865), "Karaca_Adivar18@gmail.com", "Gül Sokak 76a, Bilecik, Reunion, Fransa", "Apak", "Gürmen", "+90-423-012-51-26", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(7866), 0m, "d8d6bffb-1bd0-4e32-821d-28d4511ab21d", 0m, "Temizlik Görevlisi", "0", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(7866) },
                    { 9, "Yalova", "Kuzey Kore", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8143), "Ebin.Babaoglu@hotmail.com", "Bayır Sokak 3, Kars, Gambiya", "Bornak", "Sadıklar", "+90-736-178-93-82", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8143), 0m, "26190860-4ad5-4b47-b1ca-85cb07b3d48d", 0m, "Temizlik Görevlisi", "1", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8144) },
                    { 10, "Burdur", "Gine-Bissau", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8242), "Bazir.Kuzucu25@yahoo.com", "Atatürk Bulvarı 05a, Bursa, Almanya", "Çaba", "Tokgöz", "+90-806-435-42-48", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8242), 0m, "9b14d6c7-d035-4928-a55d-9e365383e416", 0m, "Temizlik Görevlisi", "0", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8243) },
                    { 11, "Edirne", "Kazakistan", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8330), "Azak66@yahoo.com", "Okul Sokak 903, Giresun, Güney Georgia ve Güney Sandviç Adaları, İngiltere", "Karaca", "Numanoğlu", "+90-274-445-6-848", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8330), 0m, "b53d2f3c-0efc-40c3-a784-9e298717363c", 0m, "Temizlik Görevlisi", "1", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8331) },
                    { 12, "Iğdır", "Zambiya", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8413), "Gokcegol_Koybasi@yahoo.com", "Sarıkaya Caddesi 19c, Yozgat, Kolombiya", "Barlas", "Akal", "+90-406-049-68-31", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8414), 0m, "23a277e9-7096-47c0-be77-88667977dfdc", 0m, "Temizlik Görevlisi", "1", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8414) },
                    { 13, "Niğde", "Sırbistan", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8497), "Barbulsun_Corekci@yahoo.com", "Ali Çetinkaya Caddesi 14b, Tunceli, Santa Kitts ve Nevis", "Bozkuş", "Koçoğlu", "+90-124-176-58-30", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8498), 0m, "840d85db-26e8-4de3-afc9-e8e53ebf57d2", 0m, "Temizlik Görevlisi", "1", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8498) },
                    { 14, "Çankırı", "El Salvador", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8590), "Barbeg.Okur29@yahoo.com", "Tevfik Fikret Caddesi 275, Isparta, Grönland", "Bilgetamgacı", "Egeli", "+90-740-251-2-282", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8590), 0m, "0c93647b-524b-4e28-a0d0-0aa079cf9aa2", 0m, "Temizlik Görevlisi", "1", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8590) },
                    { 15, "Muğla", "Gürcistan H", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8665), "Barkin63@hotmail.com", "Harman Yolu Sokak  73b, Rize, Svaziland", "Karak", "Karabulut", "+90-528-292-64-89", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8666), 0m, "ee1aaddd-e535-4aec-bbe2-bb5f7f67dcaf", 0m, "Temizlik Görevlisi", "1", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8666) },
                    { 16, "Edirne", "Azerbaycan", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8742), "Arademir_Babacan8@gmail.com", "Gül Sokak 6, Balıkesir, Suudi Arabistan", "Kançı", "Tekelioğlu", "+90-463-128-84-01", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8743), 0m, "f621d790-472b-4800-ae4c-f184ddda2fa7", 0m, "Temizlik Görevlisi", "0", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8743) },
                    { 17, "Malatya", "Cezayir", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8828), "Bek3@hotmail.com", "Tevfik Fikret Caddesi 34, Ağrı, Hırvatistan", "Kırlangıç", "Erberk", "+90-620-767-9-974", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8828), 0m, "6f973a85-1407-48d1-9087-0be294bc8c7c", 0m, "Temizlik Görevlisi", "1", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8829) },
                    { 18, "K.maraş", "Uganda", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8907), "Bugrakarakagan.Egeli60@gmail.com", "Atatürk Bulvarı 09c, Manisa, Mısır", "Benlidemir", "Yazıcı", "+90-793-041-98-95", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8908), 0m, "c5f09b28-d88c-42d2-941c-edf30393755a", 0m, "Temizlik Görevlisi", "1", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8908) },
                    { 19, "Bolu", "Güney Kıbrıs Rum Yönetimi", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(783), "Bekbekec_Akgul@gmail.com", "Bayır Sokak 4, Samsun, Venezuela", "Ermen", "Balcı", "+90-233-701-5-015", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(788), 0m, "b68c32cf-c51b-4257-8bc7-88b3ad3fff9a", 0m, "Aşçı", "0", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(789) },
                    { 20, "Adıyaman", "Endonezya", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(5170), "Ardic24@gmail.com", "Mevlana Sokak 14a, Kilis, İran", "Belgi", "Velioğlu", "+90-917-113-2-928", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(5173), 0m, "91a21ad7-45b2-4ff3-bddb-b5ae1a29600b", 0m, "Aşçı", "1", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(5174) },
                    { 21, "Bartın", "Botswana", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(5387), "Akata54@hotmail.com", "Gül Sokak 39b, Antalya, Paraguay", "Barlıbay", "Kurutluoğlu", "+90-600-464-55-96", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(5388), 0m, "013879c0-8beb-4660-8aba-7132992e9571", 0m, "Aşçı", "0", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(5388) },
                    { 22, "Giresun", "Birmanya (Myanmar)", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(5513), "Bukak.Turkyilmaz47@gmail.com", "Kerimoğlu Sokak 258, Ordu, Christmas Adası , Avusturalya", "Aldıgerey", "Pekkan", "+90-782-344-2-068", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(5514), 0m, "021cf92d-72c5-4401-a281-36b44fff29c6", 0m, "Aşçı", "0", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(5514) },
                    { 23, "Kütahya", "Burkina Faso", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(5652), "Bakirsokum.Akgul24@gmail.com", "Güven Yaka Sokak 90c, Nevşehir, Brezilya", "Bağatur", "Korol", "+90-774-397-22-37", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(5653), 0m, "fff2db5c-f001-44ce-8e7c-2d872fdb6db4", 0m, "Aşçı", "1", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(5653) },
                    { 24, "Çankırı", "Nijer", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(5773), "Basut_Ozkok@gmail.com", "Alparslan Türkeş Bulvarı 84b, Bolu, Singapur", "Bozan", "Kıraç ", "+90-202-111-16-04", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(5774), 0m, "3e32c5a9-2988-4522-ae63-89bd32236be2", 0m, "Aşçı", "0", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(5774) },
                    { 25, "Balıkesir", "Cayman Adaları, İngiltere", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(5897), "Bilgetacam_Yildizoglu45@gmail.com", "Kaldırım Sokak 6, Manisa, Kanada", "Aprançur", "Türkdoğan", "+90-516-139-55-29", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(5897), 0m, "217f9ee0-d302-4fd2-9fc8-f768178f9758", 0m, "Aşçı", "1", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(5898) },
                    { 26, "Ardahan", "Fas", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(6027), "Abak_Barbarosoglu@hotmail.com", "Gül Sokak 74, Sinop, Kamerun", "Alpurungututuk", "Sandalcı", "+90-394-731-7-595", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(6027), 0m, "dadfb48b-9f0d-444f-a6b4-67c6d70f5ec2", 0m, "Aşçı", "1", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(6028) },
                    { 27, "K.maraş", "Vallis ve Futuna, Fransa", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(6146), "Katunkiz84@yahoo.com", "Tevfik Fikret Caddesi 16c, Muğla, Amerikan Samoa", "Barbeğ", "Karaer", "+90-887-402-03-60", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(6146), 0m, "5488ff68-e922-4039-880c-6ff6aeab0976", 0m, "Aşçı", "1", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(6147) },
                    { 28, "Rize", "Saint Pierre ve Miquelon, Fransa", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(6280), "Asikbulmus.Poyrazoglu@hotmail.com", "Saygılı Sokak 18b, Ordu, Mauritius", "Katunkız", "Sezek", "+90-062-771-79-05", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(6280), 0m, "8ce09946-2a9b-47c9-8fc4-e2a12b5a4ab0", 0m, "Aşçı", "1", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(6281) },
                    { 29, "Diyarbakır", "İzlanda", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(6407), "Biligkongulsengun.Akbulut@yahoo.com", "Ülkü Sokak 87c, Ankara, Makau (Makao)", "Baçman", "Numanoğlu", "+90-979-859-33-11", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(6408), 0m, "84c3d4a8-aa42-4f64-9767-171137a5989e", 0m, "Aşçı", "1", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(6408) },
                    { 30, "Giresun", "Gambiya", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(7265), "Bogde94@hotmail.com", "Sevgi Sokak 818, Karaman, Uruguay", "Beğdemir", "Kuday", "+90-812-094-01-14", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(7269), 0m, "f437d655-a845-4e04-979a-bd5153983a17", 0m, "Garson", "0", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(7270) },
                    { 31, "Sinop", "Uruguay", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(7845), "Borubars19@hotmail.com", "Dağınık Evler Sokak 7, Elazığ, Arjantin", "Alpagut", "Erberk", "+90-055-475-0-204", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(7846), 0m, "9ff37e69-115e-4928-9bfd-0b4d8f265537", 0m, "Garson", "0", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(7846) },
                    { 32, "Kilis", "Kamboçya", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8002), "Bortecine30@gmail.com", "İsmet Paşa Caddesi 9, Kırklareli, İsviçre", "Altankağan", "Abacı", "+90-035-952-19-15", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8002), 0m, "56115d0c-d130-4fb6-bdfa-176c936192fe", 0m, "Garson", "1", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8003) },
                    { 33, "Giresun", "Brunei", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8136), "Altay96@hotmail.com", "Sıran Söğüt Sokak 53, Van, Seyşeller", "Aşkın", "Erbulak", "+90-399-931-76-48", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8137), 0m, "b425a7a7-780e-4d09-929d-f3c1a8a9098f", 0m, "Garson", "1", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8137) },
                    { 34, "Burdur", "Panama", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8264), "Alptegin.Sayginer@gmail.com", "Fatih Sokak  63b, Çankırı, Turks ve Caicos Adaları, İngiltere", "Böke", "Adal", "+90-226-172-6-300", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8265), 0m, "9d70b7c9-c6ec-4f0c-af54-6b7fe779d7f5", 0m, "Garson", "1", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8265) },
                    { 35, "Muğla", "Avusturya", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8401), "Agakagan_Ozkok@yahoo.com", "Menekşe Sokak 47a, Tekirdağ, Haiti", "Esen", "Beşerler", "+90-145-166-11-75", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8401), 0m, "db6d7418-52c2-4eb2-8756-6d063106410a", 0m, "Garson", "1", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8402) },
                    { 36, "Sinop", "Gabon", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8538), "Abaka_Hakyemez34@gmail.com", "Ülkü Sokak 4, Erzincan, Çin", "Bayık", "Karadaş", "+90-253-278-9-300", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8539), 0m, "d9bdb59c-e188-410c-a95c-71da9b54b1f2", 0m, "Garson", "1", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8539) },
                    { 37, "Ardahan", "Paraguay", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8665), "Gokce.Ozdogan55@gmail.com", "Fatih Sokak  56, Bartın, Johnston Atoll, Amerika", "Çolpan", "Öymen", "+90-936-641-3-778", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8666), 0m, "fb978233-633e-4abe-aebd-611b7253cddc", 0m, "Garson", "1", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8666) },
                    { 38, "İçel (Mersin)", "Brunei", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8777), "Astalogul_Kunt55@hotmail.com", "Gül Sokak 911, Adana, Guatemala", "Begitutuk", "Gümüşpala", "+90-397-943-8-113", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8778), 0m, "ee888ac7-aa63-4edb-9849-9684e3b0eb6a", 0m, "Garson", "1", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8778) },
                    { 39, "Çankırı", "Belize", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8942), "Bazir.Yorulmaz29@yahoo.com", "Nalbant Sokak 962, Van, Hollanda", "Aykağan", "Çağıran", "+90-814-027-3-469", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8943), 0m, "47c30a54-ee91-4dd2-81e2-4efb74b785d3", 0m, "Garson", "0", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8943) },
                    { 40, "Kütahya", "Folkland Adaları, İngiltere", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(9076), "Altinkan.Hamzaoglu@hotmail.com", "Menekşe Sokak 159, Tokat, Porto Riko, Amerika", "Bilgetonyukuk", "Karabulut", "+90-414-265-47-83", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(9076), 0m, "59c50a95-87ac-4a43-8e6f-ea632a4386dc", 0m, "Garson", "0", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(9077) },
                    { 41, "Kırşehir", "Çin", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(9356), "Adikutlutas.Aclan@hotmail.com", "Oğuzhan Sokak 791, İzmir, Lübnan", "Böge", "Ayverdi", "+90-304-817-55-08", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(9356), 0m, "d068bde8-67a0-4971-8b9b-28c876b5cd72", 0m, "Garson", "0", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(9357) },
                    { 42, "Aydın", "Litvanya", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(9486), "Bukebuyrac77@hotmail.com", "Güven Yaka Sokak 02c, Gümüşhane, Somali", "Abar", "Tahincioğlu", "+90-991-190-27-95", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(9487), 0m, "fff67ec1-7ee4-4ebd-96de-196672b7e945", 0m, "Garson", "0", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(9487) },
                    { 43, "Tunceli", "Norveç", new DateTime(2025, 8, 8, 12, 57, 53, 94, DateTimeKind.Local).AddTicks(2554), "Alpertunga_Topcuoglu59@gmail.com", "Tevfik Fikret Caddesi 47, Ardahan, Kuzey İrlanda", "Armağan", "Doğan ", "+90-264-153-2-974", new DateTime(2025, 8, 8, 12, 57, 53, 94, DateTimeKind.Local).AddTicks(2558), 0m, "87eb72b8-2114-4c0b-8085-752eabed9c5c", 0m, "Elektrikçi", "0", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 94, DateTimeKind.Local).AddTicks(2558) },
                    { 44, "Tekirdağ", "İzlanda", new DateTime(2025, 8, 8, 12, 57, 53, 95, DateTimeKind.Local).AddTicks(4062), "Alpertunga_Akgul@yahoo.com", "Fatih Sokak  20b, Bolu, Gana", "Arslan", "Sepetçi", "+90-489-314-5-056", new DateTime(2025, 8, 8, 12, 57, 53, 95, DateTimeKind.Local).AddTicks(4066), 0m, "ac690689-136c-46ae-881b-371f4f1dee7c", 0m, "Bilgi İşlem Sorumlusu", "1", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 95, DateTimeKind.Local).AddTicks(4067) }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedDate", "DataStasus", "Description", "EntryDate", "Floor", "HasAirConditioning", "HasBalcony", "HasHairDryer", "HasMinibar", "HasTV", "HasWiFi", "ImageUrl", "MasterId", "PackageType", "PricePerNight", "RoomBreakfast", "RoomCapacity", "RoomNumber", "SelectedStatus", "Status", "Type", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 8, 8, 12, 57, 53, 9, DateTimeKind.Local).AddTicks(2398), 1, "Room 101 - Single, Floor 1", new DateTime(2025, 8, 8, 12, 57, 53, 9, DateTimeKind.Local).AddTicks(2405), 1, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "f795e9e1-8464-40b8-a7eb-3a30ba7baf94", 0, 100m, false, 1, 101, 0, 0, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 9, DateTimeKind.Local).AddTicks(2405) },
                    { 2, new DateTime(2025, 8, 8, 12, 57, 53, 10, DateTimeKind.Local).AddTicks(1894), 1, "Room 102 - Single, Floor 1", new DateTime(2025, 8, 8, 12, 57, 53, 10, DateTimeKind.Local).AddTicks(1896), 1, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "39abfcef-a3a4-4b15-8bc8-490cf32df06b", 0, 100m, false, 1, 102, 0, 0, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 10, DateTimeKind.Local).AddTicks(1897) },
                    { 3, new DateTime(2025, 8, 8, 12, 57, 53, 11, DateTimeKind.Local).AddTicks(1396), 1, "Room 103 - Single, Floor 1", new DateTime(2025, 8, 8, 12, 57, 53, 11, DateTimeKind.Local).AddTicks(1399), 1, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "236e5e4a-754d-4898-9cd3-a535a097303e", 0, 100m, false, 1, 103, 0, 0, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 11, DateTimeKind.Local).AddTicks(1400) },
                    { 4, new DateTime(2025, 8, 8, 12, 57, 53, 11, DateTimeKind.Local).AddTicks(9392), 1, "Room 104 - Single, Floor 1", new DateTime(2025, 8, 8, 12, 57, 53, 11, DateTimeKind.Local).AddTicks(9395), 1, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "74374b30-2552-46b4-aea6-eed685901b27", 0, 100m, false, 1, 104, 0, 0, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 11, DateTimeKind.Local).AddTicks(9396) },
                    { 5, new DateTime(2025, 8, 8, 12, 57, 53, 12, DateTimeKind.Local).AddTicks(9015), 1, "Room 105 - Single, Floor 1", new DateTime(2025, 8, 8, 12, 57, 53, 12, DateTimeKind.Local).AddTicks(9017), 1, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "b60a13b0-4db8-4da5-9fac-b873e554ed84", 0, 100m, false, 1, 105, 0, 0, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 12, DateTimeKind.Local).AddTicks(9017) },
                    { 6, new DateTime(2025, 8, 8, 12, 57, 53, 13, DateTimeKind.Local).AddTicks(8172), 1, "Room 106 - Single, Floor 1", new DateTime(2025, 8, 8, 12, 57, 53, 13, DateTimeKind.Local).AddTicks(8176), 1, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "ac9697b6-5cb0-4743-91c7-bd6860c7c247", 0, 100m, false, 1, 106, 0, 0, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 13, DateTimeKind.Local).AddTicks(8176) },
                    { 7, new DateTime(2025, 8, 8, 12, 57, 53, 14, DateTimeKind.Local).AddTicks(7032), 1, "Room 107 - Single, Floor 1", new DateTime(2025, 8, 8, 12, 57, 53, 14, DateTimeKind.Local).AddTicks(7033), 1, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "f355703c-a706-4068-8d52-18225eebc911", 0, 100m, false, 1, 107, 0, 0, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 14, DateTimeKind.Local).AddTicks(7034) },
                    { 8, new DateTime(2025, 8, 8, 12, 57, 53, 15, DateTimeKind.Local).AddTicks(9504), 1, "Room 108 - Single, Floor 1", new DateTime(2025, 8, 8, 12, 57, 53, 15, DateTimeKind.Local).AddTicks(9508), 1, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "76ac2fcd-77d7-437c-ae5a-d9d8b32268b1", 0, 100m, false, 1, 108, 0, 0, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 15, DateTimeKind.Local).AddTicks(9508) },
                    { 9, new DateTime(2025, 8, 8, 12, 57, 53, 26, DateTimeKind.Local).AddTicks(8075), 1, "Room 109 - Single, Floor 1", new DateTime(2025, 8, 8, 12, 57, 53, 26, DateTimeKind.Local).AddTicks(8085), 1, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "1d40b396-5c57-4b8f-8b9d-8d32879abeee", 0, 100m, false, 1, 109, 0, 0, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 26, DateTimeKind.Local).AddTicks(8086) },
                    { 10, new DateTime(2025, 8, 8, 12, 57, 53, 27, DateTimeKind.Local).AddTicks(8399), 1, "Room 110 - Single, Floor 1", new DateTime(2025, 8, 8, 12, 57, 53, 27, DateTimeKind.Local).AddTicks(8404), 1, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "fab16e72-8ef7-4342-be90-d1e2745fb554", 0, 100m, false, 1, 110, 0, 0, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 27, DateTimeKind.Local).AddTicks(8405) },
                    { 11, new DateTime(2025, 8, 8, 12, 57, 53, 29, DateTimeKind.Local).AddTicks(8006), 1, "Room 111 - Triple (3 single beds), Floor 1", new DateTime(2025, 8, 8, 12, 57, 53, 29, DateTimeKind.Local).AddTicks(8012), 1, true, false, true, true, true, true, "https://www.louisfitzgeraldhotel.com/wp-content/uploads/2020/03/hotel-louis-fitzgerald-082-1366x768-fp_mm-fpoff_0_0.jpg", "b500b60a-52d0-4b1e-9461-5a17f265b6c5", 1, 180m, false, 3, 111, 0, 0, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 29, DateTimeKind.Local).AddTicks(8013) },
                    { 12, new DateTime(2025, 8, 8, 12, 57, 53, 30, DateTimeKind.Local).AddTicks(8596), 1, "Room 112 - Triple (3 single beds), Floor 1", new DateTime(2025, 8, 8, 12, 57, 53, 30, DateTimeKind.Local).AddTicks(8600), 1, true, false, true, true, true, true, "https://www.louisfitzgeraldhotel.com/wp-content/uploads/2020/03/hotel-louis-fitzgerald-082-1366x768-fp_mm-fpoff_0_0.jpg", "bce7e30b-2215-4d8a-b827-01ddbccf8994", 1, 180m, false, 3, 112, 0, 0, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 30, DateTimeKind.Local).AddTicks(8601) },
                    { 13, new DateTime(2025, 8, 8, 12, 57, 53, 32, DateTimeKind.Local).AddTicks(973), 1, "Room 113 - Triple (3 single beds), Floor 1", new DateTime(2025, 8, 8, 12, 57, 53, 32, DateTimeKind.Local).AddTicks(979), 1, true, false, true, true, true, true, "https://www.louisfitzgeraldhotel.com/wp-content/uploads/2020/03/hotel-louis-fitzgerald-082-1366x768-fp_mm-fpoff_0_0.jpg", "2e673749-5a8a-47e5-8cc2-5a343de1d554", 1, 180m, false, 3, 113, 0, 0, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 32, DateTimeKind.Local).AddTicks(979) },
                    { 14, new DateTime(2025, 8, 8, 12, 57, 53, 32, DateTimeKind.Local).AddTicks(9108), 1, "Room 114 - Triple (3 single beds), Floor 1", new DateTime(2025, 8, 8, 12, 57, 53, 32, DateTimeKind.Local).AddTicks(9112), 1, true, false, true, true, true, true, "https://www.louisfitzgeraldhotel.com/wp-content/uploads/2020/03/hotel-louis-fitzgerald-082-1366x768-fp_mm-fpoff_0_0.jpg", "2a839ae5-a524-46db-a3e2-3d4eb20c77d7", 1, 180m, false, 3, 114, 0, 0, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 32, DateTimeKind.Local).AddTicks(9112) },
                    { 15, new DateTime(2025, 8, 8, 12, 57, 53, 33, DateTimeKind.Local).AddTicks(8308), 1, "Room 115 - Triple (3 single beds), Floor 1", new DateTime(2025, 8, 8, 12, 57, 53, 33, DateTimeKind.Local).AddTicks(8312), 1, true, false, true, true, true, true, "https://www.louisfitzgeraldhotel.com/wp-content/uploads/2020/03/hotel-louis-fitzgerald-082-1366x768-fp_mm-fpoff_0_0.jpg", "312e8e8a-23e0-4817-a281-10349458f67b", 1, 180m, false, 3, 115, 0, 0, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 33, DateTimeKind.Local).AddTicks(8313) },
                    { 16, new DateTime(2025, 8, 8, 12, 57, 53, 34, DateTimeKind.Local).AddTicks(8861), 1, "Room 116 - Triple (3 single beds), Floor 1", new DateTime(2025, 8, 8, 12, 57, 53, 34, DateTimeKind.Local).AddTicks(8865), 1, true, false, true, true, true, true, "https://www.louisfitzgeraldhotel.com/wp-content/uploads/2020/03/hotel-louis-fitzgerald-082-1366x768-fp_mm-fpoff_0_0.jpg", "032261cd-ee50-41cc-8011-10a5ae8f8b40", 1, 180m, false, 3, 116, 0, 0, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 34, DateTimeKind.Local).AddTicks(8865) },
                    { 17, new DateTime(2025, 8, 8, 12, 57, 53, 36, DateTimeKind.Local).AddTicks(2626), 1, "Room 117 - Triple (3 single beds), Floor 1", new DateTime(2025, 8, 8, 12, 57, 53, 36, DateTimeKind.Local).AddTicks(2631), 1, true, false, true, true, true, true, "https://www.louisfitzgeraldhotel.com/wp-content/uploads/2020/03/hotel-louis-fitzgerald-082-1366x768-fp_mm-fpoff_0_0.jpg", "42afceab-4cdb-4a0a-9911-f5241b9dae17", 1, 180m, false, 3, 117, 0, 0, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 36, DateTimeKind.Local).AddTicks(2632) },
                    { 18, new DateTime(2025, 8, 8, 12, 57, 53, 37, DateTimeKind.Local).AddTicks(993), 1, "Room 118 - Triple (3 single beds), Floor 1", new DateTime(2025, 8, 8, 12, 57, 53, 37, DateTimeKind.Local).AddTicks(996), 1, true, false, true, true, true, true, "https://www.louisfitzgeraldhotel.com/wp-content/uploads/2020/03/hotel-louis-fitzgerald-082-1366x768-fp_mm-fpoff_0_0.jpg", "7d13dbc1-b603-4eed-8dca-c653dae035cf", 1, 180m, false, 3, 118, 0, 0, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 37, DateTimeKind.Local).AddTicks(997) },
                    { 19, new DateTime(2025, 8, 8, 12, 57, 53, 37, DateTimeKind.Local).AddTicks(8524), 1, "Room 119 - Triple (3 single beds), Floor 1", new DateTime(2025, 8, 8, 12, 57, 53, 37, DateTimeKind.Local).AddTicks(8527), 1, true, false, true, true, true, true, "https://www.louisfitzgeraldhotel.com/wp-content/uploads/2020/03/hotel-louis-fitzgerald-082-1366x768-fp_mm-fpoff_0_0.jpg", "7710ed51-3d08-4c63-a54b-d51467f62ac8", 1, 180m, false, 3, 119, 0, 0, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 37, DateTimeKind.Local).AddTicks(8528) },
                    { 20, new DateTime(2025, 8, 8, 12, 57, 53, 38, DateTimeKind.Local).AddTicks(7369), 1, "Room 120 - Triple (3 single beds), Floor 1", new DateTime(2025, 8, 8, 12, 57, 53, 38, DateTimeKind.Local).AddTicks(7373), 1, true, false, true, true, true, true, "https://www.louisfitzgeraldhotel.com/wp-content/uploads/2020/03/hotel-louis-fitzgerald-082-1366x768-fp_mm-fpoff_0_0.jpg", "1818e7b6-ab17-4c16-a8c5-0e74ade34e19", 1, 180m, false, 3, 120, 0, 0, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 38, DateTimeKind.Local).AddTicks(7373) },
                    { 21, new DateTime(2025, 8, 8, 12, 57, 53, 39, DateTimeKind.Local).AddTicks(6875), 1, "Room 121 - Single, Floor 2", new DateTime(2025, 8, 8, 12, 57, 53, 39, DateTimeKind.Local).AddTicks(6878), 2, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "2a2dbcf9-5367-43a5-97b3-ad50123a6d68", 0, 110m, false, 1, 121, 0, 0, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 39, DateTimeKind.Local).AddTicks(6879) },
                    { 22, new DateTime(2025, 8, 8, 12, 57, 53, 40, DateTimeKind.Local).AddTicks(6137), 1, "Room 122 - Single, Floor 2", new DateTime(2025, 8, 8, 12, 57, 53, 40, DateTimeKind.Local).AddTicks(6140), 2, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "52807bff-97ed-4928-a76e-8fd730dec266", 0, 110m, false, 1, 122, 0, 0, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 40, DateTimeKind.Local).AddTicks(6140) },
                    { 23, new DateTime(2025, 8, 8, 12, 57, 53, 41, DateTimeKind.Local).AddTicks(5663), 1, "Room 123 - Single, Floor 2", new DateTime(2025, 8, 8, 12, 57, 53, 41, DateTimeKind.Local).AddTicks(5666), 2, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "4ca2a5ab-51b6-4ab7-bf20-1bfc2f5bd087", 0, 110m, false, 1, 123, 0, 0, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 41, DateTimeKind.Local).AddTicks(5667) },
                    { 24, new DateTime(2025, 8, 8, 12, 57, 53, 42, DateTimeKind.Local).AddTicks(4974), 1, "Room 124 - Single, Floor 2", new DateTime(2025, 8, 8, 12, 57, 53, 42, DateTimeKind.Local).AddTicks(4975), 2, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "c33a80e2-6e6c-41ac-9989-e2604fb75564", 0, 110m, false, 1, 124, 0, 0, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 42, DateTimeKind.Local).AddTicks(4976) },
                    { 25, new DateTime(2025, 8, 8, 12, 57, 53, 45, DateTimeKind.Local).AddTicks(3077), 1, "Room 125 - Single, Floor 2", new DateTime(2025, 8, 8, 12, 57, 53, 45, DateTimeKind.Local).AddTicks(3084), 2, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "1c85a1cf-1fd8-485a-b813-6eda80e699ce", 0, 110m, false, 1, 125, 0, 0, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 45, DateTimeKind.Local).AddTicks(3085) },
                    { 26, new DateTime(2025, 8, 8, 12, 57, 53, 46, DateTimeKind.Local).AddTicks(136), 1, "Room 126 - Single, Floor 2", new DateTime(2025, 8, 8, 12, 57, 53, 46, DateTimeKind.Local).AddTicks(139), 2, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "94c619a7-9b17-43aa-b928-c491e97ba1c1", 0, 110m, false, 1, 126, 0, 0, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 46, DateTimeKind.Local).AddTicks(139) },
                    { 27, new DateTime(2025, 8, 8, 12, 57, 53, 46, DateTimeKind.Local).AddTicks(6470), 1, "Room 127 - Single, Floor 2", new DateTime(2025, 8, 8, 12, 57, 53, 46, DateTimeKind.Local).AddTicks(6471), 2, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "f53b721f-db14-435f-8787-8bb5e51100b6", 0, 110m, false, 1, 127, 0, 0, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 46, DateTimeKind.Local).AddTicks(6471) },
                    { 28, new DateTime(2025, 8, 8, 12, 57, 53, 47, DateTimeKind.Local).AddTicks(3041), 1, "Room 128 - Single, Floor 2", new DateTime(2025, 8, 8, 12, 57, 53, 47, DateTimeKind.Local).AddTicks(3041), 2, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "a53de25c-0a99-4ae0-9f55-b20d648128db", 0, 110m, false, 1, 128, 0, 0, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 47, DateTimeKind.Local).AddTicks(3041) },
                    { 29, new DateTime(2025, 8, 8, 12, 57, 53, 47, DateTimeKind.Local).AddTicks(9760), 1, "Room 129 - Single, Floor 2", new DateTime(2025, 8, 8, 12, 57, 53, 47, DateTimeKind.Local).AddTicks(9762), 2, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "7917743c-c838-421b-b5cb-96f0c0cb325d", 0, 110m, false, 1, 129, 0, 0, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 47, DateTimeKind.Local).AddTicks(9763) },
                    { 30, new DateTime(2025, 8, 8, 12, 57, 53, 48, DateTimeKind.Local).AddTicks(5934), 1, "Room 130 - Single, Floor 2", new DateTime(2025, 8, 8, 12, 57, 53, 48, DateTimeKind.Local).AddTicks(5935), 2, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "da962b47-a23d-4cdd-a400-c744beeb4263", 0, 110m, false, 1, 130, 0, 0, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 48, DateTimeKind.Local).AddTicks(5935) },
                    { 31, new DateTime(2025, 8, 8, 12, 57, 53, 49, DateTimeKind.Local).AddTicks(2639), 1, "Room 131 - Double (2 single beds), Floor 2", new DateTime(2025, 8, 8, 12, 57, 53, 49, DateTimeKind.Local).AddTicks(2642), 2, true, false, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "7c4d3b6f-1e99-47af-8d42-f9934c0e0aad", 1, 150m, false, 2, 131, 0, 0, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 49, DateTimeKind.Local).AddTicks(2642) },
                    { 32, new DateTime(2025, 8, 8, 12, 57, 53, 50, DateTimeKind.Local).AddTicks(5965), 1, "Room 132 - Double (2 single beds), Floor 2", new DateTime(2025, 8, 8, 12, 57, 53, 50, DateTimeKind.Local).AddTicks(5969), 2, true, false, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "e6d5f2a3-f19a-408d-8bff-ad36e140001d", 1, 150m, false, 2, 132, 0, 0, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 50, DateTimeKind.Local).AddTicks(5969) },
                    { 33, new DateTime(2025, 8, 8, 12, 57, 53, 51, DateTimeKind.Local).AddTicks(2452), 1, "Room 133 - Double (2 single beds), Floor 2", new DateTime(2025, 8, 8, 12, 57, 53, 51, DateTimeKind.Local).AddTicks(2453), 2, true, false, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "1de98cde-d2f1-4df9-a615-c6cb1b7e4606", 1, 150m, false, 2, 133, 0, 0, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 51, DateTimeKind.Local).AddTicks(2453) },
                    { 34, new DateTime(2025, 8, 8, 12, 57, 53, 51, DateTimeKind.Local).AddTicks(8863), 1, "Room 134 - Double (2 single beds), Floor 2", new DateTime(2025, 8, 8, 12, 57, 53, 51, DateTimeKind.Local).AddTicks(8866), 2, true, false, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "0c5495df-79c7-421c-924a-822f675663ec", 1, 150m, false, 2, 134, 0, 0, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 51, DateTimeKind.Local).AddTicks(8867) },
                    { 35, new DateTime(2025, 8, 8, 12, 57, 53, 52, DateTimeKind.Local).AddTicks(5228), 1, "Room 135 - Double (2 single beds), Floor 2", new DateTime(2025, 8, 8, 12, 57, 53, 52, DateTimeKind.Local).AddTicks(5229), 2, true, false, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "91fc2784-359f-4501-9976-b51cc1f0d40b", 1, 150m, false, 2, 135, 0, 0, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 52, DateTimeKind.Local).AddTicks(5229) },
                    { 36, new DateTime(2025, 8, 8, 12, 57, 53, 53, DateTimeKind.Local).AddTicks(1546), 1, "Room 136 - Double (2 single beds), Floor 2", new DateTime(2025, 8, 8, 12, 57, 53, 53, DateTimeKind.Local).AddTicks(1547), 2, true, false, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "ddba2f2a-1ea9-48ce-aff5-66a4b862f23a", 1, 150m, false, 2, 136, 0, 0, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 53, DateTimeKind.Local).AddTicks(1547) },
                    { 37, new DateTime(2025, 8, 8, 12, 57, 53, 53, DateTimeKind.Local).AddTicks(7934), 1, "Room 137 - Double (2 single beds), Floor 2", new DateTime(2025, 8, 8, 12, 57, 53, 53, DateTimeKind.Local).AddTicks(7937), 2, true, false, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "58f1d12d-8f0f-4db8-b101-4997f7fa2958", 1, 150m, false, 2, 137, 0, 0, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 53, DateTimeKind.Local).AddTicks(7938) },
                    { 38, new DateTime(2025, 8, 8, 12, 57, 53, 54, DateTimeKind.Local).AddTicks(4336), 1, "Room 138 - Double (2 single beds), Floor 2", new DateTime(2025, 8, 8, 12, 57, 53, 54, DateTimeKind.Local).AddTicks(4337), 2, true, false, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "d9b89f55-049d-41a1-8828-acd36b093549", 1, 150m, false, 2, 138, 0, 0, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 54, DateTimeKind.Local).AddTicks(4337) },
                    { 39, new DateTime(2025, 8, 8, 12, 57, 53, 55, DateTimeKind.Local).AddTicks(764), 1, "Room 139 - Double (2 single beds), Floor 2", new DateTime(2025, 8, 8, 12, 57, 53, 55, DateTimeKind.Local).AddTicks(765), 2, true, false, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "e121dbbd-8296-4292-aa24-0f49a604c677", 1, 150m, false, 2, 139, 0, 0, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 55, DateTimeKind.Local).AddTicks(765) },
                    { 40, new DateTime(2025, 8, 8, 12, 57, 53, 55, DateTimeKind.Local).AddTicks(7138), 1, "Room 140 - Double (2 single beds), Floor 2", new DateTime(2025, 8, 8, 12, 57, 53, 55, DateTimeKind.Local).AddTicks(7141), 2, true, false, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "f6a944a8-fd79-4303-8841-794c9b8e44ab", 1, 150m, false, 2, 140, 0, 0, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 55, DateTimeKind.Local).AddTicks(7141) },
                    { 41, new DateTime(2025, 8, 8, 12, 57, 53, 59, DateTimeKind.Local).AddTicks(493), 1, "Room 141 - Double (double bed), Floor 3", new DateTime(2025, 8, 8, 12, 57, 53, 59, DateTimeKind.Local).AddTicks(499), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "5fda8e39-7a6c-4ecf-91a5-02f9cd828f6b", 1, 170m, true, 2, 141, 0, 0, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 59, DateTimeKind.Local).AddTicks(500) },
                    { 42, new DateTime(2025, 8, 8, 12, 57, 53, 60, DateTimeKind.Local).AddTicks(2181), 1, "Room 142 - Double (double bed), Floor 3", new DateTime(2025, 8, 8, 12, 57, 53, 60, DateTimeKind.Local).AddTicks(2186), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "d1b638a5-d7bb-4058-b03d-f537a095b0af", 1, 170m, true, 2, 142, 0, 0, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 60, DateTimeKind.Local).AddTicks(2187) },
                    { 43, new DateTime(2025, 8, 8, 12, 57, 53, 61, DateTimeKind.Local).AddTicks(1514), 1, "Room 143 - Double (double bed), Floor 3", new DateTime(2025, 8, 8, 12, 57, 53, 61, DateTimeKind.Local).AddTicks(1516), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "b1f78d20-eb83-434e-95a1-352a588b09e8", 1, 170m, true, 2, 143, 0, 0, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 61, DateTimeKind.Local).AddTicks(1517) },
                    { 44, new DateTime(2025, 8, 8, 12, 57, 53, 62, DateTimeKind.Local).AddTicks(901), 1, "Room 144 - Double (double bed), Floor 3", new DateTime(2025, 8, 8, 12, 57, 53, 62, DateTimeKind.Local).AddTicks(904), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "4a45de28-d911-4813-b595-b410e0c5871d", 1, 170m, true, 2, 144, 0, 0, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 62, DateTimeKind.Local).AddTicks(905) },
                    { 45, new DateTime(2025, 8, 8, 12, 57, 53, 63, DateTimeKind.Local).AddTicks(111), 1, "Room 145 - Double (double bed), Floor 3", new DateTime(2025, 8, 8, 12, 57, 53, 63, DateTimeKind.Local).AddTicks(113), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "c277158e-71e8-40d1-bcbd-aa37aba9182f", 1, 170m, true, 2, 145, 0, 0, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 63, DateTimeKind.Local).AddTicks(114) },
                    { 46, new DateTime(2025, 8, 8, 12, 57, 53, 64, DateTimeKind.Local).AddTicks(4611), 1, "Room 146 - Double (double bed), Floor 3", new DateTime(2025, 8, 8, 12, 57, 53, 64, DateTimeKind.Local).AddTicks(4614), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "6b301c82-7f04-4322-9117-075f3b916f2a", 1, 170m, true, 2, 146, 0, 0, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 64, DateTimeKind.Local).AddTicks(4615) },
                    { 47, new DateTime(2025, 8, 8, 12, 57, 53, 65, DateTimeKind.Local).AddTicks(1164), 1, "Room 147 - Double (double bed), Floor 3", new DateTime(2025, 8, 8, 12, 57, 53, 65, DateTimeKind.Local).AddTicks(1165), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "52e5e702-20f9-4d90-a80b-5f384478975e", 1, 170m, true, 2, 147, 0, 0, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 65, DateTimeKind.Local).AddTicks(1165) },
                    { 48, new DateTime(2025, 8, 8, 12, 57, 53, 65, DateTimeKind.Local).AddTicks(7590), 1, "Room 148 - Double (double bed), Floor 3", new DateTime(2025, 8, 8, 12, 57, 53, 65, DateTimeKind.Local).AddTicks(7593), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "563f41b9-fcaf-47db-b799-70be164480cf", 1, 170m, true, 2, 148, 0, 0, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 65, DateTimeKind.Local).AddTicks(7594) },
                    { 49, new DateTime(2025, 8, 8, 12, 57, 53, 66, DateTimeKind.Local).AddTicks(4112), 1, "Room 149 - Double (double bed), Floor 3", new DateTime(2025, 8, 8, 12, 57, 53, 66, DateTimeKind.Local).AddTicks(4113), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "ab82d2b7-52d5-4d38-9cc9-2412d35868e8", 1, 170m, true, 2, 149, 0, 0, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 66, DateTimeKind.Local).AddTicks(4113) },
                    { 50, new DateTime(2025, 8, 8, 12, 57, 53, 67, DateTimeKind.Local).AddTicks(534), 1, "Room 150 - Double (double bed), Floor 3", new DateTime(2025, 8, 8, 12, 57, 53, 67, DateTimeKind.Local).AddTicks(534), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "ff6b5802-ced6-4d12-a63e-3616b5cd4772", 1, 170m, true, 2, 150, 0, 0, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 67, DateTimeKind.Local).AddTicks(535) },
                    { 51, new DateTime(2025, 8, 8, 12, 57, 53, 67, DateTimeKind.Local).AddTicks(6907), 1, "Room 151 - Triple (1 double, 1 single), Floor 3", new DateTime(2025, 8, 8, 12, 57, 53, 67, DateTimeKind.Local).AddTicks(6909), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "066564c1-a5c0-4302-a460-9aa2f8208ee9", 1, 200m, true, 3, 151, 0, 0, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 67, DateTimeKind.Local).AddTicks(6910) },
                    { 52, new DateTime(2025, 8, 8, 12, 57, 53, 68, DateTimeKind.Local).AddTicks(3374), 1, "Room 152 - Triple (1 double, 1 single), Floor 3", new DateTime(2025, 8, 8, 12, 57, 53, 68, DateTimeKind.Local).AddTicks(3375), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "275007a8-74e8-45c0-9561-e9676bc6e16b", 1, 200m, true, 3, 152, 0, 0, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 68, DateTimeKind.Local).AddTicks(3375) },
                    { 53, new DateTime(2025, 8, 8, 12, 57, 53, 68, DateTimeKind.Local).AddTicks(9709), 1, "Room 153 - Triple (1 double, 1 single), Floor 3", new DateTime(2025, 8, 8, 12, 57, 53, 68, DateTimeKind.Local).AddTicks(9710), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "ab01ec16-f6ed-43a5-b9cd-7592ac8a2f34", 1, 200m, true, 3, 153, 0, 0, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 68, DateTimeKind.Local).AddTicks(9710) },
                    { 54, new DateTime(2025, 8, 8, 12, 57, 53, 69, DateTimeKind.Local).AddTicks(5757), 1, "Room 154 - Triple (1 double, 1 single), Floor 3", new DateTime(2025, 8, 8, 12, 57, 53, 69, DateTimeKind.Local).AddTicks(5758), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "a89176c0-5f8c-48b4-bdb9-256994afe06d", 1, 200m, true, 3, 154, 0, 0, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 69, DateTimeKind.Local).AddTicks(5758) },
                    { 55, new DateTime(2025, 8, 8, 12, 57, 53, 70, DateTimeKind.Local).AddTicks(2368), 1, "Room 155 - Triple (1 double, 1 single), Floor 3", new DateTime(2025, 8, 8, 12, 57, 53, 70, DateTimeKind.Local).AddTicks(2372), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "d14d6511-884e-40c9-8d8a-240286d4fab3", 1, 200m, true, 3, 155, 0, 0, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 70, DateTimeKind.Local).AddTicks(2372) },
                    { 56, new DateTime(2025, 8, 8, 12, 57, 53, 71, DateTimeKind.Local).AddTicks(4137), 1, "Room 156 - Triple (1 double, 1 single), Floor 3", new DateTime(2025, 8, 8, 12, 57, 53, 71, DateTimeKind.Local).AddTicks(4142), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "c24cc6c8-d33e-4455-8e76-8defe7a59a14", 1, 200m, true, 3, 156, 0, 0, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 71, DateTimeKind.Local).AddTicks(4143) },
                    { 57, new DateTime(2025, 8, 8, 12, 57, 53, 72, DateTimeKind.Local).AddTicks(7276), 1, "Room 157 - Triple (1 double, 1 single), Floor 3", new DateTime(2025, 8, 8, 12, 57, 53, 72, DateTimeKind.Local).AddTicks(7282), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "8f577f5a-e4a5-4d43-b7d1-47d2c00b076d", 1, 200m, true, 3, 157, 0, 0, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 72, DateTimeKind.Local).AddTicks(7282) },
                    { 58, new DateTime(2025, 8, 8, 12, 57, 53, 73, DateTimeKind.Local).AddTicks(3947), 1, "Room 158 - Triple (1 double, 1 single), Floor 3", new DateTime(2025, 8, 8, 12, 57, 53, 73, DateTimeKind.Local).AddTicks(3948), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "b5c71b98-6f92-4550-a154-0618bd249163", 1, 200m, true, 3, 158, 0, 0, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 73, DateTimeKind.Local).AddTicks(3948) },
                    { 59, new DateTime(2025, 8, 8, 12, 57, 53, 74, DateTimeKind.Local).AddTicks(629), 1, "Room 159 - Triple (1 double, 1 single), Floor 3", new DateTime(2025, 8, 8, 12, 57, 53, 74, DateTimeKind.Local).AddTicks(632), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "ff6b98f7-66b2-4620-a020-c3f7d61211bc", 1, 200m, true, 3, 159, 0, 0, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 74, DateTimeKind.Local).AddTicks(633) },
                    { 60, new DateTime(2025, 8, 8, 12, 57, 53, 74, DateTimeKind.Local).AddTicks(6753), 1, "Room 160 - Triple (1 double, 1 single), Floor 3", new DateTime(2025, 8, 8, 12, 57, 53, 74, DateTimeKind.Local).AddTicks(6754), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "00429214-708d-49af-91e5-07812d476294", 1, 200m, true, 3, 160, 0, 0, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 74, DateTimeKind.Local).AddTicks(6755) },
                    { 61, new DateTime(2025, 8, 8, 12, 57, 53, 75, DateTimeKind.Local).AddTicks(3959), 1, "Room 161 - Double (double bed), Floor 4", new DateTime(2025, 8, 8, 12, 57, 53, 75, DateTimeKind.Local).AddTicks(3962), 4, true, true, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "386e5985-6a82-425c-ba9f-21d71d587a9f", 1, 180m, true, 2, 161, 0, 0, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 75, DateTimeKind.Local).AddTicks(3962) },
                    { 62, new DateTime(2025, 8, 8, 12, 57, 53, 76, DateTimeKind.Local).AddTicks(297), 1, "Room 162 - Double (double bed), Floor 4", new DateTime(2025, 8, 8, 12, 57, 53, 76, DateTimeKind.Local).AddTicks(297), 4, true, true, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "c97d7788-9fa9-4e82-a081-19e8705e0792", 1, 180m, true, 2, 162, 0, 0, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 76, DateTimeKind.Local).AddTicks(298) },
                    { 63, new DateTime(2025, 8, 8, 12, 57, 53, 76, DateTimeKind.Local).AddTicks(6288), 1, "Room 163 - Double (double bed), Floor 4", new DateTime(2025, 8, 8, 12, 57, 53, 76, DateTimeKind.Local).AddTicks(6289), 4, true, true, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "e404e774-515f-41c6-9138-b2962cc755a5", 1, 180m, true, 2, 163, 0, 0, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 76, DateTimeKind.Local).AddTicks(6289) },
                    { 64, new DateTime(2025, 8, 8, 12, 57, 53, 77, DateTimeKind.Local).AddTicks(3858), 1, "Room 164 - Double (double bed), Floor 4", new DateTime(2025, 8, 8, 12, 57, 53, 77, DateTimeKind.Local).AddTicks(3862), 4, true, true, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "c461b6b0-cd20-45d5-8934-018597bc2ee1", 1, 180m, true, 2, 164, 0, 0, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 77, DateTimeKind.Local).AddTicks(3862) },
                    { 65, new DateTime(2025, 8, 8, 12, 57, 53, 78, DateTimeKind.Local).AddTicks(3868), 1, "Room 165 - Double (double bed), Floor 4", new DateTime(2025, 8, 8, 12, 57, 53, 78, DateTimeKind.Local).AddTicks(3871), 4, true, true, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "692ab4f7-6a35-48f0-8b91-aaa2b006e7ff", 1, 180m, true, 2, 165, 0, 0, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 78, DateTimeKind.Local).AddTicks(3872) },
                    { 66, new DateTime(2025, 8, 8, 12, 57, 53, 79, DateTimeKind.Local).AddTicks(758), 1, "Room 166 - Double (double bed), Floor 4", new DateTime(2025, 8, 8, 12, 57, 53, 79, DateTimeKind.Local).AddTicks(761), 4, true, true, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "d5ae7bb9-c8a0-4db1-981d-460a34877c7c", 1, 180m, true, 2, 166, 0, 0, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 79, DateTimeKind.Local).AddTicks(761) },
                    { 67, new DateTime(2025, 8, 8, 12, 57, 53, 79, DateTimeKind.Local).AddTicks(6734), 1, "Room 167 - Double (double bed), Floor 4", new DateTime(2025, 8, 8, 12, 57, 53, 79, DateTimeKind.Local).AddTicks(6735), 4, true, true, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "908447ba-4f42-41e2-bba5-f1991cb51766", 1, 180m, true, 2, 167, 0, 0, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 79, DateTimeKind.Local).AddTicks(6735) },
                    { 68, new DateTime(2025, 8, 8, 12, 57, 53, 80, DateTimeKind.Local).AddTicks(3043), 1, "Room 168 - Double (double bed), Floor 4", new DateTime(2025, 8, 8, 12, 57, 53, 80, DateTimeKind.Local).AddTicks(3044), 4, true, true, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "7ad15694-3c86-414f-9a7b-185c00cb235d", 1, 180m, true, 2, 168, 0, 0, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 80, DateTimeKind.Local).AddTicks(3044) },
                    { 69, new DateTime(2025, 8, 8, 12, 57, 53, 80, DateTimeKind.Local).AddTicks(9665), 1, "Room 169 - Double (double bed), Floor 4", new DateTime(2025, 8, 8, 12, 57, 53, 80, DateTimeKind.Local).AddTicks(9668), 4, true, true, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "dac14300-bc30-4cab-ae67-0df446117118", 1, 180m, true, 2, 169, 0, 0, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 80, DateTimeKind.Local).AddTicks(9669) },
                    { 70, new DateTime(2025, 8, 8, 12, 57, 53, 81, DateTimeKind.Local).AddTicks(5751), 1, "Room 170 - Double (double bed), Floor 4", new DateTime(2025, 8, 8, 12, 57, 53, 81, DateTimeKind.Local).AddTicks(5751), 4, true, true, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "572124e8-f735-4552-9301-82c1921935dd", 1, 180m, true, 2, 170, 0, 0, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 81, DateTimeKind.Local).AddTicks(5752) },
                    { 71, new DateTime(2025, 8, 8, 12, 57, 53, 82, DateTimeKind.Local).AddTicks(2066), 1, "Room 171 - Quad (1 double, 2 single), Floor 4", new DateTime(2025, 8, 8, 12, 57, 53, 82, DateTimeKind.Local).AddTicks(2067), 4, true, true, true, true, true, true, "https://setarehhotel.com/wp-content/uploads/2018/03/QuadRoom01.jpg", "dd60eb81-c3ae-4cbb-b979-861688fc975d", 1, 250m, true, 4, 171, 0, 0, 3, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 82, DateTimeKind.Local).AddTicks(2067) },
                    { 72, new DateTime(2025, 8, 8, 12, 57, 53, 82, DateTimeKind.Local).AddTicks(8381), 1, "Room 172 - Quad (1 double, 2 single), Floor 4", new DateTime(2025, 8, 8, 12, 57, 53, 82, DateTimeKind.Local).AddTicks(8384), 4, true, true, true, true, true, true, "https://setarehhotel.com/wp-content/uploads/2018/03/QuadRoom01.jpg", "55a7842d-8365-4241-add1-1810e573df4d", 1, 250m, true, 4, 172, 0, 0, 3, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 82, DateTimeKind.Local).AddTicks(8384) },
                    { 73, new DateTime(2025, 8, 8, 12, 57, 53, 83, DateTimeKind.Local).AddTicks(8482), 1, "Room 173 - Quad (1 double, 2 single), Floor 4", new DateTime(2025, 8, 8, 12, 57, 53, 83, DateTimeKind.Local).AddTicks(8483), 4, true, true, true, true, true, true, "https://setarehhotel.com/wp-content/uploads/2018/03/QuadRoom01.jpg", "b9f5b6fa-2150-4773-a3f5-e38cf4b7a322", 1, 250m, true, 4, 173, 0, 0, 3, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 83, DateTimeKind.Local).AddTicks(8484) },
                    { 74, new DateTime(2025, 8, 8, 12, 57, 53, 84, DateTimeKind.Local).AddTicks(8712), 1, "Room 174 - Quad (1 double, 2 single), Floor 4", new DateTime(2025, 8, 8, 12, 57, 53, 84, DateTimeKind.Local).AddTicks(8715), 4, true, true, true, true, true, true, "https://setarehhotel.com/wp-content/uploads/2018/03/QuadRoom01.jpg", "4ec0317e-8e5c-4ec8-ac90-596abc7e38e0", 1, 250m, true, 4, 174, 0, 0, 3, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 84, DateTimeKind.Local).AddTicks(8715) },
                    { 75, new DateTime(2025, 8, 8, 12, 57, 53, 85, DateTimeKind.Local).AddTicks(5383), 1, "Room 175 - Quad (1 double, 2 single), Floor 4", new DateTime(2025, 8, 8, 12, 57, 53, 85, DateTimeKind.Local).AddTicks(5384), 4, true, true, true, true, true, true, "https://setarehhotel.com/wp-content/uploads/2018/03/QuadRoom01.jpg", "77d037ed-bb70-4da4-bfe6-b903d881fda1", 1, 250m, true, 4, 175, 0, 0, 3, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 85, DateTimeKind.Local).AddTicks(5384) },
                    { 76, new DateTime(2025, 8, 8, 12, 57, 53, 86, DateTimeKind.Local).AddTicks(1733), 1, "Room 176 - Quad (1 double, 2 single), Floor 4", new DateTime(2025, 8, 8, 12, 57, 53, 86, DateTimeKind.Local).AddTicks(1733), 4, true, true, true, true, true, true, "https://setarehhotel.com/wp-content/uploads/2018/03/QuadRoom01.jpg", "eebb5929-7c82-4af1-8d83-1391b1608706", 1, 250m, true, 4, 176, 0, 0, 3, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 86, DateTimeKind.Local).AddTicks(1734) },
                    { 77, new DateTime(2025, 8, 8, 12, 57, 53, 86, DateTimeKind.Local).AddTicks(8100), 1, "Room 177 - King Suite, Floor 4", new DateTime(2025, 8, 8, 12, 57, 53, 86, DateTimeKind.Local).AddTicks(8103), 4, true, true, true, true, true, true, "https://calista.com.tr/media/xaug4yos/calista-resort-hotel-blog-king-suit-banner.jpg", "c53108a1-cb44-4085-8cb3-ffc2d11bd5b9", 1, 500m, true, 5, 177, 0, 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 86, DateTimeKind.Local).AddTicks(8104) }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "PackageType", "PaymentMethod", "ReservationStatus", "RoomId", "SelectedStatus", "TotalAmount", "UpdatedComputerName", "UpdatedDate", "status" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 11, 23, 0, 3, 18, 211, DateTimeKind.Local).AddTicks(7245), new DateTime(2026, 9, 1, 20, 0, 22, 403, DateTimeKind.Local).AddTicks(127), new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(8816), 4, new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(8817), "d8622786-7268-449d-9cd1-878c07291ee7", 0, 0, 0, 2, 0, 2213.45m, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(8818), 0 },
                    { 2, new DateTime(2026, 8, 2, 6, 55, 16, 377, DateTimeKind.Local).AddTicks(8330), new DateTime(2027, 7, 6, 3, 36, 23, 241, DateTimeKind.Local).AddTicks(9008), new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9228), 10, new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9228), "7822f192-033a-4e88-a3a6-ef6a8b4bcd56", 1, 1, 1, 34, 0, 1959.22m, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9229), 1 },
                    { 3, new DateTime(2026, 5, 3, 21, 55, 28, 40, DateTimeKind.Local).AddTicks(6156), new DateTime(2026, 8, 8, 20, 43, 16, 8, DateTimeKind.Local).AddTicks(2163), new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9331), 5, new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9331), "7aa31c93-de45-4aff-b022-2c378161ca9f", 0, 2, 2, 44, 0, 1589.91m, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9331), 2 },
                    { 4, new DateTime(2025, 9, 29, 17, 50, 25, 386, DateTimeKind.Local).AddTicks(7402), new DateTime(2026, 1, 20, 5, 56, 5, 117, DateTimeKind.Local).AddTicks(5507), new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9357), 3, new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9357), "79ce297d-cbe7-48c3-ae6c-a1b8ddc25aef", 1, 0, 0, 38, 0, 1710.44m, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9357), 3 },
                    { 5, new DateTime(2026, 3, 10, 3, 38, 38, 730, DateTimeKind.Local).AddTicks(3260), new DateTime(2027, 3, 4, 9, 44, 10, 473, DateTimeKind.Local).AddTicks(7695), new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9382), 5, new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9382), "cf3b33c0-dea4-419d-a8f1-773c674979b2", 0, 1, 1, 16, 0, 1733.10m, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9382), 4 },
                    { 6, new DateTime(2025, 9, 24, 6, 14, 4, 312, DateTimeKind.Local).AddTicks(9562), new DateTime(2026, 4, 22, 15, 40, 3, 431, DateTimeKind.Local).AddTicks(6105), new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9407), 3, new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9407), "4af55c3e-5c95-4a93-9367-7789d6e1d800", 1, 2, 2, 18, 0, 1567.47m, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9407), 0 },
                    { 7, new DateTime(2026, 5, 25, 12, 37, 34, 600, DateTimeKind.Local).AddTicks(4344), new DateTime(2026, 6, 15, 18, 4, 51, 620, DateTimeKind.Local).AddTicks(5389), new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9432), 10, new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9433), "f2fa75f5-06b9-464d-8a3e-e18e227307de", 0, 0, 0, 20, 0, 2326.20m, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9433), 1 },
                    { 8, new DateTime(2026, 3, 16, 2, 23, 9, 678, DateTimeKind.Local).AddTicks(4791), new DateTime(2026, 10, 5, 12, 26, 4, 244, DateTimeKind.Local).AddTicks(6009), new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9457), 10, new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9458), "6463386a-4c23-49c9-91c9-352d65f5b774", 1, 1, 1, 44, 0, 2101.44m, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9458), 2 },
                    { 9, new DateTime(2026, 6, 5, 0, 18, 10, 614, DateTimeKind.Local).AddTicks(5153), new DateTime(2027, 1, 28, 20, 22, 49, 612, DateTimeKind.Local).AddTicks(5385), new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9483), 7, new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9484), "723081e6-13b8-46c4-9978-f3ab35c2f43f", 0, 2, 2, 17, 0, 1805.58m, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9484), 3 },
                    { 10, new DateTime(2026, 6, 23, 21, 22, 21, 950, DateTimeKind.Local).AddTicks(5238), new DateTime(2027, 3, 29, 6, 23, 5, 898, DateTimeKind.Local).AddTicks(7493), new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9509), 5, new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9509), "e6645de4-d0aa-4155-9f47-a3b6561c9712", 1, 0, 0, 43, 0, 1635.22m, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9510), 4 }
                });

            migrationBuilder.InsertData(
                table: "Shifts",
                columns: new[] { "Id", "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "SelectedStatus", "ShiftDate", "ShiftType", "StartTime", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(15), 1, new DateTime(2025, 8, 8, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(16), "100dbc27-8d1f-41bb-b0e5-a57ba0fe08ca", 0, new DateTime(2025, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 8, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(16) },
                    { 2, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(33), 2, new DateTime(2025, 8, 8, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(34), "4f9587bb-f75b-42c1-ad0a-be2f3ede502c", 0, new DateTime(2025, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 8, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(34) },
                    { 3, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(39), 3, new DateTime(2025, 8, 8, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(39), "3df4ded6-c9f8-4558-aefc-c654843aadda", 0, new DateTime(2025, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 8, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(39) },
                    { 4, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(44), 4, new DateTime(2025, 8, 8, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(44), "401cb937-c797-49d5-b9b4-9536ef869ada", 0, new DateTime(2025, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 8, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(44) },
                    { 5, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(52), 1, new DateTime(2025, 8, 9, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(52), "dac1e9d8-94bc-4b58-a44d-3c28c91e53e5", 0, new DateTime(2025, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 9, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(53) },
                    { 6, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(57), 2, new DateTime(2025, 8, 9, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(58), "35c1b88b-1f52-4a3b-b66f-8c8fd899d03d", 0, new DateTime(2025, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 9, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(58) },
                    { 7, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(62), 3, new DateTime(2025, 8, 9, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(63), "9397e890-81d4-4a10-b4b7-6d3b4bdd0912", 0, new DateTime(2025, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 9, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(63) },
                    { 8, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(70), 4, new DateTime(2025, 8, 9, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(71), "adea4366-fb8c-4b80-aa96-2e92732638ca", 0, new DateTime(2025, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 9, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(71) },
                    { 9, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(78), 2, new DateTime(2025, 8, 10, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(79), "ab45fd2c-f71b-498f-bad1-d8c089d80fa9", 0, new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 10, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(79) },
                    { 10, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(84), 3, new DateTime(2025, 8, 10, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(84), "5de56dc1-30e9-401c-900b-3fd395ce0968", 0, new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 10, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(84) },
                    { 11, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(88), 4, new DateTime(2025, 8, 10, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(88), "48f7772f-1ef1-472e-a598-bbb24e178c0c", 0, new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 10, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(89) },
                    { 12, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(92), 5, new DateTime(2025, 8, 10, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(93), "6c889334-8807-4794-b9b0-beda163c196f", 0, new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 10, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(93) },
                    { 13, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(99), 1, new DateTime(2025, 8, 11, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(99), "0ca7ffc8-43c7-466c-9360-2288a5058051", 0, new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 11, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(99) },
                    { 14, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(104), 3, new DateTime(2025, 8, 11, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(104), "fd988c3a-4a46-4332-b8a9-a99fbb926460", 0, new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 11, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(104) },
                    { 15, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(108), 4, new DateTime(2025, 8, 11, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(108), "80edb942-f006-4bf5-b50f-097284e37147", 0, new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 11, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(109) },
                    { 16, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(114), 5, new DateTime(2025, 8, 11, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(114), "3032fb80-86a4-4bf9-96b6-dd5cfe9e9d98", 0, new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 11, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(114) },
                    { 17, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(120), 1, new DateTime(2025, 8, 12, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(120), "3a9f6b4c-0a85-4be6-abcd-4de67b936f04", 0, new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 12, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(120) },
                    { 18, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(125), 2, new DateTime(2025, 8, 12, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(125), "c731cf9b-d199-4b52-8159-cd0e2baf8af7", 0, new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 12, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(125) },
                    { 19, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(130), 4, new DateTime(2025, 8, 12, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(130), "33ecc0f2-dee4-4dae-8f59-c787d45da354", 0, new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 12, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(130) },
                    { 20, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(134), 5, new DateTime(2025, 8, 12, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(134), "45d9cda4-7344-44d4-a584-6a14ed04473d", 0, new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 12, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(135) },
                    { 21, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(141), 1, new DateTime(2025, 8, 13, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(141), "9fe054ed-8728-4c92-a5d0-7988963f9500", 0, new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 13, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(141) },
                    { 22, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(149), 2, new DateTime(2025, 8, 13, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(150), "5dbf14ba-cd24-4ce1-a6dc-ca35c73e6b96", 0, new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 13, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(150) },
                    { 23, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(155), 3, new DateTime(2025, 8, 13, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(155), "15bdb9d3-932a-4a04-825b-945d3683caa7", 0, new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 13, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(155) },
                    { 24, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(161), 5, new DateTime(2025, 8, 13, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(161), "70605f49-c23c-445b-921f-d15c008a2900", 0, new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 13, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(161) },
                    { 25, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(167), 1, new DateTime(2025, 8, 14, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(167), "4b39fa17-a27a-4316-9eb7-699216d73b5b", 0, new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 14, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(168) },
                    { 26, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(172), 2, new DateTime(2025, 8, 14, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(172), "dd505076-2033-456d-ae60-28f29e76d2a1", 0, new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 14, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(172) },
                    { 27, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(176), 3, new DateTime(2025, 8, 14, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(176), "889d70cc-aa7b-4ffd-a38a-09e7ae2d97ac", 0, new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 14, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(177) },
                    { 28, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(180), 4, new DateTime(2025, 8, 14, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(181), "18f65640-d47a-44cc-9b98-4fb649922291", 0, new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 14, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(181) },
                    { 29, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(189), 8, new DateTime(2025, 8, 8, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(190), "8dd6b16e-e7ba-4dca-8280-70caf3513d69", 0, new DateTime(2025, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 8, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(190) },
                    { 30, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(195), 8, new DateTime(2025, 8, 8, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(195), "774391aa-f85e-4529-a296-7d7e63208c53", 0, new DateTime(2025, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 8, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(196) },
                    { 31, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(200), 9, new DateTime(2025, 8, 8, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(200), "1b9e3483-ba57-4afa-b933-7698727f3760", 0, new DateTime(2025, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 8, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(201) },
                    { 32, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(206), 9, new DateTime(2025, 8, 8, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(206), "9a387171-d16c-43e5-95b5-d07434ace63e", 0, new DateTime(2025, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 8, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(206) },
                    { 33, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(211), 10, new DateTime(2025, 8, 8, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(211), "402665bf-9bd4-4403-affa-127a897b0c2d", 0, new DateTime(2025, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 8, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(212) },
                    { 34, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(216), 10, new DateTime(2025, 8, 8, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(216), "b9bf8da8-b100-48dd-8419-2482fe1a2d83", 0, new DateTime(2025, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 8, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(217) },
                    { 35, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(221), 8, new DateTime(2025, 8, 9, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(222), "97ae99fd-61f6-4184-b64a-4ed431ed1ded", 0, new DateTime(2025, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 9, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(222) },
                    { 36, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(226), 8, new DateTime(2025, 8, 9, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(226), "5fab67cb-6050-4785-9d06-8c4b907fe320", 0, new DateTime(2025, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 9, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(226) },
                    { 37, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(230), 9, new DateTime(2025, 8, 9, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(230), "00a678a4-29fe-4c20-a5e8-05feb790da7d", 0, new DateTime(2025, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 9, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(231) },
                    { 38, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(234), 9, new DateTime(2025, 8, 9, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(234), "c6473e53-cee9-40a7-aedf-5cc1e8b0cc2c", 0, new DateTime(2025, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 9, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(235) },
                    { 39, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(238), 10, new DateTime(2025, 8, 9, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(239), "8c578426-c5a0-4f4a-8b9a-7836b32dc090", 0, new DateTime(2025, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 9, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(239) },
                    { 40, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(244), 10, new DateTime(2025, 8, 9, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(244), "f7fc3a3b-d973-4160-9767-6fcab22fcd91", 0, new DateTime(2025, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 9, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(245) },
                    { 41, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(249), 8, new DateTime(2025, 8, 10, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(249), "83bb2c1f-6eca-452b-9a24-7f4b07f3c465", 0, new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 10, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(249) },
                    { 42, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(253), 8, new DateTime(2025, 8, 10, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(253), "15d5580f-457b-47ff-a5bf-6372ff3ac602", 0, new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 10, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(253) },
                    { 43, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(257), 9, new DateTime(2025, 8, 10, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(257), "733c27ab-bb9d-46d9-a360-df4d9c0bf422", 0, new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 10, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(258) },
                    { 44, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(261), 9, new DateTime(2025, 8, 10, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(262), "e76500c8-5efb-4d09-a33f-32f719c33159", 0, new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 10, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(262) },
                    { 45, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(266), 10, new DateTime(2025, 8, 10, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(266), "64076f44-a287-47c9-84a2-f3341619afee", 0, new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 10, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(266) },
                    { 46, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(270), 10, new DateTime(2025, 8, 10, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(270), "4f31662a-1a10-4d24-b070-806185780fab", 0, new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 10, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(270) },
                    { 47, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(274), 8, new DateTime(2025, 8, 11, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(275), "232f2e1b-30f6-4e01-a6e7-b23f5c2065b0", 0, new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 11, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(275) },
                    { 48, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(280), 8, new DateTime(2025, 8, 11, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(280), "c3c7ba31-f599-46c4-8f2d-7427b8298787", 0, new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 11, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(280) },
                    { 49, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(284), 9, new DateTime(2025, 8, 11, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(284), "3795eb0b-476e-40b5-bc96-5fecdeb0b1d1", 0, new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 11, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(284) },
                    { 50, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(288), 9, new DateTime(2025, 8, 11, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(288), "56e6154f-33ee-4a49-b83c-b57e8560f7a0", 0, new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 11, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(289) },
                    { 51, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(295), 10, new DateTime(2025, 8, 11, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(296), "cd71861c-e158-424f-88f7-20656a81d231", 0, new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 11, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(296) },
                    { 52, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(300), 10, new DateTime(2025, 8, 11, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(300), "74444a75-6822-485b-bc90-7eade4992841", 0, new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 11, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(301) },
                    { 53, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(305), 8, new DateTime(2025, 8, 12, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(305), "fa17725e-eea7-454e-906c-351651b8143a", 0, new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 12, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(305) },
                    { 54, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(309), 8, new DateTime(2025, 8, 12, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(309), "42e9ba84-9041-4f13-b803-c88fbe8fcf5e", 0, new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 12, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(309) },
                    { 55, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(313), 9, new DateTime(2025, 8, 12, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(314), "079f8770-b33e-489b-8c92-0bac8420f98f", 0, new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 12, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(314) },
                    { 56, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(319), 9, new DateTime(2025, 8, 12, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(319), "61bf6a31-ff6b-463d-9c3d-34dbac0aa388", 0, new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 12, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(319) },
                    { 57, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(323), 10, new DateTime(2025, 8, 12, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(323), "a1a0f189-e3d4-4d03-8665-20a0ead0f035", 0, new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 12, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(323) },
                    { 58, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(327), 10, new DateTime(2025, 8, 12, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(327), "967026de-94f8-49ee-85b5-48a7c285198e", 0, new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 12, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(327) },
                    { 59, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(331), 8, new DateTime(2025, 8, 13, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(332), "f26f6866-ab52-4ee4-b908-235923aa6460", 0, new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 13, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(332) },
                    { 60, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(335), 8, new DateTime(2025, 8, 13, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(336), "804c629a-f599-48fb-8ae3-57c47365cb47", 0, new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 13, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(336) },
                    { 61, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(340), 9, new DateTime(2025, 8, 13, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(340), "f5b6f062-f833-4c92-a46d-a70e5e460fc1", 0, new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 13, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(340) },
                    { 62, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(344), 9, new DateTime(2025, 8, 13, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(344), "17b7ae27-2305-407b-8a7d-0db16ee3fbef", 0, new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 13, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(344) },
                    { 63, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(348), 10, new DateTime(2025, 8, 13, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(348), "050f86f0-f07e-4204-be53-63139ac5fb65", 0, new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 13, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(349) },
                    { 64, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(353), 10, new DateTime(2025, 8, 13, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(354), "a70a9529-3f26-4bff-b5f6-47c20748383f", 0, new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 13, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(354) },
                    { 65, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(358), 8, new DateTime(2025, 8, 14, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(358), "43b461ff-43ff-47ac-b539-b80721d7fee5", 0, new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 14, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(358) },
                    { 66, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(363), 8, new DateTime(2025, 8, 14, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(363), "7a55c298-6798-4c73-821c-a13911a51e5d", 0, new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 14, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(363) },
                    { 67, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(367), 9, new DateTime(2025, 8, 14, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(368), "4d927aba-e6f7-421b-9d62-d7dc2cbbac5d", 0, new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 14, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(368) },
                    { 68, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(372), 9, new DateTime(2025, 8, 14, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(372), "0db5376b-2e59-4a91-b8de-fb2be88a571a", 0, new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 14, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(372) },
                    { 69, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(376), 10, new DateTime(2025, 8, 14, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(376), "de57f733-4860-48e2-9209-2773c2867a99", 0, new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 14, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(376) },
                    { 70, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(380), 10, new DateTime(2025, 8, 14, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(380), "ace25970-d543-4129-b0c9-5127a2e6a336", 0, new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 14, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(381) },
                    { 71, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(428), 11, new DateTime(2025, 8, 8, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(428), "e86c9fa9-3d46-4c15-9191-ef621d077ed6", 0, new DateTime(2025, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 8, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(428) },
                    { 72, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(437), 12, new DateTime(2025, 8, 8, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(438), "b0652750-46e7-4112-b432-9c7d63649098", 0, new DateTime(2025, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 8, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(438) },
                    { 73, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(443), 11, new DateTime(2025, 8, 9, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(443), "0a837edc-37c6-45b3-8d54-760fc87bab80", 0, new DateTime(2025, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 9, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(443) },
                    { 74, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(449), 12, new DateTime(2025, 8, 9, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(450), "a06e7235-45e7-4f1a-83b5-331b14c239a4", 0, new DateTime(2025, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 9, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(450) },
                    { 75, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(454), 11, new DateTime(2025, 8, 10, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(454), "6dabb742-9a24-4abf-b50f-325d05538bfa", 0, new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 10, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(455) },
                    { 76, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(460), 12, new DateTime(2025, 8, 10, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(460), "54a3966e-c8e1-4df0-9436-9fc92179ddcc", 0, new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 10, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(461) },
                    { 77, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(465), 11, new DateTime(2025, 8, 11, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(465), "6a6754cb-28a1-4a1b-9243-f24ebea71b5b", 0, new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 11, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(465) },
                    { 78, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(474), 12, new DateTime(2025, 8, 11, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(474), "6ede634d-5ea0-444d-af45-eb43fefe02ad", 0, new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 11, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(474) },
                    { 79, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(478), 11, new DateTime(2025, 8, 12, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(479), "585425d3-0656-42f3-aa6a-d9a4703525da", 0, new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 12, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(479) },
                    { 80, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(484), 12, new DateTime(2025, 8, 12, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(485), "4ece81a6-755d-4cfd-95b6-052b8683dc35", 0, new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 12, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(485) },
                    { 81, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(489), 11, new DateTime(2025, 8, 13, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(489), "7fd0f1d7-4ce7-427e-b025-7bd0106264ba", 0, new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 13, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(490) },
                    { 82, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(495), 12, new DateTime(2025, 8, 13, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(495), "97ba3ef2-8d66-4eb6-867e-f3d562b82a6f", 0, new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 13, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(496) },
                    { 83, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(500), 11, new DateTime(2025, 8, 14, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(500), "3901159f-68eb-49a3-8490-f65ea2e14f74", 0, new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 14, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(500) },
                    { 84, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(506), 12, new DateTime(2025, 8, 14, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(506), "e8a94509-28a3-4156-85d5-9161a5582937", 0, new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 14, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(506) },
                    { 85, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(510), 12, new DateTime(2025, 8, 14, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(511), "cfd91fe6-f0ce-4a25-980b-301914d28221", 0, new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 14, 18, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(511) }
                });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "SelectedStatus", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(7678), new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(7683), 620.38m, new DateTime(2025, 5, 31, 23, 4, 13, 578, DateTimeKind.Local).AddTicks(4319), "Non necessitatibus modi est consequatur perspiciatis quod magnam magnam repudiandae.", "Unbranded Soft Pants", "4912855f-cd15-454e-981d-5bca229535f3", 10, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(7683) },
                    { 2, new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(7898), new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(7898), 766.91m, new DateTime(2025, 2, 14, 21, 13, 43, 88, DateTimeKind.Local).AddTicks(3290), "İusto nihil eius natus perferendis similique.", "Unbranded Cotton Sausages", "e818e884-226b-4de0-971b-f465b986df45", 3, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(7899) },
                    { 3, new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(7941), new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(7941), 312.41m, new DateTime(2024, 8, 15, 12, 49, 15, 98, DateTimeKind.Local).AddTicks(1310), "Ullam quisquam dolor accusantium voluptatem dolores labore.", "Small Granite Soap", "5419a93c-b8cc-44ec-80a8-bb1ebd078998", 10, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(7941) },
                    { 4, new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(7974), new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(7975), 637.93m, new DateTime(2025, 5, 4, 13, 19, 25, 54, DateTimeKind.Local).AddTicks(2493), "Velit vel dolor aut vero ab vel qui et.", "Small Granite Pizza", "74a42255-8293-4646-b1ae-b9a0c65da986", 6, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(7975) },
                    { 5, new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(8012), new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(8012), 813.11m, new DateTime(2025, 7, 7, 11, 4, 33, 8, DateTimeKind.Local).AddTicks(8776), "Voluptatem rem ut veritatis ipsa facere cum ut.", "Handcrafted Frozen Bacon", "b5fbce5d-1bb8-4616-aa59-d7903cda7b72", 5, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(8012) },
                    { 6, new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(8046), new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(8047), 798.61m, new DateTime(2024, 10, 12, 11, 14, 41, 792, DateTimeKind.Local).AddTicks(6351), "Ea cumque exercitationem mollitia aspernatur quia sint illo sunt.", "Handcrafted Steel Chicken", "f4878c54-852f-4122-b05f-48f50212221a", 2, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(8047) },
                    { 7, new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(8081), new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(8082), 910.47m, new DateTime(2024, 10, 23, 7, 21, 56, 38, DateTimeKind.Local).AddTicks(820), "Aut dolores ut ut ipsum labore adipisci delectus ducimus.", "Generic Steel Mouse", "20178d84-7e4f-40f3-ab7a-4f5d544ca5ee", 9, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(8082) },
                    { 8, new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(8114), new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(8114), 945.10m, new DateTime(2025, 2, 17, 23, 52, 39, 365, DateTimeKind.Local).AddTicks(4588), "Ab debitis rem praesentium.", "Awesome Concrete Car", "f3ad3be6-6e37-4bd8-bbbc-8abf284598c6", 10, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(8114) },
                    { 9, new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(8138), new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(8138), 358.93m, new DateTime(2024, 10, 8, 7, 11, 5, 296, DateTimeKind.Local).AddTicks(6474), "Recusandae ut et natus quae autem et.", "Ergonomic Wooden Ball", "9e2c382e-3bb9-4d71-ba33-2bb8f3ba5786", 7, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(8138) },
                    { 10, new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(8165), new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(8165), 813.00m, new DateTime(2025, 7, 24, 7, 7, 32, 207, DateTimeKind.Local).AddTicks(4243), "Ut cumque vitae.", "Gorgeous Granite Sausages", "cfe58693-c708-47ff-bc06-9c8983c8425e", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(8166) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_ReservationId",
                table: "Expenses",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ReservationId",
                table: "Payments",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CustomerId",
                table: "Reservations",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_RoomId",
                table: "Reservations",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Shifts_EmployeeId",
                table: "Shifts",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Shifts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Rooms");
        }
    }
}

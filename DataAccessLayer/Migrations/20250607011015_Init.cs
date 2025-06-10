using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
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
                    WeeklyOfDate = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "none"),
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
                    { 1, "Sophiaton", "Saint Martin", new DateTime(2025, 6, 7, 4, 10, 14, 95, DateTimeKind.Local).AddTicks(5742), "911 Fritsch Shores, Giannishire, Chile", "11", "SK8355863700451008009111", "375.956.2624", "Bryce_Ankunding@hotmail.com", new DateTime(2025, 6, 7, 4, 10, 14, 95, DateTimeKind.Local).AddTicks(5750), "Ewald", "Harber", "ffd0cb0a-da5d-42db-8484-9a936ab698b4", "00623-6967", 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 95, DateTimeKind.Local).AddTicks(5751) },
                    { 2, "Aricview", "Hungary", new DateTime(2025, 6, 7, 4, 10, 14, 95, DateTimeKind.Local).AddTicks(6552), "93207 Bartoletti Meadows, New Zoie, Jamaica", "1", "AZ0418R897892090157006095617", "(982) 736-4932 x8513", "Janice45@gmail.com", new DateTime(2025, 6, 7, 4, 10, 14, 95, DateTimeKind.Local).AddTicks(6554), "Wilford", "Mayer", "7c5f1faf-8122-47d1-bde9-d696aec559fe", "70155", 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 95, DateTimeKind.Local).AddTicks(6555) },
                    { 3, "Tremaineland", "Mayotte", new DateTime(2025, 6, 7, 4, 10, 14, 95, DateTimeKind.Local).AddTicks(6798), "787 Feest Canyon, New Kathleenland, Madagascar", "7", "AT465000956510086372", "1-561-489-6525", "Claud.Lind@hotmail.com", new DateTime(2025, 6, 7, 4, 10, 14, 95, DateTimeKind.Local).AddTicks(6798), "Allene", "Will", "530919c5-22f3-43ad-8bff-3f6bd290aa8b", "77787", 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 95, DateTimeKind.Local).AddTicks(6798) },
                    { 4, "Trompchester", "Azerbaijan", new DateTime(2025, 6, 7, 4, 10, 14, 95, DateTimeKind.Local).AddTicks(6971), "3180 Kihn Curve, Jastshire, Lebanon", "10", "GL4800340077005942", "1-391-570-1216 x19893", "Raquel48@gmail.com", new DateTime(2025, 6, 7, 4, 10, 14, 95, DateTimeKind.Local).AddTicks(6972), "Adaline", "Hyatt", "357ec5bd-8872-459c-ad49-3bf8b95a6d5b", "31120", 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 95, DateTimeKind.Local).AddTicks(6972) },
                    { 5, "Pouroschester", "Suriname", new DateTime(2025, 6, 7, 4, 10, 14, 95, DateTimeKind.Local).AddTicks(7131), "65696 Lowe Valleys, Stiedemannport, Israel", "1", "SK8490061287551475130032", "1-867-949-8853 x468", "Idella16@yahoo.com", new DateTime(2025, 6, 7, 4, 10, 14, 95, DateTimeKind.Local).AddTicks(7132), "Weston", "Marquardt", "cf19243b-7928-40c3-aa3e-e074bd01e46e", "06781-8234", 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 95, DateTimeKind.Local).AddTicks(7132) },
                    { 6, "Lueilwitzmouth", "Falkland Islands (Malvinas)", new DateTime(2025, 6, 7, 4, 10, 14, 95, DateTimeKind.Local).AddTicks(7365), "3443 Stiedemann Loaf, Ullrichmouth, Oman", "11", "VG4994520124825610875429", "1-616-775-1959 x094", "Jason_OHara@hotmail.com", new DateTime(2025, 6, 7, 4, 10, 14, 95, DateTimeKind.Local).AddTicks(7366), "Marques", "Breitenberg", "5de5c22c-99fb-43a4-82c7-1b9f28a7b807", "57170-4551", 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 95, DateTimeKind.Local).AddTicks(7366) },
                    { 7, "Inesstad", "Monaco", new DateTime(2025, 6, 7, 4, 10, 14, 96, DateTimeKind.Local).AddTicks(3004), "1372 Kihn Canyon, South Arianemouth, Argentina", "7", "SM30R0822084740J85N0553V53F", "683-718-9862", "Ethyl.Windler@gmail.com", new DateTime(2025, 6, 7, 4, 10, 14, 96, DateTimeKind.Local).AddTicks(3010), "Francesco", "Rogahn", "71c5b2a2-de41-422f-bbf4-3edc57c9d6cf", "56314", 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 96, DateTimeKind.Local).AddTicks(3010) },
                    { 8, "New Harleymouth", "Ghana", new DateTime(2025, 6, 7, 4, 10, 14, 96, DateTimeKind.Local).AddTicks(3307), "466 Melba Summit, Lake Jammieshire, Niue", "10", "MK60701161738695876", "348-431-3815 x6900", "Marilyne_Kessler95@yahoo.com", new DateTime(2025, 6, 7, 4, 10, 14, 96, DateTimeKind.Local).AddTicks(3308), "Walton", "Kertzmann", "40ed7600-6210-46fa-a685-ae65f090f2f9", "01391", 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 96, DateTimeKind.Local).AddTicks(3308) },
                    { 9, "Alexaneland", "India", new DateTime(2025, 6, 7, 4, 10, 14, 96, DateTimeKind.Local).AddTicks(3498), "045 Adams Wall, Port Jarrellton, Estonia", "4", "ME28061736091403003657", "(545) 656-3351", "Leif.Satterfield@yahoo.com", new DateTime(2025, 6, 7, 4, 10, 14, 96, DateTimeKind.Local).AddTicks(3499), "Terrell", "Ankunding", "f668ea58-3695-40be-a6e8-969381a1d58a", "70510-0428", 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 96, DateTimeKind.Local).AddTicks(3499) },
                    { 10, "East Nyasiashire", "Martinique", new DateTime(2025, 6, 7, 4, 10, 14, 96, DateTimeKind.Local).AddTicks(3673), "34021 Spinka Branch, Beatriceview, Micronesia", "8", "EE916759259202180526", "518-725-2179 x969", "Reina.Fay4@hotmail.com", new DateTime(2025, 6, 7, 4, 10, 14, 96, DateTimeKind.Local).AddTicks(3673), "Delphia", "Senger", "c0717b6b-90b0-4dcb-ac74-650cad159c51", "14777", 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 96, DateTimeKind.Local).AddTicks(3673) }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "HourlyWage", "MasterId", "MonthlyWage", "Position", "PostalCode", "SelectedStatus", "ShiftEnd", "ShiftStart", "Status", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Kocaeli", "Mikronezya", new DateTime(2025, 6, 7, 4, 10, 14, 164, DateTimeKind.Local).AddTicks(8230), "Asuk.Kulaksizoglu98@hotmail.com", "Kocatepe Caddesi 1, Erzurum, Güney Kıbrıs Rum Yönetimi", "Argu", "Erbay", "+90-849-235-89-90", new DateTime(2025, 6, 7, 4, 10, 14, 164, DateTimeKind.Local).AddTicks(8233), 0m, "323f709c-97e5-4edb-9a18-eccd3cb4ea82", 0m, "Resepsiyon Görevlisi", "1", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 164, DateTimeKind.Local).AddTicks(8234) },
                    { 2, "Amasya", "Namibia", new DateTime(2025, 6, 7, 4, 10, 14, 164, DateTimeKind.Local).AddTicks(8972), "Colpan81@yahoo.com", "Bandak Sokak 82, Diyarbakır, Ürdün", "İdil", "Keçeci", "+90-552-895-08-61", new DateTime(2025, 6, 7, 4, 10, 14, 164, DateTimeKind.Local).AddTicks(8973), 0m, "f5df5837-9d9d-47c5-9285-471877aab7c1", 0m, "Resepsiyon Görevlisi", "1", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 164, DateTimeKind.Local).AddTicks(8973) },
                    { 3, "Aksaray", "Barbados", new DateTime(2025, 6, 7, 4, 10, 14, 164, DateTimeKind.Local).AddTicks(9100), "Bolmus.Kavaklioglu@yahoo.com", "Harman Altı Sokak 92a, Van, Dominik Cumhuriyeti", "Güler", "Körmükçü", "+90-759-614-45-62", new DateTime(2025, 6, 7, 4, 10, 14, 164, DateTimeKind.Local).AddTicks(9101), 0m, "f64154af-1270-4604-9e39-2ac11c33a9f6", 0m, "Resepsiyon Görevlisi", "1", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 164, DateTimeKind.Local).AddTicks(9101) },
                    { 4, "Iğdır", "Guyana", new DateTime(2025, 6, 7, 4, 10, 14, 164, DateTimeKind.Local).AddTicks(9207), "Keyken_Ozkara72@hotmail.com", "Kaldırım Sokak 38c, Şırnak, Afganistan", "Bilgekan", "Karadaş", "+90-648-582-3-397", new DateTime(2025, 6, 7, 4, 10, 14, 164, DateTimeKind.Local).AddTicks(9207), 0m, "5ff0249c-382e-4b40-9fda-343b0406a8f8", 0m, "Resepsiyon Görevlisi", "1", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 164, DateTimeKind.Local).AddTicks(9207) },
                    { 5, "Adana", "Hırvatistan", new DateTime(2025, 6, 7, 4, 10, 14, 164, DateTimeKind.Local).AddTicks(9299), "Atuncu0@yahoo.com", "Saygılı Sokak 63b, Osmaniye, Burkina Faso", "Barçadurmuş", "Kavaklıoğlu", "+90-779-120-85-16", new DateTime(2025, 6, 7, 4, 10, 14, 164, DateTimeKind.Local).AddTicks(9299), 0m, "571f6484-6f16-41d7-9540-4e3e0dfc1f8d", 0m, "Resepsiyon Görevlisi", "0", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 164, DateTimeKind.Local).AddTicks(9299) },
                    { 6, "Batman", "Gana", new DateTime(2025, 6, 7, 4, 10, 14, 164, DateTimeKind.Local).AddTicks(9394), "Alper.Eksioglu55@yahoo.com", "Güven Yaka Sokak 599, Kütahya, Cibuti", "Güneş", "Adal", "+90-482-399-44-94", new DateTime(2025, 6, 7, 4, 10, 14, 164, DateTimeKind.Local).AddTicks(9394), 0m, "b09e98d3-785b-45f4-b4ea-e4ae2e2d7773", 0m, "Resepsiyon Görevlisi", "0", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 164, DateTimeKind.Local).AddTicks(9394) },
                    { 7, "Şırnak", "Estonya", new DateTime(2025, 6, 7, 4, 10, 14, 164, DateTimeKind.Local).AddTicks(9478), "Altinkagan90@hotmail.com", "İsmet Attila Caddesi 28, Hakkari, Tayland", "Çabdar", "Durak ", "+90-594-506-1-458", new DateTime(2025, 6, 7, 4, 10, 14, 164, DateTimeKind.Local).AddTicks(9478), 0m, "3ac426c5-147b-4c52-95e2-961714007e21", 0m, "Resepsiyon Görevlisi", "0", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 164, DateTimeKind.Local).AddTicks(9479) },
                    { 8, "Bitlis", "Guatemala", new DateTime(2025, 6, 7, 4, 10, 14, 165, DateTimeKind.Local).AddTicks(7109), "Ilgegu99@gmail.com", "Ergenekon Sokak   9, Batman, Cape Verde", "Barsboğa", "Adıvar", "+90-905-379-9-877", new DateTime(2025, 6, 7, 4, 10, 14, 165, DateTimeKind.Local).AddTicks(7112), 0m, "5a896b2c-c783-4caf-976e-bc6bee72b34d", 0m, "Temizlik Görevlisi", "0", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 165, DateTimeKind.Local).AddTicks(7113) },
                    { 9, "Niğde", "Doğu Timor", new DateTime(2025, 6, 7, 4, 10, 14, 165, DateTimeKind.Local).AddTicks(7738), "Bulut_Cagiran87@hotmail.com", "Okul Sokak 92b, Elazığ, Slovakya", "Bilig", "Günday", "+90-747-803-7-605", new DateTime(2025, 6, 7, 4, 10, 14, 165, DateTimeKind.Local).AddTicks(7740), 0m, "fa01a0d8-3c50-4a29-a25c-ed0cc8eaa1c5", 0m, "Temizlik Görevlisi", "1", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 165, DateTimeKind.Local).AddTicks(7740) },
                    { 10, "Kütahya", "Yeni Kaledonya, Fransa", new DateTime(2025, 6, 7, 4, 10, 14, 165, DateTimeKind.Local).AddTicks(7862), "Baytas_Akaydin52@gmail.com", "Barış Sokak 759, Bayburt, İzlanda", "Arslan", "Koçyiğit", "+90-661-777-35-31", new DateTime(2025, 6, 7, 4, 10, 14, 165, DateTimeKind.Local).AddTicks(7863), 0m, "457209d1-1476-40c4-876a-d38da1e51c22", 0m, "Temizlik Görevlisi", "1", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 165, DateTimeKind.Local).AddTicks(7863) },
                    { 11, "Batman", "Honduras", new DateTime(2025, 6, 7, 4, 10, 14, 165, DateTimeKind.Local).AddTicks(7958), "Esen.Suleymanoglu26@gmail.com", "30 Ağustos Caddesi 44b, Yozgat, Ekvator", "Baybüre", "Koyuncu", "+90-422-282-3-864", new DateTime(2025, 6, 7, 4, 10, 14, 165, DateTimeKind.Local).AddTicks(7959), 0m, "5a1e921c-fcee-47bd-beb2-04bc3c090621", 0m, "Temizlik Görevlisi", "0", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 165, DateTimeKind.Local).AddTicks(7959) },
                    { 12, "Bolu", "Hırvatistan", new DateTime(2025, 6, 7, 4, 10, 14, 165, DateTimeKind.Local).AddTicks(8061), "Begine.Gurmen@hotmail.com", "Sağlık Sokak 35a, Giresun, Hırvatistan", "Atunçu", "Aykaç", "+90-376-915-0-441", new DateTime(2025, 6, 7, 4, 10, 14, 165, DateTimeKind.Local).AddTicks(8061), 0m, "90a25815-4810-4b99-b55a-1de42dfe55b0", 0m, "Temizlik Görevlisi", "0", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 165, DateTimeKind.Local).AddTicks(8061) },
                    { 13, "Sakarya", "Hollanda Antilleri", new DateTime(2025, 6, 7, 4, 10, 14, 165, DateTimeKind.Local).AddTicks(8142), "Isil.Gonultas26@yahoo.com", "Güven Yaka Sokak 1, Kayseri, Cayman Adaları, İngiltere", "İrinç", "Yıldızoğlu", "+90-176-130-9-825", new DateTime(2025, 6, 7, 4, 10, 14, 165, DateTimeKind.Local).AddTicks(8143), 0m, "e2ab5ed3-e8e1-4dbb-87e5-bc64bab2643b", 0m, "Temizlik Görevlisi", "1", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 165, DateTimeKind.Local).AddTicks(8143) },
                    { 14, "Kocaeli", "Dominika", new DateTime(2025, 6, 7, 4, 10, 14, 165, DateTimeKind.Local).AddTicks(8230), "Butuk_Topaloglu70@hotmail.com", "Ali Çetinkaya Caddesi 042, Batman, Malta", "Arslansungur", "Kıraç ", "+90-860-133-7-368", new DateTime(2025, 6, 7, 4, 10, 14, 165, DateTimeKind.Local).AddTicks(8230), 0m, "48f461bf-d873-4f5d-b4dd-d72bc8fffacd", 0m, "Temizlik Görevlisi", "0", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 165, DateTimeKind.Local).AddTicks(8231) },
                    { 15, "Gaziantep", "Christmas Adası , Avusturalya", new DateTime(2025, 6, 7, 4, 10, 14, 165, DateTimeKind.Local).AddTicks(8317), "Borcul_Koc24@yahoo.com", "Bahçe Sokak 34c, Sivas, Surinam", "Akçora", "Aclan", "+90-781-768-4-770", new DateTime(2025, 6, 7, 4, 10, 14, 165, DateTimeKind.Local).AddTicks(8317), 0m, "4ca7b630-1029-4578-871d-4d001b5233ec", 0m, "Temizlik Görevlisi", "0", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 165, DateTimeKind.Local).AddTicks(8317) },
                    { 16, "Muğla", "Mısır", new DateTime(2025, 6, 7, 4, 10, 14, 165, DateTimeKind.Local).AddTicks(8405), "Alparslan75@yahoo.com", "Gül Sokak 33a, İzmir, Monako", "Al", "Demirbaş", "+90-988-304-99-30", new DateTime(2025, 6, 7, 4, 10, 14, 165, DateTimeKind.Local).AddTicks(8406), 0m, "07eade71-8eb2-4a07-b178-63e25e2503c7", 0m, "Temizlik Görevlisi", "1", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 165, DateTimeKind.Local).AddTicks(8406) },
                    { 17, "Elazığ", "Saint Helena, İngiltere", new DateTime(2025, 6, 7, 4, 10, 14, 165, DateTimeKind.Local).AddTicks(8492), "Atis59@gmail.com", "Kaldırım Sokak 972, Tekirdağ, Macaristan", "Baraktöre", "Öymen", "+90-448-998-0-152", new DateTime(2025, 6, 7, 4, 10, 14, 165, DateTimeKind.Local).AddTicks(8492), 0m, "7c6fe8ad-5ae5-4cfb-9d78-4c1f823c7c50", 0m, "Temizlik Görevlisi", "0", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 165, DateTimeKind.Local).AddTicks(8493) },
                    { 18, "Adana", "Makedonya", new DateTime(2025, 6, 7, 4, 10, 14, 165, DateTimeKind.Local).AddTicks(8575), "Berkis34@hotmail.com", "Barış Sokak 1, Kırklareli, Mayotte, Fransa", "Ermen", "Sadıklar", "+90-149-349-46-16", new DateTime(2025, 6, 7, 4, 10, 14, 165, DateTimeKind.Local).AddTicks(8576), 0m, "759cfd52-1b74-4c11-b8d3-e403746cb71f", 0m, "Temizlik Görevlisi", "1", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 165, DateTimeKind.Local).AddTicks(8576) },
                    { 19, "Şırnak", "Moğolistan", new DateTime(2025, 6, 7, 4, 10, 14, 166, DateTimeKind.Local).AddTicks(6114), "Burulday_Oztuna@yahoo.com", "Sıran Söğüt Sokak 95c, Konya, Amerikan Samoa", "Bayazıt", "Eronat", "+90-101-498-9-120", new DateTime(2025, 6, 7, 4, 10, 14, 166, DateTimeKind.Local).AddTicks(6118), 0m, "0cf31929-406e-4d37-8a0d-4005d9f6f9af", 0m, "Aşçı", "0", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 166, DateTimeKind.Local).AddTicks(6118) },
                    { 20, "Aksaray", "İspanya", new DateTime(2025, 6, 7, 4, 10, 14, 166, DateTimeKind.Local).AddTicks(6613), "Bozok.Sadiklar77@gmail.com", "Oğuzhan Sokak 59c, Gümüşhane, Özbekistan", "Bayuttu", "Polat", "+90-369-153-87-80", new DateTime(2025, 6, 7, 4, 10, 14, 166, DateTimeKind.Local).AddTicks(6613), 0m, "8f788814-424d-46d8-8670-164c27432092", 0m, "Aşçı", "1", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 166, DateTimeKind.Local).AddTicks(6614) },
                    { 21, "Isparta", "Kolombiya", new DateTime(2025, 6, 7, 4, 10, 14, 166, DateTimeKind.Local).AddTicks(6725), "Bilgez_Alniacik3@gmail.com", "İsmet Attila Caddesi 15b, Bilecik, Madagaskar", "Alabörü", "Koçyiğit", "+90-366-759-72-58", new DateTime(2025, 6, 7, 4, 10, 14, 166, DateTimeKind.Local).AddTicks(6726), 0m, "dafbb83c-df83-4279-b29b-1987f03a6490", 0m, "Aşçı", "1", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 166, DateTimeKind.Local).AddTicks(6726) },
                    { 22, "Bitlis", "Moritanya", new DateTime(2025, 6, 7, 4, 10, 14, 166, DateTimeKind.Local).AddTicks(6824), "Isik.Adivar35@gmail.com", "Ergenekon Sokak   93a, Trabzon, Laos", "Begine", "Berberoğlu", "+90-385-061-70-96", new DateTime(2025, 6, 7, 4, 10, 14, 166, DateTimeKind.Local).AddTicks(6824), 0m, "88b89c69-194f-40b7-89b7-2cbf66c5c3f0", 0m, "Aşçı", "0", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 166, DateTimeKind.Local).AddTicks(6824) },
                    { 23, "İzmir", "Pakistan", new DateTime(2025, 6, 7, 4, 10, 14, 166, DateTimeKind.Local).AddTicks(6909), "Beyizci96@hotmail.com", "Dar Sokak 573, Iğdır, Finlandiya", "Ayaz", "Babaoğlu", "+90-518-383-04-73", new DateTime(2025, 6, 7, 4, 10, 14, 166, DateTimeKind.Local).AddTicks(6909), 0m, "b6b239d9-d2b0-425c-8e74-afb15bd504d7", 0m, "Aşçı", "0", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 166, DateTimeKind.Local).AddTicks(6909) },
                    { 24, "Çankırı", "Aruba, Hollanda", new DateTime(2025, 6, 7, 4, 10, 14, 166, DateTimeKind.Local).AddTicks(6994), "Berendey97@hotmail.com", "Ülkü Sokak 68a, Hatay, Estonya", "Atmaca", "Alnıaçık", "+90-244-195-99-41", new DateTime(2025, 6, 7, 4, 10, 14, 166, DateTimeKind.Local).AddTicks(6995), 0m, "ccd1a388-ed0b-46f4-983d-b200d3b05bdb", 0m, "Aşçı", "1", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 166, DateTimeKind.Local).AddTicks(6995) },
                    { 25, "Adana", "Polonya", new DateTime(2025, 6, 7, 4, 10, 14, 166, DateTimeKind.Local).AddTicks(7079), "Bakagul.Tugluk@gmail.com", "Namık Kemal Caddesi 615, Çorum, Kanada", "İldike", "Başoğlu", "+90-813-903-71-86", new DateTime(2025, 6, 7, 4, 10, 14, 166, DateTimeKind.Local).AddTicks(7079), 0m, "caaab7d5-f60c-4796-9bee-38709a7b8469", 0m, "Aşçı", "0", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 166, DateTimeKind.Local).AddTicks(7079) },
                    { 26, "Malatya", "Saint Helena, İngiltere", new DateTime(2025, 6, 7, 4, 10, 14, 166, DateTimeKind.Local).AddTicks(7164), "Ila.Mertoglu59@gmail.com", "Dağınık Evler Sokak 78a, Bilecik, İspanya", "Borçul", "Erdoğan", "+90-682-368-91-32", new DateTime(2025, 6, 7, 4, 10, 14, 166, DateTimeKind.Local).AddTicks(7164), 0m, "9cc324d0-662f-420e-b3f6-b2b0b68ab316", 0m, "Aşçı", "0", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 166, DateTimeKind.Local).AddTicks(7165) },
                    { 27, "Hakkari", "Türkiye", new DateTime(2025, 6, 7, 4, 10, 14, 166, DateTimeKind.Local).AddTicks(7241), "Akbay_Asikoglu@yahoo.com", "Ali Çetinkaya Caddesi 74b, Adana, Türkiye", "Abılay", "Kulaksızoğlu", "+90-144-233-31-73", new DateTime(2025, 6, 7, 4, 10, 14, 166, DateTimeKind.Local).AddTicks(7241), 0m, "c3d558b2-0f34-40aa-a007-f2bb57c8a3c4", 0m, "Aşçı", "1", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 166, DateTimeKind.Local).AddTicks(7241) },
                    { 28, "K.maraş", "Svalbard, Norveç", new DateTime(2025, 6, 7, 4, 10, 14, 166, DateTimeKind.Local).AddTicks(7316), "Bekecarslan.Tugluk60@gmail.com", "Bayır Sokak 00, Ordu, Almanya", "Arıboğa", "Yorulmaz", "+90-055-220-2-324", new DateTime(2025, 6, 7, 4, 10, 14, 166, DateTimeKind.Local).AddTicks(7316), 0m, "acc44950-903b-49a3-ae4c-5119d6e2a4b1", 0m, "Aşçı", "0", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 166, DateTimeKind.Local).AddTicks(7316) },
                    { 29, "Ağrı", "Bangladeş", new DateTime(2025, 6, 7, 4, 10, 14, 166, DateTimeKind.Local).AddTicks(7404), "Aykan.Denkel@gmail.com", "Fatih Sokak  69c, Diyarbakır, Uganda", "Balamır", "Oraloğlu", "+90-510-467-59-52", new DateTime(2025, 6, 7, 4, 10, 14, 166, DateTimeKind.Local).AddTicks(7405), 0m, "4652426b-d432-4367-b1d8-253dcbf4fb1c", 0m, "Aşçı", "0", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 166, DateTimeKind.Local).AddTicks(7405) },
                    { 30, "Şırnak", "Lübnan", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(5006), "Buyankara0@hotmail.com", "Köypınar Sokak 04, Muş, Laos", "Barsgan", "Körmükçü", "+90-938-331-4-595", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(5010), 0m, "703ad4f5-6c04-4aaf-a320-bd7ace1f8045", 0m, "Garson", "1", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(5010) },
                    { 31, "Burdur", "Honduras", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(5510), "Balaban.Keseroglu13@gmail.com", "Bahçe Sokak 77c, K.maraş, Kuzey Maryana Adaları", "Akkurt", "Akal", "+90-571-946-58-15", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(5510), 0m, "01f5ff37-2bde-4e96-ba9a-7a67665abeaa", 0m, "Garson", "0", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(5511) },
                    { 32, "Samsun", "Yunanistan", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(5633), "Buyruk_Arslanoglu84@gmail.com", "Lütfi Karadirek Caddesi 34c, Rize, Maldiv Adaları", "Börü", "Okur", "+90-874-465-4-872", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(5633), 0m, "268ce3d2-d1d6-4d7b-ab97-9f279335e84f", 0m, "Garson", "0", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(5633) },
                    { 33, "Mardin", "Anguilla, İngiltere", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(5732), "Adikutlutas.Kurutluoglu@gmail.com", "Sarıkaya Caddesi 12, Kars, Kazakistan", "Gökçen", "Koyuncu", "+90-282-174-53-96", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(5733), 0m, "4afea406-f65d-4e72-ace9-503e3a9e3258", 0m, "Garson", "1", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(5733) },
                    { 34, "Giresun", "Liechtenstein", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(5928), "Alpertunga31@yahoo.com", "Sarıkaya Caddesi 492, Manisa, Avusturya", "Keyken", "Sadıklar", "+90-798-604-0-213", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(5929), 0m, "82106b10-20bf-4c3d-bfa8-71512ebbf027", 0m, "Garson", "1", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(5929) },
                    { 35, "Bilecik", "Uganda", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(6066), "Bozkurt_Cagiran32@hotmail.com", "Kerimoğlu Sokak 55b, Erzincan, Güney Kore", "Bıçkıcı", "Körmükçü", "+90-124-859-3-281", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(6067), 0m, "18aa2f1c-5c96-46dd-bcee-03ca8294a993", 0m, "Garson", "0", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(6067) },
                    { 36, "Kütahya", "Özbekistan", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(6171), "Bilgebayuncur.Ozdenak@hotmail.com", "Alparslan Türkeş Bulvarı 068, Tekirdağ, Dominika", "İmrem", "Özdenak", "+90-027-887-0-073", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(6172), 0m, "842a66ea-b58c-45f4-8a1b-950912d82f7b", 0m, "Garson", "0", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(6172) },
                    { 37, "Bolu", "Özbekistan", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(6269), "Alpamis30@gmail.com", "Sağlık Sokak 77a, Konya, Japonya", "Buğrakarakağan", "Erbulak", "+90-196-953-3-980", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(6269), 0m, "e673328d-e0fa-434e-8e40-b803c20fca60", 0m, "Garson", "0", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(6269) },
                    { 38, "Nevşehir", "Hollanda Antilleri", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(6359), "Adar.Dogan51@yahoo.com", "Kekeçoğlu Sokak 9, Kocaeli, Vietnam", "Bağaşatulu", "Samancı", "+90-265-147-04-88", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(6359), 0m, "504b2335-e67c-40c5-966a-267f69d80c41", 0m, "Garson", "0", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(6359) },
                    { 39, "Nevşehir", "Jamaika", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(6449), "Bukaktutuk_Ozdenak78@hotmail.com", "Bandak Sokak 03c, Kırıkkale, Kiribati", "Ayaz", "Barbarosoğlu", "+90-025-820-54-49", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(6450), 0m, "fd50255a-aa6c-472c-9bd0-4291cdc8d405", 0m, "Garson", "1", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(6450) },
                    { 40, "Burdur", "Solomon Adaları", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(6670), "Bozboru.Akbulut48@yahoo.com", "Bahçe Sokak 836, Yozgat, Kuzey Kore", "Beglen", "Nebioğlu", "+90-890-644-63-92", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(6670), 0m, "c1d65073-c209-4f61-a8c9-ec570ee099e4", 0m, "Garson", "0", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(6670) },
                    { 41, "Sivas", "Turks ve Caicos Adaları, İngiltere", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(6763), "Borubars.Bakircioglu83@gmail.com", "Harman Yolu Sokak  178, Konya, Suudi Arabistan", "Barkdurdu", "Aybar", "+90-429-549-98-49", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(6763), 0m, "f463ffa6-e565-47f7-a0ea-b8bf3669da13", 0m, "Garson", "1", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(6763) },
                    { 42, "Diyarbakır", "Estonya", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(6855), "Baybayik39@hotmail.com", "30 Ağustos Caddesi 00, Adıyaman, Ekvator Ginesi", "Gülümser", "Beşerler", "+90-391-711-72-55", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(6855), 0m, "21d07116-45b8-4770-b8a6-db232729608e", 0m, "Garson", "0", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 167, DateTimeKind.Local).AddTicks(6856) },
                    { 43, "Muğla", "Gana", new DateTime(2025, 6, 7, 4, 10, 14, 168, DateTimeKind.Local).AddTicks(5239), "Deniz33@yahoo.com", "Kocatepe Caddesi 00c, Nevşehir, Yeni Kaledonya, Fransa", "Bakşı", "Karadaş", "+90-117-846-2-268", new DateTime(2025, 6, 7, 4, 10, 14, 168, DateTimeKind.Local).AddTicks(5243), 0m, "8eec42c7-320a-4311-92ad-7670df2e0e9d", 0m, "Elektrikçi", "0", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 168, DateTimeKind.Local).AddTicks(5243) },
                    { 44, "Bingöl", "Midway Adaları, Amerika", new DateTime(2025, 6, 7, 4, 10, 14, 169, DateTimeKind.Local).AddTicks(4185), "Esen.Kunt69@gmail.com", "Oğuzhan Sokak 00c, Samsun, Liberya", "Barçadurdu", "Günday", "+90-307-329-4-103", new DateTime(2025, 6, 7, 4, 10, 14, 169, DateTimeKind.Local).AddTicks(4188), 0m, "aad7b00a-4a8e-45e0-a852-f873d2509d4f", 0m, "Bilgi İşlem Sorumlusu", "0", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 169, DateTimeKind.Local).AddTicks(4189) }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedDate", "DataStasus", "Description", "EntryDate", "Floor", "HasAirConditioning", "HasBalcony", "HasHairDryer", "HasMinibar", "HasTV", "HasWiFi", "ImageUrl", "MasterId", "PackageType", "PricePerNight", "RoomBreakfast", "RoomCapacity", "RoomNumber", "SelectedStatus", "Type", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 6, 7, 4, 10, 14, 97, DateTimeKind.Local).AddTicks(2914), 1, "Room 101 - Single, Floor 1", new DateTime(2025, 6, 7, 4, 10, 14, 97, DateTimeKind.Local).AddTicks(2919), 1, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "89f71da4-7fdb-47d6-9918-058d993b438e", 0, 100m, false, 1, 101, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 97, DateTimeKind.Local).AddTicks(2919) },
                    { 2, new DateTime(2025, 6, 7, 4, 10, 14, 98, DateTimeKind.Local).AddTicks(2866), 1, "Room 102 - Single, Floor 1", new DateTime(2025, 6, 7, 4, 10, 14, 98, DateTimeKind.Local).AddTicks(2869), 1, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "323b783f-be2b-4043-9ed3-fac3e29c8640", 0, 100m, false, 1, 102, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 98, DateTimeKind.Local).AddTicks(2870) },
                    { 3, new DateTime(2025, 6, 7, 4, 10, 14, 99, DateTimeKind.Local).AddTicks(9059), 1, "Room 103 - Single, Floor 1", new DateTime(2025, 6, 7, 4, 10, 14, 99, DateTimeKind.Local).AddTicks(9068), 1, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "4315a9cd-4ab3-453c-9619-a78fd6370afb", 0, 100m, false, 1, 103, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 99, DateTimeKind.Local).AddTicks(9069) },
                    { 4, new DateTime(2025, 6, 7, 4, 10, 14, 101, DateTimeKind.Local).AddTicks(1402), 1, "Room 104 - Single, Floor 1", new DateTime(2025, 6, 7, 4, 10, 14, 101, DateTimeKind.Local).AddTicks(1410), 1, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "e50d9828-67c6-4a77-9a73-536cc6d25787", 0, 100m, false, 1, 104, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 101, DateTimeKind.Local).AddTicks(1410) },
                    { 5, new DateTime(2025, 6, 7, 4, 10, 14, 102, DateTimeKind.Local).AddTicks(2108), 1, "Room 105 - Single, Floor 1", new DateTime(2025, 6, 7, 4, 10, 14, 102, DateTimeKind.Local).AddTicks(2113), 1, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "efda0ed0-3619-460f-afb1-3d761b58c863", 0, 100m, false, 1, 105, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 102, DateTimeKind.Local).AddTicks(2113) },
                    { 6, new DateTime(2025, 6, 7, 4, 10, 14, 102, DateTimeKind.Local).AddTicks(9334), 1, "Room 106 - Single, Floor 1", new DateTime(2025, 6, 7, 4, 10, 14, 102, DateTimeKind.Local).AddTicks(9336), 1, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "bd8c39e8-c45d-45fc-bded-6cac135a2d3c", 0, 100m, false, 1, 106, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 102, DateTimeKind.Local).AddTicks(9337) },
                    { 7, new DateTime(2025, 6, 7, 4, 10, 14, 103, DateTimeKind.Local).AddTicks(5909), 1, "Room 107 - Single, Floor 1", new DateTime(2025, 6, 7, 4, 10, 14, 103, DateTimeKind.Local).AddTicks(5911), 1, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "4493416d-5f39-41c5-a659-9a0e207b9538", 0, 100m, false, 1, 107, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 103, DateTimeKind.Local).AddTicks(5912) },
                    { 8, new DateTime(2025, 6, 7, 4, 10, 14, 104, DateTimeKind.Local).AddTicks(2836), 1, "Room 108 - Single, Floor 1", new DateTime(2025, 6, 7, 4, 10, 14, 104, DateTimeKind.Local).AddTicks(2839), 1, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "3985af57-c069-4689-b9bd-ea5d0470e847", 0, 100m, false, 1, 108, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 104, DateTimeKind.Local).AddTicks(2840) },
                    { 9, new DateTime(2025, 6, 7, 4, 10, 14, 104, DateTimeKind.Local).AddTicks(9403), 1, "Room 109 - Single, Floor 1", new DateTime(2025, 6, 7, 4, 10, 14, 104, DateTimeKind.Local).AddTicks(9406), 1, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "8e8ba6de-3a38-4f96-8dff-02912ddd79b2", 0, 100m, false, 1, 109, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 104, DateTimeKind.Local).AddTicks(9407) },
                    { 10, new DateTime(2025, 6, 7, 4, 10, 14, 107, DateTimeKind.Local).AddTicks(7567), 1, "Room 110 - Single, Floor 1", new DateTime(2025, 6, 7, 4, 10, 14, 107, DateTimeKind.Local).AddTicks(7570), 1, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "499f2ab0-d717-4dcc-9d11-22ac69cb1a7c", 0, 100m, false, 1, 110, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 107, DateTimeKind.Local).AddTicks(7571) },
                    { 11, new DateTime(2025, 6, 7, 4, 10, 14, 108, DateTimeKind.Local).AddTicks(4070), 1, "Room 111 - Triple (3 single beds), Floor 1", new DateTime(2025, 6, 7, 4, 10, 14, 108, DateTimeKind.Local).AddTicks(4073), 1, true, false, true, true, true, true, "https://www.louisfitzgeraldhotel.com/wp-content/uploads/2020/03/hotel-louis-fitzgerald-082-1366x768-fp_mm-fpoff_0_0.jpg", "aa34395b-cc14-4cb6-aa46-bffe2a6ec7c2", 1, 180m, false, 3, 111, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 108, DateTimeKind.Local).AddTicks(4074) },
                    { 12, new DateTime(2025, 6, 7, 4, 10, 14, 109, DateTimeKind.Local).AddTicks(601), 1, "Room 112 - Triple (3 single beds), Floor 1", new DateTime(2025, 6, 7, 4, 10, 14, 109, DateTimeKind.Local).AddTicks(603), 1, true, false, true, true, true, true, "https://www.louisfitzgeraldhotel.com/wp-content/uploads/2020/03/hotel-louis-fitzgerald-082-1366x768-fp_mm-fpoff_0_0.jpg", "b45de3a1-a74d-46a6-b9b4-be6ca1bd7647", 1, 180m, false, 3, 112, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 109, DateTimeKind.Local).AddTicks(604) },
                    { 13, new DateTime(2025, 6, 7, 4, 10, 14, 109, DateTimeKind.Local).AddTicks(6901), 1, "Room 113 - Triple (3 single beds), Floor 1", new DateTime(2025, 6, 7, 4, 10, 14, 109, DateTimeKind.Local).AddTicks(6904), 1, true, false, true, true, true, true, "https://www.louisfitzgeraldhotel.com/wp-content/uploads/2020/03/hotel-louis-fitzgerald-082-1366x768-fp_mm-fpoff_0_0.jpg", "9ebf626a-7f10-46bb-8f28-0af13bb22b1d", 1, 180m, false, 3, 113, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 109, DateTimeKind.Local).AddTicks(6904) },
                    { 14, new DateTime(2025, 6, 7, 4, 10, 14, 110, DateTimeKind.Local).AddTicks(3153), 1, "Room 114 - Triple (3 single beds), Floor 1", new DateTime(2025, 6, 7, 4, 10, 14, 110, DateTimeKind.Local).AddTicks(3155), 1, true, false, true, true, true, true, "https://www.louisfitzgeraldhotel.com/wp-content/uploads/2020/03/hotel-louis-fitzgerald-082-1366x768-fp_mm-fpoff_0_0.jpg", "2743bad2-5029-4f46-b574-18f9f00894da", 1, 180m, false, 3, 114, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 110, DateTimeKind.Local).AddTicks(3156) },
                    { 15, new DateTime(2025, 6, 7, 4, 10, 14, 110, DateTimeKind.Local).AddTicks(9470), 1, "Room 115 - Triple (3 single beds), Floor 1", new DateTime(2025, 6, 7, 4, 10, 14, 110, DateTimeKind.Local).AddTicks(9473), 1, true, false, true, true, true, true, "https://www.louisfitzgeraldhotel.com/wp-content/uploads/2020/03/hotel-louis-fitzgerald-082-1366x768-fp_mm-fpoff_0_0.jpg", "4e03ef74-f387-48d7-9657-35f56bb365ab", 1, 180m, false, 3, 115, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 110, DateTimeKind.Local).AddTicks(9473) },
                    { 16, new DateTime(2025, 6, 7, 4, 10, 14, 111, DateTimeKind.Local).AddTicks(6921), 1, "Room 116 - Triple (3 single beds), Floor 1", new DateTime(2025, 6, 7, 4, 10, 14, 111, DateTimeKind.Local).AddTicks(6924), 1, true, false, true, true, true, true, "https://www.louisfitzgeraldhotel.com/wp-content/uploads/2020/03/hotel-louis-fitzgerald-082-1366x768-fp_mm-fpoff_0_0.jpg", "a171946c-3a82-4990-85ce-acc3118844d4", 1, 180m, false, 3, 116, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 111, DateTimeKind.Local).AddTicks(6924) },
                    { 17, new DateTime(2025, 6, 7, 4, 10, 14, 112, DateTimeKind.Local).AddTicks(4032), 1, "Room 117 - Triple (3 single beds), Floor 1", new DateTime(2025, 6, 7, 4, 10, 14, 112, DateTimeKind.Local).AddTicks(4036), 1, true, false, true, true, true, true, "https://www.louisfitzgeraldhotel.com/wp-content/uploads/2020/03/hotel-louis-fitzgerald-082-1366x768-fp_mm-fpoff_0_0.jpg", "a5f05bf7-c486-4892-9540-a4ed24080d76", 1, 180m, false, 3, 117, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 112, DateTimeKind.Local).AddTicks(4036) },
                    { 18, new DateTime(2025, 6, 7, 4, 10, 14, 113, DateTimeKind.Local).AddTicks(853), 1, "Room 118 - Triple (3 single beds), Floor 1", new DateTime(2025, 6, 7, 4, 10, 14, 113, DateTimeKind.Local).AddTicks(856), 1, true, false, true, true, true, true, "https://www.louisfitzgeraldhotel.com/wp-content/uploads/2020/03/hotel-louis-fitzgerald-082-1366x768-fp_mm-fpoff_0_0.jpg", "716d309d-5b27-4026-b5be-d44d620b413e", 1, 180m, false, 3, 118, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 113, DateTimeKind.Local).AddTicks(856) },
                    { 19, new DateTime(2025, 6, 7, 4, 10, 14, 113, DateTimeKind.Local).AddTicks(7259), 1, "Room 119 - Triple (3 single beds), Floor 1", new DateTime(2025, 6, 7, 4, 10, 14, 113, DateTimeKind.Local).AddTicks(7262), 1, true, false, true, true, true, true, "https://www.louisfitzgeraldhotel.com/wp-content/uploads/2020/03/hotel-louis-fitzgerald-082-1366x768-fp_mm-fpoff_0_0.jpg", "c77d1529-41ea-494a-8da8-c2330b041377", 1, 180m, false, 3, 119, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 113, DateTimeKind.Local).AddTicks(7262) },
                    { 20, new DateTime(2025, 6, 7, 4, 10, 14, 114, DateTimeKind.Local).AddTicks(4020), 1, "Room 120 - Triple (3 single beds), Floor 1", new DateTime(2025, 6, 7, 4, 10, 14, 114, DateTimeKind.Local).AddTicks(4023), 1, true, false, true, true, true, true, "https://www.louisfitzgeraldhotel.com/wp-content/uploads/2020/03/hotel-louis-fitzgerald-082-1366x768-fp_mm-fpoff_0_0.jpg", "a977d77a-da19-4b42-ad1b-1a60d64ef18d", 1, 180m, false, 3, 120, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 114, DateTimeKind.Local).AddTicks(4024) },
                    { 21, new DateTime(2025, 6, 7, 4, 10, 14, 115, DateTimeKind.Local).AddTicks(755), 1, "Room 121 - Single, Floor 2", new DateTime(2025, 6, 7, 4, 10, 14, 115, DateTimeKind.Local).AddTicks(758), 2, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "c0fa9f12-126f-4491-914e-b0d4bb51e797", 0, 110m, false, 1, 121, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 115, DateTimeKind.Local).AddTicks(759) },
                    { 22, new DateTime(2025, 6, 7, 4, 10, 14, 115, DateTimeKind.Local).AddTicks(9593), 1, "Room 122 - Single, Floor 2", new DateTime(2025, 6, 7, 4, 10, 14, 115, DateTimeKind.Local).AddTicks(9597), 2, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "acb466b9-1a39-4e6f-9194-ff338b4e0122", 0, 110m, false, 1, 122, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 115, DateTimeKind.Local).AddTicks(9597) },
                    { 23, new DateTime(2025, 6, 7, 4, 10, 14, 116, DateTimeKind.Local).AddTicks(8284), 1, "Room 123 - Single, Floor 2", new DateTime(2025, 6, 7, 4, 10, 14, 116, DateTimeKind.Local).AddTicks(8287), 2, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "22036bc1-d748-4eed-9f73-9d293c5cfaad", 0, 110m, false, 1, 123, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 116, DateTimeKind.Local).AddTicks(8288) },
                    { 24, new DateTime(2025, 6, 7, 4, 10, 14, 117, DateTimeKind.Local).AddTicks(6637), 1, "Room 124 - Single, Floor 2", new DateTime(2025, 6, 7, 4, 10, 14, 117, DateTimeKind.Local).AddTicks(6640), 2, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "58c43c4a-6a3e-43a9-aba3-d714e0a2d171", 0, 110m, false, 1, 124, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 117, DateTimeKind.Local).AddTicks(6640) },
                    { 25, new DateTime(2025, 6, 7, 4, 10, 14, 118, DateTimeKind.Local).AddTicks(5726), 1, "Room 125 - Single, Floor 2", new DateTime(2025, 6, 7, 4, 10, 14, 118, DateTimeKind.Local).AddTicks(5729), 2, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "9706eef4-8a2c-4a11-8089-6e23f2d0b120", 0, 110m, false, 1, 125, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 118, DateTimeKind.Local).AddTicks(5730) },
                    { 26, new DateTime(2025, 6, 7, 4, 10, 14, 120, DateTimeKind.Local).AddTicks(1513), 1, "Room 126 - Single, Floor 2", new DateTime(2025, 6, 7, 4, 10, 14, 120, DateTimeKind.Local).AddTicks(1522), 2, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "44175202-eb58-4309-a40b-2a7acc5fa431", 0, 110m, false, 1, 126, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 120, DateTimeKind.Local).AddTicks(1522) },
                    { 27, new DateTime(2025, 6, 7, 4, 10, 14, 120, DateTimeKind.Local).AddTicks(8610), 1, "Room 127 - Single, Floor 2", new DateTime(2025, 6, 7, 4, 10, 14, 120, DateTimeKind.Local).AddTicks(8614), 2, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "a421ef43-41fb-40e7-95af-c6fbcb9be790", 0, 110m, false, 1, 127, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 120, DateTimeKind.Local).AddTicks(8614) },
                    { 28, new DateTime(2025, 6, 7, 4, 10, 14, 121, DateTimeKind.Local).AddTicks(5225), 1, "Room 128 - Single, Floor 2", new DateTime(2025, 6, 7, 4, 10, 14, 121, DateTimeKind.Local).AddTicks(5228), 2, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "47943e03-6e68-4801-8708-1b7320e54653", 0, 110m, false, 1, 128, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 121, DateTimeKind.Local).AddTicks(5229) },
                    { 29, new DateTime(2025, 6, 7, 4, 10, 14, 122, DateTimeKind.Local).AddTicks(1846), 1, "Room 129 - Single, Floor 2", new DateTime(2025, 6, 7, 4, 10, 14, 122, DateTimeKind.Local).AddTicks(1848), 2, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "ebb6eb60-babe-4bba-b36b-1d34b1edb887", 0, 110m, false, 1, 129, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 122, DateTimeKind.Local).AddTicks(1849) },
                    { 30, new DateTime(2025, 6, 7, 4, 10, 14, 122, DateTimeKind.Local).AddTicks(8213), 1, "Room 130 - Single, Floor 2", new DateTime(2025, 6, 7, 4, 10, 14, 122, DateTimeKind.Local).AddTicks(8216), 2, true, false, true, false, true, true, "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg", "a07788a6-137b-4ee9-aef4-2ae6b4721e37", 0, 110m, false, 1, 130, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 122, DateTimeKind.Local).AddTicks(8217) },
                    { 31, new DateTime(2025, 6, 7, 4, 10, 14, 123, DateTimeKind.Local).AddTicks(4654), 1, "Room 131 - Double (2 single beds), Floor 2", new DateTime(2025, 6, 7, 4, 10, 14, 123, DateTimeKind.Local).AddTicks(4657), 2, true, false, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "8e23d73b-4886-420c-9cc8-89d85fc32934", 1, 150m, false, 2, 131, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 123, DateTimeKind.Local).AddTicks(4657) },
                    { 32, new DateTime(2025, 6, 7, 4, 10, 14, 124, DateTimeKind.Local).AddTicks(1192), 1, "Room 132 - Double (2 single beds), Floor 2", new DateTime(2025, 6, 7, 4, 10, 14, 124, DateTimeKind.Local).AddTicks(1194), 2, true, false, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "a68f090e-cd27-443e-9bde-7ab4e963589e", 1, 150m, false, 2, 132, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 124, DateTimeKind.Local).AddTicks(1195) },
                    { 33, new DateTime(2025, 6, 7, 4, 10, 14, 124, DateTimeKind.Local).AddTicks(7510), 1, "Room 133 - Double (2 single beds), Floor 2", new DateTime(2025, 6, 7, 4, 10, 14, 124, DateTimeKind.Local).AddTicks(7513), 2, true, false, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "b307185e-2705-47ab-9fe5-ca359994e0e8", 1, 150m, false, 2, 133, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 124, DateTimeKind.Local).AddTicks(7513) },
                    { 34, new DateTime(2025, 6, 7, 4, 10, 14, 125, DateTimeKind.Local).AddTicks(3937), 1, "Room 134 - Double (2 single beds), Floor 2", new DateTime(2025, 6, 7, 4, 10, 14, 125, DateTimeKind.Local).AddTicks(3939), 2, true, false, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "b04ec5b8-99c6-4c9e-bb96-0ae3f2d95f07", 1, 150m, false, 2, 134, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 125, DateTimeKind.Local).AddTicks(3940) },
                    { 35, new DateTime(2025, 6, 7, 4, 10, 14, 126, DateTimeKind.Local).AddTicks(457), 1, "Room 135 - Double (2 single beds), Floor 2", new DateTime(2025, 6, 7, 4, 10, 14, 126, DateTimeKind.Local).AddTicks(460), 2, true, false, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "1913cbe0-194c-4e1e-b5fd-8026c4686939", 1, 150m, false, 2, 135, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 126, DateTimeKind.Local).AddTicks(461) },
                    { 36, new DateTime(2025, 6, 7, 4, 10, 14, 126, DateTimeKind.Local).AddTicks(6904), 1, "Room 136 - Double (2 single beds), Floor 2", new DateTime(2025, 6, 7, 4, 10, 14, 126, DateTimeKind.Local).AddTicks(6907), 2, true, false, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "4e8b058f-a6f0-4ab5-8ac7-0cdfad51e82c", 1, 150m, false, 2, 136, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 126, DateTimeKind.Local).AddTicks(6907) },
                    { 37, new DateTime(2025, 6, 7, 4, 10, 14, 127, DateTimeKind.Local).AddTicks(3496), 1, "Room 137 - Double (2 single beds), Floor 2", new DateTime(2025, 6, 7, 4, 10, 14, 127, DateTimeKind.Local).AddTicks(3498), 2, true, false, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "80549c42-b4b8-4bfe-8cf1-0b320ba0eb80", 1, 150m, false, 2, 137, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 127, DateTimeKind.Local).AddTicks(3499) },
                    { 38, new DateTime(2025, 6, 7, 4, 10, 14, 127, DateTimeKind.Local).AddTicks(9920), 1, "Room 138 - Double (2 single beds), Floor 2", new DateTime(2025, 6, 7, 4, 10, 14, 127, DateTimeKind.Local).AddTicks(9923), 2, true, false, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "f243a5d5-7b0f-40d5-ab9e-e4088cb07633", 1, 150m, false, 2, 138, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 127, DateTimeKind.Local).AddTicks(9923) },
                    { 39, new DateTime(2025, 6, 7, 4, 10, 14, 128, DateTimeKind.Local).AddTicks(6397), 1, "Room 139 - Double (2 single beds), Floor 2", new DateTime(2025, 6, 7, 4, 10, 14, 128, DateTimeKind.Local).AddTicks(6400), 2, true, false, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "f71154df-0add-4a59-a769-f11845745c4e", 1, 150m, false, 2, 139, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 128, DateTimeKind.Local).AddTicks(6401) },
                    { 40, new DateTime(2025, 6, 7, 4, 10, 14, 129, DateTimeKind.Local).AddTicks(2851), 1, "Room 140 - Double (2 single beds), Floor 2", new DateTime(2025, 6, 7, 4, 10, 14, 129, DateTimeKind.Local).AddTicks(2854), 2, true, false, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "91454d14-57f2-4aa9-b1a6-404c0e9104f0", 1, 150m, false, 2, 140, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 129, DateTimeKind.Local).AddTicks(2855) },
                    { 41, new DateTime(2025, 6, 7, 4, 10, 14, 129, DateTimeKind.Local).AddTicks(9992), 1, "Room 141 - Double (double bed), Floor 3", new DateTime(2025, 6, 7, 4, 10, 14, 129, DateTimeKind.Local).AddTicks(9995), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "a1247089-020e-4d95-9e01-0b09c078139b", 1, 170m, true, 2, 141, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 129, DateTimeKind.Local).AddTicks(9996) },
                    { 42, new DateTime(2025, 6, 7, 4, 10, 14, 137, DateTimeKind.Local).AddTicks(8919), 1, "Room 142 - Double (double bed), Floor 3", new DateTime(2025, 6, 7, 4, 10, 14, 137, DateTimeKind.Local).AddTicks(8930), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "7c31b813-42fe-433a-b554-3a388e881ae8", 1, 170m, true, 2, 142, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 137, DateTimeKind.Local).AddTicks(8931) },
                    { 43, new DateTime(2025, 6, 7, 4, 10, 14, 138, DateTimeKind.Local).AddTicks(5884), 1, "Room 143 - Double (double bed), Floor 3", new DateTime(2025, 6, 7, 4, 10, 14, 138, DateTimeKind.Local).AddTicks(5890), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "83ca2b9d-18b1-4d23-bc30-aac34ba25fd5", 1, 170m, true, 2, 143, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 138, DateTimeKind.Local).AddTicks(5890) },
                    { 44, new DateTime(2025, 6, 7, 4, 10, 14, 139, DateTimeKind.Local).AddTicks(2695), 1, "Room 144 - Double (double bed), Floor 3", new DateTime(2025, 6, 7, 4, 10, 14, 139, DateTimeKind.Local).AddTicks(2698), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "6b5dbde3-da0e-4192-a334-7fd8f07f461a", 1, 170m, true, 2, 144, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 139, DateTimeKind.Local).AddTicks(2699) },
                    { 45, new DateTime(2025, 6, 7, 4, 10, 14, 139, DateTimeKind.Local).AddTicks(9287), 1, "Room 145 - Double (double bed), Floor 3", new DateTime(2025, 6, 7, 4, 10, 14, 139, DateTimeKind.Local).AddTicks(9290), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "84496e32-d232-4008-9165-75feb989e1d0", 1, 170m, true, 2, 145, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 139, DateTimeKind.Local).AddTicks(9290) },
                    { 46, new DateTime(2025, 6, 7, 4, 10, 14, 140, DateTimeKind.Local).AddTicks(6272), 1, "Room 146 - Double (double bed), Floor 3", new DateTime(2025, 6, 7, 4, 10, 14, 140, DateTimeKind.Local).AddTicks(6275), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "11e6bf7e-6b4e-443a-9eb8-65999d1148ae", 1, 170m, true, 2, 146, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 140, DateTimeKind.Local).AddTicks(6276) },
                    { 47, new DateTime(2025, 6, 7, 4, 10, 14, 141, DateTimeKind.Local).AddTicks(3365), 1, "Room 147 - Double (double bed), Floor 3", new DateTime(2025, 6, 7, 4, 10, 14, 141, DateTimeKind.Local).AddTicks(3368), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "cf68377f-4b61-4a2e-8c46-a8e49a08e8c9", 1, 170m, true, 2, 147, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 141, DateTimeKind.Local).AddTicks(3369) },
                    { 48, new DateTime(2025, 6, 7, 4, 10, 14, 142, DateTimeKind.Local).AddTicks(481), 1, "Room 148 - Double (double bed), Floor 3", new DateTime(2025, 6, 7, 4, 10, 14, 142, DateTimeKind.Local).AddTicks(484), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "9283b31e-f597-4e7f-bb47-651ac2f62a05", 1, 170m, true, 2, 148, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 142, DateTimeKind.Local).AddTicks(485) },
                    { 49, new DateTime(2025, 6, 7, 4, 10, 14, 142, DateTimeKind.Local).AddTicks(6939), 1, "Room 149 - Double (double bed), Floor 3", new DateTime(2025, 6, 7, 4, 10, 14, 142, DateTimeKind.Local).AddTicks(6942), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "98a390d0-4336-40f7-83e5-17ef533f0fc8", 1, 170m, true, 2, 149, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 142, DateTimeKind.Local).AddTicks(6942) },
                    { 50, new DateTime(2025, 6, 7, 4, 10, 14, 143, DateTimeKind.Local).AddTicks(3374), 1, "Room 150 - Double (double bed), Floor 3", new DateTime(2025, 6, 7, 4, 10, 14, 143, DateTimeKind.Local).AddTicks(3377), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "16676fac-b185-4b64-af08-298616bb6f70", 1, 170m, true, 2, 150, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 143, DateTimeKind.Local).AddTicks(3377) },
                    { 51, new DateTime(2025, 6, 7, 4, 10, 14, 143, DateTimeKind.Local).AddTicks(9963), 1, "Room 151 - Triple (1 double, 1 single), Floor 3", new DateTime(2025, 6, 7, 4, 10, 14, 143, DateTimeKind.Local).AddTicks(9966), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "2c75cfcd-8cd0-498c-8ba3-f983e60609d3", 1, 200m, true, 3, 151, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 143, DateTimeKind.Local).AddTicks(9967) },
                    { 52, new DateTime(2025, 6, 7, 4, 10, 14, 144, DateTimeKind.Local).AddTicks(6833), 1, "Room 152 - Triple (1 double, 1 single), Floor 3", new DateTime(2025, 6, 7, 4, 10, 14, 144, DateTimeKind.Local).AddTicks(6836), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "7441e71f-5a39-418a-9788-94c9d7d26d32", 1, 200m, true, 3, 152, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 144, DateTimeKind.Local).AddTicks(6837) },
                    { 53, new DateTime(2025, 6, 7, 4, 10, 14, 145, DateTimeKind.Local).AddTicks(3493), 1, "Room 153 - Triple (1 double, 1 single), Floor 3", new DateTime(2025, 6, 7, 4, 10, 14, 145, DateTimeKind.Local).AddTicks(3496), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "8d89fe6c-01f6-4f8d-8b08-cc2b849206a0", 1, 200m, true, 3, 153, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 145, DateTimeKind.Local).AddTicks(3496) },
                    { 54, new DateTime(2025, 6, 7, 4, 10, 14, 146, DateTimeKind.Local).AddTicks(345), 1, "Room 154 - Triple (1 double, 1 single), Floor 3", new DateTime(2025, 6, 7, 4, 10, 14, 146, DateTimeKind.Local).AddTicks(348), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "61c7c4c8-43a9-48c0-8b17-3682cdaa1abb", 1, 200m, true, 3, 154, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 146, DateTimeKind.Local).AddTicks(348) },
                    { 55, new DateTime(2025, 6, 7, 4, 10, 14, 146, DateTimeKind.Local).AddTicks(6758), 1, "Room 155 - Triple (1 double, 1 single), Floor 3", new DateTime(2025, 6, 7, 4, 10, 14, 146, DateTimeKind.Local).AddTicks(6761), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "08e52df8-389a-44e9-b16f-ae542096193f", 1, 200m, true, 3, 155, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 146, DateTimeKind.Local).AddTicks(6762) },
                    { 56, new DateTime(2025, 6, 7, 4, 10, 14, 147, DateTimeKind.Local).AddTicks(3172), 1, "Room 156 - Triple (1 double, 1 single), Floor 3", new DateTime(2025, 6, 7, 4, 10, 14, 147, DateTimeKind.Local).AddTicks(3174), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "d6bfae15-b459-45cb-be69-51a34c9ad397", 1, 200m, true, 3, 156, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 147, DateTimeKind.Local).AddTicks(3175) },
                    { 57, new DateTime(2025, 6, 7, 4, 10, 14, 147, DateTimeKind.Local).AddTicks(9616), 1, "Room 157 - Triple (1 double, 1 single), Floor 3", new DateTime(2025, 6, 7, 4, 10, 14, 147, DateTimeKind.Local).AddTicks(9619), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "042db094-f295-4b5f-9477-7c98d31d59eb", 1, 200m, true, 3, 157, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 147, DateTimeKind.Local).AddTicks(9619) },
                    { 58, new DateTime(2025, 6, 7, 4, 10, 14, 149, DateTimeKind.Local).AddTicks(5182), 1, "Room 158 - Triple (1 double, 1 single), Floor 3", new DateTime(2025, 6, 7, 4, 10, 14, 149, DateTimeKind.Local).AddTicks(5185), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "366d9905-6ab2-4c92-ac07-ef661b3ba665", 1, 200m, true, 3, 158, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 149, DateTimeKind.Local).AddTicks(5186) },
                    { 59, new DateTime(2025, 6, 7, 4, 10, 14, 150, DateTimeKind.Local).AddTicks(1645), 1, "Room 159 - Triple (1 double, 1 single), Floor 3", new DateTime(2025, 6, 7, 4, 10, 14, 150, DateTimeKind.Local).AddTicks(1648), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "84ac778c-2c60-4887-91ec-4c3ac1c87e3c", 1, 200m, true, 3, 159, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 150, DateTimeKind.Local).AddTicks(1648) },
                    { 60, new DateTime(2025, 6, 7, 4, 10, 14, 150, DateTimeKind.Local).AddTicks(8829), 1, "Room 160 - Triple (1 double, 1 single), Floor 3", new DateTime(2025, 6, 7, 4, 10, 14, 150, DateTimeKind.Local).AddTicks(8832), 3, true, true, true, true, true, true, "https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg", "80097058-28f7-4a77-a155-24f9e347d0d3", 1, 200m, true, 3, 160, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 150, DateTimeKind.Local).AddTicks(8833) },
                    { 61, new DateTime(2025, 6, 7, 4, 10, 14, 151, DateTimeKind.Local).AddTicks(5446), 1, "Room 161 - Double (double bed), Floor 4", new DateTime(2025, 6, 7, 4, 10, 14, 151, DateTimeKind.Local).AddTicks(5449), 4, true, true, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "4708531a-8da6-4351-b15a-cdffd117aaad", 1, 180m, true, 2, 161, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 151, DateTimeKind.Local).AddTicks(5450) },
                    { 62, new DateTime(2025, 6, 7, 4, 10, 14, 152, DateTimeKind.Local).AddTicks(1860), 1, "Room 162 - Double (double bed), Floor 4", new DateTime(2025, 6, 7, 4, 10, 14, 152, DateTimeKind.Local).AddTicks(1863), 4, true, true, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "603b9c69-5bfe-46e5-88eb-1c5e83e8aaab", 1, 180m, true, 2, 162, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 152, DateTimeKind.Local).AddTicks(1863) },
                    { 63, new DateTime(2025, 6, 7, 4, 10, 14, 152, DateTimeKind.Local).AddTicks(8316), 1, "Room 163 - Double (double bed), Floor 4", new DateTime(2025, 6, 7, 4, 10, 14, 152, DateTimeKind.Local).AddTicks(8319), 4, true, true, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "7b6a314a-f3b7-4955-b6e4-12385c8e73d0", 1, 180m, true, 2, 163, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 152, DateTimeKind.Local).AddTicks(8320) },
                    { 64, new DateTime(2025, 6, 7, 4, 10, 14, 153, DateTimeKind.Local).AddTicks(5121), 1, "Room 164 - Double (double bed), Floor 4", new DateTime(2025, 6, 7, 4, 10, 14, 153, DateTimeKind.Local).AddTicks(5133), 4, true, true, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "f347dfd0-606d-4c3f-bde1-95e9c607d693", 1, 180m, true, 2, 164, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 153, DateTimeKind.Local).AddTicks(5134) },
                    { 65, new DateTime(2025, 6, 7, 4, 10, 14, 154, DateTimeKind.Local).AddTicks(1984), 1, "Room 165 - Double (double bed), Floor 4", new DateTime(2025, 6, 7, 4, 10, 14, 154, DateTimeKind.Local).AddTicks(1987), 4, true, true, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "42c87256-e5ec-4f54-9f2b-d40059302743", 1, 180m, true, 2, 165, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 154, DateTimeKind.Local).AddTicks(1988) },
                    { 66, new DateTime(2025, 6, 7, 4, 10, 14, 154, DateTimeKind.Local).AddTicks(8619), 1, "Room 166 - Double (double bed), Floor 4", new DateTime(2025, 6, 7, 4, 10, 14, 154, DateTimeKind.Local).AddTicks(8622), 4, true, true, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "e64ab052-654e-44ba-bf47-ae8a8afe4653", 1, 180m, true, 2, 166, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 154, DateTimeKind.Local).AddTicks(8623) },
                    { 67, new DateTime(2025, 6, 7, 4, 10, 14, 155, DateTimeKind.Local).AddTicks(5011), 1, "Room 167 - Double (double bed), Floor 4", new DateTime(2025, 6, 7, 4, 10, 14, 155, DateTimeKind.Local).AddTicks(5014), 4, true, true, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "3cb1b49a-4aed-400a-a54e-f73edee224b8", 1, 180m, true, 2, 167, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 155, DateTimeKind.Local).AddTicks(5015) },
                    { 68, new DateTime(2025, 6, 7, 4, 10, 14, 156, DateTimeKind.Local).AddTicks(1266), 1, "Room 168 - Double (double bed), Floor 4", new DateTime(2025, 6, 7, 4, 10, 14, 156, DateTimeKind.Local).AddTicks(1269), 4, true, true, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "f1d38e40-7d87-451f-9266-549397f2f710", 1, 180m, true, 2, 168, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 156, DateTimeKind.Local).AddTicks(1270) },
                    { 69, new DateTime(2025, 6, 7, 4, 10, 14, 156, DateTimeKind.Local).AddTicks(7492), 1, "Room 169 - Double (double bed), Floor 4", new DateTime(2025, 6, 7, 4, 10, 14, 156, DateTimeKind.Local).AddTicks(7495), 4, true, true, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "9b0c180d-df0f-4a00-b0a4-caee3f5edd66", 1, 180m, true, 2, 169, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 156, DateTimeKind.Local).AddTicks(7495) },
                    { 70, new DateTime(2025, 6, 7, 4, 10, 14, 157, DateTimeKind.Local).AddTicks(3878), 1, "Room 170 - Double (double bed), Floor 4", new DateTime(2025, 6, 7, 4, 10, 14, 157, DateTimeKind.Local).AddTicks(3881), 4, true, true, true, true, true, true, "https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png", "773a72b2-dfac-4b5c-a4ad-a6bca9360b0c", 1, 180m, true, 2, 170, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 157, DateTimeKind.Local).AddTicks(3882) },
                    { 71, new DateTime(2025, 6, 7, 4, 10, 14, 158, DateTimeKind.Local).AddTicks(309), 1, "Room 171 - Quad (1 double, 2 single), Floor 4", new DateTime(2025, 6, 7, 4, 10, 14, 158, DateTimeKind.Local).AddTicks(312), 4, true, true, true, true, true, true, "https://setarehhotel.com/wp-content/uploads/2018/03/QuadRoom01.jpg", "9dbc75ce-d071-4552-a858-e485a7fcf80c", 1, 250m, true, 4, 171, 1, 3, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 158, DateTimeKind.Local).AddTicks(313) },
                    { 72, new DateTime(2025, 6, 7, 4, 10, 14, 158, DateTimeKind.Local).AddTicks(6679), 1, "Room 172 - Quad (1 double, 2 single), Floor 4", new DateTime(2025, 6, 7, 4, 10, 14, 158, DateTimeKind.Local).AddTicks(6682), 4, true, true, true, true, true, true, "https://setarehhotel.com/wp-content/uploads/2018/03/QuadRoom01.jpg", "64a967b4-9dbc-403b-9b9f-c13d398995ba", 1, 250m, true, 4, 172, 1, 3, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 158, DateTimeKind.Local).AddTicks(6682) },
                    { 73, new DateTime(2025, 6, 7, 4, 10, 14, 159, DateTimeKind.Local).AddTicks(3198), 1, "Room 173 - Quad (1 double, 2 single), Floor 4", new DateTime(2025, 6, 7, 4, 10, 14, 159, DateTimeKind.Local).AddTicks(3201), 4, true, true, true, true, true, true, "https://setarehhotel.com/wp-content/uploads/2018/03/QuadRoom01.jpg", "dcdd1f2c-cb6d-49f3-817f-e05b17986de7", 1, 250m, true, 4, 173, 1, 3, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 159, DateTimeKind.Local).AddTicks(3202) },
                    { 74, new DateTime(2025, 6, 7, 4, 10, 14, 160, DateTimeKind.Local).AddTicks(3621), 1, "Room 174 - Quad (1 double, 2 single), Floor 4", new DateTime(2025, 6, 7, 4, 10, 14, 160, DateTimeKind.Local).AddTicks(3624), 4, true, true, true, true, true, true, "https://setarehhotel.com/wp-content/uploads/2018/03/QuadRoom01.jpg", "0222a444-8638-4c7a-aa06-7a88dec28d16", 1, 250m, true, 4, 174, 1, 3, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 160, DateTimeKind.Local).AddTicks(3625) },
                    { 75, new DateTime(2025, 6, 7, 4, 10, 14, 161, DateTimeKind.Local).AddTicks(351), 1, "Room 175 - Quad (1 double, 2 single), Floor 4", new DateTime(2025, 6, 7, 4, 10, 14, 161, DateTimeKind.Local).AddTicks(354), 4, true, true, true, true, true, true, "https://setarehhotel.com/wp-content/uploads/2018/03/QuadRoom01.jpg", "ec13559d-116f-4aff-8c46-d7a2c99b2fdd", 1, 250m, true, 4, 175, 1, 3, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 161, DateTimeKind.Local).AddTicks(355) },
                    { 76, new DateTime(2025, 6, 7, 4, 10, 14, 161, DateTimeKind.Local).AddTicks(7159), 1, "Room 176 - Quad (1 double, 2 single), Floor 4", new DateTime(2025, 6, 7, 4, 10, 14, 161, DateTimeKind.Local).AddTicks(7162), 4, true, true, true, true, true, true, "https://setarehhotel.com/wp-content/uploads/2018/03/QuadRoom01.jpg", "9a1e63e2-3055-4dd2-b619-505293d618a4", 1, 250m, true, 4, 176, 1, 3, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 161, DateTimeKind.Local).AddTicks(7163) },
                    { 77, new DateTime(2025, 6, 7, 4, 10, 14, 162, DateTimeKind.Local).AddTicks(3911), 1, "Room 177 - King Suite, Floor 4", new DateTime(2025, 6, 7, 4, 10, 14, 162, DateTimeKind.Local).AddTicks(3914), 4, true, true, true, true, true, true, "https://calista.com.tr/media/xaug4yos/calista-resort-hotel-blog-king-suit-banner.jpg", "3b5e46e5-1f6f-4393-b51c-ceca55d81b94", 1, 500m, true, 5, 177, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 162, DateTimeKind.Local).AddTicks(3914) }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "PackageType", "RoomId", "SelectedStatus", "TotalAmount", "UpdatedComputerName", "UpdatedDate", "status" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 8, 12, 7, 48, 46, 804, DateTimeKind.Local).AddTicks(110), new DateTime(2026, 7, 9, 17, 15, 20, 94, DateTimeKind.Local).AddTicks(6723), new DateTime(2025, 6, 7, 4, 10, 14, 170, DateTimeKind.Local).AddTicks(5286), 8, new DateTime(2025, 6, 7, 4, 10, 14, 170, DateTimeKind.Local).AddTicks(5287), "fed404a4-84c5-4eb8-a93b-1cd63fc22dad", 0, 11, 1, 1698.08m, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 170, DateTimeKind.Local).AddTicks(5288), 0 },
                    { 2, new DateTime(2025, 11, 10, 9, 44, 35, 623, DateTimeKind.Local).AddTicks(975), new DateTime(2026, 1, 16, 16, 33, 24, 881, DateTimeKind.Local).AddTicks(5105), new DateTime(2025, 6, 7, 4, 10, 14, 170, DateTimeKind.Local).AddTicks(5533), 8, new DateTime(2025, 6, 7, 4, 10, 14, 170, DateTimeKind.Local).AddTicks(5534), "d32b5752-a7aa-428b-8104-12e561cd52a4", 1, 7, 1, 1775.37m, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 170, DateTimeKind.Local).AddTicks(5534), 1 },
                    { 3, new DateTime(2025, 10, 22, 11, 44, 7, 331, DateTimeKind.Local).AddTicks(1328), new DateTime(2025, 11, 3, 10, 8, 10, 181, DateTimeKind.Local).AddTicks(9239), new DateTime(2025, 6, 7, 4, 10, 14, 170, DateTimeKind.Local).AddTicks(5557), 2, new DateTime(2025, 6, 7, 4, 10, 14, 170, DateTimeKind.Local).AddTicks(5557), "1367f936-ac07-4ad6-88f7-ba0502368e97", 0, 43, 1, 1886.02m, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 170, DateTimeKind.Local).AddTicks(5557), 2 },
                    { 4, new DateTime(2026, 1, 6, 17, 3, 26, 916, DateTimeKind.Local).AddTicks(2111), new DateTime(2026, 9, 15, 0, 51, 29, 409, DateTimeKind.Local).AddTicks(4114), new DateTime(2025, 6, 7, 4, 10, 14, 170, DateTimeKind.Local).AddTicks(5571), 2, new DateTime(2025, 6, 7, 4, 10, 14, 170, DateTimeKind.Local).AddTicks(5571), "5cfb21e9-1666-4516-aa94-4e8d220fab25", 1, 38, 1, 2043.66m, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 170, DateTimeKind.Local).AddTicks(5572), 3 },
                    { 5, new DateTime(2025, 10, 7, 10, 26, 52, 441, DateTimeKind.Local).AddTicks(3695), new DateTime(2026, 5, 22, 22, 41, 50, 48, DateTimeKind.Local).AddTicks(57), new DateTime(2025, 6, 7, 4, 10, 14, 170, DateTimeKind.Local).AddTicks(5585), 2, new DateTime(2025, 6, 7, 4, 10, 14, 170, DateTimeKind.Local).AddTicks(5586), "ca06c6af-5e4a-46e8-b3cd-b3dcb516434c", 0, 24, 1, 1687.81m, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 170, DateTimeKind.Local).AddTicks(5586), 4 },
                    { 6, new DateTime(2025, 12, 11, 5, 27, 31, 453, DateTimeKind.Local).AddTicks(1082), new DateTime(2026, 1, 4, 0, 45, 53, 733, DateTimeKind.Local).AddTicks(2998), new DateTime(2025, 6, 7, 4, 10, 14, 170, DateTimeKind.Local).AddTicks(5601), 8, new DateTime(2025, 6, 7, 4, 10, 14, 170, DateTimeKind.Local).AddTicks(5602), "c2e63e05-cea8-4ae4-93a9-41b47c9336ee", 1, 10, 1, 1726.88m, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 170, DateTimeKind.Local).AddTicks(5602), 0 },
                    { 7, new DateTime(2026, 5, 24, 9, 29, 54, 688, DateTimeKind.Local).AddTicks(811), new DateTime(2026, 7, 15, 22, 15, 13, 723, DateTimeKind.Local).AddTicks(3082), new DateTime(2025, 6, 7, 4, 10, 14, 170, DateTimeKind.Local).AddTicks(5614), 10, new DateTime(2025, 6, 7, 4, 10, 14, 170, DateTimeKind.Local).AddTicks(5614), "1cf8844c-035a-47d4-93e4-f392b0a417d3", 0, 26, 1, 1859.16m, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 170, DateTimeKind.Local).AddTicks(5614), 1 },
                    { 8, new DateTime(2026, 1, 1, 17, 3, 53, 467, DateTimeKind.Local).AddTicks(6379), new DateTime(2026, 8, 27, 20, 31, 57, 252, DateTimeKind.Local).AddTicks(2152), new DateTime(2025, 6, 7, 4, 10, 14, 170, DateTimeKind.Local).AddTicks(5626), 2, new DateTime(2025, 6, 7, 4, 10, 14, 170, DateTimeKind.Local).AddTicks(5626), "84ec04c3-a399-42ec-99a1-4674de85159c", 1, 13, 1, 2411.76m, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 170, DateTimeKind.Local).AddTicks(5627), 2 },
                    { 9, new DateTime(2026, 5, 6, 7, 7, 20, 327, DateTimeKind.Local).AddTicks(2591), new DateTime(2026, 12, 10, 9, 57, 41, 164, DateTimeKind.Local).AddTicks(4405), new DateTime(2025, 6, 7, 4, 10, 14, 170, DateTimeKind.Local).AddTicks(5638), 7, new DateTime(2025, 6, 7, 4, 10, 14, 170, DateTimeKind.Local).AddTicks(5639), "3abf5217-e1c0-45c6-8ec9-38f28df9c297", 0, 6, 1, 2035.60m, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 170, DateTimeKind.Local).AddTicks(5639), 3 },
                    { 10, new DateTime(2025, 8, 10, 15, 46, 6, 630, DateTimeKind.Local).AddTicks(5268), new DateTime(2025, 11, 28, 1, 45, 41, 102, DateTimeKind.Local).AddTicks(3996), new DateTime(2025, 6, 7, 4, 10, 14, 170, DateTimeKind.Local).AddTicks(5656), 4, new DateTime(2025, 6, 7, 4, 10, 14, 170, DateTimeKind.Local).AddTicks(5658), "01e6f7bf-0b7b-4a69-b931-21c71b621892", 1, 12, 1, 2021.70m, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 170, DateTimeKind.Local).AddTicks(5658), 4 }
                });

            migrationBuilder.InsertData(
                table: "Shifts",
                columns: new[] { "Id", "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "SelectedStatus", "ShiftDate", "ShiftType", "StartTime", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7736), 1, new DateTime(2025, 6, 7, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7737), "be7a8620-5daf-457a-ab1b-1880df3a6eb4", 1, new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 7, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7737) },
                    { 2, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7757), 2, new DateTime(2025, 6, 7, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7757), "8c77101e-426a-4b9f-8dc6-093a600bd395", 1, new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 7, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7758) },
                    { 3, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7763), 3, new DateTime(2025, 6, 7, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7763), "9ecfa12f-9ff0-4c92-b2da-463e761dac0c", 1, new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 7, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7763) },
                    { 4, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7768), 4, new DateTime(2025, 6, 7, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7768), "7285652f-28e9-4bc3-b287-122af4068733", 1, new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 7, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7768) },
                    { 5, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7776), 2, new DateTime(2025, 6, 8, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7776), "13bb8b0f-0b5b-44cb-8e8b-5996f07133d8", 1, new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 8, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7777) },
                    { 6, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7782), 3, new DateTime(2025, 6, 8, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7782), "91d51196-a3d9-4d9e-b112-6c0cb5c4419a", 1, new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 8, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7782) },
                    { 7, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7790), 4, new DateTime(2025, 6, 8, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7790), "1e3a3274-13ae-46af-af7b-713f01f36e27", 1, new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 8, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7790) },
                    { 8, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7794), 5, new DateTime(2025, 6, 8, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7795), "2d5132fa-ea5f-463f-bb0c-81b074357e24", 1, new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 8, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7795) },
                    { 9, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7802), 1, new DateTime(2025, 6, 9, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7802), "5f56c84f-c9f9-4c2a-b155-13b7b08f84af", 1, new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 9, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7802) },
                    { 10, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7812), 3, new DateTime(2025, 6, 9, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7812), "3505550e-cebb-49b2-a884-cbe1677df0c3", 1, new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 9, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7812) },
                    { 11, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7817), 4, new DateTime(2025, 6, 9, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7817), "5f21bc83-1676-475c-af80-23bd809968ce", 1, new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 9, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7817) },
                    { 12, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7821), 5, new DateTime(2025, 6, 9, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7821), "f866f76d-0882-412f-a3a7-000002510c5b", 1, new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 9, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7821) },
                    { 13, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7827), 1, new DateTime(2025, 6, 10, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7828), "4759d5da-82df-46e1-897d-ae8475424a8e", 1, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 10, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7828) },
                    { 14, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7832), 2, new DateTime(2025, 6, 10, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7832), "1de16cbe-1cb5-40b6-bf4a-140369ac7188", 1, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 10, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7833) },
                    { 15, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7838), 4, new DateTime(2025, 6, 10, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7838), "025180e1-b539-415c-8797-f7f78730cb46", 1, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 10, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7839) },
                    { 16, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7843), 5, new DateTime(2025, 6, 10, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7843), "8dabc5c4-2568-4aea-a81d-9e4295e8691a", 1, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 10, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7843) },
                    { 17, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7849), 1, new DateTime(2025, 6, 11, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7850), "100e264e-64f8-4d48-b597-21b3b065811e", 1, new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 11, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7850) },
                    { 18, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7854), 2, new DateTime(2025, 6, 11, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7855), "f83b0d1d-89fe-4839-b352-a6b136486ea3", 1, new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 11, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7855) },
                    { 19, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7859), 3, new DateTime(2025, 6, 11, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7859), "54d9c22e-3f62-46e2-b878-9f41a2187fc4", 1, new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 11, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7860) },
                    { 20, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7864), 5, new DateTime(2025, 6, 11, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7864), "731c86b0-bb11-435e-87a7-ab5c63fd4df6", 1, new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 11, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7864) },
                    { 21, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7870), 1, new DateTime(2025, 6, 12, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7871), "ad0b5315-edfb-437e-8bb9-cd37be26ec86", 1, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 12, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7871) },
                    { 22, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7875), 2, new DateTime(2025, 6, 12, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7875), "c5664df9-7a0e-411e-ace4-0a94a2268c47", 1, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 12, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7875) },
                    { 23, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7881), 3, new DateTime(2025, 6, 12, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7881), "abb77fa3-35ac-44e2-a5ae-e5306a70ec43", 1, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 12, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7881) },
                    { 24, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7885), 4, new DateTime(2025, 6, 12, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7885), "77afd9fd-985b-45bf-b5c4-505f4a20d041", 1, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 12, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7886) },
                    { 25, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7892), 1, new DateTime(2025, 6, 13, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7892), "c8f4dd77-bd21-45a7-ad71-87a05f8163cd", 1, new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 13, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7892) },
                    { 26, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7896), 2, new DateTime(2025, 6, 13, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7897), "cfe9b216-f5d2-45ac-aa5c-5ac53d7a5f64", 1, new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 13, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7897) },
                    { 27, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7901), 3, new DateTime(2025, 6, 13, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7901), "43f34837-5cfc-4036-9b28-a2fdda4c8963", 1, new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 13, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7901) },
                    { 28, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7905), 4, new DateTime(2025, 6, 13, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7906), "2388b1f5-93e0-49c8-b89c-307e664a9e5b", 1, new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 13, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7906) },
                    { 29, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7919), 8, new DateTime(2025, 6, 7, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7919), "ac9fbb0f-9efb-4905-a6ad-3d3b0b275034", 1, new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 7, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7919) },
                    { 30, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7925), 8, new DateTime(2025, 6, 7, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7926), "a3f4fa45-5740-43c7-8a9b-19bdf05c0abd", 1, new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 7, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7926) },
                    { 31, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7932), 9, new DateTime(2025, 6, 7, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7932), "e74716ad-aef7-43f2-ad58-5e78344c69e6", 1, new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 7, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7933) },
                    { 32, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7936), 9, new DateTime(2025, 6, 7, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7937), "6fb84b4b-db43-4d52-b63a-bbfb8d4afda2", 1, new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 7, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7937) },
                    { 33, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7941), 10, new DateTime(2025, 6, 7, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7942), "7e2f8651-2fc7-4e2d-b760-95cf7a5e6df3", 1, new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 7, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7942) },
                    { 34, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7949), 10, new DateTime(2025, 6, 7, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7950), "9fc8f733-15f0-4874-b89b-267782075143", 1, new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 7, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7950) },
                    { 35, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7956), 8, new DateTime(2025, 6, 8, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7956), "7bdb7d3b-19d2-4190-ae82-8a7ef851b955", 1, new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 8, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7956) },
                    { 36, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7960), 8, new DateTime(2025, 6, 8, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7961), "c0ec647f-af59-474d-a077-392313550e71", 1, new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 8, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7961) },
                    { 37, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7965), 9, new DateTime(2025, 6, 8, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7966), "2c8b40a2-3d3c-4209-a15b-4cbe2d229d45", 1, new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 8, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7966) },
                    { 38, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7970), 9, new DateTime(2025, 6, 8, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7970), "5646004b-f1c2-488e-a10a-343253cfd415", 1, new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 8, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7970) },
                    { 39, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7976), 10, new DateTime(2025, 6, 8, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7976), "8c05aa2a-7ad9-4bc6-b5dc-ee4c67a7370c", 1, new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 8, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7976) },
                    { 40, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7980), 10, new DateTime(2025, 6, 8, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7980), "2732cb6b-3077-4795-af55-efd205d9871f", 1, new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 8, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7981) },
                    { 41, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7985), 8, new DateTime(2025, 6, 9, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7985), "e75729c2-8a47-41fc-abe6-85aafd049597", 1, new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 9, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7985) },
                    { 42, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7989), 8, new DateTime(2025, 6, 9, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7989), "98c821ee-b214-49a6-98df-b27bdcad4c1e", 1, new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 9, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7990) },
                    { 43, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7994), 9, new DateTime(2025, 6, 9, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7994), "69a0b951-3d57-4568-8bac-29b283c77768", 1, new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 9, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7994) },
                    { 44, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7999), 9, new DateTime(2025, 6, 9, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7999), "9ddb05ee-83bf-465a-856f-65e7cea7d027", 1, new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 9, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(7999) },
                    { 45, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8003), 10, new DateTime(2025, 6, 9, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8003), "3b34ced4-e2ec-4515-ad9a-8f084a9cad85", 1, new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 9, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8004) },
                    { 46, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8008), 10, new DateTime(2025, 6, 9, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8008), "6fcb18ec-7ca6-4295-b54d-271d3c63feb4", 1, new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 9, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8008) },
                    { 47, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8014), 8, new DateTime(2025, 6, 10, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8014), "b2aa4a2e-0e0a-4973-94cd-e873ff2befec", 1, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 10, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8014) },
                    { 48, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8018), 8, new DateTime(2025, 6, 10, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8018), "3b615044-388c-4522-9c78-db657fba59c3", 1, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 10, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8018) },
                    { 49, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8023), 9, new DateTime(2025, 6, 10, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8023), "79747e40-e4fd-4934-87d5-25f6e3fca0be", 1, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 10, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8023) },
                    { 50, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8027), 9, new DateTime(2025, 6, 10, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8027), "bf6196f0-8bad-46dd-a889-120e51201a67", 1, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 10, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8027) },
                    { 51, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8031), 10, new DateTime(2025, 6, 10, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8032), "7a729384-25ee-4b5f-a400-5c2daff82277", 1, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 10, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8032) },
                    { 52, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8036), 10, new DateTime(2025, 6, 10, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8036), "82c29139-0d7e-47f6-8573-d4da188c7211", 1, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 10, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8036) },
                    { 53, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8041), 8, new DateTime(2025, 6, 11, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8041), "973c89a1-21ca-4ca1-9f83-c868ef2b6e90", 1, new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 11, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8041) },
                    { 54, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8045), 8, new DateTime(2025, 6, 11, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8045), "35785d5a-d91a-4f00-9185-47c126ee81fd", 1, new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 11, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8045) },
                    { 55, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8051), 9, new DateTime(2025, 6, 11, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8051), "6057383a-d800-4edb-a09b-3b6226951072", 1, new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 11, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8051) },
                    { 56, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8055), 9, new DateTime(2025, 6, 11, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8055), "8e0ed87a-335a-4d88-ad2f-81a12f280bf6", 1, new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 11, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8056) },
                    { 57, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8060), 10, new DateTime(2025, 6, 11, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8060), "1466bb0e-aab6-4992-87ba-77213cf1e0e1", 1, new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 11, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8060) },
                    { 58, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8064), 10, new DateTime(2025, 6, 11, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8064), "8cb1ebae-ac53-4ec9-9547-7ab0c58a90b2", 1, new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 11, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8064) },
                    { 59, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8069), 8, new DateTime(2025, 6, 12, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8069), "70ee9b55-8c2e-460b-be54-f0a73c8438cb", 1, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 12, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8069) },
                    { 60, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8073), 8, new DateTime(2025, 6, 12, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8073), "1f9d934e-af2a-410f-ae6d-8d1b338b5e39", 1, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 12, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8074) },
                    { 61, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8078), 9, new DateTime(2025, 6, 12, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8078), "7030d2ef-4c77-4033-953d-85e0556bfc36", 1, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 12, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8078) },
                    { 62, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8082), 9, new DateTime(2025, 6, 12, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8082), "80ea947c-5483-466f-b6e2-7b2facafc515", 1, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 12, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8083) },
                    { 63, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8088), 10, new DateTime(2025, 6, 12, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8088), "95507175-7023-49e2-afda-7ed2bee8fe9d", 1, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 12, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8088) },
                    { 64, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8092), 10, new DateTime(2025, 6, 12, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8092), "ca1e62c6-73d3-4555-a602-b50152bab9bd", 1, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 12, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8093) },
                    { 65, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8097), 8, new DateTime(2025, 6, 13, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8097), "96211252-5b32-484c-a753-86a6c80869b3", 1, new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 13, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8097) },
                    { 66, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8108), 8, new DateTime(2025, 6, 13, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8108), "e36d9d08-5749-453c-85c7-f029ae2fb881", 1, new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 13, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8108) },
                    { 67, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8113), 9, new DateTime(2025, 6, 13, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8113), "a86e0fc9-8c79-4f72-94d1-afb1ef564640", 1, new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 13, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8113) },
                    { 68, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8117), 9, new DateTime(2025, 6, 13, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8117), "4aabb554-6b63-43d7-8f38-caca9d16b4f5", 1, new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 13, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8118) },
                    { 69, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8122), 10, new DateTime(2025, 6, 13, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8122), "ce1acdc4-27da-4f99-88ea-5e0ef3f0a6cb", 1, new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 13, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8122) },
                    { 70, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8126), 10, new DateTime(2025, 6, 13, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8127), "186d9fd4-ee63-4a26-a0dd-fba123208a7f", 1, new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 13, 16, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8127) },
                    { 71, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8168), 11, new DateTime(2025, 6, 7, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8168), "ee62a11c-0f16-4a2a-a362-d043c2396cfa", 1, new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 7, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8168) },
                    { 72, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8178), 11, new DateTime(2025, 6, 7, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8179), "6d803844-bcfc-42dd-bb81-ac031bb5109e", 1, new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 7, 18, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8179) },
                    { 73, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8184), 12, new DateTime(2025, 6, 7, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8184), "aff00891-2941-4699-9a07-8fd9749f9b06", 1, new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 7, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8184) },
                    { 74, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8189), 11, new DateTime(2025, 6, 8, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8189), "ae0b47c7-835c-4455-b3c0-67995fc35cbe", 1, new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 8, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8190) },
                    { 75, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8196), 12, new DateTime(2025, 6, 8, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8196), "08a0cbfc-7957-4fc8-b2d3-a7253f4a1d78", 1, new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 8, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8196) },
                    { 76, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8201), 11, new DateTime(2025, 6, 9, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8201), "7539f638-61f4-4063-81b1-385b44b8fbf4", 1, new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 9, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8201) },
                    { 77, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8207), 12, new DateTime(2025, 6, 9, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8207), "ad6999a2-d791-413e-8c85-e84eb2386d00", 1, new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 9, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8208) },
                    { 78, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8212), 11, new DateTime(2025, 6, 10, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8212), "9977d6bb-3ca9-44dc-9649-5862be4e548f", 1, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 10, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8212) },
                    { 79, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8218), 11, new DateTime(2025, 6, 10, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8219), "ac920d10-0b29-49e6-b53d-87d7e6b6b6ad", 1, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 10, 18, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8219) },
                    { 80, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8223), 12, new DateTime(2025, 6, 10, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8223), "bac568b6-b8ab-48d5-a552-28ce0fd4fd02", 1, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 10, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8223) },
                    { 81, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8228), 11, new DateTime(2025, 6, 11, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8228), "034fe3ce-e0c7-4a27-a154-144c07aac11b", 1, new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 11, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8228) },
                    { 82, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8234), 12, new DateTime(2025, 6, 11, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8234), "2d1d437c-5d50-4d70-a819-31fb17fefc3b", 1, new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 11, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8235) },
                    { 83, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8239), 11, new DateTime(2025, 6, 12, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8239), "6d0de519-c312-41fb-9928-e51d8208b2b1", 1, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 12, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8240) },
                    { 84, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8245), 12, new DateTime(2025, 6, 12, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8246), "a144defc-48bf-4233-841f-3f25091dba43", 1, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 12, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8246) },
                    { 85, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8251), 11, new DateTime(2025, 6, 13, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8252), "3693f565-e41e-4ee0-b8b5-9ef882d7a2c9", 1, new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 13, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8252) },
                    { 86, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8258), 11, new DateTime(2025, 6, 13, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8258), "192396e9-0343-4d9c-bc2d-7c675587a7e5", 1, new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 6, 13, 18, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8258) },
                    { 87, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8263), 12, new DateTime(2025, 6, 13, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8263), "6b340b69-74a9-469a-9a7f-5e96ff8c7231", 1, new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 6, 13, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(8263) }
                });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "SelectedStatus", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(4067), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(4070), 120.18m, new DateTime(2024, 11, 8, 10, 29, 23, 130, DateTimeKind.Local).AddTicks(2098), "Libero est repudiandae consequatur qui quaerat.", "Generic Rubber Sausages", "7686e0e2-276d-4634-9dbf-d4b96508935b", 5, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(4071) },
                    { 2, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(4311), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(4311), 105.08m, new DateTime(2025, 4, 1, 15, 0, 25, 722, DateTimeKind.Local).AddTicks(1397), "İllo adipisci eaque voluptatem quis dignissimos ea repellat non.", "Handcrafted Concrete Chips", "45fb51b7-4ec4-4b94-b7ec-5df3e752aaf1", 8, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(4312) },
                    { 3, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(4358), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(4358), 660.92m, new DateTime(2025, 4, 8, 7, 31, 34, 237, DateTimeKind.Local).AddTicks(4521), "Laboriosam est voluptatem possimus.", "Licensed Wooden Table", "56a9da7f-a776-4575-986f-e999cfcbcafa", 9, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(4358) },
                    { 4, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(4392), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(4392), 607.54m, new DateTime(2025, 4, 3, 16, 42, 42, 393, DateTimeKind.Local).AddTicks(8158), "Delectus aut quisquam sed deleniti itaque iure voluptatum est.", "Refined Frozen Ball", "5240cf98-b77b-4cf7-8304-304b7cae25d6", 2, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(4392) },
                    { 5, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(4427), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(4428), 542.46m, new DateTime(2025, 5, 25, 4, 40, 46, 105, DateTimeKind.Local).AddTicks(3575), "Quisquam optio ut et dolorem tenetur iure.", "Awesome Soft Car", "ab3f23b5-7eda-4cbe-9f78-30658314281a", 3, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(4428) },
                    { 6, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(4962), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(4963), 293.26m, new DateTime(2024, 6, 10, 16, 11, 33, 263, DateTimeKind.Local).AddTicks(8047), "Repellendus quis nostrum praesentium adipisci et facere qui.", "Sleek Soft Soap", "63c72d46-60bc-4290-a26c-a11af1cb4e96", 4, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(4963) },
                    { 7, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(5115), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(5115), 556.06m, new DateTime(2024, 9, 11, 12, 29, 33, 425, DateTimeKind.Local).AddTicks(5818), "Exercitationem ipsum recusandae dolorem et.", "Handmade Frozen Sausages", "b824be32-3116-4898-9599-d6fdf56e1f9a", 3, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(5115) },
                    { 8, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(5151), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(5151), 791.32m, new DateTime(2025, 3, 24, 12, 15, 0, 242, DateTimeKind.Local).AddTicks(4556), "Et qui deserunt ut corrupti sunt molestias ut possimus.", "Sleek Metal Mouse", "e05f429a-f252-44c4-a417-7a06c4e1b570", 9, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(5152) },
                    { 9, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(5187), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(5187), 681.65m, new DateTime(2025, 3, 16, 21, 45, 4, 590, DateTimeKind.Local).AddTicks(3273), "Repellat eius explicabo officiis neque voluptatibus dignissimos quis.", "Gorgeous Granite Bike", "b382c53e-0015-40de-b7b6-af9ecabcb0ae", 9, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(5187) },
                    { 10, new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(5227), new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(5227), 589.87m, new DateTime(2024, 9, 18, 6, 23, 28, 16, DateTimeKind.Local).AddTicks(6889), "Rerum veniam et quaerat magni ut dolorem illo ea ratione.", "Incredible Rubber Keyboard", "d8b7bb6f-3c2a-4595-8eb5-20aa03b88bce", 8, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 6, 7, 4, 10, 14, 163, DateTimeKind.Local).AddTicks(5228) }
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

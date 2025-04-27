using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class updatedProperties : Migration
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
                    EmployeeAddres = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    HourlyWage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                    RoomNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomCapacity = table.Column<int>(type: "int", nullable: false),
                    RoomBreakfast = table.Column<bool>(type: "bit", nullable: false),
                    PricePerNight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HasBalcony = table.Column<bool>(type: "bit", nullable: false),
                    HasMinibar = table.Column<bool>(type: "bit", nullable: false),
                    RoomType = table.Column<int>(type: "int", maxLength: 50, nullable: false),
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
                    Id = table.Column<int>(type: "int", nullable: false),
                    ShiftType = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_Shifts_Employees_Id",
                        column: x => x.Id,
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
                    PaymentVerification = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_Reservations_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
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
                    ExpenseStatus = table.Column<int>(type: "int", nullable: false),
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

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "SelectedStatus", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Pearlineport", "Holy See (Vatican City State)", new DateTime(2025, 4, 27, 12, 32, 41, 322, DateTimeKind.Local).AddTicks(7825), "95000 Lindgren Plain, Jerdestad, Mexico", "4", "GL8685088001679085", "909.218.5201", "Nelson_Anderson@hotmail.com", new DateTime(2025, 4, 27, 12, 32, 41, 322, DateTimeKind.Local).AddTicks(7835), "Ned", "Johnson", "42808b01-1198-45d8-af84-eacd3ad92778", "27626", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 322, DateTimeKind.Local).AddTicks(7836) },
                    { 2, "East Hayliefurt", "Colombia", new DateTime(2025, 4, 27, 12, 32, 41, 322, DateTimeKind.Local).AddTicks(9070), "21597 Huels Ridges, South Katelynnberg, Tuvalu", "3", "LB198448925M8SF176020F91274J", "(347) 485-4797 x8437", "Charlotte.Carter64@hotmail.com", new DateTime(2025, 4, 27, 12, 32, 41, 322, DateTimeKind.Local).AddTicks(9071), "George", "Treutel", "acc1e2cc-a46f-4e07-8467-3a465bf374dc", "91585", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 322, DateTimeKind.Local).AddTicks(9071) },
                    { 3, "Martinamouth", "Vanuatu", new DateTime(2025, 4, 27, 12, 32, 41, 322, DateTimeKind.Local).AddTicks(9347), "5944 Reinger Dale, New Korbinborough, Italy", "7", "LB980056839915E348872J9W9091", "417-578-8495", "Ara_West45@yahoo.com", new DateTime(2025, 4, 27, 12, 32, 41, 322, DateTimeKind.Local).AddTicks(9347), "Amir", "Bergnaum", "2828d7bd-44c1-4eed-aa8b-590a788232d9", "22587", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 322, DateTimeKind.Local).AddTicks(9348) },
                    { 4, "Kenyattaburgh", "Anguilla", new DateTime(2025, 4, 27, 12, 32, 41, 322, DateTimeKind.Local).AddTicks(9572), "6193 Beahan Trail, Kassulkemouth, Togo", "9", "GR5004083397769X97976097052", "437.935.6819 x177", "Natalie.Erdman@hotmail.com", new DateTime(2025, 4, 27, 12, 32, 41, 322, DateTimeKind.Local).AddTicks(9573), "Aniya", "Walker", "efd9440b-fe6e-4c9b-87be-eb450bd3d1fc", "62681-8090", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 322, DateTimeKind.Local).AddTicks(9573) },
                    { 5, "Lake Vaughntown", "Uruguay", new DateTime(2025, 4, 27, 12, 32, 41, 322, DateTimeKind.Local).AddTicks(9746), "0936 Marianne Plains, Port Colinborough, Virgin Islands, British", "1", "NO9384700023073", "1-883-953-0939 x3209", "Marilyne.Beier@gmail.com", new DateTime(2025, 4, 27, 12, 32, 41, 322, DateTimeKind.Local).AddTicks(9746), "Carolyn", "Gutmann", "f234ff77-ab5b-40ee-9fdb-f911b91d5af6", "08258-2503", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 322, DateTimeKind.Local).AddTicks(9746) },
                    { 6, "Gaymouth", "Costa Rica", new DateTime(2025, 4, 27, 12, 32, 41, 322, DateTimeKind.Local).AddTicks(9921), "5403 Lacey Ville, Hesselville, Heard Island and McDonald Islands", "6", "HU59155009004006693875005139", "880.529.5808 x242", "Elmore.Wiegand92@yahoo.com", new DateTime(2025, 4, 27, 12, 32, 41, 322, DateTimeKind.Local).AddTicks(9921), "Ena", "Waelchi", "82484933-7f53-45bb-8353-91144f4f33dd", "32664-1673", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 322, DateTimeKind.Local).AddTicks(9922) },
                    { 7, "East Charley", "Saint Vincent and the Grenadines", new DateTime(2025, 4, 27, 12, 32, 41, 323, DateTimeKind.Local).AddTicks(97), "26284 Hansen Stream, Skilesfort, Reunion", "3", "TR5909039477778477729M1IM4", "1-857-904-9532 x71171", "Ezequiel.Legros@yahoo.com", new DateTime(2025, 4, 27, 12, 32, 41, 323, DateTimeKind.Local).AddTicks(97), "Humberto", "Haag", "3cbce811-8119-4aa0-a0df-c8b8bf261936", "75177-2417", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 323, DateTimeKind.Local).AddTicks(98) },
                    { 8, "Port Vilma", "Bangladesh", new DateTime(2025, 4, 27, 12, 32, 41, 323, DateTimeKind.Local).AddTicks(271), "794 Tod Harbors, New Jarrellfort, Ghana", "5", "KZ2961217L2C56442482", "739.842.9837 x331", "Lavonne_Gottlieb2@gmail.com", new DateTime(2025, 4, 27, 12, 32, 41, 323, DateTimeKind.Local).AddTicks(271), "Orie", "Hammes", "dd0e980f-c859-4bb9-9aad-383065a93ca8", "29641-5688", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 323, DateTimeKind.Local).AddTicks(271) },
                    { 9, "Lottiemouth", "Guatemala", new DateTime(2025, 4, 27, 12, 32, 41, 323, DateTimeKind.Local).AddTicks(567), "30697 Eloisa Estates, New Sherman, Israel", "7", "ME13900983610092024016", "(917) 390-1010", "Destany_Huel@yahoo.com", new DateTime(2025, 4, 27, 12, 32, 41, 323, DateTimeKind.Local).AddTicks(568), "Rosie", "Kreiger", "89062469-b4ad-47f3-9fa8-889923d234fa", "93127-3507", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 323, DateTimeKind.Local).AddTicks(568) },
                    { 10, "New Libbyhaven", "Panama", new DateTime(2025, 4, 27, 12, 32, 41, 323, DateTimeKind.Local).AddTicks(728), "0711 Auer Islands, Dillanport, Swaziland", "1", "MC5802006200594Q768E9P3T130", "(227) 867-3689", "Kristofer_Ratke@hotmail.com", new DateTime(2025, 4, 27, 12, 32, 41, 323, DateTimeKind.Local).AddTicks(728), "Kelley", "Gutkowski", "4ed0a8bc-4ecc-4d24-8e87-0823469a8e16", "77582", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 323, DateTimeKind.Local).AddTicks(729) }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "HourlyWage", "MasterId", "PostalCode", "SelectedStatus", "Status", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Port Elenorberg", "Bermuda", new DateTime(2026, 2, 27, 4, 35, 21, 282, DateTimeKind.Local).AddTicks(7207), "Adele_Sporer@yahoo.com", "5540 Gianni Shoals, Lake Elainatown, Saint Helena", "Savannah", "Simonis", "1-887-659-1693", new DateTime(2025, 4, 27, 12, 32, 41, 331, DateTimeKind.Local).AddTicks(2598), 0m, "069447af-7bce-4d3a-a8eb-9cc433630b37", "80130-3353", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2026, 6, 17, 19, 41, 29, 113, DateTimeKind.Local).AddTicks(5738) },
                    { 2, "Leopoldoshire", "Jersey", new DateTime(2026, 1, 28, 18, 5, 44, 228, DateTimeKind.Local).AddTicks(8630), "Lela25@hotmail.com", "585 Feil Rapids, Laurelshire, Turkey", "Rafaela", "Lebsack", "(222) 751-2192 x640", new DateTime(2025, 4, 27, 12, 32, 41, 331, DateTimeKind.Local).AddTicks(3241), 0m, "6218d751-46c3-446a-8c82-05e35057c694", "85937-0707", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2027, 1, 12, 4, 30, 48, 912, DateTimeKind.Local).AddTicks(2546) },
                    { 3, "Beckermouth", "Nauru", new DateTime(2025, 10, 19, 4, 11, 9, 150, DateTimeKind.Local).AddTicks(848), "Anjali24@hotmail.com", "5442 Watson Light, South Reynold, Brazil", "Edwardo", "Schiller", "(592) 376-9652", new DateTime(2025, 4, 27, 12, 32, 41, 331, DateTimeKind.Local).AddTicks(3428), 0m, "5a5c57c9-b8fc-4c06-b4fe-1a6d2fe48182", "20891", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2026, 5, 22, 4, 34, 30, 9, DateTimeKind.Local).AddTicks(1007) },
                    { 4, "Oranbury", "Netherlands", new DateTime(2025, 5, 27, 13, 19, 11, 819, DateTimeKind.Local).AddTicks(4906), "Berta10@gmail.com", "2762 Cristal Field, Douglasfurt, Germany", "Beau", "Tromp", "966.207.9863", new DateTime(2025, 4, 27, 12, 32, 41, 331, DateTimeKind.Local).AddTicks(3575), 0m, "f644f3ec-beef-470d-b71f-6bed77eeffc4", "71709", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 12, 15, 9, 19, 45, 702, DateTimeKind.Local).AddTicks(5106) },
                    { 5, "Port Yessenia", "Somalia", new DateTime(2025, 9, 21, 17, 49, 7, 307, DateTimeKind.Local).AddTicks(9154), "Duane52@yahoo.com", "24409 Erin Vista, North Genoveva, Sierra Leone", "Annamae", "Labadie", "(710) 786-6904 x8010", new DateTime(2025, 4, 27, 12, 32, 41, 331, DateTimeKind.Local).AddTicks(3702), 0m, "c3e9b9db-8767-44f2-afcf-747b5c27b154", "91474", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2026, 5, 6, 11, 15, 1, 982, DateTimeKind.Local).AddTicks(3883) },
                    { 6, "Port Josephine", "Azerbaijan", new DateTime(2026, 1, 24, 20, 47, 50, 800, DateTimeKind.Local).AddTicks(5553), "Dangelo_Lockman@yahoo.com", "7227 Moriah Corner, North Josianeshire, Vietnam", "Dion", "Walsh", "1-785-726-0319", new DateTime(2025, 4, 27, 12, 32, 41, 331, DateTimeKind.Local).AddTicks(3834), 0m, "64cfd2ae-f8be-4c4c-90e2-b7dd3b1f2e4e", "08031", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2026, 5, 8, 17, 36, 32, 666, DateTimeKind.Local).AddTicks(7166) },
                    { 7, "Nehaberg", "Northern Mariana Islands", new DateTime(2025, 12, 15, 9, 1, 34, 979, DateTimeKind.Local).AddTicks(8967), "Eva9@hotmail.com", "8602 Ed Station, East Pedrotown, Benin", "Laurine", "Stracke", "1-231-788-6211", new DateTime(2025, 4, 27, 12, 32, 41, 332, DateTimeKind.Local).AddTicks(3015), 0m, "e743f570-bd77-45ee-af29-21cc5ca12e03", "34140-8474", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2026, 1, 21, 17, 39, 0, 488, DateTimeKind.Local).AddTicks(4939) },
                    { 8, "Lake Zoe", "Saint Pierre and Miquelon", new DateTime(2026, 3, 5, 5, 6, 38, 799, DateTimeKind.Local).AddTicks(1758), "Yoshiko39@gmail.com", "22684 Oberbrunner Fort, North Hopehaven, Anguilla", "Virgil", "Schuster", "941-909-7879 x653", new DateTime(2025, 4, 27, 12, 32, 41, 332, DateTimeKind.Local).AddTicks(3251), 0m, "77fc60cc-9227-45a2-9ead-72e03d17df37", "95681-0665", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2026, 4, 16, 8, 19, 47, 645, DateTimeKind.Local).AddTicks(8777) },
                    { 9, "East Christopher", "Puerto Rico", new DateTime(2025, 6, 27, 0, 31, 17, 691, DateTimeKind.Local).AddTicks(1078), "Dax57@gmail.com", "859 Kreiger Lane, Wolfshire, Norway", "Edyth", "Bailey", "743-769-6814", new DateTime(2025, 4, 27, 12, 32, 41, 332, DateTimeKind.Local).AddTicks(3396), 0m, "0f8ef387-f1a8-4daa-97bc-d1a564d78927", "93898", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 9, 11, 1, 58, 17, 729, DateTimeKind.Local).AddTicks(2469) },
                    { 10, "Bartonmouth", "Romania", new DateTime(2025, 7, 10, 2, 34, 32, 406, DateTimeKind.Local).AddTicks(2407), "Lillie.Beer31@hotmail.com", "14291 Leonard Manors, East Alfreda, Cameroon", "Mona", "Cremin", "1-485-350-8650", new DateTime(2025, 4, 27, 12, 32, 41, 332, DateTimeKind.Local).AddTicks(3531), 0m, "c668f52a-0de8-4cce-8c23-7e011525cce1", "41979", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2026, 7, 8, 9, 15, 27, 58, DateTimeKind.Local).AddTicks(7139) }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedDate", "DataStasus", "Description", "EntryDate", "Floor", "HasAirConditioning", "HasBalcony", "HasHairDryer", "HasMinibar", "HasTV", "HasWiFi", "ImageUrl", "MasterId", "PricePerNight", "RoomBreakfast", "RoomCapacity", "RoomNumber", "RoomType", "SelectedStatus", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(1458), 0, "Omnis iste molestias animi qui.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(1461), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=573", "f0d82732-7596-4b52-b250-7951b99ce941", 1750.83m, false, 1, "1", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(1462) },
                    { 2, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(1758), 1, "Nobis doloribus quia et ut.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(1758), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=162", "cdd0ee93-7d0c-4bb6-a433-f0527dd6373a", 2035.72m, true, 2, "2", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(1759) },
                    { 3, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(1797), 2, "Occaecati aut sequi aut quidem.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(1797), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=763", "73220869-038c-4261-8595-d0b2bf10d7f9", 2376.40m, true, 3, "3", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(1797) },
                    { 4, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(1828), 3, "Est voluptatibus beatae quidem et.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(1829), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=244", "5820b25c-deb1-48d7-9048-8f0ed1af0ff3", 1784.44m, true, 4, "4", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(1829) },
                    { 5, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(1859), 4, "Sit voluptate excepturi ipsam nisi.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(1859), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=880", "186e2749-e45b-43a5-a097-1c6ff4c4a9f4", 1834.96m, true, 5, "5", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(1859) },
                    { 6, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(1889), 5, "İllo natus omnis et cumque.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(1890), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=855", "ea129cd4-5505-44ef-8af0-5f27a8c3a6a1", 2268.96m, false, 1, "6", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(1890) },
                    { 7, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(1916), 0, "İpsa est debitis voluptatem animi.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(1916), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=681", "e9d68056-1148-4abe-ae17-ff01fa03e6c3", 2433.99m, true, 2, "7", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(1916) },
                    { 8, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(1940), 1, "Ut sapiente in ad quibusdam.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(1940), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=320", "439fdaa9-8963-40dc-97c4-ef976fbd70a0", 2007.73m, true, 3, "8", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(1940) },
                    { 9, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(1972), 2, "Omnis qui consequatur placeat nobis.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(1974), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=676", "c49aacc6-270f-4862-8c7e-c6adb7d080a7", 2475.80m, true, 4, "9", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(1974) },
                    { 10, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(1999), 3, "Quo est eligendi voluptatibus quis.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(1999), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=601", "da8ac11b-256a-4e02-8110-7adcfb27df11", 1878.93m, true, 5, "10", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(1999) },
                    { 11, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2021), 4, "Eveniet soluta non eos aut.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2021), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=934", "40a68140-bc81-4f23-9ef0-3f17b8635067", 2394.31m, false, 1, "11", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2021) },
                    { 12, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2043), 5, "Occaecati voluptatem veritatis praesentium et.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2044), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=205", "4cb1eeb8-0dc6-42a7-8777-19b334775c0a", 1539.88m, true, 2, "12", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2044) },
                    { 13, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2067), 0, "Qui et omnis unde expedita.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2067), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=877", "94a836cc-4b4f-4f3f-8019-33172d85a9b3", 1538.94m, true, 3, "13", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2068) },
                    { 14, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2095), 1, "Exercitationem praesentium sunt sunt ducimus.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2096), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=288", "61168d7d-d6b2-47cf-92e0-544f5a4d702a", 1957.56m, true, 4, "14", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2096) },
                    { 15, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2120), 2, "Voluptate enim commodi aut est.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2121), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=33", "da04794b-b388-4d6e-ae4b-049e8244c711", 2338.67m, true, 5, "15", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2121) },
                    { 16, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2143), 3, "Aut ab et veniam nostrum.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2143), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=727", "e16c5a0d-2197-439c-bab5-90b34932edf7", 1963.71m, false, 1, "16", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2143) },
                    { 17, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2166), 4, "Possimus voluptas aut voluptas exercitationem.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2166), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=140", "07b4ece1-f895-4d61-bce1-9eb2d8038081", 2320.36m, true, 2, "17", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2166) },
                    { 18, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2187), 5, "Hic aperiam sapiente pariatur aspernatur.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2187), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=909", "419c2ab0-58f4-4e45-b286-46eec3cedcef", 1866.45m, true, 3, "18", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2188) },
                    { 19, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2215), 0, "Quis odio quaerat nulla doloribus.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2215), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=67", "d9566b85-d9c2-401d-bd63-6ca81e6a921e", 2069.42m, true, 4, "19", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2216) },
                    { 20, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2239), 1, "Et aut dolorem vitae omnis.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2239), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=661", "c15466b3-0539-4020-a46c-b8f83280de74", 1622.79m, true, 5, "20", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2239) },
                    { 21, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2261), 2, "Sapiente soluta aut minus aut.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2261), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=478", "8ec02fc0-5152-4cf1-af0b-3ed9d11e92aa", 1950.97m, false, 1, "21", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2262) },
                    { 22, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2283), 3, "Et ipsam est dolorem qui.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2283), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=819", "6f1cfea4-cac2-4047-a0b4-e6d6d64a05b0", 2177.11m, true, 2, "22", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2283) },
                    { 23, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2304), 4, "Nihil quo id perspiciatis placeat.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2304), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=323", "b307b4d5-1b10-4e94-8462-6c46c533afd1", 2461.09m, true, 3, "23", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2305) },
                    { 24, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2331), 5, "Quo cumque et possimus quia.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2332), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=892", "c3beedd7-257b-454a-a159-5a696964e2df", 2136.31m, true, 4, "24", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2333) },
                    { 25, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2354), 0, "Eum sunt et vero voluptate.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2354), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=616", "fdbc972f-6a7e-4fed-89cf-9119094a0765", 2102.15m, true, 5, "25", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2355) },
                    { 26, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2376), 1, "Eos qui aut laboriosam eaque.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2376), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=964", "067602dc-071a-4a0c-a5e0-74c9a0b0937b", 1840.20m, false, 1, "26", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2376) },
                    { 27, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2398), 2, "Sequi quam sint sed et.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2398), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=287", "878ab1d9-0ab4-4a6d-a484-7f6a53279235", 2090.22m, true, 2, "27", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2398) },
                    { 28, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2419), 3, "Repudiandae explicabo rerum hic accusamus.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2419), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=461", "58aaa247-4fdf-4007-8e93-a1054ea4d288", 1683.24m, true, 3, "28", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2419) },
                    { 29, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2442), 4, "Expedita sit saepe rerum aut.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2443), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=1052", "38cf3a01-0667-4650-89c7-d7e206efff20", 1589.28m, true, 4, "29", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2443) },
                    { 30, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2471), 5, "İusto accusantium sit incidunt fugiat.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2471), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=479", "15998428-a046-4e96-b255-1783e1c1a106", 2013.10m, true, 5, "30", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2471) },
                    { 31, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2491), 0, "Dolores maxime natus voluptatem saepe.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2492), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=953", "174f6754-875a-4e2f-a38b-e3331fb8ef09", 1713.52m, false, 1, "31", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2492) },
                    { 32, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2512), 1, "Quisquam aliquam praesentium eius eius.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2512), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=736", "ca363fc8-3cb4-41cd-a873-6dc8f044251b", 2216.70m, true, 2, "32", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2513) },
                    { 33, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2535), 2, "Est repellendus veniam id facilis.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2535), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=474", "fd2863bf-ff8e-4519-8998-5098143ab458", 1534.87m, true, 3, "33", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2535) },
                    { 34, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2617), 3, "Facilis aperiam aut sint fugiat.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2618), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=886", "fde8f55a-e3b0-4847-9574-4d436d704242", 1793.05m, true, 4, "34", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2618) },
                    { 35, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2750), 4, "Aut perspiciatis vero necessitatibus officia.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2751), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=806", "074802d5-c44b-4b8c-960a-4ac0dc8989ad", 1591.98m, true, 5, "35", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2751) },
                    { 36, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2776), 5, "Praesentium quos rerum ut consequuntur.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2776), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=116", "99445916-3a99-42ae-97de-056d604c0aec", 2091.02m, false, 1, "36", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2776) },
                    { 37, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2799), 0, "Quasi est nemo saepe est.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2799), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=851", "38651fad-330f-4794-8ea0-0be89f8b8efe", 2456.62m, true, 2, "37", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2799) },
                    { 38, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2820), 1, "Et molestiae excepturi hic corporis.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2821), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=877", "6aec7e9a-dea0-4e14-bd72-e1a4b8d2e023", 1833.00m, true, 3, "38", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2821) },
                    { 39, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2847), 2, "Maxime consequuntur deserunt quia quia.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2847), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=1078", "be3e6c44-dfa2-478d-ac46-f96eb748a9dc", 1595.75m, true, 4, "39", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2847) },
                    { 40, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2868), 3, "Excepturi quibusdam voluptates nesciunt enim.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2868), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=78", "89d3d4ac-04a5-4f22-b945-94f3b663936a", 2454.35m, true, 5, "40", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2869) },
                    { 41, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2890), 4, "Distinctio eaque molestiae ipsam veniam.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2890), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=494", "6299065b-0b5a-47f9-84e3-535584439b38", 2181.92m, false, 1, "41", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2890) },
                    { 42, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2910), 5, "İste placeat rerum non ut.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2910), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=340", "1b2ce4f4-175a-4194-b3d7-22edfa062a36", 1603.32m, true, 2, "42", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2910) },
                    { 43, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2931), 0, "Voluptate dignissimos beatae qui sed.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2931), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=797", "560bdca6-1c60-4741-aeb8-13ceb6b0a810", 1794.39m, true, 3, "43", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2932) },
                    { 44, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2957), 1, "Rem earum accusamus aut nulla.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2957), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=88", "db4c7536-a499-43a5-968b-bda3e7642785", 1990.28m, true, 4, "44", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2957) },
                    { 45, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2980), 2, "Quia voluptas itaque rerum incidunt.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2980), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=587", "4c781219-d799-49ea-87ae-6ec55145b877", 1890.36m, true, 5, "45", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(2981) },
                    { 46, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(3001), 3, "Quae soluta non iste id.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(3001), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=937", "84a1954b-7e41-4f7b-92bb-713ba26df9e0", 1970.20m, false, 1, "46", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(3002) },
                    { 47, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(3021), 4, "Quis vel sed delectus aut.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(3022), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=641", "2acfca61-8f72-4161-b58f-4dd7d32a84bc", 2096.63m, true, 2, "47", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(3022) },
                    { 48, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(3042), 5, "Molestiae minus reprehenderit nemo sed.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(3043), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=188", "b83fdf64-616a-4e58-832c-6398b6c81c48", 2103.33m, true, 3, "48", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(3043) },
                    { 49, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(3070), 0, "Quidem est voluptates eaque facilis.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(3071), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=210", "1b6a29af-8082-4081-9e5b-afa04a583a09", 1733.22m, true, 4, "49", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(3071) },
                    { 50, new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(3091), 1, "Reprehenderit rerum pariatur asperiores repellendus.", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(3092), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=931", "db515cfb-cc3b-49ea-a6cd-305bc0b1bf65", 2431.23m, true, 5, "50", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 324, DateTimeKind.Local).AddTicks(3092) }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "PackageType", "PaymentVerification", "RoomId", "SelectedStatus", "TotalAmount", "UpdatedComputerName", "UpdatedDate", "UserId", "status" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 26, 20, 37, 50, 457, DateTimeKind.Local).AddTicks(5685), new DateTime(2026, 9, 30, 14, 35, 35, 0, DateTimeKind.Local).AddTicks(1920), new DateTime(2025, 4, 27, 12, 32, 41, 333, DateTimeKind.Local).AddTicks(4306), 6, new DateTime(2025, 4, 27, 12, 32, 41, 333, DateTimeKind.Local).AddTicks(4306), "7bfa1f60-a291-490b-8361-cdc664e0c998", 0, "6399-0662-7278-9428", 39, 4, 1720.21m, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 333, DateTimeKind.Local).AddTicks(4307), null, 0 },
                    { 2, new DateTime(2025, 11, 26, 23, 9, 34, 567, DateTimeKind.Local).AddTicks(9141), new DateTime(2026, 10, 25, 14, 39, 55, 499, DateTimeKind.Local).AddTicks(6461), new DateTime(2025, 4, 27, 12, 32, 41, 333, DateTimeKind.Local).AddTicks(5013), 9, new DateTime(2025, 4, 27, 12, 32, 41, 333, DateTimeKind.Local).AddTicks(5014), "6d677df5-92f7-4629-8ae3-c630b7a4d854", 1, "6759-5917-2385-2545", 42, 4, 1819.61m, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 333, DateTimeKind.Local).AddTicks(5014), null, 1 },
                    { 3, new DateTime(2025, 12, 27, 23, 13, 30, 454, DateTimeKind.Local).AddTicks(36), new DateTime(2026, 10, 28, 13, 16, 24, 633, DateTimeKind.Local).AddTicks(628), new DateTime(2025, 4, 27, 12, 32, 41, 333, DateTimeKind.Local).AddTicks(5164), 6, new DateTime(2025, 4, 27, 12, 32, 41, 333, DateTimeKind.Local).AddTicks(5164), "b8fbafd8-4036-4a30-83c3-297646116f5e", 0, "6759-5414-3937-9794-77", 6, 4, 1539.26m, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 333, DateTimeKind.Local).AddTicks(5164), null, 2 },
                    { 4, new DateTime(2026, 3, 27, 17, 44, 43, 276, DateTimeKind.Local).AddTicks(3234), new DateTime(2026, 8, 14, 21, 16, 7, 167, DateTimeKind.Local).AddTicks(4275), new DateTime(2025, 4, 27, 12, 32, 41, 333, DateTimeKind.Local).AddTicks(5294), 2, new DateTime(2025, 4, 27, 12, 32, 41, 333, DateTimeKind.Local).AddTicks(5294), "d0bb900c-0fa2-4920-93b1-2f49d058a413", 1, "3711-697482-28545", 16, 4, 1874.99m, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 333, DateTimeKind.Local).AddTicks(5295), null, 3 },
                    { 5, new DateTime(2026, 2, 25, 23, 1, 14, 208, DateTimeKind.Local).AddTicks(695), new DateTime(2026, 11, 19, 12, 46, 44, 490, DateTimeKind.Local).AddTicks(5413), new DateTime(2025, 4, 27, 12, 32, 41, 333, DateTimeKind.Local).AddTicks(5424), 8, new DateTime(2025, 4, 27, 12, 32, 41, 333, DateTimeKind.Local).AddTicks(5424), "b5e1ec97-1d1d-4e2f-ac00-37fbed43ad07", 0, "6532-3770-7716-5591", 46, 4, 1939.38m, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 333, DateTimeKind.Local).AddTicks(5425), null, 4 },
                    { 6, new DateTime(2026, 3, 16, 11, 9, 54, 828, DateTimeKind.Local).AddTicks(3257), new DateTime(2027, 3, 7, 14, 36, 11, 176, DateTimeKind.Local).AddTicks(1926), new DateTime(2025, 4, 27, 12, 32, 41, 333, DateTimeKind.Local).AddTicks(5551), 10, new DateTime(2025, 4, 27, 12, 32, 41, 333, DateTimeKind.Local).AddTicks(5551), "f99721f9-519e-4ac1-9000-9c7b223614b3", 1, "4475-0295-3370-2806", 36, 4, 2016.39m, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 333, DateTimeKind.Local).AddTicks(5552), null, 5 },
                    { 7, new DateTime(2025, 7, 17, 10, 39, 6, 940, DateTimeKind.Local).AddTicks(693), new DateTime(2025, 9, 30, 19, 23, 6, 31, DateTimeKind.Local).AddTicks(3111), new DateTime(2025, 4, 27, 12, 32, 41, 333, DateTimeKind.Local).AddTicks(5678), 8, new DateTime(2025, 4, 27, 12, 32, 41, 333, DateTimeKind.Local).AddTicks(5679), "9f3ff1b4-52fc-4def-9e29-7d04ec8554eb", 0, "6771789637335169", 9, 4, 1947.45m, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 333, DateTimeKind.Local).AddTicks(5679), null, 0 },
                    { 8, new DateTime(2025, 10, 15, 9, 27, 28, 205, DateTimeKind.Local).AddTicks(3999), new DateTime(2026, 3, 29, 6, 30, 2, 322, DateTimeKind.Local).AddTicks(1867), new DateTime(2025, 4, 27, 12, 32, 41, 333, DateTimeKind.Local).AddTicks(5806), 9, new DateTime(2025, 4, 27, 12, 32, 41, 333, DateTimeKind.Local).AddTicks(5806), "e00e1554-b67e-4abd-ab2d-38f28b97a30e", 1, "6771-8972-3479-7523", 28, 4, 1667.58m, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 333, DateTimeKind.Local).AddTicks(5806), null, 1 },
                    { 9, new DateTime(2026, 1, 14, 2, 43, 9, 300, DateTimeKind.Local).AddTicks(4718), new DateTime(2026, 12, 15, 23, 36, 30, 505, DateTimeKind.Local).AddTicks(7944), new DateTime(2025, 4, 27, 12, 32, 41, 333, DateTimeKind.Local).AddTicks(5931), 4, new DateTime(2025, 4, 27, 12, 32, 41, 333, DateTimeKind.Local).AddTicks(5932), "75e719e8-be8f-4166-a06e-f8ba8dc5facb", 0, "3584-0174-7314-7157", 45, 4, 1722.59m, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 333, DateTimeKind.Local).AddTicks(5932), null, 2 },
                    { 10, new DateTime(2025, 5, 25, 5, 36, 37, 692, DateTimeKind.Local).AddTicks(9635), new DateTime(2025, 8, 22, 18, 54, 52, 651, DateTimeKind.Local).AddTicks(9417), new DateTime(2025, 4, 27, 12, 32, 41, 333, DateTimeKind.Local).AddTicks(6062), 9, new DateTime(2025, 4, 27, 12, 32, 41, 333, DateTimeKind.Local).AddTicks(6063), "2084fc43-57ff-42c8-95e0-bd63608ec6c4", 1, "58935379469315077", 10, 4, 1597.28m, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 333, DateTimeKind.Local).AddTicks(6063), null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Shifts",
                columns: new[] { "Id", "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "SelectedStatus", "ShiftType", "StartTime", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 27, 12, 32, 41, 330, DateTimeKind.Local).AddTicks(2073), 8, new DateTime(2025, 5, 9, 18, 21, 24, 193, DateTimeKind.Local).AddTicks(7814), new DateTime(2025, 4, 27, 12, 32, 41, 330, DateTimeKind.Local).AddTicks(2078), "9d4d34dd-5892-4177-bb62-61ce73fb8148", 4, 1, new DateTime(2024, 10, 12, 13, 18, 18, 634, DateTimeKind.Local).AddTicks(2254), "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 330, DateTimeKind.Local).AddTicks(2079) },
                    { 2, new DateTime(2025, 4, 27, 12, 32, 41, 330, DateTimeKind.Local).AddTicks(2253), 1, new DateTime(2025, 5, 6, 23, 53, 52, 494, DateTimeKind.Local).AddTicks(8946), new DateTime(2025, 4, 27, 12, 32, 41, 330, DateTimeKind.Local).AddTicks(2253), "d6e9f986-9c3d-46d2-bcb6-e9f7d7a2630c", 4, 0, new DateTime(2024, 8, 18, 2, 56, 48, 707, DateTimeKind.Local).AddTicks(9513), "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 330, DateTimeKind.Local).AddTicks(2253) },
                    { 3, new DateTime(2025, 4, 27, 12, 32, 41, 330, DateTimeKind.Local).AddTicks(2262), 6, new DateTime(2025, 6, 18, 12, 26, 23, 888, DateTimeKind.Local).AddTicks(8522), new DateTime(2025, 4, 27, 12, 32, 41, 330, DateTimeKind.Local).AddTicks(2262), "f6484d95-60be-48b9-8ccf-12856b4f9642", 4, 2, new DateTime(2025, 3, 19, 4, 19, 21, 455, DateTimeKind.Local).AddTicks(4006), "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 330, DateTimeKind.Local).AddTicks(2262) },
                    { 4, new DateTime(2025, 4, 27, 12, 32, 41, 330, DateTimeKind.Local).AddTicks(2269), 3, new DateTime(2025, 5, 21, 10, 53, 39, 434, DateTimeKind.Local).AddTicks(9726), new DateTime(2025, 4, 27, 12, 32, 41, 330, DateTimeKind.Local).AddTicks(2269), "92ddf12c-9b36-407c-b914-98f176c3cc1e", 4, 2, new DateTime(2024, 10, 8, 23, 4, 46, 798, DateTimeKind.Local).AddTicks(6504), "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 330, DateTimeKind.Local).AddTicks(2269) },
                    { 5, new DateTime(2025, 4, 27, 12, 32, 41, 330, DateTimeKind.Local).AddTicks(2275), 8, new DateTime(2025, 10, 7, 0, 57, 52, 752, DateTimeKind.Local).AddTicks(2430), new DateTime(2025, 4, 27, 12, 32, 41, 330, DateTimeKind.Local).AddTicks(2275), "3b73ad9c-5628-4e0f-a3ed-3436b363c67d", 4, 0, new DateTime(2024, 12, 22, 18, 5, 59, 968, DateTimeKind.Local).AddTicks(1627), "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 330, DateTimeKind.Local).AddTicks(2275) },
                    { 6, new DateTime(2025, 4, 27, 12, 32, 41, 330, DateTimeKind.Local).AddTicks(2282), 9, new DateTime(2025, 9, 19, 10, 5, 3, 996, DateTimeKind.Local).AddTicks(4397), new DateTime(2025, 4, 27, 12, 32, 41, 330, DateTimeKind.Local).AddTicks(2282), "c89268c0-fb4d-4c0f-a4f2-315bb7daad1d", 4, 0, new DateTime(2025, 1, 13, 17, 6, 44, 140, DateTimeKind.Local).AddTicks(6940), "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 330, DateTimeKind.Local).AddTicks(2282) },
                    { 7, new DateTime(2025, 4, 27, 12, 32, 41, 330, DateTimeKind.Local).AddTicks(2288), 6, new DateTime(2025, 11, 13, 10, 53, 37, 559, DateTimeKind.Local).AddTicks(3894), new DateTime(2025, 4, 27, 12, 32, 41, 330, DateTimeKind.Local).AddTicks(2288), "c9431088-30bd-404e-a636-461cfc121d1d", 4, 0, new DateTime(2024, 9, 10, 13, 57, 10, 258, DateTimeKind.Local).AddTicks(2660), "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 330, DateTimeKind.Local).AddTicks(2289) },
                    { 8, new DateTime(2025, 4, 27, 12, 32, 41, 330, DateTimeKind.Local).AddTicks(2295), 3, new DateTime(2026, 2, 4, 21, 31, 46, 438, DateTimeKind.Local).AddTicks(3638), new DateTime(2025, 4, 27, 12, 32, 41, 330, DateTimeKind.Local).AddTicks(2295), "6d37bb77-49d2-42a9-9570-c5bca1c86c86", 4, 0, new DateTime(2024, 11, 12, 11, 8, 22, 557, DateTimeKind.Local).AddTicks(9912), "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 330, DateTimeKind.Local).AddTicks(2295) },
                    { 9, new DateTime(2025, 4, 27, 12, 32, 41, 330, DateTimeKind.Local).AddTicks(2305), 5, new DateTime(2025, 7, 7, 1, 18, 56, 106, DateTimeKind.Local).AddTicks(7038), new DateTime(2025, 4, 27, 12, 32, 41, 330, DateTimeKind.Local).AddTicks(2305), "d7142b01-8444-4523-b1a7-afdd7a840008", 4, 0, new DateTime(2024, 5, 28, 18, 59, 22, 127, DateTimeKind.Local).AddTicks(4686), "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 330, DateTimeKind.Local).AddTicks(2305) },
                    { 10, new DateTime(2025, 4, 27, 12, 32, 41, 330, DateTimeKind.Local).AddTicks(2312), 9, new DateTime(2025, 11, 30, 6, 12, 43, 154, DateTimeKind.Local).AddTicks(7900), new DateTime(2025, 4, 27, 12, 32, 41, 330, DateTimeKind.Local).AddTicks(2312), "fa79cb68-a0d0-408c-85ed-62402a15faeb", 4, 0, new DateTime(2024, 10, 1, 19, 22, 45, 139, DateTimeKind.Local).AddTicks(871), "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 330, DateTimeKind.Local).AddTicks(2312) }
                });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "ExpenseStatus", "MasterId", "ReservationId", "SelectedStatus", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 27, 12, 32, 41, 329, DateTimeKind.Local).AddTicks(1679), new DateTime(2025, 4, 27, 12, 32, 41, 329, DateTimeKind.Local).AddTicks(1685), 748.31m, new DateTime(2024, 6, 30, 8, 11, 50, 960, DateTimeKind.Local).AddTicks(4557), "Laudantium nobis nam et hic in qui.", "Intelligent Rubber Bike", 4, "1fe9c9da-1dd8-48c6-801f-4f52c75419f4", 9, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 329, DateTimeKind.Local).AddTicks(1686) },
                    { 2, new DateTime(2025, 4, 27, 12, 32, 41, 329, DateTimeKind.Local).AddTicks(2017), new DateTime(2025, 4, 27, 12, 32, 41, 329, DateTimeKind.Local).AddTicks(2018), 580.34m, new DateTime(2024, 8, 4, 15, 56, 30, 660, DateTimeKind.Local).AddTicks(935), "A rerum voluptas vero unde adipisci assumenda sunt numquam.", "Awesome Fresh Salad", 4, "91bbe2c2-3bf9-4b6f-a125-22deb5cfce2c", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 329, DateTimeKind.Local).AddTicks(2018) },
                    { 3, new DateTime(2025, 4, 27, 12, 32, 41, 329, DateTimeKind.Local).AddTicks(2067), new DateTime(2025, 4, 27, 12, 32, 41, 329, DateTimeKind.Local).AddTicks(2068), 414.25m, new DateTime(2024, 11, 1, 15, 3, 12, 493, DateTimeKind.Local).AddTicks(4312), "Rem eius in iure molestias ipsam rerum.", "Awesome Granite Mouse", 4, "cc21b5e9-e129-4a94-8564-168b14c2fe34", 7, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 329, DateTimeKind.Local).AddTicks(2068) },
                    { 4, new DateTime(2025, 4, 27, 12, 32, 41, 329, DateTimeKind.Local).AddTicks(2104), new DateTime(2025, 4, 27, 12, 32, 41, 329, DateTimeKind.Local).AddTicks(2104), 38.52m, new DateTime(2024, 11, 7, 8, 46, 12, 495, DateTimeKind.Local).AddTicks(6250), "Blanditiis eum et qui itaque ad repudiandae aut.", "Tasty Metal Shirt", 4, "a871650a-131e-4753-af54-97f0f356094b", 8, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 329, DateTimeKind.Local).AddTicks(2104) },
                    { 5, new DateTime(2025, 4, 27, 12, 32, 41, 329, DateTimeKind.Local).AddTicks(2143), new DateTime(2025, 4, 27, 12, 32, 41, 329, DateTimeKind.Local).AddTicks(2144), 466.85m, new DateTime(2024, 7, 10, 2, 16, 3, 338, DateTimeKind.Local).AddTicks(4561), "Eos iste tempora eos sunt praesentium nam aliquid.", "Rustic Concrete Table", 4, "6a558051-9261-49c7-ae27-77f824927ef2", 6, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 329, DateTimeKind.Local).AddTicks(2145) },
                    { 6, new DateTime(2025, 4, 27, 12, 32, 41, 329, DateTimeKind.Local).AddTicks(2176), new DateTime(2025, 4, 27, 12, 32, 41, 329, DateTimeKind.Local).AddTicks(2176), 430.10m, new DateTime(2024, 6, 2, 23, 3, 19, 429, DateTimeKind.Local).AddTicks(5067), "Et architecto nihil non consequuntur qui.", "Incredible Frozen Ball", 4, "61865e90-be75-45bf-a0e0-d1de7e52606f", 7, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 329, DateTimeKind.Local).AddTicks(2176) },
                    { 7, new DateTime(2025, 4, 27, 12, 32, 41, 329, DateTimeKind.Local).AddTicks(2271), new DateTime(2025, 4, 27, 12, 32, 41, 329, DateTimeKind.Local).AddTicks(2272), 94.70m, new DateTime(2025, 4, 14, 3, 40, 9, 319, DateTimeKind.Local).AddTicks(2940), "Et incidunt quaerat ut.", "Generic Wooden Fish", 4, "eaa84e52-60a7-4476-bfcf-129b53edb542", 7, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 329, DateTimeKind.Local).AddTicks(2272) },
                    { 8, new DateTime(2025, 4, 27, 12, 32, 41, 329, DateTimeKind.Local).AddTicks(2316), new DateTime(2025, 4, 27, 12, 32, 41, 329, DateTimeKind.Local).AddTicks(2317), 55.39m, new DateTime(2025, 3, 21, 13, 42, 1, 76, DateTimeKind.Local).AddTicks(235), "Vero et cum velit qui dolorem expedita sunt.", "Ergonomic Soft Bike", 4, "38b7cecd-56ae-4ede-945b-877b09a64ad7", 6, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 329, DateTimeKind.Local).AddTicks(2317) },
                    { 9, new DateTime(2025, 4, 27, 12, 32, 41, 329, DateTimeKind.Local).AddTicks(2348), new DateTime(2025, 4, 27, 12, 32, 41, 329, DateTimeKind.Local).AddTicks(2348), 521.47m, new DateTime(2025, 1, 22, 16, 14, 59, 658, DateTimeKind.Local).AddTicks(6276), "Aperiam sed vel animi praesentium delectus voluptas tempore et iure.", "Refined Wooden Salad", 4, "51c877df-b8ba-4508-a39f-8289bfebc0f4", 10, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 329, DateTimeKind.Local).AddTicks(2349) },
                    { 10, new DateTime(2025, 4, 27, 12, 32, 41, 329, DateTimeKind.Local).AddTicks(2391), new DateTime(2025, 4, 27, 12, 32, 41, 329, DateTimeKind.Local).AddTicks(2392), 598.37m, new DateTime(2024, 10, 25, 19, 41, 54, 728, DateTimeKind.Local).AddTicks(9688), "İmpedit magnam placeat deserunt totam.", "Gorgeous Plastic Chips", 4, "120e001d-af64-4ac0-bbac-2f9654df420a", 5, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 4, 27, 12, 32, 41, 329, DateTimeKind.Local).AddTicks(2392) }
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
                name: "IX_Reservations_CustomerId",
                table: "Reservations",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_RoomId",
                table: "Reservations",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");
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
                name: "Shifts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Rooms");
        }
    }
}

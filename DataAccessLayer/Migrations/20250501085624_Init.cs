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
                    { 1, "West Melvina", "Andorra", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(839), "3516 Sean Cape, Nakialand, Costa Rica", "6", "FR2918390086677219506883A73", "654.206.6702", "Maryam66@gmail.com", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(850), "Ettie", "Effertz", "708cc5c4-756e-4c22-94a1-a862769cd9a3", "00680-8993", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(850) },
                    { 2, "North Rosalyn", "Suriname", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(1912), "83930 Kristina Hill, Rowehaven, Austria", "8", "MD70838R553174Q451902294", "(209) 768-7685 x71786", "Tania7@yahoo.com", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(1912), "Myriam", "Graham", "53bda135-167b-461f-916b-b3b30bdd5006", "73694-2450", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(1913) },
                    { 3, "North Nettie", "Trinidad and Tobago", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(2132), "3135 Seamus Highway, Hansenchester, Montserrat", "11", "FO8500934040045055", "735-672-1766 x475", "Federico_VonRueden15@gmail.com", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(2133), "Loma", "Simonis", "909f3331-abe4-4606-a28d-8809414472b3", "39728", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(2133) },
                    { 4, "East Kiannabury", "Afghanistan", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(2324), "119 McKenzie Lane, New Mossiechester, Falkland Islands (Malvinas)", "6", "TL967186344780050070994", "1-847-809-2018 x1886", "Brent_Robel@gmail.com", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(2325), "Dina", "Wiegand", "6e9e84ff-a8e1-4a2e-9f73-0040595cfb9d", "88974", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(2325) },
                    { 5, "Mrazberg", "Norway", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(2525), "0034 Akeem Parks, Dooleyside, Egypt", "10", "MC7801599780568925GA8AO6340", "1-817-595-2870 x2769", "Dominic.Rutherford9@gmail.com", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(2525), "Florian", "Aufderhar", "d75c36b2-e15e-478e-9669-889cb0d8298c", "74766", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(2526) },
                    { 6, "Port Joaniefort", "Turkey", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(2709), "718 Hortense Stravenue, Stokesborough, Burkina Faso", "2", "MC200503049069821M005K98730", "1-601-780-4549 x27890", "Jarvis_Lueilwitz@hotmail.com", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(2709), "Tyrese", "Ward", "31feba47-8557-43db-96cf-65fed3ed9d12", "13311", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(2710) },
                    { 7, "Prosaccofort", "Zambia", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(2885), "89648 Albina Islands, Dedricchester, Angola", "2", "IL310065007004041700253", "(475) 561-4728 x0953", "Raul.Powlowski81@gmail.com", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(2886), "Kassandra", "Carter", "7734d414-5259-4aed-ba20-50134ba0acc9", "93702", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(2886) },
                    { 8, "Port Creola", "Solomon Islands", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(3046), "319 Granville Groves, Balistreriberg, Bermuda", "6", "DO90TUAH09468007544779335628", "837.342.0323 x8768", "Georgianna.Bayer@gmail.com", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(3047), "Elsa", "Marvin", "1a8464bc-c495-4405-95da-e739cb8af675", "51947", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(3047) },
                    { 9, "South Richmond", "Australia", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(3358), "6245 Tressa Harbor, Parisianfort, Dominica", "1", "HR4523127998604009054", "1-554-753-0127 x698", "Liliane.Monahan99@yahoo.com", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(3360), "Randy", "Shanahan", "4a74fed4-218c-4195-ab89-56de133a18a7", "83046", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(3360) },
                    { 10, "East Perryview", "Grenada", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(3555), "502 Donavon Inlet, East Willisfurt, Poland", "3", "MR1659979162168600801019511", "817.456.8007 x91204", "Guido76@gmail.com", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(3555), "Jackson", "Roob", "d139c81c-39c6-4d64-9546-a8c9a37c281c", "17291-4825", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(3555) }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "HourlyWage", "MasterId", "PostalCode", "SelectedStatus", "Status", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Goldnerborough", "Western Sahara", new DateTime(2025, 8, 7, 20, 47, 23, 442, DateTimeKind.Local).AddTicks(9159), "Ethel40@gmail.com", "9043 Pfannerstill Garden, South Daphnee, Greece", "Lelah", "Cassin", "999-858-3384", new DateTime(2025, 5, 1, 11, 56, 23, 302, DateTimeKind.Local).AddTicks(2549), 0m, "efb10c92-d972-4232-83ce-31ea36fd9fbe", "40540", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2026, 2, 18, 6, 0, 9, 155, DateTimeKind.Local).AddTicks(5975) },
                    { 2, "Lake Wendystad", "Brazil", new DateTime(2025, 8, 8, 6, 45, 4, 983, DateTimeKind.Local).AddTicks(5249), "Leopoldo.McCullough5@gmail.com", "00111 Morgan Mountains, Port Noah, American Samoa", "Bernie", "Miller", "312-731-3742", new DateTime(2025, 5, 1, 11, 56, 23, 302, DateTimeKind.Local).AddTicks(2983), 0m, "7d990195-1efa-44f4-9e3c-0392a7abfdf2", "97665", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 11, 8, 19, 48, 30, 333, DateTimeKind.Local).AddTicks(9282) },
                    { 3, "Margaritamouth", "Armenia", new DateTime(2026, 4, 6, 20, 24, 8, 389, DateTimeKind.Local).AddTicks(1836), "Chet.West37@hotmail.com", "4615 Amelie Cliffs, West Marianoberg, Virgin Islands, U.S.", "Darwin", "Carter", "953.456.3485 x200", new DateTime(2025, 5, 1, 11, 56, 23, 302, DateTimeKind.Local).AddTicks(3148), 0m, "a4c7e500-d869-447f-a560-31e4dc8a2860", "38297-9535", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2027, 2, 19, 3, 50, 13, 644, DateTimeKind.Local).AddTicks(6928) },
                    { 4, "North Brennamouth", "Liechtenstein", new DateTime(2025, 5, 22, 3, 36, 55, 421, DateTimeKind.Local).AddTicks(5164), "Elenora_Effertz85@gmail.com", "13914 Bernhard Orchard, Ebertside, Canada", "Milton", "Schultz", "854.911.6277", new DateTime(2025, 5, 1, 11, 56, 23, 302, DateTimeKind.Local).AddTicks(3280), 0m, "acaabf73-81d2-48ac-8b93-3fde28783aa1", "95741-0802", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2026, 5, 17, 18, 14, 15, 104, DateTimeKind.Local).AddTicks(4163) },
                    { 5, "Richmondhaven", "Ethiopia", new DateTime(2025, 12, 16, 13, 44, 28, 47, DateTimeKind.Local).AddTicks(1297), "Ashtyn_Homenick53@gmail.com", "2013 Eula Green, Hueltown, Tokelau", "Ova", "Maggio", "278-377-3679 x5135", new DateTime(2025, 5, 1, 11, 56, 23, 302, DateTimeKind.Local).AddTicks(3413), 0m, "5100d4cb-22f7-4b59-8c14-7c31a46e4b97", "22571-7144", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2026, 3, 25, 0, 22, 29, 510, DateTimeKind.Local).AddTicks(5949) },
                    { 6, "Grimesbury", "Saint Lucia", new DateTime(2025, 9, 15, 10, 49, 16, 822, DateTimeKind.Local).AddTicks(5439), "Guido18@yahoo.com", "81808 Labadie Drive, Bergstromton, Mayotte", "Gavin", "Batz", "759.865.3823 x9037", new DateTime(2025, 5, 1, 11, 56, 23, 302, DateTimeKind.Local).AddTicks(3537), 0m, "8176d864-b22d-455c-ae94-3ac9696e732f", "47543-7669", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2026, 7, 2, 14, 7, 10, 605, DateTimeKind.Local).AddTicks(7858) },
                    { 7, "Rauhaven", "Puerto Rico", new DateTime(2025, 12, 28, 11, 33, 7, 999, DateTimeKind.Local).AddTicks(8209), "Earnest96@gmail.com", "97818 Baumbach Springs, Lillianatown, Cocos (Keeling) Islands", "Lucinda", "Nitzsche", "394-453-2919 x552", new DateTime(2025, 5, 1, 11, 56, 23, 302, DateTimeKind.Local).AddTicks(3650), 0m, "1ab9166e-fb84-49d9-b49e-10b8cdef23e9", "41837-8515", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2026, 5, 16, 14, 1, 26, 680, DateTimeKind.Local).AddTicks(5505) },
                    { 8, "North Candelario", "Congo", new DateTime(2025, 11, 15, 10, 8, 13, 821, DateTimeKind.Local).AddTicks(5227), "Gregorio_Ankunding82@yahoo.com", "7891 Purdy Walk, Gulgowskiton, Burundi", "Alivia", "Brakus", "1-985-216-2329 x308", new DateTime(2025, 5, 1, 11, 56, 23, 302, DateTimeKind.Local).AddTicks(3767), 0m, "71ec9b70-aa5c-4767-8b45-94e31859ee0b", "40837-6836", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2026, 5, 21, 9, 38, 12, 249, DateTimeKind.Local).AddTicks(5891) },
                    { 9, "Lake Roelbury", "Iraq", new DateTime(2025, 5, 3, 17, 23, 53, 284, DateTimeKind.Local).AddTicks(2045), "Shea_Baumbach@hotmail.com", "899 Schaden Haven, East Laverneborough, Swaziland", "Jaeden", "Feil", "908.216.7183", new DateTime(2025, 5, 1, 11, 56, 23, 302, DateTimeKind.Local).AddTicks(3884), 0m, "7a06dc8e-d82c-4f72-bc64-25866f6ef66e", "70537", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2026, 2, 10, 17, 26, 15, 804, DateTimeKind.Local).AddTicks(4235) },
                    { 10, "New Watsonshire", "Luxembourg", new DateTime(2025, 8, 8, 7, 58, 38, 116, DateTimeKind.Local).AddTicks(8219), "Franz29@hotmail.com", "941 Lexi Field, Estefaniatown, Guyana", "Cordie", "Kihn", "(848) 943-1908", new DateTime(2025, 5, 1, 11, 56, 23, 302, DateTimeKind.Local).AddTicks(4009), 0m, "9ff915bd-e6be-4a03-97ba-6e41c8d692d3", "42245-7201", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 12, 8, 18, 42, 3, 416, DateTimeKind.Local).AddTicks(1029) }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedDate", "DataStasus", "Description", "EntryDate", "Floor", "HasAirConditioning", "HasBalcony", "HasHairDryer", "HasMinibar", "HasTV", "HasWiFi", "ImageUrl", "MasterId", "PricePerNight", "RoomBreakfast", "RoomCapacity", "RoomNumber", "RoomType", "SelectedStatus", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(7731), 0, "Sit alias qui est minima.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(7736), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=931", "1a36d596-4bca-431e-9bf9-9bde5d8c897f", 2172.84m, false, 1, "1", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(7736) },
                    { 2, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8118), 1, "Vel ullam aut reprehenderit maxime.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8120), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=943", "dff56ed3-db03-41ce-85ee-3a58fa71e403", 1660.83m, true, 2, "2", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8121) },
                    { 3, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8184), 2, "Autem repudiandae et cumque quis.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8185), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=1034", "8219c091-ab15-483d-834d-6771c8a371ee", 1731.80m, true, 3, "3", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8185) },
                    { 4, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8218), 3, "Vero maxime a tempore libero.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8218), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=122", "7535882b-f43f-4cf4-9ba5-104de0286cc3", 2386.30m, true, 4, "4", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8218) },
                    { 5, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8246), 4, "Commodi excepturi in nulla veritatis.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8247), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=258", "6c14a969-2092-4cc1-af24-c0410444489c", 2425.62m, true, 5, "5", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8247) },
                    { 6, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8280), 5, "Voluptas non et totam sint.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8280), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=77", "34ef8240-ffc9-4a3e-b362-bf8db10ad155", 2298.03m, false, 1, "6", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8280) },
                    { 7, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8305), 0, "Et corporis nostrum quae odit.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8305), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=1012", "445f24ec-3b45-41a2-95b2-7f838e542e3f", 2208.74m, true, 2, "7", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8306) },
                    { 8, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8330), 1, "Porro laboriosam deserunt voluptas ipsum.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8330), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=429", "b22bdeca-0136-4c3c-8ee8-9d57ac4c1c36", 1549.17m, true, 3, "8", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8331) },
                    { 9, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8354), 2, "Quis voluptatem quaerat ut ab.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8354), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=539", "92d8c2be-874f-4ed9-9ef0-fd720fc28a61", 1653.35m, true, 4, "9", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8354) },
                    { 10, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8381), 3, "İncidunt facilis quasi odio iusto.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8382), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=638", "bf32cce0-7939-41db-a3e1-3f815893b434", 1821.72m, true, 5, "10", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8383) },
                    { 11, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8405), 4, "Harum impedit quia aspernatur recusandae.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8406), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=356", "f7393f3d-3475-40d2-833c-da2c1b0e93f1", 1651.44m, false, 1, "11", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8406) },
                    { 12, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8429), 5, "Est ut molestias delectus ut.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8429), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=137", "68cbc8de-ff6e-45e8-bb71-bad3d4ab8cab", 1670.28m, true, 2, "12", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8429) },
                    { 13, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8451), 0, "Maiores sint consequatur dicta iusto.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8452), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=525", "fa638041-7d73-41f5-a632-fd8b300df3bd", 2212.62m, true, 3, "13", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8452) },
                    { 14, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8474), 1, "Dolores veritatis explicabo nesciunt quisquam.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8474), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=136", "1c52bfc3-a23a-4be4-a976-ae38c10d6611", 1983.13m, true, 4, "14", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8474) },
                    { 15, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8498), 2, "Unde quia sequi quam in.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8500), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=315", "263b16f7-d98b-4de4-8b5b-28b4f6d035dc", 1774.92m, true, 5, "15", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8501) },
                    { 16, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8524), 3, "Tempore veniam omnis dolorem a.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8524), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=489", "ac2ef3ff-e535-41c1-bf38-a2018d5ef39c", 1924.92m, false, 1, "16", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8524) },
                    { 17, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8545), 4, "Aut aut voluptatem facilis cum.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8546), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=346", "618bfcf8-4079-47f9-89ae-1604ee493889", 1513.51m, true, 2, "17", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8546) },
                    { 18, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8567), 5, "Voluptatem sunt qui laudantium perspiciatis.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8567), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=771", "e87ffcaa-cf54-4f9d-a28b-3f446c50cc84", 1603.97m, true, 3, "18", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8567) },
                    { 19, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8589), 0, "Dolorem qui aliquam consectetur expedita.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8589), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=477", "eb3b258f-7a9f-4c82-9209-4ab5f71aa29e", 2441.59m, true, 4, "19", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8590) },
                    { 20, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8616), 1, "Veniam rerum sapiente id ullam.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8616), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=498", "db9eab4c-2bc3-4a6a-8755-953af202c352", 2225.86m, true, 5, "20", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8616) },
                    { 21, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8638), 2, "Vel sed quam odit quia.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8638), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=320", "d626a664-d30e-422d-aff0-620ad2f17711", 2030.53m, false, 1, "21", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8638) },
                    { 22, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8660), 3, "Quidem nemo provident atque ea.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8661), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=1000", "eae00350-1e38-4716-9a3d-9399533f88bc", 1501.89m, true, 2, "22", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8661) },
                    { 23, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8682), 4, "Odit sunt pariatur eos id.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8682), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=848", "33685b5c-3f02-4ecb-a821-20c3c683d97d", 2258.91m, true, 3, "23", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8683) },
                    { 24, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8704), 5, "Harum et suscipit omnis corporis.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8705), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=825", "12622b3e-d4ef-48f0-9789-a8f371b66698", 2251.12m, true, 4, "24", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8705) },
                    { 25, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8726), 0, "Recusandae consectetur quae esse pariatur.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8726), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=267", "9dfd50f5-8596-4db6-b800-67945724c773", 2136.77m, true, 5, "25", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8727) },
                    { 26, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8753), 1, "Quas voluptatem id fuga enim.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8753), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=766", "3b692c90-2651-442c-ada2-6204776b32e7", 1943.04m, false, 1, "26", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8753) },
                    { 27, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8774), 2, "Soluta facere alias consequatur placeat.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8775), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=527", "03785005-a4f8-4cf7-acc6-2c0d0c27f86f", 2019.56m, true, 2, "27", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8775) },
                    { 28, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8797), 3, "Quo tempora consectetur quis mollitia.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8797), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=481", "298b8da3-2aef-4f24-a4d4-d65c93f11f4d", 2118.80m, true, 3, "28", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8797) },
                    { 29, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8818), 4, "Temporibus eos nihil quos commodi.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8818), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=832", "0f2848d6-3949-4e20-b0ab-71ba25bc41df", 1542.74m, true, 4, "29", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8818) },
                    { 30, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8839), 5, "Atque ullam sint qui nobis.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8839), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=525", "92883847-e76e-43e2-a75b-eaf1d91f0e9c", 1587.01m, true, 5, "30", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8839) },
                    { 31, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8864), 0, "Omnis repellat cupiditate ipsam ut.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8865), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=48", "50165822-9316-4d5e-9036-d52e940d3071", 2395.20m, false, 1, "31", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8865) },
                    { 32, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8888), 1, "Quaerat labore in quidem distinctio.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8888), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=601", "f2ca97d7-2d75-4db7-a8bd-3164fd7d47be", 1836.73m, true, 2, "32", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8888) },
                    { 33, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8909), 2, "Culpa quos aut et qui.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8909), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=686", "c492a47b-04c9-4042-a9c2-734332a769d1", 1557.52m, true, 3, "33", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8909) },
                    { 34, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8931), 3, "Dolor voluptatibus assumenda nesciunt inventore.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8931), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=495", "84b70aa1-fda3-4557-bd9b-96e2dee09bb5", 2318.80m, true, 4, "34", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8931) },
                    { 35, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9020), 4, "Quis nihil quam et facere.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9020), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=797", "50b01a1b-d973-4f08-8be4-656918ff1a07", 1965.27m, true, 5, "35", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9021) },
                    { 36, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9043), 5, "Et distinctio rerum est qui.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9043), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=839", "7534f926-60ad-4746-8cc2-1b90abd9611c", 2037.69m, false, 1, "36", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9044) },
                    { 37, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9065), 0, "İncidunt et aut non itaque.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9066), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=813", "617bb678-1adf-4f3d-98f9-be7b0ba99f8e", 1759.76m, true, 2, "37", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9066) },
                    { 38, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9087), 1, "Ad nobis exercitationem et voluptatum.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9087), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=226", "d0fe276a-302a-438f-88f4-1c399fa15f1e", 1514.52m, true, 3, "38", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9088) },
                    { 39, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9109), 2, "Ducimus impedit minus aut qui.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9109), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=1062", "7c799a95-b880-458c-a47d-499c5ce94368", 2015.86m, true, 4, "39", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9110) },
                    { 40, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9132), 3, "Dignissimos sint veritatis ea cupiditate.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9132), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=1062", "1192658f-d05d-4e72-850d-7bd82a7d0b7d", 1860.64m, true, 5, "40", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9132) },
                    { 41, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9158), 4, "Corporis tempore voluptatum quidem nulla.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9158), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=671", "aa161add-fe33-4d03-814e-c7f494e7281f", 2203.37m, false, 1, "41", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9158) },
                    { 42, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9180), 5, "Expedita hic est quisquam illum.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9180), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=277", "8e7720f9-2340-4ee6-b412-634e67cbe9b2", 1844.03m, true, 2, "42", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9180) },
                    { 43, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9201), 0, "Veritatis quibusdam odio in corrupti.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9201), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=140", "f9fe460a-0558-4a0e-bdc9-5141aecea320", 1833.46m, true, 3, "43", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9201) },
                    { 44, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9221), 1, "Occaecati porro non fugiat saepe.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9222), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=690", "35065c04-54b6-44e1-b988-9fae5328b7b5", 1611.64m, true, 4, "44", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9222) },
                    { 45, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9241), 2, "Repellendus enim laborum occaecati nihil.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9242), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=753", "8641b025-f208-4a4b-bce8-43e350390412", 1773.96m, true, 5, "45", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9242) },
                    { 46, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9266), 3, "Voluptate eveniet consectetur sed repudiandae.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9266), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=583", "3ecffc6a-c5c6-45ce-8137-5dadb831cb2d", 2175.64m, false, 1, "46", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9267) },
                    { 47, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9287), 4, "Occaecati et perspiciatis ex qui.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9288), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=163", "f44383ff-e05a-49a3-bbe3-478fa6273c6b", 2458.22m, true, 2, "47", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9288) },
                    { 48, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9310), 5, "Perferendis at aut ea incidunt.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9310), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=347", "805b4562-f4cb-4a93-b74e-b39ef32a548d", 1906.95m, true, 3, "48", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9310) },
                    { 49, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9330), 0, "Debitis deserunt aut aut exercitationem.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9330), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=181", "6aa49077-346b-42d9-ac30-9e7aa0117601", 1841.93m, true, 4, "49", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9330) },
                    { 50, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9355), 1, "Sit architecto et dolore ut.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9355), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=833", "7268f29b-278f-4e5f-99fc-e4b59340e64f", 1883.09m, true, 5, "50", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9356) }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "PackageType", "RoomId", "SelectedStatus", "TotalAmount", "UpdatedComputerName", "UpdatedDate", "status" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 4, 10, 13, 26, 49, 682, DateTimeKind.Local).AddTicks(5315), new DateTime(2026, 6, 9, 15, 8, 21, 515, DateTimeKind.Local).AddTicks(685), new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3034), 10, new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3034), "d7ea9a7a-168f-4786-aece-b7921f16c330", 0, 43, 4, 1723.17m, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3035), 0 },
                    { 2, new DateTime(2026, 4, 7, 14, 14, 6, 769, DateTimeKind.Local).AddTicks(7674), new DateTime(2027, 3, 19, 0, 28, 46, 286, DateTimeKind.Local).AddTicks(3847), new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3216), 6, new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3216), "60e2f77a-94f6-45ad-90d9-3ce340f6312c", 1, 15, 4, 2018.87m, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3216), 1 },
                    { 3, new DateTime(2025, 6, 26, 5, 39, 44, 934, DateTimeKind.Local).AddTicks(6050), new DateTime(2026, 4, 15, 15, 30, 10, 798, DateTimeKind.Local).AddTicks(7954), new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3239), 5, new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3239), "2e8bc4fe-c34d-49f4-90e0-ca273fb2d843", 0, 15, 4, 1671.31m, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3239), 2 },
                    { 4, new DateTime(2025, 12, 8, 20, 11, 21, 119, DateTimeKind.Local).AddTicks(5935), new DateTime(2026, 8, 13, 17, 48, 31, 967, DateTimeKind.Local).AddTicks(8061), new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3254), 9, new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3254), "0d35ba70-4947-4bec-905d-de24bf942dbf", 1, 41, 4, 2289.56m, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3254), 3 },
                    { 5, new DateTime(2025, 9, 10, 0, 8, 33, 283, DateTimeKind.Local).AddTicks(3076), new DateTime(2026, 5, 15, 0, 1, 58, 900, DateTimeKind.Local).AddTicks(5476), new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3267), 10, new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3268), "b0e0d207-c882-4c00-b992-3cd6110ceee3", 0, 14, 4, 2316.37m, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3268), 4 },
                    { 6, new DateTime(2025, 6, 21, 12, 48, 53, 842, DateTimeKind.Local).AddTicks(573), new DateTime(2026, 5, 30, 12, 46, 33, 164, DateTimeKind.Local).AddTicks(2678), new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3283), 10, new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3283), "355dee23-283a-45f7-b587-8a4fb8e16a16", 1, 47, 4, 2114.11m, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3284), 5 },
                    { 7, new DateTime(2025, 5, 21, 12, 10, 10, 34, DateTimeKind.Local).AddTicks(1123), new DateTime(2026, 3, 26, 21, 53, 38, 67, DateTimeKind.Local).AddTicks(7735), new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3296), 7, new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3296), "2053f3c9-853e-457f-8593-b0864618bee9", 0, 44, 4, 2269.21m, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3296), 0 },
                    { 8, new DateTime(2025, 6, 28, 18, 59, 0, 566, DateTimeKind.Local).AddTicks(7402), new DateTime(2026, 2, 8, 19, 39, 28, 665, DateTimeKind.Local).AddTicks(553), new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3308), 8, new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3308), "168f6908-8952-4d8a-a876-0e0838633e94", 1, 22, 4, 1718.19m, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3308), 1 },
                    { 9, new DateTime(2025, 12, 23, 4, 32, 1, 691, DateTimeKind.Local).AddTicks(3789), new DateTime(2026, 2, 8, 1, 1, 18, 355, DateTimeKind.Local).AddTicks(2823), new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3320), 10, new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3320), "16046211-8b64-4ff0-9df8-00c84682e4fe", 0, 10, 4, 1997.49m, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3321), 2 },
                    { 10, new DateTime(2025, 12, 7, 14, 33, 32, 476, DateTimeKind.Local).AddTicks(1935), new DateTime(2026, 11, 21, 7, 46, 31, 376, DateTimeKind.Local).AddTicks(3233), new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3336), 6, new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3336), "6a628206-a362-48fe-bcf1-0d235c7e9c83", 1, 42, 4, 2051.39m, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3336), 3 }
                });

            migrationBuilder.InsertData(
                table: "Shifts",
                columns: new[] { "Id", "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "SelectedStatus", "ShiftType", "StartTime", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(2844), 10, new DateTime(2026, 1, 24, 3, 25, 37, 235, DateTimeKind.Local).AddTicks(3873), new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(2848), "56e66382-88be-49f5-8e9c-235ff8e98791", 4, 0, new DateTime(2024, 10, 26, 4, 2, 56, 576, DateTimeKind.Local).AddTicks(2557), "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(2848) },
                    { 2, new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(2967), 10, new DateTime(2025, 7, 1, 14, 36, 47, 533, DateTimeKind.Local).AddTicks(503), new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(2968), "415792ad-d6a2-4635-9af5-9d16da7a15bd", 4, 1, new DateTime(2024, 7, 25, 3, 14, 7, 760, DateTimeKind.Local).AddTicks(4268), "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(2968) },
                    { 3, new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(2977), 5, new DateTime(2025, 8, 8, 9, 40, 23, 636, DateTimeKind.Local).AddTicks(4940), new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(2977), "747f58d5-2eb2-4609-b162-27bca39dbfb6", 4, 0, new DateTime(2024, 9, 9, 2, 52, 25, 718, DateTimeKind.Local).AddTicks(1689), "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(2978) },
                    { 4, new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(2984), 8, new DateTime(2025, 8, 28, 1, 45, 57, 408, DateTimeKind.Local).AddTicks(3538), new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(2984), "afde93d1-0bc2-41c0-b49b-5c2a57d3d22a", 4, 0, new DateTime(2024, 10, 31, 19, 37, 43, 729, DateTimeKind.Local).AddTicks(6444), "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(2984) },
                    { 5, new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(2990), 9, new DateTime(2025, 8, 13, 7, 30, 44, 939, DateTimeKind.Local).AddTicks(7374), new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(2990), "b59fdc36-75d4-4072-9da0-3697568e2764", 4, 0, new DateTime(2025, 1, 19, 7, 33, 29, 522, DateTimeKind.Local).AddTicks(8267), "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(2990) },
                    { 6, new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(3001), 10, new DateTime(2025, 8, 8, 0, 1, 12, 620, DateTimeKind.Local).AddTicks(2975), new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(3001), "2e6b8590-7f95-4dc3-b96b-75999901aa1f", 4, 1, new DateTime(2024, 11, 19, 7, 47, 38, 391, DateTimeKind.Local).AddTicks(4244), "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(3001) },
                    { 7, new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(3007), 1, new DateTime(2025, 9, 3, 6, 1, 13, 204, DateTimeKind.Local).AddTicks(816), new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(3008), "27b55dac-43ab-4dd2-a8a8-6a2a6a7d583f", 4, 0, new DateTime(2025, 4, 11, 7, 9, 19, 826, DateTimeKind.Local).AddTicks(3847), "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(3008) },
                    { 8, new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(3014), 9, new DateTime(2025, 5, 6, 6, 1, 11, 984, DateTimeKind.Local).AddTicks(1077), new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(3014), "b18e3834-604d-4885-83f5-823e053582fa", 4, 1, new DateTime(2024, 7, 3, 22, 22, 5, 494, DateTimeKind.Local).AddTicks(7883), "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(3014) },
                    { 9, new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(3020), 7, new DateTime(2026, 3, 1, 2, 23, 17, 741, DateTimeKind.Local).AddTicks(7012), new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(3020), "97a11adc-9c99-4cf2-9522-696ede61afb3", 4, 0, new DateTime(2024, 11, 10, 9, 53, 59, 444, DateTimeKind.Local).AddTicks(2720), "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(3020) },
                    { 10, new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(3026), 1, new DateTime(2026, 2, 2, 16, 27, 53, 227, DateTimeKind.Local).AddTicks(1105), new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(3027), "6f384e34-ca07-4daa-9058-e67848989397", 4, 1, new DateTime(2024, 12, 9, 4, 45, 34, 214, DateTimeKind.Local).AddTicks(8362), "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(3027) }
                });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "ExpenseStatus", "MasterId", "ReservationId", "SelectedStatus", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4238), new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4242), 899.48m, new DateTime(2025, 1, 16, 18, 10, 23, 797, DateTimeKind.Local).AddTicks(329), "İn dicta doloremque ipsam architecto et eos et magni.", "Practical Cotton Pants", 4, "01c49777-9432-4788-8359-9591d80dd1b3", 10, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4243) },
                    { 2, new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4457), new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4457), 858.40m, new DateTime(2024, 7, 3, 12, 39, 36, 537, DateTimeKind.Local).AddTicks(7192), "İtaque esse dicta voluptates.", "Awesome Plastic Pizza", 4, "a5bc1606-f39b-43e3-a11f-7afa2d0ea0a7", 5, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4457) },
                    { 3, new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4491), new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4491), 986.70m, new DateTime(2025, 3, 11, 14, 29, 2, 222, DateTimeKind.Local).AddTicks(1898), "İncidunt vel dolores cum.", "Refined Soft Keyboard", 4, "41f20d6b-eb4b-4041-9be7-75c936e96787", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4491) },
                    { 4, new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4519), new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4519), 790.72m, new DateTime(2025, 4, 14, 0, 4, 53, 138, DateTimeKind.Local).AddTicks(8550), "Quo aliquam repellat qui odit fuga id iusto.", "Awesome Frozen Sausages", 4, "47879de5-f3b5-492f-91de-a533e74bad91", 5, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4520) },
                    { 5, new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4555), new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4555), 803.39m, new DateTime(2024, 5, 31, 13, 25, 38, 681, DateTimeKind.Local).AddTicks(9727), "Aut repellendus omnis est aut similique nisi beatae iure non.", "Rustic Frozen Fish", 4, "d221830d-6238-4698-812b-e9f2b157d7ac", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4555) },
                    { 6, new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4591), new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4592), 955.89m, new DateTime(2024, 10, 28, 22, 58, 33, 853, DateTimeKind.Local).AddTicks(6042), "Placeat quia quisquam placeat.", "Practical Plastic Pants", 4, "d2cf96ec-b12d-4586-b7fa-cd7110a73b3f", 10, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4592) },
                    { 7, new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4618), new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4618), 425.31m, new DateTime(2024, 10, 3, 9, 3, 6, 793, DateTimeKind.Local).AddTicks(4947), "Cupiditate mollitia harum molestias illo.", "Unbranded Cotton Soap", 4, "182949d9-77db-4a6d-aa5f-2f5464c883b8", 6, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4618) },
                    { 8, new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4647), new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4647), 102.11m, new DateTime(2024, 5, 28, 15, 50, 20, 557, DateTimeKind.Local).AddTicks(7657), "Alias ut enim veritatis consectetur sunt et ad.", "Incredible Rubber Fish", 4, "5f42c66c-c4fb-4a12-9714-99cc012bf01d", 7, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4648) },
                    { 9, new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4676), new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4677), 997.41m, new DateTime(2025, 2, 7, 4, 55, 11, 673, DateTimeKind.Local).AddTicks(7091), "Soluta consequuntur eos facere voluptatem velit nostrum perspiciatis qui voluptas.", "Gorgeous Wooden Pants", 4, "440929df-fb65-403a-993d-215af339c24c", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4677) },
                    { 10, new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4712), new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4712), 719.06m, new DateTime(2024, 10, 20, 11, 30, 2, 233, DateTimeKind.Local).AddTicks(1030), "Fuga unde in.", "Awesome Soft Bike", 4, "3e4b180b-db83-4d42-b003-b3b69fc8f61c", 10, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4713) }
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

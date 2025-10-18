using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
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
                    FirstVisitDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastVisitDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalVisits = table.Column<int>(type: "int", nullable: false),
                    TotalNightsStayed = table.Column<int>(type: "int", nullable: false),
                    TotalSpent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsVIPCustomer = table.Column<bool>(type: "bit", nullable: false),
                    CustomerNotes = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "DatabaseConfigurations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatabaseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Port = table.Column<int>(type: "int", nullable: false),
                    Provider = table.Column<int>(type: "int", nullable: false),
                    ConnectionString = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    LastConnectionTest = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastConnectionStatus = table.Column<bool>(type: "bit", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MasterId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SelectedStatus = table.Column<int>(type: "int", nullable: false),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatabaseConfigurations", x => x.Id);
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
                    Position = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    EmployeeType = table.Column<int>(type: "int", nullable: false),
                    EmployeeAddres = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    StandardShift = table.Column<int>(type: "int", nullable: false),
                    OffDay = table.Column<DateTime>(type: "date", nullable: true),
                    HasOvertime = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    WeeklyWorkedHours = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    TotalWorkedHours = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    OvertimeHours = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    HourlyWage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MonthlyWage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OvertimeRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MinWeeklyHours = table.Column<int>(type: "int", nullable: false),
                    MaxWeeklyHours = table.Column<int>(type: "int", nullable: false),
                    RequiredShiftsPerWeek = table.Column<int>(type: "int", nullable: false),
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
                    BedCount = table.Column<int>(type: "int", nullable: false),
                    BasePricePerNight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AllInclusivePricePerNight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HasBalcony = table.Column<bool>(type: "bit", nullable: false),
                    HasMinibar = table.Column<bool>(type: "bit", nullable: false),
                    HasAirConditioning = table.Column<bool>(type: "bit", nullable: false),
                    HasTV = table.Column<bool>(type: "bit", nullable: false),
                    HasHairDryer = table.Column<bool>(type: "bit", nullable: false),
                    HasWiFi = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DataStatus = table.Column<int>(type: "int", nullable: false),
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
                name: "CustomerVisits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NightsStayed = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PackageType = table.Column<int>(type: "int", nullable: false),
                    RoomNumbers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfGuests = table.Column<int>(type: "int", nullable: false),
                    HadComplaints = table.Column<bool>(type: "bit", nullable: false),
                    VisitNotes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    MasterId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SelectedStatus = table.Column<int>(type: "int", nullable: false),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerVisits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerVisits_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DatabaseBackups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BackupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BackupPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BackupFileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileSize = table.Column<long>(type: "bigint", nullable: false),
                    BackupDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BackupType = table.Column<int>(type: "int", nullable: false),
                    DatabaseProvider = table.Column<int>(type: "int", nullable: false),
                    DatabaseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCompressed = table.Column<bool>(type: "bit", nullable: false),
                    Checksum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MasterId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SelectedStatus = table.Column<int>(type: "int", nullable: false),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatabaseBackups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DatabaseBackups_Employees_CreatedByEmployeeId",
                        column: x => x.CreatedByEmployeeId,
                        principalTable: "Employees",
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
                    StartTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    EndTime = table.Column<TimeOnly>(type: "time", nullable: false),
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
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ExtraCharges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ChargeType = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ChargeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    PaidDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    MasterId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SelectedStatus = table.Column<int>(type: "int", nullable: false),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtraCharges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExtraCharges_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ExtraCharges_Employees_CreatedByEmployeeId",
                        column: x => x.CreatedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExtraCharges_Reservations_ReservationId",
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
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerNotes", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "FirstVisitDate", "IsVIPCustomer", "LastName", "LastVisitDate", "MasterId", "PostalCode", "SelectedStatus", "TotalNightsStayed", "TotalSpent", "TotalVisits", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Bayburt", "Kars", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(5536), "Yunus Emre Sokak 76, Karabük, İsviçre", "38725479500", "", "EE937480500606560092", "+90-921-286-7-968", "Boru.Tazegul@yahoo.com", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(5545), "İmrem", new DateTime(2024, 12, 2, 6, 7, 57, 149, DateTimeKind.Local).AddTicks(5368), false, "Gümüşpala", null, "69622d12-33f8-4e76-9103-f41b1cdf6525", "33283", 0, 3, 6058.749028025401300m, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(5545) },
                    { 2, "İzmir", "Çanakkale", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(6401), "Sevgi Sokak 30, Hakkari, Bermuda, İngiltere", "27765620836", "Yapacakmış ışık ekşili sayfası iure.", "IS626584611003040900979070", "+90-670-538-8-792", "Kizdurmus20@gmail.com", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(6402), "Beker", new DateTime(2025, 5, 31, 8, 18, 16, 827, DateTimeKind.Local).AddTicks(9461), false, "Akman", null, "d598e09b-357d-4e43-ae9b-da4a1561bc4d", "39266", 0, 34, 5311.94111761757500m, 3, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(6402) },
                    { 3, "Hakkari", "Mersin", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(6677), "Tevfik Fikret Caddesi 4, Ağrı, Amerikan Samoa", "35002654836", "Et dolor nostrum laboriosam kulu commodi voluptatem.", "MT25HUCE0010616516643150960FLY6", "+90-940-372-70-12", "Beceapa78@yahoo.com", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(6677), "Bıdın", new DateTime(2025, 3, 13, 3, 18, 19, 6, DateTimeKind.Local).AddTicks(7296), false, "Poçan", null, "b9649c02-e2ef-455d-9bb8-45cc906012fe", "12608", 0, 15, 4323.466057093069600m, 7, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(6678) },
                    { 4, "Çankırı", "Hakkâri", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(6881), "Fatih Sokak  3, Kilis, Avustralya", "91852049862", "", "RO36WZFX5E3R8605F147Q894", "+90-007-697-12-94", "Budak.Koc19@gmail.com", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(6881), "Bağatarkan", new DateTime(2024, 7, 6, 15, 42, 18, 442, DateTimeKind.Local).AddTicks(2975), false, "Başoğlu", null, "b74d2d0c-4dfd-47ea-b1cb-6b4d3910ce4d", "09890", 0, 37, 4395.17643193381600m, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(6882) },
                    { 5, "Manisa", "Siirt", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(7077), "30 Ağustos Caddesi 01c, Zonguldak, Doğu Timor", "44042806424", "", "SA1468TD0736373141IX722S", "+90-191-924-5-317", "Apa_Akbulut@yahoo.com", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(7078), "Apak", new DateTime(2024, 12, 20, 9, 55, 8, 990, DateTimeKind.Local).AddTicks(6307), false, "Köybaşı", null, "801ecaf0-a59f-4eb2-9a57-23c29c754fa8", "65120", 0, 1, 3033.535501656317800m, 7, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(7078) },
                    { 6, "Adıyaman", "Sirnak", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(7225), "Saygılı Sokak 06b, Düzce, Svaziland", "08384139512", "", "BH25QWLP03276319U48883", "+90-560-870-60-00", "Beltir.Barbarosoglu1@hotmail.com", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(7226), "Alpbilge", new DateTime(2025, 9, 12, 0, 42, 49, 20, DateTimeKind.Local).AddTicks(7943), false, "Evliyaoğlu", null, "d8fada58-89ed-4f5a-9f50-849091c07368", "49634", 0, 28, 9478.615447642899700m, 7, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(7226) },
                    { 7, "Ankara", "Zonguldak", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(7380), "Lütfi Karadirek Caddesi 007, Bingöl, Suriye", "75172254036", "", "TL729849630145600906077", "+90-089-604-39-83", "Ekim_Kocyigit48@hotmail.com", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(7380), "Kayça", new DateTime(2025, 3, 17, 9, 16, 30, 164, DateTimeKind.Local).AddTicks(3390), false, "Küçükler", null, "4687e5e6-b9df-487b-ad6f-aa6b0e100f1c", "14405", 0, 47, 9607.487079825113500m, 3, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(7381) },
                    { 8, "Kocaeli", "Osmaniye", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(7511), "Alparslan Türkeş Bulvarı 353, Kilis, Wake Adaları, Amerika", "86285947548", "", "AD68003330015659M26817G2", "+90-879-655-2-726", "Arslansungur.Ozgorkey86@gmail.com", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(7511), "Atımer", new DateTime(2023, 12, 10, 8, 35, 12, 559, DateTimeKind.Local).AddTicks(7411), true, "Sandalcı", null, "d4a3bfe5-eae0-408f-8322-5eb9ad39cc13", "46376", 0, 35, 8053.11081072461800m, 10, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(7511) },
                    { 9, "Kilis", "Sivas", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(7764), "Okul Sokak 40c, Edirne, Kazakistan", "28578197412", "Neque çakıl türemiş gül praesentium illo sıfat layıkıyla quia gülüyorum.", "SA14074016860XB216499976", "+90-484-399-74-40", "Alptunga68@hotmail.com", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(7764), "İrinçköl", new DateTime(2024, 10, 24, 21, 41, 0, 991, DateTimeKind.Local).AddTicks(9834), false, "Kaya ", null, "9ac63c6a-978d-4695-90a0-e252a77fe21b", "68120", 0, 39, 1541.771346355585300m, 8, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(7764) },
                    { 10, "Ağrı", "Kayseri", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(7957), "Bayır Sokak 116, Ordu, Filipinler", "14652730536", "", "IE82382U03007906300154", "+90-254-166-2-333", "Ancuk.Velioglu51@gmail.com", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(7958), "Erten", new DateTime(2023, 11, 19, 1, 33, 16, 701, DateTimeKind.Local).AddTicks(9824), false, "Numanoğlu", null, "206a1376-9b18-47ff-9dfd-af5eecc8014a", "40585", 0, 19, 2617.622586535325500m, 7, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(7958) },
                    { 11, "Samsun", "Ankara", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(8078), "Kocatepe Caddesi 13c, Çankırı, Doğu Timor", "95627972412", "", "RS94244001008861400599", "+90-709-137-09-81", "Boru_Bolatli@gmail.com", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(8079), "Bayunçur", new DateTime(2024, 11, 3, 4, 31, 10, 529, DateTimeKind.Local).AddTicks(5721), false, "Babacan", null, "fe9d1f47-029a-4876-a755-66be3ed70065", "19197", 0, 29, 2698.042633945976800m, 7, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(8079) },
                    { 12, "Edirne", "Gümüshane", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(8195), "Alparslan Türkeş Bulvarı 90a, Ankara, Ukrayna", "16337318136", "Voluptatem camisi yapacakmış sinema neque.", "GT4249302960743RD49D4824C171", "+90-182-555-6-295", "Balaban60@yahoo.com", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(8195), "Baltur", new DateTime(2024, 6, 26, 3, 45, 14, 56, DateTimeKind.Local).AddTicks(1482), false, "Karabulut", null, "474258f4-6c96-4a50-bce5-292f942adbf4", "60072", 0, 32, 2800.246294625334400m, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(8196) },
                    { 13, "Sinop", "Kastamonu", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(8349), "Bayır Sokak 4, Kilis, Meksika", "67027109024", "Eos enim uzattı accusantium illo yapacakmış dolor odit ekşili.", "BE96007904066166", "+90-950-848-37-04", "Atmaca_Catalbas@gmail.com", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(8349), "Keklik", new DateTime(2024, 7, 18, 3, 51, 36, 934, DateTimeKind.Local).AddTicks(2148), true, "Akışık", null, "cefb9a9d-d99d-4fc5-94be-23178e2ef176", "65539", 0, 1, 7127.924941295602300m, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(8350) },
                    { 14, "Iğdır", "Bayburt", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(8502), "Alparslan Türkeş Bulvarı 825, Malatya, Kazakistan", "36487066774", "", "LB3777860F2DJ50066110354782X", "+90-240-559-0-553", "Borcul.Mayhos@hotmail.com", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(8503), "Arademir", new DateTime(2024, 4, 26, 17, 7, 48, 835, DateTimeKind.Local).AddTicks(3229), true, "Kaplangı", null, "ab54bf56-31ca-49f3-bea9-1a9945353cc5", "79185", 0, 1, 3982.46653612605700m, 3, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(8503) },
                    { 15, "Diyarbakır", "Eskisehir", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(8624), "Bandak Sokak 59a, Burdur, Mayotte, Fransa", "02133396524", "", "LI7532616620384NJ7302", "+90-281-854-5-165", "Cagru.Babaoglu9@yahoo.com", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(8625), "Bağaturipi", new DateTime(2024, 7, 6, 18, 12, 48, 4, DateTimeKind.Local).AddTicks(3577), false, "Biçer", null, "f72a51b5-8ec3-420e-8b30-74d55fb0bd43", "56390", 0, 22, 566.0694149787052300m, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(8625) },
                    { 16, "Antalya", "Hatay", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(8749), "Namık Kemal Caddesi 47a, Artvin, Guadalup, Fransa", "16524331498", "", "GL7019715026200997", "+90-865-096-3-019", "Bardibay47@yahoo.com", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(8749), "Boyankulu", new DateTime(2024, 3, 10, 20, 13, 55, 685, DateTimeKind.Local).AddTicks(8538), true, "Sinanoğlu", null, "bbbe892d-4f12-4faf-a370-5fccf24b979f", "92628", 0, 26, 1398.252798118500400m, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(8749) },
                    { 17, "Şanlıurfa", "Hakkâri", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(8858), "Okul Sokak 09, Tekirdağ, Vanuatu", "12140798462", "", "LT633173690868159686", "+90-234-055-9-159", "Burunduk72@yahoo.com", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(8858), "Arı", new DateTime(2025, 2, 26, 18, 14, 17, 305, DateTimeKind.Local).AddTicks(2888), false, "Orbay", null, "49065150-3d04-4bab-be70-9e8f0b74630c", "01747", 0, 1, 1717.196053327307200m, 9, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(8859) },
                    { 18, "Niğde", "Kahramanmaras", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(8977), "Kocatepe Caddesi 93c, Kilis, Trinidad ve Tobago", "94770187362", "Sit cezbelendi blanditiis kutusu velit.", "SM82F7100178406553N1450I2H0", "+90-098-965-2-399", "Edil81@yahoo.com", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(8977), "Bağaşatulu", new DateTime(2024, 4, 15, 9, 58, 58, 605, DateTimeKind.Local).AddTicks(2590), false, "Yazıcı", null, "d366d720-1b54-4853-89bd-e6d3b9db148a", "99886", 0, 26, 5060.817370520228800m, 8, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(8978) },
                    { 19, "Artvin", "Kocaeli", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(9120), "Kekeçoğlu Sokak 34c, Şanlıurfa, Kamboçya", "33785344962", "", "BR5680030310580010585507488CA", "+90-515-152-90-77", "Bangu.Karaer@yahoo.com", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(9120), "Erdem", new DateTime(2024, 11, 29, 5, 11, 28, 825, DateTimeKind.Local).AddTicks(5971), false, "Kavaklıoğlu", null, "b279994a-71c3-49ef-a213-678243afd15e", "80186", 0, 35, 4293.394851467869300m, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(9121) },
                    { 20, "Kilis", "Diyarbakir", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(9239), "Mevlana Sokak 47b, Bilecik, Guadalup, Fransa", "68783234786", "Labore magnam dağılımı.", "DK1540420452300303", "+90-025-708-33-53", "Altinoba.Elmastasoglu@yahoo.com", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(9239), "Baykuzu", new DateTime(2025, 9, 21, 20, 41, 0, 539, DateTimeKind.Local).AddTicks(31), false, "Aclan", null, "6442bb05-4eec-4e45-8857-666b262ed76a", "74065", 0, 30, 2667.686830071566500m, 5, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 723, DateTimeKind.Local).AddTicks(9240) }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EmployeeType", "EntryDate", "HourlyWage", "MasterId", "MaxWeeklyHours", "MinWeeklyHours", "MonthlyWage", "OffDay", "OvertimeRate", "Position", "PostalCode", "RequiredShiftsPerWeek", "SelectedStatus", "StandardShift", "Status", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Muş", "Meksika", new DateTime(2025, 10, 15, 13, 25, 46, 726, DateTimeKind.Local).AddTicks(3435), "Barboga31@gmail.com", "Namık Kemal Caddesi 728, Niğde, Sri Lanka", "Akboğa", "Akan", "+90-522-747-60-43", 3, new DateTime(2025, 10, 15, 13, 25, 46, 726, DateTimeKind.Local).AddTicks(3440), 75m, "2dcbd88a-91e0-4d40-965c-72cc370be9a1", 48, 40, 0m, null, 1.5m, 1, "1", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 726, DateTimeKind.Local).AddTicks(3440) },
                    { 2, "Sakarya", "Liberya", new DateTime(2025, 10, 15, 13, 25, 46, 726, DateTimeKind.Local).AddTicks(4251), "Ceyhun.Tazegul@yahoo.com", "Kerimoğlu Sokak 39a, Tokat, Virgin Adaları, İngiltere", "Avşar", "Hakyemez", "+90-832-684-8-323", 3, new DateTime(2025, 10, 15, 13, 25, 46, 726, DateTimeKind.Local).AddTicks(4252), 75m, "2be6d2d7-c332-458b-9cdc-66dd5aef3c31", 48, 40, 0m, null, 1.5m, 1, "1", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 726, DateTimeKind.Local).AddTicks(4253) },
                    { 3, "Kütahya", "Nikaragua", new DateTime(2025, 10, 15, 13, 25, 46, 726, DateTimeKind.Local).AddTicks(4410), "Alayuntlu75@gmail.com", "30 Ağustos Caddesi 543, Aydın, Bosna Hersek", "Akı", "Barbarosoğlu", "+90-541-001-6-136", 3, new DateTime(2025, 10, 15, 13, 25, 46, 726, DateTimeKind.Local).AddTicks(4410), 75m, "530d8875-2ef7-4fcc-8af0-654d70f0897f", 48, 40, 0m, null, 1.5m, 1, "1", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 726, DateTimeKind.Local).AddTicks(4411) },
                    { 4, "Kayseri", "Litvanya", new DateTime(2025, 10, 15, 13, 25, 46, 726, DateTimeKind.Local).AddTicks(4543), "Baypure.Tahincioglu34@gmail.com", "Köypınar Sokak 98a, Amasya, Liberya", "Çabdar", "Çapanoğlu", "+90-745-191-42-42", 3, new DateTime(2025, 10, 15, 13, 25, 46, 726, DateTimeKind.Local).AddTicks(4543), 75m, "99e489fe-b203-4030-af2b-4cc0a0719007", 48, 40, 0m, null, 1.5m, 1, "0", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 726, DateTimeKind.Local).AddTicks(4544) },
                    { 5, "Erzincan", "Libya", new DateTime(2025, 10, 15, 13, 25, 46, 726, DateTimeKind.Local).AddTicks(4673), "Biligkongulsengun17@hotmail.com", "Ülkü Sokak 80c, Gümüşhane, Portekiz", "Bulmaz", "Çatalbaş", "+90-172-112-2-159", 3, new DateTime(2025, 10, 15, 13, 25, 46, 726, DateTimeKind.Local).AddTicks(4673), 75m, "89e41291-0e92-4045-a9a4-8d35c7d90db0", 48, 40, 0m, null, 1.5m, 1, "0", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 726, DateTimeKind.Local).AddTicks(4674) },
                    { 6, "Kars", "Finlandiya", new DateTime(2025, 10, 15, 13, 25, 46, 726, DateTimeKind.Local).AddTicks(4817), "Bayuncur.Oztuna@hotmail.com", "Afyon Kaya Sokak 1, Kütahya, Brunei", "Katunkız", "Özkök ", "+90-099-442-57-97", 3, new DateTime(2025, 10, 15, 13, 25, 46, 726, DateTimeKind.Local).AddTicks(4818), 75m, "16ca481a-cffa-4847-b210-57ab1b6a4cd6", 48, 40, 0m, null, 1.5m, 1, "1", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 726, DateTimeKind.Local).AddTicks(4818) },
                    { 7, "Konya", "İngiltere", new DateTime(2025, 10, 15, 13, 25, 46, 726, DateTimeKind.Local).AddTicks(4924), "Beyrem_Tahincioglu@gmail.com", "Mevlana Sokak 16b, Karaman, Sao Tome ve Principe", "Aktan", "Tazegül", "+90-957-511-8-724", 3, new DateTime(2025, 10, 15, 13, 25, 46, 726, DateTimeKind.Local).AddTicks(4924), 75m, "691d4273-2d03-4dbb-843b-dbe573ce0067", 48, 40, 0m, null, 1.5m, 1, "0", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 726, DateTimeKind.Local).AddTicks(4925) },
                    { 8, "Tekirdağ", "Moritanya", new DateTime(2025, 10, 15, 13, 25, 46, 727, DateTimeKind.Local).AddTicks(4451), "Ariboga.Tutuncu@gmail.com", "Atatürk Bulvarı 65b, Zonguldak, Laos", "Beçkem", "Sözeri", "+90-437-757-3-689", 3, new DateTime(2025, 10, 15, 13, 25, 46, 727, DateTimeKind.Local).AddTicks(4453), 60m, "21f3b60a-fc63-4cb5-8097-d3ad4e4ed21a", 48, 40, 0m, null, 1.5m, 2, "1", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 727, DateTimeKind.Local).AddTicks(4453) },
                    { 9, "Iğdır", "Gabon", new DateTime(2025, 10, 15, 13, 25, 46, 727, DateTimeKind.Local).AddTicks(4985), "Akkurt_Basoglu20@gmail.com", "Sarıkaya Caddesi 59, Kırşehir, Bhutan", "Arpat", "Koçoğlu", "+90-372-152-0-708", 3, new DateTime(2025, 10, 15, 13, 25, 46, 727, DateTimeKind.Local).AddTicks(4986), 60m, "20218e39-dfc5-4365-a5b9-40167f65efd5", 48, 40, 0m, null, 1.5m, 2, "1", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 727, DateTimeKind.Local).AddTicks(4986) },
                    { 10, "Kilis", "Nikaragua", new DateTime(2025, 10, 15, 13, 25, 46, 727, DateTimeKind.Local).AddTicks(5138), "Altay63@yahoo.com", "Ergenekon Sokak   3, Bilecik, Tayvan", "Burunduk", "Poçan", "+90-421-918-6-550", 3, new DateTime(2025, 10, 15, 13, 25, 46, 727, DateTimeKind.Local).AddTicks(5139), 60m, "1a9ae290-cc36-4bb7-bd4a-885e2a4af25f", 48, 40, 0m, null, 1.5m, 2, "0", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 727, DateTimeKind.Local).AddTicks(5139) },
                    { 11, "Yalova", "Liberya", new DateTime(2025, 10, 15, 13, 25, 46, 727, DateTimeKind.Local).AddTicks(5274), "Batuk.Bakircioglu32@gmail.com", "İsmet Attila Caddesi 81a, Yalova, Makedonya", "Adberilgen", "Tokgöz", "+90-525-094-51-53", 3, new DateTime(2025, 10, 15, 13, 25, 46, 727, DateTimeKind.Local).AddTicks(5274), 60m, "ef94db5c-b562-4132-a5b8-4bc6b73db07d", 48, 40, 0m, null, 1.5m, 2, "0", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 727, DateTimeKind.Local).AddTicks(5275) },
                    { 12, "Kırklareli", "Palmyra Atoll, Amerika", new DateTime(2025, 10, 15, 13, 25, 46, 727, DateTimeKind.Local).AddTicks(5400), "Alaboru_Karabulut31@hotmail.com", "Kaldırım Sokak 34b, Kayseri, Fildişi Sahili", "Alayunt", "Akar ", "+90-455-476-2-320", 3, new DateTime(2025, 10, 15, 13, 25, 46, 727, DateTimeKind.Local).AddTicks(5400), 60m, "4d882cd1-3b8f-423a-95a8-a3a5a1acf750", 48, 40, 0m, null, 1.5m, 2, "1", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 727, DateTimeKind.Local).AddTicks(5401) },
                    { 13, "Düzce", "Kuzey Maryana Adaları", new DateTime(2025, 10, 15, 13, 25, 46, 727, DateTimeKind.Local).AddTicks(5521), "Bitri.Barbarosoglu43@yahoo.com", "Barış Sokak 39a, Şırnak, Estonya", "Bozkurt", "Abacı", "+90-674-738-41-76", 3, new DateTime(2025, 10, 15, 13, 25, 46, 727, DateTimeKind.Local).AddTicks(5522), 60m, "f3174713-1ed5-4a0e-93f2-6ca38d76daeb", 48, 40, 0m, null, 1.5m, 2, "0", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 727, DateTimeKind.Local).AddTicks(5522) },
                    { 14, "Gaziantep", "Endonezya", new DateTime(2025, 10, 15, 13, 25, 46, 727, DateTimeKind.Local).AddTicks(5636), "Cemgen.Kuzucu37@hotmail.com", "İsmet Attila Caddesi 64b, Konya, Tacikistan", "Ayaş", "Babaoğlu", "+90-932-285-55-47", 3, new DateTime(2025, 10, 15, 13, 25, 46, 727, DateTimeKind.Local).AddTicks(5636), 60m, "f5686840-5f92-407c-9c20-c0b4b27342d3", 48, 40, 0m, null, 1.5m, 2, "1", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 727, DateTimeKind.Local).AddTicks(5636) },
                    { 15, "Bayburt", "Gine", new DateTime(2025, 10, 15, 13, 25, 46, 727, DateTimeKind.Local).AddTicks(5775), "Gokcen11@yahoo.com", "Okul Sokak 28a, Ankara, Türkiye", "Bilgetonyukuk", "Mertoğlu", "+90-489-440-79-06", 3, new DateTime(2025, 10, 15, 13, 25, 46, 727, DateTimeKind.Local).AddTicks(5775), 60m, "7aabeccd-62b3-42b2-87d8-872b6ec07ec9", 48, 40, 0m, null, 1.5m, 2, "0", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 727, DateTimeKind.Local).AddTicks(5775) },
                    { 16, "Karabük", "Libya", new DateTime(2025, 10, 15, 13, 25, 46, 727, DateTimeKind.Local).AddTicks(5875), "Barcatoyun.Kucukler69@yahoo.com", "Alparslan Türkeş Bulvarı 298, Burdur, Kosova", "Bölükbaşı", "Sinanoğlu", "+90-384-713-29-06", 3, new DateTime(2025, 10, 15, 13, 25, 46, 727, DateTimeKind.Local).AddTicks(5875), 60m, "1d45bb9d-f5f3-4765-9398-4800b748a3a3", 48, 40, 0m, null, 1.5m, 2, "0", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 727, DateTimeKind.Local).AddTicks(5876) },
                    { 17, "Isparta", "Antigua ve Barbuda", new DateTime(2025, 10, 15, 13, 25, 46, 727, DateTimeKind.Local).AddTicks(6000), "Butuk46@yahoo.com", "30 Ağustos Caddesi 77, Elazığ, Yunanistan", "Baştar", "Koyuncu", "+90-098-377-5-995", 3, new DateTime(2025, 10, 15, 13, 25, 46, 727, DateTimeKind.Local).AddTicks(6000), 60m, "9ad6ebfa-de06-4957-a138-63176913cebe", 48, 40, 0m, null, 1.5m, 2, "1", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 727, DateTimeKind.Local).AddTicks(6000) },
                    { 18, "Karaman", "Komorlar", new DateTime(2025, 10, 15, 13, 25, 46, 727, DateTimeKind.Local).AddTicks(6114), "Begdemir48@hotmail.com", "Afyon Kaya Sokak 14, Çankırı, Güney Kore", "Alpbilge", "Pekkan", "+90-701-103-1-487", 3, new DateTime(2025, 10, 15, 13, 25, 46, 727, DateTimeKind.Local).AddTicks(6115), 60m, "7b367c2e-a3e9-4b55-8c54-7225e5a439f7", 48, 40, 0m, null, 1.5m, 2, "0", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 727, DateTimeKind.Local).AddTicks(6115) },
                    { 19, "Çanakkale", "Etiyopya", new DateTime(2025, 10, 15, 13, 25, 46, 728, DateTimeKind.Local).AddTicks(6565), "Arpat_Tugluk@yahoo.com", "Harman Yolu Sokak  90, Denizli, Porto Riko, Amerika", "Isık", "Alpuğan", "+90-911-956-80-50", 3, new DateTime(2025, 10, 15, 13, 25, 46, 728, DateTimeKind.Local).AddTicks(6569), 90m, "d7dfadd5-3634-4c0c-bc97-463bc52a6a25", 48, 40, 0m, null, 1.5m, 3, "1", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 728, DateTimeKind.Local).AddTicks(6570) },
                    { 20, "Bolu", "Birmanya (Myanmar)", new DateTime(2025, 10, 15, 13, 25, 46, 728, DateTimeKind.Local).AddTicks(7276), "Bokde.Abaci61@gmail.com", "Okul Sokak 25b, Osmaniye, Niue, Yeni Zelanda", "Boylabağatarkan", "Saygıner", "+90-325-750-11-86", 3, new DateTime(2025, 10, 15, 13, 25, 46, 728, DateTimeKind.Local).AddTicks(7276), 90m, "7b49b8c7-5aba-4da7-8fbf-ce628069c18d", 48, 40, 0m, null, 1.5m, 3, "0", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 728, DateTimeKind.Local).AddTicks(7277) },
                    { 21, "Yozgat", "Cibuti", new DateTime(2025, 10, 15, 13, 25, 46, 728, DateTimeKind.Local).AddTicks(7423), "Kizilalma.Okumus@gmail.com", "İsmet Paşa Caddesi 28a, Çorum, Sri Lanka", "Alpamış", "Özbir", "+90-675-356-57-15", 3, new DateTime(2025, 10, 15, 13, 25, 46, 728, DateTimeKind.Local).AddTicks(7423), 90m, "7fd101f4-6b62-4fcc-b90a-9b2fd5416b8b", 48, 40, 0m, null, 1.5m, 3, "0", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 728, DateTimeKind.Local).AddTicks(7423) },
                    { 22, "Batman", "Bahreyn", new DateTime(2025, 10, 15, 13, 25, 46, 728, DateTimeKind.Local).AddTicks(7570), "Artut_Gonultas71@yahoo.com", "Okul Sokak 99c, Muş, Panama", "Başkırt", "Yalçın", "+90-832-387-3-646", 3, new DateTime(2025, 10, 15, 13, 25, 46, 728, DateTimeKind.Local).AddTicks(7570), 90m, "19b9a336-3314-4796-b291-888c5b56af64", 48, 40, 0m, null, 1.5m, 3, "1", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 728, DateTimeKind.Local).AddTicks(7571) },
                    { 23, "Burdur", "Vallis ve Futuna, Fransa", new DateTime(2025, 10, 15, 13, 25, 46, 728, DateTimeKind.Local).AddTicks(7689), "Baltaci.Velioglu75@yahoo.com", "Güven Yaka Sokak 64b, Niğde, Kenya", "Erinç", "Tuğluk", "+90-116-990-98-84", 3, new DateTime(2025, 10, 15, 13, 25, 46, 728, DateTimeKind.Local).AddTicks(7690), 90m, "6ff88af2-392c-42d4-9b29-353ed73a18a1", 48, 40, 0m, null, 1.5m, 3, "0", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 728, DateTimeKind.Local).AddTicks(7690) },
                    { 24, "Afyon", "Niue, Yeni Zelanda", new DateTime(2025, 10, 15, 13, 25, 46, 728, DateTimeKind.Local).AddTicks(7818), "Babir_Kocyigit@yahoo.com", "Kekeçoğlu Sokak 77b, Edirne, Wake Adaları, Amerika", "Ataç", "Türkyılmaz", "+90-590-758-8-682", 3, new DateTime(2025, 10, 15, 13, 25, 46, 728, DateTimeKind.Local).AddTicks(7818), 90m, "0457727f-9ae2-48b0-88fb-59790792c52f", 48, 40, 0m, null, 1.5m, 3, "1", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 728, DateTimeKind.Local).AddTicks(7818) },
                    { 25, "Tokat", "Somali", new DateTime(2025, 10, 15, 13, 25, 46, 728, DateTimeKind.Local).AddTicks(7955), "Alptegin88@yahoo.com", "Köypınar Sokak 704, Sivas, Romanya", "İldike", "Kavaklıoğlu", "+90-910-194-1-485", 3, new DateTime(2025, 10, 15, 13, 25, 46, 728, DateTimeKind.Local).AddTicks(7955), 90m, "bf39a95d-a593-472b-a545-60aa8a500149", 48, 40, 0m, null, 1.5m, 3, "1", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 728, DateTimeKind.Local).AddTicks(7955) },
                    { 26, "Çankırı", "Johnston Atoll, Amerika", new DateTime(2025, 10, 15, 13, 25, 46, 728, DateTimeKind.Local).AddTicks(8070), "Boke_Solmaz63@yahoo.com", "Dağınık Evler Sokak 681, Uşak, Jamaika", "Babur", "Türkyılmaz", "+90-904-454-37-64", 3, new DateTime(2025, 10, 15, 13, 25, 46, 728, DateTimeKind.Local).AddTicks(8070), 90m, "dadd179f-344a-401f-9485-2351a0c764de", 48, 40, 0m, null, 1.5m, 3, "0", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 728, DateTimeKind.Local).AddTicks(8070) },
                    { 27, "Niğde", "Turks ve Caicos Adaları, İngiltere", new DateTime(2025, 10, 15, 13, 25, 46, 728, DateTimeKind.Local).AddTicks(8186), "Afsin46@yahoo.com", "Bahçe Sokak 3, Hatay, Bolivya", "Irmak", "Kaya ", "+90-817-740-67-02", 3, new DateTime(2025, 10, 15, 13, 25, 46, 728, DateTimeKind.Local).AddTicks(8187), 90m, "ce1f6ca8-81da-4c3d-8351-c9c59c30330b", 48, 40, 0m, null, 1.5m, 3, "0", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 728, DateTimeKind.Local).AddTicks(8187) },
                    { 28, "Zonguldak", "Arjantin", new DateTime(2025, 10, 15, 13, 25, 46, 728, DateTimeKind.Local).AddTicks(8317), "Barsgan.Kahveci@hotmail.com", "Yunus Emre Sokak 74a, K.maraş, Yemen", "Günçiçek", "Ozansoy", "+90-449-564-7-122", 3, new DateTime(2025, 10, 15, 13, 25, 46, 728, DateTimeKind.Local).AddTicks(8318), 90m, "86cdb48a-f778-45ba-a54e-9d38e3a864f1", 48, 40, 0m, null, 1.5m, 3, "1", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 728, DateTimeKind.Local).AddTicks(8318) },
                    { 29, "Yalova", "Bhutan", new DateTime(2025, 10, 15, 13, 25, 46, 728, DateTimeKind.Local).AddTicks(8468), "Asikbulmus54@gmail.com", "Güven Yaka Sokak 71a, Bilecik, Gana", "Alptuğrul", "Çetiner", "+90-295-359-97-72", 3, new DateTime(2025, 10, 15, 13, 25, 46, 728, DateTimeKind.Local).AddTicks(8468), 90m, "eb586256-b2c2-42b2-9108-0b0acfee16c4", 48, 40, 0m, null, 1.5m, 3, "0", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 728, DateTimeKind.Local).AddTicks(8468) },
                    { 30, "Bartın", "Kanarya Adaları", new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(676), "Atalan22@hotmail.com", "Yunus Emre Sokak 43c, Kayseri, K.K.T.C.", "Bekeçarslan", "Evliyaoğlu", "+90-758-395-3-071", 3, new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(680), 65m, "3e8a32f9-deed-4328-953e-9b1c859ef136", 48, 40, 0m, null, 1.5m, 4, "0", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(681) },
                    { 31, "Diyarbakır", "İtalya", new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(1505), "Bastugrul_Uluhan41@gmail.com", "Dar Sokak 41, Gümüşhane, Azerbaycan", "Çemen", "Durak ", "+90-450-141-0-430", 3, new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(1506), 65m, "950e1d65-24fb-488b-af40-99f1f6ee6e08", 48, 40, 0m, null, 1.5m, 4, "0", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(1506) },
                    { 32, "Trabzon", "Kırgızistan", new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(1740), "Belguc.Yazici@gmail.com", "İbn-i Sina Sokak 6, Sakarya, Svalbard, Norveç", "Iyık", "Balaban", "+90-665-006-1-997", 3, new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(1741), 65m, "f2e48d30-e7a9-447d-898f-8ff40d1906bf", 48, 40, 0m, null, 1.5m, 4, "1", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(1741) },
                    { 33, "Mardin", "Marşal Adaları", new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(2013), "Arslanboru_Tekelioglu67@yahoo.com", "İbn-i Sina Sokak 12a, Kırıkkale, İtalya", "Aytak", "Akal", "+90-163-272-85-88", 3, new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(2013), 65m, "4e8903d2-f74b-481a-b709-2b18fa0d41d5", 48, 40, 0m, null, 1.5m, 4, "0", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(2014) },
                    { 34, "Ağrı", "Almanya", new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(2152), "Akboru_Abaci@gmail.com", "Güven Yaka Sokak 95b, Tekirdağ, Benin", "Çağrı", "Başoğlu", "+90-262-056-64-25", 3, new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(2153), 65m, "e18fbabf-e84d-4d05-a1f3-bcfc548c9b21", 48, 40, 0m, null, 1.5m, 4, "0", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(2154) },
                    { 35, "Niğde", "Moldavya", new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(2303), "Atli25@hotmail.com", "Ergenekon Sokak   9, Van, Guam, Amerika", "Boylabağa", "Köybaşı", "+90-212-659-29-77", 3, new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(2304), 65m, "67bd8385-10ba-4206-b791-d8d6a0eb4f11", 48, 40, 0m, null, 1.5m, 4, "1", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(2304) },
                    { 36, "Bolu", "Kiribati", new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(2447), "Alpurungu.Sinanoglu@yahoo.com", "Mevlana Sokak 44, Manisa, Güney Afrika", "Alımga", "Akal", "+90-207-110-48-99", 3, new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(2447), 65m, "a342e5e7-1232-4a3e-9469-a290eb4647df", 48, 40, 0m, null, 1.5m, 4, "0", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(2447) },
                    { 37, "Bitlis", "Haiti", new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(2584), "Bacman.Ertepinar58@gmail.com", "Okul Sokak 44a, Sakarya, Fiji", "Babır", "Kıraç ", "+90-190-539-1-316", 3, new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(2585), 65m, "d9c0a329-4698-44fe-8754-4226bf3b3ddd", 48, 40, 0m, null, 1.5m, 4, "1", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(2585) },
                    { 38, "Ordu", "Botswana", new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(2717), "Boru.Koyuncu87@yahoo.com", "Dar Sokak 95a, Denizli, Malezya", "Baçman", "Çörekçi", "+90-494-216-9-286", 3, new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(2718), 65m, "331095ed-9424-454b-a507-cc7d67237b23", 48, 40, 0m, null, 1.5m, 4, "1", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(2718) },
                    { 39, "Manisa", "Tayvan", new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(2847), "Altan0@hotmail.com", "Ülkü Sokak 73b, Muş, Litvanya", "Aladağ", "Nebioğlu", "+90-352-284-0-191", 3, new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(2848), 65m, "bf01d232-2670-428d-95a0-6e6a43b159d6", 48, 40, 0m, null, 1.5m, 4, "0", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(2848) },
                    { 40, "Yalova", "Uganda", new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(2961), "Bugra96@gmail.com", "Gül Sokak 9, Ağrı, Küba", "Ilaçın", "Çamdalı", "+90-496-525-0-684", 3, new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(2962), 65m, "8bf78559-55a5-4ae4-8cf2-2715161104c9", 48, 40, 0m, null, 1.5m, 4, "0", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(2962) },
                    { 41, "Malatya", "Aruba, Hollanda", new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(3085), "Azganaz_Kaya90@gmail.com", "Okul Sokak 39a, Edirne, Rusya Federasyonu", "Gülegen", "Dizdar ", "+90-272-868-2-960", 3, new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(3085), 65m, "84e4c5f6-0cd7-4390-8c11-506082156e40", 48, 40, 0m, null, 1.5m, 4, "1", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(3086) },
                    { 42, "Eskişehir", "Makau (Makao)", new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(3202), "Aral61@yahoo.com", "Okul Sokak 632, Aksaray, Katar", "Büke", "Berberoğlu", "+90-214-250-32-72", 3, new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(3203), 65m, "e1be4114-d249-4582-93fb-a47b80ceeba4", 48, 40, 0m, null, 1.5m, 4, "0", 5, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 730, DateTimeKind.Local).AddTicks(3203) },
                    { 43, "Kayseri", "Ekvator", new DateTime(2025, 10, 15, 13, 25, 46, 736, DateTimeKind.Local).AddTicks(8402), "Basar_Denkel88@hotmail.com", "Sıran Söğüt Sokak 499, Aydın, Nepal", "Barımtay", "Ertepınar", "+90-195-134-27-94", 1, new DateTime(2025, 10, 15, 13, 25, 46, 736, DateTimeKind.Local).AddTicks(8412), 100m, "8cefb62e-ef5f-4124-b911-b2d13815f65a", 60, 40, 0m, null, 1.5m, 5, "1", 5, 0, 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 736, DateTimeKind.Local).AddTicks(8412) },
                    { 44, "Antalya", "Nikaragua", new DateTime(2025, 10, 15, 13, 25, 46, 737, DateTimeKind.Local).AddTicks(9850), "Cagritegin.Ozgorkey@hotmail.com", "Lütfi Karadirek Caddesi 61c, Burdur, Dominika", "Begni", "Okur", "+90-750-157-3-065", 2, new DateTime(2025, 10, 15, 13, 25, 46, 737, DateTimeKind.Local).AddTicks(9857), 0m, "83c05437-994e-44dd-96bd-5307eb20cc14", 60, 40, 15000m, null, 0m, 6, "0", 5, 0, 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 737, DateTimeKind.Local).AddTicks(9857) }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "AllInclusivePricePerNight", "BasePricePerNight", "BedCount", "CreatedDate", "DataStatus", "Description", "EntryDate", "Floor", "HasAirConditioning", "HasBalcony", "HasHairDryer", "HasMinibar", "HasTV", "HasWiFi", "ImageUrl", "MasterId", "RoomCapacity", "RoomNumber", "SelectedStatus", "Status", "Type", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 400m, 300m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1850), 4, "Tek kişilik standart oda - 1. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1855), 1, true, false, true, false, true, true, "/images/rooms/single_1_101.jpg", "436af765-b8d6-4999-a6ef-239a7cb5ae9d", 1, 101, 0, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1856) },
                    { 2, 400m, 300m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1917), 4, "Tek kişilik standart oda - 1. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1917), 1, true, false, true, false, true, true, "/images/rooms/single_1_102.jpg", "b85d2686-e9b7-4245-a405-4a3922f97b69", 1, 102, 0, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1918) },
                    { 3, 400m, 300m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1933), 4, "Tek kişilik standart oda - 1. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1933), 1, true, false, true, false, true, true, "/images/rooms/single_1_103.jpg", "4d817c00-904e-416d-ab32-50d890e641fd", 1, 103, 0, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1933) },
                    { 4, 400m, 300m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1939), 4, "Tek kişilik standart oda - 1. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1939), 1, true, false, true, false, true, true, "/images/rooms/single_1_104.jpg", "0c6373fd-3610-47b5-bb60-b4bed52bfb72", 1, 104, 0, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1939) },
                    { 5, 400m, 300m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1945), 4, "Tek kişilik standart oda - 1. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1945), 1, true, false, true, false, true, true, "/images/rooms/single_1_105.jpg", "8826b3b4-f161-45d4-869f-123583abc2e3", 1, 105, 0, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1946) },
                    { 6, 400m, 300m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1953), 4, "Tek kişilik standart oda - 1. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1953), 1, true, false, true, false, true, true, "/images/rooms/single_1_106.jpg", "de7b2254-9630-43e7-9b4b-0e50ff9febc9", 1, 106, 0, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1953) },
                    { 7, 400m, 300m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1959), 4, "Tek kişilik standart oda - 1. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1959), 1, true, false, true, false, true, true, "/images/rooms/single_1_107.jpg", "0076b8c2-591d-441b-8eb0-45f42c0c1009", 1, 107, 0, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1959) },
                    { 8, 400m, 300m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1964), 4, "Tek kişilik standart oda - 1. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1965), 1, true, false, true, false, true, true, "/images/rooms/single_1_108.jpg", "e9225c67-96b1-412a-8b5d-e7f611e75283", 1, 108, 0, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1965) },
                    { 9, 400m, 300m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1972), 4, "Tek kişilik standart oda - 1. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1972), 1, true, false, true, false, true, true, "/images/rooms/single_1_109.jpg", "4d0b5330-b65a-4381-bfc8-1ba49dde0e00", 1, 109, 0, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1973) },
                    { 10, 400m, 300m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1978), 4, "Tek kişilik standart oda - 1. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1978), 1, true, false, true, false, true, true, "/images/rooms/single_1_110.jpg", "76506159-d444-4bdb-a64d-95c3539952ae", 1, 110, 0, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1979) },
                    { 11, 900m, 700m, 3, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1984), 4, "Üç kişilik oda - 1. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1984), 1, true, false, true, true, true, true, "/images/rooms/triple_1_131.jpg", "4fb3f4c4-8082-45a7-9368-0450efb899d3", 3, 131, 0, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1985) },
                    { 12, 900m, 700m, 3, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1993), 4, "Üç kişilik oda - 1. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1994), 1, true, false, true, true, true, true, "/images/rooms/triple_1_132.jpg", "30eca6eb-f1f0-408a-a075-bff89992beef", 3, 132, 0, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1994) },
                    { 13, 900m, 700m, 3, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1999), 4, "Üç kişilik oda - 1. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1999), 1, true, false, true, true, true, true, "/images/rooms/triple_1_133.jpg", "9e34549e-e3fb-4cae-aff7-d83924a08a0f", 3, 133, 0, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(1999) },
                    { 14, 900m, 700m, 3, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2004), 4, "Üç kişilik oda - 1. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2004), 1, true, false, true, true, true, true, "/images/rooms/triple_1_134.jpg", "9e89f7f6-e621-4b85-8526-c9692a3b0331", 3, 134, 0, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2005) },
                    { 15, 900m, 700m, 3, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2009), 4, "Üç kişilik oda - 1. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2009), 1, true, false, true, true, true, true, "/images/rooms/triple_1_135.jpg", "37bf8034-c907-42f6-a55a-ea78e6dfceb3", 3, 135, 0, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2010) },
                    { 16, 900m, 700m, 3, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2015), 4, "Üç kişilik oda - 1. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2015), 1, true, false, true, true, true, true, "/images/rooms/triple_1_136.jpg", "b1703002-c09b-4cae-8ff5-dc84ad652446", 3, 136, 0, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2015) },
                    { 17, 900m, 700m, 3, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2021), 4, "Üç kişilik oda - 1. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2021), 1, true, false, true, true, true, true, "/images/rooms/triple_1_137.jpg", "b4928616-13c6-402d-8855-aec2a8075078", 3, 137, 0, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2021) },
                    { 18, 900m, 700m, 3, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2027), 4, "Üç kişilik oda - 1. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2027), 1, true, false, true, true, true, true, "/images/rooms/triple_1_138.jpg", "3356cba5-2ff0-4fe5-960f-42ae72629185", 3, 138, 0, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2028) },
                    { 19, 900m, 700m, 3, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2037), 4, "Üç kişilik oda - 1. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2038), 1, true, false, true, true, true, true, "/images/rooms/triple_1_139.jpg", "1693b684-0603-48bc-869b-a2920c7f7941", 3, 139, 0, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2038) },
                    { 20, 900m, 700m, 3, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2043), 4, "Üç kişilik oda - 1. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2043), 1, true, false, true, true, true, true, "/images/rooms/triple_1_140.jpg", "06b96262-596a-4cf9-b60e-6447b39e5f39", 3, 140, 0, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2043) },
                    { 21, 400m, 300m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2049), 4, "Tek kişilik standart oda - 2. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2049), 2, true, false, true, false, true, true, "/images/rooms/single_2_201.jpg", "28c79d57-9e58-474e-a0c0-ca19d892117a", 1, 201, 0, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2050) },
                    { 22, 400m, 300m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2055), 4, "Tek kişilik standart oda - 2. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2056), 2, true, false, true, false, true, true, "/images/rooms/single_2_202.jpg", "3e430608-399e-472c-acdb-c9a0f3fcb5db", 1, 202, 0, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2056) },
                    { 23, 400m, 300m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2061), 4, "Tek kişilik standart oda - 2. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2061), 2, true, false, true, false, true, true, "/images/rooms/single_2_203.jpg", "c92ad332-641c-4b66-a479-a0dd6486d4a1", 1, 203, 0, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2061) },
                    { 24, 400m, 300m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2066), 4, "Tek kişilik standart oda - 2. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2067), 2, true, false, true, false, true, true, "/images/rooms/single_2_204.jpg", "6f65d378-49f2-4e19-9078-536e0167fc83", 1, 204, 0, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2067) },
                    { 25, 400m, 300m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2073), 4, "Tek kişilik standart oda - 2. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2073), 2, true, false, true, false, true, true, "/images/rooms/single_2_205.jpg", "d94b844c-e1cb-4b0f-967a-608273fa4747", 1, 205, 0, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2073) },
                    { 26, 400m, 300m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2078), 4, "Tek kişilik standart oda - 2. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2078), 2, true, false, true, false, true, true, "/images/rooms/single_2_206.jpg", "6e3bb960-1943-487e-8def-75eaf42ca7a4", 1, 206, 0, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2078) },
                    { 27, 400m, 300m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2083), 4, "Tek kişilik standart oda - 2. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2083), 2, true, false, true, false, true, true, "/images/rooms/single_2_207.jpg", "e6d53368-445c-43ad-9731-c55b57d9ac24", 1, 207, 0, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2083) },
                    { 28, 400m, 300m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2088), 4, "Tek kişilik standart oda - 2. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2088), 2, true, false, true, false, true, true, "/images/rooms/single_2_208.jpg", "94fba066-675c-47ed-9ff9-b0203898da4c", 1, 208, 0, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2088) },
                    { 29, 400m, 300m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2093), 4, "Tek kişilik standart oda - 2. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2093), 2, true, false, true, false, true, true, "/images/rooms/single_2_209.jpg", "15af2ce2-b8dd-40d3-82f3-678011dacf68", 1, 209, 0, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2093) },
                    { 30, 400m, 300m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2098), 4, "Tek kişilik standart oda - 2. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2099), 2, true, false, true, false, true, true, "/images/rooms/single_2_210.jpg", "a1f1eaf2-4802-4241-bb37-3b16137ea60c", 1, 210, 0, 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2099) },
                    { 31, 650m, 500m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2104), 4, "İki kişilik duble oda - 2. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2104), 2, true, false, true, true, true, true, "/images/rooms/double_2_221.jpg", "32a182b9-1e65-4459-9bc8-0774c6fca4fb", 2, 221, 0, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2104) },
                    { 32, 650m, 500m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2113), 4, "İki kişilik duble oda - 2. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2113), 2, true, false, true, true, true, true, "/images/rooms/double_2_222.jpg", "c9c50403-600e-4cd7-b543-007a1881c1e2", 2, 222, 0, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2113) },
                    { 33, 650m, 500m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2120), 4, "İki kişilik duble oda - 2. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2120), 2, true, false, true, true, true, true, "/images/rooms/double_2_223.jpg", "982a4b2d-3b59-460c-8ffa-e6a01e5dc21f", 2, 223, 0, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2120) },
                    { 34, 650m, 500m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2130), 4, "İki kişilik duble oda - 2. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2131), 2, true, false, true, true, true, true, "/images/rooms/double_2_224.jpg", "c503bdc0-d354-4a12-9a16-713dc82d829a", 2, 224, 0, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2131) },
                    { 35, 650m, 500m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2137), 4, "İki kişilik duble oda - 2. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2137), 2, true, false, true, true, true, true, "/images/rooms/double_2_225.jpg", "bde0d0c8-8f34-4bdb-91e3-acffd9f5aefe", 2, 225, 0, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2137) },
                    { 36, 650m, 500m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2142), 4, "İki kişilik duble oda - 2. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2142), 2, true, false, true, true, true, true, "/images/rooms/double_2_226.jpg", "20c75b64-776e-4c17-bf1b-2bb45e274c3e", 2, 226, 0, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2142) },
                    { 37, 650m, 500m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2147), 4, "İki kişilik duble oda - 2. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2147), 2, true, false, true, true, true, true, "/images/rooms/double_2_227.jpg", "695da8bc-04cc-4bbe-b545-60aeffd2be7e", 2, 227, 0, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2147) },
                    { 38, 650m, 500m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2152), 4, "İki kişilik duble oda - 2. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2152), 2, true, false, true, true, true, true, "/images/rooms/double_2_228.jpg", "ef9371ac-6102-4bba-92e9-eeec9a5ee69b", 2, 228, 0, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2152) },
                    { 39, 650m, 500m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2157), 4, "İki kişilik duble oda - 2. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2157), 2, true, false, true, true, true, true, "/images/rooms/double_2_229.jpg", "277936cf-e242-41d8-8287-c0f25982d01b", 2, 229, 0, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2157) },
                    { 40, 650m, 500m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2162), 4, "İki kişilik duble oda - 2. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2162), 2, true, false, true, true, true, true, "/images/rooms/double_2_230.jpg", "a0464fa5-8d87-4345-a3d0-5274504d89ee", 2, 230, 0, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2162) },
                    { 41, 650m, 500m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2168), 4, "İki kişilik duble oda - 3. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2169), 3, true, true, true, true, true, true, "/images/rooms/double_3_301.jpg", "648831bf-1e9e-4d23-a7b7-13ae159daa35", 2, 301, 0, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2169) },
                    { 42, 650m, 500m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2173), 4, "İki kişilik duble oda - 3. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2174), 3, true, true, true, true, true, true, "/images/rooms/double_3_302.jpg", "6f809905-05ad-4e07-8959-bbe4a5c6616d", 2, 302, 0, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2174) },
                    { 43, 650m, 500m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2179), 4, "İki kişilik duble oda - 3. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2179), 3, true, true, true, true, true, true, "/images/rooms/double_3_303.jpg", "07064928-ce23-445a-adca-908730150040", 2, 303, 0, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2179) },
                    { 44, 650m, 500m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2184), 4, "İki kişilik duble oda - 3. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2184), 3, true, true, true, true, true, true, "/images/rooms/double_3_304.jpg", "2cc1184a-39b6-401d-9ab8-98ccbf30fce6", 2, 304, 0, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2184) },
                    { 45, 650m, 500m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2189), 4, "İki kişilik duble oda - 3. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2189), 3, true, true, true, true, true, true, "/images/rooms/double_3_305.jpg", "0e4442db-a72c-422c-b46d-33ef9dc05b62", 2, 305, 0, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2189) },
                    { 46, 650m, 500m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2194), 4, "İki kişilik duble oda - 3. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2194), 3, true, true, true, true, true, true, "/images/rooms/double_3_306.jpg", "adbd5c0b-469d-4e34-ba4b-901b6fdebcbf", 2, 306, 0, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2194) },
                    { 47, 650m, 500m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2199), 4, "İki kişilik duble oda - 3. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2199), 3, true, true, true, true, true, true, "/images/rooms/double_3_307.jpg", "e0bac83e-26d2-4ce3-8541-46e250c27420", 2, 307, 0, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2200) },
                    { 48, 650m, 500m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2204), 4, "İki kişilik duble oda - 3. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2204), 3, true, true, true, true, true, true, "/images/rooms/double_3_308.jpg", "21795d23-7d74-41b8-b3da-3d7ed3bd7945", 2, 308, 0, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2205) },
                    { 49, 650m, 500m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2210), 4, "İki kişilik duble oda - 3. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2210), 3, true, true, true, true, true, true, "/images/rooms/double_3_309.jpg", "ce4d91ec-2c04-47b4-8e04-eee90f8280ff", 2, 309, 0, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2211) },
                    { 50, 650m, 500m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2215), 4, "İki kişilik duble oda - 3. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2216), 3, true, true, true, true, true, true, "/images/rooms/double_3_310.jpg", "a23c0d01-2b47-4568-88b9-467b8889fe7d", 2, 310, 0, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2216) },
                    { 51, 900m, 700m, 3, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2226), 4, "Üç kişilik oda - 3. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2226), 3, true, true, true, true, true, true, "/images/rooms/triple_3_321.jpg", "f2341d5b-4d1b-40d4-b010-83d582a5a0b2", 3, 321, 0, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2226) },
                    { 52, 900m, 700m, 3, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2232), 4, "Üç kişilik oda - 3. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2232), 3, true, true, true, true, true, true, "/images/rooms/triple_3_322.jpg", "6371347b-0c10-49ce-a711-f312752e2157", 3, 322, 0, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2232) },
                    { 53, 900m, 700m, 3, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2238), 4, "Üç kişilik oda - 3. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2238), 3, true, true, true, true, true, true, "/images/rooms/triple_3_323.jpg", "98ba160a-bc6d-48b7-a498-565bdeec88f8", 3, 323, 0, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2238) },
                    { 54, 900m, 700m, 3, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2243), 4, "Üç kişilik oda - 3. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2243), 3, true, true, true, true, true, true, "/images/rooms/triple_3_324.jpg", "60f117de-92c4-4da9-b04c-0b1e80010b4c", 3, 324, 0, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2244) },
                    { 55, 900m, 700m, 3, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2248), 4, "Üç kişilik oda - 3. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2249), 3, true, true, true, true, true, true, "/images/rooms/triple_3_325.jpg", "d6fee10d-5f9b-4ae7-9ac3-973743047f50", 3, 325, 0, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2249) },
                    { 56, 900m, 700m, 3, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2253), 4, "Üç kişilik oda - 3. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2254), 3, true, true, true, true, true, true, "/images/rooms/triple_3_326.jpg", "176c9058-c64e-42a5-b0a8-eb443f5fae7c", 3, 326, 0, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2254) },
                    { 57, 900m, 700m, 3, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2260), 4, "Üç kişilik oda - 3. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2260), 3, true, true, true, true, true, true, "/images/rooms/triple_3_327.jpg", "4a5900b6-a0ef-4037-9b98-d443623765ce", 3, 327, 0, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2261) },
                    { 58, 900m, 700m, 3, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2265), 4, "Üç kişilik oda - 3. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2265), 3, true, true, true, true, true, true, "/images/rooms/triple_3_328.jpg", "b48c4fa6-2fcc-48ea-a391-bd53ecf9499a", 3, 328, 0, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2266) },
                    { 59, 900m, 700m, 3, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2271), 4, "Üç kişilik oda - 3. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2271), 3, true, true, true, true, true, true, "/images/rooms/triple_3_329.jpg", "6df7b699-a0bc-44ac-bccd-e294f4ce3067", 3, 329, 0, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2271) },
                    { 60, 900m, 700m, 3, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2276), 4, "Üç kişilik oda - 3. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2276), 3, true, true, true, true, true, true, "/images/rooms/triple_3_330.jpg", "7446c3f2-b2e5-4019-864e-0682850a630e", 3, 330, 0, 1, 2, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2276) },
                    { 61, 650m, 500m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2281), 4, "İki kişilik duble oda - 4. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2281), 4, true, true, true, true, true, true, "/images/rooms/double_4_401.jpg", "a3e37066-e7bb-4c31-bd55-4fd7247acd12", 2, 401, 0, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2282) },
                    { 62, 650m, 500m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2287), 4, "İki kişilik duble oda - 4. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2287), 4, true, true, true, true, true, true, "/images/rooms/double_4_402.jpg", "b22b0982-6ede-4b03-938c-0873c38e8829", 2, 402, 0, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2288) },
                    { 63, 650m, 500m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2292), 4, "İki kişilik duble oda - 4. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2293), 4, true, true, true, true, true, true, "/images/rooms/double_4_403.jpg", "d9a8ce17-9d35-48f3-ae17-34b3196dfc37", 2, 403, 0, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2293) },
                    { 64, 650m, 500m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2297), 4, "İki kişilik duble oda - 4. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2298), 4, true, true, true, true, true, true, "/images/rooms/double_4_404.jpg", "2123b26f-17c6-4ad1-a102-c2a54073ce4b", 2, 404, 0, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2298) },
                    { 65, 650m, 500m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2304), 4, "İki kişilik duble oda - 4. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2304), 4, true, true, true, true, true, true, "/images/rooms/double_4_405.jpg", "56e053c4-6d71-4178-9912-7e7961bd12a8", 2, 405, 0, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2304) },
                    { 66, 650m, 500m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2314), 4, "İki kişilik duble oda - 4. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2315), 4, true, true, true, true, true, true, "/images/rooms/double_4_406.jpg", "dec074e1-3040-4b44-804a-07013e8e17d6", 2, 406, 0, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2315) },
                    { 67, 650m, 500m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2320), 4, "İki kişilik duble oda - 4. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2320), 4, true, true, true, true, true, true, "/images/rooms/double_4_407.jpg", "93c7bbf0-37f3-48da-ad6d-dee9378329c7", 2, 407, 0, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2320) },
                    { 68, 650m, 500m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2326), 4, "İki kişilik duble oda - 4. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2326), 4, true, true, true, true, true, true, "/images/rooms/double_4_408.jpg", "d78de87e-df9b-418f-a276-22d6446ba0c1", 2, 408, 0, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2326) },
                    { 69, 650m, 500m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2331), 4, "İki kişilik duble oda - 4. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2331), 4, true, true, true, true, true, true, "/images/rooms/double_4_409.jpg", "2cea5782-8758-4363-8671-acbe22e9e9f5", 2, 409, 0, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2332) },
                    { 70, 650m, 500m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2336), 4, "İki kişilik duble oda - 4. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2336), 4, true, true, true, true, true, true, "/images/rooms/double_4_410.jpg", "fff01737-283b-4a3e-8428-33d8fc1a8a50", 2, 410, 0, 1, 1, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2337) },
                    { 71, 1200m, 900m, 3, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2342), 4, "Dört kişilik aile odası - 4. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2342), 4, true, true, true, true, true, true, "/images/rooms/quadruple_4_421.jpg", "2f20e51c-2eb6-421e-8ce5-387870429cfe", 4, 421, 0, 1, 3, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2342) },
                    { 72, 1200m, 900m, 3, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2350), 4, "Dört kişilik aile odası - 4. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2351), 4, true, true, true, true, true, true, "/images/rooms/quadruple_4_422.jpg", "11f0fc6d-ff9e-4e9a-b663-9bf43d8c89ac", 4, 422, 0, 1, 3, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2351) },
                    { 73, 1200m, 900m, 3, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2358), 4, "Dört kişilik aile odası - 4. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2358), 4, true, true, true, true, true, true, "/images/rooms/quadruple_4_423.jpg", "13b9fc2b-fd9e-4dfa-9434-868efb0d3dc1", 4, 423, 0, 1, 3, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2358) },
                    { 74, 1200m, 900m, 3, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2363), 4, "Dört kişilik aile odası - 4. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2363), 4, true, true, true, true, true, true, "/images/rooms/quadruple_4_424.jpg", "287ecf7a-b436-4a21-a361-54d4203813f8", 4, 424, 0, 1, 3, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2364) },
                    { 75, 1200m, 900m, 3, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2369), 4, "Dört kişilik aile odası - 4. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2369), 4, true, true, true, true, true, true, "/images/rooms/quadruple_4_425.jpg", "310ef434-7984-42bc-953e-526d73414e78", 4, 425, 0, 1, 3, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2369) },
                    { 76, 1200m, 900m, 3, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2374), 4, "Dört kişilik aile odası - 4. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2374), 4, true, true, true, true, true, true, "/images/rooms/quadruple_4_426.jpg", "db97e268-cf19-498e-828b-0789ab2bf7f1", 4, 426, 0, 1, 3, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2374) },
                    { 77, 2000m, 1500m, 1, new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2380), 4, "Kral dairesi - 4. kat", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2380), 4, true, true, true, true, true, true, "/images/rooms/kingsuite_4_426.jpg", "350b06a3-1cf5-4aa0-a2f4-098587bd50ee", 2, 426, 0, 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 724, DateTimeKind.Local).AddTicks(2380) }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "PackageType", "PaymentMethod", "ReservationStatus", "RoomId", "SelectedStatus", "TotalAmount", "UpdatedComputerName", "UpdatedDate", "status" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 6, 28, 22, 33, 1, 958, DateTimeKind.Local).AddTicks(7114), new DateTime(2027, 2, 21, 16, 18, 7, 803, DateTimeKind.Local).AddTicks(7752), new DateTime(2025, 10, 15, 13, 25, 46, 739, DateTimeKind.Local).AddTicks(1272), 7, new DateTime(2025, 10, 15, 13, 25, 46, 739, DateTimeKind.Local).AddTicks(1273), "6d347e23-1be7-4a8d-bd74-b319de8dbf43", 0, 0, 0, 12, 0, 1705.31m, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 739, DateTimeKind.Local).AddTicks(1273), 0 },
                    { 2, new DateTime(2026, 5, 19, 9, 25, 30, 828, DateTimeKind.Local).AddTicks(2328), new DateTime(2026, 12, 23, 5, 21, 3, 371, DateTimeKind.Local).AddTicks(4211), new DateTime(2025, 10, 15, 13, 25, 46, 739, DateTimeKind.Local).AddTicks(1507), 1, new DateTime(2025, 10, 15, 13, 25, 46, 739, DateTimeKind.Local).AddTicks(1507), "68635765-6646-4c0d-a68b-0edb2fa3eeb8", 1, 1, 1, 39, 0, 1973.54m, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 739, DateTimeKind.Local).AddTicks(1508), 1 },
                    { 3, new DateTime(2026, 3, 23, 17, 7, 3, 355, DateTimeKind.Local).AddTicks(8907), new DateTime(2027, 1, 30, 6, 2, 33, 256, DateTimeKind.Local).AddTicks(1872), new DateTime(2025, 10, 15, 13, 25, 46, 739, DateTimeKind.Local).AddTicks(1534), 4, new DateTime(2025, 10, 15, 13, 25, 46, 739, DateTimeKind.Local).AddTicks(1535), "0f82086d-8503-4ec1-8feb-4286a2eb1d2f", 0, 2, 2, 16, 0, 2038.48m, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 739, DateTimeKind.Local).AddTicks(1535), 2 },
                    { 4, new DateTime(2026, 1, 18, 11, 17, 11, 832, DateTimeKind.Local).AddTicks(6537), new DateTime(2026, 6, 27, 11, 22, 55, 310, DateTimeKind.Local).AddTicks(4241), new DateTime(2025, 10, 15, 13, 25, 46, 739, DateTimeKind.Local).AddTicks(1551), 5, new DateTime(2025, 10, 15, 13, 25, 46, 739, DateTimeKind.Local).AddTicks(1551), "3d295fb9-7573-4af1-bb68-9c23c46ea4ea", 1, 3, 3, 7, 0, 2081.05m, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 739, DateTimeKind.Local).AddTicks(1551), 3 },
                    { 5, new DateTime(2025, 10, 16, 1, 23, 51, 95, DateTimeKind.Local).AddTicks(1593), new DateTime(2026, 9, 22, 13, 54, 43, 465, DateTimeKind.Local).AddTicks(9874), new DateTime(2025, 10, 15, 13, 25, 46, 739, DateTimeKind.Local).AddTicks(1568), 8, new DateTime(2025, 10, 15, 13, 25, 46, 739, DateTimeKind.Local).AddTicks(1568), "78f6b1b3-7854-41f0-86ca-1ed4a42424ef", 0, 4, 0, 42, 0, 1603.01m, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 739, DateTimeKind.Local).AddTicks(1568), 4 },
                    { 6, new DateTime(2025, 12, 19, 13, 50, 31, 732, DateTimeKind.Local).AddTicks(2006), new DateTime(2026, 4, 4, 1, 41, 13, 762, DateTimeKind.Local).AddTicks(2959), new DateTime(2025, 10, 15, 13, 25, 46, 739, DateTimeKind.Local).AddTicks(1583), 10, new DateTime(2025, 10, 15, 13, 25, 46, 739, DateTimeKind.Local).AddTicks(1584), "2ae3675b-3dd6-40f6-b98d-73f3ece513a1", 1, 0, 1, 1, 0, 2049.63m, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 739, DateTimeKind.Local).AddTicks(1584), 0 },
                    { 7, new DateTime(2026, 2, 8, 17, 27, 39, 462, DateTimeKind.Local).AddTicks(2551), new DateTime(2026, 12, 3, 5, 29, 36, 194, DateTimeKind.Local).AddTicks(1239), new DateTime(2025, 10, 15, 13, 25, 46, 739, DateTimeKind.Local).AddTicks(1599), 7, new DateTime(2025, 10, 15, 13, 25, 46, 739, DateTimeKind.Local).AddTicks(1599), "9cc45f15-4ab9-4ac6-8f94-fa5140fa2c84", 0, 1, 2, 24, 0, 2034.58m, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 739, DateTimeKind.Local).AddTicks(1599), 1 },
                    { 8, new DateTime(2026, 10, 6, 15, 46, 17, 456, DateTimeKind.Local).AddTicks(1183), new DateTime(2027, 3, 11, 17, 6, 49, 781, DateTimeKind.Local).AddTicks(9554), new DateTime(2025, 10, 15, 13, 25, 46, 739, DateTimeKind.Local).AddTicks(1612), 6, new DateTime(2025, 10, 15, 13, 25, 46, 739, DateTimeKind.Local).AddTicks(1613), "6332daf2-ad1d-4eb8-a90b-14631d59da49", 1, 2, 3, 43, 0, 2368.80m, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 739, DateTimeKind.Local).AddTicks(1613), 2 },
                    { 9, new DateTime(2026, 1, 9, 16, 12, 18, 807, DateTimeKind.Local).AddTicks(4213), new DateTime(2026, 8, 30, 23, 48, 11, 661, DateTimeKind.Local).AddTicks(6563), new DateTime(2025, 10, 15, 13, 25, 46, 739, DateTimeKind.Local).AddTicks(1626), 10, new DateTime(2025, 10, 15, 13, 25, 46, 739, DateTimeKind.Local).AddTicks(1626), "5ebb57ad-267f-43c8-a771-984a5fdce5bc", 0, 3, 0, 22, 0, 1835.08m, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 739, DateTimeKind.Local).AddTicks(1626), 3 },
                    { 10, new DateTime(2026, 9, 21, 18, 28, 59, 128, DateTimeKind.Local).AddTicks(7438), new DateTime(2027, 1, 4, 8, 6, 11, 592, DateTimeKind.Local).AddTicks(5090), new DateTime(2025, 10, 15, 13, 25, 46, 739, DateTimeKind.Local).AddTicks(1639), 7, new DateTime(2025, 10, 15, 13, 25, 46, 739, DateTimeKind.Local).AddTicks(1640), "f0fc9ba6-e8f9-4632-8fdc-9aa0e93a3655", 1, 4, 1, 4, 0, 1598.43m, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 739, DateTimeKind.Local).AddTicks(1640), 4 }
                });

            migrationBuilder.InsertData(
                table: "Shifts",
                columns: new[] { "Id", "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "SelectedStatus", "ShiftDate", "ShiftType", "StartTime", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2605), 1, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2605), "ecdd2254-d4d2-4af4-8aec-179d285b7a3b", 0, new DateTime(2025, 10, 15, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2605) },
                    { 2, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2635), 2, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2635), "a9df701e-cf16-4d7c-ba16-b149786698d8", 0, new DateTime(2025, 10, 15, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2636) },
                    { 3, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2640), 3, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2641), "71489c0a-a0d1-42b3-a5ee-9e17434e6451", 0, new DateTime(2025, 10, 15, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2641) },
                    { 4, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2645), 5, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2645), "0281feec-d801-44cf-95dd-9d4ae54c5359", 0, new DateTime(2025, 10, 15, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2645) },
                    { 5, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2658), 1, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2659), "ea5ac860-2118-4dcd-bbd4-54b95ff64cdf", 0, new DateTime(2025, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2659) },
                    { 6, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2664), 2, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2665), "b51258d8-6363-4e41-ac18-24b122a06cbb", 0, new DateTime(2025, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2665) },
                    { 7, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2670), 3, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2670), "4c429294-03ff-440b-8386-691dab859063", 0, new DateTime(2025, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2670) },
                    { 8, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2677), 4, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2677), "c39ceb6b-2122-43d6-bfcb-261f3e575673", 0, new DateTime(2025, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2677) },
                    { 9, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2684), 1, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2685), "be2cf672-5b38-4d8d-b79f-96f992aa045d", 0, new DateTime(2025, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2685) },
                    { 10, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2690), 2, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2690), "0e1bad36-aa4a-408a-b29e-2fd2edb6bab1", 0, new DateTime(2025, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2690) },
                    { 11, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2694), 3, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2694), "5f4807fe-98f3-4336-9276-dcf842f8b2ab", 0, new DateTime(2025, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2695) },
                    { 12, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2699), 4, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2699), "7b844f3f-3795-4174-a79c-76d48b7fd4a2", 0, new DateTime(2025, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2699) },
                    { 13, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2707), 1, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2707), "d5655d2e-1774-4882-a2b6-3d7ce3575c92", 0, new DateTime(2025, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2707) },
                    { 14, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2711), 2, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2711), "b7146c11-8fad-4aee-be9f-3aa09a043e73", 0, new DateTime(2025, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2712) },
                    { 15, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2715), 3, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2716), "43aa0eca-d858-4256-b23e-3873e834eb45", 0, new DateTime(2025, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2716) },
                    { 16, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2721), 4, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2721), "9b31d0ea-6ffb-42d3-b612-30cec59ef520", 0, new DateTime(2025, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2721) },
                    { 17, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2728), 2, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2729), "126ab21e-0f8b-4962-beca-08d3badb6f47", 0, new DateTime(2025, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2729) },
                    { 18, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2733), 3, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2734), "dcb4a43c-41e2-42f0-8291-5597ca56c99b", 0, new DateTime(2025, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2734) },
                    { 19, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2738), 4, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2739), "2e2856a5-fe19-4d50-96a0-4ce855f6b9d1", 0, new DateTime(2025, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2739) },
                    { 20, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2743), 5, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2743), "f40c48c6-734c-4257-ade8-8f643d5903a2", 0, new DateTime(2025, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2743) },
                    { 21, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2750), 1, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2750), "1f4000bd-04ed-451e-bd20-30fa97b38c14", 0, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2750) },
                    { 22, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2755), 3, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2755), "52521232-ad0d-42c2-971a-7f6219ad9e68", 0, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2755) },
                    { 23, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2759), 4, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2759), "b7a18c32-1068-435a-86f4-c23c3e4a5ad3", 0, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2760) },
                    { 24, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2764), 5, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2765), "5f9785c0-f5bf-4ccb-9644-bead5ecb112e", 0, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2765) },
                    { 25, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2771), 1, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2772), "5a143356-2a55-4264-8b21-9b94ab534a54", 0, new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2772) },
                    { 26, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2776), 2, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2776), "23cfd704-161f-40de-b921-75edd2fb9d08", 0, new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2777) },
                    { 27, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2780), 4, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2781), "e74de185-6114-423b-9690-a581aa83c8bb", 0, new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2781) },
                    { 28, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2785), 5, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2785), "5324a020-62e3-42ae-9e39-4db858736205", 0, new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2785) },
                    { 29, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2802), 8, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2802), "62c92735-0cac-4b40-980b-6192a0de3de6", 0, new DateTime(2025, 10, 15, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2803) },
                    { 30, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2808), 8, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2808), "6f7127d5-b72c-4980-8b8f-36a1fa15bdae", 0, new DateTime(2025, 10, 15, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2808) },
                    { 31, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2813), 9, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2813), "6757bda0-2dc9-4f8a-9a83-7be59793597b", 0, new DateTime(2025, 10, 15, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2814) },
                    { 32, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2819), 9, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2819), "bfb95642-ea6f-4bf4-83b5-e3859db682a2", 0, new DateTime(2025, 10, 15, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2819) },
                    { 33, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2824), 10, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2824), "af17c755-af4e-448a-a13e-41464dbbe3ad", 0, new DateTime(2025, 10, 15, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2824) },
                    { 34, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2829), 10, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2829), "e46224dd-80f2-484a-a692-7a690e62150f", 0, new DateTime(2025, 10, 15, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2829) },
                    { 35, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2834), 8, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2834), "af6b4dae-c596-4c78-9d7f-95ede8c252de", 0, new DateTime(2025, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2834) },
                    { 36, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2838), 8, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2838), "1b039cdb-b1ff-4153-b984-6380dad8afd7", 0, new DateTime(2025, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2839) },
                    { 37, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2843), 9, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2843), "773842e4-e116-42d3-bd72-d7e5ca56900e", 0, new DateTime(2025, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2843) },
                    { 38, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2847), 9, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2847), "0375478b-1f66-4078-9447-dcb8f17d7ad4", 0, new DateTime(2025, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2847) },
                    { 39, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2851), 10, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2851), "8a642696-e924-4c14-874f-138bab786001", 0, new DateTime(2025, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2852) },
                    { 40, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2856), 10, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2857), "8a042753-c2d0-4d57-8dd8-a8f982f827c3", 0, new DateTime(2025, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2857) },
                    { 41, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2861), 8, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2861), "2228b880-062a-40e8-a3e9-268ac8d85e36", 0, new DateTime(2025, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2862) },
                    { 42, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2865), 8, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2865), "460404b6-6de8-4aa4-aa81-7ccd9d8cb783", 0, new DateTime(2025, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2866) },
                    { 43, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2870), 9, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2870), "833f0d24-0348-4bda-8f93-e6ddac8bc1c1", 0, new DateTime(2025, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2870) },
                    { 44, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2874), 9, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2874), "2e4718ce-25c3-4c48-af83-8358ac6ab910", 0, new DateTime(2025, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2874) },
                    { 45, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2878), 10, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2879), "831248ca-d46f-419c-b2ea-c12dcc4fc9e4", 0, new DateTime(2025, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2879) },
                    { 46, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2883), 10, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2883), "d80f5a5b-f44b-428f-825b-ae5ee353015c", 0, new DateTime(2025, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2883) },
                    { 47, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2887), 8, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2888), "385ec62b-4b85-4f02-8ab2-92adbf798aac", 0, new DateTime(2025, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2888) },
                    { 48, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2893), 8, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2893), "39500107-9a57-4d7f-8853-90d66c640413", 0, new DateTime(2025, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2893) },
                    { 49, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2897), 9, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2898), "56da6273-5a97-4e2b-b29c-b4b417d20e5c", 0, new DateTime(2025, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2898) },
                    { 50, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2902), 9, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2902), "e2ad92bd-f900-48e4-9b30-64ce373d72ab", 0, new DateTime(2025, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2903) },
                    { 51, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2906), 10, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2907), "0950e987-0ac8-4002-ac85-7fad37928a3c", 0, new DateTime(2025, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2907) },
                    { 52, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2910), 10, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2911), "94158131-683f-49e6-b973-1159fe280240", 0, new DateTime(2025, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2911) },
                    { 53, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2915), 8, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2915), "5f01eae7-3bcd-4ae1-b134-83897999470c", 0, new DateTime(2025, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2915) },
                    { 54, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2919), 8, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2920), "d93b423b-a9a7-438a-8ad5-e0e0db15ba5a", 0, new DateTime(2025, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2920) },
                    { 55, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2924), 9, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2924), "c1128c3a-f3a0-4415-960b-56c92c373531", 0, new DateTime(2025, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2924) },
                    { 56, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2929), 9, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2929), "ea90f9e7-86c3-491f-8e3e-680b7385e34b", 0, new DateTime(2025, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2930) },
                    { 57, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2934), 10, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2934), "25efcc90-7bda-45be-a83b-9f37689bb9c7", 0, new DateTime(2025, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2934) },
                    { 58, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2938), 10, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2938), "0e3a17aa-0c51-4c53-8b13-685bb63e3dd4", 0, new DateTime(2025, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2938) },
                    { 59, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2949), 8, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2949), "a3023a43-969d-4f30-a963-566bc6e0368e", 0, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2949) },
                    { 60, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2953), 8, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2953), "1250ca24-f048-4596-a9dc-5d788fa6b5fd", 0, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2954) },
                    { 61, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2958), 9, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2958), "f2e27810-b175-4ea0-b539-551fe43f2241", 0, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2958) },
                    { 62, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2962), 9, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2962), "fa25db94-3e55-47a8-8a26-6d70560dbc2f", 0, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2963) },
                    { 63, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2967), 10, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2967), "203d58d8-bea0-407a-b009-fabdc01b2a02", 0, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2967) },
                    { 64, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2972), 10, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2973), "6b91b64d-2c0d-4bf8-a4c4-aa484dc0e689", 0, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2973) },
                    { 65, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2977), 8, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2977), "19d6ecaf-3428-4175-905b-5b078fb69b6f", 0, new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2978) },
                    { 66, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2982), 8, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2982), "fb10b5f2-01ff-431a-9db0-ff5b937e6e16", 0, new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2983) },
                    { 67, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2987), 9, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2987), "2d6868fb-5c79-4515-baa1-d14abe308b99", 0, new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2987) },
                    { 68, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2991), 9, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2991), "2510fd9b-5f7f-4e54-a163-a75141ef06b4", 0, new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2991) },
                    { 69, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2995), 10, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2995), "5db79fc8-3353-45a7-8f19-dca4de3a6396", 0, new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2996) },
                    { 70, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(2999), 10, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3000), "a6c530ca-52ab-4923-928b-9f8f9b73058e", 0, new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3000) },
                    { 71, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3028), 11, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3028), "db7bef98-3914-46f6-a600-0d72484c47bf", 0, new DateTime(2025, 10, 15, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3028) },
                    { 72, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3041), 12, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3041), "187cdb05-9904-4b89-bca8-512d35674966", 0, new DateTime(2025, 10, 15, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3041) },
                    { 73, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3046), 11, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3046), "3877113a-e26b-45a8-a712-37292414226c", 0, new DateTime(2025, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3046) },
                    { 74, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3052), 12, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3052), "db9187e9-080d-4136-ae3e-73d2a95b0d9f", 0, new DateTime(2025, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3053) },
                    { 75, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3057), 11, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3057), "746ffe51-43c4-4370-b015-49b84e15f93c", 0, new DateTime(2025, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3057) },
                    { 76, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3063), 12, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3063), "15d90805-da6b-4851-a026-0ef9658e9325", 0, new DateTime(2025, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3063) },
                    { 77, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3067), 12, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3068), "050fd9f0-a93b-47e5-b052-8622acc1ad53", 0, new DateTime(2025, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3068) },
                    { 78, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3074), 11, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3075), "b7cc6f5b-c03f-48ea-9bf9-fe1bb7d57d46", 0, new DateTime(2025, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3075) },
                    { 79, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3081), 12, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3081), "040684ce-67e2-4a2a-853a-6494c1a47d0b", 0, new DateTime(2025, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3081) },
                    { 80, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3085), 11, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3086), "452d7f34-105f-44ef-89c1-2702d0c9c3c7", 0, new DateTime(2025, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3086) },
                    { 81, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3092), 11, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3092), "6be55774-ea30-40d1-9b5f-c407a16a27b7", 0, new DateTime(2025, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3092) },
                    { 82, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3096), 12, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3096), "62b45b44-b4ee-4928-b9de-e4a22f4c32be", 0, new DateTime(2025, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3096) },
                    { 83, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3100), 12, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3100), "17149e49-94ff-4485-871b-6440fa0af0d5", 0, new DateTime(2025, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3101) },
                    { 84, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3105), 11, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3105), "a48864a3-c5d7-483c-bfd1-323023f9afb5", 0, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3105) },
                    { 85, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3110), 11, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3111), "ab1fe170-96af-4914-b5d5-484b4129cbd8", 0, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3111) },
                    { 86, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3121), 12, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3122), "ec3e7815-3d59-40ce-b9be-85f104c88c99", 0, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3122) },
                    { 87, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3125), 12, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3126), "21f00337-9a0c-4dad-9705-13efa6d7c32a", 0, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3126) },
                    { 88, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3130), 11, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3130), "0bff592b-02d8-4ada-9529-f0b9740475e9", 0, new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3130) },
                    { 89, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3136), 12, new TimeOnly(16, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3136), "2ea0715f-463c-4f9d-94ec-4a716c1ae672", 0, new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3136) },
                    { 90, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3140), 12, new TimeOnly(0, 0, 0), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3140), "6413497d-ece7-435b-a014-78b9373515e2", 0, new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(3141) }
                });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "SelectedStatus", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(675), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(678), 583.14m, new DateTime(2025, 4, 6, 4, 32, 29, 872, DateTimeKind.Local).AddTicks(4753), "Molestiae numquam sequi.", "Gorgeous Concrete Chicken", "65565a3f-8dd3-412d-998f-d1c2465b4b75", 2, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(679) },
                    { 2, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(859), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(859), 913.62m, new DateTime(2025, 7, 16, 0, 42, 7, 127, DateTimeKind.Local).AddTicks(805), "Ut aut sequi ducimus rerum.", "Incredible Soft Sausages", "66f3723b-39d7-42f8-bd69-a4778f7aebc5", 6, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(859) },
                    { 3, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(899), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(900), 948.01m, new DateTime(2025, 2, 6, 4, 24, 28, 444, DateTimeKind.Local).AddTicks(4801), "Dolores qui perspiciatis voluptas.", "Practical Cotton Ball", "ed066f2e-a60b-4bfa-a45b-3c11a07ed84a", 1, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(900) },
                    { 4, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(928), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(928), 514.27m, new DateTime(2025, 5, 18, 3, 43, 8, 517, DateTimeKind.Local).AddTicks(8998), "Ut a magni excepturi voluptatibus dolorum voluptatem facere iste.", "Handmade Cotton Gloves", "61570278-43b3-436e-b5bb-d470ff39f4dd", 9, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(929) },
                    { 5, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(963), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(963), 384.24m, new DateTime(2025, 4, 11, 9, 28, 20, 584, DateTimeKind.Local).AddTicks(1788), "Harum nihil eaque asperiores.", "Intelligent Rubber Bike", "c4bdf89d-e3e5-4b6e-81f4-b5afc51a99b8", 2, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(964) },
                    { 6, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(989), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(990), 606.27m, new DateTime(2025, 10, 6, 5, 16, 29, 701, DateTimeKind.Local).AddTicks(9804), "Earum hic rem ullam.", "Fantastic Concrete Ball", "08ad6b53-993a-491f-8301-c949e25c7f60", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(990) },
                    { 7, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(1014), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(1014), 763.09m, new DateTime(2025, 3, 3, 0, 48, 25, 501, DateTimeKind.Local).AddTicks(6867), "Praesentium ab aliquam enim omnis.", "Ergonomic Fresh Cheese", "808d6359-c7ed-4d95-812d-6799240c92d8", 3, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(1014) },
                    { 8, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(1043), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(1044), 713.57m, new DateTime(2025, 7, 9, 21, 35, 0, 489, DateTimeKind.Local).AddTicks(5756), "Autem corrupti saepe voluptatem.", "Unbranded Concrete Ball", "63870cfb-d14f-4cf3-937f-6d7a0bf94cb3", 2, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(1044) },
                    { 9, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(1069), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(1069), 21.05m, new DateTime(2025, 5, 6, 3, 52, 9, 495, DateTimeKind.Local).AddTicks(2516), "Voluptas quo et doloremque et facilis.", "Ergonomic Rubber Mouse", "ded0f157-b97f-4ca3-85ce-7241561454b7", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(1070) },
                    { 10, new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(1096), new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(1096), 677.04m, new DateTime(2024, 11, 6, 21, 35, 38, 1, DateTimeKind.Local).AddTicks(882), "Est voluptatem beatae commodi non cupiditate quasi cum dolores.", "Tasty Wooden Bike", "91eeaab6-a0fa-4593-940c-900eade619be", 3, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 15, 13, 25, 46, 725, DateTimeKind.Local).AddTicks(1097) }
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
                name: "IX_CustomerVisits_CustomerId",
                table: "CustomerVisits",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_DatabaseBackups_CreatedByEmployeeId",
                table: "DatabaseBackups",
                column: "CreatedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_ReservationId",
                table: "Expenses",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_ExtraCharges_CreatedByEmployeeId",
                table: "ExtraCharges",
                column: "CreatedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ExtraCharges_CustomerId",
                table: "ExtraCharges",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ExtraCharges_ReservationId",
                table: "ExtraCharges",
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
                name: "CustomerVisits");

            migrationBuilder.DropTable(
                name: "DatabaseBackups");

            migrationBuilder.DropTable(
                name: "DatabaseConfigurations");

            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "ExtraCharges");

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

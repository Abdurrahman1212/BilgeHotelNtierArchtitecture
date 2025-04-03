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
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivationCode = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_Users", x => x.Id);
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
                    table.ForeignKey(
                        name: "FK_Reservations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
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
                    { 1, "Lake Danykaburgh", "Vietnam", new DateTime(2025, 3, 31, 1, 9, 50, 325, DateTimeKind.Local).AddTicks(9431), "194 Joaquin Hollow, Lake Jovanny, Azerbaijan", "6", "GI62CTTT5903518W81246E2", "674-990-8653", "Jerel_Parisian@hotmail.com", new DateTime(2025, 3, 31, 1, 9, 50, 325, DateTimeKind.Local).AddTicks(9443), "Heather", "Hegmann", "5bf30a8c-5a74-4033-b31e-1584b34a57b5", "91915", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 325, DateTimeKind.Local).AddTicks(9443) },
                    { 2, "Jamisonchester", "Bolivia", new DateTime(2025, 3, 31, 1, 9, 50, 326, DateTimeKind.Local).AddTicks(486), "91758 Harold Prairie, New Keyshawnshire, Antarctica (the territory South of 60 deg S)", "5", "PS551693064120072379008320578", "911.313.2451", "Estevan_Kihn@yahoo.com", new DateTime(2025, 3, 31, 1, 9, 50, 326, DateTimeKind.Local).AddTicks(490), "Josiah", "Heathcote", "d18cba5c-3142-4fb5-b156-66fb918eb8a1", "93848-2155", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 326, DateTimeKind.Local).AddTicks(490) },
                    { 3, "South Haleybury", "Aruba", new DateTime(2025, 3, 31, 1, 9, 50, 326, DateTimeKind.Local).AddTicks(861), "38250 Rosella Turnpike, Mosciskistad, Belarus", "6", "GE78855195834070045999", "(247) 577-3674 x17829", "Rhiannon.Greenfelder92@gmail.com", new DateTime(2025, 3, 31, 1, 9, 50, 326, DateTimeKind.Local).AddTicks(862), "Stevie", "Rice", "44502658-b4f9-4a2c-99ba-aae7d5a69466", "61459-5973", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 326, DateTimeKind.Local).AddTicks(863) },
                    { 4, "Lake Mercedesville", "Namibia", new DateTime(2025, 3, 31, 1, 9, 50, 326, DateTimeKind.Local).AddTicks(1194), "595 Gislason Courts, Maggioville, Barbados", "1", "KZ879810K46I1G670858", "655-251-6107 x8157", "Jamarcus17@yahoo.com", new DateTime(2025, 3, 31, 1, 9, 50, 326, DateTimeKind.Local).AddTicks(1196), "Zoila", "Hegmann", "e5d620cc-54bd-4f4d-b0ca-0d30ae26a714", "05052", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 326, DateTimeKind.Local).AddTicks(1196) },
                    { 5, "North Sofia", "Comoros", new DateTime(2025, 3, 31, 1, 9, 50, 326, DateTimeKind.Local).AddTicks(1484), "806 Anjali Hills, East Enahaven, Dominica", "2", "GB75IKET59093802830367", "(994) 273-7337 x60979", "Colin.Friesen@yahoo.com", new DateTime(2025, 3, 31, 1, 9, 50, 326, DateTimeKind.Local).AddTicks(1485), "Reta", "Kerluke", "39ab2052-fcce-4f0a-9473-f0d28cfc5b5d", "60208-5487", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 326, DateTimeKind.Local).AddTicks(1486) },
                    { 6, "Port Odessa", "Tajikistan", new DateTime(2025, 3, 31, 1, 9, 50, 326, DateTimeKind.Local).AddTicks(1716), "137 Mikel Ville, Lake Tanyashire, Ecuador", "11", "LI2820463312J97000198", "472-601-6561", "Rosalia.Waelchi@gmail.com", new DateTime(2025, 3, 31, 1, 9, 50, 326, DateTimeKind.Local).AddTicks(1718), "Brody", "Kertzmann", "dfcbed87-3e57-4d32-a721-10c669e3fbee", "19958", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 326, DateTimeKind.Local).AddTicks(1718) },
                    { 7, "North Alexzander", "Algeria", new DateTime(2025, 3, 31, 1, 9, 50, 326, DateTimeKind.Local).AddTicks(1987), "14997 Briana Meadows, Mullerfurt, Spain", "4", "LB54040676T16801M781802W9QF5", "329-776-1079 x751", "Flossie.McKenzie34@gmail.com", new DateTime(2025, 3, 31, 1, 9, 50, 326, DateTimeKind.Local).AddTicks(1988), "Pauline", "Langosh", "d260c917-74ff-483b-87c6-796b2bc57830", "34860-2929", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 326, DateTimeKind.Local).AddTicks(1988) },
                    { 8, "North Jaime", "Bhutan", new DateTime(2025, 3, 31, 1, 9, 50, 326, DateTimeKind.Local).AddTicks(2247), "230 Bayer Streets, Port Araceli, Turkey", "7", "JO15EJJC2732017660540538753809", "398.771.3932", "Shawna_Goldner@hotmail.com", new DateTime(2025, 3, 31, 1, 9, 50, 326, DateTimeKind.Local).AddTicks(2247), "Delaney", "Christiansen", "92d71a54-f8b1-4d2e-84b4-85305a695ae5", "29043-3956", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 326, DateTimeKind.Local).AddTicks(2248) },
                    { 9, "Gerlachfurt", "Cameroon", new DateTime(2025, 3, 31, 1, 9, 50, 326, DateTimeKind.Local).AddTicks(2491), "0211 Rod Valley, North Adahmouth, Malawi", "8", "AZ85050200699800518000200423", "1-395-675-9951 x3905", "Erika26@gmail.com", new DateTime(2025, 3, 31, 1, 9, 50, 326, DateTimeKind.Local).AddTicks(2493), "Davion", "Abernathy", "bbbdc54e-a5d2-484a-9cfd-c5c64ce9bf3f", "47101", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 326, DateTimeKind.Local).AddTicks(2493) },
                    { 10, "Gislasonbury", "Bermuda", new DateTime(2025, 3, 31, 1, 9, 50, 326, DateTimeKind.Local).AddTicks(2766), "137 Nicolas Heights, Lake Maymieborough, Zimbabwe", "7", "MR1160750531404249650020747", "711.744.0806", "Kurt38@gmail.com", new DateTime(2025, 3, 31, 1, 9, 50, 326, DateTimeKind.Local).AddTicks(2766), "Alverta", "Hills", "0c8aae54-b08f-4f8a-a040-1fab8785d3e7", "67573-6358", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 326, DateTimeKind.Local).AddTicks(2767) }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "HourlyWage", "MasterId", "PostalCode", "SelectedStatus", "Status", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "South Randifort", "Liberia", new DateTime(2025, 5, 2, 16, 55, 29, 839, DateTimeKind.Local).AddTicks(3303), "Shaniya36@yahoo.com", "6688 Nicole Ford, Kaydenton, Argentina", "Clemmie", "Sanford", "1-545-934-1648 x6876", new DateTime(2025, 3, 31, 1, 9, 50, 330, DateTimeKind.Local).AddTicks(5850), 0m, "cdd675d8-0840-4c7e-a40e-c3ba94e651a8", "39485", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 9, 4, 13, 28, 315, DateTimeKind.Local).AddTicks(6175) },
                    { 2, "Lake Vanside", "Palestinian Territory", new DateTime(2025, 12, 21, 18, 0, 33, 162, DateTimeKind.Local).AddTicks(3864), "Marlon.Carroll@gmail.com", "22466 Bernadette Mount, Port Cooper, Pakistan", "Malcolm", "Koch", "710.775.5407 x3765", new DateTime(2025, 3, 31, 1, 9, 50, 330, DateTimeKind.Local).AddTicks(6331), 0m, "ef1d0742-cb8e-4ff9-8e24-fdb53eceee11", "90791-4541", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2026, 11, 24, 4, 51, 52, 889, DateTimeKind.Local).AddTicks(4409) },
                    { 3, "Port Kenborough", "Vietnam", new DateTime(2025, 7, 10, 12, 15, 41, 110, DateTimeKind.Local).AddTicks(6586), "Ursula_Bashirian87@hotmail.com", "319 Collins Mountain, West Lennieport, Haiti", "Hulda", "Hermiston", "1-379-541-0258 x424", new DateTime(2025, 3, 31, 1, 9, 50, 330, DateTimeKind.Local).AddTicks(6499), 0m, "93b24092-f490-4051-9075-baa4710b391d", "11341", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 11, 18, 4, 14, 30, 371, DateTimeKind.Local).AddTicks(3286) },
                    { 4, "West Lonny", "Aruba", new DateTime(2025, 8, 22, 8, 36, 28, 444, DateTimeKind.Local).AddTicks(9993), "Judy_Trantow51@hotmail.com", "7978 Upton Points, South Glenniehaven, Palau", "Myron", "Okuneva", "(902) 282-6487 x628", new DateTime(2025, 3, 31, 1, 9, 50, 330, DateTimeKind.Local).AddTicks(6658), 0m, "74674b03-f759-4964-97eb-5bc70e3faff3", "82421-9946", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 10, 24, 7, 26, 10, 347, DateTimeKind.Local).AddTicks(2420) },
                    { 5, "Port Denaport", "Turkmenistan", new DateTime(2025, 4, 15, 18, 42, 25, 930, DateTimeKind.Local).AddTicks(228), "Judge.Trantow11@yahoo.com", "5454 Shanahan Isle, North Stevie, Montserrat", "Cathrine", "Gibson", "800.498.1496", new DateTime(2025, 3, 31, 1, 9, 50, 330, DateTimeKind.Local).AddTicks(6796), 0m, "9c942726-9b5d-4914-b34a-73b57d50365d", "55824-1725", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2026, 2, 20, 17, 25, 19, 510, DateTimeKind.Local).AddTicks(8116) },
                    { 6, "Leannonland", "Argentina", new DateTime(2025, 8, 23, 9, 40, 44, 632, DateTimeKind.Local).AddTicks(7239), "Julius.Raynor1@yahoo.com", "3025 Gunnar Mountain, Jerodbury, Luxembourg", "Carolyn", "Hickle", "236-906-7204", new DateTime(2025, 3, 31, 1, 9, 50, 330, DateTimeKind.Local).AddTicks(6916), 0m, "e5154c38-b215-4554-a501-cf08722a4adf", "36402", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 12, 10, 16, 29, 35, 166, DateTimeKind.Local).AddTicks(4768) },
                    { 7, "Carrollmouth", "Cayman Islands", new DateTime(2025, 5, 12, 3, 55, 7, 416, DateTimeKind.Local).AddTicks(1836), "Kenton49@yahoo.com", "97242 VonRueden Canyon, Marcfort, Syrian Arab Republic", "Newton", "Herman", "816.789.0808", new DateTime(2025, 3, 31, 1, 9, 50, 330, DateTimeKind.Local).AddTicks(7040), 0m, "2f58db5c-934f-45ec-a8cf-fe0b4749f8eb", "77950", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2026, 2, 26, 5, 12, 43, 405, DateTimeKind.Local).AddTicks(7822) },
                    { 8, "Connellyville", "Ghana", new DateTime(2026, 1, 16, 8, 40, 30, 763, DateTimeKind.Local).AddTicks(4436), "Cheyenne18@gmail.com", "06397 Luna Inlet, West Lilyanfurt, United States of America", "Cathrine", "Kilback", "472.835.2308 x82373", new DateTime(2025, 3, 31, 1, 9, 50, 330, DateTimeKind.Local).AddTicks(7160), 0m, "725252a4-1a41-4e9e-8063-947c4b26032d", "42736", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2026, 5, 19, 12, 38, 47, 696, DateTimeKind.Local).AddTicks(6144) },
                    { 9, "Briceville", "Mauritania", new DateTime(2025, 8, 29, 19, 18, 58, 802, DateTimeKind.Local).AddTicks(4708), "Genoveva46@gmail.com", "5087 Raina Union, Kimville, Pitcairn Islands", "Rhett", "Gleason", "(570) 744-0293", new DateTime(2025, 3, 31, 1, 9, 50, 330, DateTimeKind.Local).AddTicks(7282), 0m, "4c3fa490-5cf5-4479-9d33-0b33e8d9fdf3", "02635-5388", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2026, 6, 28, 19, 10, 25, 43, DateTimeKind.Local).AddTicks(8528) },
                    { 10, "Averyton", "Cote d'Ivoire", new DateTime(2025, 12, 26, 23, 39, 3, 385, DateTimeKind.Local).AddTicks(9950), "Aurelia.Labadie30@yahoo.com", "259 Ebert Drives, New Drakemouth, Tokelau", "Odie", "Casper", "681.815.6772", new DateTime(2025, 3, 31, 1, 9, 50, 330, DateTimeKind.Local).AddTicks(7406), 0m, "88db0e4a-4f2c-49d4-a584-b83ab041cf01", "68932-6165", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2026, 8, 23, 7, 7, 19, 238, DateTimeKind.Local).AddTicks(8275) }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedDate", "DataStasus", "Description", "EntryDate", "Floor", "HasAirConditioning", "HasBalcony", "HasHairDryer", "HasMinibar", "HasTV", "HasWiFi", "ImageUrl", "MasterId", "PricePerNight", "RoomBreakfast", "RoomCapacity", "RoomNumber", "RoomType", "SelectedStatus", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(2854), 0, "Exercitationem necessitatibus vitae fugiat est.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(2858), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=751", "a0bbd1b3-9bb8-4c45-9514-adab54acafca", 2213.24m, false, 1, "1", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(2859) },
                    { 2, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3114), 1, "İnventore repellendus eligendi et et.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3115), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=837", "f208098a-36cf-4efb-b4f2-215663b9c354", 1576.39m, true, 2, "2", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3115) },
                    { 3, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3149), 2, "Delectus perspiciatis autem sed corporis.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3149), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=438", "37eec1b2-dfc8-4f5c-884f-64efb58d8fca", 1648.99m, true, 3, "3", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3149) },
                    { 4, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3176), 3, "Quia debitis deserunt optio at.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3176), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=43", "f2369615-66bb-495a-87e4-36122be2a0d5", 2210.29m, true, 4, "4", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3177) },
                    { 5, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3209), 4, "Qui temporibus delectus laboriosam quidem.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3209), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=384", "ad662760-de97-47d7-9fc7-d4bc0338280f", 1808.44m, true, 5, "5", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3209) },
                    { 6, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3239), 5, "Ratione vero quisquam error sunt.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3240), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=691", "ac08a54f-4894-4751-8f2e-8e6cc1d49f66", 1780.75m, false, 1, "6", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3240) },
                    { 7, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3263), 0, "Voluptas culpa nesciunt magnam ab.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3263), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=183", "f7469f88-e98e-42a7-af51-b6764dacb5fa", 2444.66m, true, 2, "7", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3263) },
                    { 8, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3287), 1, "At omnis aspernatur iure ab.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3287), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=65", "9663490d-d0a4-4064-bec7-9b0a133f3d32", 1839.56m, true, 3, "8", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3287) },
                    { 9, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3310), 2, "Ab totam tenetur culpa incidunt.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3311), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=540", "8a170a0f-6037-4de6-a984-979db436355c", 1655.15m, true, 4, "9", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3311) },
                    { 10, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3333), 3, "Ut eos deserunt omnis eos.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3333), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=783", "cf98fc35-a598-48f4-9b13-f9b0037f58c4", 2305.72m, true, 5, "10", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3333) },
                    { 11, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3369), 4, "Optio molestias officia itaque sed.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3369), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=719", "8e7a1a2c-bfc9-43a5-8cdd-00ebd40f983d", 1697.40m, false, 1, "11", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3369) },
                    { 12, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3400), 5, "Atque qui sunt deleniti molestiae.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3400), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=784", "f3b5ddaf-2537-48a5-8aa1-6aa7fb9aece3", 1750.74m, true, 2, "12", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3400) },
                    { 13, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3434), 0, "Rerum dolore ut culpa voluptas.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3434), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=410", "cfe4317b-bad8-4b58-9977-32661c3e9531", 1996.02m, true, 3, "13", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3434) },
                    { 14, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3465), 1, "Est corporis ipsa expedita cum.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3465), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=633", "d4178c8f-f4f7-458d-95c3-66cad30a51e7", 2447.72m, true, 4, "14", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3465) },
                    { 15, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3500), 2, "İusto natus aliquid debitis sint.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3500), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=1030", "2a768123-ebcf-40f1-bf21-c1bfc221d3cc", 1727.41m, true, 5, "15", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3500) },
                    { 16, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3536), 3, "Voluptatem et quia sit est.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3536), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=388", "8c6da1ac-c38d-459a-8e59-997409c18303", 1543.79m, false, 1, "16", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3537) },
                    { 17, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3562), 4, "Quia voluptatibus voluptates velit ipsa.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3562), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=706", "f9197cc6-0b53-457b-83bb-7d9d5862da20", 2020.49m, true, 2, "17", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3563) },
                    { 18, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3587), 5, "Alias quis suscipit est incidunt.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3587), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=828", "ceadb9c4-52fd-485f-91f5-54587078124d", 1566.92m, true, 3, "18", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3588) },
                    { 19, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3608), 0, "Veniam distinctio repudiandae molestias tempore.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3608), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=635", "42257b0e-d82e-48a5-b3da-f967cfe17aff", 2484.20m, true, 4, "19", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3608) },
                    { 20, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3629), 1, "Non hic beatae sed libero.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3630), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=745", "2389e45f-f88b-4c9a-95cc-796a1a01be14", 2472.22m, true, 5, "20", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3630) },
                    { 21, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3657), 2, "Minima porro sunt quas aut.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3657), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=270", "75264b48-6def-4aed-bff9-37a6ed7b688a", 2014.38m, false, 1, "21", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3657) },
                    { 22, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3677), 3, "Natus quia id et aut.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3677), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=114", "89e6fbe6-7b95-4f33-a61c-05ed0b5df6a3", 1713.76m, true, 2, "22", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3677) },
                    { 23, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3698), 4, "Eaque esse hic nulla corporis.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3698), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=210", "6aeebe56-177f-468e-9b52-b55d70d0a54f", 2027.45m, true, 3, "23", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3699) },
                    { 24, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3720), 5, "Rem nihil dolore dolor asperiores.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3720), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=289", "925b922b-ea81-4335-a166-014a984fbf37", 2465.39m, true, 4, "24", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3721) },
                    { 25, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3754), 0, "Consequatur rerum ipsum et beatae.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3754), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=721", "d2a5dbba-b3c7-43e2-b356-89298da0a1fc", 2371.95m, true, 5, "25", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3755) },
                    { 26, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3788), 1, "Et aut ut corporis ipsa.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3788), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=278", "1c5fcb57-1a81-4a9a-a379-1fb23570f999", 1703.04m, false, 1, "26", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3789) },
                    { 27, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3820), 2, "Nulla voluptas labore quae omnis.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3822), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=431", "b63875a3-659a-4e24-9286-fd554043d7e5", 1942.83m, true, 2, "27", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3822) },
                    { 28, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3846), 3, "İpsa assumenda ea velit quis.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3847), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=299", "19725858-c4d3-4e27-b376-70297bb87f06", 1764.09m, true, 3, "28", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3847) },
                    { 29, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3869), 4, "İpsum et est et nobis.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3869), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=556", "a4417a7e-8bde-4961-a9a4-a8c1d29b796d", 1814.00m, true, 4, "29", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3869) },
                    { 30, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3889), 5, "Maiores iste maxime odio id.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3889), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=714", "87f295f5-5ac4-468a-8732-8e1872e9c4c3", 1545.66m, true, 5, "30", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3889) },
                    { 31, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3914), 0, "Explicabo a aut asperiores magni.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3914), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=254", "4f85fb8b-1435-4ce5-b308-c170af0811cb", 2084.68m, false, 1, "31", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3915) },
                    { 32, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3937), 1, "Velit commodi excepturi maiores sed.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3937), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=217", "d7b4c9d7-4052-413c-9840-2a3f9dbd7a54", 2186.58m, true, 2, "32", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3938) },
                    { 33, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3959), 2, "Ullam labore nobis fugiat perspiciatis.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3959), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=860", "ddfb7874-8ea3-4727-ac76-3d78d8a7dc8d", 2474.34m, true, 3, "33", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3959) },
                    { 34, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3980), 3, "Ut laudantium et ut eligendi.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3980), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=76", "26235ec1-c647-403b-a29d-752503b91f3c", 1920.99m, true, 4, "34", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(3980) },
                    { 35, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4033), 4, "Et omnis adipisci labore aperiam.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4034), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=263", "0150094e-e0a6-459b-aa69-809f7d543bc5", 1972.38m, true, 5, "35", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4034) },
                    { 36, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4058), 5, "Explicabo nihil veniam doloribus est.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4059), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=603", "45f2475f-2521-4587-b46b-1bbdd157cb84", 2351.69m, false, 1, "36", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4059) },
                    { 37, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4080), 0, "Quod illum voluptatibus eaque perferendis.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4080), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=7", "3611d7e4-fff5-485f-9df2-45e32571d58d", 2092.19m, true, 2, "37", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4081) },
                    { 38, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4101), 1, "Dignissimos id vero ab est.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4102), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=157", "6c756037-782e-4ae9-8799-74667b3ae343", 1960.58m, true, 3, "38", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4102) },
                    { 39, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4121), 2, "Exercitationem ut excepturi atque culpa.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4122), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=560", "4fd97003-44c9-4abf-8d2d-b1c2e86b9098", 2258.80m, true, 4, "39", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4122) },
                    { 40, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4142), 3, "Quod magnam itaque enim ea.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4142), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=42", "48f05cf3-4ed9-453e-b9e5-9188dfcb0e87", 1981.58m, true, 5, "40", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4143) },
                    { 41, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4169), 4, "Eveniet voluptates harum sint consequatur.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4169), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=256", "9b7d5e23-2a3d-40b1-9548-ce9907fd29c3", 1841.33m, false, 1, "41", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4169) },
                    { 42, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4192), 5, "Nihil sequi omnis atque et.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4192), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=38", "ff59f8b3-9e17-4532-938d-805b1b95e4fc", 2397.89m, true, 2, "42", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4192) },
                    { 43, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4212), 0, "Quae vitae dolorem est at.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4212), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=314", "8b1ae090-31ca-40f6-bb00-19f2a97d7918", 2282.08m, true, 3, "43", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4212) },
                    { 44, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4232), 1, "Officia aut delectus voluptatem in.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4233), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=393", "687df797-e655-422a-890d-b594cb918c68", 2431.47m, true, 4, "44", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4233) },
                    { 45, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4254), 2, "Est fuga qui ut quis.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4254), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=637", "28f6a67e-d3fd-46b9-bd91-c64c6dd0a120", 2169.81m, true, 5, "45", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4255) },
                    { 46, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4279), 3, "Temporibus sunt in iure nihil.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4279), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=612", "9c449327-7df5-4a85-9c2c-b5477a2ba74b", 1609.90m, false, 1, "46", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4279) },
                    { 47, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4299), 4, "İllum in laborum nobis consequuntur.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4300), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=850", "19dd3c79-14f8-4027-b67a-3060a5bd6bff", 2091.85m, true, 2, "47", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4300) },
                    { 48, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4320), 5, "Adipisci qui est sunt aut.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4320), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=396", "977a0ad7-bec2-45c6-9111-2ce8db199952", 1887.70m, true, 3, "48", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4321) },
                    { 49, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4342), 0, "Vel consequatur officiis consequatur rerum.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4342), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=894", "09cc8392-374f-4f9b-95a8-30c3b176f59a", 2271.81m, true, 4, "49", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4342) },
                    { 50, new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4362), 1, "Ad nostrum reprehenderit repellat veniam.", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4362), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=486", "8d882ada-443e-4b6a-a4ee-78b820e2db8c", 1758.81m, true, 5, "50", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 327, DateTimeKind.Local).AddTicks(4362) }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "PackageType", "PaymentVerification", "RoomId", "SelectedStatus", "TotalAmount", "UpdatedComputerName", "UpdatedDate", "UserId", "status" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 9, 23, 13, 8, 180, DateTimeKind.Local).AddTicks(2897), new DateTime(2025, 9, 30, 22, 14, 33, 552, DateTimeKind.Local).AddTicks(4952), new DateTime(2025, 3, 31, 1, 9, 50, 336, DateTimeKind.Local).AddTicks(751), 9, new DateTime(2025, 3, 31, 1, 9, 50, 336, DateTimeKind.Local).AddTicks(752), "398705bd-eb29-4fd0-8077-f039741c1c51", 0, "6380-6905-9785-5506", 32, 4, 2325.40m, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 336, DateTimeKind.Local).AddTicks(753), null, 0 },
                    { 2, new DateTime(2025, 11, 3, 4, 6, 59, 274, DateTimeKind.Local).AddTicks(9337), new DateTime(2026, 2, 12, 14, 13, 49, 824, DateTimeKind.Local).AddTicks(9460), new DateTime(2025, 3, 31, 1, 9, 50, 336, DateTimeKind.Local).AddTicks(1814), 2, new DateTime(2025, 3, 31, 1, 9, 50, 336, DateTimeKind.Local).AddTicks(1815), "a061b5e2-3762-46a5-9a5c-488f277d4cbf", 1, "5591-5928-7098-3707", 41, 4, 2000.48m, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 336, DateTimeKind.Local).AddTicks(1815), null, 1 },
                    { 3, new DateTime(2025, 4, 23, 8, 27, 46, 726, DateTimeKind.Local).AddTicks(752), new DateTime(2025, 11, 4, 11, 58, 25, 730, DateTimeKind.Local).AddTicks(7326), new DateTime(2025, 3, 31, 1, 9, 50, 336, DateTimeKind.Local).AddTicks(2128), 9, new DateTime(2025, 3, 31, 1, 9, 50, 336, DateTimeKind.Local).AddTicks(2129), "45da2979-ecfd-4bd5-854f-41218f54c41a", 0, "6767-2880-6619-5505", 5, 4, 1993.58m, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 336, DateTimeKind.Local).AddTicks(2129), null, 2 },
                    { 4, new DateTime(2025, 8, 13, 8, 55, 57, 25, DateTimeKind.Local).AddTicks(278), new DateTime(2026, 8, 10, 5, 37, 6, 467, DateTimeKind.Local).AddTicks(2234), new DateTime(2025, 3, 31, 1, 9, 50, 336, DateTimeKind.Local).AddTicks(2335), 4, new DateTime(2025, 3, 31, 1, 9, 50, 336, DateTimeKind.Local).AddTicks(2335), "d48ae8b0-5bc0-4b29-b0c4-0fc475d0dc78", 1, "6011-6223-1587-0068-2360", 50, 4, 1933.67m, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 336, DateTimeKind.Local).AddTicks(2335), null, 3 },
                    { 5, new DateTime(2026, 3, 2, 13, 40, 6, 631, DateTimeKind.Local).AddTicks(7695), new DateTime(2026, 6, 11, 12, 52, 11, 246, DateTimeKind.Local).AddTicks(554), new DateTime(2025, 3, 31, 1, 9, 50, 336, DateTimeKind.Local).AddTicks(2521), 2, new DateTime(2025, 3, 31, 1, 9, 50, 336, DateTimeKind.Local).AddTicks(2521), "4d7dc1b2-c82b-4f94-abca-c195245ffdab", 0, "6759-3391-4911-5737-977", 19, 4, 1753.23m, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 336, DateTimeKind.Local).AddTicks(2521), null, 4 },
                    { 6, new DateTime(2025, 12, 9, 16, 31, 22, 600, DateTimeKind.Local).AddTicks(905), new DateTime(2026, 8, 28, 1, 11, 8, 346, DateTimeKind.Local).AddTicks(8145), new DateTime(2025, 3, 31, 1, 9, 50, 336, DateTimeKind.Local).AddTicks(2706), 3, new DateTime(2025, 3, 31, 1, 9, 50, 336, DateTimeKind.Local).AddTicks(2706), "f495eed3-f652-477a-90cc-09a0ca0cdf02", 1, "6709264828717402668", 29, 4, 2025.83m, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 336, DateTimeKind.Local).AddTicks(2706), null, 5 },
                    { 7, new DateTime(2025, 7, 26, 11, 0, 48, 100, DateTimeKind.Local).AddTicks(3769), new DateTime(2026, 3, 19, 1, 0, 40, 69, DateTimeKind.Local).AddTicks(7881), new DateTime(2025, 3, 31, 1, 9, 50, 336, DateTimeKind.Local).AddTicks(9761), 6, new DateTime(2025, 3, 31, 1, 9, 50, 336, DateTimeKind.Local).AddTicks(9762), "deb22bb6-c17a-4bae-83b0-90061188accb", 0, "5486-9900-3529-2873", 2, 4, 2154.18m, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 336, DateTimeKind.Local).AddTicks(9762), null, 0 },
                    { 8, new DateTime(2025, 4, 11, 22, 1, 47, 115, DateTimeKind.Local).AddTicks(6305), new DateTime(2025, 12, 25, 2, 20, 43, 127, DateTimeKind.Local).AddTicks(5438), new DateTime(2025, 3, 31, 1, 9, 50, 337, DateTimeKind.Local).AddTicks(260), 7, new DateTime(2025, 3, 31, 1, 9, 50, 337, DateTimeKind.Local).AddTicks(260), "17187465-1421-4163-9782-aa70f44b0062", 1, "6759-5817-0018-2099", 44, 4, 2177.49m, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 337, DateTimeKind.Local).AddTicks(261), null, 1 },
                    { 9, new DateTime(2025, 8, 21, 20, 30, 55, 717, DateTimeKind.Local).AddTicks(5236), new DateTime(2025, 9, 8, 10, 27, 19, 246, DateTimeKind.Local).AddTicks(3916), new DateTime(2025, 3, 31, 1, 9, 50, 337, DateTimeKind.Local).AddTicks(466), 9, new DateTime(2025, 3, 31, 1, 9, 50, 337, DateTimeKind.Local).AddTicks(466), "5d91bb91-c260-46ee-9b24-e81024885717", 0, "6011-6237-6377-5328-5449", 14, 4, 2079.48m, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 337, DateTimeKind.Local).AddTicks(466), null, 2 },
                    { 10, new DateTime(2026, 2, 9, 10, 19, 53, 560, DateTimeKind.Local).AddTicks(1099), new DateTime(2026, 3, 21, 18, 4, 8, 176, DateTimeKind.Local).AddTicks(9771), new DateTime(2025, 3, 31, 1, 9, 50, 337, DateTimeKind.Local).AddTicks(644), 9, new DateTime(2025, 3, 31, 1, 9, 50, 337, DateTimeKind.Local).AddTicks(645), "e9f01d51-c8a5-4524-9444-1b93f64bdd7b", 1, "3422-823696-17494", 42, 4, 2005.35m, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 337, DateTimeKind.Local).AddTicks(645), null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Shifts",
                columns: new[] { "Id", "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "SelectedStatus", "ShiftType", "StartTime", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 31, 1, 9, 50, 329, DateTimeKind.Local).AddTicks(6044), 4, new DateTime(2025, 10, 31, 10, 58, 7, 607, DateTimeKind.Local).AddTicks(4986), new DateTime(2025, 3, 31, 1, 9, 50, 329, DateTimeKind.Local).AddTicks(6049), "4243efaa-fe73-4b41-9bab-6ea509589528", 4, 0, new DateTime(2024, 6, 28, 0, 28, 40, 506, DateTimeKind.Local).AddTicks(4562), "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 329, DateTimeKind.Local).AddTicks(6050) },
                    { 2, new DateTime(2025, 3, 31, 1, 9, 50, 329, DateTimeKind.Local).AddTicks(6199), 5, new DateTime(2026, 1, 10, 4, 29, 4, 32, DateTimeKind.Local).AddTicks(7829), new DateTime(2025, 3, 31, 1, 9, 50, 329, DateTimeKind.Local).AddTicks(6199), "5f2bdb1c-0a73-448c-914a-a9cbfdc8af06", 4, 0, new DateTime(2025, 3, 11, 4, 33, 22, 986, DateTimeKind.Local).AddTicks(4230), "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 329, DateTimeKind.Local).AddTicks(6199) },
                    { 3, new DateTime(2025, 3, 31, 1, 9, 50, 329, DateTimeKind.Local).AddTicks(6212), 5, new DateTime(2026, 3, 5, 16, 16, 39, 370, DateTimeKind.Local).AddTicks(5448), new DateTime(2025, 3, 31, 1, 9, 50, 329, DateTimeKind.Local).AddTicks(6212), "bfa778f3-5e4c-41e5-8260-18a4beb3edc6", 4, 2, new DateTime(2025, 1, 30, 22, 38, 49, 258, DateTimeKind.Local).AddTicks(2381), "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 329, DateTimeKind.Local).AddTicks(6213) },
                    { 4, new DateTime(2025, 3, 31, 1, 9, 50, 329, DateTimeKind.Local).AddTicks(6222), 9, new DateTime(2025, 6, 16, 4, 57, 7, 502, DateTimeKind.Local).AddTicks(9684), new DateTime(2025, 3, 31, 1, 9, 50, 329, DateTimeKind.Local).AddTicks(6223), "d25dea30-3f4e-4d0d-9551-429acb21a4cb", 4, 1, new DateTime(2024, 6, 15, 22, 9, 7, 108, DateTimeKind.Local).AddTicks(3183), "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 329, DateTimeKind.Local).AddTicks(6223) },
                    { 5, new DateTime(2025, 3, 31, 1, 9, 50, 329, DateTimeKind.Local).AddTicks(6232), 5, new DateTime(2026, 2, 18, 13, 0, 35, 618, DateTimeKind.Local).AddTicks(8202), new DateTime(2025, 3, 31, 1, 9, 50, 329, DateTimeKind.Local).AddTicks(6232), "40c6bfab-7947-4172-abbb-a824b2523c98", 4, 0, new DateTime(2024, 9, 22, 22, 13, 23, 575, DateTimeKind.Local).AddTicks(3638), "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 329, DateTimeKind.Local).AddTicks(6233) },
                    { 6, new DateTime(2025, 3, 31, 1, 9, 50, 329, DateTimeKind.Local).AddTicks(6242), 1, new DateTime(2026, 1, 16, 4, 35, 24, 684, DateTimeKind.Local).AddTicks(8306), new DateTime(2025, 3, 31, 1, 9, 50, 329, DateTimeKind.Local).AddTicks(6242), "41d288a2-a59c-436c-8a29-4691b267f3af", 4, 0, new DateTime(2024, 12, 14, 20, 27, 36, 690, DateTimeKind.Local).AddTicks(2834), "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 329, DateTimeKind.Local).AddTicks(6243) },
                    { 7, new DateTime(2025, 3, 31, 1, 9, 50, 329, DateTimeKind.Local).AddTicks(6252), 1, new DateTime(2025, 5, 31, 8, 0, 25, 411, DateTimeKind.Local).AddTicks(4374), new DateTime(2025, 3, 31, 1, 9, 50, 329, DateTimeKind.Local).AddTicks(6252), "efbd3004-3fba-4374-b81e-db61aecd6169", 4, 1, new DateTime(2025, 3, 8, 7, 8, 31, 385, DateTimeKind.Local).AddTicks(2309), "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 329, DateTimeKind.Local).AddTicks(6252) },
                    { 8, new DateTime(2025, 3, 31, 1, 9, 50, 329, DateTimeKind.Local).AddTicks(6262), 9, new DateTime(2025, 6, 27, 2, 7, 14, 714, DateTimeKind.Local).AddTicks(8095), new DateTime(2025, 3, 31, 1, 9, 50, 329, DateTimeKind.Local).AddTicks(6262), "6b410cbd-0714-4d94-b0c2-e00addad656b", 4, 0, new DateTime(2024, 12, 26, 4, 42, 37, 402, DateTimeKind.Local).AddTicks(9668), "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 329, DateTimeKind.Local).AddTicks(6262) },
                    { 9, new DateTime(2025, 3, 31, 1, 9, 50, 329, DateTimeKind.Local).AddTicks(6276), 5, new DateTime(2026, 1, 22, 10, 36, 50, 684, DateTimeKind.Local).AddTicks(1076), new DateTime(2025, 3, 31, 1, 9, 50, 329, DateTimeKind.Local).AddTicks(6277), "202f7c78-0553-4c0c-ac05-4dac32c2900b", 4, 0, new DateTime(2024, 12, 3, 6, 47, 2, 14, DateTimeKind.Local).AddTicks(9838), "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 329, DateTimeKind.Local).AddTicks(6277) },
                    { 10, new DateTime(2025, 3, 31, 1, 9, 50, 329, DateTimeKind.Local).AddTicks(6287), 10, new DateTime(2025, 12, 11, 12, 56, 11, 299, DateTimeKind.Local).AddTicks(4165), new DateTime(2025, 3, 31, 1, 9, 50, 329, DateTimeKind.Local).AddTicks(6287), "def0842e-d8ac-472e-9485-8cc0aa3b1702", 4, 1, new DateTime(2024, 6, 23, 1, 51, 17, 988, DateTimeKind.Local).AddTicks(6425), "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 329, DateTimeKind.Local).AddTicks(6288) }
                });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "ExpenseStatus", "MasterId", "ReservationId", "SelectedStatus", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 31, 1, 9, 50, 328, DateTimeKind.Local).AddTicks(4731), new DateTime(2025, 3, 31, 1, 9, 50, 328, DateTimeKind.Local).AddTicks(4735), 23.40m, new DateTime(2024, 9, 10, 16, 32, 17, 503, DateTimeKind.Local).AddTicks(4705), "Ea saepe aliquam est commodi doloremque repudiandae laudantium.", "Awesome Cotton Keyboard", 4, "9558bdaa-e80a-4b0d-9342-81b6d3f7805d", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 328, DateTimeKind.Local).AddTicks(4736) },
                    { 2, new DateTime(2025, 3, 31, 1, 9, 50, 328, DateTimeKind.Local).AddTicks(4964), new DateTime(2025, 3, 31, 1, 9, 50, 328, DateTimeKind.Local).AddTicks(4964), 470.48m, new DateTime(2024, 8, 19, 18, 43, 22, 712, DateTimeKind.Local).AddTicks(4947), "Aut qui est voluptates porro omnis.", "Gorgeous Metal Table", 4, "ced2d9b4-6fbc-4434-9212-aad38b47ba98", 10, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 328, DateTimeKind.Local).AddTicks(4964) },
                    { 3, new DateTime(2025, 3, 31, 1, 9, 50, 328, DateTimeKind.Local).AddTicks(5015), new DateTime(2025, 3, 31, 1, 9, 50, 328, DateTimeKind.Local).AddTicks(5015), 323.18m, new DateTime(2024, 5, 9, 5, 55, 38, 908, DateTimeKind.Local).AddTicks(1354), "Nulla maxime dolor et quidem ipsa dolorem et rerum.", "Fantastic Frozen Table", 4, "64ffd45c-3d0b-4da0-a495-9b33cc9d7540", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 328, DateTimeKind.Local).AddTicks(5016) },
                    { 4, new DateTime(2025, 3, 31, 1, 9, 50, 328, DateTimeKind.Local).AddTicks(5067), new DateTime(2025, 3, 31, 1, 9, 50, 328, DateTimeKind.Local).AddTicks(5067), 281.63m, new DateTime(2025, 3, 28, 9, 24, 30, 454, DateTimeKind.Local).AddTicks(6126), "Corporis est unde ipsam.", "Awesome Soft Salad", 4, "8efa2db2-24b9-436e-96e7-5440b06b63b2", 5, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 328, DateTimeKind.Local).AddTicks(5067) },
                    { 5, new DateTime(2025, 3, 31, 1, 9, 50, 328, DateTimeKind.Local).AddTicks(5105), new DateTime(2025, 3, 31, 1, 9, 50, 328, DateTimeKind.Local).AddTicks(5106), 396.08m, new DateTime(2024, 11, 27, 8, 9, 37, 325, DateTimeKind.Local).AddTicks(5493), "Ut omnis repellendus.", "Handmade Rubber Shoes", 4, "241d23bd-5473-4a66-8381-e97d1d1c43cc", 7, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 328, DateTimeKind.Local).AddTicks(5106) },
                    { 6, new DateTime(2025, 3, 31, 1, 9, 50, 328, DateTimeKind.Local).AddTicks(5138), new DateTime(2025, 3, 31, 1, 9, 50, 328, DateTimeKind.Local).AddTicks(5138), 944.64m, new DateTime(2024, 4, 15, 22, 7, 48, 704, DateTimeKind.Local).AddTicks(4728), "Ex perferendis reprehenderit dolorum esse qui aut deserunt pariatur.", "Generic Plastic Table", 4, "1d94bfe7-3ce9-44f2-80f8-fbf0de94697b", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 328, DateTimeKind.Local).AddTicks(5139) },
                    { 7, new DateTime(2025, 3, 31, 1, 9, 50, 328, DateTimeKind.Local).AddTicks(5193), new DateTime(2025, 3, 31, 1, 9, 50, 328, DateTimeKind.Local).AddTicks(5193), 368.12m, new DateTime(2024, 12, 28, 22, 32, 41, 281, DateTimeKind.Local).AddTicks(1025), "Culpa non eos non dolore molestiae facilis atque.", "Practical Frozen Salad", 4, "d271ac9b-924b-479e-8629-ddacc0fc8637", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 328, DateTimeKind.Local).AddTicks(5194) },
                    { 8, new DateTime(2025, 3, 31, 1, 9, 50, 328, DateTimeKind.Local).AddTicks(5236), new DateTime(2025, 3, 31, 1, 9, 50, 328, DateTimeKind.Local).AddTicks(5236), 935.87m, new DateTime(2024, 5, 20, 4, 4, 17, 614, DateTimeKind.Local).AddTicks(3957), "Aut quisquam et.", "Gorgeous Granite Pants", 4, "2fa3dd5c-ec03-4def-acec-ff33b1897241", 9, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 328, DateTimeKind.Local).AddTicks(5237) },
                    { 9, new DateTime(2025, 3, 31, 1, 9, 50, 328, DateTimeKind.Local).AddTicks(5267), new DateTime(2025, 3, 31, 1, 9, 50, 328, DateTimeKind.Local).AddTicks(5267), 759.71m, new DateTime(2024, 8, 10, 17, 12, 6, 37, DateTimeKind.Local).AddTicks(7549), "Quas neque fugiat voluptas enim velit.", "Generic Rubber Towels", 4, "4a3163af-a425-4cb7-afa8-525046833b95", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 328, DateTimeKind.Local).AddTicks(5267) },
                    { 10, new DateTime(2025, 3, 31, 1, 9, 50, 328, DateTimeKind.Local).AddTicks(5314), new DateTime(2025, 3, 31, 1, 9, 50, 328, DateTimeKind.Local).AddTicks(5314), 177.47m, new DateTime(2024, 12, 21, 13, 55, 14, 80, DateTimeKind.Local).AddTicks(2391), "Officiis eius laudantium repellat et magni.", "Generic Cotton Keyboard", 4, "67d84008-926c-4f55-ac23-eb259749d081", 6, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 31, 1, 9, 50, 328, DateTimeKind.Local).AddTicks(5315) }
                });

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
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "Shifts");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

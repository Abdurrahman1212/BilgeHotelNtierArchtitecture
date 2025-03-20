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
                    { 1, "Port Norbertoside", "Germany", new DateTime(2025, 3, 19, 2, 2, 39, 259, DateTimeKind.Local).AddTicks(2172), "85927 Cummings Light, Lake Darianberg, Hungary", "9", "BE49619593070703", "(933) 542-8128 x04861", "Antonietta70@hotmail.com", new DateTime(2025, 3, 19, 2, 2, 39, 259, DateTimeKind.Local).AddTicks(2180), "Whitney", "Gibson", "8a4ba60b-9ac9-4682-a43a-f2ba18903ecf", "70930-9474", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 259, DateTimeKind.Local).AddTicks(2181) },
                    { 2, "Gilesfurt", "Malaysia", new DateTime(2025, 3, 19, 2, 2, 39, 259, DateTimeKind.Local).AddTicks(3100), "841 Lisette Port, Port Junehaven, Egypt", "11", "CZ7285008088341403930088", "957-889-3268 x4386", "Velva.Leffler@yahoo.com", new DateTime(2025, 3, 19, 2, 2, 39, 259, DateTimeKind.Local).AddTicks(3101), "Saul", "Cremin", "68699270-a8f8-450e-8151-3cb213da578c", "48585-5046", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 259, DateTimeKind.Local).AddTicks(3101) },
                    { 3, "Prohaskabury", "Philippines", new DateTime(2025, 3, 19, 2, 2, 39, 259, DateTimeKind.Local).AddTicks(3315), "7868 Jaunita Passage, New Roycechester, Suriname", "1", "GL0200325810064022", "510.597.7787", "Claude13@gmail.com", new DateTime(2025, 3, 19, 2, 2, 39, 259, DateTimeKind.Local).AddTicks(3315), "Schuyler", "Zieme", "83359c65-9911-4aac-95f1-ab6cbb492cb4", "35793-4481", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 259, DateTimeKind.Local).AddTicks(3316) },
                    { 4, "Kristyton", "Angola", new DateTime(2025, 3, 19, 2, 2, 39, 259, DateTimeKind.Local).AddTicks(3502), "668 Tremblay Shoals, Margotstad, Timor-Leste", "8", "TR8802226RKC5T11092M1H957C", "(955) 537-9479 x6823", "Tad.Schamberger52@yahoo.com", new DateTime(2025, 3, 19, 2, 2, 39, 259, DateTimeKind.Local).AddTicks(3502), "Fredrick", "Schulist", "560521c5-ac02-43d6-930e-fd5cbda57011", "20416", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 259, DateTimeKind.Local).AddTicks(3502) },
                    { 5, "New Carmelview", "New Caledonia", new DateTime(2025, 3, 19, 2, 2, 39, 259, DateTimeKind.Local).AddTicks(3709), "71562 Witting Mountain, West Jamalburgh, Azerbaijan", "3", "PS529516098029745300153628347", "(360) 664-7710", "Annamae48@hotmail.com", new DateTime(2025, 3, 19, 2, 2, 39, 259, DateTimeKind.Local).AddTicks(3709), "Raheem", "Dare", "bdfa0c35-834a-448f-a528-6962a1851442", "07098-9985", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 259, DateTimeKind.Local).AddTicks(3709) },
                    { 6, "North Tianaberg", "Saint Kitts and Nevis", new DateTime(2025, 3, 19, 2, 2, 39, 259, DateTimeKind.Local).AddTicks(3890), "660 Haley Island, North Melvinaland, Mayotte", "6", "RS09007087400885130678", "370-837-6867", "Immanuel6@gmail.com", new DateTime(2025, 3, 19, 2, 2, 39, 259, DateTimeKind.Local).AddTicks(3890), "Hillard", "Botsford", "04896e5c-016e-4984-a464-d681a16410fa", "96267", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 259, DateTimeKind.Local).AddTicks(3891) },
                    { 7, "East Justineland", "Macao", new DateTime(2025, 3, 19, 2, 2, 39, 259, DateTimeKind.Local).AddTicks(4055), "7105 Dibbert Cliff, Jaunitaview, Italy", "5", "FI7905813308500634", "777.790.3638", "Adell46@gmail.com", new DateTime(2025, 3, 19, 2, 2, 39, 259, DateTimeKind.Local).AddTicks(4055), "Morgan", "Fadel", "5362c4e4-fd80-469a-9e56-4e3c5aa2057b", "37924", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 259, DateTimeKind.Local).AddTicks(4055) },
                    { 8, "Angelaton", "Oman", new DateTime(2025, 3, 19, 2, 2, 39, 259, DateTimeKind.Local).AddTicks(4263), "06239 King Squares, Lake Sigurd, Moldova", "4", "GL2900134521800774", "474.495.5134 x96464", "Nakia29@hotmail.com", new DateTime(2025, 3, 19, 2, 2, 39, 259, DateTimeKind.Local).AddTicks(4264), "Josie", "Lindgren", "06663a91-ffd5-4ef6-ad1d-8d26fa919ede", "14137-3243", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 259, DateTimeKind.Local).AddTicks(4264) },
                    { 9, "New Mollie", "Saint Vincent and the Grenadines", new DateTime(2025, 3, 19, 2, 2, 39, 259, DateTimeKind.Local).AddTicks(4413), "264 Schroeder Hill, North Odaton, Sweden", "5", "BA560003257004306531", "926-625-0030", "Katelyn_Feest@yahoo.com", new DateTime(2025, 3, 19, 2, 2, 39, 259, DateTimeKind.Local).AddTicks(4413), "Cheyenne", "Hyatt", "8f1de9fe-e8fa-49d1-838a-8d53de56b612", "78113-8378", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 259, DateTimeKind.Local).AddTicks(4413) },
                    { 10, "Daphneetown", "Togo", new DateTime(2025, 3, 19, 2, 2, 39, 259, DateTimeKind.Local).AddTicks(4573), "6031 Antonette Mill, North Yadiratown, Vanuatu", "2", "LT317001504708003077", "1-675-422-0589 x2854", "Garry.Murazik40@gmail.com", new DateTime(2025, 3, 19, 2, 2, 39, 259, DateTimeKind.Local).AddTicks(4573), "Alivia", "Pacocha", "dde75791-97aa-443a-9054-2897374ed44d", "31832", 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 259, DateTimeKind.Local).AddTicks(4573) }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "HourlyWage", "MasterId", "PostalCode", "SelectedStatus", "Status", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Kuhnborough", "Egypt", new DateTime(2026, 1, 23, 4, 46, 20, 198, DateTimeKind.Local).AddTicks(2361), "Jevon_Hagenes82@gmail.com", "128 Waino Summit, North Julietport, Martinique", "Elian", "Hirthe", "1-587-625-7204 x46205", new DateTime(2025, 3, 19, 2, 2, 39, 262, DateTimeKind.Local).AddTicks(9552), 0m, "5dc06f47-fba2-4f69-bc98-9f5b9e1b6110", "48283-8945", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2026, 12, 12, 14, 43, 30, 390, DateTimeKind.Local).AddTicks(895) },
                    { 2, "Ricoport", "Lithuania", new DateTime(2025, 6, 22, 5, 48, 32, 812, DateTimeKind.Local).AddTicks(1022), "Icie18@gmail.com", "799 Dianna Mountain, Cooperstad, French Polynesia", "Dariana", "Stroman", "1-431-322-4510 x5629", new DateTime(2025, 3, 19, 2, 2, 39, 262, DateTimeKind.Local).AddTicks(9919), 0m, "13643138-4bdf-46f6-aa3c-dd51c443e1cd", "07590", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 9, 2, 11, 22, 4, 557, DateTimeKind.Local).AddTicks(9894) },
                    { 3, "East Edythe", "Peru", new DateTime(2025, 6, 5, 17, 13, 19, 971, DateTimeKind.Local).AddTicks(837), "Florence.Cummings@hotmail.com", "130 Franecki Path, Maeganburgh, Micronesia", "Domenica", "Reichert", "1-299-297-8507", new DateTime(2025, 3, 19, 2, 2, 39, 263, DateTimeKind.Local).AddTicks(52), 0m, "8a85749f-553a-4d1a-9fbd-c5cef50e311a", "68607-2629", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 9, 26, 14, 5, 6, 596, DateTimeKind.Local).AddTicks(4544) },
                    { 4, "Luciusside", "Svalbard & Jan Mayen Islands", new DateTime(2025, 6, 16, 0, 16, 1, 136, DateTimeKind.Local).AddTicks(4615), "Jon41@gmail.com", "0687 Pearline Mews, West Rachelle, Egypt", "Isabella", "Streich", "1-346-240-5129 x475", new DateTime(2025, 3, 19, 2, 2, 39, 263, DateTimeKind.Local).AddTicks(188), 0m, "6e7ecb28-b2b2-42f0-ad56-17f78aee3590", "46953-8612", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2026, 5, 12, 18, 5, 11, 62, DateTimeKind.Local).AddTicks(4685) },
                    { 5, "Lehnerhaven", "Mauritania", new DateTime(2026, 2, 28, 12, 9, 17, 83, DateTimeKind.Local).AddTicks(8508), "Michele.Will@gmail.com", "2262 Kaden Islands, North Marian, Martinique", "Reece", "Treutel", "813.368.5057", new DateTime(2025, 3, 19, 2, 2, 39, 263, DateTimeKind.Local).AddTicks(314), 0m, "fca76117-d7be-4ce1-be32-675b831aed00", "66376", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2027, 2, 6, 21, 15, 58, 457, DateTimeKind.Local).AddTicks(7078) },
                    { 6, "Brennonland", "Nigeria", new DateTime(2025, 3, 20, 22, 16, 19, 725, DateTimeKind.Local).AddTicks(5990), "Arely.Gleason@yahoo.com", "3319 Blick Pass, West Hadley, Andorra", "Gillian", "Jacobi", "(861) 513-9030 x31193", new DateTime(2025, 3, 19, 2, 2, 39, 263, DateTimeKind.Local).AddTicks(430), 0m, "ca8080fe-89c8-498f-bd0e-a5e5483072f0", "66138-7733", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2025, 5, 18, 20, 36, 31, 533, DateTimeKind.Local).AddTicks(3833) },
                    { 7, "East Cleveburgh", "Puerto Rico", new DateTime(2025, 6, 8, 23, 40, 27, 982, DateTimeKind.Local).AddTicks(3306), "Theodora_Toy94@gmail.com", "112 Vergie Mews, Murrayton, Hungary", "Flavie", "Crooks", "204.470.3148 x63005", new DateTime(2025, 3, 19, 2, 2, 39, 263, DateTimeKind.Local).AddTicks(548), 0m, "daeb194e-4fff-4a9f-87f3-852d45f0a930", "40493-7434", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2026, 3, 19, 21, 22, 10, 6, DateTimeKind.Local).AddTicks(3696) },
                    { 8, "West Judsonfort", "Central African Republic", new DateTime(2025, 5, 12, 14, 56, 32, 219, DateTimeKind.Local).AddTicks(1169), "Roxane22@gmail.com", "174 Volkman Ports, Robelhaven, Kenya", "Nannie", "Mills", "1-353-800-9300 x45757", new DateTime(2025, 3, 19, 2, 2, 39, 263, DateTimeKind.Local).AddTicks(672), 0m, "67f0b28f-9b69-41c1-a796-29291b0e8285", "24300", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2026, 2, 5, 20, 48, 10, 318, DateTimeKind.Local).AddTicks(2814) },
                    { 9, "North Lonzo", "El Salvador", new DateTime(2026, 3, 19, 0, 50, 39, 167, DateTimeKind.Local).AddTicks(3169), "Eldora9@yahoo.com", "2124 Quigley Locks, Littelland, Chad", "Evangeline", "Fisher", "657-845-9406 x895", new DateTime(2025, 3, 19, 2, 2, 39, 263, DateTimeKind.Local).AddTicks(791), 0m, "b90247f9-f37b-42c5-8b06-9a2c6ce5f9e1", "04946-2858", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2026, 7, 8, 19, 31, 9, 697, DateTimeKind.Local).AddTicks(7650) },
                    { 10, "Hyattshire", "Belize", new DateTime(2025, 12, 4, 13, 51, 39, 692, DateTimeKind.Local).AddTicks(7960), "Jerod_Hamill@gmail.com", "055 Gorczany Neck, East Ahmed, Latvia", "Fermin", "O'Kon", "1-408-655-8394 x50594", new DateTime(2025, 3, 19, 2, 2, 39, 263, DateTimeKind.Local).AddTicks(907), 0m, "068fc767-27d9-461d-a7a6-c0b6c7279d82", "81566", 4, 0, "DESKTOP-BC8DJ2E", new DateTime(2026, 4, 18, 7, 31, 42, 21, DateTimeKind.Local).AddTicks(8164) }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedDate", "DataStasus", "Description", "EntryDate", "Floor", "HasAirConditioning", "HasBalcony", "HasHairDryer", "HasMinibar", "HasTV", "HasWiFi", "ImageUrl", "MasterId", "PricePerNight", "RoomBreakfast", "RoomCapacity", "RoomNumber", "RoomType", "SelectedStatus", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(3575), 0, "Dolores officiis quae et vitae.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(3580), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=393", "865bd5af-4112-40c5-8a53-c98feda6099f", 1569.81m, false, 1, "1", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(3581) },
                    { 2, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(3862), 1, "Veniam ut expedita eius possimus.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(3862), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=926", "d9d42141-d987-4566-9960-1d552cf086c5", 2498.51m, true, 2, "2", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(3862) },
                    { 3, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(3898), 2, "Voluptates sequi tempora quibusdam suscipit.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(3899), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=279", "2664508c-f766-45f1-b2ea-9f864fa9214d", 1542.80m, true, 3, "3", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(3899) },
                    { 4, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(3926), 3, "Sequi porro omnis qui consequatur.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(3927), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=125", "0647f00d-5fe4-4368-8f2f-0a195eca7a83", 1683.39m, true, 4, "4", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(3927) },
                    { 5, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(3963), 4, "Eos et explicabo et itaque.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(3963), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=509", "8f06180f-6478-42ea-aa90-daac62c8ab9a", 1604.67m, true, 5, "5", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(3964) },
                    { 6, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4027), 5, "Labore consequuntur dolores sapiente impedit.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4027), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=834", "dacb93df-2b47-4a40-93e5-7495dbc034fe", 2059.19m, false, 1, "6", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4028) },
                    { 7, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4053), 0, "İllum distinctio architecto veniam distinctio.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4053), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=650", "246774cc-7e40-46ee-a1d0-b5a66b2963c7", 1899.83m, true, 2, "7", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4053) },
                    { 8, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4077), 1, "İncidunt minima eos reprehenderit repudiandae.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4077), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=581", "af1bb310-5626-4725-ab43-b1fe37a96655", 2196.95m, true, 3, "8", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4078) },
                    { 9, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4101), 2, "Enim veniam quae quam pariatur.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4101), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=771", "47f7f44c-ff78-418c-8530-59da2ef45da9", 2179.87m, true, 4, "9", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4102) },
                    { 10, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4134), 3, "Voluptatum accusantium veniam harum harum.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4134), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=253", "0a311eac-fa3a-4de1-b9b8-688ecebe8604", 1893.09m, true, 5, "10", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4135) },
                    { 11, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4160), 4, "Libero doloremque dolores ut eum.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4161), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=382", "050a25ae-6b51-421d-a46b-b3ac9e1e742b", 1739.27m, false, 1, "11", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4161) },
                    { 12, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4182), 5, "Sint non nobis eligendi animi.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4183), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=520", "115fa177-70ed-45a7-9b04-696f868f5f40", 1629.69m, true, 2, "12", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4183) },
                    { 13, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4208), 0, "Quas eos qui modi officia.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4208), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=288", "33311b8d-2ceb-4593-b7e6-aeab67a82ad9", 1972.29m, true, 3, "13", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4209) },
                    { 14, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4233), 1, "Qui saepe consequatur velit libero.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4233), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=1004", "2af501cf-1540-455b-87db-9e0c293b8c71", 1688.04m, true, 4, "14", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4233) },
                    { 15, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4269), 2, "Quia vero at tempore quia.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4269), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=405", "63196b5b-e9ad-4d71-b6d1-1aaac4e0f66e", 2408.05m, true, 5, "15", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4269) },
                    { 16, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4292), 3, "Doloribus et nobis voluptates placeat.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4293), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=615", "a16b7560-327f-437d-a29f-38acb3eebbfd", 2368.77m, false, 1, "16", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4293) },
                    { 17, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4315), 4, "İpsum laboriosam ab aut pariatur.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4315), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=783", "a70f51f1-ead5-4a96-b59e-410628f3f84c", 2475.27m, true, 2, "17", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4316) },
                    { 18, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4341), 5, "Quia tenetur quis ut eum.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4341), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=417", "4327e9db-d805-4a5d-afad-cd7637391c00", 2456.90m, true, 3, "18", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4342) },
                    { 19, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4363), 0, "Accusantium non magnam iste et.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4364), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=383", "b156e784-2b45-42ad-b03a-f37ca3b85ad0", 1816.87m, true, 4, "19", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4364) },
                    { 20, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4393), 1, "Non ad eum eius eligendi.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4393), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=1023", "34f6917f-3d5e-43b7-922b-fcc916138e71", 2119.20m, true, 5, "20", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4393) },
                    { 21, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4415), 2, "İn vero ut dolores explicabo.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4415), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=253", "e2cb8831-b27f-402b-a1f4-018c6fb25c08", 2371.99m, false, 1, "21", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4415) },
                    { 22, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4439), 3, "Aut aut ut quia facere.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4440), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=47", "6c684a40-1be2-46f5-98ab-fd20352e7811", 2495.76m, true, 2, "22", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4440) },
                    { 23, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4461), 4, "Sit eos facere vel et.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4461), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=508", "20390c19-a552-406a-b581-7ae792b75d90", 1805.39m, true, 3, "23", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4461) },
                    { 24, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4482), 5, "Et et velit alias aliquam.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4483), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=1029", "20c00377-c7c3-4a70-872a-c691aca28ffa", 2078.43m, true, 4, "24", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4483) },
                    { 25, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4510), 0, "Voluptatibus harum error dolores veniam.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4511), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=890", "4f80546a-3e62-47d3-a9f2-9f22fd3fbd16", 2383.34m, true, 5, "25", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4511) },
                    { 26, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4534), 1, "Sed omnis modi est voluptatem.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4534), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=211", "ec0b3ce7-23e9-4abc-bbdd-6e9bce1030af", 2429.10m, false, 1, "26", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4534) },
                    { 27, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4556), 2, "Maiores fugiat quia assumenda deserunt.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4557), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=606", "9e6512f9-aa03-4f9f-a23e-c0db00e86da1", 1741.72m, true, 2, "27", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4557) },
                    { 28, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4578), 3, "Sed sit eum aut dolorem.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4578), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=480", "2f632261-07f6-4188-9101-8ba675621484", 2391.01m, true, 3, "28", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4578) },
                    { 29, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4601), 4, "Et consectetur nisi non voluptate.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4601), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=420", "0e3a4a41-7ac1-4138-9c66-73c9014df9b6", 1500.88m, true, 4, "29", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4601) },
                    { 30, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4626), 5, "Sed ipsam non quo qui.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4626), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=667", "5fbf4539-3ab8-4e6e-969f-0e5e2b4aea7a", 2178.32m, true, 5, "30", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4626) },
                    { 31, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4653), 0, "Dicta error aut asperiores quasi.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4654), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=835", "d163c6b8-f487-4260-8cc0-ca01a188ccb9", 1902.15m, false, 1, "31", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4654) },
                    { 32, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4676), 1, "Voluptas debitis modi minima a.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4676), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=675", "9dfe9c28-1a9e-427a-8491-76c37b4b2688", 2116.87m, true, 2, "32", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4677) },
                    { 33, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4698), 2, "Et dolores eos illum in.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4698), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=242", "20bd2bfb-fe0e-48a2-9400-f777b936122c", 2293.18m, true, 3, "33", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4698) },
                    { 34, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4722), 3, "Nihil cupiditate beatae perspiciatis nesciunt.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4722), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=547", "d3ae9558-b871-4a37-aff1-bb6d4310759b", 1796.33m, true, 4, "34", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4722) },
                    { 35, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4783), 4, "Officiis et libero dignissimos fugit.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4783), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=875", "9c9f747a-bab7-4bec-8eff-7614609cf60c", 2460.36m, true, 5, "35", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4784) },
                    { 36, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4805), 5, "Nihil ut voluptatem esse velit.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4806), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=686", "9d167f0c-269e-49b7-8e0f-3de726a26c26", 2330.93m, false, 1, "36", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4806) },
                    { 37, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4827), 0, "Harum qui odit qui rerum.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4827), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=412", "a9994ac7-2913-4415-ae2b-ad5f859570c8", 2321.85m, true, 2, "37", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4827) },
                    { 38, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4850), 1, "Voluptas deserunt maxime architecto necessitatibus.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4851), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=593", "c86b27be-75ea-468a-a9ce-e77945e2f851", 1884.65m, true, 3, "38", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4851) },
                    { 39, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4871), 2, "Nisi ipsa fugiat ducimus quia.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4872), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=604", "d6da12b6-7d30-433e-97f4-32722206cb66", 1847.27m, true, 4, "39", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4872) },
                    { 40, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4897), 3, "Voluptas nostrum consequuntur sed odio.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4898), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=566", "b305b4be-5456-4118-bf3e-a81790503bfe", 1934.14m, true, 5, "40", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4898) },
                    { 41, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4921), 4, "Sunt dolore at necessitatibus sint.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4921), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=648", "98fe9b32-8eb4-4b10-b492-72e8d0c06978", 1745.39m, false, 1, "41", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4922) },
                    { 42, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4944), 5, "Velit repudiandae enim consequatur laboriosam.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4944), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=969", "5aab2273-7a27-4411-9036-e01dee12f766", 2453.91m, true, 2, "42", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4944) },
                    { 43, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4966), 0, "Quam voluptatum et pariatur consequatur.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4966), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=362", "05afdc2f-c1b3-4d30-9243-16f7d9dbb611", 2360.83m, true, 3, "43", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4966) },
                    { 44, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4987), 1, "A quisquam in impedit dolorum.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4987), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=949", "a19d21f2-d03a-46e3-899e-d4c51779e45b", 2498.09m, true, 4, "44", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(4988) },
                    { 45, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(5013), 2, "İure explicabo ea quis molestias.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(5013), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=1081", "84e7b0ba-0e1b-45fd-b2ee-1e4f5e3e194d", 2049.84m, true, 5, "45", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(5014) },
                    { 46, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(5036), 3, "Quas consequatur aut sunt ullam.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(5037), 1, true, false, true, true, true, true, "https://picsum.photos/640/480/?image=103", "eb727fcb-885c-4da7-aa40-74404f119c62", 2334.68m, false, 1, "46", 0, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(5037) },
                    { 47, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(5058), 4, "Fugiat ut reiciendis provident quia.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(5058), 2, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=641", "10dca50c-43cc-4436-b561-a911be42cef9", 1651.24m, true, 2, "47", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(5059) },
                    { 48, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(5080), 5, "İpsum rerum illum dolorem nesciunt.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(5080), 3, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=825", "d43887a4-4318-478e-9e8d-093e5e9da410", 2203.95m, true, 3, "48", 2, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(5080) },
                    { 49, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(5102), 0, "Et blanditiis in eos nostrum.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(5102), 4, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=565", "1a1ecdea-68da-4fcd-99c9-7de07e877643", 2005.53m, true, 4, "49", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(5102) },
                    { 50, new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(5125), 1, "Suscipit eum suscipit eum molestiae.", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(5125), 5, true, true, true, true, true, true, "https://picsum.photos/640/480/?image=311", "a1a3350c-ceaa-405f-b319-f6fc5f7431e0", 2115.74m, true, 5, "50", 4, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 260, DateTimeKind.Local).AddTicks(5126) }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "PackageType", "PaymentVerification", "RoomId", "SelectedStatus", "TotalAmount", "UpdatedComputerName", "UpdatedDate", "status" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 9, 11, 54, 53, 496, DateTimeKind.Local).AddTicks(3592), new DateTime(2025, 6, 8, 5, 38, 13, 525, DateTimeKind.Local).AddTicks(3269), new DateTime(2025, 3, 19, 2, 2, 39, 263, DateTimeKind.Local).AddTicks(9292), 9, new DateTime(2025, 3, 19, 2, 2, 39, 263, DateTimeKind.Local).AddTicks(9293), "9038d7d4-f155-45ab-b60a-28ba1257bcb5", 0, "5101-5143-0698-4003", 50, 4, 2478.81m, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 263, DateTimeKind.Local).AddTicks(9293), 0 },
                    { 2, new DateTime(2026, 3, 18, 17, 29, 34, 464, DateTimeKind.Local).AddTicks(5095), new DateTime(2026, 5, 5, 22, 47, 32, 72, DateTimeKind.Local).AddTicks(580), new DateTime(2025, 3, 19, 2, 2, 39, 263, DateTimeKind.Local).AddTicks(9858), 3, new DateTime(2025, 3, 19, 2, 2, 39, 263, DateTimeKind.Local).AddTicks(9858), "a6c387c2-fb0a-47ff-9816-7924137c1150", 1, "6304979440168685", 45, 4, 2466.72m, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 263, DateTimeKind.Local).AddTicks(9859), 1 },
                    { 3, new DateTime(2025, 5, 5, 4, 29, 7, 93, DateTimeKind.Local).AddTicks(6694), new DateTime(2026, 3, 4, 6, 11, 21, 168, DateTimeKind.Local).AddTicks(8944), new DateTime(2025, 3, 19, 2, 2, 39, 263, DateTimeKind.Local).AddTicks(9994), 4, new DateTime(2025, 3, 19, 2, 2, 39, 263, DateTimeKind.Local).AddTicks(9994), "8de7aa2b-28d8-46c9-857c-ef2e3309534a", 0, "3690-711909-7446", 5, 4, 2176.34m, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 263, DateTimeKind.Local).AddTicks(9994), 2 },
                    { 4, new DateTime(2026, 3, 4, 6, 7, 17, 829, DateTimeKind.Local).AddTicks(95), new DateTime(2026, 8, 18, 6, 33, 28, 983, DateTimeKind.Local).AddTicks(9716), new DateTime(2025, 3, 19, 2, 2, 39, 264, DateTimeKind.Local).AddTicks(115), 3, new DateTime(2025, 3, 19, 2, 2, 39, 264, DateTimeKind.Local).AddTicks(115), "25240a8b-c140-41d9-b356-a9548bd014d9", 1, "6771-8939-5620-1125", 8, 4, 1998.59m, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 264, DateTimeKind.Local).AddTicks(116), 3 },
                    { 5, new DateTime(2025, 8, 5, 15, 33, 10, 338, DateTimeKind.Local).AddTicks(6764), new DateTime(2026, 6, 7, 1, 0, 58, 839, DateTimeKind.Local).AddTicks(2220), new DateTime(2025, 3, 19, 2, 2, 39, 264, DateTimeKind.Local).AddTicks(234), 10, new DateTime(2025, 3, 19, 2, 2, 39, 264, DateTimeKind.Local).AddTicks(234), "7dbddc2d-28f5-49b2-94d1-3c0332d400d9", 0, "3029-208550-2992", 12, 4, 2420.30m, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 264, DateTimeKind.Local).AddTicks(234), 4 },
                    { 6, new DateTime(2025, 6, 9, 10, 5, 20, 854, DateTimeKind.Local).AddTicks(9317), new DateTime(2025, 7, 8, 20, 53, 15, 540, DateTimeKind.Local).AddTicks(418), new DateTime(2025, 3, 19, 2, 2, 39, 264, DateTimeKind.Local).AddTicks(350), 1, new DateTime(2025, 3, 19, 2, 2, 39, 264, DateTimeKind.Local).AddTicks(350), "313f4fe3-c105-4dfd-a083-148ac9da5fdd", 1, "3630-562248-1399", 29, 4, 2476.61m, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 264, DateTimeKind.Local).AddTicks(351), 5 },
                    { 7, new DateTime(2025, 8, 19, 12, 3, 34, 301, DateTimeKind.Local).AddTicks(9531), new DateTime(2026, 5, 15, 5, 14, 8, 870, DateTimeKind.Local).AddTicks(2962), new DateTime(2025, 3, 19, 2, 2, 39, 264, DateTimeKind.Local).AddTicks(464), 8, new DateTime(2025, 3, 19, 2, 2, 39, 264, DateTimeKind.Local).AddTicks(465), "192bf92b-3dfb-44aa-9939-df694057c9e3", 0, "6011-0276-5191-9174", 37, 4, 2003.11m, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 264, DateTimeKind.Local).AddTicks(465), 0 },
                    { 8, new DateTime(2025, 10, 3, 1, 5, 21, 42, DateTimeKind.Local).AddTicks(2780), new DateTime(2026, 2, 18, 0, 15, 58, 539, DateTimeKind.Local).AddTicks(9850), new DateTime(2025, 3, 19, 2, 2, 39, 264, DateTimeKind.Local).AddTicks(582), 1, new DateTime(2025, 3, 19, 2, 2, 39, 264, DateTimeKind.Local).AddTicks(582), "b13cb4e2-fddc-451f-91f6-ca6fb3c00a1c", 1, "4919344944670", 39, 4, 2013.55m, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 264, DateTimeKind.Local).AddTicks(582), 1 },
                    { 9, new DateTime(2025, 5, 27, 2, 38, 59, 867, DateTimeKind.Local).AddTicks(5214), new DateTime(2026, 2, 15, 13, 57, 49, 567, DateTimeKind.Local).AddTicks(7130), new DateTime(2025, 3, 19, 2, 2, 39, 264, DateTimeKind.Local).AddTicks(691), 4, new DateTime(2025, 3, 19, 2, 2, 39, 264, DateTimeKind.Local).AddTicks(691), "6ff62a56-410e-4b93-9ac9-7c025e86fc20", 0, "50389795209882744784", 5, 4, 1622.54m, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 264, DateTimeKind.Local).AddTicks(691), 2 },
                    { 10, new DateTime(2025, 9, 19, 4, 56, 32, 684, DateTimeKind.Local).AddTicks(2281), new DateTime(2025, 10, 30, 11, 41, 7, 3, DateTimeKind.Local).AddTicks(9259), new DateTime(2025, 3, 19, 2, 2, 39, 264, DateTimeKind.Local).AddTicks(846), 6, new DateTime(2025, 3, 19, 2, 2, 39, 264, DateTimeKind.Local).AddTicks(847), "bbb6f706-9782-4cec-a3b6-429214b08321", 1, "3622-985110-2718", 48, 4, 2403.22m, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 264, DateTimeKind.Local).AddTicks(847), 3 }
                });

            migrationBuilder.InsertData(
                table: "Shifts",
                columns: new[] { "Id", "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "SelectedStatus", "ShiftType", "StartTime", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 19, 2, 2, 39, 262, DateTimeKind.Local).AddTicks(809), 5, new DateTime(2025, 9, 6, 7, 21, 38, 842, DateTimeKind.Local).AddTicks(3475), new DateTime(2025, 3, 19, 2, 2, 39, 262, DateTimeKind.Local).AddTicks(813), "e74bcc81-183d-4e7e-85a4-c3ee02195ab6", 4, 0, new DateTime(2024, 12, 29, 13, 24, 51, 245, DateTimeKind.Local).AddTicks(9259), "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 262, DateTimeKind.Local).AddTicks(814) },
                    { 2, new DateTime(2025, 3, 19, 2, 2, 39, 262, DateTimeKind.Local).AddTicks(926), 1, new DateTime(2025, 6, 29, 22, 32, 26, 45, DateTimeKind.Local).AddTicks(5080), new DateTime(2025, 3, 19, 2, 2, 39, 262, DateTimeKind.Local).AddTicks(926), "897fc63d-47a2-4aeb-9d4e-50f72df5cfb7", 4, 2, new DateTime(2024, 7, 23, 10, 40, 19, 704, DateTimeKind.Local).AddTicks(5073), "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 262, DateTimeKind.Local).AddTicks(926) },
                    { 3, new DateTime(2025, 3, 19, 2, 2, 39, 262, DateTimeKind.Local).AddTicks(940), 1, new DateTime(2026, 2, 24, 12, 11, 14, 437, DateTimeKind.Local).AddTicks(7371), new DateTime(2025, 3, 19, 2, 2, 39, 262, DateTimeKind.Local).AddTicks(940), "a4da86e2-14dc-45e8-8370-8dbeac9ea53b", 4, 0, new DateTime(2024, 11, 18, 1, 23, 41, 999, DateTimeKind.Local).AddTicks(7101), "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 262, DateTimeKind.Local).AddTicks(941) },
                    { 4, new DateTime(2025, 3, 19, 2, 2, 39, 262, DateTimeKind.Local).AddTicks(947), 4, new DateTime(2025, 4, 20, 1, 5, 50, 358, DateTimeKind.Local).AddTicks(1005), new DateTime(2025, 3, 19, 2, 2, 39, 262, DateTimeKind.Local).AddTicks(947), "ae6c4af3-8616-4faa-93f2-13b6c94a2c69", 4, 2, new DateTime(2025, 1, 5, 18, 57, 13, 375, DateTimeKind.Local).AddTicks(267), "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 262, DateTimeKind.Local).AddTicks(947) },
                    { 5, new DateTime(2025, 3, 19, 2, 2, 39, 262, DateTimeKind.Local).AddTicks(953), 4, new DateTime(2025, 5, 3, 1, 30, 50, 35, DateTimeKind.Local).AddTicks(1651), new DateTime(2025, 3, 19, 2, 2, 39, 262, DateTimeKind.Local).AddTicks(953), "fc335e42-6c44-4581-9d0e-361ec56cd061", 4, 1, new DateTime(2024, 6, 21, 5, 14, 21, 917, DateTimeKind.Local).AddTicks(2049), "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 262, DateTimeKind.Local).AddTicks(954) },
                    { 6, new DateTime(2025, 3, 19, 2, 2, 39, 262, DateTimeKind.Local).AddTicks(961), 3, new DateTime(2025, 3, 26, 10, 24, 12, 794, DateTimeKind.Local).AddTicks(7249), new DateTime(2025, 3, 19, 2, 2, 39, 262, DateTimeKind.Local).AddTicks(961), "4998c5df-cb10-4029-9cb2-08758f1283a6", 4, 1, new DateTime(2024, 5, 25, 2, 49, 50, 58, DateTimeKind.Local).AddTicks(7985), "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 262, DateTimeKind.Local).AddTicks(961) },
                    { 7, new DateTime(2025, 3, 19, 2, 2, 39, 262, DateTimeKind.Local).AddTicks(967), 7, new DateTime(2025, 8, 6, 7, 45, 57, 168, DateTimeKind.Local).AddTicks(3104), new DateTime(2025, 3, 19, 2, 2, 39, 262, DateTimeKind.Local).AddTicks(967), "bc3c7b25-a4bf-4604-b36a-e991a121a3ad", 4, 2, new DateTime(2024, 5, 22, 11, 15, 2, 660, DateTimeKind.Local).AddTicks(2287), "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 262, DateTimeKind.Local).AddTicks(967) },
                    { 8, new DateTime(2025, 3, 19, 2, 2, 39, 262, DateTimeKind.Local).AddTicks(973), 5, new DateTime(2026, 2, 12, 18, 39, 55, 396, DateTimeKind.Local).AddTicks(8705), new DateTime(2025, 3, 19, 2, 2, 39, 262, DateTimeKind.Local).AddTicks(973), "2881d7b4-8f7c-4ede-b63d-dd3e1306726e", 4, 0, new DateTime(2024, 8, 16, 2, 13, 41, 731, DateTimeKind.Local).AddTicks(5518), "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 262, DateTimeKind.Local).AddTicks(974) },
                    { 9, new DateTime(2025, 3, 19, 2, 2, 39, 262, DateTimeKind.Local).AddTicks(979), 4, new DateTime(2026, 3, 9, 13, 12, 49, 814, DateTimeKind.Local).AddTicks(4008), new DateTime(2025, 3, 19, 2, 2, 39, 262, DateTimeKind.Local).AddTicks(979), "cdd235e4-3e51-43e0-8177-0fbb75090c98", 4, 0, new DateTime(2024, 7, 19, 9, 35, 35, 900, DateTimeKind.Local).AddTicks(7345), "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 262, DateTimeKind.Local).AddTicks(979) },
                    { 10, new DateTime(2025, 3, 19, 2, 2, 39, 262, DateTimeKind.Local).AddTicks(986), 7, new DateTime(2026, 1, 4, 5, 46, 18, 112, DateTimeKind.Local).AddTicks(6693), new DateTime(2025, 3, 19, 2, 2, 39, 262, DateTimeKind.Local).AddTicks(986), "1ba828b0-876d-460f-8d28-7bb6ab3c4967", 4, 1, new DateTime(2024, 10, 6, 6, 15, 7, 688, DateTimeKind.Local).AddTicks(2626), "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 262, DateTimeKind.Local).AddTicks(987) }
                });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "ExpenseStatus", "MasterId", "ReservationId", "SelectedStatus", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 19, 2, 2, 39, 261, DateTimeKind.Local).AddTicks(3007), new DateTime(2025, 3, 19, 2, 2, 39, 261, DateTimeKind.Local).AddTicks(3010), 794.72m, new DateTime(2024, 5, 8, 13, 21, 47, 340, DateTimeKind.Local).AddTicks(5494), "Qui dolorem velit esse explicabo est occaecati magni dolore.", "Intelligent Wooden Shoes", 4, "9ea0536e-09ac-4fcd-a5cc-cab3544fe566", 8, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 261, DateTimeKind.Local).AddTicks(3010) },
                    { 2, new DateTime(2025, 3, 19, 2, 2, 39, 261, DateTimeKind.Local).AddTicks(3172), new DateTime(2025, 3, 19, 2, 2, 39, 261, DateTimeKind.Local).AddTicks(3173), 201.13m, new DateTime(2024, 11, 5, 12, 31, 31, 802, DateTimeKind.Local).AddTicks(6628), "Vero id enim aut quam et distinctio.", "Awesome Cotton Car", 4, "3e333ba6-e56c-4ffb-9169-390c809f517f", 1, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 261, DateTimeKind.Local).AddTicks(3173) },
                    { 3, new DateTime(2025, 3, 19, 2, 2, 39, 261, DateTimeKind.Local).AddTicks(3210), new DateTime(2025, 3, 19, 2, 2, 39, 261, DateTimeKind.Local).AddTicks(3210), 534.92m, new DateTime(2024, 5, 6, 10, 11, 44, 466, DateTimeKind.Local).AddTicks(559), "Error consectetur incidunt architecto adipisci dolore.", "Handcrafted Rubber Pizza", 4, "f899f3c2-c97a-478f-aab6-180c45bcda1a", 3, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 261, DateTimeKind.Local).AddTicks(3211) },
                    { 4, new DateTime(2025, 3, 19, 2, 2, 39, 261, DateTimeKind.Local).AddTicks(3244), new DateTime(2025, 3, 19, 2, 2, 39, 261, DateTimeKind.Local).AddTicks(3244), 803.04m, new DateTime(2024, 5, 7, 23, 56, 35, 215, DateTimeKind.Local).AddTicks(3678), "Dolore itaque autem non et quod.", "Handmade Metal Shirt", 4, "e071b86c-4996-4633-bedf-01af5a0c892f", 6, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 261, DateTimeKind.Local).AddTicks(3244) },
                    { 5, new DateTime(2025, 3, 19, 2, 2, 39, 261, DateTimeKind.Local).AddTicks(3274), new DateTime(2025, 3, 19, 2, 2, 39, 261, DateTimeKind.Local).AddTicks(3275), 205.80m, new DateTime(2024, 8, 5, 6, 51, 22, 873, DateTimeKind.Local).AddTicks(7905), "Minus quasi est illo recusandae.", "Licensed Cotton Keyboard", 4, "c40ebbba-0572-49c0-8362-ad832ee78870", 9, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 261, DateTimeKind.Local).AddTicks(3275) },
                    { 6, new DateTime(2025, 3, 19, 2, 2, 39, 261, DateTimeKind.Local).AddTicks(3306), new DateTime(2025, 3, 19, 2, 2, 39, 261, DateTimeKind.Local).AddTicks(3307), 884.49m, new DateTime(2024, 10, 17, 7, 14, 8, 902, DateTimeKind.Local).AddTicks(691), "Rerum rem ipsam sunt et.", "Handcrafted Rubber Computer", 4, "0e4a10d7-00c8-47a4-8eca-2ebcbff2b207", 5, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 261, DateTimeKind.Local).AddTicks(3307) },
                    { 7, new DateTime(2025, 3, 19, 2, 2, 39, 261, DateTimeKind.Local).AddTicks(3335), new DateTime(2025, 3, 19, 2, 2, 39, 261, DateTimeKind.Local).AddTicks(3336), 673.12m, new DateTime(2024, 7, 8, 15, 30, 57, 943, DateTimeKind.Local).AddTicks(4852), "İllum nesciunt molestiae sequi fugit autem.", "Incredible Cotton Car", 4, "bddf2733-19b6-4dda-b621-b4a9998332ed", 8, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 261, DateTimeKind.Local).AddTicks(3336) },
                    { 8, new DateTime(2025, 3, 19, 2, 2, 39, 261, DateTimeKind.Local).AddTicks(3364), new DateTime(2025, 3, 19, 2, 2, 39, 261, DateTimeKind.Local).AddTicks(3365), 174.50m, new DateTime(2024, 12, 18, 12, 42, 16, 257, DateTimeKind.Local).AddTicks(2859), "Mollitia dolores consectetur consequatur id at et sed.", "Fantastic Frozen Pants", 4, "53e274b5-a6da-4b63-b77e-b87bf3069362", 9, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 261, DateTimeKind.Local).AddTicks(3365) },
                    { 9, new DateTime(2025, 3, 19, 2, 2, 39, 261, DateTimeKind.Local).AddTicks(3395), new DateTime(2025, 3, 19, 2, 2, 39, 261, DateTimeKind.Local).AddTicks(3395), 269.62m, new DateTime(2024, 4, 10, 6, 20, 11, 728, DateTimeKind.Local).AddTicks(7274), "Neque qui et aut deserunt esse laboriosam eos unde.", "Awesome Fresh Chair", 4, "fd81c542-6747-466c-bd17-ea48f435b9d2", 5, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 261, DateTimeKind.Local).AddTicks(3396) },
                    { 10, new DateTime(2025, 3, 19, 2, 2, 39, 261, DateTimeKind.Local).AddTicks(3426), new DateTime(2025, 3, 19, 2, 2, 39, 261, DateTimeKind.Local).AddTicks(3426), 157.75m, new DateTime(2025, 1, 4, 21, 59, 46, 91, DateTimeKind.Local).AddTicks(1370), "Quo velit autem omnis officiis minus facilis perferendis necessitatibus.", "Incredible Granite Pizza", 4, "20504d98-8b62-4a98-84f5-5375e41627e9", 10, 4, "DESKTOP-BC8DJ2E", new DateTime(2025, 3, 19, 2, 2, 39, 261, DateTimeKind.Local).AddTicks(3426) }
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
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "West Hillaryshire", "Heard Island and McDonald Islands", new DateTime(2025, 5, 1, 19, 29, 44, 682, DateTimeKind.Local).AddTicks(5169), "98073 Lazaro Bridge, North Jensen, Western Sahara", "11", "CH2790585G6P225381484", "270.349.7598", "Hiram_Klocko99@gmail.com", new DateTime(2025, 5, 1, 19, 29, 44, 682, DateTimeKind.Local).AddTicks(5183), "Dessie", "Stroman", "6db78c98-01f6-426a-8cd0-dab0fbd33853", "89809-8438", new DateTime(2025, 5, 1, 19, 29, 44, 682, DateTimeKind.Local).AddTicks(5184) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "East Mike", "Australia", new DateTime(2025, 5, 1, 19, 29, 44, 682, DateTimeKind.Local).AddTicks(6159), "27540 Haag Mountains, South Felton, Morocco", "9", "FO8780900067040088", "(710) 496-0973", "Paxton.Purdy12@hotmail.com", new DateTime(2025, 5, 1, 19, 29, 44, 682, DateTimeKind.Local).AddTicks(6159), "Sarai", "Hane", "6a4a5fcd-e4c6-47e8-b1c1-7da544b83d65", "08869-7234", new DateTime(2025, 5, 1, 19, 29, 44, 682, DateTimeKind.Local).AddTicks(6159) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Lake Codyview", "Mozambique", new DateTime(2025, 5, 1, 19, 29, 44, 682, DateTimeKind.Local).AddTicks(6573), "27289 Graham Dale, Altenwerthland, Turkey", "MD790086657R06PL3S146668", "1-515-249-9555 x45327", "Emily_Barton@yahoo.com", new DateTime(2025, 5, 1, 19, 29, 44, 682, DateTimeKind.Local).AddTicks(6575), "Aditya", "Borer", "7fa2dcff-27ba-4ab3-9a2e-41c9a720602d", "27816", new DateTime(2025, 5, 1, 19, 29, 44, 682, DateTimeKind.Local).AddTicks(6575) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Lake Katelyn", "Cote d'Ivoire", new DateTime(2025, 5, 1, 19, 29, 44, 682, DateTimeKind.Local).AddTicks(6928), "12306 Trenton Circles, South Shyannehaven, Cuba", "3", "IT58Z2310075568BE6U4693N483", "(415) 450-7428 x1832", "Lorine.Von13@gmail.com", new DateTime(2025, 5, 1, 19, 29, 44, 682, DateTimeKind.Local).AddTicks(6929), "Tyler", "Stracke", "0c2eb808-099e-4f19-b0cc-bb570bc669ae", "83942-9022", new DateTime(2025, 5, 1, 19, 29, 44, 682, DateTimeKind.Local).AddTicks(6929) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Gutkowskifurt", "Cuba", new DateTime(2025, 5, 1, 19, 29, 44, 682, DateTimeKind.Local).AddTicks(7232), "5932 Lonzo Extension, West Aurelio, Solomon Islands", "3", "AT636063380118437019", "(795) 704-1829", "Rahul58@gmail.com", new DateTime(2025, 5, 1, 19, 29, 44, 682, DateTimeKind.Local).AddTicks(7233), "Nicklaus", "Goodwin", "57890ede-618d-4bb1-8d9a-0408383563d8", "09899", new DateTime(2025, 5, 1, 19, 29, 44, 682, DateTimeKind.Local).AddTicks(7233) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "West Carolanne", "Malaysia", new DateTime(2025, 5, 1, 19, 29, 44, 682, DateTimeKind.Local).AddTicks(7474), "96058 Bergnaum Camp, Travisfort, French Guiana", "11", "BR4201009138403406708700180S6", "343-943-6725 x80174", "Greyson_Pfeffer22@gmail.com", new DateTime(2025, 5, 1, 19, 29, 44, 682, DateTimeKind.Local).AddTicks(7474), "Ciara", "Reichert", "66375cb2-5681-4ede-b537-29359de363fe", "94143-3841", new DateTime(2025, 5, 1, 19, 29, 44, 682, DateTimeKind.Local).AddTicks(7475) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Port Fidelshire", "Saint Vincent and the Grenadines", new DateTime(2025, 5, 1, 19, 29, 44, 682, DateTimeKind.Local).AddTicks(7774), "594 Vickie Road, Kerlukechester, Bouvet Island (Bouvetoya)", "3", "TR4350051B3FC8229687H68432", "358-717-0292 x6752", "Adeline17@hotmail.com", new DateTime(2025, 5, 1, 19, 29, 44, 682, DateTimeKind.Local).AddTicks(7774), "Marie", "Gleason", "00831b0b-9b69-4b9c-b909-79d656118f1e", "84922", new DateTime(2025, 5, 1, 19, 29, 44, 682, DateTimeKind.Local).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Kareemchester", "Virgin Islands, U.S.", new DateTime(2025, 5, 1, 19, 29, 44, 682, DateTimeKind.Local).AddTicks(8036), "93813 Marquardt Crest, North Arnofort, Saint Martin", "4", "MR0211086280810082209040547", "649-791-4931 x51673", "Mia.Gusikowski78@yahoo.com", new DateTime(2025, 5, 1, 19, 29, 44, 682, DateTimeKind.Local).AddTicks(8036), "Marge", "Brekke", "f5059ac1-28de-4668-80a3-7e88d6f4cb4b", "42717", new DateTime(2025, 5, 1, 19, 29, 44, 682, DateTimeKind.Local).AddTicks(8036) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "South Keshawnland", "Monaco", new DateTime(2025, 5, 1, 19, 29, 44, 682, DateTimeKind.Local).AddTicks(8277), "4248 Hirthe Rest, Kristofferview, Aruba", "6", "RO14EMPTJ63046BD117736ZI", "446-913-4951", "Maryjane16@yahoo.com", new DateTime(2025, 5, 1, 19, 29, 44, 682, DateTimeKind.Local).AddTicks(8278), "Albina", "Maggio", "007afbec-f70f-4270-a704-92cea7b95ccd", "99833", new DateTime(2025, 5, 1, 19, 29, 44, 682, DateTimeKind.Local).AddTicks(8278) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Emiliostad", "Chile", new DateTime(2025, 5, 1, 19, 29, 44, 682, DateTimeKind.Local).AddTicks(8556), "93373 Heidenreich Mills, Lake Carolyne, Norfolk Island", "5", "NL15ZTFT0017885801", "720.380.4269 x1631", "Lenora.Wolff57@hotmail.com", new DateTime(2025, 5, 1, 19, 29, 44, 682, DateTimeKind.Local).AddTicks(8556), "Alexandre", "Hickle", "2b5b15b8-f516-4a46-b66b-fffff36869ed", "08990-6383", new DateTime(2025, 5, 1, 19, 29, 44, 682, DateTimeKind.Local).AddTicks(8556) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "North Marieberg", "Pitcairn Islands", new DateTime(2025, 11, 19, 13, 27, 32, 969, DateTimeKind.Local).AddTicks(1442), "Morgan81@hotmail.com", "026 Chloe Corner, Fannymouth, Burkina Faso", "Ford", "Jast", "1-252-800-4170 x54632", new DateTime(2025, 5, 1, 19, 29, 44, 688, DateTimeKind.Local).AddTicks(9979), "ab431487-2290-4a28-9b01-a4e5648bd241", "30758-7577", new DateTime(2026, 4, 1, 17, 27, 20, 145, DateTimeKind.Local).AddTicks(3110) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "South Claudia", "Aruba", new DateTime(2026, 4, 7, 19, 33, 53, 950, DateTimeKind.Local).AddTicks(2871), "Hadley.Zboncak@gmail.com", "04450 Lind Mall, East Kailyn, Ethiopia", "Valentin", "Pacocha", "532-721-7806 x34391", new DateTime(2025, 5, 1, 19, 29, 44, 689, DateTimeKind.Local).AddTicks(537), "32ef9a87-9bbf-4757-9ba0-cfadbd1190f6", "20268", new DateTime(2026, 12, 5, 23, 12, 50, 200, DateTimeKind.Local).AddTicks(4887) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Tatumton", "Guam", new DateTime(2025, 5, 7, 16, 27, 28, 355, DateTimeKind.Local).AddTicks(3336), "Armani.Harris@gmail.com", "176 Tremblay Green, Halvorsonhaven, Bolivia", "Alfonso", "Steuber", "1-478-728-2496 x55777", new DateTime(2025, 5, 1, 19, 29, 44, 689, DateTimeKind.Local).AddTicks(758), "6b450236-d4fd-4710-9124-e52e4a249442", "66995", new DateTime(2025, 7, 8, 23, 56, 41, 775, DateTimeKind.Local).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "West Sydnieview", "Ireland", new DateTime(2026, 4, 7, 17, 51, 53, 883, DateTimeKind.Local).AddTicks(8299), "Cecilia.Jenkins85@hotmail.com", "827 Darrell Roads, Franeckichester, Marshall Islands", "Diana", "Gibson", "(704) 895-7761 x9302", new DateTime(2025, 5, 1, 19, 29, 44, 689, DateTimeKind.Local).AddTicks(955), "afb35c68-755e-4630-9b51-0bc4d9f3b76d", "26977-6193", new DateTime(2026, 11, 2, 10, 30, 1, 387, DateTimeKind.Local).AddTicks(6942) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "West Sophieside", "Kyrgyz Republic", new DateTime(2025, 7, 20, 18, 9, 47, 879, DateTimeKind.Local).AddTicks(7198), "Norene.Padberg@hotmail.com", "484 Schultz Rest, Lake Jordyfurt, Netherlands Antilles", "Marcelina", "Robel", "(756) 869-4754", new DateTime(2025, 5, 1, 19, 29, 44, 689, DateTimeKind.Local).AddTicks(1292), "fce203a4-1033-4812-9268-f89c6191f9b0", "31972-9728", new DateTime(2025, 10, 22, 23, 7, 21, 858, DateTimeKind.Local).AddTicks(8043) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "South Mollyhaven", "United Arab Emirates", new DateTime(2025, 9, 6, 19, 38, 27, 203, DateTimeKind.Local).AddTicks(3956), "Carol_Barrows@yahoo.com", "83213 Bergnaum Court, West Newton, French Guiana", "Ryley", "Gutkowski", "429.692.5890", new DateTime(2025, 5, 1, 19, 29, 44, 689, DateTimeKind.Local).AddTicks(1506), "0e80cbb8-b05d-48b5-ba10-008a0033062e", "95723-7440", new DateTime(2025, 10, 10, 18, 4, 31, 875, DateTimeKind.Local).AddTicks(4027) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Rodriguezberg", "Georgia", new DateTime(2025, 9, 23, 2, 49, 50, 162, DateTimeKind.Local).AddTicks(5135), "Orrin_Ortiz89@gmail.com", "05744 Kaylie Skyway, Schulistview, United States Minor Outlying Islands", "Brian", "Blanda", "954-670-8166", new DateTime(2025, 5, 1, 19, 29, 44, 689, DateTimeKind.Local).AddTicks(1687), "56fd9b4d-a208-4980-8b60-cbd57d3f1561", "63693-6791", new DateTime(2026, 4, 21, 17, 48, 17, 869, DateTimeKind.Local).AddTicks(4590) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "South Camilla", "Seychelles", new DateTime(2026, 1, 9, 7, 48, 40, 513, DateTimeKind.Local).AddTicks(5470), "Adrain.OKeefe53@yahoo.com", "2242 Cartwright Shoal, Port Eddie, Bouvet Island (Bouvetoya)", "Winnifred", "Murray", "406-494-7617 x608", new DateTime(2025, 5, 1, 19, 29, 44, 689, DateTimeKind.Local).AddTicks(1852), "b013a346-748e-4505-a8ca-d16fa251ed6c", "68013-7932", new DateTime(2026, 7, 28, 12, 44, 37, 664, DateTimeKind.Local).AddTicks(905) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Stoltenbergstad", "Falkland Islands (Malvinas)", new DateTime(2025, 6, 20, 0, 19, 23, 512, DateTimeKind.Local).AddTicks(4423), "Burnice.Erdman@yahoo.com", "97823 Kaya Trace, Smithborough, Liechtenstein", "Demetrius", "Schowalter", "552.431.3568 x61562", new DateTime(2025, 5, 1, 19, 29, 44, 699, DateTimeKind.Local).AddTicks(1780), "001e3231-6759-4815-816d-aa81fa224a1a", "54324", new DateTime(2025, 7, 31, 22, 3, 51, 771, DateTimeKind.Local).AddTicks(6728) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Satterfieldfurt", "Suriname", new DateTime(2025, 9, 29, 2, 2, 55, 980, DateTimeKind.Local).AddTicks(6257), "Dion85@hotmail.com", "1401 Hadley Run, North Eliasmouth, Taiwan", "Queen", "Denesik", "251-345-3691", new DateTime(2025, 5, 1, 19, 29, 44, 699, DateTimeKind.Local).AddTicks(3563), "a12af19a-cdb3-4353-bb00-331dcab18466", "68471-2711", new DateTime(2026, 7, 13, 12, 27, 43, 576, DateTimeKind.Local).AddTicks(5296) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 686, DateTimeKind.Local).AddTicks(1750), new DateTime(2025, 5, 1, 19, 29, 44, 686, DateTimeKind.Local).AddTicks(1755), 571.11m, new DateTime(2024, 6, 12, 5, 24, 41, 549, DateTimeKind.Local).AddTicks(6352), "Nulla maxime repellendus eum.", "Handcrafted Steel Keyboard", "5e2cfedf-4856-41fa-b19d-425508f2a85d", 2, new DateTime(2025, 5, 1, 19, 29, 44, 686, DateTimeKind.Local).AddTicks(1756) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 686, DateTimeKind.Local).AddTicks(1962), new DateTime(2025, 5, 1, 19, 29, 44, 686, DateTimeKind.Local).AddTicks(1962), 670.96m, new DateTime(2025, 4, 21, 12, 43, 30, 878, DateTimeKind.Local).AddTicks(9361), "Est deleniti quasi qui sit quos nam.", "Fantastic Cotton Fish", "d481f7e8-c166-4c04-bc84-346f5eed7e4d", 3, new DateTime(2025, 5, 1, 19, 29, 44, 686, DateTimeKind.Local).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 686, DateTimeKind.Local).AddTicks(2016), new DateTime(2025, 5, 1, 19, 29, 44, 686, DateTimeKind.Local).AddTicks(2017), 999.67m, new DateTime(2024, 11, 8, 22, 2, 48, 52, DateTimeKind.Local).AddTicks(2278), "Beatae deserunt voluptas est aut ab aut.", "Gorgeous Concrete Hat", "933529b7-6c2b-4697-a258-f627fc40d11a", new DateTime(2025, 5, 1, 19, 29, 44, 686, DateTimeKind.Local).AddTicks(2017) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 686, DateTimeKind.Local).AddTicks(2055), new DateTime(2025, 5, 1, 19, 29, 44, 686, DateTimeKind.Local).AddTicks(2056), 211.90m, new DateTime(2024, 10, 14, 8, 0, 53, 465, DateTimeKind.Local).AddTicks(6039), "Fuga autem dicta consequatur et doloribus.", "Gorgeous Steel Shirt", "9a70e09e-ea18-4229-9033-971bf4b96c5b", 10, new DateTime(2025, 5, 1, 19, 29, 44, 686, DateTimeKind.Local).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 686, DateTimeKind.Local).AddTicks(2134), new DateTime(2025, 5, 1, 19, 29, 44, 686, DateTimeKind.Local).AddTicks(2134), 87.81m, new DateTime(2024, 7, 17, 12, 13, 38, 226, DateTimeKind.Local).AddTicks(3161), "Pariatur ut id quaerat sint et quia.", "Handcrafted Concrete Pants", "16fc45a3-b78a-44a9-8e17-3c1259e78f6c", 6, new DateTime(2025, 5, 1, 19, 29, 44, 686, DateTimeKind.Local).AddTicks(2135) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 686, DateTimeKind.Local).AddTicks(2173), new DateTime(2025, 5, 1, 19, 29, 44, 686, DateTimeKind.Local).AddTicks(2173), 28.92m, new DateTime(2024, 6, 16, 20, 35, 24, 725, DateTimeKind.Local).AddTicks(7455), "Consequatur aut fugiat.", "Awesome Plastic Chair", "30629dee-211e-46fa-a1ff-dc76446eca3d", new DateTime(2025, 5, 1, 19, 29, 44, 686, DateTimeKind.Local).AddTicks(2173) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 686, DateTimeKind.Local).AddTicks(2204), new DateTime(2025, 5, 1, 19, 29, 44, 686, DateTimeKind.Local).AddTicks(2204), 385.74m, new DateTime(2024, 5, 22, 1, 59, 6, 892, DateTimeKind.Local).AddTicks(1179), "Consequatur alias quia dolorum in excepturi eaque dolore.", "Generic Metal Ball", "a7b769b6-5040-42f1-bc5a-cc407cb58473", 3, new DateTime(2025, 5, 1, 19, 29, 44, 686, DateTimeKind.Local).AddTicks(2205) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 686, DateTimeKind.Local).AddTicks(2242), new DateTime(2025, 5, 1, 19, 29, 44, 686, DateTimeKind.Local).AddTicks(2242), 50.69m, new DateTime(2025, 4, 25, 17, 3, 41, 118, DateTimeKind.Local).AddTicks(9987), "Fugiat repellendus harum soluta.", "Sleek Concrete Car", "16ff262b-b062-41c6-9098-bada51b0953c", 2, new DateTime(2025, 5, 1, 19, 29, 44, 686, DateTimeKind.Local).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 686, DateTimeKind.Local).AddTicks(2269), new DateTime(2025, 5, 1, 19, 29, 44, 686, DateTimeKind.Local).AddTicks(2269), 394.62m, new DateTime(2024, 8, 4, 4, 11, 36, 741, DateTimeKind.Local).AddTicks(2046), "Totam asperiores et magnam dolore ut ipsam deleniti similique sint.", "Ergonomic Rubber Gloves", "ef3efc88-2931-4618-a43a-6edfbc5bb596", 9, new DateTime(2025, 5, 1, 19, 29, 44, 686, DateTimeKind.Local).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 686, DateTimeKind.Local).AddTicks(2358), new DateTime(2025, 5, 1, 19, 29, 44, 686, DateTimeKind.Local).AddTicks(2358), 255.24m, new DateTime(2024, 11, 23, 19, 31, 40, 719, DateTimeKind.Local).AddTicks(4981), "Et aliquam facilis consectetur adipisci quasi.", "Practical Metal Chair", "0aca76d2-eda9-466b-b4aa-cd99eb8318f4", 9, new DateTime(2025, 5, 1, 19, 29, 44, 686, DateTimeKind.Local).AddTicks(2358) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 18, 20, 23, 160, DateTimeKind.Local).AddTicks(9122), new DateTime(2026, 3, 5, 12, 35, 26, 47, DateTimeKind.Local).AddTicks(8491), new DateTime(2025, 5, 1, 19, 29, 44, 701, DateTimeKind.Local).AddTicks(3869), 5, new DateTime(2025, 5, 1, 19, 29, 44, 701, DateTimeKind.Local).AddTicks(3869), "093131bc-6efc-42e3-8106-7b4f68d49823", 24, 2232.23m, new DateTime(2025, 5, 1, 19, 29, 44, 701, DateTimeKind.Local).AddTicks(3870) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 5, 10, 19, 13, 834, DateTimeKind.Local).AddTicks(5873), new DateTime(2026, 4, 3, 4, 37, 45, 439, DateTimeKind.Local).AddTicks(8343), new DateTime(2025, 5, 1, 19, 29, 44, 701, DateTimeKind.Local).AddTicks(4100), new DateTime(2025, 5, 1, 19, 29, 44, 701, DateTimeKind.Local).AddTicks(4100), "f3dc7762-a15a-4afb-ad07-85df0f8dc6d0", 38, 1509.98m, new DateTime(2025, 5, 1, 19, 29, 44, 701, DateTimeKind.Local).AddTicks(4100) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 21, 18, 52, 46, 622, DateTimeKind.Local).AddTicks(2759), new DateTime(2025, 8, 7, 19, 57, 20, 991, DateTimeKind.Local).AddTicks(7276), new DateTime(2025, 5, 1, 19, 29, 44, 701, DateTimeKind.Local).AddTicks(4144), 1, new DateTime(2025, 5, 1, 19, 29, 44, 701, DateTimeKind.Local).AddTicks(4144), "45224d7d-4382-4be9-8e87-e0d3a762f988", 24, 2401.15m, new DateTime(2025, 5, 1, 19, 29, 44, 701, DateTimeKind.Local).AddTicks(4144) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 9, 28, 13, 10, 42, 151, DateTimeKind.Local).AddTicks(5988), new DateTime(2026, 2, 19, 23, 39, 54, 414, DateTimeKind.Local).AddTicks(1617), new DateTime(2025, 5, 1, 19, 29, 44, 701, DateTimeKind.Local).AddTicks(4166), 8, new DateTime(2025, 5, 1, 19, 29, 44, 701, DateTimeKind.Local).AddTicks(4166), "5dfb2057-c433-4b94-9d86-4b6c763dc600", 16, 1539.38m, new DateTime(2025, 5, 1, 19, 29, 44, 701, DateTimeKind.Local).AddTicks(4166) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 19, 5, 57, 11, 105, DateTimeKind.Local).AddTicks(3299), new DateTime(2026, 5, 16, 7, 9, 58, 719, DateTimeKind.Local).AddTicks(4183), new DateTime(2025, 5, 1, 19, 29, 44, 701, DateTimeKind.Local).AddTicks(4180), 5, new DateTime(2025, 5, 1, 19, 29, 44, 701, DateTimeKind.Local).AddTicks(4181), "bbb78442-14b4-4620-873c-d55d37ba6493", 1, 1731.13m, new DateTime(2025, 5, 1, 19, 29, 44, 701, DateTimeKind.Local).AddTicks(4181) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 7, 2, 19, 9, 0, 768, DateTimeKind.Local).AddTicks(2798), new DateTime(2026, 1, 6, 2, 20, 46, 557, DateTimeKind.Local).AddTicks(8443), new DateTime(2025, 5, 1, 19, 29, 44, 701, DateTimeKind.Local).AddTicks(4194), 6, new DateTime(2025, 5, 1, 19, 29, 44, 701, DateTimeKind.Local).AddTicks(4195), "9ca063d3-9452-4c94-bc68-ce48e2898296", 16, 2209.59m, new DateTime(2025, 5, 1, 19, 29, 44, 701, DateTimeKind.Local).AddTicks(4195) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 10, 14, 44, 45, 919, DateTimeKind.Local).AddTicks(2466), new DateTime(2026, 4, 28, 22, 48, 1, 458, DateTimeKind.Local).AddTicks(2710), new DateTime(2025, 5, 1, 19, 29, 44, 701, DateTimeKind.Local).AddTicks(4209), 3, new DateTime(2025, 5, 1, 19, 29, 44, 701, DateTimeKind.Local).AddTicks(4209), "d47d8de4-8d06-4023-b70d-aadfef442a7f", 21, 2020.47m, new DateTime(2025, 5, 1, 19, 29, 44, 701, DateTimeKind.Local).AddTicks(4209) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 14, 4, 55, 29, 660, DateTimeKind.Local).AddTicks(1180), new DateTime(2025, 9, 15, 21, 38, 35, 786, DateTimeKind.Local).AddTicks(8203), new DateTime(2025, 5, 1, 19, 29, 44, 701, DateTimeKind.Local).AddTicks(4224), 10, new DateTime(2025, 5, 1, 19, 29, 44, 701, DateTimeKind.Local).AddTicks(4225), "56788161-e1e7-46bb-8d03-098ab5c01102", 48, 1860.22m, new DateTime(2025, 5, 1, 19, 29, 44, 701, DateTimeKind.Local).AddTicks(4225) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 9, 5, 44, 36, 330, DateTimeKind.Local).AddTicks(6218), new DateTime(2026, 7, 12, 5, 47, 24, 762, DateTimeKind.Local).AddTicks(6659), new DateTime(2025, 5, 1, 19, 29, 44, 701, DateTimeKind.Local).AddTicks(4238), 9, new DateTime(2025, 5, 1, 19, 29, 44, 701, DateTimeKind.Local).AddTicks(4238), "3d892a04-7984-4f0a-813c-b803bb1e6591", 4, 1714.54m, new DateTime(2025, 5, 1, 19, 29, 44, 701, DateTimeKind.Local).AddTicks(4238) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 12, 11, 54, 2, 91, DateTimeKind.Local).AddTicks(4089), new DateTime(2025, 9, 14, 2, 42, 13, 649, DateTimeKind.Local).AddTicks(3043), new DateTime(2025, 5, 1, 19, 29, 44, 701, DateTimeKind.Local).AddTicks(4252), 3, new DateTime(2025, 5, 1, 19, 29, 44, 701, DateTimeKind.Local).AddTicks(4252), "2c6137b0-0935-43d8-8d84-efee5702d0b4", 24, 1906.80m, new DateTime(2025, 5, 1, 19, 29, 44, 701, DateTimeKind.Local).AddTicks(4252) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(4646), "Nihil deserunt natus error repellat.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(4653), "https://picsum.photos/640/480/?image=66", "15044650-892b-4894-9ba8-2a8a4587e180", 2126.12m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(4654) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(4988), "Porro omnis qui excepturi animi.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(4988), "https://picsum.photos/640/480/?image=502", "df21da59-8eca-449e-ae57-f3fa736a8dcb", 2400.99m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(4989) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5030), "Eveniet quia ducimus quas quod.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5030), "https://picsum.photos/640/480/?image=452", "b7ee6bad-3d40-410a-832d-1861557efefa", 1873.38m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5091), "Minima ut repudiandae facilis rem.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5091), "https://picsum.photos/640/480/?image=416", "d3f7befa-a432-4f35-97b9-a45b57109cb6", 1610.24m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5092) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5128), "Quo facilis alias suscipit commodi.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5129), "https://picsum.photos/640/480/?image=1052", "e1c507aa-2001-4705-86a7-adb630d635a8", 2221.70m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5129) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5159), "İste architecto repellat at numquam.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5159), "https://picsum.photos/640/480/?image=1081", "538f1bba-e92d-4470-a51f-b4ef9e2dfeb4", 2481.95m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5159) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5190), "Esse voluptates et commodi veritatis.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5190), "https://picsum.photos/640/480/?image=189", "a3fc261c-f45e-474b-befe-a44dd81e0435", 2242.67m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5218), "Libero eos quia ducimus qui.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5218), "https://picsum.photos/640/480/?image=638", "6fc0d2e2-e828-4358-89b7-26a6553f52fd", 2435.13m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5219) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5278), "Est consequatur iste quam debitis.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5279), "https://picsum.photos/640/480/?image=811", "42427a18-0ea2-433d-8886-d8f0c6dd7c06", 2235.93m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5279) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5308), "Error qui ipsa aut consequuntur.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5309), "https://picsum.photos/640/480/?image=115", "2b30d797-c718-4720-b6f9-69d9b537fbae", 2432.39m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5309) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5337), "Aperiam et vero eaque nemo.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5337), "https://picsum.photos/640/480/?image=184", "69c09fa8-c7f8-4c41-8836-9e0501afa4f5", 2314.56m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5365), "Sunt ducimus quod impedit ut.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5365), "https://picsum.photos/640/480/?image=724", "809b3625-417b-48a6-ae41-3904fe958cb1", 1622.02m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5366) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5396), "Quisquam consequuntur quae labore voluptas.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5397), "https://picsum.photos/640/480/?image=518", "86939495-e049-438d-95c2-c23d390838b7", 1735.91m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5397) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5452), "Nemo in odio reiciendis quibusdam.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5452), "https://picsum.photos/640/480/?image=773", "21212d30-75be-4f67-be99-a42c5d47bfe8", 2365.91m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5453) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5481), "İpsa assumenda soluta sunt facilis.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5482), "https://picsum.photos/640/480/?image=764", "ea2696ff-3f23-495d-9a9e-6737075729bf", 1923.86m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5482) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5506), "Reiciendis placeat dignissimos et excepturi.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5507), "https://picsum.photos/640/480/?image=430", "facf7290-d9b3-45a9-9b55-218f3fa32ff3", 2030.11m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5507) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5535), "Non fugit nesciunt atque eligendi.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5535), "https://picsum.photos/640/480/?image=985", "4357b0df-292c-4756-bf91-30b7403f977a", 1680.57m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5564), "Maiores expedita sunt nostrum nihil.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5564), "https://picsum.photos/640/480/?image=380", "fa97abd5-2831-4277-b56e-6df92a65762a", 2040.35m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5564) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5611), "Esse repellat alias possimus et.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5611), "https://picsum.photos/640/480/?image=1043", "6a8120a1-9cb6-423b-acdc-98e6416a9060", 1764.52m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5612) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5637), "Dicta recusandae sint illum recusandae.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5638), "https://picsum.photos/640/480/?image=1039", "a75b0d3b-a744-4df1-a630-aac1c5a82b7a", 2380.87m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5638) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5667), "Aut deserunt perferendis sit deleniti.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5667), "https://picsum.photos/640/480/?image=702", "d21c3b02-b904-433f-9d54-5acff90a1a8d", 2302.81m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5667) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5695), "Qui dolorem provident nulla molestias.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5695), "https://picsum.photos/640/480/?image=872", "55071a2e-18eb-42e0-899f-8fe4927b8aaa", 2295.19m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5724), "Natus voluptatibus odit quidem id.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5725), "https://picsum.photos/640/480/?image=1035", "518730cb-f2b9-4d0f-bf43-7a5bf6a19de8", 2154.25m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5798), "Et minus culpa facere iste.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5798), "https://picsum.photos/640/480/?image=930", "6506a8f3-2067-42bf-a82e-27f499888209", 2313.40m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5798) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5830), "Aliquid ipsa id nobis fugit.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5831), "https://picsum.photos/640/480/?image=767", "fda8b502-39b1-4453-a847-239c765e5cbb", 2282.61m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5831) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5855), "Totam molestias dolor cum nam.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5855), "https://picsum.photos/640/480/?image=163", "b8c56811-5825-4d97-a094-ff51be11a054", 1583.50m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5855) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5882), "Sequi ut voluptate quaerat atque.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5883), "https://picsum.photos/640/480/?image=132", "1a6f0308-e04a-49d7-adb0-54c530897ced", 1527.35m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5914), "Debitis nemo accusamus ut molestiae.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5915), "https://picsum.photos/640/480/?image=468", "e67161e7-9094-4ae7-a1f7-cdd9edcf0994", 2240.90m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5977), "Distinctio amet id dolor doloribus.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5978), "https://picsum.photos/640/480/?image=841", "99061a15-7ffe-4727-bb52-95c7770efef9", 2323.77m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(5978) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6005), "Sit doloribus eos dolor quod.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6006), "https://picsum.photos/640/480/?image=954", "b4e03d44-bb15-4fcc-93e3-e1b65ec91dfb", 2224.14m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6006) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6031), "Molestiae corrupti culpa ipsam voluptatem.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6032), "https://picsum.photos/640/480/?image=366", "686ac184-8c21-419d-ada2-cd454eca63e5", 1887.99m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6032) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6059), "Laboriosam nobis impedit doloremque neque.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6059), "https://picsum.photos/640/480/?image=62", "d7b934ae-84f7-4640-87c6-1f480860a0b4", 1811.69m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6060) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6088), "Ut porro libero dolorum id.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6088), "https://picsum.photos/640/480/?image=168", "8c0688c3-6a21-491c-b860-fe2a13c6fc8e", 2420.69m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6088) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6141), "Repellendus porro perspiciatis aliquid eligendi.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6142), "https://picsum.photos/640/480/?image=1065", "bfcc2108-10b7-4bc1-aa5f-08c994b61d9a", 2155.51m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6333), "Excepturi sunt est cumque omnis.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6335), "https://picsum.photos/640/480/?image=900", "e1bc7230-0536-4841-9f72-3ba7c9d33fd8", 2082.70m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6335) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6387), "Quia commodi eligendi in eius.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6388), "https://picsum.photos/640/480/?image=1051", "d607b156-da69-4d10-9813-69a413c625ef", 1997.85m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6388) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6413), "Consequatur qui vel qui sit.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6414), "https://picsum.photos/640/480/?image=855", "1402a6c1-790f-417a-bd44-379abd4c1cbe", 1973.03m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6414) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6439), "Eum sapiente quia nostrum exercitationem.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6440), "https://picsum.photos/640/480/?image=245", "f114172d-9e3f-4741-ba6a-3bfe8b6a2735", 2336.61m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6750), "Et quod officiis sit est.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6751), "https://picsum.photos/640/480/?image=735", "f0d56858-9121-44e4-8b05-ebb732a8b1c4", 1874.08m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6751) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6785), "Unde nulla nisi nobis officia.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6786), "https://picsum.photos/640/480/?image=290", "986b39db-959e-4242-aa8f-608c3ce7ecad", 2275.84m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6786) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6814), "Qui officia in et qui.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6814), "https://picsum.photos/640/480/?image=775", "6e04ab98-47f3-4221-b267-8640885fa551", 2070.75m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6815) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6839), "Quia culpa dolorem soluta quia.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6840), "https://picsum.photos/640/480/?image=492", "9b25b6e0-4954-4153-8df2-1677e70a797b", 2178.64m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6861), "Ut voluptas et molestiae consequatur.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6862), "https://picsum.photos/640/480/?image=932", "abea5d0c-1e1d-4414-8143-0b9630325947", 1805.70m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6862) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6913), "Et est repellat cumque minus.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6913), "https://picsum.photos/640/480/?image=735", "869c3592-01db-4e44-9dda-a961bc9a9195", 1837.46m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6913) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6940), "Beatae est soluta molestiae ut.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6941), "https://picsum.photos/640/480/?image=218", "bf5c72aa-e87a-4784-80a1-90166aece931", 2078.21m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6941) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6965), "Est aut alias accusantium eveniet.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6966), "https://picsum.photos/640/480/?image=729", "ed343eeb-b995-4d81-bcc3-2f8ccef2ec88", 1578.04m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6966) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6991), "Culpa illum perferendis perferendis numquam.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6991), "https://picsum.photos/640/480/?image=677", "8dc8b01b-9377-4298-bc18-8959b197d3b8", 1782.71m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(6992) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(7016), "Quia illum ipsam in consequatur.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(7016), "https://picsum.photos/640/480/?image=590", "3e5e23ab-bda1-424e-997c-a60293d0850a", 2485.73m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(7016) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(7080), "Omnis aspernatur doloremque tempore voluptas.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(7080), "https://picsum.photos/640/480/?image=25", "3b220797-ba32-4177-b962-dd47b2d8c823", 2432.12m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(7081) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(7107), "Amet quod vero dolorem quia.", new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(7107), "https://picsum.photos/640/480/?image=864", "803c7e7b-6f78-4db4-8b31-8eddb5abc33d", 2099.26m, new DateTime(2025, 5, 1, 19, 29, 44, 684, DateTimeKind.Local).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 687, DateTimeKind.Local).AddTicks(5182), 3, new DateTime(2025, 6, 2, 16, 20, 32, 515, DateTimeKind.Local).AddTicks(6155), new DateTime(2025, 5, 1, 19, 29, 44, 687, DateTimeKind.Local).AddTicks(5187), "b6c8058b-f909-4e34-8c21-01b8114e7b2d", 2, new DateTime(2024, 10, 15, 8, 55, 52, 576, DateTimeKind.Local).AddTicks(2276), new DateTime(2025, 5, 1, 19, 29, 44, 687, DateTimeKind.Local).AddTicks(5188) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 687, DateTimeKind.Local).AddTicks(5309), 9, new DateTime(2025, 7, 25, 0, 43, 26, 772, DateTimeKind.Local).AddTicks(5345), new DateTime(2025, 5, 1, 19, 29, 44, 687, DateTimeKind.Local).AddTicks(5310), "a1072311-b84a-4c1b-9660-ce5694ff6ba0", 2, new DateTime(2025, 1, 18, 8, 47, 8, 766, DateTimeKind.Local).AddTicks(1841), new DateTime(2025, 5, 1, 19, 29, 44, 687, DateTimeKind.Local).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 687, DateTimeKind.Local).AddTicks(5318), 8, new DateTime(2025, 5, 2, 4, 39, 4, 119, DateTimeKind.Local).AddTicks(6365), new DateTime(2025, 5, 1, 19, 29, 44, 687, DateTimeKind.Local).AddTicks(5319), "4726b4ca-e4b0-4ced-8a19-5d2d53349957", 1, new DateTime(2024, 11, 20, 23, 27, 29, 764, DateTimeKind.Local).AddTicks(2601), new DateTime(2025, 5, 1, 19, 29, 44, 687, DateTimeKind.Local).AddTicks(5319) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 687, DateTimeKind.Local).AddTicks(5353), 10, new DateTime(2026, 2, 2, 16, 10, 31, 394, DateTimeKind.Local).AddTicks(8169), new DateTime(2025, 5, 1, 19, 29, 44, 687, DateTimeKind.Local).AddTicks(5353), "e1176141-1271-454f-a911-23382ee80ce7", new DateTime(2024, 10, 23, 19, 27, 9, 444, DateTimeKind.Local).AddTicks(7290), new DateTime(2025, 5, 1, 19, 29, 44, 687, DateTimeKind.Local).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 687, DateTimeKind.Local).AddTicks(5360), new DateTime(2026, 4, 29, 23, 16, 31, 625, DateTimeKind.Local).AddTicks(4963), new DateTime(2025, 5, 1, 19, 29, 44, 687, DateTimeKind.Local).AddTicks(5360), "1f1edca4-14da-4f1f-9fc1-c3cf70346ebb", new DateTime(2024, 9, 22, 12, 0, 25, 878, DateTimeKind.Local).AddTicks(4519), new DateTime(2025, 5, 1, 19, 29, 44, 687, DateTimeKind.Local).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 687, DateTimeKind.Local).AddTicks(5367), 1, new DateTime(2025, 6, 14, 3, 0, 57, 851, DateTimeKind.Local).AddTicks(8782), new DateTime(2025, 5, 1, 19, 29, 44, 687, DateTimeKind.Local).AddTicks(5367), "7f815f8b-00de-48d5-aa1d-71618f846688", new DateTime(2024, 7, 8, 17, 28, 0, 891, DateTimeKind.Local).AddTicks(5927), new DateTime(2025, 5, 1, 19, 29, 44, 687, DateTimeKind.Local).AddTicks(5368) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 687, DateTimeKind.Local).AddTicks(5374), 10, new DateTime(2026, 1, 10, 17, 45, 17, 487, DateTimeKind.Local).AddTicks(6822), new DateTime(2025, 5, 1, 19, 29, 44, 687, DateTimeKind.Local).AddTicks(5374), "e966f150-d347-4bf5-9305-2d576de826ee", new DateTime(2024, 6, 9, 20, 27, 54, 575, DateTimeKind.Local).AddTicks(916), new DateTime(2025, 5, 1, 19, 29, 44, 687, DateTimeKind.Local).AddTicks(5374) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 687, DateTimeKind.Local).AddTicks(5383), new DateTime(2025, 5, 6, 10, 35, 26, 323, DateTimeKind.Local).AddTicks(1942), new DateTime(2025, 5, 1, 19, 29, 44, 687, DateTimeKind.Local).AddTicks(5384), "80e2c2b1-fba7-43c0-96d5-440e6ec08ed9", 2, new DateTime(2024, 10, 28, 23, 14, 22, 306, DateTimeKind.Local).AddTicks(3407), new DateTime(2025, 5, 1, 19, 29, 44, 687, DateTimeKind.Local).AddTicks(5384) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 687, DateTimeKind.Local).AddTicks(5391), 3, new DateTime(2025, 8, 23, 16, 58, 9, 818, DateTimeKind.Local).AddTicks(6447), new DateTime(2025, 5, 1, 19, 29, 44, 687, DateTimeKind.Local).AddTicks(5391), "7c7e206b-0753-41ff-aefa-c10c57c4ac85", 1, new DateTime(2025, 2, 1, 4, 30, 21, 39, DateTimeKind.Local).AddTicks(4337), new DateTime(2025, 5, 1, 19, 29, 44, 687, DateTimeKind.Local).AddTicks(5391) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 29, 44, 687, DateTimeKind.Local).AddTicks(5398), 5, new DateTime(2025, 12, 13, 20, 9, 54, 230, DateTimeKind.Local).AddTicks(3731), new DateTime(2025, 5, 1, 19, 29, 44, 687, DateTimeKind.Local).AddTicks(5398), "9e7c7c34-6c0d-4102-8d07-7509be96a895", new DateTime(2025, 3, 3, 9, 35, 21, 783, DateTimeKind.Local).AddTicks(2032), new DateTime(2025, 5, 1, 19, 29, 44, 687, DateTimeKind.Local).AddTicks(5398) });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ReservationId",
                table: "Payments",
                column: "ReservationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "West Melvina", "Andorra", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(839), "3516 Sean Cape, Nakialand, Costa Rica", "6", "FR2918390086677219506883A73", "654.206.6702", "Maryam66@gmail.com", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(850), "Ettie", "Effertz", "708cc5c4-756e-4c22-94a1-a862769cd9a3", "00680-8993", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(850) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "North Rosalyn", "Suriname", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(1912), "83930 Kristina Hill, Rowehaven, Austria", "8", "MD70838R553174Q451902294", "(209) 768-7685 x71786", "Tania7@yahoo.com", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(1912), "Myriam", "Graham", "53bda135-167b-461f-916b-b3b30bdd5006", "73694-2450", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(1913) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "North Nettie", "Trinidad and Tobago", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(2132), "3135 Seamus Highway, Hansenchester, Montserrat", "FO8500934040045055", "735-672-1766 x475", "Federico_VonRueden15@gmail.com", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(2133), "Loma", "Simonis", "909f3331-abe4-4606-a28d-8809414472b3", "39728", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(2133) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "East Kiannabury", "Afghanistan", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(2324), "119 McKenzie Lane, New Mossiechester, Falkland Islands (Malvinas)", "6", "TL967186344780050070994", "1-847-809-2018 x1886", "Brent_Robel@gmail.com", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(2325), "Dina", "Wiegand", "6e9e84ff-a8e1-4a2e-9f73-0040595cfb9d", "88974", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(2325) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Mrazberg", "Norway", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(2525), "0034 Akeem Parks, Dooleyside, Egypt", "10", "MC7801599780568925GA8AO6340", "1-817-595-2870 x2769", "Dominic.Rutherford9@gmail.com", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(2525), "Florian", "Aufderhar", "d75c36b2-e15e-478e-9669-889cb0d8298c", "74766", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(2526) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Port Joaniefort", "Turkey", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(2709), "718 Hortense Stravenue, Stokesborough, Burkina Faso", "2", "MC200503049069821M005K98730", "1-601-780-4549 x27890", "Jarvis_Lueilwitz@hotmail.com", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(2709), "Tyrese", "Ward", "31feba47-8557-43db-96cf-65fed3ed9d12", "13311", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Prosaccofort", "Zambia", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(2885), "89648 Albina Islands, Dedricchester, Angola", "2", "IL310065007004041700253", "(475) 561-4728 x0953", "Raul.Powlowski81@gmail.com", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(2886), "Kassandra", "Carter", "7734d414-5259-4aed-ba20-50134ba0acc9", "93702", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(2886) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Port Creola", "Solomon Islands", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(3046), "319 Granville Groves, Balistreriberg, Bermuda", "6", "DO90TUAH09468007544779335628", "837.342.0323 x8768", "Georgianna.Bayer@gmail.com", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(3047), "Elsa", "Marvin", "1a8464bc-c495-4405-95da-e739cb8af675", "51947", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(3047) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "South Richmond", "Australia", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(3358), "6245 Tressa Harbor, Parisianfort, Dominica", "1", "HR4523127998604009054", "1-554-753-0127 x698", "Liliane.Monahan99@yahoo.com", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(3360), "Randy", "Shanahan", "4a74fed4-218c-4195-ab89-56de133a18a7", "83046", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "East Perryview", "Grenada", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(3555), "502 Donavon Inlet, East Willisfurt, Poland", "3", "MR1659979162168600801019511", "817.456.8007 x91204", "Guido76@gmail.com", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(3555), "Jackson", "Roob", "d139c81c-39c6-4d64-9546-a8c9a37c281c", "17291-4825", new DateTime(2025, 5, 1, 11, 56, 23, 294, DateTimeKind.Local).AddTicks(3555) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Goldnerborough", "Western Sahara", new DateTime(2025, 8, 7, 20, 47, 23, 442, DateTimeKind.Local).AddTicks(9159), "Ethel40@gmail.com", "9043 Pfannerstill Garden, South Daphnee, Greece", "Lelah", "Cassin", "999-858-3384", new DateTime(2025, 5, 1, 11, 56, 23, 302, DateTimeKind.Local).AddTicks(2549), "efb10c92-d972-4232-83ce-31ea36fd9fbe", "40540", new DateTime(2026, 2, 18, 6, 0, 9, 155, DateTimeKind.Local).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Lake Wendystad", "Brazil", new DateTime(2025, 8, 8, 6, 45, 4, 983, DateTimeKind.Local).AddTicks(5249), "Leopoldo.McCullough5@gmail.com", "00111 Morgan Mountains, Port Noah, American Samoa", "Bernie", "Miller", "312-731-3742", new DateTime(2025, 5, 1, 11, 56, 23, 302, DateTimeKind.Local).AddTicks(2983), "7d990195-1efa-44f4-9e3c-0392a7abfdf2", "97665", new DateTime(2025, 11, 8, 19, 48, 30, 333, DateTimeKind.Local).AddTicks(9282) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Margaritamouth", "Armenia", new DateTime(2026, 4, 6, 20, 24, 8, 389, DateTimeKind.Local).AddTicks(1836), "Chet.West37@hotmail.com", "4615 Amelie Cliffs, West Marianoberg, Virgin Islands, U.S.", "Darwin", "Carter", "953.456.3485 x200", new DateTime(2025, 5, 1, 11, 56, 23, 302, DateTimeKind.Local).AddTicks(3148), "a4c7e500-d869-447f-a560-31e4dc8a2860", "38297-9535", new DateTime(2027, 2, 19, 3, 50, 13, 644, DateTimeKind.Local).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "North Brennamouth", "Liechtenstein", new DateTime(2025, 5, 22, 3, 36, 55, 421, DateTimeKind.Local).AddTicks(5164), "Elenora_Effertz85@gmail.com", "13914 Bernhard Orchard, Ebertside, Canada", "Milton", "Schultz", "854.911.6277", new DateTime(2025, 5, 1, 11, 56, 23, 302, DateTimeKind.Local).AddTicks(3280), "acaabf73-81d2-48ac-8b93-3fde28783aa1", "95741-0802", new DateTime(2026, 5, 17, 18, 14, 15, 104, DateTimeKind.Local).AddTicks(4163) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Richmondhaven", "Ethiopia", new DateTime(2025, 12, 16, 13, 44, 28, 47, DateTimeKind.Local).AddTicks(1297), "Ashtyn_Homenick53@gmail.com", "2013 Eula Green, Hueltown, Tokelau", "Ova", "Maggio", "278-377-3679 x5135", new DateTime(2025, 5, 1, 11, 56, 23, 302, DateTimeKind.Local).AddTicks(3413), "5100d4cb-22f7-4b59-8c14-7c31a46e4b97", "22571-7144", new DateTime(2026, 3, 25, 0, 22, 29, 510, DateTimeKind.Local).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Grimesbury", "Saint Lucia", new DateTime(2025, 9, 15, 10, 49, 16, 822, DateTimeKind.Local).AddTicks(5439), "Guido18@yahoo.com", "81808 Labadie Drive, Bergstromton, Mayotte", "Gavin", "Batz", "759.865.3823 x9037", new DateTime(2025, 5, 1, 11, 56, 23, 302, DateTimeKind.Local).AddTicks(3537), "8176d864-b22d-455c-ae94-3ac9696e732f", "47543-7669", new DateTime(2026, 7, 2, 14, 7, 10, 605, DateTimeKind.Local).AddTicks(7858) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Rauhaven", "Puerto Rico", new DateTime(2025, 12, 28, 11, 33, 7, 999, DateTimeKind.Local).AddTicks(8209), "Earnest96@gmail.com", "97818 Baumbach Springs, Lillianatown, Cocos (Keeling) Islands", "Lucinda", "Nitzsche", "394-453-2919 x552", new DateTime(2025, 5, 1, 11, 56, 23, 302, DateTimeKind.Local).AddTicks(3650), "1ab9166e-fb84-49d9-b49e-10b8cdef23e9", "41837-8515", new DateTime(2026, 5, 16, 14, 1, 26, 680, DateTimeKind.Local).AddTicks(5505) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "North Candelario", "Congo", new DateTime(2025, 11, 15, 10, 8, 13, 821, DateTimeKind.Local).AddTicks(5227), "Gregorio_Ankunding82@yahoo.com", "7891 Purdy Walk, Gulgowskiton, Burundi", "Alivia", "Brakus", "1-985-216-2329 x308", new DateTime(2025, 5, 1, 11, 56, 23, 302, DateTimeKind.Local).AddTicks(3767), "71ec9b70-aa5c-4767-8b45-94e31859ee0b", "40837-6836", new DateTime(2026, 5, 21, 9, 38, 12, 249, DateTimeKind.Local).AddTicks(5891) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Lake Roelbury", "Iraq", new DateTime(2025, 5, 3, 17, 23, 53, 284, DateTimeKind.Local).AddTicks(2045), "Shea_Baumbach@hotmail.com", "899 Schaden Haven, East Laverneborough, Swaziland", "Jaeden", "Feil", "908.216.7183", new DateTime(2025, 5, 1, 11, 56, 23, 302, DateTimeKind.Local).AddTicks(3884), "7a06dc8e-d82c-4f72-bc64-25866f6ef66e", "70537", new DateTime(2026, 2, 10, 17, 26, 15, 804, DateTimeKind.Local).AddTicks(4235) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "New Watsonshire", "Luxembourg", new DateTime(2025, 8, 8, 7, 58, 38, 116, DateTimeKind.Local).AddTicks(8219), "Franz29@hotmail.com", "941 Lexi Field, Estefaniatown, Guyana", "Cordie", "Kihn", "(848) 943-1908", new DateTime(2025, 5, 1, 11, 56, 23, 302, DateTimeKind.Local).AddTicks(4009), "9ff915bd-e6be-4a03-97ba-6e41c8d692d3", "42245-7201", new DateTime(2025, 12, 8, 18, 42, 3, 416, DateTimeKind.Local).AddTicks(1029) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4238), new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4242), 899.48m, new DateTime(2025, 1, 16, 18, 10, 23, 797, DateTimeKind.Local).AddTicks(329), "İn dicta doloremque ipsam architecto et eos et magni.", "Practical Cotton Pants", "01c49777-9432-4788-8359-9591d80dd1b3", 10, new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4243) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4457), new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4457), 858.40m, new DateTime(2024, 7, 3, 12, 39, 36, 537, DateTimeKind.Local).AddTicks(7192), "İtaque esse dicta voluptates.", "Awesome Plastic Pizza", "a5bc1606-f39b-43e3-a11f-7afa2d0ea0a7", 5, new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4457) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4491), new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4491), 986.70m, new DateTime(2025, 3, 11, 14, 29, 2, 222, DateTimeKind.Local).AddTicks(1898), "İncidunt vel dolores cum.", "Refined Soft Keyboard", "41f20d6b-eb4b-4041-9be7-75c936e96787", new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4491) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4519), new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4519), 790.72m, new DateTime(2025, 4, 14, 0, 4, 53, 138, DateTimeKind.Local).AddTicks(8550), "Quo aliquam repellat qui odit fuga id iusto.", "Awesome Frozen Sausages", "47879de5-f3b5-492f-91de-a533e74bad91", 5, new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4520) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4555), new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4555), 803.39m, new DateTime(2024, 5, 31, 13, 25, 38, 681, DateTimeKind.Local).AddTicks(9727), "Aut repellendus omnis est aut similique nisi beatae iure non.", "Rustic Frozen Fish", "d221830d-6238-4698-812b-e9f2b157d7ac", 4, new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4555) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4591), new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4592), 955.89m, new DateTime(2024, 10, 28, 22, 58, 33, 853, DateTimeKind.Local).AddTicks(6042), "Placeat quia quisquam placeat.", "Practical Plastic Pants", "d2cf96ec-b12d-4586-b7fa-cd7110a73b3f", new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4592) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4618), new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4618), 425.31m, new DateTime(2024, 10, 3, 9, 3, 6, 793, DateTimeKind.Local).AddTicks(4947), "Cupiditate mollitia harum molestias illo.", "Unbranded Cotton Soap", "182949d9-77db-4a6d-aa5f-2f5464c883b8", 6, new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4618) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4647), new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4647), 102.11m, new DateTime(2024, 5, 28, 15, 50, 20, 557, DateTimeKind.Local).AddTicks(7657), "Alias ut enim veritatis consectetur sunt et ad.", "Incredible Rubber Fish", "5f42c66c-c4fb-4a12-9714-99cc012bf01d", 7, new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4648) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4676), new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4677), 997.41m, new DateTime(2025, 2, 7, 4, 55, 11, 673, DateTimeKind.Local).AddTicks(7091), "Soluta consequuntur eos facere voluptatem velit nostrum perspiciatis qui voluptas.", "Gorgeous Wooden Pants", "440929df-fb65-403a-993d-215af339c24c", 2, new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4677) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4712), new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4712), 719.06m, new DateTime(2024, 10, 20, 11, 30, 2, 233, DateTimeKind.Local).AddTicks(1030), "Fuga unde in.", "Awesome Soft Bike", "3e4b180b-db83-4d42-b003-b3b69fc8f61c", 10, new DateTime(2025, 5, 1, 11, 56, 23, 300, DateTimeKind.Local).AddTicks(4713) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 10, 13, 26, 49, 682, DateTimeKind.Local).AddTicks(5315), new DateTime(2026, 6, 9, 15, 8, 21, 515, DateTimeKind.Local).AddTicks(685), new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3034), 10, new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3034), "d7ea9a7a-168f-4786-aece-b7921f16c330", 43, 1723.17m, new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3035) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 7, 14, 14, 6, 769, DateTimeKind.Local).AddTicks(7674), new DateTime(2027, 3, 19, 0, 28, 46, 286, DateTimeKind.Local).AddTicks(3847), new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3216), new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3216), "60e2f77a-94f6-45ad-90d9-3ce340f6312c", 15, 2018.87m, new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3216) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 26, 5, 39, 44, 934, DateTimeKind.Local).AddTicks(6050), new DateTime(2026, 4, 15, 15, 30, 10, 798, DateTimeKind.Local).AddTicks(7954), new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3239), 5, new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3239), "2e8bc4fe-c34d-49f4-90e0-ca273fb2d843", 15, 1671.31m, new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3239) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 12, 8, 20, 11, 21, 119, DateTimeKind.Local).AddTicks(5935), new DateTime(2026, 8, 13, 17, 48, 31, 967, DateTimeKind.Local).AddTicks(8061), new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3254), 9, new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3254), "0d35ba70-4947-4bec-905d-de24bf942dbf", 41, 2289.56m, new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 9, 10, 0, 8, 33, 283, DateTimeKind.Local).AddTicks(3076), new DateTime(2026, 5, 15, 0, 1, 58, 900, DateTimeKind.Local).AddTicks(5476), new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3267), 10, new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3268), "b0e0d207-c882-4c00-b992-3cd6110ceee3", 14, 2316.37m, new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3268) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 21, 12, 48, 53, 842, DateTimeKind.Local).AddTicks(573), new DateTime(2026, 5, 30, 12, 46, 33, 164, DateTimeKind.Local).AddTicks(2678), new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3283), 10, new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3283), "355dee23-283a-45f7-b587-8a4fb8e16a16", 47, 2114.11m, new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3284) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 21, 12, 10, 10, 34, DateTimeKind.Local).AddTicks(1123), new DateTime(2026, 3, 26, 21, 53, 38, 67, DateTimeKind.Local).AddTicks(7735), new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3296), 7, new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3296), "2053f3c9-853e-457f-8593-b0864618bee9", 44, 2269.21m, new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3296) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 28, 18, 59, 0, 566, DateTimeKind.Local).AddTicks(7402), new DateTime(2026, 2, 8, 19, 39, 28, 665, DateTimeKind.Local).AddTicks(553), new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3308), 8, new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3308), "168f6908-8952-4d8a-a876-0e0838633e94", 22, 1718.19m, new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3308) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 12, 23, 4, 32, 1, 691, DateTimeKind.Local).AddTicks(3789), new DateTime(2026, 2, 8, 1, 1, 18, 355, DateTimeKind.Local).AddTicks(2823), new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3320), 10, new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3320), "16046211-8b64-4ff0-9df8-00c84682e4fe", 10, 1997.49m, new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3321) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 12, 7, 14, 33, 32, 476, DateTimeKind.Local).AddTicks(1935), new DateTime(2026, 11, 21, 7, 46, 31, 376, DateTimeKind.Local).AddTicks(3233), new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3336), 6, new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3336), "6a628206-a362-48fe-bcf1-0d235c7e9c83", 42, 2051.39m, new DateTime(2025, 5, 1, 11, 56, 23, 303, DateTimeKind.Local).AddTicks(3336) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(7731), "Sit alias qui est minima.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(7736), "https://picsum.photos/640/480/?image=931", "1a36d596-4bca-431e-9bf9-9bde5d8c897f", 2172.84m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(7736) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8118), "Vel ullam aut reprehenderit maxime.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8120), "https://picsum.photos/640/480/?image=943", "dff56ed3-db03-41ce-85ee-3a58fa71e403", 1660.83m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8121) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8184), "Autem repudiandae et cumque quis.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8185), "https://picsum.photos/640/480/?image=1034", "8219c091-ab15-483d-834d-6771c8a371ee", 1731.80m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8185) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8218), "Vero maxime a tempore libero.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8218), "https://picsum.photos/640/480/?image=122", "7535882b-f43f-4cf4-9ba5-104de0286cc3", 2386.30m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8218) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8246), "Commodi excepturi in nulla veritatis.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8247), "https://picsum.photos/640/480/?image=258", "6c14a969-2092-4cc1-af24-c0410444489c", 2425.62m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8247) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8280), "Voluptas non et totam sint.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8280), "https://picsum.photos/640/480/?image=77", "34ef8240-ffc9-4a3e-b362-bf8db10ad155", 2298.03m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8305), "Et corporis nostrum quae odit.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8305), "https://picsum.photos/640/480/?image=1012", "445f24ec-3b45-41a2-95b2-7f838e542e3f", 2208.74m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8306) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8330), "Porro laboriosam deserunt voluptas ipsum.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8330), "https://picsum.photos/640/480/?image=429", "b22bdeca-0136-4c3c-8ee8-9d57ac4c1c36", 1549.17m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8331) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8354), "Quis voluptatem quaerat ut ab.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8354), "https://picsum.photos/640/480/?image=539", "92d8c2be-874f-4ed9-9ef0-fd720fc28a61", 1653.35m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8354) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8381), "İncidunt facilis quasi odio iusto.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8382), "https://picsum.photos/640/480/?image=638", "bf32cce0-7939-41db-a3e1-3f815893b434", 1821.72m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8383) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8405), "Harum impedit quia aspernatur recusandae.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8406), "https://picsum.photos/640/480/?image=356", "f7393f3d-3475-40d2-833c-da2c1b0e93f1", 1651.44m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8406) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8429), "Est ut molestias delectus ut.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8429), "https://picsum.photos/640/480/?image=137", "68cbc8de-ff6e-45e8-bb71-bad3d4ab8cab", 1670.28m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8429) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8451), "Maiores sint consequatur dicta iusto.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8452), "https://picsum.photos/640/480/?image=525", "fa638041-7d73-41f5-a632-fd8b300df3bd", 2212.62m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8452) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8474), "Dolores veritatis explicabo nesciunt quisquam.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8474), "https://picsum.photos/640/480/?image=136", "1c52bfc3-a23a-4be4-a976-ae38c10d6611", 1983.13m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8474) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8498), "Unde quia sequi quam in.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8500), "https://picsum.photos/640/480/?image=315", "263b16f7-d98b-4de4-8b5b-28b4f6d035dc", 1774.92m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8501) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8524), "Tempore veniam omnis dolorem a.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8524), "https://picsum.photos/640/480/?image=489", "ac2ef3ff-e535-41c1-bf38-a2018d5ef39c", 1924.92m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8524) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8545), "Aut aut voluptatem facilis cum.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8546), "https://picsum.photos/640/480/?image=346", "618bfcf8-4079-47f9-89ae-1604ee493889", 1513.51m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8546) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8567), "Voluptatem sunt qui laudantium perspiciatis.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8567), "https://picsum.photos/640/480/?image=771", "e87ffcaa-cf54-4f9d-a28b-3f446c50cc84", 1603.97m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8567) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8589), "Dolorem qui aliquam consectetur expedita.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8589), "https://picsum.photos/640/480/?image=477", "eb3b258f-7a9f-4c82-9209-4ab5f71aa29e", 2441.59m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8616), "Veniam rerum sapiente id ullam.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8616), "https://picsum.photos/640/480/?image=498", "db9eab4c-2bc3-4a6a-8755-953af202c352", 2225.86m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8616) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8638), "Vel sed quam odit quia.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8638), "https://picsum.photos/640/480/?image=320", "d626a664-d30e-422d-aff0-620ad2f17711", 2030.53m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8638) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8660), "Quidem nemo provident atque ea.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8661), "https://picsum.photos/640/480/?image=1000", "eae00350-1e38-4716-9a3d-9399533f88bc", 1501.89m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8661) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8682), "Odit sunt pariatur eos id.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8682), "https://picsum.photos/640/480/?image=848", "33685b5c-3f02-4ecb-a821-20c3c683d97d", 2258.91m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8683) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8704), "Harum et suscipit omnis corporis.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8705), "https://picsum.photos/640/480/?image=825", "12622b3e-d4ef-48f0-9789-a8f371b66698", 2251.12m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8705) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8726), "Recusandae consectetur quae esse pariatur.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8726), "https://picsum.photos/640/480/?image=267", "9dfd50f5-8596-4db6-b800-67945724c773", 2136.77m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8727) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8753), "Quas voluptatem id fuga enim.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8753), "https://picsum.photos/640/480/?image=766", "3b692c90-2651-442c-ada2-6204776b32e7", 1943.04m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8774), "Soluta facere alias consequatur placeat.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8775), "https://picsum.photos/640/480/?image=527", "03785005-a4f8-4cf7-acc6-2c0d0c27f86f", 2019.56m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8797), "Quo tempora consectetur quis mollitia.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8797), "https://picsum.photos/640/480/?image=481", "298b8da3-2aef-4f24-a4d4-d65c93f11f4d", 2118.80m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8797) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8818), "Temporibus eos nihil quos commodi.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8818), "https://picsum.photos/640/480/?image=832", "0f2848d6-3949-4e20-b0ab-71ba25bc41df", 1542.74m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8818) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8839), "Atque ullam sint qui nobis.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8839), "https://picsum.photos/640/480/?image=525", "92883847-e76e-43e2-a75b-eaf1d91f0e9c", 1587.01m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8839) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8864), "Omnis repellat cupiditate ipsam ut.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8865), "https://picsum.photos/640/480/?image=48", "50165822-9316-4d5e-9036-d52e940d3071", 2395.20m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8888), "Quaerat labore in quidem distinctio.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8888), "https://picsum.photos/640/480/?image=601", "f2ca97d7-2d75-4db7-a8bd-3164fd7d47be", 1836.73m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8909), "Culpa quos aut et qui.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8909), "https://picsum.photos/640/480/?image=686", "c492a47b-04c9-4042-a9c2-734332a769d1", 1557.52m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8909) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8931), "Dolor voluptatibus assumenda nesciunt inventore.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8931), "https://picsum.photos/640/480/?image=495", "84b70aa1-fda3-4557-bd9b-96e2dee09bb5", 2318.80m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9020), "Quis nihil quam et facere.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9020), "https://picsum.photos/640/480/?image=797", "50b01a1b-d973-4f08-8be4-656918ff1a07", 1965.27m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9043), "Et distinctio rerum est qui.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9043), "https://picsum.photos/640/480/?image=839", "7534f926-60ad-4746-8cc2-1b90abd9611c", 2037.69m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9065), "İncidunt et aut non itaque.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9066), "https://picsum.photos/640/480/?image=813", "617bb678-1adf-4f3d-98f9-be7b0ba99f8e", 1759.76m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9066) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9087), "Ad nobis exercitationem et voluptatum.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9087), "https://picsum.photos/640/480/?image=226", "d0fe276a-302a-438f-88f4-1c399fa15f1e", 1514.52m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9088) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9109), "Ducimus impedit minus aut qui.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9109), "https://picsum.photos/640/480/?image=1062", "7c799a95-b880-458c-a47d-499c5ce94368", 2015.86m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9132), "Dignissimos sint veritatis ea cupiditate.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9132), "https://picsum.photos/640/480/?image=1062", "1192658f-d05d-4e72-850d-7bd82a7d0b7d", 1860.64m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9132) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9158), "Corporis tempore voluptatum quidem nulla.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9158), "https://picsum.photos/640/480/?image=671", "aa161add-fe33-4d03-814e-c7f494e7281f", 2203.37m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9158) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9180), "Expedita hic est quisquam illum.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9180), "https://picsum.photos/640/480/?image=277", "8e7720f9-2340-4ee6-b412-634e67cbe9b2", 1844.03m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9201), "Veritatis quibusdam odio in corrupti.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9201), "https://picsum.photos/640/480/?image=140", "f9fe460a-0558-4a0e-bdc9-5141aecea320", 1833.46m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9201) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9221), "Occaecati porro non fugiat saepe.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9222), "https://picsum.photos/640/480/?image=690", "35065c04-54b6-44e1-b988-9fae5328b7b5", 1611.64m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9222) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9241), "Repellendus enim laborum occaecati nihil.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9242), "https://picsum.photos/640/480/?image=753", "8641b025-f208-4a4b-bce8-43e350390412", 1773.96m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9242) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9266), "Voluptate eveniet consectetur sed repudiandae.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9266), "https://picsum.photos/640/480/?image=583", "3ecffc6a-c5c6-45ce-8137-5dadb831cb2d", 2175.64m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9267) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9287), "Occaecati et perspiciatis ex qui.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9288), "https://picsum.photos/640/480/?image=163", "f44383ff-e05a-49a3-bbe3-478fa6273c6b", 2458.22m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9288) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9310), "Perferendis at aut ea incidunt.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9310), "https://picsum.photos/640/480/?image=347", "805b4562-f4cb-4a93-b74e-b39ef32a548d", 1906.95m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9310) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9330), "Debitis deserunt aut aut exercitationem.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9330), "https://picsum.photos/640/480/?image=181", "6aa49077-346b-42d9-ac30-9e7aa0117601", 1841.93m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9330) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Description", "EntryDate", "ImageUrl", "MasterId", "PricePerNight", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9355), "Sit architecto et dolore ut.", new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9355), "https://picsum.photos/640/480/?image=833", "7268f29b-278f-4e5f-99fc-e4b59340e64f", 1883.09m, new DateTime(2025, 5, 1, 11, 56, 23, 295, DateTimeKind.Local).AddTicks(9356) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(2844), 10, new DateTime(2026, 1, 24, 3, 25, 37, 235, DateTimeKind.Local).AddTicks(3873), new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(2848), "56e66382-88be-49f5-8e9c-235ff8e98791", 0, new DateTime(2024, 10, 26, 4, 2, 56, 576, DateTimeKind.Local).AddTicks(2557), new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(2848) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(2967), 10, new DateTime(2025, 7, 1, 14, 36, 47, 533, DateTimeKind.Local).AddTicks(503), new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(2968), "415792ad-d6a2-4635-9af5-9d16da7a15bd", 1, new DateTime(2024, 7, 25, 3, 14, 7, 760, DateTimeKind.Local).AddTicks(4268), new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(2968) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(2977), 5, new DateTime(2025, 8, 8, 9, 40, 23, 636, DateTimeKind.Local).AddTicks(4940), new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(2977), "747f58d5-2eb2-4609-b162-27bca39dbfb6", 0, new DateTime(2024, 9, 9, 2, 52, 25, 718, DateTimeKind.Local).AddTicks(1689), new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(2978) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(2984), 8, new DateTime(2025, 8, 28, 1, 45, 57, 408, DateTimeKind.Local).AddTicks(3538), new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(2984), "afde93d1-0bc2-41c0-b49b-5c2a57d3d22a", new DateTime(2024, 10, 31, 19, 37, 43, 729, DateTimeKind.Local).AddTicks(6444), new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(2984) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(2990), new DateTime(2025, 8, 13, 7, 30, 44, 939, DateTimeKind.Local).AddTicks(7374), new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(2990), "b59fdc36-75d4-4072-9da0-3697568e2764", new DateTime(2025, 1, 19, 7, 33, 29, 522, DateTimeKind.Local).AddTicks(8267), new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(2990) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(3001), 10, new DateTime(2025, 8, 8, 0, 1, 12, 620, DateTimeKind.Local).AddTicks(2975), new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(3001), "2e6b8590-7f95-4dc3-b96b-75999901aa1f", new DateTime(2024, 11, 19, 7, 47, 38, 391, DateTimeKind.Local).AddTicks(4244), new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(3001) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(3007), 1, new DateTime(2025, 9, 3, 6, 1, 13, 204, DateTimeKind.Local).AddTicks(816), new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(3008), "27b55dac-43ab-4dd2-a8a8-6a2a6a7d583f", new DateTime(2025, 4, 11, 7, 9, 19, 826, DateTimeKind.Local).AddTicks(3847), new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(3008) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(3014), new DateTime(2025, 5, 6, 6, 1, 11, 984, DateTimeKind.Local).AddTicks(1077), new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(3014), "b18e3834-604d-4885-83f5-823e053582fa", 1, new DateTime(2024, 7, 3, 22, 22, 5, 494, DateTimeKind.Local).AddTicks(7883), new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(3020), 7, new DateTime(2026, 3, 1, 2, 23, 17, 741, DateTimeKind.Local).AddTicks(7012), new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(3020), "97a11adc-9c99-4cf2-9522-696ede61afb3", 0, new DateTime(2024, 11, 10, 9, 53, 59, 444, DateTimeKind.Local).AddTicks(2720), new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(3020) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(3026), 1, new DateTime(2026, 2, 2, 16, 27, 53, 227, DateTimeKind.Local).AddTicks(1105), new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(3027), "6f384e34-ca07-4daa-9058-e67848989397", new DateTime(2024, 12, 9, 4, 45, 34, 214, DateTimeKind.Local).AddTicks(8362), new DateTime(2025, 5, 1, 11, 56, 23, 301, DateTimeKind.Local).AddTicks(3027) });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Init5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Braunstad", "Antarctica (the territory South of 60 deg S)", new DateTime(2025, 8, 18, 1, 38, 42, 454, DateTimeKind.Local).AddTicks(7678), "5465 Goyette Streets, Dareburgh, Burkina Faso", "6", "LI52008822609V3H5A868", "1-864-864-7258 x29237", "Ruth.Doyle@gmail.com", new DateTime(2025, 8, 18, 1, 38, 42, 454, DateTimeKind.Local).AddTicks(7689), "Norwood", "Rice", "5eb1534b-5667-468f-9057-e2b580ee9c7d", "75434-9821", new DateTime(2025, 8, 18, 1, 38, 42, 454, DateTimeKind.Local).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Port Roger", "Bolivia", new DateTime(2025, 8, 18, 1, 38, 42, 454, DateTimeKind.Local).AddTicks(8763), "14228 Quigley Cliffs, Rogahnhaven, Tanzania", "8", "SK3113074313793990730256", "695-333-2420 x697", "Darlene48@gmail.com", new DateTime(2025, 8, 18, 1, 38, 42, 454, DateTimeKind.Local).AddTicks(8764), "Garfield", "Hauck", "d57fd0e2-66d0-4c37-964f-0586ef3b75be", "86699", new DateTime(2025, 8, 18, 1, 38, 42, 454, DateTimeKind.Local).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Port Aliza", "Cambodia", new DateTime(2025, 8, 18, 1, 38, 42, 454, DateTimeKind.Local).AddTicks(9196), "92421 Tristin Centers, Verniehaven, Brunei Darussalam", "1", "IE562F6894233048800432", "421-344-7539", "Estefania.Cartwright@gmail.com", new DateTime(2025, 8, 18, 1, 38, 42, 454, DateTimeKind.Local).AddTicks(9197), "Thomas", "Bergstrom", "004df4b3-9553-4741-bf3b-bbe3b357d83e", "75120-3703", new DateTime(2025, 8, 18, 1, 38, 42, 454, DateTimeKind.Local).AddTicks(9198) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "North Darrenfurt", "Anguilla", new DateTime(2025, 8, 18, 1, 38, 42, 454, DateTimeKind.Local).AddTicks(9588), "604 Kertzmann Underpass, East Rachelview, Marshall Islands", "IE70636882003940050047", "813.598.8266 x220", "Yessenia_Torphy@yahoo.com", new DateTime(2025, 8, 18, 1, 38, 42, 454, DateTimeKind.Local).AddTicks(9588), "Florida", "Maggio", "89a42027-6be0-459f-942a-a972aff6e3b7", "80691", new DateTime(2025, 8, 18, 1, 38, 42, 454, DateTimeKind.Local).AddTicks(9589) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Berenicehaven", "Virgin Islands, British", new DateTime(2025, 8, 18, 1, 38, 42, 455, DateTimeKind.Local).AddTicks(206), "7346 Hilll Turnpike, Connerton, Somalia", "9", "SA9280YD804O63V3O7G1ZC67", "396-211-7069", "Winnifred.Conn@hotmail.com", new DateTime(2025, 8, 18, 1, 38, 42, 455, DateTimeKind.Local).AddTicks(208), "Wendy", "Bashirian", "6ed5a240-9d7f-44ec-9e64-43ca29c1e857", "14553", new DateTime(2025, 8, 18, 1, 38, 42, 455, DateTimeKind.Local).AddTicks(209) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "West Kallie", "Mauritania", new DateTime(2025, 8, 18, 1, 38, 42, 455, DateTimeKind.Local).AddTicks(628), "1476 Miles Ramp, Lake Jaronburgh, Timor-Leste", "4", "KW45PTYS9S50344605B53T230H1397", "344.645.8606 x955", "Joan_Zboncak@gmail.com", new DateTime(2025, 8, 18, 1, 38, 42, 455, DateTimeKind.Local).AddTicks(628), "Ulices", "Davis", "e10d9471-277b-4c90-ba3f-85d31ee84cf5", "60454", new DateTime(2025, 8, 18, 1, 38, 42, 455, DateTimeKind.Local).AddTicks(629) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "New Celestinoside", "Virgin Islands, U.S.", new DateTime(2025, 8, 18, 1, 38, 42, 455, DateTimeKind.Local).AddTicks(1015), "159 Ward Cove, Port Demetris, Sao Tome and Principe", "5", "KW61JUBI778YF35252693803425768", "(489) 287-8688 x698", "Emma87@gmail.com", new DateTime(2025, 8, 18, 1, 38, 42, 455, DateTimeKind.Local).AddTicks(1016), "Lacy", "Armstrong", "ea176f8e-8d36-4c24-b2bf-3cb386b29206", "64681-5143", new DateTime(2025, 8, 18, 1, 38, 42, 455, DateTimeKind.Local).AddTicks(1016) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "New Otha", "Bouvet Island (Bouvetoya)", new DateTime(2025, 8, 18, 1, 38, 42, 455, DateTimeKind.Local).AddTicks(1379), "489 Becker Orchard, Wunschburgh, Greece", "7", "PL32557244075200808458522004", "1-574-655-9080", "Olga_Lind64@gmail.com", new DateTime(2025, 8, 18, 1, 38, 42, 455, DateTimeKind.Local).AddTicks(1380), "Naomi", "Leuschke", "aa640b2e-0ac1-46c6-9639-962f9a2e8ae9", "74679-6037", new DateTime(2025, 8, 18, 1, 38, 42, 455, DateTimeKind.Local).AddTicks(1381) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "West Marvin", "Brunei Darussalam", new DateTime(2025, 8, 18, 1, 38, 42, 455, DateTimeKind.Local).AddTicks(1731), "39364 Eldon Ports, Lake Era, Micronesia", "11", "LU538798GT3J842Q6D09", "835-292-1482 x2821", "Deondre63@yahoo.com", new DateTime(2025, 8, 18, 1, 38, 42, 455, DateTimeKind.Local).AddTicks(1732), "Kimberly", "Bergnaum", "50a3655f-bd97-4edc-82a6-c28f0a18b001", "51389", new DateTime(2025, 8, 18, 1, 38, 42, 455, DateTimeKind.Local).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Lake Yasmineville", "Zambia", new DateTime(2025, 8, 18, 1, 38, 42, 455, DateTimeKind.Local).AddTicks(2075), "5045 Betty Pine, New Lornachester, Cyprus", "8", "LU59285W4937496K271U", "(209) 801-0754 x6360", "Edd.Runolfsson@hotmail.com", new DateTime(2025, 8, 18, 1, 38, 42, 455, DateTimeKind.Local).AddTicks(2076), "Elza", "Wuckert", "6445617c-2086-48cf-8f86-92740f9acbc7", "24649-2384", new DateTime(2025, 8, 18, 1, 38, 42, 455, DateTimeKind.Local).AddTicks(2077) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Muş", "Montserrat", new DateTime(2025, 8, 18, 1, 38, 42, 636, DateTimeKind.Local).AddTicks(7192), "Baykoca.Paksut@gmail.com", "Harman Altı Sokak 07, Diyarbakır, Yeni Kaledonya, Fransa", "Bayankağan", "Küçükler", "+90-469-205-6-402", new DateTime(2025, 8, 18, 1, 38, 42, 636, DateTimeKind.Local).AddTicks(7197), "ba8b25fd-c97f-4436-bb3b-76ed72c788f6", new DateTime(2025, 8, 18, 1, 38, 42, 636, DateTimeKind.Local).AddTicks(7197) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Isparta", "Svaziland", new DateTime(2025, 8, 18, 1, 38, 42, 636, DateTimeKind.Local).AddTicks(8366), "Araboga.Kuday63@gmail.com", "Kocatepe Caddesi 82b, Giresun, Katar", "Erinç", "Dağdaş", "+90-596-578-71-13", new DateTime(2025, 8, 18, 1, 38, 42, 636, DateTimeKind.Local).AddTicks(8366), "a48c15e0-a6e9-40eb-bad5-fd81f57d733b", new DateTime(2025, 8, 18, 1, 38, 42, 636, DateTimeKind.Local).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Gaziantep", "Dominik Cumhuriyeti", new DateTime(2025, 8, 18, 1, 38, 42, 636, DateTimeKind.Local).AddTicks(8666), "Bilik_Aykac@hotmail.com", "Sıran Söğüt Sokak 47a, Hatay, Surinam", "Aladağ", "Yetkiner", "+90-442-579-87-72", new DateTime(2025, 8, 18, 1, 38, 42, 636, DateTimeKind.Local).AddTicks(8666), "d1c09cd0-7be8-45ce-80a2-ca7345ea5674", "1", new DateTime(2025, 8, 18, 1, 38, 42, 636, DateTimeKind.Local).AddTicks(8667) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Düzce", "Kuzey Maryana Adaları", new DateTime(2025, 8, 18, 1, 38, 42, 636, DateTimeKind.Local).AddTicks(8905), "Al.Akal65@hotmail.com", "Harman Altı Sokak 60a, Erzincan, Botswana", "Çobulmak", "Kuday", "+90-684-559-82-57", new DateTime(2025, 8, 18, 1, 38, 42, 636, DateTimeKind.Local).AddTicks(8906), "d7a4330c-4725-4ccc-87e1-7030f9f58176", new DateTime(2025, 8, 18, 1, 38, 42, 636, DateTimeKind.Local).AddTicks(8906) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Manisa", "Kosova", new DateTime(2025, 8, 18, 1, 38, 42, 636, DateTimeKind.Local).AddTicks(9107), "Akin52@gmail.com", "Ergenekon Sokak   489, Erzurum, Galler", "Altan", "Günday", "+90-666-387-0-955", new DateTime(2025, 8, 18, 1, 38, 42, 636, DateTimeKind.Local).AddTicks(9108), "02f38f70-6182-4a0a-bee3-747ecc51d73e", new DateTime(2025, 8, 18, 1, 38, 42, 636, DateTimeKind.Local).AddTicks(9108) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Karaman", "Marşal Adaları", new DateTime(2025, 8, 18, 1, 38, 42, 636, DateTimeKind.Local).AddTicks(9360), "Alpaya.Tunceri21@gmail.com", "Kekeçoğlu Sokak 1, İzmir, Lüksemburg", "Aydemir", "Elçiboğa", "+90-002-088-4-568", new DateTime(2025, 8, 18, 1, 38, 42, 636, DateTimeKind.Local).AddTicks(9361), "fcfb1620-631d-4b77-a19a-cf81deefdbaa", new DateTime(2025, 8, 18, 1, 38, 42, 636, DateTimeKind.Local).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Ankara", "Amerika Birleşik Devletleri", new DateTime(2025, 8, 18, 1, 38, 42, 636, DateTimeKind.Local).AddTicks(9564), "Ergenekatun_Duygulu9@gmail.com", "30 Ağustos Caddesi 900, Karabük, Burundi", "Barçadurdu", "Korol", "+90-774-224-4-503", new DateTime(2025, 8, 18, 1, 38, 42, 636, DateTimeKind.Local).AddTicks(9564), "f82cd706-35f6-47fc-add5-3ec08ce0f329", new DateTime(2025, 8, 18, 1, 38, 42, 636, DateTimeKind.Local).AddTicks(9564) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Gaziantep", "Birleşik Arap Emirlikleri", new DateTime(2025, 8, 18, 1, 38, 42, 638, DateTimeKind.Local).AddTicks(9510), "Keklik.Uca42@hotmail.com", "Harman Altı Sokak 51c, İstanbul, Fas", "Balakatay", "Koçyiğit", "+90-045-197-8-914", new DateTime(2025, 8, 18, 1, 38, 42, 638, DateTimeKind.Local).AddTicks(9516), "73440212-82f6-48b4-980c-c898d9da8ece", "1", new DateTime(2025, 8, 18, 1, 38, 42, 638, DateTimeKind.Local).AddTicks(9517) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Bilecik", "Midway Adaları, Amerika", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(666), "Caglayan.Akbulut58@hotmail.com", "Ali Çetinkaya Caddesi 83, Elazığ, Makau (Makao)", "Baydemir", "Adıvar", "+90-426-106-2-308", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(667), "6c98fddc-46f5-4b6d-a2e2-35a04c29d6f7", "1", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(667) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Rize", "San Marino", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(973), "Bilgeciksin_Catalbas@gmail.com", "Okul Sokak 40, Burdur, Saint Helena, İngiltere", "Aykağan", "Çetin", "+90-899-218-2-097", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(973), "75033240-164c-4f4c-883c-de7969b1514b", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(974) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Kütahya", "Ürdün", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(1313), "Bozkus55@hotmail.com", "Yunus Emre Sokak 17a, Malatya, Antigua ve Barbuda", "Bilgetardu", "Mertoğlu", "+90-461-092-05-84", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(1314), "175bc9f0-b529-40f9-81ee-225cee9393cb", "0", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(1314) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Burdur", "Grenada", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(1591), "Cokramayul.Erbay68@gmail.com", "Harman Yolu Sokak  05b, Aydın, Türkiye", "Berendey", "Tokgöz", "+90-891-483-2-384", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(1591), "98b292dd-50b7-4e2a-acf4-9b6ba38985db", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(1592) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Ağrı", "Antigua ve Barbuda", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(1812), "Altinoba_Cevik@gmail.com", "Saygılı Sokak 36, Antalya, Bhutan", "İtil", "Avan", "+90-257-450-44-32", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(1813), "3966c72d-bf76-4cb1-9d9e-82ac3ba55ca2", "1", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(1814) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Muş", "Maldiv Adaları", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(2019), "Ediz.Elciboga67@hotmail.com", "Sevgi Sokak 71b, Edirne, İrlanda", "Kazanç", "Türkdoğan", "+90-634-568-20-66", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(2020), "483dcbd3-792d-4c82-b8fb-a54c71d399dc", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(2020) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Bartın", "Honduras", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(2212), "Balaka63@gmail.com", "Sarıkaya Caddesi 90c, Iğdır, Polonya", "Basar", "Çamdalı", "+90-675-089-06-45", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(2213), "31c00037-d53d-4eb4-9b92-922633402b14", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(2213) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Bartın", "Angola", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(2528), "Bozboru_Topcuoglu@gmail.com", "Sağlık Sokak 3, Eskişehir, İran", "Ekin", "Dağdaş", "+90-987-455-06-73", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(2529), "284bcb8b-318a-4ce3-95ea-2e4c02507fd9", "0", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(2529) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Antalya", "Komorlar", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(2754), "Ikicitoyun.Alniacik79@hotmail.com", "Güven Yaka Sokak 76, Sivas, Portekiz", "Alpilig", "Kılıççı", "+90-399-373-19-65", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(2754), "154e79d6-3ddc-4f74-9b5d-783532db586d", "0", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Rize", "Ermenistan", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(2973), "Bacman.Asikoglu@hotmail.com", "Sıran Söğüt Sokak 60, Niğde, Saint Helena, İngiltere", "Baltur", "Okur", "+90-679-253-52-63", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(2973), "7a339b27-dc00-43c3-b41a-57d170c4f1b9", "1", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Afyon", "Cebelitarık, İngiltere", new DateTime(2025, 8, 18, 1, 38, 42, 641, DateTimeKind.Local).AddTicks(7137), "Asantugrul.Erez@hotmail.com", "Sağlık Sokak 20a, Balıkesir, Namibia", "Beğboğa", "Erkekli", "+90-639-863-83-45", new DateTime(2025, 8, 18, 1, 38, 42, 641, DateTimeKind.Local).AddTicks(7145), "0e0ce23f-771e-4114-9a17-13c2cd586932", new DateTime(2025, 8, 18, 1, 38, 42, 641, DateTimeKind.Local).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Aydın", "Bangladeş", new DateTime(2025, 8, 18, 1, 38, 42, 641, DateTimeKind.Local).AddTicks(8272), "Akata.Keseroglu@yahoo.com", "Kerimoğlu Sokak 21c, Kayseri, İsrail", "Çocukbörü", "Örge", "+90-403-490-4-253", new DateTime(2025, 8, 18, 1, 38, 42, 641, DateTimeKind.Local).AddTicks(8273), "0655bd03-8a38-416e-89ce-d902add577b8", "0", new DateTime(2025, 8, 18, 1, 38, 42, 641, DateTimeKind.Local).AddTicks(8274) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Iğdır", "Fiji", new DateTime(2025, 8, 18, 1, 38, 42, 641, DateTimeKind.Local).AddTicks(8602), "Azganaz.Karaer27@hotmail.com", "Ülkü Sokak 956, Şırnak, Turks ve Caicos Adaları, İngiltere", "Belgüc", "Abadan", "+90-890-121-45-10", new DateTime(2025, 8, 18, 1, 38, 42, 641, DateTimeKind.Local).AddTicks(8603), "f01de683-f2c1-4419-ab93-c63c6508da90", new DateTime(2025, 8, 18, 1, 38, 42, 641, DateTimeKind.Local).AddTicks(8603) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Gaziantep", "Yeni Kaledonya, Fransa", new DateTime(2025, 8, 18, 1, 38, 42, 641, DateTimeKind.Local).AddTicks(9067), "Altintamgantarkan.Adan27@yahoo.com", "Harman Yolu Sokak  599, Bartın, Jamaika", "Bozok", "Aybar", "+90-270-942-48-82", new DateTime(2025, 8, 18, 1, 38, 42, 641, DateTimeKind.Local).AddTicks(9070), "f9f2d8d4-fbb1-4749-a67f-9c7efba0da79", "0", new DateTime(2025, 8, 18, 1, 38, 42, 641, DateTimeKind.Local).AddTicks(9071) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Diyarbakır", "Guadalup, Fransa", new DateTime(2025, 8, 18, 1, 38, 42, 641, DateTimeKind.Local).AddTicks(9510), "Buzac_Samanci@hotmail.com", "Gül Sokak 66c, Batman, Virgin Adaları, İngiltere", "Bünül", "Özbey", "+90-407-157-5-548", new DateTime(2025, 8, 18, 1, 38, 42, 641, DateTimeKind.Local).AddTicks(9512), "7d7a9c61-7151-4d6d-b856-a0af025e807f", new DateTime(2025, 8, 18, 1, 38, 42, 641, DateTimeKind.Local).AddTicks(9512) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Kosta Rika", new DateTime(2025, 8, 18, 1, 38, 42, 641, DateTimeKind.Local).AddTicks(9797), "Irmak.Mertoglu@hotmail.com", "İsmet Attila Caddesi 220, Hakkari, Gine", "Alkış", "Kavaklıoğlu", "+90-196-416-84-80", new DateTime(2025, 8, 18, 1, 38, 42, 641, DateTimeKind.Local).AddTicks(9798), "6a27cbb8-0be2-462e-acbb-60b437caa651", "1", new DateTime(2025, 8, 18, 1, 38, 42, 641, DateTimeKind.Local).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Sivas", "Ekvator", new DateTime(2025, 8, 18, 1, 38, 42, 642, DateTimeKind.Local).AddTicks(69), "Egemen_Karadas19@yahoo.com", "Nalbant Sokak 44b, Rize, Reunion, Fransa", "Araboğa", "Ağaoğlu", "+90-420-320-0-787", new DateTime(2025, 8, 18, 1, 38, 42, 642, DateTimeKind.Local).AddTicks(70), "9d318368-8bb5-4455-838f-5c3719622cca", "1", new DateTime(2025, 8, 18, 1, 38, 42, 642, DateTimeKind.Local).AddTicks(70) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Tekirdağ", "Ürdün", new DateTime(2025, 8, 18, 1, 38, 42, 642, DateTimeKind.Local).AddTicks(363), "Baskirt_Koyluoglu@hotmail.com", "Fatih Sokak  346, İçel (Mersin), Burkina Faso", "Baltacı", "Kahveci", "+90-182-435-95-97", new DateTime(2025, 8, 18, 1, 38, 42, 642, DateTimeKind.Local).AddTicks(364), "05ddfd01-5c76-4ad9-a485-c205a9fea127", new DateTime(2025, 8, 18, 1, 38, 42, 642, DateTimeKind.Local).AddTicks(364) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Bingöl", "Paraguay", new DateTime(2025, 8, 18, 1, 38, 42, 642, DateTimeKind.Local).AddTicks(654), "Isilay.Aksit22@hotmail.com", "İbn-i Sina Sokak 08c, Van, Güney Georgia ve Güney Sandviç Adaları, İngiltere", "Alakurt", "Ilıcalı", "+90-780-327-61-57", new DateTime(2025, 8, 18, 1, 38, 42, 642, DateTimeKind.Local).AddTicks(655), "5c9482cc-8f68-4df8-8f4b-d4be90e38c26", "1", new DateTime(2025, 8, 18, 1, 38, 42, 642, DateTimeKind.Local).AddTicks(656) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Nevşehir", "Solomon Adaları", new DateTime(2025, 8, 18, 1, 38, 42, 642, DateTimeKind.Local).AddTicks(916), "Besentegin54@hotmail.com", "Kerimoğlu Sokak 77b, Çanakkale, Santa Vincent ve Grenadinler", "Besentegin", "Aydan", "+90-528-795-91-46", new DateTime(2025, 8, 18, 1, 38, 42, 642, DateTimeKind.Local).AddTicks(917), "2e106aed-8e4d-499d-95af-d8b4873864af", "0", new DateTime(2025, 8, 18, 1, 38, 42, 642, DateTimeKind.Local).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Karaman", "Çad", new DateTime(2025, 8, 18, 1, 38, 42, 642, DateTimeKind.Local).AddTicks(1184), "Bayutmus.Arican@hotmail.com", "30 Ağustos Caddesi 17, Çanakkale, Laos", "Ataldı", "Ayverdi", "+90-572-799-8-637", new DateTime(2025, 8, 18, 1, 38, 42, 642, DateTimeKind.Local).AddTicks(1184), "0ff96028-219e-493c-b3e3-e04196bc07d1", "1", new DateTime(2025, 8, 18, 1, 38, 42, 642, DateTimeKind.Local).AddTicks(1185) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Çankırı", "Kosova", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(659), "Avsar_Adal@gmail.com", "Mevlana Sokak 05a, Bingöl, Cibuti", "Börübars", "Velioğlu", "+90-183-862-8-702", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(668), "dc3f2168-5900-4e65-9b45-09764cf55d15", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(669) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Bilecik", "Beyaz Rusya", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(2073), "Gokcen36@hotmail.com", "Okul Sokak 07, Şanlıurfa, Güney Georgia ve Güney Sandviç Adaları, İngiltere", "Akaş", "Türkyılmaz", "+90-069-319-30-35", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(2075), "7a5a7106-9ffa-460e-aa19-a25a4f6abf73", "1", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(2076) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Kocaeli", "Kuzey Maryana Adaları", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(2428), "Adik70@yahoo.com", "Harman Yolu Sokak  60a, Van, Tuvalu", "Barlas", "Kavaklıoğlu", "+90-507-791-4-979", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(2428), "b4f1cd28-2662-4ab8-a3b2-5025d8c11d2f", "0", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(2429) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Yozgat", "İspanya", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(2706), "Aygirak_Koybasi@yahoo.com", "Afyon Kaya Sokak 705, Manisa, Mauritius", "Avşar", "Samancı", "+90-168-929-9-859", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(2707), "208902c5-9b63-41d8-a38b-493099cbb60e", "0", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(2707) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Bitlis", "Aruba, Hollanda", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(3062), "Buzactutuk54@gmail.com", "Güven Yaka Sokak 5, Yalova, İran", "Ağalak", "Hakyemez", "+90-409-011-6-305", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(3063), "e21f7965-03a5-49ec-bfc5-c6d3b6d733f1", "1", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(3064) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Malatya", "Johnston Atoll, Amerika", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(3427), "Ertenozuk86@yahoo.com", "Bahçe Sokak 4, Ankara, Nauru", "Kaynak", "Tekand", "+90-388-793-50-64", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(3428), "c3281700-e56f-4ae2-a7c5-5ff4d30672d2", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(3429) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Ankara", "Makedonya", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(3757), "Isig.Onur88@hotmail.com", "Saygılı Sokak 4, Isparta, Bahreyn", "Begine", "Küçükler", "+90-177-809-91-13", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(3758), "48f07585-1cf9-47da-bef7-6d183e98c3dd", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(3759) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Mardin", "Cayman Adaları, İngiltere", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(4081), "Buyankara_Nalbantoglu@gmail.com", "Kerimoğlu Sokak 25c, Kırklareli, Nepal", "Asartegin", "Eronat", "+90-434-764-01-50", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(4082), "fdd200f3-3de0-403a-a155-293337b481b5", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(4083) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Erzincan", "Aruba, Hollanda", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(4428), "Alpagut.Alniacik@hotmail.com", "İbn-i Sina Sokak 86b, Diyarbakır, Surinam", "Alptuğrul", "Ekşioğlu", "+90-309-416-93-91", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(4429), "d536abe3-1af6-448a-a2e2-7c1a9f0e5827", "1", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(4429) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Bolu", "Yeni Kaledonya, Fransa", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(4753), "Itil_Kavaklioglu70@gmail.com", "Gül Sokak 91a, Uşak, Christmas Adası , Avusturalya", "Bilgiç", "Tazegül", "+90-103-032-2-828", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(4754), "718e5ce3-04c8-456c-9891-a5ffc92ad00b", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(4755) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Kocaeli", "Hindistan", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(5042), "Colman_Akyurek@hotmail.com", "Kekeçoğlu Sokak 414, Elazığ, Sırbistan", "Arbay", "Adal", "+90-211-290-2-967", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(5043), "7fde8bfa-48d7-469f-ad4f-e1c00ed7641e", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(5043) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Tokat", "Rusya Federasyonu", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(5281), "Bayazit_Dusenkalkar@hotmail.com", "Barış Sokak 8, Samsun, Ekvator Ginesi", "Avşar", "Erez", "+90-498-430-4-670", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(5282), "79dfae8c-5537-4ce4-aa14-6ddc723046d6", "0", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(5283) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Karabük", "Amerika Birleşik Devletleri", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(5590), "Kesme82@hotmail.com", "Alparslan Türkeş Bulvarı 36, Isparta, Çek Cumhuriyeti", "Akıbudak", "Paksüt", "+90-096-889-4-799", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(5590), "0c67f4d1-b2c7-4990-a70c-bd4faa95474f", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(5591) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Adana", "Paraguay", new DateTime(2025, 8, 18, 1, 38, 42, 647, DateTimeKind.Local).AddTicks(1354), "Cocukboru_Yildizoglu@yahoo.com", "Sevgi Sokak 37a, Çorum, Benin", "Gelincik", "Avan", "+90-349-010-1-606", new DateTime(2025, 8, 18, 1, 38, 42, 647, DateTimeKind.Local).AddTicks(1363), "addd4c85-a363-4824-96f3-676736bc577f", "1", new DateTime(2025, 8, 18, 1, 38, 42, 647, DateTimeKind.Local).AddTicks(1364) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Karabük", "Moldavya", new DateTime(2025, 8, 18, 1, 38, 42, 649, DateTimeKind.Local).AddTicks(8921), "Bogacuk.Samanci@gmail.com", "Nalbant Sokak 924, Ordu, Tuvalu", "Aykağan", "Ertürk", "+90-338-304-8-289", new DateTime(2025, 8, 18, 1, 38, 42, 649, DateTimeKind.Local).AddTicks(8930), "90387140-a9bc-4c0d-ae32-e119629fd206", "1", new DateTime(2025, 8, 18, 1, 38, 42, 649, DateTimeKind.Local).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 632, DateTimeKind.Local).AddTicks(8135), new DateTime(2025, 8, 18, 1, 38, 42, 632, DateTimeKind.Local).AddTicks(8147), 292.98m, new DateTime(2025, 4, 1, 3, 43, 6, 438, DateTimeKind.Local).AddTicks(6703), "Vero et ut officia enim deserunt et.", "Small Cotton Sausages", "ed7bcb89-35df-4dd0-83b6-9c910d2a8567", 4, new DateTime(2025, 8, 18, 1, 38, 42, 632, DateTimeKind.Local).AddTicks(8149) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 632, DateTimeKind.Local).AddTicks(8813), new DateTime(2025, 8, 18, 1, 38, 42, 632, DateTimeKind.Local).AddTicks(8814), 481.19m, new DateTime(2025, 6, 18, 21, 23, 34, 194, DateTimeKind.Local).AddTicks(244), "Tenetur facilis voluptas at omnis consequuntur incidunt rem enim earum.", "Rustic Rubber Salad", "0b194cbb-0d34-4b36-a70f-1a5fd63a36f3", new DateTime(2025, 8, 18, 1, 38, 42, 632, DateTimeKind.Local).AddTicks(8816) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 632, DateTimeKind.Local).AddTicks(8986), new DateTime(2025, 8, 18, 1, 38, 42, 632, DateTimeKind.Local).AddTicks(8987), 882.78m, new DateTime(2025, 7, 20, 2, 35, 14, 839, DateTimeKind.Local).AddTicks(5056), "İpsa rerum est voluptatem et.", "Licensed Wooden Chair", "948ab479-26de-4e2c-80a3-3de862326b33", 3, new DateTime(2025, 8, 18, 1, 38, 42, 632, DateTimeKind.Local).AddTicks(8988) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 632, DateTimeKind.Local).AddTicks(9192), new DateTime(2025, 8, 18, 1, 38, 42, 632, DateTimeKind.Local).AddTicks(9193), 342.60m, new DateTime(2025, 2, 16, 20, 36, 4, 874, DateTimeKind.Local).AddTicks(448), "Mollitia quia unde accusantium.", "Handcrafted Plastic Table", "e4e6f721-9abe-4fe6-8b7c-a750f4aaa9c2", 8, new DateTime(2025, 8, 18, 1, 38, 42, 632, DateTimeKind.Local).AddTicks(9194) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 632, DateTimeKind.Local).AddTicks(9436), new DateTime(2025, 8, 18, 1, 38, 42, 632, DateTimeKind.Local).AddTicks(9437), 309.98m, new DateTime(2024, 10, 25, 22, 58, 53, 598, DateTimeKind.Local).AddTicks(8388), "Eum sint distinctio a ad qui vero explicabo.", "Sleek Steel Towels", "65249120-92b8-430e-9818-b9d9bdc9e16b", 6, new DateTime(2025, 8, 18, 1, 38, 42, 632, DateTimeKind.Local).AddTicks(9438) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 632, DateTimeKind.Local).AddTicks(9582), new DateTime(2025, 8, 18, 1, 38, 42, 632, DateTimeKind.Local).AddTicks(9583), 136.70m, new DateTime(2024, 10, 16, 8, 20, 41, 583, DateTimeKind.Local).AddTicks(9234), "Porro praesentium assumenda.", "Refined Frozen Shoes", "1354777d-6c41-42a3-99fc-56e4f2adaadf", 1, new DateTime(2025, 8, 18, 1, 38, 42, 632, DateTimeKind.Local).AddTicks(9584) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 632, DateTimeKind.Local).AddTicks(9677), new DateTime(2025, 8, 18, 1, 38, 42, 632, DateTimeKind.Local).AddTicks(9678), 536.92m, new DateTime(2024, 10, 17, 0, 33, 25, 609, DateTimeKind.Local).AddTicks(1910), "Aut autem atque praesentium et similique et nihil voluptatem.", "Handmade Rubber Bacon", "13ba2e3d-815b-4f58-867d-3c0f04a5c683", 10, new DateTime(2025, 8, 18, 1, 38, 42, 632, DateTimeKind.Local).AddTicks(9679) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 632, DateTimeKind.Local).AddTicks(9805), new DateTime(2025, 8, 18, 1, 38, 42, 632, DateTimeKind.Local).AddTicks(9806), 203.25m, new DateTime(2025, 4, 18, 8, 12, 50, 104, DateTimeKind.Local).AddTicks(8713), "Repellendus dolor quasi neque.", "Sleek Concrete Bike", "cafafec6-3e57-4f58-ae64-aa4f8d9266a6", 3, new DateTime(2025, 8, 18, 1, 38, 42, 632, DateTimeKind.Local).AddTicks(9807) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 632, DateTimeKind.Local).AddTicks(9926), new DateTime(2025, 8, 18, 1, 38, 42, 632, DateTimeKind.Local).AddTicks(9927), 246.65m, new DateTime(2024, 12, 1, 1, 28, 17, 404, DateTimeKind.Local).AddTicks(7164), "İpsum rerum necessitatibus autem.", "Tasty Plastic Fish", "4e6789b1-571c-436e-98e0-47d7b794759a", 3, new DateTime(2025, 8, 18, 1, 38, 42, 632, DateTimeKind.Local).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 633, DateTimeKind.Local).AddTicks(52), new DateTime(2025, 8, 18, 1, 38, 42, 633, DateTimeKind.Local).AddTicks(53), 422.39m, new DateTime(2025, 3, 16, 4, 15, 42, 413, DateTimeKind.Local).AddTicks(3982), "Non dicta dolorem fugiat dolorem et.", "Rustic Soft Ball", "a1d1a892-8ccc-4b6c-bdf1-13d49c84f7aa", 1, new DateTime(2025, 8, 18, 1, 38, 42, 633, DateTimeKind.Local).AddTicks(54) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 12, 25, 20, 29, 44, 157, DateTimeKind.Local).AddTicks(982), new DateTime(2026, 12, 12, 2, 32, 59, 149, DateTimeKind.Local).AddTicks(7484), new DateTime(2025, 8, 18, 1, 38, 42, 652, DateTimeKind.Local).AddTicks(7895), 3, new DateTime(2025, 8, 18, 1, 38, 42, 652, DateTimeKind.Local).AddTicks(7896), "b7428030-2d57-4581-9d1c-75afd3bcad27", 36, 2063.65m, new DateTime(2025, 8, 18, 1, 38, 42, 652, DateTimeKind.Local).AddTicks(7897) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 24, 10, 8, 25, 244, DateTimeKind.Local).AddTicks(6771), new DateTime(2026, 11, 12, 11, 4, 9, 266, DateTimeKind.Local).AddTicks(8293), new DateTime(2025, 8, 18, 1, 38, 42, 652, DateTimeKind.Local).AddTicks(8265), 2, new DateTime(2025, 8, 18, 1, 38, 42, 652, DateTimeKind.Local).AddTicks(8265), "6d31cbd2-31de-4298-95ba-05b7f3a909ce", 5, 2279.82m, new DateTime(2025, 8, 18, 1, 38, 42, 652, DateTimeKind.Local).AddTicks(8266) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 9, 8, 10, 30, 16, 717, DateTimeKind.Local).AddTicks(7322), new DateTime(2026, 6, 19, 14, 4, 15, 397, DateTimeKind.Local).AddTicks(5018), new DateTime(2025, 8, 18, 1, 38, 42, 652, DateTimeKind.Local).AddTicks(8312), 5, new DateTime(2025, 8, 18, 1, 38, 42, 652, DateTimeKind.Local).AddTicks(8312), "68b67c67-08c8-4eb7-97eb-421c84a18283", 10, 1826.80m, new DateTime(2025, 8, 18, 1, 38, 42, 652, DateTimeKind.Local).AddTicks(8313) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 11, 21, 9, 14, 40, 896, DateTimeKind.Local).AddTicks(9520), new DateTime(2026, 1, 2, 5, 9, 8, 23, DateTimeKind.Local).AddTicks(7277), new DateTime(2025, 8, 18, 1, 38, 42, 652, DateTimeKind.Local).AddTicks(8374), 8, new DateTime(2025, 8, 18, 1, 38, 42, 652, DateTimeKind.Local).AddTicks(8374), "ca8c323f-c8b6-480a-a0e7-53623634f91f", 18, 2239.35m, new DateTime(2025, 8, 18, 1, 38, 42, 652, DateTimeKind.Local).AddTicks(8375) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 5, 1, 8, 54, 29, 695, DateTimeKind.Local).AddTicks(6662), new DateTime(2027, 1, 19, 21, 51, 29, 782, DateTimeKind.Local).AddTicks(2346), new DateTime(2025, 8, 18, 1, 38, 42, 652, DateTimeKind.Local).AddTicks(8405), 10, new DateTime(2025, 8, 18, 1, 38, 42, 652, DateTimeKind.Local).AddTicks(8406), "74774b2a-7653-4d08-9a29-82a8ccbe0bb3", 41, 2062.52m, new DateTime(2025, 8, 18, 1, 38, 42, 652, DateTimeKind.Local).AddTicks(8406) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 19, 10, 9, 35, 991, DateTimeKind.Local).AddTicks(6790), new DateTime(2027, 1, 28, 20, 35, 48, 841, DateTimeKind.Local).AddTicks(9656), new DateTime(2025, 8, 18, 1, 38, 42, 652, DateTimeKind.Local).AddTicks(8445), 8, new DateTime(2025, 8, 18, 1, 38, 42, 652, DateTimeKind.Local).AddTicks(8446), "954ae598-4e5c-41dc-9d80-bc9ff94717b1", 37, 1835.99m, new DateTime(2025, 8, 18, 1, 38, 42, 652, DateTimeKind.Local).AddTicks(8446) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 11, 25, 21, 13, 28, 497, DateTimeKind.Local).AddTicks(39), new DateTime(2026, 4, 15, 8, 0, 2, 850, DateTimeKind.Local).AddTicks(5899), new DateTime(2025, 8, 18, 1, 38, 42, 652, DateTimeKind.Local).AddTicks(8480), 7, new DateTime(2025, 8, 18, 1, 38, 42, 652, DateTimeKind.Local).AddTicks(8480), "1ff42052-7d7b-42f0-a595-fb0aac01333b", 12, 1551.09m, new DateTime(2025, 8, 18, 1, 38, 42, 652, DateTimeKind.Local).AddTicks(8481) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 6, 9, 13, 28, 32, 463, DateTimeKind.Local).AddTicks(1921), new DateTime(2027, 2, 19, 16, 24, 16, 131, DateTimeKind.Local).AddTicks(1905), new DateTime(2025, 8, 18, 1, 38, 42, 652, DateTimeKind.Local).AddTicks(8515), 3, new DateTime(2025, 8, 18, 1, 38, 42, 652, DateTimeKind.Local).AddTicks(8515), "67f82e2f-d65b-48dd-b9c1-40d8470295a9", 11, 2445.19m, new DateTime(2025, 8, 18, 1, 38, 42, 652, DateTimeKind.Local).AddTicks(8516) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 7, 11, 8, 8, 1, 739, DateTimeKind.Local).AddTicks(452), new DateTime(2027, 6, 26, 2, 2, 7, 738, DateTimeKind.Local).AddTicks(2801), new DateTime(2025, 8, 18, 1, 38, 42, 652, DateTimeKind.Local).AddTicks(8563), 10, new DateTime(2025, 8, 18, 1, 38, 42, 652, DateTimeKind.Local).AddTicks(8564), "063c69b6-d6cd-4157-8e30-71cd3737c1c1", 34, 2336.69m, new DateTime(2025, 8, 18, 1, 38, 42, 652, DateTimeKind.Local).AddTicks(8564) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 8, 18, 13, 18, 341, DateTimeKind.Local).AddTicks(8661), new DateTime(2026, 11, 4, 19, 45, 2, 948, DateTimeKind.Local).AddTicks(5780), new DateTime(2025, 8, 18, 1, 38, 42, 652, DateTimeKind.Local).AddTicks(8620), new DateTime(2025, 8, 18, 1, 38, 42, 652, DateTimeKind.Local).AddTicks(8620), "0346f085-5438-4734-9f89-06c4993b183e", 11, 2002.38m, new DateTime(2025, 8, 18, 1, 38, 42, 652, DateTimeKind.Local).AddTicks(8621) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 456, DateTimeKind.Local).AddTicks(5332), new DateTime(2025, 8, 18, 1, 38, 42, 456, DateTimeKind.Local).AddTicks(5337), "76a47f7a-4cca-468d-b0fb-0f02305e939c", new DateTime(2025, 8, 18, 1, 38, 42, 456, DateTimeKind.Local).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 457, DateTimeKind.Local).AddTicks(6566), new DateTime(2025, 8, 18, 1, 38, 42, 457, DateTimeKind.Local).AddTicks(6570), "ed29b35f-69a3-4bd1-8121-6b66c47312ae", new DateTime(2025, 8, 18, 1, 38, 42, 457, DateTimeKind.Local).AddTicks(6571) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 458, DateTimeKind.Local).AddTicks(5338), new DateTime(2025, 8, 18, 1, 38, 42, 458, DateTimeKind.Local).AddTicks(5341), "1350088f-d210-4492-9ce4-0e2a649cdf8c", new DateTime(2025, 8, 18, 1, 38, 42, 458, DateTimeKind.Local).AddTicks(5341) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 459, DateTimeKind.Local).AddTicks(5879), new DateTime(2025, 8, 18, 1, 38, 42, 459, DateTimeKind.Local).AddTicks(5883), "e10bb8ca-4ac4-4f47-954f-15c74e857352", new DateTime(2025, 8, 18, 1, 38, 42, 459, DateTimeKind.Local).AddTicks(5884) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 460, DateTimeKind.Local).AddTicks(7090), new DateTime(2025, 8, 18, 1, 38, 42, 460, DateTimeKind.Local).AddTicks(7094), "4012171f-8d15-41fd-a451-90bd82ea202c", new DateTime(2025, 8, 18, 1, 38, 42, 460, DateTimeKind.Local).AddTicks(7095) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 461, DateTimeKind.Local).AddTicks(8227), new DateTime(2025, 8, 18, 1, 38, 42, 461, DateTimeKind.Local).AddTicks(8231), "d13ad55d-9db3-4bb5-9a45-0362dd250aa7", new DateTime(2025, 8, 18, 1, 38, 42, 461, DateTimeKind.Local).AddTicks(8231) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 462, DateTimeKind.Local).AddTicks(8437), new DateTime(2025, 8, 18, 1, 38, 42, 462, DateTimeKind.Local).AddTicks(8440), "63af8edb-6fa9-4829-af23-8149a843872e", new DateTime(2025, 8, 18, 1, 38, 42, 462, DateTimeKind.Local).AddTicks(8441) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 463, DateTimeKind.Local).AddTicks(7317), new DateTime(2025, 8, 18, 1, 38, 42, 463, DateTimeKind.Local).AddTicks(7319), "a128d8d9-067c-4089-9b34-5f3595c538ae", new DateTime(2025, 8, 18, 1, 38, 42, 463, DateTimeKind.Local).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 464, DateTimeKind.Local).AddTicks(6852), new DateTime(2025, 8, 18, 1, 38, 42, 464, DateTimeKind.Local).AddTicks(6857), "5e7a6fca-c2b1-45a6-b1e4-cf496696fb98", new DateTime(2025, 8, 18, 1, 38, 42, 464, DateTimeKind.Local).AddTicks(6858) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 465, DateTimeKind.Local).AddTicks(8886), new DateTime(2025, 8, 18, 1, 38, 42, 465, DateTimeKind.Local).AddTicks(8888), "ce0674d9-856a-4953-b96f-553467bed781", new DateTime(2025, 8, 18, 1, 38, 42, 465, DateTimeKind.Local).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 467, DateTimeKind.Local).AddTicks(2705), new DateTime(2025, 8, 18, 1, 38, 42, 467, DateTimeKind.Local).AddTicks(2712), "ec498dac-13a5-484a-b576-002844948e7e", new DateTime(2025, 8, 18, 1, 38, 42, 467, DateTimeKind.Local).AddTicks(2713) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 468, DateTimeKind.Local).AddTicks(9158), new DateTime(2025, 8, 18, 1, 38, 42, 468, DateTimeKind.Local).AddTicks(9164), "0fb542b4-b709-44ae-a8bd-20a41155ca0f", new DateTime(2025, 8, 18, 1, 38, 42, 468, DateTimeKind.Local).AddTicks(9165) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 470, DateTimeKind.Local).AddTicks(6116), new DateTime(2025, 8, 18, 1, 38, 42, 470, DateTimeKind.Local).AddTicks(6119), "79d084f9-157c-46d3-b23e-3202a218d8c7", new DateTime(2025, 8, 18, 1, 38, 42, 470, DateTimeKind.Local).AddTicks(6120) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 471, DateTimeKind.Local).AddTicks(4660), new DateTime(2025, 8, 18, 1, 38, 42, 471, DateTimeKind.Local).AddTicks(4661), "90e25fea-597d-4eed-aad1-b25cf298ea95", new DateTime(2025, 8, 18, 1, 38, 42, 471, DateTimeKind.Local).AddTicks(4661) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 473, DateTimeKind.Local).AddTicks(6193), new DateTime(2025, 8, 18, 1, 38, 42, 473, DateTimeKind.Local).AddTicks(6202), "dd3744e2-7ab1-418a-8143-2a834d952a52", new DateTime(2025, 8, 18, 1, 38, 42, 473, DateTimeKind.Local).AddTicks(6203) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 475, DateTimeKind.Local).AddTicks(5442), new DateTime(2025, 8, 18, 1, 38, 42, 475, DateTimeKind.Local).AddTicks(5449), "69066cb8-8f6f-4500-866e-5ffdd5df61b5", new DateTime(2025, 8, 18, 1, 38, 42, 475, DateTimeKind.Local).AddTicks(5451) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 477, DateTimeKind.Local).AddTicks(4699), new DateTime(2025, 8, 18, 1, 38, 42, 477, DateTimeKind.Local).AddTicks(4706), "d68aa74b-c9c1-402e-a95e-0ed4611287a6", new DateTime(2025, 8, 18, 1, 38, 42, 477, DateTimeKind.Local).AddTicks(4707) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 479, DateTimeKind.Local).AddTicks(2224), new DateTime(2025, 8, 18, 1, 38, 42, 479, DateTimeKind.Local).AddTicks(2231), "70993e5d-551d-49ba-953c-5d5dd8d2a910", new DateTime(2025, 8, 18, 1, 38, 42, 479, DateTimeKind.Local).AddTicks(2232) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 481, DateTimeKind.Local).AddTicks(1177), new DateTime(2025, 8, 18, 1, 38, 42, 481, DateTimeKind.Local).AddTicks(1185), "5ca057e9-09b4-4a8b-ad8e-43e5adaf47a5", new DateTime(2025, 8, 18, 1, 38, 42, 481, DateTimeKind.Local).AddTicks(1186) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 483, DateTimeKind.Local).AddTicks(1917), new DateTime(2025, 8, 18, 1, 38, 42, 483, DateTimeKind.Local).AddTicks(1925), "cc5b9faa-8d60-45ec-a59d-b6a8613c0148", new DateTime(2025, 8, 18, 1, 38, 42, 483, DateTimeKind.Local).AddTicks(1927) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 485, DateTimeKind.Local).AddTicks(6263), new DateTime(2025, 8, 18, 1, 38, 42, 485, DateTimeKind.Local).AddTicks(6274), "5e18958c-08be-42f1-aa9b-1c896251dba2", new DateTime(2025, 8, 18, 1, 38, 42, 485, DateTimeKind.Local).AddTicks(6276) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 488, DateTimeKind.Local).AddTicks(4007), new DateTime(2025, 8, 18, 1, 38, 42, 488, DateTimeKind.Local).AddTicks(4019), "cfb04092-e850-4f43-b596-f95d414325ca", new DateTime(2025, 8, 18, 1, 38, 42, 488, DateTimeKind.Local).AddTicks(4021) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 491, DateTimeKind.Local).AddTicks(2737), new DateTime(2025, 8, 18, 1, 38, 42, 491, DateTimeKind.Local).AddTicks(2749), "900b05f5-7634-4fb4-9d5e-8209bad51060", new DateTime(2025, 8, 18, 1, 38, 42, 491, DateTimeKind.Local).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 494, DateTimeKind.Local).AddTicks(5140), new DateTime(2025, 8, 18, 1, 38, 42, 494, DateTimeKind.Local).AddTicks(5151), "2b7e242a-5ad7-42f0-83e7-8500081c029a", new DateTime(2025, 8, 18, 1, 38, 42, 494, DateTimeKind.Local).AddTicks(5153) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 497, DateTimeKind.Local).AddTicks(4785), new DateTime(2025, 8, 18, 1, 38, 42, 497, DateTimeKind.Local).AddTicks(4797), "1842c59b-e7e0-4fb6-8f2a-9edf8feb4e26", new DateTime(2025, 8, 18, 1, 38, 42, 497, DateTimeKind.Local).AddTicks(4798) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 500, DateTimeKind.Local).AddTicks(197), new DateTime(2025, 8, 18, 1, 38, 42, 500, DateTimeKind.Local).AddTicks(207), "e6fb8c22-5ad3-494d-9af8-a0d85f97f6ed", new DateTime(2025, 8, 18, 1, 38, 42, 500, DateTimeKind.Local).AddTicks(209) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 502, DateTimeKind.Local).AddTicks(1678), new DateTime(2025, 8, 18, 1, 38, 42, 502, DateTimeKind.Local).AddTicks(1687), "f0577982-0f64-45c1-aadf-18880b043833", new DateTime(2025, 8, 18, 1, 38, 42, 502, DateTimeKind.Local).AddTicks(1688) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 504, DateTimeKind.Local).AddTicks(1404), new DateTime(2025, 8, 18, 1, 38, 42, 504, DateTimeKind.Local).AddTicks(1412), "33817d9e-85fd-4306-8336-9bbef4100435", new DateTime(2025, 8, 18, 1, 38, 42, 504, DateTimeKind.Local).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 505, DateTimeKind.Local).AddTicks(8455), new DateTime(2025, 8, 18, 1, 38, 42, 505, DateTimeKind.Local).AddTicks(8461), "7bb51e14-40f1-4caf-aa15-420c71efc15a", new DateTime(2025, 8, 18, 1, 38, 42, 505, DateTimeKind.Local).AddTicks(8462) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 507, DateTimeKind.Local).AddTicks(4389), new DateTime(2025, 8, 18, 1, 38, 42, 507, DateTimeKind.Local).AddTicks(4395), "a090c99f-2a0f-4840-9e83-0fbbc897240b", new DateTime(2025, 8, 18, 1, 38, 42, 507, DateTimeKind.Local).AddTicks(4396) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 509, DateTimeKind.Local).AddTicks(1143), new DateTime(2025, 8, 18, 1, 38, 42, 509, DateTimeKind.Local).AddTicks(1149), "f6b484f9-fa78-4067-8c49-993c13d3eb57", new DateTime(2025, 8, 18, 1, 38, 42, 509, DateTimeKind.Local).AddTicks(1150) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 510, DateTimeKind.Local).AddTicks(5691), new DateTime(2025, 8, 18, 1, 38, 42, 510, DateTimeKind.Local).AddTicks(5697), "6f87e1e1-d3f1-4f73-8a83-d52ca107ce65", new DateTime(2025, 8, 18, 1, 38, 42, 510, DateTimeKind.Local).AddTicks(5698) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 512, DateTimeKind.Local).AddTicks(2660), new DateTime(2025, 8, 18, 1, 38, 42, 512, DateTimeKind.Local).AddTicks(2667), "e9aa326d-b652-48dd-adc0-6ba966d13479", new DateTime(2025, 8, 18, 1, 38, 42, 512, DateTimeKind.Local).AddTicks(2667) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 514, DateTimeKind.Local).AddTicks(2850), new DateTime(2025, 8, 18, 1, 38, 42, 514, DateTimeKind.Local).AddTicks(2858), "e7904c46-318c-434f-8eed-8ab6bbda1d1e", new DateTime(2025, 8, 18, 1, 38, 42, 514, DateTimeKind.Local).AddTicks(2859) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 516, DateTimeKind.Local).AddTicks(5703), new DateTime(2025, 8, 18, 1, 38, 42, 516, DateTimeKind.Local).AddTicks(5712), "ca3a5421-01d3-44ea-ba59-172b5ce747bc", new DateTime(2025, 8, 18, 1, 38, 42, 516, DateTimeKind.Local).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 519, DateTimeKind.Local).AddTicks(2399), new DateTime(2025, 8, 18, 1, 38, 42, 519, DateTimeKind.Local).AddTicks(2409), "dd13df26-385f-4621-8243-3d363b3d8acf", new DateTime(2025, 8, 18, 1, 38, 42, 519, DateTimeKind.Local).AddTicks(2410) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 522, DateTimeKind.Local).AddTicks(10), new DateTime(2025, 8, 18, 1, 38, 42, 522, DateTimeKind.Local).AddTicks(22), "f504c025-46c5-4ce1-a071-80bcec587629", new DateTime(2025, 8, 18, 1, 38, 42, 522, DateTimeKind.Local).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 524, DateTimeKind.Local).AddTicks(4736), new DateTime(2025, 8, 18, 1, 38, 42, 524, DateTimeKind.Local).AddTicks(4747), "fb6331b6-a50c-42ed-b747-439a54601587", new DateTime(2025, 8, 18, 1, 38, 42, 524, DateTimeKind.Local).AddTicks(4748) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 526, DateTimeKind.Local).AddTicks(606), new DateTime(2025, 8, 18, 1, 38, 42, 526, DateTimeKind.Local).AddTicks(620), "9a624daa-9327-4867-a409-7c52adc21f86", new DateTime(2025, 8, 18, 1, 38, 42, 526, DateTimeKind.Local).AddTicks(622) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 529, DateTimeKind.Local).AddTicks(5488), new DateTime(2025, 8, 18, 1, 38, 42, 529, DateTimeKind.Local).AddTicks(5502), "1c05f06e-99c2-4a51-967d-76377e1716ba", new DateTime(2025, 8, 18, 1, 38, 42, 529, DateTimeKind.Local).AddTicks(5503) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 532, DateTimeKind.Local).AddTicks(8529), new DateTime(2025, 8, 18, 1, 38, 42, 532, DateTimeKind.Local).AddTicks(8543), "1f4f1740-4630-43d4-8152-988fc71dc2fc", new DateTime(2025, 8, 18, 1, 38, 42, 532, DateTimeKind.Local).AddTicks(8545) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 535, DateTimeKind.Local).AddTicks(9974), new DateTime(2025, 8, 18, 1, 38, 42, 535, DateTimeKind.Local).AddTicks(9990), "6bb1e1f7-e2a4-472d-9351-af91d3dc4dc7", new DateTime(2025, 8, 18, 1, 38, 42, 535, DateTimeKind.Local).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 539, DateTimeKind.Local).AddTicks(6010), new DateTime(2025, 8, 18, 1, 38, 42, 539, DateTimeKind.Local).AddTicks(6015), "33a33ba3-f9a7-4dc8-8b0b-30aa69d00b36", new DateTime(2025, 8, 18, 1, 38, 42, 539, DateTimeKind.Local).AddTicks(6016) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 540, DateTimeKind.Local).AddTicks(6408), new DateTime(2025, 8, 18, 1, 38, 42, 540, DateTimeKind.Local).AddTicks(6412), "0a48415d-e3d4-43cb-bf67-15cdaeeb9a89", new DateTime(2025, 8, 18, 1, 38, 42, 540, DateTimeKind.Local).AddTicks(6413) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 543, DateTimeKind.Local).AddTicks(1705), new DateTime(2025, 8, 18, 1, 38, 42, 543, DateTimeKind.Local).AddTicks(1718), "8e8e240d-b6a4-454c-a7db-00307d78c3ea", new DateTime(2025, 8, 18, 1, 38, 42, 543, DateTimeKind.Local).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 546, DateTimeKind.Local).AddTicks(3361), new DateTime(2025, 8, 18, 1, 38, 42, 546, DateTimeKind.Local).AddTicks(3373), "73b7985a-6907-44be-b191-88fb570e8453", new DateTime(2025, 8, 18, 1, 38, 42, 546, DateTimeKind.Local).AddTicks(3374) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 549, DateTimeKind.Local).AddTicks(4167), new DateTime(2025, 8, 18, 1, 38, 42, 549, DateTimeKind.Local).AddTicks(4182), "d314f63b-f902-4d55-bd7e-ae73d442c873", new DateTime(2025, 8, 18, 1, 38, 42, 549, DateTimeKind.Local).AddTicks(4184) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 552, DateTimeKind.Local).AddTicks(3962), new DateTime(2025, 8, 18, 1, 38, 42, 552, DateTimeKind.Local).AddTicks(3974), "288db96f-279c-4565-bd06-1c5f31172ed2", new DateTime(2025, 8, 18, 1, 38, 42, 552, DateTimeKind.Local).AddTicks(3976) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 555, DateTimeKind.Local).AddTicks(4240), new DateTime(2025, 8, 18, 1, 38, 42, 555, DateTimeKind.Local).AddTicks(4252), "31c3878e-603f-48c1-a026-67c8b5fc8fb6", new DateTime(2025, 8, 18, 1, 38, 42, 555, DateTimeKind.Local).AddTicks(4254) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 558, DateTimeKind.Local).AddTicks(5071), new DateTime(2025, 8, 18, 1, 38, 42, 558, DateTimeKind.Local).AddTicks(5083), "7b6da79a-edcc-463a-8da9-c9c0668979af", new DateTime(2025, 8, 18, 1, 38, 42, 558, DateTimeKind.Local).AddTicks(5084) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 561, DateTimeKind.Local).AddTicks(7200), new DateTime(2025, 8, 18, 1, 38, 42, 561, DateTimeKind.Local).AddTicks(7212), "d49f3b7f-fde7-4603-976d-907bd1829a57", new DateTime(2025, 8, 18, 1, 38, 42, 561, DateTimeKind.Local).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 564, DateTimeKind.Local).AddTicks(3307), new DateTime(2025, 8, 18, 1, 38, 42, 564, DateTimeKind.Local).AddTicks(3317), "2d5a75f7-d0e6-42cb-91e4-4ed8d33eb79e", new DateTime(2025, 8, 18, 1, 38, 42, 564, DateTimeKind.Local).AddTicks(3318) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 566, DateTimeKind.Local).AddTicks(6054), new DateTime(2025, 8, 18, 1, 38, 42, 566, DateTimeKind.Local).AddTicks(6062), "4fbd881e-5fa7-4511-b2c0-e855f39289f4", new DateTime(2025, 8, 18, 1, 38, 42, 566, DateTimeKind.Local).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 567, DateTimeKind.Local).AddTicks(5857), new DateTime(2025, 8, 18, 1, 38, 42, 567, DateTimeKind.Local).AddTicks(5861), "7f6ec5de-b559-4319-9e98-5d2dbbac04b8", new DateTime(2025, 8, 18, 1, 38, 42, 567, DateTimeKind.Local).AddTicks(5861) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 569, DateTimeKind.Local).AddTicks(536), new DateTime(2025, 8, 18, 1, 38, 42, 569, DateTimeKind.Local).AddTicks(542), "39fa2617-977e-4520-9040-9240f2e0e981", new DateTime(2025, 8, 18, 1, 38, 42, 569, DateTimeKind.Local).AddTicks(543) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 579, DateTimeKind.Local).AddTicks(5800), new DateTime(2025, 8, 18, 1, 38, 42, 579, DateTimeKind.Local).AddTicks(5812), "9d83f71e-27c1-4d11-9c45-c040eee51c47", new DateTime(2025, 8, 18, 1, 38, 42, 579, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 580, DateTimeKind.Local).AddTicks(8121), new DateTime(2025, 8, 18, 1, 38, 42, 580, DateTimeKind.Local).AddTicks(8126), "01ad017d-9606-460b-b97c-1654b7876ea9", new DateTime(2025, 8, 18, 1, 38, 42, 580, DateTimeKind.Local).AddTicks(8127) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 584, DateTimeKind.Local).AddTicks(2335), new DateTime(2025, 8, 18, 1, 38, 42, 584, DateTimeKind.Local).AddTicks(2352), "d5948cc0-86bf-428b-a36d-af4e5b69ccc2", new DateTime(2025, 8, 18, 1, 38, 42, 584, DateTimeKind.Local).AddTicks(2354) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 586, DateTimeKind.Local).AddTicks(5786), new DateTime(2025, 8, 18, 1, 38, 42, 586, DateTimeKind.Local).AddTicks(5791), "c424baf8-7227-446d-910a-bf456ebc02bd", new DateTime(2025, 8, 18, 1, 38, 42, 586, DateTimeKind.Local).AddTicks(5791) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 587, DateTimeKind.Local).AddTicks(6983), new DateTime(2025, 8, 18, 1, 38, 42, 587, DateTimeKind.Local).AddTicks(6987), "4bc49450-b896-4f83-8e1f-30b575b8b03a", new DateTime(2025, 8, 18, 1, 38, 42, 587, DateTimeKind.Local).AddTicks(6988) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 590, DateTimeKind.Local).AddTicks(9699), new DateTime(2025, 8, 18, 1, 38, 42, 590, DateTimeKind.Local).AddTicks(9714), "e9ac4361-45fa-408c-bba8-0c924ab572ef", new DateTime(2025, 8, 18, 1, 38, 42, 590, DateTimeKind.Local).AddTicks(9716) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 592, DateTimeKind.Local).AddTicks(6842), new DateTime(2025, 8, 18, 1, 38, 42, 592, DateTimeKind.Local).AddTicks(6846), "aec87942-8b7d-48bb-b16d-7fb32c6a37ef", new DateTime(2025, 8, 18, 1, 38, 42, 592, DateTimeKind.Local).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 594, DateTimeKind.Local).AddTicks(590), new DateTime(2025, 8, 18, 1, 38, 42, 594, DateTimeKind.Local).AddTicks(601), "9686f4bf-0a46-47f8-bcfa-bef110c426f1", new DateTime(2025, 8, 18, 1, 38, 42, 594, DateTimeKind.Local).AddTicks(603) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 596, DateTimeKind.Local).AddTicks(6327), new DateTime(2025, 8, 18, 1, 38, 42, 596, DateTimeKind.Local).AddTicks(6337), "8ac88bc0-7cc6-4a61-a6d2-1d9c14e60aac", new DateTime(2025, 8, 18, 1, 38, 42, 596, DateTimeKind.Local).AddTicks(6338) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 598, DateTimeKind.Local).AddTicks(7601), new DateTime(2025, 8, 18, 1, 38, 42, 598, DateTimeKind.Local).AddTicks(7610), "45867189-9f41-44cf-936a-61a895d1cf31", new DateTime(2025, 8, 18, 1, 38, 42, 598, DateTimeKind.Local).AddTicks(7619) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 600, DateTimeKind.Local).AddTicks(9561), new DateTime(2025, 8, 18, 1, 38, 42, 600, DateTimeKind.Local).AddTicks(9569), "27993dbe-3a04-497c-91cf-ffc9d66d283e", new DateTime(2025, 8, 18, 1, 38, 42, 600, DateTimeKind.Local).AddTicks(9570) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 603, DateTimeKind.Local).AddTicks(1792), new DateTime(2025, 8, 18, 1, 38, 42, 603, DateTimeKind.Local).AddTicks(1799), "f38c7ce2-d7ef-4dbb-9c0d-be1331e7e860", new DateTime(2025, 8, 18, 1, 38, 42, 603, DateTimeKind.Local).AddTicks(1800) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 605, DateTimeKind.Local).AddTicks(1338), new DateTime(2025, 8, 18, 1, 38, 42, 605, DateTimeKind.Local).AddTicks(1345), "bb943699-031a-4707-8665-8722f7b762fa", new DateTime(2025, 8, 18, 1, 38, 42, 605, DateTimeKind.Local).AddTicks(1346) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 608, DateTimeKind.Local).AddTicks(473), new DateTime(2025, 8, 18, 1, 38, 42, 608, DateTimeKind.Local).AddTicks(488), "54a2657c-4164-4dcf-8f2b-eb0943452ea9", new DateTime(2025, 8, 18, 1, 38, 42, 608, DateTimeKind.Local).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 611, DateTimeKind.Local).AddTicks(3904), new DateTime(2025, 8, 18, 1, 38, 42, 611, DateTimeKind.Local).AddTicks(3910), "7771eaec-2ee2-4fa0-946b-01e3a9a2b011", new DateTime(2025, 8, 18, 1, 38, 42, 611, DateTimeKind.Local).AddTicks(3911) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 613, DateTimeKind.Local).AddTicks(1832), new DateTime(2025, 8, 18, 1, 38, 42, 613, DateTimeKind.Local).AddTicks(1839), "3b97bd4a-a6fb-4b4e-9bbb-f845a8dd9e4d", new DateTime(2025, 8, 18, 1, 38, 42, 613, DateTimeKind.Local).AddTicks(1840) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 615, DateTimeKind.Local).AddTicks(6983), new DateTime(2025, 8, 18, 1, 38, 42, 615, DateTimeKind.Local).AddTicks(6992), "07019c63-b0f0-4d2c-87fa-e0e78525a490", new DateTime(2025, 8, 18, 1, 38, 42, 615, DateTimeKind.Local).AddTicks(6993) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 618, DateTimeKind.Local).AddTicks(6555), new DateTime(2025, 8, 18, 1, 38, 42, 618, DateTimeKind.Local).AddTicks(6566), "389f322a-e8eb-4cf0-9a2a-17d89c4310e6", new DateTime(2025, 8, 18, 1, 38, 42, 618, DateTimeKind.Local).AddTicks(6567) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 621, DateTimeKind.Local).AddTicks(5925), new DateTime(2025, 8, 18, 1, 38, 42, 621, DateTimeKind.Local).AddTicks(5938), "f0e765f5-9059-4e16-925e-976081e64369", new DateTime(2025, 8, 18, 1, 38, 42, 621, DateTimeKind.Local).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 625, DateTimeKind.Local).AddTicks(4835), new DateTime(2025, 8, 18, 1, 38, 42, 625, DateTimeKind.Local).AddTicks(4843), "993528ac-6bd9-4f8e-ad20-b1acdb4d770c", new DateTime(2025, 8, 18, 1, 38, 42, 625, DateTimeKind.Local).AddTicks(4844) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 627, DateTimeKind.Local).AddTicks(8816), new DateTime(2025, 8, 18, 1, 38, 42, 627, DateTimeKind.Local).AddTicks(8824), "7f332569-6f73-4098-868a-7496b3ddbe44", new DateTime(2025, 8, 18, 1, 38, 42, 627, DateTimeKind.Local).AddTicks(8825) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 629, DateTimeKind.Local).AddTicks(6235), new DateTime(2025, 8, 18, 1, 38, 42, 629, DateTimeKind.Local).AddTicks(6237), "72d9c061-506e-4865-84c4-c900e4a9412a", new DateTime(2025, 8, 18, 1, 38, 42, 629, DateTimeKind.Local).AddTicks(6237) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2516), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2516), "7d5aa1e7-0e45-488d-b597-f0fecf4c307b", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2517) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2580), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2581), "e51450c0-c7ce-4df7-a3b7-d2b55a4c8b02", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2581) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2588), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2589), "fefbd6c0-93db-403c-ab6e-bae09d3310fe", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2589) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2595), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2595), "3371747a-5b8c-4302-9d52-d20b5df13c1d", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2612), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2612), "28bb7087-5791-4534-8bb9-045fc1b89a09", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2613) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2620), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2620), "09c04fea-97c8-4d44-b6e4-54bfc27a7e88", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2621) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2626), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2627), "d5420adc-7730-4e27-947d-008f7d087f5c", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2627) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2632), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2632), "051439a1-47a8-4d48-9976-6da3ee1b379e", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2633) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2645), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2646), "e4120491-5b8a-4ebb-a35c-2701110a6fca", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2646) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2653), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2653), "08b993b9-fb82-4d60-b48b-b76ba22da454", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2653) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2659), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2659), "651b77d7-2fee-41cc-894a-b309f4c2f7d3", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2665), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2665), "0bc66750-0177-4711-ba90-020219619c4f", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2666) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2676), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2677), "ff038791-21b4-4374-9dcb-17483ad6b319", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2677) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2682), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2683), "ae09063a-bb38-4210-9e41-fd34ed385f11", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2683) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2689), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2689), "629c36a8-4238-4f53-bca1-6110c290ce11", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2689) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2700), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2701), "fce5ea6f-305a-4de2-beaf-517d2fcd3dcc", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2701) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2711), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2711), "7cd427a7-9f83-438f-aaf3-19b30337c2d6", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2712) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2718), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2718), "8fa41731-ddc2-489f-8d7c-d2e6998fbed0", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2719) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2724), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2724), "ec80f6c2-6bd5-445d-a592-5d70c0f7bc53", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2725) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2730), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2730), "7b6c8b78-1f11-4ede-a78b-2789544aba89", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2742), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2742), "c9e1e263-4699-4b36-8a42-b6933795a14d", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2748), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2749), "82d87989-dc94-44d8-a4d9-092f4a397083", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2749) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2778), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2779), "50b9b8af-7fc8-4193-aa03-38c1addae63a", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2779) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2785), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2785), "ca72c771-d52d-4048-b6fe-c483cbde713c", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2786) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2795), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2796), "5c602739-e33b-43d3-b9c6-8d29afd7b6ad", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2796) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2802), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2802), "23ae0789-e611-41c0-b244-15e819d9c6f4", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2802) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2808), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2808), "14e66d04-2ba8-40a4-bf25-7946ee6f48e6", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2809) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2813), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2814), "ea330128-f42c-49bb-b33f-167938e0664c", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2814) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2830), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2831), "65b01723-6ba6-49f8-bd52-1516e8f18c20", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2831) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2841), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2842), "0f83d86a-e579-4e8c-a669-140c0b4b1604", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2842) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2848), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2849), "bdbd6340-34dd-4e05-8b45-2d0823d97f2f", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2849) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2854), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2855), "d61c2c6c-580f-495e-befd-291fd8c0da58", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2855) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2860), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2861), "4d08cc0c-71e9-43ac-b136-5186b376917b", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2861) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2867), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2867), "ad89a33d-090e-4253-a901-36b53d0d9e67", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2868) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2875), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2875), "0c500a9a-0f49-4202-a571-185f84da2814", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2881), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2881), "fdb7e6d5-dae4-418d-ae13-21fea8049468", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2881) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2888), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2889), "364be4cc-a177-49fa-b8bd-6b165619ac89", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2889) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2894), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2894), "5dcae3b9-d9eb-4529-94f4-8f3ee68293e2", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2895) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2899), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2900), "b528776c-7547-443f-b0af-ef3cf32d976b", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2900) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2905), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2906), "cb99ef0d-ec53-44b7-8070-e2cc25af001c", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2906) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2912), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2912), "fe99fd3a-21a7-4ebf-92f4-96e0d0f0efd2", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2913) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2918), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2918), "1b38bcf7-559b-4124-aee4-a8e512c88c35", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2924), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2924), "6a441883-f482-4300-8e52-376dcd6b5a79", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2930), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2930), "f7f9df5d-4609-494b-8835-04d4f29e36e4", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2931) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2938), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2938), "b7a546fe-6723-48fd-99d8-63996d0c86fc", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2939) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2943), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2943), "c60bbfe7-6f72-4282-9752-c00a25aeb8ca", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2944) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2949), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2950), "bf28273c-fb5f-4268-8713-9e60948b4b88", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2950) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2955), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2956), "3f2960d7-d261-4f2f-bacb-fdfaac847893", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2956) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2962), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2962), "b956c9d6-6614-4f02-8df5-cdb695634c2d", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2962) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2967), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2967), "e289ab84-a4f6-4537-83cc-ea4a307951e7", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2968) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2973), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2973), "d90ba2bf-2ebf-49d3-a20c-ecccf599004f", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3004), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3005), "e7d5b58c-9736-4762-bb7c-4b7f87053fd6", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3005) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3013), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3013), "c7dd4eb4-8c26-4f4d-80a4-d23156517bbd", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3020), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3020), "993ae03a-c516-43c5-8453-2bf060a469cf", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3020) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3026), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3026), "22fecb2c-b45b-4d2e-80ae-c2b7c273f607", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3027) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3032), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3032), "f5a5242e-fec8-42dd-addb-142b6a26f4d9", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3033) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3037), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3038), "7899f089-2090-4e62-8b32-8ed59e9490f4", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3038) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3042), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3043), "c9b03089-4153-4164-9b02-5f80cffbc35a", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3043) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3049), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3050), "64cea5db-98f0-4304-977a-1c612d538992", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3050) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3055), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3055), "e109ab76-25ae-470f-a18a-dcce55afd443", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3056) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3063), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3063), "c83b5402-b102-4f69-8a90-67772f4d687f", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3064) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3068), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3068), "606e829e-7103-4f32-b60c-69d52e1db3e9", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3069) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3074), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3075), "3dafbba2-cc40-46d0-b5e2-e8094acd4cbf", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3075) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3080), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3080), "f3c520c0-9626-47c2-a481-467cf5060cd5", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3081) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3086), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3087), "802228e2-fb2e-4953-b7a4-b2622855c46d", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3087) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3093), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3094), "a00370cf-06b6-401a-b450-fa520166c8ef", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3094) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3100), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3100), "3ec3755b-90f6-4a3b-a5d9-e56ff14086f5", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3101) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3106), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3106), "7e0e6ae2-1283-4d37-8ea0-92c182ea8f2c", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3107) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3113), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3113), "b185317d-d8fd-4344-90d2-8e3bb4c13a07", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3114) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3118), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3118), "fb3e1d4c-91d1-42bf-ac39-602cf49f7ae4", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3119) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3207), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3208), "0eeb962e-af02-4e8b-93ed-3d28cd9e6623", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3208) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3222), 12, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3222), "1ae3651b-980e-46bd-85b7-b8a05bb5bf6e", 1, new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3222) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "ShiftDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3229), 11, new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3230), "ff97c7e0-75d5-4a49-90d8-107cd2af3559", new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3238), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3239), "99f40d0c-caa7-44f7-8a8b-a939f1d12245", 2, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3239) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3247), 12, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3247), "7514ee98-eb0a-434f-a4a2-ba87c73d5b84", 1, new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3247) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3253), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3253), "d360857b-b310-41f7-bb67-892a15ce60ec", 2, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3260), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3260), "0941c3b2-4eba-4a95-86d5-a8dce4a4b831", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3268), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3269), "db20f62b-0075-42a3-8b46-83fc0866e1d7", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3304), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3305), "7058b6a4-5e33-484b-812c-92383b6815c5", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3305) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3311), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3311), "1a542680-1145-4455-adbb-ed4aa8184212", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3312) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3320), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3320), "f9d93e8f-041d-4da1-b809-2bc6592f57b8", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3326), 12, new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3326), "c3dcc35f-0a05-40cd-9abe-d6301c8f6ae7", new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3335), 11, new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3335), "775ef2e6-0509-44b1-8ee4-e69ea41589a9", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3335) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3343), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3344), "0da66123-2b44-4c31-ab1a-4d53129a9367", 1, new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3357), 12, new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3358), "ec348c17-4625-44e8-b37a-cce48809f6d7", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3358) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3367), 11, new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3367), "7f397c13-8e3f-4d84-ae80-5c0405a5f2ec", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3368) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "ShiftDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3376), 12, new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3376), "cc472eb3-550f-4589-b1cf-9f5a0ab8380c", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3376) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3382), 11, new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3382), "a3a60000-0271-4660-923b-b5225f76d977", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3382) });

            migrationBuilder.InsertData(
                table: "Shifts",
                columns: new[] { "Id", "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "SelectedStatus", "ShiftDate", "ShiftType", "StartTime", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 89, new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3390), 11, new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3390), "af104d42-62c6-4b18-8ec7-e1ed7f6d9d73", 0, new DateTime(2025, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3390) },
                    { 90, new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3395), 12, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3395), "1d3d7d05-b15b-42ee-a255-5c2d6cd0ea69", 0, new DateTime(2025, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3396) },
                    { 91, new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3403), 12, new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3403), "1af98477-88ae-46ff-80b8-5d71b9565736", 0, new DateTime(2025, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3403) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Adalineton", "Eritrea", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(4505), "316 Hoppe Rest, North Boydshire, Uzbekistan", "8", "TL730081423610060041068", "578.249.8629 x4123", "Maryam73@yahoo.com", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(4514), "Celestino", "Carroll", "17d87dc4-b246-4047-9666-0108eaed6fef", "73460-4325", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(4514) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Ratkeborough", "Luxembourg", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(5277), "56548 Jerde Route, Destinmouth, Luxembourg", "5", "CH272703078WNV199BK37", "1-818-717-2887 x1787", "Katelin98@gmail.com", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(5278), "Lincoln", "Cremin", "f1073bfa-4776-46b8-8536-4a6a27d59cd0", "11654", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(5278) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Martinebury", "Serbia", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(5557), "390 Velva Bridge, New Stanleyview, Armenia", "2", "ME53068020300500044972", "396-729-6517", "Laurence_Walsh1@gmail.com", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(5558), "Ibrahim", "Mitchell", "3fc8b495-0dfe-44bd-a90e-3b490affb862", "12817", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(5558) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Staceyport", "Bosnia and Herzegovina", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(5792), "616 Brown Loaf, Petraport, Comoros", "FO7270011800903632", "272-858-6882 x45971", "Zion.Mueller@yahoo.com", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(5792), "Emilia", "Schinner", "5aadcc86-f0eb-490d-ba57-21e3d5f7e9c6", "16539-2004", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(5793) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Lake Eula", "Falkland Islands (Malvinas)", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(5988), "399 Feeney Common, Port Opal, Cote d'Ivoire", "6", "TL150242783083003500178", "(943) 702-0489", "Arne97@hotmail.com", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(5989), "Idell", "Barton", "28889211-70c4-4210-908f-cbe3a248fc44", "70703-4174", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(5989) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "New Jazminton", "Sudan", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(6205), "385 Goodwin Lodge, South Pauline, Somalia", "1", "QA67QLYJ7BL3702K0Y25229887313", "(678) 591-9134", "Madyson_Mayer@hotmail.com", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(6206), "Ethel", "Frami", "2c468498-43e7-4f10-97c5-c5211f04e2e9", "01569-3082", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(6206) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Gulgowskiland", "Cayman Islands", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(6435), "9845 Swaniawski Gateway, Predovicmouth, Sudan", "9", "FO5989910004689075", "(721) 551-1722", "Devan37@yahoo.com", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(6435), "Freda", "Kirlin", "948095bb-39f4-43d2-a02c-413c5a75b89d", "23098-2454", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(6436) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Armstrongstad", "Oman", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(6626), "6338 Sanford Neck, East Flo, Bahrain", "2", "AL9200403706108164524J621143", "900.801.0332 x9084", "Luna85@gmail.com", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(6626), "Aisha", "Barton", "6417a6c7-ec91-4b6c-97fe-0cea5e32843c", "88491", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(6626) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "New Tyshawnfurt", "Sao Tome and Principe", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(6820), "058 Lebsack Wells, West Reyes, Kuwait", "8", "LV13ZTWD04773Q452Z909", "209-633-4971 x970", "Ocie.Denesik75@hotmail.com", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(6820), "Santa", "Rice", "7e0e4930-2350-4921-bb09-5e5ba2ac7981", "88612-2408", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(6821) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Revaview", "Burundi", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(7159), "86547 Manuela Summit, North Barney, Lesotho", "2", "SM37Y0034390118362832T74K0H", "(948) 232-9519", "Jessika.Klein50@gmail.com", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(7160), "Filiberto", "Gleason", "b680a380-e9a5-41ae-9848-072bc7276720", "22570", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Mardin", "Maldiv Adaları", new DateTime(2025, 8, 18, 1, 37, 0, 920, DateTimeKind.Local).AddTicks(5769), "Berdibeg.Arslanoglu@yahoo.com", "Kocatepe Caddesi 26b, Siirt, Avustralya", "Burslan", "Kulaksızoğlu", "+90-117-073-23-97", new DateTime(2025, 8, 18, 1, 37, 0, 920, DateTimeKind.Local).AddTicks(5772), "fd30f15d-14d1-423a-9937-9c1e6ae10a71", new DateTime(2025, 8, 18, 1, 37, 0, 920, DateTimeKind.Local).AddTicks(5773) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Kayseri", "Brezilya", new DateTime(2025, 8, 18, 1, 37, 0, 920, DateTimeKind.Local).AddTicks(6528), "Bozok_Ozkok55@yahoo.com", "Sevgi Sokak 26b, Çanakkale, Gürcistan H", "Barkdoğdu", "Egeli", "+90-929-533-7-998", new DateTime(2025, 8, 18, 1, 37, 0, 920, DateTimeKind.Local).AddTicks(6529), "8071a590-34f5-4f4a-8159-790ec87b3e7b", new DateTime(2025, 8, 18, 1, 37, 0, 920, DateTimeKind.Local).AddTicks(6529) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Batman", "Tacikistan", new DateTime(2025, 8, 18, 1, 37, 0, 920, DateTimeKind.Local).AddTicks(6667), "Gunay84@gmail.com", "Saygılı Sokak 5, Aydın, Svaziland", "Bıçkıcı", "Yazıcı", "+90-962-118-98-19", new DateTime(2025, 8, 18, 1, 37, 0, 920, DateTimeKind.Local).AddTicks(6667), "bcae07f3-17a0-4207-97e3-ecce7fcbbb5b", "0", new DateTime(2025, 8, 18, 1, 37, 0, 920, DateTimeKind.Local).AddTicks(6668) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Antalya", "Orta Afrika Cumhuriyeti", new DateTime(2025, 8, 18, 1, 37, 0, 920, DateTimeKind.Local).AddTicks(6767), "Alpulug.Sozeri@yahoo.com", "Namık Kemal Caddesi 45, Rize, Yemen", "Bengi", "Akman", "+90-146-509-28-31", new DateTime(2025, 8, 18, 1, 37, 0, 920, DateTimeKind.Local).AddTicks(6768), "84f6afa9-9a3a-43a1-b9b4-4ff8197fc595", new DateTime(2025, 8, 18, 1, 37, 0, 920, DateTimeKind.Local).AddTicks(6768) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Bilecik", "Yeni Kaledonya, Fransa", new DateTime(2025, 8, 18, 1, 37, 0, 920, DateTimeKind.Local).AddTicks(6875), "Bukduz89@hotmail.com", "Kaldırım Sokak 67, Elazığ, Santa Kitts ve Nevis", "Arslanyabgu", "Özgörkey", "+90-127-281-73-32", new DateTime(2025, 8, 18, 1, 37, 0, 920, DateTimeKind.Local).AddTicks(6876), "3b0d8880-36ec-48bd-b86f-8db54e880e0a", new DateTime(2025, 8, 18, 1, 37, 0, 920, DateTimeKind.Local).AddTicks(6876) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Adıyaman", "Midway Adaları, Amerika", new DateTime(2025, 8, 18, 1, 37, 0, 920, DateTimeKind.Local).AddTicks(6987), "Barboga.Nebioglu@gmail.com", "Menekşe Sokak 177, Adana, Amerikan Samoa", "Gökçen", "Keseroğlu", "+90-540-704-61-87", new DateTime(2025, 8, 18, 1, 37, 0, 920, DateTimeKind.Local).AddTicks(6988), "959d77a4-0c3d-4d76-a842-8693a97771c1", new DateTime(2025, 8, 18, 1, 37, 0, 920, DateTimeKind.Local).AddTicks(6988) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Bilecik", "Mayotte, Fransa", new DateTime(2025, 8, 18, 1, 37, 0, 920, DateTimeKind.Local).AddTicks(7105), "Guvercin_Eronat39@hotmail.com", "Okul Sokak 2, Ağrı, Peru", "Kesme", "Çetin", "+90-647-567-7-398", new DateTime(2025, 8, 18, 1, 37, 0, 920, DateTimeKind.Local).AddTicks(7106), "296f52a2-b0b1-47c5-adad-a59d5088252b", new DateTime(2025, 8, 18, 1, 37, 0, 920, DateTimeKind.Local).AddTicks(7106) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Siirt", "Letonya", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(7262), "Kimizin80@hotmail.com", "Sarıkaya Caddesi 76a, Artvin, Palau Adaları", "Kesme", "Koçoğlu", "+90-890-037-7-649", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(7266), "074fb044-2e43-4cb0-acd8-f95b0e3f83ce", "0", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(7266) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Tekirdağ", "Filistin", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(7740), "Akcakoca35@yahoo.com", "Oğuzhan Sokak 75a, Çorum, Cebelitarık, İngiltere", "Altınkan", "Çağıran", "+90-696-176-46-59", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(7740), "c8c9815e-7900-421f-9ae7-d1077d1595ae", "0", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Bilecik", "Peru", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(7894), "Bagaturcigsi_Kurutluoglu45@yahoo.com", "Barış Sokak 97b, Iğdır, Kuzey Kore", "Alpdoğan", "Akbulut", "+90-643-460-67-68", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(7894), "bf4b572d-ae53-45d8-aa08-b1505eb0c1be", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(7895) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Şanlıurfa", "İspanya", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(8064), "Egemen_Dusenkalkar@gmail.com", "Atatürk Bulvarı 64c, Bayburt, Singapur", "Beğ", "Karadaş", "+90-162-821-5-226", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(8064), "66b8be1d-97a2-45e2-af3f-0c2a85a3485e", "1", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(8065) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Antalya", "Libya", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(8176), "Bindir.Okur52@hotmail.com", "İsmet Attila Caddesi 39, Muğla, Sudan", "Adalan", "Akay", "+90-509-542-1-062", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(8177), "ea1b9570-4d0c-4ac0-b39e-201988efd7a1", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(8177) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Karabük", "Monako", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(8295), "Basci_Abaci@yahoo.com", "Bayır Sokak 37, Bartın, Kongo", "Arsıl", "Akbulut", "+90-242-613-29-59", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(8295), "139b576f-7431-4154-b6a9-9d2400dbc864", "0", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(8295) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Tokat", "Tonga", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(8427), "Bilig.Besok@hotmail.com", "Sağlık Sokak 60, Bilecik, Johnston Atoll, Amerika", "Bukak", "Karaduman", "+90-324-795-77-92", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(8428), "67f9c5a5-10c7-4d4d-ac38-24d456c064c3", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(8428) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "K.maraş", "Azerbaycan", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(8531), "Alpgerey71@gmail.com", "Namık Kemal Caddesi 12, Bilecik, Almanya", "Baltacı", "Kaya ", "+90-263-313-11-33", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(8531), "a0d3ee21-5bbf-4418-a0d6-97c6a9757a40", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(8531) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Burdur", "Kolombiya", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(8639), "Bozkurt.Elmastasoglu58@yahoo.com", "Sevgi Sokak 80, Eskişehir, Güney Georgia ve Güney Sandviç Adaları, İngiltere", "Çocukbörü", "Tüzün", "+90-764-619-29-70", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(8639), "fd685c6b-93ca-49c2-9d5a-4fbda2c24abb", "1", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(8639) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Karabük", "Tayland", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(8773), "Alayunt.Aclan23@hotmail.com", "Sevgi Sokak 03b, Burdur, Arjantin", "Atunçu", "Yetkiner", "+90-592-434-36-31", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(8773), "a976f107-6585-4c5a-93e6-343510767652", "1", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(8773) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "İstanbul", "Benin", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(8876), "Bilgekagan_Babaoglu64@gmail.com", "Menekşe Sokak 74b, Osmaniye, İsrail", "Beltir", "Eronat", "+90-781-288-5-433", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(8876), "ec881ebf-59ef-4a62-bdd4-758a7ac997ed", "0", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(8877) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Denizli", "Anguilla, İngiltere", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(8636), "Apa_Sozeri@hotmail.com", "Nalbant Sokak 7, Eskişehir, Anguilla, İngiltere", "Bağatur", "Özbey", "+90-926-673-16-14", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(8639), "a765bfe4-067e-4e02-b81e-41414cb1124e", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Muş", "İsrail", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(9142), "Kirlangic_Pocan95@hotmail.com", "Nalbant Sokak 1, İstanbul, Pakistan", "Ediz", "Çevik", "+90-417-204-4-257", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(9143), "8da38e9a-b519-4f62-890f-b0d7a4d0e78b", "1", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Bingöl", "Nijerya", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(9303), "Balaka_Sepetci@hotmail.com", "İsmet Attila Caddesi 834, Batman, Eritre", "Bağaturçigşi", "Kocabıyık", "+90-795-536-17-28", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(9304), "47fe4498-bcbf-4401-9300-a397d306c900", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(9304) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Aksaray", "Kongo Demokratik Cumhuriyeti", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(9433), "Gokcicek_Kuday27@yahoo.com", "Sıran Söğüt Sokak 49b, Hatay, Burkina Faso", "Apa", "Karaer", "+90-997-746-69-53", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(9434), "946d0ff8-22ea-4740-ae3b-706c075fd434", "1", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(9434) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Aksaray", "Lesotho", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(9563), "Berendey.Adan@hotmail.com", "Kocatepe Caddesi 47a, Konya, Montserrat", "Baskın", "Türkdoğan", "+90-300-611-2-238", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(9564), "c783fbf6-5c32-4ad1-9baf-219c1c4df54a", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(9564) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Malezya", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(9677), "Baytara.Besok@yahoo.com", "Kocatepe Caddesi 16a, Burdur, Barbados", "Bolun", "Akar ", "+90-179-751-42-63", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(9677), "4615a5d4-8a5c-475e-b974-56ddb04f43b1", "0", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Kars", "Kuveyt", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(9782), "Colman.Onur75@gmail.com", "Nalbant Sokak 93, K.maraş, Monako", "Bağatur", "Mayhoş", "+90-317-700-6-685", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(9783), "5e892c99-a880-45e5-ba68-699949481834", "0", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(9783) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Erzincan", "Kuzey Kore", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(9879), "Edil_Besok@hotmail.com", "Gül Sokak 449, Siirt, Polonya", "Karlıgaç", "Toraman", "+90-067-349-86-58", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(9880), "5b54a469-d460-486b-87d2-415570e1f31c", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Afyon", "Gine", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(9985), "Batuk.Kuzucu@yahoo.com", "Sarıkaya Caddesi 575, Şırnak, Fransız Guyanası", "Alpgerey", "Tunaboylu", "+90-581-566-3-399", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(9986), "c2d992b3-b83f-499b-97ab-6e3b64f42577", "0", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(9986) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Kırklareli", "Çad", new DateTime(2025, 8, 18, 1, 37, 0, 923, DateTimeKind.Local).AddTicks(98), "Ayaci_Baykam@yahoo.com", "Menekşe Sokak 835, Batman, Lübnan", "İnci", "Ekici", "+90-911-479-62-65", new DateTime(2025, 8, 18, 1, 37, 0, 923, DateTimeKind.Local).AddTicks(98), "b21bb670-bd16-468b-9e9c-5cea97831e2a", "1", new DateTime(2025, 8, 18, 1, 37, 0, 923, DateTimeKind.Local).AddTicks(99) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Niğde", "Peru", new DateTime(2025, 8, 18, 1, 37, 0, 923, DateTimeKind.Local).AddTicks(203), "Bartu_Menemencioglu17@gmail.com", "Bayır Sokak 05c, Edirne, Nijerya", "Altay", "Akyüz", "+90-177-766-7-603", new DateTime(2025, 8, 18, 1, 37, 0, 923, DateTimeKind.Local).AddTicks(204), "a6c5bb35-633f-4042-ac25-f93acf7b3782", "0", new DateTime(2025, 8, 18, 1, 37, 0, 923, DateTimeKind.Local).AddTicks(204) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Bolu", "Libya", new DateTime(2025, 8, 18, 1, 37, 0, 924, DateTimeKind.Local).AddTicks(8323), "Buluc9@hotmail.com", "Yunus Emre Sokak 94, Bilecik, Moldavya", "Basanyalavaç", "Yıldırım ", "+90-629-536-7-444", new DateTime(2025, 8, 18, 1, 37, 0, 924, DateTimeKind.Local).AddTicks(8329), "84e11488-4583-472b-bf36-e20daab48a5c", new DateTime(2025, 8, 18, 1, 37, 0, 924, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Bayburt", "Nepal", new DateTime(2025, 8, 18, 1, 37, 0, 924, DateTimeKind.Local).AddTicks(9279), "Agakagan.Arican57@gmail.com", "Sevgi Sokak 9, Burdur, Madagaskar", "Ilaçın", "Abacı", "+90-510-634-6-276", new DateTime(2025, 8, 18, 1, 37, 0, 924, DateTimeKind.Local).AddTicks(9281), "922d0fb0-35ba-4eb3-99f7-9611329af90b", "0", new DateTime(2025, 8, 18, 1, 37, 0, 924, DateTimeKind.Local).AddTicks(9282) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Tunceli", "Guadalup, Fransa", new DateTime(2025, 8, 18, 1, 37, 0, 924, DateTimeKind.Local).AddTicks(9501), "Altankan_Kahveci@yahoo.com", "Ülkü Sokak 37c, Burdur, Tanzanya", "Baykuzu", "Berberoğlu", "+90-183-317-29-09", new DateTime(2025, 8, 18, 1, 37, 0, 924, DateTimeKind.Local).AddTicks(9501), "1e68cbbf-8c96-42f9-b781-009c6d14f355", "1", new DateTime(2025, 8, 18, 1, 37, 0, 924, DateTimeKind.Local).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Antalya", "Virgin Adaları, Amerika", new DateTime(2025, 8, 18, 1, 37, 0, 924, DateTimeKind.Local).AddTicks(9626), "Alpis.Dizdar82@hotmail.com", "Güven Yaka Sokak 67c, Uşak, Vallis ve Futuna, Fransa", "Bağtaş", "Çevik", "+90-926-874-9-112", new DateTime(2025, 8, 18, 1, 37, 0, 924, DateTimeKind.Local).AddTicks(9627), "5ad9398b-b53d-4afd-9073-928950efe5b6", "1", new DateTime(2025, 8, 18, 1, 37, 0, 924, DateTimeKind.Local).AddTicks(9627) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Bolu", "Eritre", new DateTime(2025, 8, 18, 1, 37, 0, 924, DateTimeKind.Local).AddTicks(9761), "Adraman_Aybar19@gmail.com", "Sağlık Sokak 15, Muş, Virgin Adaları, Amerika", "Bilgetamgacı", "Erkekli", "+90-045-482-30-36", new DateTime(2025, 8, 18, 1, 37, 0, 924, DateTimeKind.Local).AddTicks(9762), "1ab098f1-bcf3-46ce-b144-addb9678be5c", "0", new DateTime(2025, 8, 18, 1, 37, 0, 924, DateTimeKind.Local).AddTicks(9762) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Edirne", "Malta", new DateTime(2025, 8, 18, 1, 37, 0, 924, DateTimeKind.Local).AddTicks(9916), "Burulgu88@gmail.com", "30 Ağustos Caddesi 01b, Muğla, Moğolistan", "Boğaçuk", "Tazegül", "+90-501-805-2-700", new DateTime(2025, 8, 18, 1, 37, 0, 924, DateTimeKind.Local).AddTicks(9916), "6d963e6a-ebf2-4ab6-9f14-f00d2bc47be9", new DateTime(2025, 8, 18, 1, 37, 0, 924, DateTimeKind.Local).AddTicks(9916) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Zonguldak", "Liberya", new DateTime(2025, 8, 18, 1, 37, 0, 925, DateTimeKind.Local).AddTicks(60), "Esin_Onur@yahoo.com", "Kaldırım Sokak 38b, Karabük, İsrail", "Balçar", "Gönültaş", "+90-214-452-04-56", new DateTime(2025, 8, 18, 1, 37, 0, 925, DateTimeKind.Local).AddTicks(61), "5491727e-4b0c-48f8-bbad-fc208a215727", new DateTime(2025, 8, 18, 1, 37, 0, 925, DateTimeKind.Local).AddTicks(61) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Antalya", "Peru", new DateTime(2025, 8, 18, 1, 37, 0, 925, DateTimeKind.Local).AddTicks(175), "Beltir_Ozansoy@yahoo.com", "Harman Altı Sokak 08, Rize, Tayland", "Atakağan", "Örge", "+90-671-626-7-019", new DateTime(2025, 8, 18, 1, 37, 0, 925, DateTimeKind.Local).AddTicks(176), "0dfc6cf9-2508-4554-a3a2-c6819f02a036", new DateTime(2025, 8, 18, 1, 37, 0, 925, DateTimeKind.Local).AddTicks(176) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Balıkesir", "Makau (Makao)", new DateTime(2025, 8, 18, 1, 37, 0, 925, DateTimeKind.Local).AddTicks(296), "Baksi32@yahoo.com", "Lütfi Karadirek Caddesi 71a, Manisa, Rusya Federasyonu", "Büke", "Çapanoğlu", "+90-482-566-03-83", new DateTime(2025, 8, 18, 1, 37, 0, 925, DateTimeKind.Local).AddTicks(297), "60fba879-53e3-4642-9b68-4ed693a4b14d", "0", new DateTime(2025, 8, 18, 1, 37, 0, 925, DateTimeKind.Local).AddTicks(297) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Bilecik", "Svaziland", new DateTime(2025, 8, 18, 1, 37, 0, 925, DateTimeKind.Local).AddTicks(428), "Kaynak80@gmail.com", "Bandak Sokak 00b, Çankırı, Monako", "Atlıkağan", "Tuğluk", "+90-188-836-14-66", new DateTime(2025, 8, 18, 1, 37, 0, 925, DateTimeKind.Local).AddTicks(429), "ed34a702-cdf6-499a-b8e8-f54108c1a0e9", new DateTime(2025, 8, 18, 1, 37, 0, 925, DateTimeKind.Local).AddTicks(429) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Ağrı", "Finlandiya", new DateTime(2025, 8, 18, 1, 37, 0, 925, DateTimeKind.Local).AddTicks(538), "Bermek50@gmail.com", "Nalbant Sokak 91c, Bitlis, Papua Yeni Gine", "Aydarkağan", "Dalkıran", "+90-053-169-89-24", new DateTime(2025, 8, 18, 1, 37, 0, 925, DateTimeKind.Local).AddTicks(538), "b9619834-9a8b-41ea-bfad-134b63851061", new DateTime(2025, 8, 18, 1, 37, 0, 925, DateTimeKind.Local).AddTicks(539) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "K.maraş", "Kosova", new DateTime(2025, 8, 18, 1, 37, 0, 925, DateTimeKind.Local).AddTicks(668), "Bukey6@hotmail.com", "Atatürk Bulvarı 078, Karabük, Libya", "Balçar", "Akışık", "+90-575-519-8-301", new DateTime(2025, 8, 18, 1, 37, 0, 925, DateTimeKind.Local).AddTicks(669), "5d92bef9-e6a7-4ca8-bfa0-0057d35bfed0", "1", new DateTime(2025, 8, 18, 1, 37, 0, 925, DateTimeKind.Local).AddTicks(669) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Zonguldak", "Mısır", new DateTime(2025, 8, 18, 1, 37, 0, 925, DateTimeKind.Local).AddTicks(747), "Bayna.Erbay72@yahoo.com", "Tevfik Fikret Caddesi 08a, Eskişehir, Somali", "Beğtegin", "Aybar", "+90-915-987-10-55", new DateTime(2025, 8, 18, 1, 37, 0, 925, DateTimeKind.Local).AddTicks(748), "f795d6e7-a179-43d0-ab53-80ff35da5a2c", new DateTime(2025, 8, 18, 1, 37, 0, 925, DateTimeKind.Local).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Samsun", "Yunanistan", new DateTime(2025, 8, 18, 1, 37, 0, 926, DateTimeKind.Local).AddTicks(1227), "Bolen59@gmail.com", "Sarıkaya Caddesi 246, K.maraş, Çek Cumhuriyeti", "Adraman", "Nalbantoğlu", "+90-193-805-00-86", new DateTime(2025, 8, 18, 1, 37, 0, 926, DateTimeKind.Local).AddTicks(1230), "e1864565-143b-464b-801e-14aac627eb7a", "0", new DateTime(2025, 8, 18, 1, 37, 0, 926, DateTimeKind.Local).AddTicks(1230) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Isparta", "Wake Adaları, Amerika", new DateTime(2025, 8, 18, 1, 37, 0, 927, DateTimeKind.Local).AddTicks(1757), "Bayri_Eksioglu@gmail.com", "Güven Yaka Sokak 79, Sakarya, Umman", "Atıla", "Karabulut", "+90-743-557-6-757", new DateTime(2025, 8, 18, 1, 37, 0, 927, DateTimeKind.Local).AddTicks(1761), "d9b5a220-4e04-46d8-b2ee-aef8682805fe", "0", new DateTime(2025, 8, 18, 1, 37, 0, 927, DateTimeKind.Local).AddTicks(1761) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(183), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(187), 483.65m, new DateTime(2025, 3, 12, 18, 6, 59, 482, DateTimeKind.Local).AddTicks(6779), "Non nam distinctio quidem aut.", "Sleek Rubber Bike", "0b2ee143-5367-4fcb-9273-ff54bfa9051b", 3, new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(188) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(421), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(422), 853.74m, new DateTime(2025, 7, 7, 19, 21, 59, 673, DateTimeKind.Local).AddTicks(4929), "Eligendi eos et debitis et aut omnis.", "Generic Fresh Chicken", "a4cede44-5c50-43a9-a17d-d249cb843bdd", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(469), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(469), 736.54m, new DateTime(2024, 12, 19, 3, 7, 5, 227, DateTimeKind.Local).AddTicks(9308), "Quasi doloribus dolor cum quia vitae.", "Ergonomic Soft Pizza", "d1be3209-01cc-4248-859c-f11b3ac6e1f0", 5, new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(469) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(533), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(534), 621.25m, new DateTime(2025, 1, 23, 14, 45, 5, 816, DateTimeKind.Local).AddTicks(3244), "Enim asperiores voluptas earum vero molestiae est dolores.", "Refined Granite Cheese", "a940b834-1115-438d-bb8c-dcb3aeaf7276", 2, new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(534) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(571), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(572), 235.89m, new DateTime(2024, 8, 27, 19, 21, 27, 362, DateTimeKind.Local).AddTicks(8214), "İmpedit in excepturi doloremque omnis qui voluptatem ea incidunt sit.", "Rustic Concrete Towels", "2bb9eac4-cf56-4559-938f-f7b5d6414bdc", 8, new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(572) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(618), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(618), 580.98m, new DateTime(2024, 9, 3, 17, 40, 3, 765, DateTimeKind.Local).AddTicks(3375), "Molestias nam et iusto asperiores neque tempora exercitationem harum dolorum.", "Ergonomic Cotton Chips", "bd14f1fe-0805-409e-a43c-52fa730fbdf1", 10, new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(619) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(656), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(657), 425.92m, new DateTime(2025, 5, 12, 10, 31, 23, 838, DateTimeKind.Local).AddTicks(68), "Et ut saepe.", "Unbranded Granite Gloves", "a2038223-eef1-4142-ae7c-cf05cdf7b046", 3, new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(657) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(680), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(681), 256.78m, new DateTime(2025, 1, 27, 11, 26, 29, 427, DateTimeKind.Local).AddTicks(6455), "Provident rem molestiae autem accusantium cum ut.", "Small Soft Pants", "b2e4858b-fb8a-4213-b82f-9715181c899a", 10, new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(681) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(732), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(732), 221.50m, new DateTime(2025, 7, 28, 10, 15, 36, 731, DateTimeKind.Local).AddTicks(2599), "Et nam quo placeat architecto ex eaque distinctio explicabo.", "Incredible Metal Cheese", "e39f0c67-1217-4b45-b7db-50c5bd4871c9", 7, new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(733) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(769), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(770), 843.19m, new DateTime(2024, 12, 23, 14, 6, 39, 916, DateTimeKind.Local).AddTicks(9795), "Natus fugiat doloremque.", "Fantastic Concrete Car", "1d7a13db-ae88-417e-851e-c727c6ac7b7a", 2, new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(770) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 7, 20, 6, 47, 37, 428, DateTimeKind.Local).AddTicks(7726), new DateTime(2027, 2, 11, 8, 24, 31, 251, DateTimeKind.Local).AddTicks(4133), new DateTime(2025, 8, 18, 1, 37, 0, 928, DateTimeKind.Local).AddTicks(8516), 1, new DateTime(2025, 8, 18, 1, 37, 0, 928, DateTimeKind.Local).AddTicks(8517), "691842f1-fbe1-4e66-bca7-086450e5d38f", 39, 1534.19m, new DateTime(2025, 8, 18, 1, 37, 0, 928, DateTimeKind.Local).AddTicks(8518) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 7, 8, 1, 52, 59, 880, DateTimeKind.Local).AddTicks(7641), new DateTime(2027, 5, 14, 9, 58, 20, 18, DateTimeKind.Local).AddTicks(4192), new DateTime(2025, 8, 18, 1, 37, 0, 928, DateTimeKind.Local).AddTicks(8733), 10, new DateTime(2025, 8, 18, 1, 37, 0, 928, DateTimeKind.Local).AddTicks(8733), "929b8308-fe62-44e1-a8ab-f2e349ddd01f", 4, 2193.32m, new DateTime(2025, 8, 18, 1, 37, 0, 928, DateTimeKind.Local).AddTicks(8733) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 11, 15, 17, 19, 32, 208, DateTimeKind.Local).AddTicks(9093), new DateTime(2026, 10, 7, 7, 1, 56, 8, DateTimeKind.Local).AddTicks(7125), new DateTime(2025, 8, 18, 1, 37, 0, 928, DateTimeKind.Local).AddTicks(8757), 3, new DateTime(2025, 8, 18, 1, 37, 0, 928, DateTimeKind.Local).AddTicks(8758), "bc6ec1c7-6049-4964-a3b8-c89d3a83975c", 47, 2229.33m, new DateTime(2025, 8, 18, 1, 37, 0, 928, DateTimeKind.Local).AddTicks(8758) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 22, 8, 32, 43, 355, DateTimeKind.Local).AddTicks(6023), new DateTime(2025, 12, 28, 7, 52, 57, 812, DateTimeKind.Local).AddTicks(4286), new DateTime(2025, 8, 18, 1, 37, 0, 928, DateTimeKind.Local).AddTicks(8772), 10, new DateTime(2025, 8, 18, 1, 37, 0, 928, DateTimeKind.Local).AddTicks(8773), "a3b7dcd1-f4e0-4ab5-bd69-1aee364a849f", 12, 2136.50m, new DateTime(2025, 8, 18, 1, 37, 0, 928, DateTimeKind.Local).AddTicks(8773) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 6, 5, 9, 20, 56, 479, DateTimeKind.Local).AddTicks(8337), new DateTime(2027, 3, 15, 9, 39, 22, 724, DateTimeKind.Local).AddTicks(7133), new DateTime(2025, 8, 18, 1, 37, 0, 928, DateTimeKind.Local).AddTicks(8787), 5, new DateTime(2025, 8, 18, 1, 37, 0, 928, DateTimeKind.Local).AddTicks(8788), "b2870afb-8892-463b-ae53-12f42ff33ae7", 24, 2027.92m, new DateTime(2025, 8, 18, 1, 37, 0, 928, DateTimeKind.Local).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 9, 24, 5, 31, 53, 179, DateTimeKind.Local).AddTicks(8242), new DateTime(2025, 11, 4, 14, 55, 58, 563, DateTimeKind.Local).AddTicks(6462), new DateTime(2025, 8, 18, 1, 37, 0, 928, DateTimeKind.Local).AddTicks(8803), 7, new DateTime(2025, 8, 18, 1, 37, 0, 928, DateTimeKind.Local).AddTicks(8803), "d6a9879c-7c6c-4dca-95dd-f6b1dcfc1f2a", 21, 1615.73m, new DateTime(2025, 8, 18, 1, 37, 0, 928, DateTimeKind.Local).AddTicks(8804) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 13, 12, 59, 19, 647, DateTimeKind.Local).AddTicks(5078), new DateTime(2026, 2, 3, 7, 16, 16, 122, DateTimeKind.Local).AddTicks(5777), new DateTime(2025, 8, 18, 1, 37, 0, 928, DateTimeKind.Local).AddTicks(8819), 3, new DateTime(2025, 8, 18, 1, 37, 0, 928, DateTimeKind.Local).AddTicks(8820), "6a7b784f-7186-4c96-8d51-5004225a62fe", 39, 2190.35m, new DateTime(2025, 8, 18, 1, 37, 0, 928, DateTimeKind.Local).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 11, 10, 17, 41, 49, 581, DateTimeKind.Local).AddTicks(5944), new DateTime(2026, 7, 9, 18, 59, 54, 45, DateTimeKind.Local).AddTicks(2802), new DateTime(2025, 8, 18, 1, 37, 0, 928, DateTimeKind.Local).AddTicks(8835), 1, new DateTime(2025, 8, 18, 1, 37, 0, 928, DateTimeKind.Local).AddTicks(8835), "32849744-fdff-4db6-8378-2dc0d49cbebe", 17, 1518.49m, new DateTime(2025, 8, 18, 1, 37, 0, 928, DateTimeKind.Local).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 12, 4, 14, 14, 50, 805, DateTimeKind.Local).AddTicks(2393), new DateTime(2026, 5, 28, 1, 16, 2, 531, DateTimeKind.Local).AddTicks(3081), new DateTime(2025, 8, 18, 1, 37, 0, 928, DateTimeKind.Local).AddTicks(8883), 3, new DateTime(2025, 8, 18, 1, 37, 0, 928, DateTimeKind.Local).AddTicks(8883), "56dd7f71-f57a-43bb-919e-8f8ab1f1885d", 8, 2359.24m, new DateTime(2025, 8, 18, 1, 37, 0, 928, DateTimeKind.Local).AddTicks(8883) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 3, 10, 12, 11, 68, DateTimeKind.Local).AddTicks(6429), new DateTime(2026, 8, 28, 12, 11, 37, 984, DateTimeKind.Local).AddTicks(7534), new DateTime(2025, 8, 18, 1, 37, 0, 928, DateTimeKind.Local).AddTicks(8899), new DateTime(2025, 8, 18, 1, 37, 0, 928, DateTimeKind.Local).AddTicks(8899), "03c86b70-5022-4111-b8c9-d15d33dd4ea9", 46, 1626.39m, new DateTime(2025, 8, 18, 1, 37, 0, 928, DateTimeKind.Local).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 848, DateTimeKind.Local).AddTicks(8920), new DateTime(2025, 8, 18, 1, 37, 0, 848, DateTimeKind.Local).AddTicks(8925), "bab8bafd-0dd9-4a9f-8020-408537ad112c", new DateTime(2025, 8, 18, 1, 37, 0, 848, DateTimeKind.Local).AddTicks(8926) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 849, DateTimeKind.Local).AddTicks(8113), new DateTime(2025, 8, 18, 1, 37, 0, 849, DateTimeKind.Local).AddTicks(8116), "252d4759-09ca-46f4-8da1-d4e05c45ff01", new DateTime(2025, 8, 18, 1, 37, 0, 849, DateTimeKind.Local).AddTicks(8117) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 850, DateTimeKind.Local).AddTicks(7409), new DateTime(2025, 8, 18, 1, 37, 0, 850, DateTimeKind.Local).AddTicks(7413), "67d4d282-4247-4fa9-bf1f-25cb8837f505", new DateTime(2025, 8, 18, 1, 37, 0, 850, DateTimeKind.Local).AddTicks(7413) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 851, DateTimeKind.Local).AddTicks(6490), new DateTime(2025, 8, 18, 1, 37, 0, 851, DateTimeKind.Local).AddTicks(6494), "91ec42ae-d4a2-4423-a948-74aabe8266c8", new DateTime(2025, 8, 18, 1, 37, 0, 851, DateTimeKind.Local).AddTicks(6494) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 852, DateTimeKind.Local).AddTicks(5935), new DateTime(2025, 8, 18, 1, 37, 0, 852, DateTimeKind.Local).AddTicks(5938), "acf9739a-a1ad-4a5c-9fba-f398e94082ec", new DateTime(2025, 8, 18, 1, 37, 0, 852, DateTimeKind.Local).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 853, DateTimeKind.Local).AddTicks(4426), new DateTime(2025, 8, 18, 1, 37, 0, 853, DateTimeKind.Local).AddTicks(4430), "0d9f4ae0-151d-4499-9ff9-4be7e2d7bf4d", new DateTime(2025, 8, 18, 1, 37, 0, 853, DateTimeKind.Local).AddTicks(4430) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 854, DateTimeKind.Local).AddTicks(2878), new DateTime(2025, 8, 18, 1, 37, 0, 854, DateTimeKind.Local).AddTicks(2881), "93beb1d5-3d69-47bd-887c-e55739c8b811", new DateTime(2025, 8, 18, 1, 37, 0, 854, DateTimeKind.Local).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 855, DateTimeKind.Local).AddTicks(1495), new DateTime(2025, 8, 18, 1, 37, 0, 855, DateTimeKind.Local).AddTicks(1497), "2fc6bdf9-5038-4b2e-a548-02d6c85b68f6", new DateTime(2025, 8, 18, 1, 37, 0, 855, DateTimeKind.Local).AddTicks(1498) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 856, DateTimeKind.Local).AddTicks(59), new DateTime(2025, 8, 18, 1, 37, 0, 856, DateTimeKind.Local).AddTicks(62), "cbe0294b-918d-42e6-a882-671d268d7d78", new DateTime(2025, 8, 18, 1, 37, 0, 856, DateTimeKind.Local).AddTicks(63) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 856, DateTimeKind.Local).AddTicks(8608), new DateTime(2025, 8, 18, 1, 37, 0, 856, DateTimeKind.Local).AddTicks(8611), "874415c5-29e4-4a5f-b3c2-50d1906690fc", new DateTime(2025, 8, 18, 1, 37, 0, 856, DateTimeKind.Local).AddTicks(8612) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 857, DateTimeKind.Local).AddTicks(7038), new DateTime(2025, 8, 18, 1, 37, 0, 857, DateTimeKind.Local).AddTicks(7041), "501f01e3-48a6-4887-980e-317e71dfc9cb", new DateTime(2025, 8, 18, 1, 37, 0, 857, DateTimeKind.Local).AddTicks(7041) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 858, DateTimeKind.Local).AddTicks(5511), new DateTime(2025, 8, 18, 1, 37, 0, 858, DateTimeKind.Local).AddTicks(5515), "a064b27a-e91d-42da-9b89-bba8488ed9db", new DateTime(2025, 8, 18, 1, 37, 0, 858, DateTimeKind.Local).AddTicks(5515) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 859, DateTimeKind.Local).AddTicks(6653), new DateTime(2025, 8, 18, 1, 37, 0, 859, DateTimeKind.Local).AddTicks(6657), "0b20cfb7-f92a-4f00-b3bc-7d2384fb60f2", new DateTime(2025, 8, 18, 1, 37, 0, 859, DateTimeKind.Local).AddTicks(6658) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 860, DateTimeKind.Local).AddTicks(7039), new DateTime(2025, 8, 18, 1, 37, 0, 860, DateTimeKind.Local).AddTicks(7041), "9ae471c2-6a57-4cea-9ea6-85c0618ae5ab", new DateTime(2025, 8, 18, 1, 37, 0, 860, DateTimeKind.Local).AddTicks(7041) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 861, DateTimeKind.Local).AddTicks(5820), new DateTime(2025, 8, 18, 1, 37, 0, 861, DateTimeKind.Local).AddTicks(5823), "dffa140a-8ab3-440b-bbce-2c34311b663e", new DateTime(2025, 8, 18, 1, 37, 0, 861, DateTimeKind.Local).AddTicks(5824) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 862, DateTimeKind.Local).AddTicks(4535), new DateTime(2025, 8, 18, 1, 37, 0, 862, DateTimeKind.Local).AddTicks(4537), "42688648-4d6f-469a-942a-c1afde64198e", new DateTime(2025, 8, 18, 1, 37, 0, 862, DateTimeKind.Local).AddTicks(4537) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 864, DateTimeKind.Local).AddTicks(1572), new DateTime(2025, 8, 18, 1, 37, 0, 864, DateTimeKind.Local).AddTicks(1575), "970a0568-93ae-4a87-a0de-68e73dec4d54", new DateTime(2025, 8, 18, 1, 37, 0, 864, DateTimeKind.Local).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 865, DateTimeKind.Local).AddTicks(8710), new DateTime(2025, 8, 18, 1, 37, 0, 865, DateTimeKind.Local).AddTicks(8713), "f7815658-9a61-45d0-9b3f-92ecd386db8f", new DateTime(2025, 8, 18, 1, 37, 0, 865, DateTimeKind.Local).AddTicks(8714) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 866, DateTimeKind.Local).AddTicks(8994), new DateTime(2025, 8, 18, 1, 37, 0, 866, DateTimeKind.Local).AddTicks(8995), "d8e896b5-0eb8-413a-b1e8-86dda5e7d726", new DateTime(2025, 8, 18, 1, 37, 0, 866, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 867, DateTimeKind.Local).AddTicks(8974), new DateTime(2025, 8, 18, 1, 37, 0, 867, DateTimeKind.Local).AddTicks(8978), "1be0e9ca-024f-4f4c-a63c-08352529c36e", new DateTime(2025, 8, 18, 1, 37, 0, 867, DateTimeKind.Local).AddTicks(8979) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 868, DateTimeKind.Local).AddTicks(8148), new DateTime(2025, 8, 18, 1, 37, 0, 868, DateTimeKind.Local).AddTicks(8151), "63622d1c-2d89-4db1-8332-d4fc7dab3a61", new DateTime(2025, 8, 18, 1, 37, 0, 868, DateTimeKind.Local).AddTicks(8152) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 869, DateTimeKind.Local).AddTicks(6858), new DateTime(2025, 8, 18, 1, 37, 0, 869, DateTimeKind.Local).AddTicks(6861), "61add857-db34-4477-98de-4eefa3737a0a", new DateTime(2025, 8, 18, 1, 37, 0, 869, DateTimeKind.Local).AddTicks(6862) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 870, DateTimeKind.Local).AddTicks(5347), new DateTime(2025, 8, 18, 1, 37, 0, 870, DateTimeKind.Local).AddTicks(5350), "5e93aed1-8c44-4a2e-a0ac-9d8ffe92aa36", new DateTime(2025, 8, 18, 1, 37, 0, 870, DateTimeKind.Local).AddTicks(5351) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 871, DateTimeKind.Local).AddTicks(4060), new DateTime(2025, 8, 18, 1, 37, 0, 871, DateTimeKind.Local).AddTicks(4063), "686bc09d-01c3-4c29-835b-972b4860d083", new DateTime(2025, 8, 18, 1, 37, 0, 871, DateTimeKind.Local).AddTicks(4064) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 872, DateTimeKind.Local).AddTicks(2771), new DateTime(2025, 8, 18, 1, 37, 0, 872, DateTimeKind.Local).AddTicks(2774), "c97006a6-a3f6-4acf-9681-2468d2f300a7", new DateTime(2025, 8, 18, 1, 37, 0, 872, DateTimeKind.Local).AddTicks(2775) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 873, DateTimeKind.Local).AddTicks(1568), new DateTime(2025, 8, 18, 1, 37, 0, 873, DateTimeKind.Local).AddTicks(1569), "dfb8a085-c136-490b-ae3f-b19728200628", new DateTime(2025, 8, 18, 1, 37, 0, 873, DateTimeKind.Local).AddTicks(1569) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 874, DateTimeKind.Local).AddTicks(698), new DateTime(2025, 8, 18, 1, 37, 0, 874, DateTimeKind.Local).AddTicks(701), "fa0ea506-a4f1-4e2a-9dac-82921653e482", new DateTime(2025, 8, 18, 1, 37, 0, 874, DateTimeKind.Local).AddTicks(701) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 874, DateTimeKind.Local).AddTicks(9840), new DateTime(2025, 8, 18, 1, 37, 0, 874, DateTimeKind.Local).AddTicks(9842), "ad5ef5ee-dbeb-4a7b-b09b-280f4fcf88e1", new DateTime(2025, 8, 18, 1, 37, 0, 874, DateTimeKind.Local).AddTicks(9843) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 875, DateTimeKind.Local).AddTicks(9277), new DateTime(2025, 8, 18, 1, 37, 0, 875, DateTimeKind.Local).AddTicks(9280), "eddfcab0-7d2b-4d97-989b-02cd52f333a2", new DateTime(2025, 8, 18, 1, 37, 0, 875, DateTimeKind.Local).AddTicks(9281) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 876, DateTimeKind.Local).AddTicks(8045), new DateTime(2025, 8, 18, 1, 37, 0, 876, DateTimeKind.Local).AddTicks(8048), "9f184da3-c595-436c-aa23-fe61a2b45855", new DateTime(2025, 8, 18, 1, 37, 0, 876, DateTimeKind.Local).AddTicks(8048) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 877, DateTimeKind.Local).AddTicks(6709), new DateTime(2025, 8, 18, 1, 37, 0, 877, DateTimeKind.Local).AddTicks(6712), "ff96e564-6b96-433a-8fa6-cf36790e4203", new DateTime(2025, 8, 18, 1, 37, 0, 877, DateTimeKind.Local).AddTicks(6713) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 878, DateTimeKind.Local).AddTicks(5377), new DateTime(2025, 8, 18, 1, 37, 0, 878, DateTimeKind.Local).AddTicks(5381), "7d5c7d7c-a5a9-4646-8d6e-ebe4c06759ff", new DateTime(2025, 8, 18, 1, 37, 0, 878, DateTimeKind.Local).AddTicks(5381) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 879, DateTimeKind.Local).AddTicks(4169), new DateTime(2025, 8, 18, 1, 37, 0, 879, DateTimeKind.Local).AddTicks(4172), "17113d2f-e23a-47d2-9821-ef4cabcd1541", new DateTime(2025, 8, 18, 1, 37, 0, 879, DateTimeKind.Local).AddTicks(4172) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 880, DateTimeKind.Local).AddTicks(3180), new DateTime(2025, 8, 18, 1, 37, 0, 880, DateTimeKind.Local).AddTicks(3183), "315086a2-1f5f-4565-9ff3-0b1cebffc085", new DateTime(2025, 8, 18, 1, 37, 0, 880, DateTimeKind.Local).AddTicks(3183) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 881, DateTimeKind.Local).AddTicks(1497), new DateTime(2025, 8, 18, 1, 37, 0, 881, DateTimeKind.Local).AddTicks(1498), "6d352e5b-ca6b-47d9-ac3b-724edc32b1d2", new DateTime(2025, 8, 18, 1, 37, 0, 881, DateTimeKind.Local).AddTicks(1499) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 882, DateTimeKind.Local).AddTicks(95), new DateTime(2025, 8, 18, 1, 37, 0, 882, DateTimeKind.Local).AddTicks(98), "a439cff7-8e91-437f-86da-651022b735be", new DateTime(2025, 8, 18, 1, 37, 0, 882, DateTimeKind.Local).AddTicks(98) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 882, DateTimeKind.Local).AddTicks(8833), new DateTime(2025, 8, 18, 1, 37, 0, 882, DateTimeKind.Local).AddTicks(8836), "fc966325-448e-4f76-be87-3679f8a1e7c6", new DateTime(2025, 8, 18, 1, 37, 0, 882, DateTimeKind.Local).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 883, DateTimeKind.Local).AddTicks(7682), new DateTime(2025, 8, 18, 1, 37, 0, 883, DateTimeKind.Local).AddTicks(7685), "326da315-67bb-4a9f-a258-a737b3042513", new DateTime(2025, 8, 18, 1, 37, 0, 883, DateTimeKind.Local).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 884, DateTimeKind.Local).AddTicks(6171), new DateTime(2025, 8, 18, 1, 37, 0, 884, DateTimeKind.Local).AddTicks(6174), "8394e192-f33a-45d8-8e56-b149260b21c2", new DateTime(2025, 8, 18, 1, 37, 0, 884, DateTimeKind.Local).AddTicks(6175) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 885, DateTimeKind.Local).AddTicks(4730), new DateTime(2025, 8, 18, 1, 37, 0, 885, DateTimeKind.Local).AddTicks(4733), "4fe9fc83-0b8f-41ef-8471-9942c3b97029", new DateTime(2025, 8, 18, 1, 37, 0, 885, DateTimeKind.Local).AddTicks(4733) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 886, DateTimeKind.Local).AddTicks(3188), new DateTime(2025, 8, 18, 1, 37, 0, 886, DateTimeKind.Local).AddTicks(3192), "44f88617-c030-4b44-beb3-d5aff0ce7a3c", new DateTime(2025, 8, 18, 1, 37, 0, 886, DateTimeKind.Local).AddTicks(3192) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 887, DateTimeKind.Local).AddTicks(1820), new DateTime(2025, 8, 18, 1, 37, 0, 887, DateTimeKind.Local).AddTicks(1821), "e26d5cc7-eed1-4949-8a93-aa65afbbeee1", new DateTime(2025, 8, 18, 1, 37, 0, 887, DateTimeKind.Local).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 888, DateTimeKind.Local).AddTicks(506), new DateTime(2025, 8, 18, 1, 37, 0, 888, DateTimeKind.Local).AddTicks(510), "61f8c8ed-9610-4a26-a31a-a57ee0133860", new DateTime(2025, 8, 18, 1, 37, 0, 888, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 888, DateTimeKind.Local).AddTicks(9322), new DateTime(2025, 8, 18, 1, 37, 0, 888, DateTimeKind.Local).AddTicks(9325), "437aa282-374e-4751-9e34-bfb020396854", new DateTime(2025, 8, 18, 1, 37, 0, 888, DateTimeKind.Local).AddTicks(9326) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 889, DateTimeKind.Local).AddTicks(7901), new DateTime(2025, 8, 18, 1, 37, 0, 889, DateTimeKind.Local).AddTicks(7904), "89ffe699-1b18-4372-97f1-055c2b74b06d", new DateTime(2025, 8, 18, 1, 37, 0, 889, DateTimeKind.Local).AddTicks(7904) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 890, DateTimeKind.Local).AddTicks(6534), new DateTime(2025, 8, 18, 1, 37, 0, 890, DateTimeKind.Local).AddTicks(6537), "1e230181-9291-4252-a2b8-d78eb005b42b", new DateTime(2025, 8, 18, 1, 37, 0, 890, DateTimeKind.Local).AddTicks(6537) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 891, DateTimeKind.Local).AddTicks(5895), new DateTime(2025, 8, 18, 1, 37, 0, 891, DateTimeKind.Local).AddTicks(5899), "284cb70f-b492-4a2f-b509-4b61e372ed0c", new DateTime(2025, 8, 18, 1, 37, 0, 891, DateTimeKind.Local).AddTicks(5899) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 892, DateTimeKind.Local).AddTicks(4608), new DateTime(2025, 8, 18, 1, 37, 0, 892, DateTimeKind.Local).AddTicks(4611), "a63b799b-19bf-4262-87af-6418c855cf91", new DateTime(2025, 8, 18, 1, 37, 0, 892, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 893, DateTimeKind.Local).AddTicks(3151), new DateTime(2025, 8, 18, 1, 37, 0, 893, DateTimeKind.Local).AddTicks(3154), "8dd371b2-9cc4-4994-9cdf-d8b8227765c4", new DateTime(2025, 8, 18, 1, 37, 0, 893, DateTimeKind.Local).AddTicks(3154) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 894, DateTimeKind.Local).AddTicks(1594), new DateTime(2025, 8, 18, 1, 37, 0, 894, DateTimeKind.Local).AddTicks(1595), "be739dc3-620a-4acb-bfcd-6ca0d9e009c1", new DateTime(2025, 8, 18, 1, 37, 0, 894, DateTimeKind.Local).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 895, DateTimeKind.Local).AddTicks(537), new DateTime(2025, 8, 18, 1, 37, 0, 895, DateTimeKind.Local).AddTicks(541), "206c033d-eaeb-4fda-ad3b-7f76c92bf835", new DateTime(2025, 8, 18, 1, 37, 0, 895, DateTimeKind.Local).AddTicks(541) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 895, DateTimeKind.Local).AddTicks(9321), new DateTime(2025, 8, 18, 1, 37, 0, 895, DateTimeKind.Local).AddTicks(9324), "f47d2e9e-bbc4-4d7e-8135-519392a0f1ea", new DateTime(2025, 8, 18, 1, 37, 0, 895, DateTimeKind.Local).AddTicks(9325) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 896, DateTimeKind.Local).AddTicks(8277), new DateTime(2025, 8, 18, 1, 37, 0, 896, DateTimeKind.Local).AddTicks(8281), "871e8c0a-0d6c-4f93-8d06-3f544ba507a4", new DateTime(2025, 8, 18, 1, 37, 0, 896, DateTimeKind.Local).AddTicks(8282) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 897, DateTimeKind.Local).AddTicks(7413), new DateTime(2025, 8, 18, 1, 37, 0, 897, DateTimeKind.Local).AddTicks(7416), "f5e3d04c-ee8f-464b-b4ca-75fbc3528c14", new DateTime(2025, 8, 18, 1, 37, 0, 897, DateTimeKind.Local).AddTicks(7417) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 898, DateTimeKind.Local).AddTicks(6216), new DateTime(2025, 8, 18, 1, 37, 0, 898, DateTimeKind.Local).AddTicks(6219), "aa0abbfc-8819-4902-9783-6f2c5e50ecc1", new DateTime(2025, 8, 18, 1, 37, 0, 898, DateTimeKind.Local).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 899, DateTimeKind.Local).AddTicks(5328), new DateTime(2025, 8, 18, 1, 37, 0, 899, DateTimeKind.Local).AddTicks(5332), "3d857599-6bc0-4368-a51d-95d0a461c6a5", new DateTime(2025, 8, 18, 1, 37, 0, 899, DateTimeKind.Local).AddTicks(5332) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 900, DateTimeKind.Local).AddTicks(4504), new DateTime(2025, 8, 18, 1, 37, 0, 900, DateTimeKind.Local).AddTicks(4507), "f90542cf-7900-44d3-8175-889e8d3d8473", new DateTime(2025, 8, 18, 1, 37, 0, 900, DateTimeKind.Local).AddTicks(4508) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 901, DateTimeKind.Local).AddTicks(3183), new DateTime(2025, 8, 18, 1, 37, 0, 901, DateTimeKind.Local).AddTicks(3186), "3d85b9d5-1279-4eed-b4ad-99484b7ddf20", new DateTime(2025, 8, 18, 1, 37, 0, 901, DateTimeKind.Local).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 902, DateTimeKind.Local).AddTicks(1400), new DateTime(2025, 8, 18, 1, 37, 0, 902, DateTimeKind.Local).AddTicks(1402), "fa96bf80-d1d5-4049-ac63-623cba7d21e6", new DateTime(2025, 8, 18, 1, 37, 0, 902, DateTimeKind.Local).AddTicks(1403) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 903, DateTimeKind.Local).AddTicks(151), new DateTime(2025, 8, 18, 1, 37, 0, 903, DateTimeKind.Local).AddTicks(154), "4989bfc3-03c3-40d6-9d5a-f935429ff783", new DateTime(2025, 8, 18, 1, 37, 0, 903, DateTimeKind.Local).AddTicks(155) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 903, DateTimeKind.Local).AddTicks(8977), new DateTime(2025, 8, 18, 1, 37, 0, 903, DateTimeKind.Local).AddTicks(8979), "1611c456-2d06-4d73-aa3c-b6400a4a11b5", new DateTime(2025, 8, 18, 1, 37, 0, 903, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 904, DateTimeKind.Local).AddTicks(7655), new DateTime(2025, 8, 18, 1, 37, 0, 904, DateTimeKind.Local).AddTicks(7658), "a8927e30-3aed-47c2-8c9c-cbeb54d4087e", new DateTime(2025, 8, 18, 1, 37, 0, 904, DateTimeKind.Local).AddTicks(7659) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 905, DateTimeKind.Local).AddTicks(6278), new DateTime(2025, 8, 18, 1, 37, 0, 905, DateTimeKind.Local).AddTicks(6281), "423a5752-3927-4412-980e-e21e6239fc9a", new DateTime(2025, 8, 18, 1, 37, 0, 905, DateTimeKind.Local).AddTicks(6282) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 906, DateTimeKind.Local).AddTicks(4903), new DateTime(2025, 8, 18, 1, 37, 0, 906, DateTimeKind.Local).AddTicks(4907), "b19bd8ce-de53-4b8b-84b9-82f8199282ae", new DateTime(2025, 8, 18, 1, 37, 0, 906, DateTimeKind.Local).AddTicks(4907) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 907, DateTimeKind.Local).AddTicks(3784), new DateTime(2025, 8, 18, 1, 37, 0, 907, DateTimeKind.Local).AddTicks(3788), "23ef51dc-6b71-4e8a-8d8f-7d72ad089bb2", new DateTime(2025, 8, 18, 1, 37, 0, 907, DateTimeKind.Local).AddTicks(3788) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 908, DateTimeKind.Local).AddTicks(2429), new DateTime(2025, 8, 18, 1, 37, 0, 908, DateTimeKind.Local).AddTicks(2432), "ab6c8103-7a6d-43d0-8daf-bbabe04ed615", new DateTime(2025, 8, 18, 1, 37, 0, 908, DateTimeKind.Local).AddTicks(2433) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 909, DateTimeKind.Local).AddTicks(688), new DateTime(2025, 8, 18, 1, 37, 0, 909, DateTimeKind.Local).AddTicks(690), "1c0cb2b1-86d8-47c8-ad19-c72456f3a60e", new DateTime(2025, 8, 18, 1, 37, 0, 909, DateTimeKind.Local).AddTicks(690) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 909, DateTimeKind.Local).AddTicks(9263), new DateTime(2025, 8, 18, 1, 37, 0, 909, DateTimeKind.Local).AddTicks(9266), "f4f6867f-b128-4942-b5ca-a2f0c8390ccd", new DateTime(2025, 8, 18, 1, 37, 0, 909, DateTimeKind.Local).AddTicks(9267) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 910, DateTimeKind.Local).AddTicks(7906), new DateTime(2025, 8, 18, 1, 37, 0, 910, DateTimeKind.Local).AddTicks(7909), "d5a9a78a-b838-497c-a6f5-59f01e03d63d", new DateTime(2025, 8, 18, 1, 37, 0, 910, DateTimeKind.Local).AddTicks(7910) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 911, DateTimeKind.Local).AddTicks(6495), new DateTime(2025, 8, 18, 1, 37, 0, 911, DateTimeKind.Local).AddTicks(6498), "50dcda5f-81d2-4767-a686-55dc639e235a", new DateTime(2025, 8, 18, 1, 37, 0, 911, DateTimeKind.Local).AddTicks(6499) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 912, DateTimeKind.Local).AddTicks(5232), new DateTime(2025, 8, 18, 1, 37, 0, 912, DateTimeKind.Local).AddTicks(5235), "a334bfc3-88f3-4b1a-a8fd-03a13f2be44e", new DateTime(2025, 8, 18, 1, 37, 0, 912, DateTimeKind.Local).AddTicks(5236) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 913, DateTimeKind.Local).AddTicks(3808), new DateTime(2025, 8, 18, 1, 37, 0, 913, DateTimeKind.Local).AddTicks(3811), "e7f23e33-e863-4473-a883-62938512632c", new DateTime(2025, 8, 18, 1, 37, 0, 913, DateTimeKind.Local).AddTicks(3811) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 914, DateTimeKind.Local).AddTicks(2603), new DateTime(2025, 8, 18, 1, 37, 0, 914, DateTimeKind.Local).AddTicks(2606), "fa1ceb4e-0687-4a53-a52b-2bc6d851ddc9", new DateTime(2025, 8, 18, 1, 37, 0, 914, DateTimeKind.Local).AddTicks(2607) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 915, DateTimeKind.Local).AddTicks(1608), new DateTime(2025, 8, 18, 1, 37, 0, 915, DateTimeKind.Local).AddTicks(1611), "5dd59487-06a9-476a-812b-52231d539252", new DateTime(2025, 8, 18, 1, 37, 0, 915, DateTimeKind.Local).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 916, DateTimeKind.Local).AddTicks(779), new DateTime(2025, 8, 18, 1, 37, 0, 916, DateTimeKind.Local).AddTicks(782), "78f8c4a6-194a-4c50-9af3-fb11ae43c295", new DateTime(2025, 8, 18, 1, 37, 0, 916, DateTimeKind.Local).AddTicks(782) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 916, DateTimeKind.Local).AddTicks(9383), new DateTime(2025, 8, 18, 1, 37, 0, 916, DateTimeKind.Local).AddTicks(9386), "3651bb0e-4e9d-459e-87c5-07e862fb4703", new DateTime(2025, 8, 18, 1, 37, 0, 916, DateTimeKind.Local).AddTicks(9386) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 917, DateTimeKind.Local).AddTicks(8080), new DateTime(2025, 8, 18, 1, 37, 0, 917, DateTimeKind.Local).AddTicks(8083), "006ded63-4e76-479f-b298-8bf80501ada9", new DateTime(2025, 8, 18, 1, 37, 0, 917, DateTimeKind.Local).AddTicks(8084) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(2948), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(2948), "3184395d-ed2e-4404-8728-a39fed1e1835", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(2982), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(2982), "251c3242-c1e9-4d66-a116-e7f490fabe1d", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(2988), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(2988), "114d618e-2e36-4b13-8984-63fafd5563f5", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(2992), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(2993), "9a66f406-3684-428b-a8da-bdc3c978c9e1", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3002), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3002), "997e2fdc-c757-4761-b795-fc25c849aa23", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3002) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3007), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3007), "b920617a-bd15-4a67-bd1f-a23639413f40", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3007) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3015), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3015), "1df861d4-f2e4-465d-a03d-87ca554ddafb", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3016) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3019), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3020), "7238a964-946a-4a3f-99f9-b1dc6054a5a7", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3020) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3027), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3027), "445a3a6d-d0c1-420c-8333-3b3d59fd6dfd", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3027) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3032), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3032), "b2340ec2-e09b-4a9e-a89c-d524132bd405", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3032) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3036), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3036), "e1f6dfa8-9bc9-4b7f-8d1f-a4922166726a", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3037) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3040), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3040), "f6aaab05-466c-4e36-b3a5-3326f3bb8717", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3041) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3075), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3075), "c6d485be-cda0-4359-a0f5-cfc965699488", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3075) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3080), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3080), "8ad83259-5b77-4152-b462-bfcdd89029be", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3086), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3086), "fd07b2c2-739b-4028-a07d-04c5580fd9c5", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3086) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3090), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3090), "790a1c83-f213-4cc1-b097-9dbbd9df6617", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3090) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3097), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3097), "25957a12-7b94-4348-a127-41b736b23280", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3097) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3102), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3102), "f8a6f300-6a2b-490b-ad1d-72beb31cda1a", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3102) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3107), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3107), "3a07f6cd-bae6-4572-8578-2d4c8bca0210", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3107) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3111), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3111), "e59554ce-135f-42fb-b8e0-5f34595ec35c", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3111) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3117), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3118), "6f9845f5-75b3-4c98-9620-1429664e0d5e", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3118) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3122), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3122), "2c2312c1-7875-4965-a660-3d1555c3ed0f", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3122) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3128), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3128), "402be473-b850-4ce3-b0f9-915c083faaff", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3128) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3132), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3132), "c062764e-13f4-4d56-85fa-0d330c19882c", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3133) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3139), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3140), "1f379b7b-5e36-4c4e-aaa3-500361d66f4e", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3140) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3143), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3144), "2e83a98c-4585-4978-ab1c-99cb71e62ab2", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3148), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3148), "58b14e40-1c2d-4389-921b-f17da2bd1aec", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3152), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3152), "54f58d5a-09f1-43c7-b33b-d885d4fe1e48", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3152) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3162), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3162), "d1337846-b33d-4f32-899c-c5f3fd59628f", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3163) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3167), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3167), "6657ecea-5aa2-4cf9-8135-629729e730d9", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3168) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3173), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3174), "d913e19c-059c-49ff-ae64-24d2c8180132", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3177), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3178), "4b92b40a-e1f6-4b6b-a8e5-4a4722bdb898", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3178) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3182), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3182), "4a3b233f-dca6-40dc-9969-ac83ab6e9c57", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3182) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3187), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3187), "209eb4ee-afb5-4500-8d56-add80fd37308", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3187) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3192), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3192), "d275ec2c-9947-4c3c-ba60-2449f82f6ddb", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3192) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3196), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3196), "dad38d35-c41c-45f4-a3d8-8f48b1a43f7e", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3197) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3201), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3201), "f3a10d1e-d50e-4e58-be55-0691dd616be1", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3202) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3231), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3231), "cea29569-ed4d-4a5f-b172-4f9bc435436c", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3231) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3237), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3238), "2590aaf9-de33-486d-bbfd-9a52eec0194e", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3242), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3242), "502e2d44-1761-43aa-bd11-ed3d334a1196", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3247), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3247), "de73f892-497d-433f-98a3-3d888ebf1442", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3247) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3252), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3252), "f1384514-41ac-4cc5-81a3-8c64932c4ad7", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3252) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3256), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3256), "a37016ca-55f9-44bf-a30b-299db10934fe", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3257) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3260), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3261), "db962e8a-17c4-4d6a-b3a8-2b3b99122f49", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3265), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3265), "6d1c6ea4-8557-4fe7-9c7c-f101184e8718", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3265) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3269), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3270), "e5d2b4f9-e541-47ac-bfbc-a8fd00e7c514", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3275), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3276), "2582549f-14a4-44c4-8268-a9371cdfa7af", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3276) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3279), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3279), "3813784e-8597-4b7e-842a-cd32e10d5652", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3284), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3284), "cd1e4fe1-0abe-433c-ae9f-7abec470deca", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3284) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3288), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3288), "7ac02c27-26e9-450f-bbdd-fd8056c444a9", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3292), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3292), "d111e54d-f2c1-46be-a131-af177142656d", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3292) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3296), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3296), "b34444e6-c4a6-4011-9e99-9396771d59bf", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3296) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3300), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3301), "e6ea6f52-abe1-465b-acb6-d34a0ce2ef49", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3301) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3304), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3305), "3d6aef8c-9333-4b2c-b4e5-42a06a99c13d", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3305) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3310), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3310), "6f236508-68eb-420d-b69f-559f884470aa", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3314), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3314), "c2d19c44-9854-4c97-b7eb-2f25804289a8", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3314) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3318), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3319), "9ad97ead-cb19-4a06-b986-b09c4a5d9546", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3319) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3322), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3322), "c0289c3d-7db9-4d5f-92f4-9d411b87f315", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3323) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3327), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3327), "26cdfaf3-7fe6-492d-9815-f3fb5e0d51cf", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3331), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3331), "e3a99a5e-3226-4c97-afec-0bfb63f399b7", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3331) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3335), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3335), "bf8fa534-3f88-4f53-80b1-6baa4bb5c784", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3336) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3339), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3339), "9b84ab12-7a16-48c0-a1c7-2291442f6835", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3339) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3344), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3345), "849cae85-2e37-4069-b73b-824f1c2b9ee8", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3345) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3348), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3349), "206b276f-7ed8-49a7-8a58-15be0fe07cc7", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3349) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3353), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3353), "c19d955d-29a5-4d27-84da-4c8a3abc2d66", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3382), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3382), "ca5e7029-7318-47e2-923c-890c4db2d832", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3383) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3387), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3388), "b594f56c-26cf-4b83-9528-b1ef90a06946", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3388) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3392), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3393), "0bfa1c19-4c2e-406a-9188-2fbd60c6f838", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3397), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3397), "dbd5b2bf-5e27-4f2b-8deb-df75b874dc73", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3401), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3401), "1f3ab5df-3b18-402a-b477-419a23087f45", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3402) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3449), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3449), "35d56d07-a995-4e5f-816c-897337e60d4f", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3449) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3458), 11, new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3458), "66a95ee3-9180-4119-8ca7-e97c00286ce7", 2, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3458) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "ShiftDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3463), 12, new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3463), "26ddd517-f2fe-4819-8542-144014013980", new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3463) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3468), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3469), "0a5b9308-1dc1-4251-a681-56a8eaed38d4", 1, new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3469) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3474), 11, new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3475), "6159324a-3a14-41ad-9dbe-a574f637cb51", 2, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3475) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3478), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3479), "624b5698-080d-49d6-b4ab-3813b8c6c26d", 1, new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3479) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3484), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3485), "a4b1868f-c9d6-4408-931c-0fb8473342d1", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3485) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3490), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3490), "cd7f2484-a764-433f-b70a-edcebfad6e74", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3491) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3494), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3494), "e372ea16-5731-4939-b48f-808c7b8576a3", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3495) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3499), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3499), "f32cb245-8d5a-4c3a-b4ec-737b32fc6180", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3500) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3505), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3506), "81b05f23-12fa-4998-9dc5-ac69d424cbc2", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3506) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3510), 11, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3510), "39951d5c-8b7c-4960-bc18-89ba8d81994d", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3511) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3516), 12, new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3516), "03b3a1be-9266-43b4-91ac-74e4d40c4ee7", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3517) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3520), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3520), "c2bf4f7a-edd4-459f-870b-bf27604339f9", 2, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3521) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3526), 11, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3526), "e688fce5-a870-4f38-8741-b6053cd3ec3b", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3526) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3531), 12, new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3532), "825b0b5e-be5e-4509-9a9a-3d9cafb07de0", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3532) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "ShiftDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3536), 11, new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3536), "17639627-cdb2-40f8-9d3e-293778bae976", new DateTime(2025, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3536) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3542), 12, new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3542), "06632e61-42f8-4e8c-b97e-c0a0fa2d1424", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3542) });
        }
    }
}

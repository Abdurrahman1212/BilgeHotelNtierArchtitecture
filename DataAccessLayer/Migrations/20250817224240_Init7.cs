using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Init7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Vinceville", "Honduras", new DateTime(2025, 8, 18, 1, 42, 39, 809, DateTimeKind.Local).AddTicks(8261), "25022 Baumbach Stream, West Allan, Libyan Arab Jamahiriya", "11", "KZ6113717651339ON674", "977-534-2855", "Malinda54@gmail.com", new DateTime(2025, 8, 18, 1, 42, 39, 809, DateTimeKind.Local).AddTicks(8269), "Loraine", "Mohr", "5fd69dda-0076-4fbc-bee7-9bec66d6e59d", "43604-2871", new DateTime(2025, 8, 18, 1, 42, 39, 809, DateTimeKind.Local).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Bartelltown", "Antarctica (the territory South of 60 deg S)", new DateTime(2025, 8, 18, 1, 42, 39, 809, DateTimeKind.Local).AddTicks(9132), "41815 Swift Prairie, Koelpinport, Egypt", "5", "ES3080757670693050242585", "1-888-716-9604", "Toney_Willms@yahoo.com", new DateTime(2025, 8, 18, 1, 42, 39, 809, DateTimeKind.Local).AddTicks(9133), "Narciso", "Ortiz", "8e3445fe-7f6e-47e5-838e-2038b97c8324", "88720-8869", new DateTime(2025, 8, 18, 1, 42, 39, 809, DateTimeKind.Local).AddTicks(9133) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "North Brandi", "Belarus", new DateTime(2025, 8, 18, 1, 42, 39, 809, DateTimeKind.Local).AddTicks(9413), "60783 Rosalind Creek, Jermaineport, Singapore", "2", "AZ41G20O70515600905025007004", "1-998-319-5443 x741", "Giovani.Gaylord@yahoo.com", new DateTime(2025, 8, 18, 1, 42, 39, 809, DateTimeKind.Local).AddTicks(9413), "Keegan", "Rogahn", "96438f43-fde9-4f3e-97b6-25987fcaa6bf", "93522-7318", new DateTime(2025, 8, 18, 1, 42, 39, 809, DateTimeKind.Local).AddTicks(9414) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Rooseveltshire", "Burkina Faso", new DateTime(2025, 8, 18, 1, 42, 39, 809, DateTimeKind.Local).AddTicks(9665), "78630 Mathilde Extension, North Etha, Japan", "4", "AD052152004030G187347539", "1-204-424-3990 x198", "Laron14@hotmail.com", new DateTime(2025, 8, 18, 1, 42, 39, 809, DateTimeKind.Local).AddTicks(9666), "Eriberto", "Maggio", "8c5e5afd-6338-4a21-a7d2-a4e3e13c8562", "56896-9906", new DateTime(2025, 8, 18, 1, 42, 39, 809, DateTimeKind.Local).AddTicks(9666) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Elinoreburgh", "Germany", new DateTime(2025, 8, 18, 1, 42, 39, 809, DateTimeKind.Local).AddTicks(9906), "043 Justen Drives, Spencerland, Kyrgyz Republic", "1", "AZ47M87Z50342270500336006985", "(291) 971-6637", "Major_Ratke@hotmail.com", new DateTime(2025, 8, 18, 1, 42, 39, 809, DateTimeKind.Local).AddTicks(9906), "Carolanne", "Nitzsche", "119c4d52-1fef-4191-a66b-3845024751f8", "86564", new DateTime(2025, 8, 18, 1, 42, 39, 809, DateTimeKind.Local).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Schmelerfort", "Brunei Darussalam", new DateTime(2025, 8, 18, 1, 42, 39, 810, DateTimeKind.Local).AddTicks(157), "535 Treutel Island, North Karaberg, Kenya", "2", "MK8980980514QA90958", "363-836-1772", "Armand.Beahan30@yahoo.com", new DateTime(2025, 8, 18, 1, 42, 39, 810, DateTimeKind.Local).AddTicks(158), "Harmony", "Weber", "c2cc6e87-c8b6-40bb-9b30-f6d261206b8e", "57522", new DateTime(2025, 8, 18, 1, 42, 39, 810, DateTimeKind.Local).AddTicks(158) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Port Busterfurt", "Chile", new DateTime(2025, 8, 18, 1, 42, 39, 810, DateTimeKind.Local).AddTicks(405), "5472 Doyle Parks, New Nedra, Senegal", "8", "GT343430502963147B21026Y4989", "723-801-1489 x401", "Jeromy.Ernser@yahoo.com", new DateTime(2025, 8, 18, 1, 42, 39, 810, DateTimeKind.Local).AddTicks(405), "Christina", "Goldner", "1cfb86c6-4d35-40af-b6c7-c0822310e2d8", "64904-4743", new DateTime(2025, 8, 18, 1, 42, 39, 810, DateTimeKind.Local).AddTicks(405) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Rocioberg", "Saint Lucia", new DateTime(2025, 8, 18, 1, 42, 39, 810, DateTimeKind.Local).AddTicks(656), "981 Macie Flat, Abdullahville, New Zealand", "3", "CH1980535005H07Z92860", "(281) 815-1615", "Doris84@gmail.com", new DateTime(2025, 8, 18, 1, 42, 39, 810, DateTimeKind.Local).AddTicks(657), "George", "Towne", "ae324103-5caf-4c12-8562-0cad3dd5e391", "71885-9797", new DateTime(2025, 8, 18, 1, 42, 39, 810, DateTimeKind.Local).AddTicks(657) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "South Taurean", "French Polynesia", new DateTime(2025, 8, 18, 1, 42, 39, 810, DateTimeKind.Local).AddTicks(877), "061 Strosin Landing, Lake Fermin, French Polynesia", "5", "CZ4031007034470060910013", "1-768-215-4604", "Hillary.Kutch3@yahoo.com", new DateTime(2025, 8, 18, 1, 42, 39, 810, DateTimeKind.Local).AddTicks(877), "Lamar", "Hackett", "b372b635-ea35-4f5c-990f-5218b7cec152", "67726", new DateTime(2025, 8, 18, 1, 42, 39, 810, DateTimeKind.Local).AddTicks(878) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Ewellshire", "Macao", new DateTime(2025, 8, 18, 1, 42, 39, 810, DateTimeKind.Local).AddTicks(1133), "7956 Trycia Court, Jeffereyfurt, Niue", "1", "AZ16089910090485006008505099", "(492) 494-3104 x7140", "Citlalli16@hotmail.com", new DateTime(2025, 8, 18, 1, 42, 39, 810, DateTimeKind.Local).AddTicks(1133), "Amely", "Nicolas", "75e7255e-5318-415e-9178-40fae5bd6f4c", "58509-8925", new DateTime(2025, 8, 18, 1, 42, 39, 810, DateTimeKind.Local).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Ordu", "Christmas Adası , Avusturalya", new DateTime(2025, 8, 18, 1, 42, 39, 890, DateTimeKind.Local).AddTicks(26), "Altin_Akgul21@gmail.com", "Bayır Sokak 559, Kayseri, Mozambik", "Bölükbaşı", "Sözeri", "+90-383-251-6-091", new DateTime(2025, 8, 18, 1, 42, 39, 890, DateTimeKind.Local).AddTicks(29), "8b585fdc-b504-4417-8256-c11ea03a2a74", "0", new DateTime(2025, 8, 18, 1, 42, 39, 890, DateTimeKind.Local).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Eskişehir", "Gine", new DateTime(2025, 8, 18, 1, 42, 39, 890, DateTimeKind.Local).AddTicks(794), "Barsboga.Denkel47@yahoo.com", "Gül Sokak 644, Tunceli, Dominik Cumhuriyeti", "Baytara", "Demirel", "+90-056-300-28-56", new DateTime(2025, 8, 18, 1, 42, 39, 890, DateTimeKind.Local).AddTicks(794), "ba494f7f-5194-49a7-abac-3f68a8485a19", new DateTime(2025, 8, 18, 1, 42, 39, 890, DateTimeKind.Local).AddTicks(794) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Kırıkkale", "Guam, Amerika", new DateTime(2025, 8, 18, 1, 42, 39, 890, DateTimeKind.Local).AddTicks(974), "Bongul44@yahoo.com", "İsmet Paşa Caddesi 53, Amasya, Andorra", "Basar", "Yıldızoğlu", "+90-649-768-03-25", new DateTime(2025, 8, 18, 1, 42, 39, 890, DateTimeKind.Local).AddTicks(975), "4aae41e9-2145-4df2-b998-771ee218cb59", new DateTime(2025, 8, 18, 1, 42, 39, 890, DateTimeKind.Local).AddTicks(975) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Eskişehir", "Bulgaristan", new DateTime(2025, 8, 18, 1, 42, 39, 890, DateTimeKind.Local).AddTicks(1118), "Kirlangic26@gmail.com", "Sevgi Sokak 28c, Karaman, Kamboçya", "Ayas", "Bademci", "+90-141-664-6-739", new DateTime(2025, 8, 18, 1, 42, 39, 890, DateTimeKind.Local).AddTicks(1118), "c917944b-af83-4c63-ba97-32f352f637dc", new DateTime(2025, 8, 18, 1, 42, 39, 890, DateTimeKind.Local).AddTicks(1118) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Yalova", "Palau Adaları", new DateTime(2025, 8, 18, 1, 42, 39, 890, DateTimeKind.Local).AddTicks(1252), "Al.Sepetci@hotmail.com", "Köypınar Sokak 04b, Hakkari, Tuvalu", "Alparsbeğ", "Dalkıran", "+90-050-335-27-69", new DateTime(2025, 8, 18, 1, 42, 39, 890, DateTimeKind.Local).AddTicks(1252), "acb55188-cc22-4e71-a4db-fefa06f9006c", new DateTime(2025, 8, 18, 1, 42, 39, 890, DateTimeKind.Local).AddTicks(1252) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Aydın", "Togo", new DateTime(2025, 8, 18, 1, 42, 39, 890, DateTimeKind.Local).AddTicks(1374), "Bugduz.Ertepinar@hotmail.com", "Dağınık Evler Sokak 75, Erzurum, İsveç", "Bozbörü", "Özgörkey", "+90-021-066-4-082", new DateTime(2025, 8, 18, 1, 42, 39, 890, DateTimeKind.Local).AddTicks(1375), "1aadc93d-60c8-4747-8153-9ae71b4c1766", new DateTime(2025, 8, 18, 1, 42, 39, 890, DateTimeKind.Local).AddTicks(1375) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Düzce", "Svaziland", new DateTime(2025, 8, 18, 1, 42, 39, 890, DateTimeKind.Local).AddTicks(1493), "Cabus_Nebioglu63@hotmail.com", "Dağınık Evler Sokak 33, Malatya, Vanuatu", "Arbuz", "Sandalcı", "+90-949-353-1-854", new DateTime(2025, 8, 18, 1, 42, 39, 890, DateTimeKind.Local).AddTicks(1494), "608208b5-cfd1-4d8c-931e-2b6e32a8e95d", "0", new DateTime(2025, 8, 18, 1, 42, 39, 890, DateTimeKind.Local).AddTicks(1494) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Şırnak", "Fransız Güney Eyaletleri (Kerguelen Adaları)", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(2350), "Bortecine.Daglaroglu@yahoo.com", "Harman Yolu Sokak  81b, Bitlis, Ukrayna", "Gülegen", "Sarıoğlu", "+90-206-104-0-372", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(2353), "e9c79150-2993-467f-9929-b825b46e6b7c", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(2354) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Amasya", "İrlanda", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(3009), "Bozok.Koyluoglu@yahoo.com", "Bayır Sokak 3, Edirne, Paraguay", "Beyrem", "Akışık", "+90-571-858-6-988", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(3009), "fa47a6d5-22eb-4857-9950-f9b095aa39c7", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(3009) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Kırklareli", "Cezayir", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(3167), "Basan_Gunday8@hotmail.com", "Bahçe Sokak 03b, Kastamonu, Samoa", "Buluğ", "Tazegül", "+90-895-627-30-43", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(3167), "8b790444-caa4-4b2b-bec8-39c87d7e6a6d", "1", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(3168) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Kırşehir", "Yemen", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(3293), "Boke36@yahoo.com", "Nalbant Sokak 65b, Siirt, Andorra", "Bozkurt", "Özbir", "+90-380-188-84-41", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(3294), "f8be44c4-16c7-430d-814a-6f55b68331ed", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(3294) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Adıyaman", "Tonga", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(3432), "Bagatursepi15@yahoo.com", "Harman Yolu Sokak  14b, Nevşehir, El Salvador", "Abak", "Tanrıkulu", "+90-003-884-9-153", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(3433), "7eae303e-d7d8-44fa-b409-c7d829190933", "1", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(3433) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Osmaniye", "Saint Martin, Fransa", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(3583), "Cagritegin_Balci29@gmail.com", "Sağlık Sokak 88a, Aksaray, Slovenya", "Baybayık", "Topaloğlu", "+90-600-828-05-03", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(3583), "4f4f0d6a-bbb2-4b88-acf4-bc55ed42d8d0", "1", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(3584) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Kütahya", "Wake Adaları, Amerika", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(3798), "Balaka.Tokgoz5@gmail.com", "Kekeçoğlu Sokak 883, Sivas, Palau Adaları", "Abılay", "Yazıcı", "+90-044-897-20-23", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(3800), "e8526894-2f82-4867-bd80-01b8340ee708", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(3800) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Kırşehir", "Güney Georgia ve Güney Sandviç Adaları, İngiltere", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(3945), "Elkin_Kunter@gmail.com", "Nalbant Sokak 48, Şırnak, Tuvalu", "Akçora", "Akyürek", "+90-415-179-0-978", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(3945), "8b6a54ea-8246-4098-b6ac-281218739868", "0", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(3946) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Edirne", "İrlanda", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(4065), "Begdurmus_Cevik@hotmail.com", "Atatürk Bulvarı 008, Niğde, Venezuela", "Bumın", "Poçan", "+90-208-149-5-937", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(4065), "e54b2049-7710-4912-89c3-e4f56899fb99", "0", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(4066) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Bingöl", "Gine", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(4172), "Atsiz_Menemencioglu@yahoo.com", "Ergenekon Sokak   45, Sakarya, Madagaskar", "Bastı", "Egeli", "+90-712-803-7-191", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(4172), "3414b135-816d-42ee-bad8-6378ea580e5f", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(4173) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Kırşehir", "Doğu Timor", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(4290), "Baltir_Cetin@yahoo.com", "Sıran Söğüt Sokak 3, Antalya, Nikaragua", "Ebren", "Keçeci", "+90-508-236-4-006", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(4291), "b51a2b43-9bfc-4896-9c5a-18627e00ff66", "0", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(4291) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Batman", "Makau (Makao)", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(5066), "Adberilgen.Kahveci62@yahoo.com", "Yunus Emre Sokak 65c, Yalova, Jamaika", "Bozan", "Dağlaroğlu", "+90-897-516-6-475", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(5070), "20b0dd93-4aea-4546-a9ce-3595645e4cfd", "0", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(5071) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Çorum", "Mayotte, Fransa", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(5737), "Barmakli46@gmail.com", "Barış Sokak 67c, Sivas, Andorra", "Arslanargun", "Durmaz", "+90-313-931-41-39", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(5737), "e9211ab1-29a0-41a4-adb3-cee34efbf73e", "1", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(5738) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Bursa", "Kiribati", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(5886), "Bogacuk_Baturalp@gmail.com", "Barış Sokak 249, Şanlıurfa, Güney Georgia ve Güney Sandviç Adaları, İngiltere", "Baysungur", "Poyrazoğlu", "+90-997-094-04-49", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(5887), "aa355579-58f8-4d09-be38-e92ba01af792", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(5887) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Kırıkkale", "Güney Kıbrıs Rum Yönetimi", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(6003), "Barcadogdu.Bakircioglu@hotmail.com", "Lütfi Karadirek Caddesi 78b, Bitlis, Seyşeller", "Barkan", "Demirbaş", "+90-211-721-79-04", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(6003), "32c5f4fb-2b39-4429-8298-76a2b5c3a284", "1", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(6004) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Trabzon", "Pakistan", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(6142), "Berginsenge_Akan29@gmail.com", "Fatih Sokak  069, Yozgat, Irak", "Bönek", "Öymen", "+90-213-464-9-519", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(6142), "8de47889-d491-465a-8495-be9a5db47c61", "1", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(6143) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Edirne", "Hollanda Antilleri", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(6274), "Bek_Koyuncu30@yahoo.com", "Okul Sokak 3, Osmaniye, Somali", "Ayyıldız", "Akar ", "+90-222-690-56-61", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(6275), "1dfb3103-1d49-4cc0-8aa6-9566beae0966", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(6275) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Samsun", "Libya", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(6388), "Ayruk_Ilicali@yahoo.com", "Harman Yolu Sokak  952, Ağrı, Christmas Adası , Avusturalya", "Bönge", "Kutlay", "+90-636-576-8-802", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(6389), "ea9f86b3-6bfc-4fa9-93cb-bdf177ff1840", "1", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(6389) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Denizli", "Brezilya", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(6507), "Baksi_Oztuna64@hotmail.com", "Alparslan Türkeş Bulvarı 9, Uşak, Küba", "Çıngır", "Erez", "+90-181-642-20-32", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(6507), "daeb3b6b-f225-4a3b-9991-bd44db85c502", "0", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(6507) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Kastamonu", "Danimarka", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(6623), "Gulumser11@gmail.com", "İsmet Paşa Caddesi 86, Muş, Türkmenistan", "Çölü", "Balcı", "+90-224-030-59-34", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(6623), "5234b48f-77c3-4099-83d1-c31f6f8de5e2", "0", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(6623) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Zonguldak", "Japonya", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(6739), "Bugrakarakagan82@yahoo.com", "Bayır Sokak 12, Burdur, İran", "Atsız", "Erçetin", "+90-141-107-13-67", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(6740), "5c598e1b-f4e8-450b-bc72-0f4705017226", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Bolu", "Zimbabve", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(6861), "Buke.Aclan@yahoo.com", "Ali Çetinkaya Caddesi 3, Malatya, Vietnam", "Beğdurmuş", "Kılıççı", "+90-801-373-01-27", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(6861), "4d8c48be-6ca6-42b3-b1a9-b8ed64419e1f", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(6862) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Şanlıurfa", "Portekiz", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(8013), "Bekec1@gmail.com", "Sağlık Sokak 65b, Uşak, Libya", "Erten", "Tekand", "+90-910-194-2-395", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(8017), "63ef3f3b-2925-4347-9afb-1b085b3c15b4", "0", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(8017) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Tokat", "Andorra", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(8632), "Ikeme.Kaplangi74@gmail.com", "Kaldırım Sokak 54c, İzmir, Saint Helena, İngiltere", "Çemen", "Adıvar", "+90-939-465-8-710", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(8633), "70fae7a3-056e-4564-9019-123f9c34ec52", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(8633) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Iğdır", "Zambiya", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(8793), "Aydogdu61@yahoo.com", "Saygılı Sokak 895, Tokat, Tanzanya", "Başkırt", "Akal", "+90-697-382-56-33", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(8793), "ac01dbf5-4872-42b0-91b1-dfcac44a8bca", "0", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(8793) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Çanakkale", "Cibuti", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(8911), "Buyat2@hotmail.com", "Tevfik Fikret Caddesi 9, Hakkari, Zimbabve", "Baltur", "Denkel", "+90-482-769-5-399", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(8911), "ee6252a3-616c-49c2-9f74-1c080cab7932", "0", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Çankırı", "Finlandiya", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9033), "Al57@hotmail.com", "Kekeçoğlu Sokak 93, Tekirdağ, Barbados", "Bilgebayunçur", "Kahveci", "+90-251-245-29-21", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9033), "178c0b10-7667-43a6-9d60-24c91a905799", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Muş", "K.K.T.C.", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9143), "Arkis.Ozbey52@yahoo.com", "Kaldırım Sokak 58c, Hatay, Turks ve Caicos Adaları, İngiltere", "Alpbamsı", "Erberk", "+90-420-646-4-902", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9143), "15b8ac87-5382-4080-b63c-96caddfb74b1", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Muş", "Polonya", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9252), "Etil.Alpugan@hotmail.com", "Nalbant Sokak 53c, Isparta, Laos", "Akçora", "Dalkıran", "+90-652-432-0-532", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9252), "1b1a985c-84cd-4770-9ef3-eb03bec22d45", "1", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9252) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Sivas", "Svalbard, Norveç", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9360), "Buke_Kunt80@hotmail.com", "Harman Altı Sokak 514, Kütahya, Laos", "Katun", "Tahincioğlu", "+90-099-191-92-52", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9360), "08a50c76-855b-4c8c-af59-188b0e067611", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Kocaeli", "Cibuti", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9436), "Ayruk.Erez@hotmail.com", "Saygılı Sokak 51a, Uşak, Malavi", "Karaca", "Süleymanoğlu", "+90-047-042-0-690", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9436), "f4ef6ba5-aa6e-4ae7-a45b-f4c32fe68eeb", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9436) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Adana", "Guyana", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9529), "Bozan_Tugluk97@hotmail.com", "Atatürk Bulvarı 38a, Şırnak, Ukrayna", "Başbuğ", "Adan", "+90-905-985-4-611", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9530), "bfb7799c-39ca-4d76-af1b-184f49403ed9", "1", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9530) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Zonguldak", "Mozambik", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9651), "Ediz93@hotmail.com", "Kerimoğlu Sokak 70b, Antalya, Amerikan Samoa", "Katunkız", "Eronat", "+90-493-348-3-762", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9652), "21922f42-c19b-46fb-b00b-4a214a7e3c00", "0", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Manisa", "Namibia", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9772), "Inci_Bademci39@gmail.com", "İsmet Attila Caddesi 8, Siirt, İspanya", "Boyan", "Tüzün", "+90-679-422-7-624", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9773), "4cdc72fe-9fb6-40f6-821c-1c2bd9767162", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9773) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Afyon", "Burkina Faso", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9881), "Buzactutuk0@hotmail.com", "Afyon Kaya Sokak 376, Kocaeli, Amerika Birleşik Devletleri", "Alayunt", "Poçan", "+90-230-884-65-58", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9881), "d3ca1eec-3c01-46d7-925a-3416afc9d9f0", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9881) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Burdur", "Yemen", new DateTime(2025, 8, 18, 1, 42, 39, 895, DateTimeKind.Local).AddTicks(265), "Buyruc_Akaydin0@yahoo.com", "Bayır Sokak 23a, Eskişehir, Tuvalu", "Barkdoğdu", "Aykaç", "+90-646-688-82-35", new DateTime(2025, 8, 18, 1, 42, 39, 895, DateTimeKind.Local).AddTicks(269), "7a8b37f4-7c3d-427f-adf3-b1674feadc19", "1", new DateTime(2025, 8, 18, 1, 42, 39, 895, DateTimeKind.Local).AddTicks(269) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Yalova", "Sao Tome ve Principe", new DateTime(2025, 8, 18, 1, 42, 39, 896, DateTimeKind.Local).AddTicks(683), "Boylakutlutarkan.Asikoglu92@gmail.com", "Barış Sokak 80b, İçel (Mersin), Guam, Amerika", "Altay", "Tütüncü", "+90-359-729-71-46", new DateTime(2025, 8, 18, 1, 42, 39, 896, DateTimeKind.Local).AddTicks(685), "259e5684-408f-49f9-98b9-f73f26484bb0", "1", new DateTime(2025, 8, 18, 1, 42, 39, 896, DateTimeKind.Local).AddTicks(686) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(3251), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(3254), 631.24m, new DateTime(2024, 9, 1, 16, 48, 54, 697, DateTimeKind.Local).AddTicks(2766), "Et excepturi sint repellat aliquam.", "Refined Steel Sausages", "713672bc-1df9-4ec8-8adb-99a3803da62a", 2, new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(3507), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(3507), 48.52m, new DateTime(2025, 8, 4, 23, 3, 54, 231, DateTimeKind.Local).AddTicks(8457), "Cupiditate nulla beatae quis explicabo quae sit inventore quisquam asperiores.", "Ergonomic Granite Mouse", "e1c668d1-258b-488a-938b-4626eb426a14", 3, new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(3507) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(3594), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(3594), 943.37m, new DateTime(2025, 8, 16, 13, 37, 53, 78, DateTimeKind.Local).AddTicks(2636), "Sed minima quam vel sint impedit nam dolor perspiciatis.", "Licensed Frozen Car", "424f145b-b96a-4523-a7b6-1745214e3208", 2, new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(3595) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(3678), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(3679), 840.59m, new DateTime(2024, 12, 13, 18, 28, 26, 851, DateTimeKind.Local).AddTicks(7498), "Nisi aut illum eos sit inventore fugit autem.", "Incredible Steel Fish", "bf5136fa-f4f7-40e7-90b1-a2cfcaeb6fa3", 10, new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(3679) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(3725), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(3725), 610.16m, new DateTime(2025, 2, 23, 18, 49, 55, 141, DateTimeKind.Local).AddTicks(7374), "Dicta error suscipit veniam.", "Sleek Fresh Bacon", "1f93c17f-b69e-45e1-94f9-1a75f6090549", 8, new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(3725) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(3756), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(3757), 407.78m, new DateTime(2025, 5, 25, 3, 58, 46, 302, DateTimeKind.Local).AddTicks(3420), "Dicta quis est dolores cupiditate possimus qui impedit nam.", "Incredible Wooden Shoes", "885c37f0-be27-4fa6-a1cf-64e41f0dcb17", 10, new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(3757) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(3796), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(3796), 427.95m, new DateTime(2025, 1, 26, 9, 20, 26, 229, DateTimeKind.Local).AddTicks(8698), "Corrupti voluptate aut doloribus minus.", "Handmade Plastic Fish", "a29f7897-77e2-46ad-9386-cb0c170c215d", 3, new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(3797) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(3870), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(3871), 369.26m, new DateTime(2025, 5, 1, 12, 0, 52, 615, DateTimeKind.Local).AddTicks(1957), "Quia qui et.", "Unbranded Rubber Bike", "259a85e8-2b52-4f25-be82-4ca090c7d262", 4, new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(3871) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(3902), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(3902), 191.26m, new DateTime(2025, 8, 10, 15, 4, 46, 665, DateTimeKind.Local).AddTicks(1789), "Assumenda illo doloremque esse voluptatem quod eius.", "Refined Steel Bacon", "e77cdb54-0f90-4088-a95b-d3576c0622aa", 5, new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(3902) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(3938), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(3938), 731.84m, new DateTime(2024, 10, 11, 8, 24, 6, 265, DateTimeKind.Local).AddTicks(5155), "Voluptatibus repellendus perferendis non.", "Refined Soft Chicken", "4ef1efa7-2b51-4611-869e-6a2627344b19", 2, new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(3938) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 11, 10, 12, 52, 33, 475, DateTimeKind.Local).AddTicks(6512), new DateTime(2026, 3, 17, 10, 10, 18, 588, DateTimeKind.Local).AddTicks(5550), new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5344), 6, new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5344), "20ca8ac9-0744-4dce-9808-b9b7e2a5425c", 27, 1859.12m, new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5345) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 9, 20, 21, 16, 22, 933, DateTimeKind.Local).AddTicks(3724), new DateTime(2026, 1, 21, 17, 36, 45, 40, DateTimeKind.Local).AddTicks(8722), new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5647), 9, new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5648), "5d0cc0d0-6bdb-4e23-997d-9feafb600a25", 6, 1813.24m, new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5648) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 16, 0, 39, 17, 451, DateTimeKind.Local).AddTicks(1577), new DateTime(2026, 9, 8, 15, 53, 0, 543, DateTimeKind.Local).AddTicks(6953), new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5669), 5, new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5670), "8e95c656-fa26-4118-8f6d-e649e6a44c4a", 17, 2067.59m, new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 6, 16, 13, 38, 155, DateTimeKind.Local).AddTicks(4230), new DateTime(2026, 5, 5, 10, 18, 5, 538, DateTimeKind.Local).AddTicks(4666), new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5693), 1, new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5693), "4472a9aa-a0e2-4f1f-8773-8e5f694ce497", 29, 2098.91m, new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5694) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 8, 5, 20, 51, 51, 182, DateTimeKind.Local).AddTicks(1573), new DateTime(2027, 6, 27, 16, 31, 0, 757, DateTimeKind.Local).AddTicks(9348), new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5708), new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5708), "9e4d6c40-79e0-481d-8da1-7d32154171e4", 50, 2458.05m, new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5709) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 6, 19, 4, 40, 58, 272, DateTimeKind.Local).AddTicks(769), new DateTime(2026, 10, 16, 9, 44, 13, 88, DateTimeKind.Local).AddTicks(239), new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5724), new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5725), "1fbf6c51-b605-445f-bc60-93590a235b38", 22, 2189.41m, new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 6, 8, 7, 3, 35, 269, DateTimeKind.Local).AddTicks(7316), new DateTime(2026, 10, 22, 17, 53, 31, 319, DateTimeKind.Local).AddTicks(4830), new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5739), new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5739), "7dfe5685-1306-475b-af75-26b896be077e", 35, 2205.39m, new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5739) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 12, 20, 20, 20, 4, 202, DateTimeKind.Local).AddTicks(3066), new DateTime(2026, 7, 21, 13, 25, 4, 964, DateTimeKind.Local).AddTicks(4704), new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5756), 3, new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5756), "adc84d03-a023-410c-ba0b-20a047b82c38", 39, 2332.35m, new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5757) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 13, 3, 57, 33, 400, DateTimeKind.Local).AddTicks(4298), new DateTime(2026, 8, 19, 1, 27, 58, 60, DateTimeKind.Local).AddTicks(5714), new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5771), 5, new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5771), "5bde2c67-a66b-4830-985b-667662254cc7", 42, 2330.72m, new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5771) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 26, 23, 16, 10, 792, DateTimeKind.Local).AddTicks(8158), new DateTime(2026, 9, 1, 4, 6, 32, 731, DateTimeKind.Local).AddTicks(7314), new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5786), 3, new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5786), "7a587ced-3e27-4105-8b1b-f92f51ccdab7", 8, 1660.16m, new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5786) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 811, DateTimeKind.Local).AddTicks(5215), new DateTime(2025, 8, 18, 1, 42, 39, 811, DateTimeKind.Local).AddTicks(5220), "a08b1f57-37cc-481b-9ec9-cb8e55946315", new DateTime(2025, 8, 18, 1, 42, 39, 811, DateTimeKind.Local).AddTicks(5221) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 812, DateTimeKind.Local).AddTicks(6369), new DateTime(2025, 8, 18, 1, 42, 39, 812, DateTimeKind.Local).AddTicks(6373), "538acfb9-24af-4932-a3e8-e78597e791f1", new DateTime(2025, 8, 18, 1, 42, 39, 812, DateTimeKind.Local).AddTicks(6374) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 813, DateTimeKind.Local).AddTicks(7615), new DateTime(2025, 8, 18, 1, 42, 39, 813, DateTimeKind.Local).AddTicks(7619), "52b96824-447a-4020-8169-8c244eca5295", new DateTime(2025, 8, 18, 1, 42, 39, 813, DateTimeKind.Local).AddTicks(7619) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 815, DateTimeKind.Local).AddTicks(3383), new DateTime(2025, 8, 18, 1, 42, 39, 815, DateTimeKind.Local).AddTicks(3392), "cdc9cb6f-65d0-42bd-9960-b82dea6ab1c5", new DateTime(2025, 8, 18, 1, 42, 39, 815, DateTimeKind.Local).AddTicks(3392) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 816, DateTimeKind.Local).AddTicks(9331), new DateTime(2025, 8, 18, 1, 42, 39, 816, DateTimeKind.Local).AddTicks(9336), "5420c6a6-c7bc-4c55-80ca-ae3852a59a6d", new DateTime(2025, 8, 18, 1, 42, 39, 816, DateTimeKind.Local).AddTicks(9337) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 818, DateTimeKind.Local).AddTicks(1809), new DateTime(2025, 8, 18, 1, 42, 39, 818, DateTimeKind.Local).AddTicks(1813), "fe534b85-53f0-4610-a668-f2295631bb63", new DateTime(2025, 8, 18, 1, 42, 39, 818, DateTimeKind.Local).AddTicks(1814) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 819, DateTimeKind.Local).AddTicks(2205), new DateTime(2025, 8, 18, 1, 42, 39, 819, DateTimeKind.Local).AddTicks(2208), "1d3f8b83-981c-4323-bc31-a95d131fdc46", new DateTime(2025, 8, 18, 1, 42, 39, 819, DateTimeKind.Local).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 820, DateTimeKind.Local).AddTicks(3081), new DateTime(2025, 8, 18, 1, 42, 39, 820, DateTimeKind.Local).AddTicks(3086), "eaea9ee5-db04-4a66-9421-5371dc784d79", new DateTime(2025, 8, 18, 1, 42, 39, 820, DateTimeKind.Local).AddTicks(3087) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 821, DateTimeKind.Local).AddTicks(3068), new DateTime(2025, 8, 18, 1, 42, 39, 821, DateTimeKind.Local).AddTicks(3070), "4e47abc7-6e8f-4683-b490-b9df074526ac", new DateTime(2025, 8, 18, 1, 42, 39, 821, DateTimeKind.Local).AddTicks(3070) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 822, DateTimeKind.Local).AddTicks(2910), new DateTime(2025, 8, 18, 1, 42, 39, 822, DateTimeKind.Local).AddTicks(2913), "510d43f5-0ac3-44bc-8465-c57fc853d7b2", new DateTime(2025, 8, 18, 1, 42, 39, 822, DateTimeKind.Local).AddTicks(2914) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 823, DateTimeKind.Local).AddTicks(2185), new DateTime(2025, 8, 18, 1, 42, 39, 823, DateTimeKind.Local).AddTicks(2186), "6848b514-1029-495f-a422-f33791ec9c3f", new DateTime(2025, 8, 18, 1, 42, 39, 823, DateTimeKind.Local).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 824, DateTimeKind.Local).AddTicks(1742), new DateTime(2025, 8, 18, 1, 42, 39, 824, DateTimeKind.Local).AddTicks(1746), "84d481de-025a-4220-b672-bed4fc3ed3ff", new DateTime(2025, 8, 18, 1, 42, 39, 824, DateTimeKind.Local).AddTicks(1747) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 825, DateTimeKind.Local).AddTicks(769), new DateTime(2025, 8, 18, 1, 42, 39, 825, DateTimeKind.Local).AddTicks(770), "1bfe3c89-b73d-48a6-a011-9b7d6f3b28f8", new DateTime(2025, 8, 18, 1, 42, 39, 825, DateTimeKind.Local).AddTicks(771) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 826, DateTimeKind.Local).AddTicks(181), new DateTime(2025, 8, 18, 1, 42, 39, 826, DateTimeKind.Local).AddTicks(185), "20908559-b956-4cc3-aa4b-76838830bb96", new DateTime(2025, 8, 18, 1, 42, 39, 826, DateTimeKind.Local).AddTicks(185) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 826, DateTimeKind.Local).AddTicks(9225), new DateTime(2025, 8, 18, 1, 42, 39, 826, DateTimeKind.Local).AddTicks(9226), "462ab2f7-1276-477f-aa95-00408c9ed630", new DateTime(2025, 8, 18, 1, 42, 39, 826, DateTimeKind.Local).AddTicks(9226) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 827, DateTimeKind.Local).AddTicks(9102), new DateTime(2025, 8, 18, 1, 42, 39, 827, DateTimeKind.Local).AddTicks(9107), "25a7ab6c-eb53-4b4b-8b0a-9a05d3129408", new DateTime(2025, 8, 18, 1, 42, 39, 827, DateTimeKind.Local).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 828, DateTimeKind.Local).AddTicks(8532), new DateTime(2025, 8, 18, 1, 42, 39, 828, DateTimeKind.Local).AddTicks(8533), "efb38072-dec8-4e66-8fdd-cf8dd0ea4275", new DateTime(2025, 8, 18, 1, 42, 39, 828, DateTimeKind.Local).AddTicks(8533) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 829, DateTimeKind.Local).AddTicks(8096), new DateTime(2025, 8, 18, 1, 42, 39, 829, DateTimeKind.Local).AddTicks(8099), "0040a9ab-166a-47a6-a31b-2a218dcb61ff", new DateTime(2025, 8, 18, 1, 42, 39, 829, DateTimeKind.Local).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 830, DateTimeKind.Local).AddTicks(7721), new DateTime(2025, 8, 18, 1, 42, 39, 830, DateTimeKind.Local).AddTicks(7722), "9bf0b795-e314-47a0-b10f-e5e6f5049a94", new DateTime(2025, 8, 18, 1, 42, 39, 830, DateTimeKind.Local).AddTicks(7722) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 831, DateTimeKind.Local).AddTicks(7535), new DateTime(2025, 8, 18, 1, 42, 39, 831, DateTimeKind.Local).AddTicks(7538), "d0b59bd2-43fa-415c-a098-44c99f35d73b", new DateTime(2025, 8, 18, 1, 42, 39, 831, DateTimeKind.Local).AddTicks(7539) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 832, DateTimeKind.Local).AddTicks(7228), new DateTime(2025, 8, 18, 1, 42, 39, 832, DateTimeKind.Local).AddTicks(7232), "0703b5ea-30e8-480e-9702-d11fca8cb93f", new DateTime(2025, 8, 18, 1, 42, 39, 832, DateTimeKind.Local).AddTicks(7232) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 833, DateTimeKind.Local).AddTicks(7234), new DateTime(2025, 8, 18, 1, 42, 39, 833, DateTimeKind.Local).AddTicks(7235), "1767a659-af25-46fe-926a-1a20a4a3d2be", new DateTime(2025, 8, 18, 1, 42, 39, 833, DateTimeKind.Local).AddTicks(7235) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 834, DateTimeKind.Local).AddTicks(8217), new DateTime(2025, 8, 18, 1, 42, 39, 834, DateTimeKind.Local).AddTicks(8220), "38daeca0-0bc5-40f2-a485-da05adc8489a", new DateTime(2025, 8, 18, 1, 42, 39, 834, DateTimeKind.Local).AddTicks(8221) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 835, DateTimeKind.Local).AddTicks(9023), new DateTime(2025, 8, 18, 1, 42, 39, 835, DateTimeKind.Local).AddTicks(9024), "8267e4ba-4717-489b-8d5a-32c452b18d50", new DateTime(2025, 8, 18, 1, 42, 39, 835, DateTimeKind.Local).AddTicks(9024) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 836, DateTimeKind.Local).AddTicks(9942), new DateTime(2025, 8, 18, 1, 42, 39, 836, DateTimeKind.Local).AddTicks(9945), "ae484806-c10b-473f-abd2-aacd373a88f1", new DateTime(2025, 8, 18, 1, 42, 39, 836, DateTimeKind.Local).AddTicks(9946) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 837, DateTimeKind.Local).AddTicks(9519), new DateTime(2025, 8, 18, 1, 42, 39, 837, DateTimeKind.Local).AddTicks(9520), "491d1bbf-0752-4e66-8451-e0b1d5c8a0c8", new DateTime(2025, 8, 18, 1, 42, 39, 837, DateTimeKind.Local).AddTicks(9521) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 838, DateTimeKind.Local).AddTicks(9511), new DateTime(2025, 8, 18, 1, 42, 39, 838, DateTimeKind.Local).AddTicks(9516), "61b859fc-741e-47b3-8abb-be9206588758", new DateTime(2025, 8, 18, 1, 42, 39, 838, DateTimeKind.Local).AddTicks(9516) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 839, DateTimeKind.Local).AddTicks(9240), new DateTime(2025, 8, 18, 1, 42, 39, 839, DateTimeKind.Local).AddTicks(9242), "540f08ed-4a8f-4c49-a072-54d858040dd5", new DateTime(2025, 8, 18, 1, 42, 39, 839, DateTimeKind.Local).AddTicks(9242) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 840, DateTimeKind.Local).AddTicks(9600), new DateTime(2025, 8, 18, 1, 42, 39, 840, DateTimeKind.Local).AddTicks(9603), "c6baefa8-35bd-4c0a-8db0-3120016ac5b9", new DateTime(2025, 8, 18, 1, 42, 39, 840, DateTimeKind.Local).AddTicks(9604) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 841, DateTimeKind.Local).AddTicks(9340), new DateTime(2025, 8, 18, 1, 42, 39, 841, DateTimeKind.Local).AddTicks(9344), "8e4c6945-26b4-4ea3-8e36-9399a233de98", new DateTime(2025, 8, 18, 1, 42, 39, 841, DateTimeKind.Local).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 842, DateTimeKind.Local).AddTicks(8854), new DateTime(2025, 8, 18, 1, 42, 39, 842, DateTimeKind.Local).AddTicks(8856), "58ad8e1a-2a38-4299-ae0d-544230705df8", new DateTime(2025, 8, 18, 1, 42, 39, 842, DateTimeKind.Local).AddTicks(8857) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 843, DateTimeKind.Local).AddTicks(8524), new DateTime(2025, 8, 18, 1, 42, 39, 843, DateTimeKind.Local).AddTicks(8526), "2559e5dd-7da1-4b25-9292-a74865642932", new DateTime(2025, 8, 18, 1, 42, 39, 843, DateTimeKind.Local).AddTicks(8526) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 844, DateTimeKind.Local).AddTicks(8504), new DateTime(2025, 8, 18, 1, 42, 39, 844, DateTimeKind.Local).AddTicks(8508), "0118b8fc-a10d-445e-850c-771bdf64b9e7", new DateTime(2025, 8, 18, 1, 42, 39, 844, DateTimeKind.Local).AddTicks(8508) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 845, DateTimeKind.Local).AddTicks(7931), new DateTime(2025, 8, 18, 1, 42, 39, 845, DateTimeKind.Local).AddTicks(7932), "aeb22631-5870-422a-a0cd-d35c65248c71", new DateTime(2025, 8, 18, 1, 42, 39, 845, DateTimeKind.Local).AddTicks(7932) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 846, DateTimeKind.Local).AddTicks(7556), new DateTime(2025, 8, 18, 1, 42, 39, 846, DateTimeKind.Local).AddTicks(7559), "7f3e20a0-f2a2-436f-a5bc-1c119f4454b2", new DateTime(2025, 8, 18, 1, 42, 39, 846, DateTimeKind.Local).AddTicks(7560) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 847, DateTimeKind.Local).AddTicks(7183), new DateTime(2025, 8, 18, 1, 42, 39, 847, DateTimeKind.Local).AddTicks(7183), "e9f221f3-0914-4034-a2c8-b740979a101b", new DateTime(2025, 8, 18, 1, 42, 39, 847, DateTimeKind.Local).AddTicks(7184) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 848, DateTimeKind.Local).AddTicks(7109), new DateTime(2025, 8, 18, 1, 42, 39, 848, DateTimeKind.Local).AddTicks(7111), "84c89299-c868-40b7-9f0e-97efd2637a6b", new DateTime(2025, 8, 18, 1, 42, 39, 848, DateTimeKind.Local).AddTicks(7112) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 849, DateTimeKind.Local).AddTicks(6738), new DateTime(2025, 8, 18, 1, 42, 39, 849, DateTimeKind.Local).AddTicks(6739), "98b9f4f4-73e3-4dd9-92ef-8ba0d7c5540e", new DateTime(2025, 8, 18, 1, 42, 39, 849, DateTimeKind.Local).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 850, DateTimeKind.Local).AddTicks(7208), new DateTime(2025, 8, 18, 1, 42, 39, 850, DateTimeKind.Local).AddTicks(7211), "4a63cc9c-11e2-4ff1-801e-9f8e4e9becb9", new DateTime(2025, 8, 18, 1, 42, 39, 850, DateTimeKind.Local).AddTicks(7211) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 851, DateTimeKind.Local).AddTicks(6731), new DateTime(2025, 8, 18, 1, 42, 39, 851, DateTimeKind.Local).AddTicks(6734), "f9c2ba80-1169-4c72-9abe-a21d797c379f", new DateTime(2025, 8, 18, 1, 42, 39, 851, DateTimeKind.Local).AddTicks(6734) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 852, DateTimeKind.Local).AddTicks(5873), new DateTime(2025, 8, 18, 1, 42, 39, 852, DateTimeKind.Local).AddTicks(5873), "e07b25e8-4add-4659-a6cd-8da90b895942", new DateTime(2025, 8, 18, 1, 42, 39, 852, DateTimeKind.Local).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 853, DateTimeKind.Local).AddTicks(4867), new DateTime(2025, 8, 18, 1, 42, 39, 853, DateTimeKind.Local).AddTicks(4868), "908b2b53-6ef8-4e45-8ce3-6ac40eceef89", new DateTime(2025, 8, 18, 1, 42, 39, 853, DateTimeKind.Local).AddTicks(4868) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 854, DateTimeKind.Local).AddTicks(4697), new DateTime(2025, 8, 18, 1, 42, 39, 854, DateTimeKind.Local).AddTicks(4700), "8efb4a25-20fb-46b6-8003-675237a2f9ca", new DateTime(2025, 8, 18, 1, 42, 39, 854, DateTimeKind.Local).AddTicks(4701) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 855, DateTimeKind.Local).AddTicks(3982), new DateTime(2025, 8, 18, 1, 42, 39, 855, DateTimeKind.Local).AddTicks(3984), "9aa0ab6a-6956-4317-b2a8-8f4b42caf38b", new DateTime(2025, 8, 18, 1, 42, 39, 855, DateTimeKind.Local).AddTicks(3984) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 856, DateTimeKind.Local).AddTicks(3469), new DateTime(2025, 8, 18, 1, 42, 39, 856, DateTimeKind.Local).AddTicks(3473), "0bac4042-ed0e-4a78-a247-9550c0041475", new DateTime(2025, 8, 18, 1, 42, 39, 856, DateTimeKind.Local).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 857, DateTimeKind.Local).AddTicks(2807), new DateTime(2025, 8, 18, 1, 42, 39, 857, DateTimeKind.Local).AddTicks(2809), "ebe2d3ef-24ca-46dd-be2e-161c3113d06b", new DateTime(2025, 8, 18, 1, 42, 39, 857, DateTimeKind.Local).AddTicks(2809) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 858, DateTimeKind.Local).AddTicks(2374), new DateTime(2025, 8, 18, 1, 42, 39, 858, DateTimeKind.Local).AddTicks(2377), "2fd19447-7dee-46ee-831d-efaa07e3d8e8", new DateTime(2025, 8, 18, 1, 42, 39, 858, DateTimeKind.Local).AddTicks(2378) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 859, DateTimeKind.Local).AddTicks(2409), new DateTime(2025, 8, 18, 1, 42, 39, 859, DateTimeKind.Local).AddTicks(2413), "eba937ab-5435-4117-b4f8-9e6286d713c0", new DateTime(2025, 8, 18, 1, 42, 39, 859, DateTimeKind.Local).AddTicks(2413) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 860, DateTimeKind.Local).AddTicks(1868), new DateTime(2025, 8, 18, 1, 42, 39, 860, DateTimeKind.Local).AddTicks(1868), "920394f0-9b0d-49ae-9a6b-c7bad62eb69c", new DateTime(2025, 8, 18, 1, 42, 39, 860, DateTimeKind.Local).AddTicks(1869) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 861, DateTimeKind.Local).AddTicks(1911), new DateTime(2025, 8, 18, 1, 42, 39, 861, DateTimeKind.Local).AddTicks(1915), "fc9fc796-66a0-4e31-93f2-75d1c85d7f61", new DateTime(2025, 8, 18, 1, 42, 39, 861, DateTimeKind.Local).AddTicks(1916) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 862, DateTimeKind.Local).AddTicks(1857), new DateTime(2025, 8, 18, 1, 42, 39, 862, DateTimeKind.Local).AddTicks(1862), "5f391a09-48da-4ae9-b77d-0fa3ffbe42f7", new DateTime(2025, 8, 18, 1, 42, 39, 862, DateTimeKind.Local).AddTicks(1862) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 863, DateTimeKind.Local).AddTicks(1598), new DateTime(2025, 8, 18, 1, 42, 39, 863, DateTimeKind.Local).AddTicks(1604), "a5944109-ac83-41cf-a6fe-47b8fbb9c5cb", new DateTime(2025, 8, 18, 1, 42, 39, 863, DateTimeKind.Local).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 864, DateTimeKind.Local).AddTicks(827), new DateTime(2025, 8, 18, 1, 42, 39, 864, DateTimeKind.Local).AddTicks(829), "e3670694-b639-4997-add0-05c2e180daf0", new DateTime(2025, 8, 18, 1, 42, 39, 864, DateTimeKind.Local).AddTicks(829) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 865, DateTimeKind.Local).AddTicks(202), new DateTime(2025, 8, 18, 1, 42, 39, 865, DateTimeKind.Local).AddTicks(206), "1ee56781-f9b5-46f3-8bcd-0260d379720d", new DateTime(2025, 8, 18, 1, 42, 39, 865, DateTimeKind.Local).AddTicks(207) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 865, DateTimeKind.Local).AddTicks(9128), new DateTime(2025, 8, 18, 1, 42, 39, 865, DateTimeKind.Local).AddTicks(9129), "3d1782be-8652-4c74-a01b-bb3337c376d0", new DateTime(2025, 8, 18, 1, 42, 39, 865, DateTimeKind.Local).AddTicks(9130) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 866, DateTimeKind.Local).AddTicks(8348), new DateTime(2025, 8, 18, 1, 42, 39, 866, DateTimeKind.Local).AddTicks(8352), "0f8384e6-1983-458a-a115-02df9fee1a63", new DateTime(2025, 8, 18, 1, 42, 39, 866, DateTimeKind.Local).AddTicks(8352) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 867, DateTimeKind.Local).AddTicks(7518), new DateTime(2025, 8, 18, 1, 42, 39, 867, DateTimeKind.Local).AddTicks(7519), "1fbfe387-b5b4-482c-925f-4bf13b2c111e", new DateTime(2025, 8, 18, 1, 42, 39, 867, DateTimeKind.Local).AddTicks(7519) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 868, DateTimeKind.Local).AddTicks(6883), new DateTime(2025, 8, 18, 1, 42, 39, 868, DateTimeKind.Local).AddTicks(6886), "64899c94-e687-4471-bff4-c5fa5a8ed8ce", new DateTime(2025, 8, 18, 1, 42, 39, 868, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 869, DateTimeKind.Local).AddTicks(5794), new DateTime(2025, 8, 18, 1, 42, 39, 869, DateTimeKind.Local).AddTicks(5796), "a5697cfb-2125-4478-856e-906d741d7897", new DateTime(2025, 8, 18, 1, 42, 39, 869, DateTimeKind.Local).AddTicks(5796) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 870, DateTimeKind.Local).AddTicks(5157), new DateTime(2025, 8, 18, 1, 42, 39, 870, DateTimeKind.Local).AddTicks(5161), "16c2f0b5-6a03-4c92-bb17-4544112083c7", new DateTime(2025, 8, 18, 1, 42, 39, 870, DateTimeKind.Local).AddTicks(5162) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 871, DateTimeKind.Local).AddTicks(4139), new DateTime(2025, 8, 18, 1, 42, 39, 871, DateTimeKind.Local).AddTicks(4140), "b94f5ed0-0616-4a16-8462-04c493e28a7b", new DateTime(2025, 8, 18, 1, 42, 39, 871, DateTimeKind.Local).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 872, DateTimeKind.Local).AddTicks(3383), new DateTime(2025, 8, 18, 1, 42, 39, 872, DateTimeKind.Local).AddTicks(3388), "5b0a3871-37f9-46bd-9128-65614cda9b13", new DateTime(2025, 8, 18, 1, 42, 39, 872, DateTimeKind.Local).AddTicks(3388) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 873, DateTimeKind.Local).AddTicks(2437), new DateTime(2025, 8, 18, 1, 42, 39, 873, DateTimeKind.Local).AddTicks(2438), "c2155e6c-a94b-4cd4-b835-48e3c4e4a5a9", new DateTime(2025, 8, 18, 1, 42, 39, 873, DateTimeKind.Local).AddTicks(2439) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 874, DateTimeKind.Local).AddTicks(1806), new DateTime(2025, 8, 18, 1, 42, 39, 874, DateTimeKind.Local).AddTicks(1809), "fa07ecc5-9dcf-4994-b30c-cb8e7fbae319", new DateTime(2025, 8, 18, 1, 42, 39, 874, DateTimeKind.Local).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 875, DateTimeKind.Local).AddTicks(732), new DateTime(2025, 8, 18, 1, 42, 39, 875, DateTimeKind.Local).AddTicks(733), "fb89f69e-aca1-4bed-9219-e345b805b281", new DateTime(2025, 8, 18, 1, 42, 39, 875, DateTimeKind.Local).AddTicks(733) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 876, DateTimeKind.Local).AddTicks(70), new DateTime(2025, 8, 18, 1, 42, 39, 876, DateTimeKind.Local).AddTicks(74), "277ef383-8af0-4dc3-9007-925ce6b5026d", new DateTime(2025, 8, 18, 1, 42, 39, 876, DateTimeKind.Local).AddTicks(74) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 876, DateTimeKind.Local).AddTicks(9096), new DateTime(2025, 8, 18, 1, 42, 39, 876, DateTimeKind.Local).AddTicks(9097), "a7e3f902-1837-4f37-ba2f-9c2e1a1f86c5", new DateTime(2025, 8, 18, 1, 42, 39, 876, DateTimeKind.Local).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 878, DateTimeKind.Local).AddTicks(71), new DateTime(2025, 8, 18, 1, 42, 39, 878, DateTimeKind.Local).AddTicks(76), "ce0d675c-280a-4beb-9478-76c48abec8ef", new DateTime(2025, 8, 18, 1, 42, 39, 878, DateTimeKind.Local).AddTicks(76) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 879, DateTimeKind.Local).AddTicks(1159), new DateTime(2025, 8, 18, 1, 42, 39, 879, DateTimeKind.Local).AddTicks(1166), "67f5bade-781e-4c86-89bf-581fcbeb0bf1", new DateTime(2025, 8, 18, 1, 42, 39, 879, DateTimeKind.Local).AddTicks(1167) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 880, DateTimeKind.Local).AddTicks(1877), new DateTime(2025, 8, 18, 1, 42, 39, 880, DateTimeKind.Local).AddTicks(1878), "834df915-ccea-4b1b-9746-90d12f015091", new DateTime(2025, 8, 18, 1, 42, 39, 880, DateTimeKind.Local).AddTicks(1879) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 881, DateTimeKind.Local).AddTicks(1639), new DateTime(2025, 8, 18, 1, 42, 39, 881, DateTimeKind.Local).AddTicks(1644), "ce8965fc-426e-48f6-9894-85a51177bb1f", new DateTime(2025, 8, 18, 1, 42, 39, 881, DateTimeKind.Local).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 882, DateTimeKind.Local).AddTicks(3141), new DateTime(2025, 8, 18, 1, 42, 39, 882, DateTimeKind.Local).AddTicks(3142), "83501197-ab78-4cc0-a054-75e4efab6673", new DateTime(2025, 8, 18, 1, 42, 39, 882, DateTimeKind.Local).AddTicks(3142) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 883, DateTimeKind.Local).AddTicks(3511), new DateTime(2025, 8, 18, 1, 42, 39, 883, DateTimeKind.Local).AddTicks(3515), "cc49e4b1-359b-40ce-a492-fe6c293e5cf8", new DateTime(2025, 8, 18, 1, 42, 39, 883, DateTimeKind.Local).AddTicks(3515) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 884, DateTimeKind.Local).AddTicks(3199), new DateTime(2025, 8, 18, 1, 42, 39, 884, DateTimeKind.Local).AddTicks(3201), "3008142d-511a-4b44-ad54-71880f73c688", new DateTime(2025, 8, 18, 1, 42, 39, 884, DateTimeKind.Local).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 885, DateTimeKind.Local).AddTicks(2597), new DateTime(2025, 8, 18, 1, 42, 39, 885, DateTimeKind.Local).AddTicks(2601), "cd2917eb-f43a-4436-823b-fafcae7b9604", new DateTime(2025, 8, 18, 1, 42, 39, 885, DateTimeKind.Local).AddTicks(2601) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 886, DateTimeKind.Local).AddTicks(1500), new DateTime(2025, 8, 18, 1, 42, 39, 886, DateTimeKind.Local).AddTicks(1501), "f624d4b9-9d40-4b26-90f0-c99d9ecf74bc", new DateTime(2025, 8, 18, 1, 42, 39, 886, DateTimeKind.Local).AddTicks(1502) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 887, DateTimeKind.Local).AddTicks(737), new DateTime(2025, 8, 18, 1, 42, 39, 887, DateTimeKind.Local).AddTicks(740), "21b2fafd-c7e8-426f-95cf-c9bea02f2e41", new DateTime(2025, 8, 18, 1, 42, 39, 887, DateTimeKind.Local).AddTicks(741) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6697), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6698), "736130bb-301a-43aa-bf55-9bc5d5c33a6b", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6698) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6732), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6732), "0810070d-7896-4028-98e4-7b03b6622f04", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6733) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6738), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6738), "61205db6-250c-476d-bfb1-dbd317783ca0", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6743), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6743), "09104734-fbca-4b5c-92c2-f65b2afee22d", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6743) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6755), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6756), "16a0e294-e0b7-40ea-ac03-eafb896fddaa", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6762), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6762), "1cb9b18e-399d-479c-9926-5b3d2ae5af18", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6762) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6767), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6767), "c214fd17-45d3-4bf1-bf4b-059874bbd165", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6767) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6771), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6772), "6a82377c-13b4-4c5f-b970-69fad438dd30", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6772) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6779), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6779), "59eac489-5908-4cb7-a2e6-266519cb7ab1", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6779) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6784), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6784), "f1bbd3f6-c497-4f38-9b14-202743790cfd", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6789), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6789), "5a1b1d20-7841-4c75-81a0-5edf2577c31d", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6824), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6824), "e64a9e0d-11e6-450b-a2d3-7af33a92a5ac", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6824) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6833), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6833), "54540955-6d43-4140-a739-578d217f3c6e", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6834) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6839), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6839), "bcdd3971-336c-43a5-93ca-dd7e18a44d28", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6839) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6843), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6844), "37e7cc67-edca-42d2-a970-bfbec7e81877", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6844) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6848), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6848), "00f7a7cf-fb5a-4c90-961c-45e36742ac13", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6855), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6855), "1ab83607-85a5-4549-a5f4-4a76f1dd20d9", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6861), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6861), "41ce9fc5-314e-48ef-a4d6-e233ac84a5c5", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6861) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6865), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6865), "9544cc19-6ae3-4fba-85d2-95576ec20607", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6866) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6869), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6870), "2701b93b-d9e9-4414-94cf-5a22f5761bbf", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6878), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6878), "42958212-eb83-4bf2-b364-6648f8eabd11", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6879) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6882), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6883), "f2193e7e-fb91-4aff-9ae9-21a23e8b7e27", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6883) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6887), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6888), "248f7c2e-5f7b-43b7-939c-251e2c789373", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6888) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6892), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6892), "12ce5253-55ad-4430-b9f4-ca94425f1584", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6892) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6899), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6899), "fdc67280-5f88-47aa-8579-03568973f8ab", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6899) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6903), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6903), "e8c74dd4-d161-46a2-ad95-f6fb6313f281", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6907), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6908), "474dacb7-d507-4482-9b99-be35f59b50cf", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6908) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6912), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6912), "8a004e98-5262-4cae-97a2-e99d19218d9f", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6912) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6923), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6923), "e5e75b1b-514b-4a42-b149-62b3ab9c5b9d", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6928), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6929), "ce08addd-995e-465e-992e-e584cb94575a", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6929) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6934), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6934), "51ae4c54-f742-4b7a-be8f-103065131d75", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6934) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6938), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6938), "616701cd-d911-4a24-a4d8-82aed45e1376", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6939) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6943), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6943), "ac3014c9-58dc-45d9-bb55-bff98b5342c5", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6943) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6948), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6949), "a8795bff-0e14-44b6-8a64-0a68b743e5a5", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6949) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6954), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6954), "c6f888cc-d8d9-4272-a427-55e7a31d837a", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6954) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6976), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6976), "0b2b1f73-780f-4c96-950d-7dee43dd0d2e", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6977) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6983), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6983), "c88ae196-79bc-4928-ae01-94ee540f527d", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6983) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6987), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6988), "de1e0e0c-bb2e-4f19-a093-e9f5bba4dc6f", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6988) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6993), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6993), "40315b4b-a0a5-4814-af53-fe9527b9ee35", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6994) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6998), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6998), "008e3627-e859-4dac-94f9-40d7ee326b6f", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(6998) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7003), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7003), "62746c6b-3a76-448f-920c-700b07dd0eee", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7003) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7008), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7008), "5ea926fb-8522-4b74-948e-af23ce390b3d", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7008) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7012), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7013), "552c0d00-04f1-437c-bc47-61f6deb2337e", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7017), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7017), "5a6868c8-55f9-4a6d-b270-f76f2064b08f", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7017) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7023), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7023), "1fc6b4b2-914c-4365-9930-71ddff7654aa", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7024) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7027), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7028), "958a9ae8-439e-4dd1-b55f-6af3479654a5", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7028) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7032), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7033), "c6fea9d1-fc55-4d18-82ad-6036feab6afe", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7033) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7037), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7037), "0882320d-aaf7-4738-ba17-867c0fa26433", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7038) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7042), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7042), "15b25c65-0439-4b32-9841-fb980cb33e7c", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7042) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7046), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7046), "65a64e57-2d89-495e-b26a-07ad9c7cef13", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7047) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7051), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7051), "6d230979-e17e-48ae-986b-78a91d04f11b", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7051) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7055), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7056), "f7190230-4bdc-4b06-b1ec-45cf963c7aef", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7056) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7061), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7062), "7c01e1cb-134b-4bd3-bcbf-99d724a85b6b", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7062) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7066), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7066), "b26415a8-0c0b-4a23-ba4e-041f5f03f74d", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7066) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7070), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7070), "c311827f-1878-4d82-bbac-0c549cb26bf4", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7071) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7075), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7075), "5573f31c-b77d-4172-885e-207412d3f43e", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7079), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7079), "281f9d8d-b061-4a57-9498-583d7a114046", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7083), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7084), "b40aba1b-c34e-4e19-a978-b1dd119d1b90", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7088), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7088), "2c4f4dbf-c08a-4fe1-b754-51c21093f6e1", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7092), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7093), "d0edcbed-1e24-4847-92aa-248a97db5b4e", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7093) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7098), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7098), "99d72d9a-6a04-4a3f-a3fa-e2bf212f8c8e", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7099) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7102), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7103), "5635c264-0149-44a5-8e71-c20bc083d5fc", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7103) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7107), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7107), "4d2dd05c-81a9-48b8-85b7-a135b583a32b", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7107) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7111), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7112), "6f96e632-6662-4656-8abe-3376c2638e6b", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7112) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7116), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7116), "8827cda3-9290-4da1-a622-47e320f6ed61", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7162), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7163), "3674ee14-bd60-4656-84f2-c64bef2751ab", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7168), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7169), "b52e226a-ca97-407c-9483-a289599085e3", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7169) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7173), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7174), "d885cb11-5174-4c87-95ff-a7bc0ad9b14c", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7174) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7180), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7180), "daf38abc-225f-40fb-b4ab-5e05fe6708df", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7181) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7185), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7185), "81f8d919-3a6d-4008-b5c1-c9e553a4bc85", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7185) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7227), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7227), "ea191867-bc48-45dd-858e-58aaa9025aa3", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7228) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7239), 12, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7239), "4e99d3fa-a428-4bee-817e-aed1ebaa1204", 1, new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "ShiftDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7244), 11, new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7244), "024a5365-fffe-4383-b549-7830ae1e6fbb", new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7245) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7251), 12, new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7251), "23c131c7-8af6-4baa-9197-6d813a0f820c", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7251) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7257), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7257), "8de6bc8f-3106-49d1-ab07-b4d65e7d87ba", 2, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7257) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7262), 11, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7262), "06c947f2-caf1-4c7a-85d5-bad2faf1581a", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7263) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7269), 12, new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7269), "54b798de-e171-4438-ab36-f97f0bf5fdc0", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7269) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "ShiftDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7273), 11, new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7274), "aa43a90b-ee23-4b66-8231-e4cd349b31e8", new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7274) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7280), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7280), "e4242fb5-9713-4453-8f79-6cd04fae5417", 2, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7284), 12, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7284), "994e27d9-9e54-4e32-bf97-b61992402b1c", 1, new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7285) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7288), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7289), "65fbfefc-20b3-4e10-85e7-c3dc47418835", 2, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7293), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7293), "36ba67d2-6d78-4eb0-9687-4eb73811a352", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7294) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7300), 11, new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7300), "2787a0ac-3722-49a8-af76-f2cea75903f6", 2, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "ShiftDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7304), 12, new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7304), "bbba5c13-cebb-423e-a61c-5f457cafaeb0", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7305) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7309), 11, new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7309), "d2f73531-6a35-4d68-b1e8-63c53893a718", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7309) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7315), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7315), "0a0d02f2-be1c-44a1-b207-fa53c3533251", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7319), 12, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7320), "2fdfb96d-e567-40aa-84d4-2c8a1f695826", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7324), 11, new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7325), "274d1c4d-3228-45cf-b63b-7e69929b3f8e", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7325) });

            migrationBuilder.InsertData(
                table: "Shifts",
                columns: new[] { "Id", "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "SelectedStatus", "ShiftDate", "ShiftType", "StartTime", "UpdatedComputerName", "UpdatedDate" },
                values: new object[] { 89, new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7331), 12, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7331), "6bf014fb-de62-471f-a649-2988526655dc", 0, new DateTime(2025, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7331) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Haskellfurt", "Democratic People's Republic of Korea", new DateTime(2025, 8, 18, 1, 42, 14, 152, DateTimeKind.Local).AddTicks(1498), "6188 Durgan Summit, Glennafurt, Germany", "7", "SE5011002851400303850217", "1-748-369-0282", "Shakira81@hotmail.com", new DateTime(2025, 8, 18, 1, 42, 14, 152, DateTimeKind.Local).AddTicks(1508), "Dangelo", "Breitenberg", "cc218a02-de72-4808-b479-fcd963203f70", "01156", new DateTime(2025, 8, 18, 1, 42, 14, 152, DateTimeKind.Local).AddTicks(1508) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "New Monte", "Angola", new DateTime(2025, 8, 18, 1, 42, 14, 152, DateTimeKind.Local).AddTicks(2289), "145 Lou Stream, Bentonfurt, Senegal", "6", "DE05007438418097100125", "(215) 962-3202 x172", "Eveline27@yahoo.com", new DateTime(2025, 8, 18, 1, 42, 14, 152, DateTimeKind.Local).AddTicks(2289), "Marian", "Leannon", "12564d55-8154-4c99-bcad-8555402f2520", "63567", new DateTime(2025, 8, 18, 1, 42, 14, 152, DateTimeKind.Local).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "North Consuelo", "Brunei Darussalam", new DateTime(2025, 8, 18, 1, 42, 14, 152, DateTimeKind.Local).AddTicks(2543), "4292 Larson Port, Tobinfurt, Bulgaria", "6", "RS46028226895503815262", "725-548-3091 x69662", "Keely.Tromp@yahoo.com", new DateTime(2025, 8, 18, 1, 42, 14, 152, DateTimeKind.Local).AddTicks(2543), "Enoch", "Bechtelar", "ec625c20-7174-4eb1-ace3-9c7540b1624d", "26576-8508", new DateTime(2025, 8, 18, 1, 42, 14, 152, DateTimeKind.Local).AddTicks(2544) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Nienowshire", "Andorra", new DateTime(2025, 8, 18, 1, 42, 14, 152, DateTimeKind.Local).AddTicks(2769), "98401 Luettgen Isle, Schambergerview, Cook Islands", "6", "MU24PNMF8401904870040730897TAG", "278-244-3088 x4854", "Kurt80@gmail.com", new DateTime(2025, 8, 18, 1, 42, 14, 152, DateTimeKind.Local).AddTicks(2769), "Melyssa", "Gerlach", "c8ffc443-4a44-447e-89a8-adeffa9bed54", "39813", new DateTime(2025, 8, 18, 1, 42, 14, 152, DateTimeKind.Local).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "South Selena", "Singapore", new DateTime(2025, 8, 18, 1, 42, 14, 152, DateTimeKind.Local).AddTicks(3025), "379 Delbert Points, West Bradyfurt, Greece", "7", "SE4200668880032472007055", "(382) 372-8721", "Althea.Hintz@yahoo.com", new DateTime(2025, 8, 18, 1, 42, 14, 152, DateTimeKind.Local).AddTicks(3025), "Karina", "Sauer", "3165c9fe-f0fe-405d-a6c6-4bb26be52bc4", "25648", new DateTime(2025, 8, 18, 1, 42, 14, 152, DateTimeKind.Local).AddTicks(3025) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "East Nikita", "Iraq", new DateTime(2025, 8, 18, 1, 42, 14, 152, DateTimeKind.Local).AddTicks(3253), "81195 Sidney Turnpike, Tessiefurt, New Caledonia", "4", "GL1004171212522142", "(615) 226-6688", "Dannie.Kuhic40@hotmail.com", new DateTime(2025, 8, 18, 1, 42, 14, 152, DateTimeKind.Local).AddTicks(3254), "Hyman", "Pacocha", "78182680-ef4d-45cb-85a6-d559220086d2", "86952", new DateTime(2025, 8, 18, 1, 42, 14, 152, DateTimeKind.Local).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Stoltenbergville", "Thailand", new DateTime(2025, 8, 18, 1, 42, 14, 152, DateTimeKind.Local).AddTicks(3456), "533 Vandervort Lodge, South Kaylieburgh, Saudi Arabia", "7", "TL440562510013100020845", "435.214.8745 x00123", "Yasmine_Zulauf@yahoo.com", new DateTime(2025, 8, 18, 1, 42, 14, 152, DateTimeKind.Local).AddTicks(3457), "Hoyt", "Maggio", "3a66f538-89a4-4256-b607-18e3fcc8b298", "38160-2313", new DateTime(2025, 8, 18, 1, 42, 14, 152, DateTimeKind.Local).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Bartholomeborough", "Jordan", new DateTime(2025, 8, 18, 1, 42, 14, 152, DateTimeKind.Local).AddTicks(3673), "440 Aniya Haven, Breanabury, Uganda", "8", "PS3094QB070005151844616637484", "1-828-491-2964 x719", "Taya_Tillman@yahoo.com", new DateTime(2025, 8, 18, 1, 42, 14, 152, DateTimeKind.Local).AddTicks(3673), "Miguel", "Thompson", "15ee9ca1-5758-4bf1-ad98-3f4e99cf625c", "69069", new DateTime(2025, 8, 18, 1, 42, 14, 152, DateTimeKind.Local).AddTicks(3673) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Tomberg", "New Zealand", new DateTime(2025, 8, 18, 1, 42, 14, 152, DateTimeKind.Local).AddTicks(3907), "77325 Koss Streets, North George, French Guiana", "4", "GR4600245784G769MF1630445Z4", "(246) 541-2923 x473", "Akeem.Senger@yahoo.com", new DateTime(2025, 8, 18, 1, 42, 14, 152, DateTimeKind.Local).AddTicks(3907), "Kenny", "Jast", "9b2372da-2ccf-4d46-aa61-7fa2d9d52f99", "68517-1527", new DateTime(2025, 8, 18, 1, 42, 14, 152, DateTimeKind.Local).AddTicks(3908) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "New Adityaburgh", "Lithuania", new DateTime(2025, 8, 18, 1, 42, 14, 152, DateTimeKind.Local).AddTicks(4141), "95122 Weston Drive, Moenfurt, British Indian Ocean Territory (Chagos Archipelago)", "9", "IT63W0063225478573977F85087", "(498) 636-6296", "Percy_Will79@hotmail.com", new DateTime(2025, 8, 18, 1, 42, 14, 152, DateTimeKind.Local).AddTicks(4141), "Bertrand", "Daugherty", "1abc3149-70a2-4760-be80-78ce23bfda0a", "03575", new DateTime(2025, 8, 18, 1, 42, 14, 152, DateTimeKind.Local).AddTicks(4141) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Afyon", "Endonezya", new DateTime(2025, 8, 18, 1, 42, 14, 272, DateTimeKind.Local).AddTicks(9871), "Basgan.Kasapoglu30@gmail.com", "Ergenekon Sokak   82b, Tunceli, Niue, Yeni Zelanda", "Bekeçtegin", "Kılıççı", "+90-388-873-4-051", new DateTime(2025, 8, 18, 1, 42, 14, 272, DateTimeKind.Local).AddTicks(9883), "e6d2e332-e9f4-4969-8770-ad57cfc55670", "1", new DateTime(2025, 8, 18, 1, 42, 14, 272, DateTimeKind.Local).AddTicks(9884) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Samsun", "Guadalup, Fransa", new DateTime(2025, 8, 18, 1, 42, 14, 273, DateTimeKind.Local).AddTicks(2369), "Bekazil46@hotmail.com", "Harman Yolu Sokak  79, Kırşehir, Guyana", "Bastuğrul", "Sinanoğlu", "+90-332-041-69-60", new DateTime(2025, 8, 18, 1, 42, 14, 273, DateTimeKind.Local).AddTicks(2375), "832df453-ac47-4733-88be-c252508c6cf3", new DateTime(2025, 8, 18, 1, 42, 14, 273, DateTimeKind.Local).AddTicks(2376) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "İzmir", "Mayotte, Fransa", new DateTime(2025, 8, 18, 1, 42, 14, 273, DateTimeKind.Local).AddTicks(3114), "Akata_Demirel60@yahoo.com", "Nalbant Sokak 06, Van, Lüksemburg", "Bönge", "Öymen", "+90-362-974-8-596", new DateTime(2025, 8, 18, 1, 42, 14, 273, DateTimeKind.Local).AddTicks(3115), "2a19bd9d-4f60-4305-9c25-c629aa0e00a2", new DateTime(2025, 8, 18, 1, 42, 14, 273, DateTimeKind.Local).AddTicks(3116) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Aydın", "Virgin Adaları, Amerika", new DateTime(2025, 8, 18, 1, 42, 14, 273, DateTimeKind.Local).AddTicks(3618), "Altinoba7@gmail.com", "Kocatepe Caddesi 79c, Adana, Brezilya", "Artıınal", "Ertepınar", "+90-515-518-24-81", new DateTime(2025, 8, 18, 1, 42, 14, 273, DateTimeKind.Local).AddTicks(3619), "ec97d282-a7b9-4903-a0a2-e9958ecc6e4e", new DateTime(2025, 8, 18, 1, 42, 14, 273, DateTimeKind.Local).AddTicks(3620) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Muş", "Santa Lucia", new DateTime(2025, 8, 18, 1, 42, 14, 273, DateTimeKind.Local).AddTicks(4166), "Imrem_Akyuz3@yahoo.com", "Dağınık Evler Sokak 21b, Muğla, Kuzey İrlanda", "Ekim", "Erbay", "+90-570-408-05-75", new DateTime(2025, 8, 18, 1, 42, 14, 273, DateTimeKind.Local).AddTicks(4167), "57fa62f3-198f-44e3-af4e-30edb2d58dd1", new DateTime(2025, 8, 18, 1, 42, 14, 273, DateTimeKind.Local).AddTicks(4168) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Kocaeli", "Somali", new DateTime(2025, 8, 18, 1, 42, 14, 273, DateTimeKind.Local).AddTicks(4635), "Begcur_Velioglu58@yahoo.com", "Nalbant Sokak 69, Edirne, Gambiya", "Kızdurmuş", "Öztuna", "+90-638-461-81-00", new DateTime(2025, 8, 18, 1, 42, 14, 273, DateTimeKind.Local).AddTicks(4636), "311cfee6-45ca-42ea-b835-7ebe0113cf75", new DateTime(2025, 8, 18, 1, 42, 14, 273, DateTimeKind.Local).AddTicks(4637) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Iğdır", "Amerikan Samoa", new DateTime(2025, 8, 18, 1, 42, 14, 273, DateTimeKind.Local).AddTicks(5121), "Kimizalmila_Keseroglu20@yahoo.com", "Mevlana Sokak 87c, Batman, Lübnan", "Anıl", "Hamzaoğlu", "+90-639-669-4-950", new DateTime(2025, 8, 18, 1, 42, 14, 273, DateTimeKind.Local).AddTicks(5122), "38669837-5d35-4ece-99b2-89d3ed36ea83", "1", new DateTime(2025, 8, 18, 1, 42, 14, 273, DateTimeKind.Local).AddTicks(5122) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Batman", "Katar", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(1526), "Aldogan27@hotmail.com", "Bayır Sokak 2, Adana, Ekvator", "Belek", "Hamzaoğlu", "+90-366-022-9-674", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(1539), "020aaeab-bdce-4fdf-849d-ab113ec2cf7e", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(1541) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Isparta", "Mikronezya", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(3105), "Ay.Kececi@yahoo.com", "Sağlık Sokak 9, Bilecik, Midway Adaları, Amerika", "Bargan", "Balcı", "+90-509-935-61-27", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(3108), "b7cd6a28-e2d3-42a4-9685-8a1b79f0e87e", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(3109) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Amasya", "Anguilla, İngiltere", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(3615), "Baltaci.Ozkok71@gmail.com", "Atatürk Bulvarı 065, İstanbul, Nijerya", "Baybars", "Topçuoğlu", "+90-948-491-74-52", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(3615), "5c159a28-10cc-4201-aa96-65ba86880ec4", "0", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Giresun", "Madagaskar", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(4119), "Kimizin.Akman62@gmail.com", "Bandak Sokak 13, Düzce, Midway Adaları, Amerika", "Ayaz", "Orbay", "+90-586-043-15-34", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(4120), "5feac337-1643-4d20-b5d6-ed149fc15e83", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(4120) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Amasya", "İsviçre", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(4555), "Baga_Catalbas@gmail.com", "Nalbant Sokak 82b, Tekirdağ, Kamerun", "Atasagun", "Bolatlı", "+90-826-180-7-006", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(4556), "abcd48ef-3cb2-4ee6-95f2-08978eb4c558", "0", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(4557) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Ordu", "Mali", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(4943), "Buzactutuk_Oymen82@hotmail.com", "Harman Altı Sokak 06a, Adana, Mozambik", "Boğaç", "Dağdaş", "+90-994-375-95-70", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(4944), "13e060cb-a053-49f6-afc1-71d77d096490", "0", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(4945) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Kastamonu", "Güney Kıbrıs Rum Yönetimi", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(5341), "Guvercin.Kasapoglu60@hotmail.com", "Gül Sokak 0, Yalova, İspanya", "Bars", "Numanoğlu", "+90-635-952-88-27", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(5342), "254c1ae4-0a7e-4584-aafa-dba9f9ac2018", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(5343) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Artvin", "Mikronezya", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(5711), "Baydemir73@yahoo.com", "Okul Sokak 08c, Nevşehir, Arnavutluk", "Edil", "Karaduman", "+90-029-852-0-906", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(5711), "0aba090e-a99c-4ed5-8687-de53b3124583", "1", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Gümüşhane", "Hırvatistan", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(6196), "Cagribeg.Alniacik@hotmail.com", "Sarıkaya Caddesi 58b, Iğdır, Kenya", "Bayrı", "Öztuna", "+90-053-130-7-136", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(6198), "4cde978a-8fdc-4e47-820e-afbab29afeb5", "1", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(6198) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Sinop", "Folkland Adaları, İngiltere", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(6600), "Arslansungur_Demirbas@hotmail.com", "İsmet Paşa Caddesi 24a, Kırıkkale, Haiti", "Akdemir", "Çamdalı", "+90-307-101-32-67", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(6601), "7d651608-f247-4a78-8062-22e184b42b0d", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(6601) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Batman", "Dominik Cumhuriyeti", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(7078), "Aybalta0@yahoo.com", "Mevlana Sokak 12, Çorum, Andorra", "Bağaturipi", "Duygulu", "+90-688-031-97-10", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(7079), "bd8063c3-0a66-4417-964f-b2207fa4a56f", "1", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Gümüşhane", "Birmanya (Myanmar)", new DateTime(2025, 8, 18, 1, 42, 14, 282, DateTimeKind.Local).AddTicks(7825), "Bugu.Orge2@yahoo.com", "Fatih Sokak  9, Ordu, Fildişi Sahili", "Barkdoğdu", "Karaduman", "+90-495-420-7-110", new DateTime(2025, 8, 18, 1, 42, 14, 282, DateTimeKind.Local).AddTicks(7838), "f3a89968-76cd-4e0c-92d1-648b05aa9010", "1", new DateTime(2025, 8, 18, 1, 42, 14, 282, DateTimeKind.Local).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Manisa", "İsveç", new DateTime(2025, 8, 18, 1, 42, 14, 282, DateTimeKind.Local).AddTicks(9365), "Arslantegin.Alpugan88@gmail.com", "Bahçe Sokak 498, Aydın, Fransa", "Ayruk", "Samancı", "+90-984-120-8-346", new DateTime(2025, 8, 18, 1, 42, 14, 282, DateTimeKind.Local).AddTicks(9367), "5f9af7fb-60e8-4c04-a650-dfa837118709", "0", new DateTime(2025, 8, 18, 1, 42, 14, 282, DateTimeKind.Local).AddTicks(9368) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Muş", "Tayvan", new DateTime(2025, 8, 18, 1, 42, 14, 282, DateTimeKind.Local).AddTicks(9856), "Buzactutuk_Ozdenak2@hotmail.com", "Köypınar Sokak 10c, Nevşehir, Mozambik", "Avşar", "Durak ", "+90-297-615-63-68", new DateTime(2025, 8, 18, 1, 42, 14, 282, DateTimeKind.Local).AddTicks(9857), "e47d193c-1d77-45cb-9a56-ee1e3b7855c8", new DateTime(2025, 8, 18, 1, 42, 14, 282, DateTimeKind.Local).AddTicks(9858) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Tokat", "Ukrayna", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(264), "Ceykun.Kocabiyik56@hotmail.com", "Mevlana Sokak 34a, Nevşehir, Cape Verde", "Bıtaybıkı", "Özdoğan", "+90-375-368-5-179", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(265), "e46713d5-da0b-4b23-b68e-307b5d3d4e4b", "0", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Ağrı", "Uganda", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(648), "Asantugrul_Evliyaoglu@gmail.com", "İsmet Paşa Caddesi 00, Uşak, Sudan", "Gökçiçek", "Ertepınar", "+90-128-060-99-11", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(649), "0d70499c-e3da-4478-aa41-cb8905810dcf", "0", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(650) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Antalya", "Makau (Makao)", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(1021), "Adik.Sadiklar@hotmail.com", "İsmet Attila Caddesi 54b, Afyon, Midway Adaları, Amerika", "Azıl", "Adan", "+90-216-969-90-65", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(1022), "c1171fd6-96c5-4359-b1bb-58d0b54a0556", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(1023) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Denizli", "Fransız Polinezyası", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(1398), "Akibudak37@gmail.com", "İsmet Paşa Caddesi 63b, Iğdır, Togo", "Kazanç", "Poyrazoğlu", "+90-399-067-1-103", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(1399), "1fe58310-023a-4d78-94cc-e09c9eab8f01", "0", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(1399) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Isparta", "İspanya", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(1780), "Arikdoruk_Pektemek26@hotmail.com", "Ülkü Sokak 288, Burdur, Antigua ve Barbuda", "Batuk", "Sepetçi", "+90-975-369-75-14", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(1781), "3bf69434-7446-4b69-bc02-2beea2d94c83", "1", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(1782) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Kocaeli", "Peru", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(2151), "Askin.Cevik36@gmail.com", "Gül Sokak 68c, Artvin, Antigua ve Barbuda", "Eğrim", "Karadaş", "+90-835-612-92-98", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(2152), "cac87122-2d0f-4b1b-b6f2-aa8d834bf8ad", "1", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(2153) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Düzce", "Cibuti", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(2844), "Ardic86@gmail.com", "Harman Altı Sokak 52a, Burdur, Grenada", "Artuk", "Abacı", "+90-231-140-84-87", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(2849), "b85ee7d8-e179-4afe-89ea-a9d7b1d80889", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Isparta", "Kuveyt", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(3229), "Adberilgen_Tahincioglu8@yahoo.com", "Gül Sokak 22c, Kırıkkale, Küba", "Egemen", "Mertoğlu", "+90-419-234-66-94", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(3231), "d40cc4cb-9e3d-4680-89a3-3785594bac2e", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(3231) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Nevşehir", "Vietnam", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(2954), "Ila11@gmail.com", "Bahçe Sokak 54a, Eskişehir, Irak", "Alptegin", "Tunçeri", "+90-091-789-63-93", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(2964), "ae4dfd0a-c701-47b5-ae12-f4be4a672307", "1", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(2966) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Van", "Sierra Leone", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(4531), "Cocukboru_Baturalp5@yahoo.com", "Sarıkaya Caddesi 09a, Şanlıurfa, Kazakistan", "Buyançuk", "Karabulut", "+90-781-410-57-16", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(4534), "5bead8e8-32f9-4610-a9d6-8cd98becc824", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(4535) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Tekirdağ", "Danimarka", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(5044), "Alpagut.Yildirim@gmail.com", "Barış Sokak 02c, Iğdır, Hırvatistan", "Atıgay", "Özbey", "+90-862-014-84-91", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(5046), "b8fdd865-8654-4776-bc0f-f3197b8a1496", "1", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(5046) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Bursa", "San Marino", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(5475), "Imrem9@hotmail.com", "Ergenekon Sokak   98b, Kırıkkale, Hollanda", "Bakağul", "Kılıççı", "+90-989-980-7-376", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(5476), "82af53ba-e1d0-4650-a58a-ffa13ab3a80d", "1", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(5476) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Nevşehir", "Rusya Federasyonu", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(5836), "Bonek29@hotmail.com", "Lütfi Karadirek Caddesi 43c, Çankırı, Tanzanya", "Beğbars", "Beşerler", "+90-242-711-48-63", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(5837), "e3ec7503-42e3-4cda-aecc-837fe76e7a13", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(5838) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Nevşehir", "Tuvalu", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(6185), "Begi19@gmail.com", "Harman Altı Sokak 58b, Kütahya, Kırgızistan", "Bilig", "Aşıkoğlu", "+90-007-288-1-717", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(6186), "30ce0fc1-0940-4988-a8ab-b7b5cbd4ec21", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(6186) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Bayburt", "Amerika Birleşik Devletleri", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(6522), "Buyruk_Aydan88@hotmail.com", "Sarıkaya Caddesi 21b, Bursa, Amerikan Samoa", "Atılgan", "Erez", "+90-231-739-34-11", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(6522), "0d4c82c1-c497-4f94-8979-01b35a6b9161", "0", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(6523) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Konya", "Arnavutluk", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(6870), "Bastar.Aksit70@yahoo.com", "30 Ağustos Caddesi 77, Denizli, Lüksemburg", "Amaç", "Karabulut", "+90-749-226-78-25", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(6871), "7daddef2-cbd2-4938-86d6-32cabc947afc", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(6872) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Zonguldak", "Montserrat", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(7213), "Cagribeg_Ilicali54@yahoo.com", "Sıran Söğüt Sokak 951, Tokat, Azerbaycan", "Aydoğan", "Limoncuoğlu", "+90-218-097-7-092", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(7214), "7d84c34a-4c7c-4682-9de5-53c39d1306cc", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(7215) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Çorum", "Bosna Hersek", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(7558), "Bugduzemen_Balci@gmail.com", "Ali Çetinkaya Caddesi 2, Çorum, Sri Lanka", "Ayaz", "Durak ", "+90-186-209-39-88", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(7559), "f27f4a98-f6e0-40ca-8dd4-1462e1f9d5a2", "0", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(7560) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Giresun", "Makedonya", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(7920), "Barbol41@yahoo.com", "Sevgi Sokak 31b, Bilecik, Gine-Bissau", "Arslansungur", "Arıcan", "+90-522-890-6-636", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(7921), "f2f1766e-f00e-474e-ae56-da3a48098b67", "1", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(7922) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Balıkesir", "Suudi Arabistan", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(8269), "Bumin_Tuzun45@yahoo.com", "Sağlık Sokak 54b, Malatya, Karadağ", "Balakatay", "Atan", "+90-778-616-08-22", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(8270), "4a94ff18-e991-46e5-a209-ab7b11a46fb6", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(8271) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Amasya", "İngiltere", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(8602), "Altankagan.Catalbas@hotmail.com", "Sevgi Sokak 3, Çankırı, Tayland", "Ebkızı", "Öztonga", "+90-834-794-80-74", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(8603), "4ac2d919-dac8-4e84-9bcd-8b446688e47c", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(8604) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Niğde", "Aruba, Hollanda", new DateTime(2025, 8, 18, 1, 42, 14, 292, DateTimeKind.Local).AddTicks(6182), "Afsin.Turkyilmaz@hotmail.com", "Ergenekon Sokak   66c, Osmaniye, Surinam", "Bukaktutuk", "Tekelioğlu", "+90-716-669-3-042", new DateTime(2025, 8, 18, 1, 42, 14, 292, DateTimeKind.Local).AddTicks(6196), "60b831ae-dba7-492c-b85d-6f7b15130438", "0", new DateTime(2025, 8, 18, 1, 42, 14, 292, DateTimeKind.Local).AddTicks(6197) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Şırnak", "İtalya", new DateTime(2025, 8, 18, 1, 42, 14, 296, DateTimeKind.Local).AddTicks(8855), "Bagis.Daglaroglu65@yahoo.com", "İsmet Attila Caddesi 44c, Hatay, Çek Cumhuriyeti", "Gülegen", "Yalçın", "+90-840-848-3-075", new DateTime(2025, 8, 18, 1, 42, 14, 296, DateTimeKind.Local).AddTicks(8866), "d35b879e-b8ee-48b1-9922-a3001b08c54c", "0", new DateTime(2025, 8, 18, 1, 42, 14, 296, DateTimeKind.Local).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 267, DateTimeKind.Local).AddTicks(5882), new DateTime(2025, 8, 18, 1, 42, 14, 267, DateTimeKind.Local).AddTicks(5890), 440.66m, new DateTime(2025, 1, 1, 8, 23, 31, 949, DateTimeKind.Local).AddTicks(3661), "Non debitis nihil aliquid.", "Handmade Wooden Table", "665b6a22-747c-43c5-8f6a-fc25b15426ba", 10, new DateTime(2025, 8, 18, 1, 42, 14, 267, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 267, DateTimeKind.Local).AddTicks(6358), new DateTime(2025, 8, 18, 1, 42, 14, 267, DateTimeKind.Local).AddTicks(6359), 287.00m, new DateTime(2025, 4, 2, 19, 11, 42, 610, DateTimeKind.Local).AddTicks(5472), "Qui consequatur enim qui deserunt alias dolorem.", "Handcrafted Cotton Ball", "27df93fe-9d5e-4caf-b007-ae88195a14f2", 2, new DateTime(2025, 8, 18, 1, 42, 14, 267, DateTimeKind.Local).AddTicks(6359) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 267, DateTimeKind.Local).AddTicks(6460), new DateTime(2025, 8, 18, 1, 42, 14, 267, DateTimeKind.Local).AddTicks(6460), 564.01m, new DateTime(2025, 3, 25, 21, 40, 44, 749, DateTimeKind.Local).AddTicks(9693), "İd debitis nihil quis.", "Generic Fresh Tuna", "17d4d442-e12c-4bb7-b02f-afc75a0b2013", 3, new DateTime(2025, 8, 18, 1, 42, 14, 267, DateTimeKind.Local).AddTicks(6461) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 267, DateTimeKind.Local).AddTicks(6547), new DateTime(2025, 8, 18, 1, 42, 14, 267, DateTimeKind.Local).AddTicks(6547), 326.90m, new DateTime(2025, 2, 11, 4, 33, 17, 400, DateTimeKind.Local).AddTicks(296), "Aliquid quisquam omnis voluptas ea.", "Incredible Wooden Computer", "6d0bb4a8-ea01-4611-a798-6e39573ca6bb", 6, new DateTime(2025, 8, 18, 1, 42, 14, 267, DateTimeKind.Local).AddTicks(6548) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 267, DateTimeKind.Local).AddTicks(6703), new DateTime(2025, 8, 18, 1, 42, 14, 267, DateTimeKind.Local).AddTicks(6704), 228.45m, new DateTime(2025, 8, 6, 13, 4, 17, 474, DateTimeKind.Local).AddTicks(6675), "Officiis velit illum inventore ratione.", "Tasty Cotton Table", "a14b5169-df31-4d3a-9716-9c0c1b94be5b", 9, new DateTime(2025, 8, 18, 1, 42, 14, 267, DateTimeKind.Local).AddTicks(6705) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 267, DateTimeKind.Local).AddTicks(6773), new DateTime(2025, 8, 18, 1, 42, 14, 267, DateTimeKind.Local).AddTicks(6774), 592.09m, new DateTime(2025, 8, 17, 15, 59, 42, 353, DateTimeKind.Local).AddTicks(4344), "İd rem qui et dolorum.", "Sleek Cotton Shoes", "9b382480-3f79-4f2b-a32a-615ee914f841", 1, new DateTime(2025, 8, 18, 1, 42, 14, 267, DateTimeKind.Local).AddTicks(6774) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 267, DateTimeKind.Local).AddTicks(6852), new DateTime(2025, 8, 18, 1, 42, 14, 267, DateTimeKind.Local).AddTicks(6853), 456.33m, new DateTime(2025, 6, 7, 10, 51, 22, 343, DateTimeKind.Local).AddTicks(4109), "Aperiam aliquid debitis hic sit et veniam perferendis ab.", "Licensed Granite Soap", "ed320c50-fbe4-4277-8e34-481f66162f09", 6, new DateTime(2025, 8, 18, 1, 42, 14, 267, DateTimeKind.Local).AddTicks(6859) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 267, DateTimeKind.Local).AddTicks(6963), new DateTime(2025, 8, 18, 1, 42, 14, 267, DateTimeKind.Local).AddTicks(6964), 393.55m, new DateTime(2024, 11, 5, 13, 12, 52, 685, DateTimeKind.Local).AddTicks(5215), "Et pariatur repudiandae voluptatem.", "Gorgeous Metal Hat", "8d5cb5e0-f91c-4987-a6b9-b81d1e225f6d", 8, new DateTime(2025, 8, 18, 1, 42, 14, 267, DateTimeKind.Local).AddTicks(6965) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 267, DateTimeKind.Local).AddTicks(7029), new DateTime(2025, 8, 18, 1, 42, 14, 267, DateTimeKind.Local).AddTicks(7030), 72.36m, new DateTime(2025, 8, 15, 8, 56, 7, 162, DateTimeKind.Local).AddTicks(8937), "Sed quisquam dolores amet aut eveniet quo omnis earum et.", "Small Rubber Computer", "b5461037-4df3-4234-a759-95d99976ba7a", 9, new DateTime(2025, 8, 18, 1, 42, 14, 267, DateTimeKind.Local).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 267, DateTimeKind.Local).AddTicks(7216), new DateTime(2025, 8, 18, 1, 42, 14, 267, DateTimeKind.Local).AddTicks(7217), 545.36m, new DateTime(2025, 4, 20, 18, 52, 8, 506, DateTimeKind.Local).AddTicks(5533), "Hic quia quae corrupti voluptas ipsa inventore voluptatem.", "Gorgeous Concrete Pants", "462cb7f8-8695-46af-9ba1-5310e7012020", 5, new DateTime(2025, 8, 18, 1, 42, 14, 267, DateTimeKind.Local).AddTicks(7218) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 8, 11, 11, 31, 24, 270, DateTimeKind.Local).AddTicks(8416), new DateTime(2026, 11, 28, 13, 32, 23, 808, DateTimeKind.Local).AddTicks(4660), new DateTime(2025, 8, 18, 1, 42, 14, 300, DateTimeKind.Local).AddTicks(9415), 4, new DateTime(2025, 8, 18, 1, 42, 14, 300, DateTimeKind.Local).AddTicks(9416), "854a2727-6541-4025-bb95-ceaf7edaa876", 32, 2102.04m, new DateTime(2025, 8, 18, 1, 42, 14, 300, DateTimeKind.Local).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 11, 26, 23, 41, 58, 469, DateTimeKind.Local).AddTicks(5456), new DateTime(2026, 9, 5, 2, 11, 2, 69, DateTimeKind.Local).AddTicks(3081), new DateTime(2025, 8, 18, 1, 42, 14, 300, DateTimeKind.Local).AddTicks(9803), 4, new DateTime(2025, 8, 18, 1, 42, 14, 300, DateTimeKind.Local).AddTicks(9804), "d0045e29-09b8-4547-983f-a9bdd25f819a", 43, 1844.88m, new DateTime(2025, 8, 18, 1, 42, 14, 300, DateTimeKind.Local).AddTicks(9804) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 2, 9, 46, 43, 284, DateTimeKind.Local).AddTicks(7551), new DateTime(2026, 6, 21, 2, 5, 4, 749, DateTimeKind.Local).AddTicks(2807), new DateTime(2025, 8, 18, 1, 42, 14, 300, DateTimeKind.Local).AddTicks(9849), 4, new DateTime(2025, 8, 18, 1, 42, 14, 300, DateTimeKind.Local).AddTicks(9849), "f82dd996-5094-4af7-bf6e-6d7f2b63c1f8", 36, 1820.52m, new DateTime(2025, 8, 18, 1, 42, 14, 300, DateTimeKind.Local).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 9, 7, 8, 15, 557, DateTimeKind.Local).AddTicks(2767), new DateTime(2026, 3, 24, 2, 1, 2, 278, DateTimeKind.Local).AddTicks(6699), new DateTime(2025, 8, 18, 1, 42, 14, 300, DateTimeKind.Local).AddTicks(9898), 6, new DateTime(2025, 8, 18, 1, 42, 14, 300, DateTimeKind.Local).AddTicks(9899), "bf84fd90-a5be-4bc9-b707-fc749f5d7c8c", 12, 1554.67m, new DateTime(2025, 8, 18, 1, 42, 14, 300, DateTimeKind.Local).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 9, 38, 26, 290, DateTimeKind.Local).AddTicks(2314), new DateTime(2027, 3, 15, 23, 2, 38, 602, DateTimeKind.Local).AddTicks(569), new DateTime(2025, 8, 18, 1, 42, 14, 300, DateTimeKind.Local).AddTicks(9928), new DateTime(2025, 8, 18, 1, 42, 14, 300, DateTimeKind.Local).AddTicks(9929), "0fd17a97-c608-4e24-a1c9-6a322dd99397", 37, 1959.00m, new DateTime(2025, 8, 18, 1, 42, 14, 300, DateTimeKind.Local).AddTicks(9929) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 5, 6, 42, 9, 256, DateTimeKind.Local).AddTicks(7119), new DateTime(2025, 10, 27, 19, 44, 28, 543, DateTimeKind.Local).AddTicks(7204), new DateTime(2025, 8, 18, 1, 42, 14, 300, DateTimeKind.Local).AddTicks(9963), new DateTime(2025, 8, 18, 1, 42, 14, 300, DateTimeKind.Local).AddTicks(9963), "39850a76-c302-48f5-afb5-a8f48c3d1806", 25, 1955.29m, new DateTime(2025, 8, 18, 1, 42, 14, 300, DateTimeKind.Local).AddTicks(9964) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 11, 12, 13, 29, 48, 337, DateTimeKind.Local).AddTicks(2896), new DateTime(2026, 8, 12, 23, 28, 37, 729, DateTimeKind.Local).AddTicks(3102), new DateTime(2025, 8, 18, 1, 42, 14, 300, DateTimeKind.Local).AddTicks(9997), new DateTime(2025, 8, 18, 1, 42, 14, 300, DateTimeKind.Local).AddTicks(9998), "66fd9193-2270-4cc3-bda1-39b5889f3045", 9, 1827.43m, new DateTime(2025, 8, 18, 1, 42, 14, 300, DateTimeKind.Local).AddTicks(9998) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 9, 26, 18, 19, 14, 945, DateTimeKind.Local).AddTicks(2910), new DateTime(2026, 4, 28, 11, 51, 9, 816, DateTimeKind.Local).AddTicks(7559), new DateTime(2025, 8, 18, 1, 42, 14, 301, DateTimeKind.Local).AddTicks(70), 1, new DateTime(2025, 8, 18, 1, 42, 14, 301, DateTimeKind.Local).AddTicks(71), "a0c917ab-a2bc-4155-a258-0b77dc51f35b", 22, 2382.63m, new DateTime(2025, 8, 18, 1, 42, 14, 301, DateTimeKind.Local).AddTicks(71) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 12, 16, 19, 29, 17, 332, DateTimeKind.Local).AddTicks(1633), new DateTime(2026, 7, 2, 11, 10, 47, 246, DateTimeKind.Local).AddTicks(6317), new DateTime(2025, 8, 18, 1, 42, 14, 301, DateTimeKind.Local).AddTicks(125), 2, new DateTime(2025, 8, 18, 1, 42, 14, 301, DateTimeKind.Local).AddTicks(125), "a1de2e35-2358-4715-89a3-ae72db93e1cc", 16, 1569.37m, new DateTime(2025, 8, 18, 1, 42, 14, 301, DateTimeKind.Local).AddTicks(126) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 11, 6, 3, 187, DateTimeKind.Local).AddTicks(6160), new DateTime(2026, 8, 25, 4, 36, 13, 639, DateTimeKind.Local).AddTicks(3871), new DateTime(2025, 8, 18, 1, 42, 14, 301, DateTimeKind.Local).AddTicks(181), 9, new DateTime(2025, 8, 18, 1, 42, 14, 301, DateTimeKind.Local).AddTicks(181), "0991ee74-ade0-44e2-b8cf-8d424b7664d5", 27, 2462.98m, new DateTime(2025, 8, 18, 1, 42, 14, 301, DateTimeKind.Local).AddTicks(182) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 153, DateTimeKind.Local).AddTicks(7541), new DateTime(2025, 8, 18, 1, 42, 14, 153, DateTimeKind.Local).AddTicks(7547), "5f9865d4-a5e5-422b-aeef-2427b827dc19", new DateTime(2025, 8, 18, 1, 42, 14, 153, DateTimeKind.Local).AddTicks(7548) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 154, DateTimeKind.Local).AddTicks(7563), new DateTime(2025, 8, 18, 1, 42, 14, 154, DateTimeKind.Local).AddTicks(7566), "c9c4aea1-6deb-4cfe-9762-f10e68a51e50", new DateTime(2025, 8, 18, 1, 42, 14, 154, DateTimeKind.Local).AddTicks(7567) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 155, DateTimeKind.Local).AddTicks(7518), new DateTime(2025, 8, 18, 1, 42, 14, 155, DateTimeKind.Local).AddTicks(7522), "a267b901-9465-4d89-a9f0-6def0c250ec9", new DateTime(2025, 8, 18, 1, 42, 14, 155, DateTimeKind.Local).AddTicks(7523) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 156, DateTimeKind.Local).AddTicks(7271), new DateTime(2025, 8, 18, 1, 42, 14, 156, DateTimeKind.Local).AddTicks(7271), "e5277b0e-640d-43ce-9d3a-b2f9c1860ccc", new DateTime(2025, 8, 18, 1, 42, 14, 156, DateTimeKind.Local).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 157, DateTimeKind.Local).AddTicks(7609), new DateTime(2025, 8, 18, 1, 42, 14, 157, DateTimeKind.Local).AddTicks(7612), "184531b8-0418-4f06-bef4-fb4fa89e72eb", new DateTime(2025, 8, 18, 1, 42, 14, 157, DateTimeKind.Local).AddTicks(7613) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 158, DateTimeKind.Local).AddTicks(7546), new DateTime(2025, 8, 18, 1, 42, 14, 158, DateTimeKind.Local).AddTicks(7547), "30f239fd-7771-4662-8498-c5989a649db9", new DateTime(2025, 8, 18, 1, 42, 14, 158, DateTimeKind.Local).AddTicks(7547) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 159, DateTimeKind.Local).AddTicks(7931), new DateTime(2025, 8, 18, 1, 42, 14, 159, DateTimeKind.Local).AddTicks(7934), "2ba52b99-7fc3-446b-8da7-e2ee32e73499", new DateTime(2025, 8, 18, 1, 42, 14, 159, DateTimeKind.Local).AddTicks(7935) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 160, DateTimeKind.Local).AddTicks(8380), new DateTime(2025, 8, 18, 1, 42, 14, 160, DateTimeKind.Local).AddTicks(8384), "efb7bcef-95e8-46c5-8197-8f8b33941c3a", new DateTime(2025, 8, 18, 1, 42, 14, 160, DateTimeKind.Local).AddTicks(8384) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 161, DateTimeKind.Local).AddTicks(8900), new DateTime(2025, 8, 18, 1, 42, 14, 161, DateTimeKind.Local).AddTicks(8903), "6c56ef1c-e332-4c2b-853f-fc4247ddcca0", new DateTime(2025, 8, 18, 1, 42, 14, 161, DateTimeKind.Local).AddTicks(8904) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 162, DateTimeKind.Local).AddTicks(8827), new DateTime(2025, 8, 18, 1, 42, 14, 162, DateTimeKind.Local).AddTicks(8830), "9158de9f-b6ff-49cb-9b9c-02ec08801e50", new DateTime(2025, 8, 18, 1, 42, 14, 162, DateTimeKind.Local).AddTicks(8831) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 163, DateTimeKind.Local).AddTicks(8666), new DateTime(2025, 8, 18, 1, 42, 14, 163, DateTimeKind.Local).AddTicks(8669), "6f1438dc-7c34-490e-bdec-0f0d7ab993e6", new DateTime(2025, 8, 18, 1, 42, 14, 163, DateTimeKind.Local).AddTicks(8669) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 164, DateTimeKind.Local).AddTicks(8420), new DateTime(2025, 8, 18, 1, 42, 14, 164, DateTimeKind.Local).AddTicks(8422), "b7736e7b-2d38-4428-b4c9-6690819fbd00", new DateTime(2025, 8, 18, 1, 42, 14, 164, DateTimeKind.Local).AddTicks(8423) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 165, DateTimeKind.Local).AddTicks(7925), new DateTime(2025, 8, 18, 1, 42, 14, 165, DateTimeKind.Local).AddTicks(7928), "393ca656-301a-4ab4-9a3b-7b78643d01d2", new DateTime(2025, 8, 18, 1, 42, 14, 165, DateTimeKind.Local).AddTicks(7929) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 166, DateTimeKind.Local).AddTicks(7323), new DateTime(2025, 8, 18, 1, 42, 14, 166, DateTimeKind.Local).AddTicks(7327), "5ad1a30a-05ab-4956-b004-ce7df97a1715", new DateTime(2025, 8, 18, 1, 42, 14, 166, DateTimeKind.Local).AddTicks(7327) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 167, DateTimeKind.Local).AddTicks(6932), new DateTime(2025, 8, 18, 1, 42, 14, 167, DateTimeKind.Local).AddTicks(6935), "725a5be9-f0d1-4ae9-9aad-b9a901f82b9b", new DateTime(2025, 8, 18, 1, 42, 14, 167, DateTimeKind.Local).AddTicks(6936) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 168, DateTimeKind.Local).AddTicks(7433), new DateTime(2025, 8, 18, 1, 42, 14, 168, DateTimeKind.Local).AddTicks(7437), "f5ca22a8-95cc-44bb-8d88-380ceebb1456", new DateTime(2025, 8, 18, 1, 42, 14, 168, DateTimeKind.Local).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 169, DateTimeKind.Local).AddTicks(9318), new DateTime(2025, 8, 18, 1, 42, 14, 169, DateTimeKind.Local).AddTicks(9321), "239f9ecd-5fea-4ea1-8518-ad18118395bd", new DateTime(2025, 8, 18, 1, 42, 14, 169, DateTimeKind.Local).AddTicks(9322) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 171, DateTimeKind.Local).AddTicks(1409), new DateTime(2025, 8, 18, 1, 42, 14, 171, DateTimeKind.Local).AddTicks(1412), "6a892f96-8e92-4997-9e91-6f95a58216d0", new DateTime(2025, 8, 18, 1, 42, 14, 171, DateTimeKind.Local).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 172, DateTimeKind.Local).AddTicks(4003), new DateTime(2025, 8, 18, 1, 42, 14, 172, DateTimeKind.Local).AddTicks(4006), "032a7b76-1144-46d2-9cf1-832d25c7e38a", new DateTime(2025, 8, 18, 1, 42, 14, 172, DateTimeKind.Local).AddTicks(4007) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 173, DateTimeKind.Local).AddTicks(6047), new DateTime(2025, 8, 18, 1, 42, 14, 173, DateTimeKind.Local).AddTicks(6051), "5c87c478-99a5-446c-a2d1-e5b55d07894e", new DateTime(2025, 8, 18, 1, 42, 14, 173, DateTimeKind.Local).AddTicks(6051) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 174, DateTimeKind.Local).AddTicks(8111), new DateTime(2025, 8, 18, 1, 42, 14, 174, DateTimeKind.Local).AddTicks(8114), "89f6f2fe-8726-4248-b9f1-2501494c1a56", new DateTime(2025, 8, 18, 1, 42, 14, 174, DateTimeKind.Local).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 175, DateTimeKind.Local).AddTicks(9769), new DateTime(2025, 8, 18, 1, 42, 14, 175, DateTimeKind.Local).AddTicks(9772), "cc8f583c-9759-4696-b6f0-51777251f5c4", new DateTime(2025, 8, 18, 1, 42, 14, 175, DateTimeKind.Local).AddTicks(9772) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 177, DateTimeKind.Local).AddTicks(2723), new DateTime(2025, 8, 18, 1, 42, 14, 177, DateTimeKind.Local).AddTicks(2727), "c30766cc-c323-4091-ac70-73156e98b465", new DateTime(2025, 8, 18, 1, 42, 14, 177, DateTimeKind.Local).AddTicks(2727) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 178, DateTimeKind.Local).AddTicks(7303), new DateTime(2025, 8, 18, 1, 42, 14, 178, DateTimeKind.Local).AddTicks(7310), "46c99aa7-87c7-4abc-af67-050b6215cc4b", new DateTime(2025, 8, 18, 1, 42, 14, 178, DateTimeKind.Local).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 179, DateTimeKind.Local).AddTicks(9276), new DateTime(2025, 8, 18, 1, 42, 14, 179, DateTimeKind.Local).AddTicks(9280), "67c62552-12a5-4793-909f-443195bcdbeb", new DateTime(2025, 8, 18, 1, 42, 14, 179, DateTimeKind.Local).AddTicks(9280) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 181, DateTimeKind.Local).AddTicks(341), new DateTime(2025, 8, 18, 1, 42, 14, 181, DateTimeKind.Local).AddTicks(345), "80ab9ac4-05ee-421e-8f19-c56a57658eb6", new DateTime(2025, 8, 18, 1, 42, 14, 181, DateTimeKind.Local).AddTicks(345) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 182, DateTimeKind.Local).AddTicks(1231), new DateTime(2025, 8, 18, 1, 42, 14, 182, DateTimeKind.Local).AddTicks(1234), "bf23f214-d3ca-4c09-8c1a-c57a7dfc6ca6", new DateTime(2025, 8, 18, 1, 42, 14, 182, DateTimeKind.Local).AddTicks(1235) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 183, DateTimeKind.Local).AddTicks(2033), new DateTime(2025, 8, 18, 1, 42, 14, 183, DateTimeKind.Local).AddTicks(2036), "05299bb7-4d47-40bf-8e21-e07e6ea5b3b3", new DateTime(2025, 8, 18, 1, 42, 14, 183, DateTimeKind.Local).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 184, DateTimeKind.Local).AddTicks(3535), new DateTime(2025, 8, 18, 1, 42, 14, 184, DateTimeKind.Local).AddTicks(3539), "e408ed18-7413-4584-934d-3fce71aea4e4", new DateTime(2025, 8, 18, 1, 42, 14, 184, DateTimeKind.Local).AddTicks(3539) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 185, DateTimeKind.Local).AddTicks(3614), new DateTime(2025, 8, 18, 1, 42, 14, 185, DateTimeKind.Local).AddTicks(3614), "0964600b-4e80-4f2c-893e-e1a5d5c11096", new DateTime(2025, 8, 18, 1, 42, 14, 185, DateTimeKind.Local).AddTicks(3615) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 186, DateTimeKind.Local).AddTicks(4317), new DateTime(2025, 8, 18, 1, 42, 14, 186, DateTimeKind.Local).AddTicks(4321), "974ce6d5-b8f8-43b0-b51f-91315e4ab62f", new DateTime(2025, 8, 18, 1, 42, 14, 186, DateTimeKind.Local).AddTicks(4321) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 187, DateTimeKind.Local).AddTicks(5101), new DateTime(2025, 8, 18, 1, 42, 14, 187, DateTimeKind.Local).AddTicks(5104), "d02e8805-f97b-43e8-a357-be2649ba6fc1", new DateTime(2025, 8, 18, 1, 42, 14, 187, DateTimeKind.Local).AddTicks(5105) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 188, DateTimeKind.Local).AddTicks(5975), new DateTime(2025, 8, 18, 1, 42, 14, 188, DateTimeKind.Local).AddTicks(5978), "40294cbd-28b1-4564-a41a-35fd0b3efe0d", new DateTime(2025, 8, 18, 1, 42, 14, 188, DateTimeKind.Local).AddTicks(5979) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 189, DateTimeKind.Local).AddTicks(6338), new DateTime(2025, 8, 18, 1, 42, 14, 189, DateTimeKind.Local).AddTicks(6339), "d66130bc-b833-4cc0-937a-1986dfb2cf6c", new DateTime(2025, 8, 18, 1, 42, 14, 189, DateTimeKind.Local).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 190, DateTimeKind.Local).AddTicks(7304), new DateTime(2025, 8, 18, 1, 42, 14, 190, DateTimeKind.Local).AddTicks(7307), "d4418f4a-c115-41d5-b5db-cad93b234dff", new DateTime(2025, 8, 18, 1, 42, 14, 190, DateTimeKind.Local).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 191, DateTimeKind.Local).AddTicks(7693), new DateTime(2025, 8, 18, 1, 42, 14, 191, DateTimeKind.Local).AddTicks(7696), "5824093c-43d5-4b8a-896e-0ab6f5a56d86", new DateTime(2025, 8, 18, 1, 42, 14, 191, DateTimeKind.Local).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 192, DateTimeKind.Local).AddTicks(8328), new DateTime(2025, 8, 18, 1, 42, 14, 192, DateTimeKind.Local).AddTicks(8332), "fa39324a-be68-4106-a71d-5b704f0e2f16", new DateTime(2025, 8, 18, 1, 42, 14, 192, DateTimeKind.Local).AddTicks(8332) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 194, DateTimeKind.Local).AddTicks(4646), new DateTime(2025, 8, 18, 1, 42, 14, 194, DateTimeKind.Local).AddTicks(4651), "f1dc2537-6267-42cd-9e52-9f732d0f5464", new DateTime(2025, 8, 18, 1, 42, 14, 194, DateTimeKind.Local).AddTicks(4651) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 195, DateTimeKind.Local).AddTicks(6579), new DateTime(2025, 8, 18, 1, 42, 14, 195, DateTimeKind.Local).AddTicks(6583), "416c422a-3f0a-4ab8-bb68-e04735936c69", new DateTime(2025, 8, 18, 1, 42, 14, 195, DateTimeKind.Local).AddTicks(6583) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 196, DateTimeKind.Local).AddTicks(5571), new DateTime(2025, 8, 18, 1, 42, 14, 196, DateTimeKind.Local).AddTicks(5572), "1a4d2cb5-ad14-4fc9-b47f-39428a6630aa", new DateTime(2025, 8, 18, 1, 42, 14, 196, DateTimeKind.Local).AddTicks(5572) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 197, DateTimeKind.Local).AddTicks(7837), new DateTime(2025, 8, 18, 1, 42, 14, 197, DateTimeKind.Local).AddTicks(7842), "60d01eb5-16ed-4c0a-82bc-4ac3d4712c09", new DateTime(2025, 8, 18, 1, 42, 14, 197, DateTimeKind.Local).AddTicks(7843) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 199, DateTimeKind.Local).AddTicks(3222), new DateTime(2025, 8, 18, 1, 42, 14, 199, DateTimeKind.Local).AddTicks(3226), "4e9c6fc9-65a0-4d58-9311-64fc3b59117a", new DateTime(2025, 8, 18, 1, 42, 14, 199, DateTimeKind.Local).AddTicks(3227) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 200, DateTimeKind.Local).AddTicks(8160), new DateTime(2025, 8, 18, 1, 42, 14, 200, DateTimeKind.Local).AddTicks(8164), "82b6121a-ef4a-40d9-a493-eec884901dd3", new DateTime(2025, 8, 18, 1, 42, 14, 200, DateTimeKind.Local).AddTicks(8165) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 202, DateTimeKind.Local).AddTicks(2559), new DateTime(2025, 8, 18, 1, 42, 14, 202, DateTimeKind.Local).AddTicks(2561), "d765bf99-45c4-4cad-a0bb-2cfa4c24d0c1", new DateTime(2025, 8, 18, 1, 42, 14, 202, DateTimeKind.Local).AddTicks(2562) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 203, DateTimeKind.Local).AddTicks(8534), new DateTime(2025, 8, 18, 1, 42, 14, 203, DateTimeKind.Local).AddTicks(8541), "3307f2b3-8e79-4963-b411-55b8e965308f", new DateTime(2025, 8, 18, 1, 42, 14, 203, DateTimeKind.Local).AddTicks(8542) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 205, DateTimeKind.Local).AddTicks(6744), new DateTime(2025, 8, 18, 1, 42, 14, 205, DateTimeKind.Local).AddTicks(6751), "481bc32f-75c7-4fa8-907e-98542302bba7", new DateTime(2025, 8, 18, 1, 42, 14, 205, DateTimeKind.Local).AddTicks(6752) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 207, DateTimeKind.Local).AddTicks(6787), new DateTime(2025, 8, 18, 1, 42, 14, 207, DateTimeKind.Local).AddTicks(6796), "c93f853f-5901-4ea9-9cc0-6a52f502d5b7", new DateTime(2025, 8, 18, 1, 42, 14, 207, DateTimeKind.Local).AddTicks(6797) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 209, DateTimeKind.Local).AddTicks(9753), new DateTime(2025, 8, 18, 1, 42, 14, 209, DateTimeKind.Local).AddTicks(9759), "42c1a178-de89-4786-bcc2-00c15f283ca3", new DateTime(2025, 8, 18, 1, 42, 14, 209, DateTimeKind.Local).AddTicks(9761) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 212, DateTimeKind.Local).AddTicks(2420), new DateTime(2025, 8, 18, 1, 42, 14, 212, DateTimeKind.Local).AddTicks(2428), "a60e7202-4c4a-40dc-95a9-62343e79f082", new DateTime(2025, 8, 18, 1, 42, 14, 212, DateTimeKind.Local).AddTicks(2429) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 214, DateTimeKind.Local).AddTicks(6298), new DateTime(2025, 8, 18, 1, 42, 14, 214, DateTimeKind.Local).AddTicks(6305), "f01f993a-4a60-4d62-8824-d593a89ff9d5", new DateTime(2025, 8, 18, 1, 42, 14, 214, DateTimeKind.Local).AddTicks(6307) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 216, DateTimeKind.Local).AddTicks(9137), new DateTime(2025, 8, 18, 1, 42, 14, 216, DateTimeKind.Local).AddTicks(9145), "99322e32-d1b7-40cb-9395-ad0426cb911d", new DateTime(2025, 8, 18, 1, 42, 14, 216, DateTimeKind.Local).AddTicks(9146) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 219, DateTimeKind.Local).AddTicks(27), new DateTime(2025, 8, 18, 1, 42, 14, 219, DateTimeKind.Local).AddTicks(33), "f1260ae4-cd96-436e-998b-afa9f0b72a45", new DateTime(2025, 8, 18, 1, 42, 14, 219, DateTimeKind.Local).AddTicks(34) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 220, DateTimeKind.Local).AddTicks(8940), new DateTime(2025, 8, 18, 1, 42, 14, 220, DateTimeKind.Local).AddTicks(8945), "589baf2a-d6d7-458f-b5c7-078aa7478cf3", new DateTime(2025, 8, 18, 1, 42, 14, 220, DateTimeKind.Local).AddTicks(8947) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 222, DateTimeKind.Local).AddTicks(6296), new DateTime(2025, 8, 18, 1, 42, 14, 222, DateTimeKind.Local).AddTicks(6302), "fab8daee-50dd-4019-9b85-2a0f88bb2f88", new DateTime(2025, 8, 18, 1, 42, 14, 222, DateTimeKind.Local).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 224, DateTimeKind.Local).AddTicks(555), new DateTime(2025, 8, 18, 1, 42, 14, 224, DateTimeKind.Local).AddTicks(557), "5b5fc763-c70b-48ad-9837-8f152a628e6c", new DateTime(2025, 8, 18, 1, 42, 14, 224, DateTimeKind.Local).AddTicks(557) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 225, DateTimeKind.Local).AddTicks(4462), new DateTime(2025, 8, 18, 1, 42, 14, 225, DateTimeKind.Local).AddTicks(4466), "22666330-2f86-461b-bba5-d7d5556e7b6b", new DateTime(2025, 8, 18, 1, 42, 14, 225, DateTimeKind.Local).AddTicks(4467) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 226, DateTimeKind.Local).AddTicks(7364), new DateTime(2025, 8, 18, 1, 42, 14, 226, DateTimeKind.Local).AddTicks(7369), "73a5d22b-e3c9-4e02-b4ad-14a72fcd98d6", new DateTime(2025, 8, 18, 1, 42, 14, 226, DateTimeKind.Local).AddTicks(7370) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 228, DateTimeKind.Local).AddTicks(1680), new DateTime(2025, 8, 18, 1, 42, 14, 228, DateTimeKind.Local).AddTicks(1685), "2f1bb114-5fce-4b41-8aca-3302337f90e4", new DateTime(2025, 8, 18, 1, 42, 14, 228, DateTimeKind.Local).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 229, DateTimeKind.Local).AddTicks(8418), new DateTime(2025, 8, 18, 1, 42, 14, 229, DateTimeKind.Local).AddTicks(8423), "94db3109-3906-4f62-b0d9-543dcee72510", new DateTime(2025, 8, 18, 1, 42, 14, 229, DateTimeKind.Local).AddTicks(8424) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 231, DateTimeKind.Local).AddTicks(7903), new DateTime(2025, 8, 18, 1, 42, 14, 231, DateTimeKind.Local).AddTicks(7910), "58a1c58e-323f-4740-9a19-dc0aa39bb745", new DateTime(2025, 8, 18, 1, 42, 14, 231, DateTimeKind.Local).AddTicks(7911) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 233, DateTimeKind.Local).AddTicks(9461), new DateTime(2025, 8, 18, 1, 42, 14, 233, DateTimeKind.Local).AddTicks(9468), "ba9f85f3-e09f-40ca-ada0-cff22deee775", new DateTime(2025, 8, 18, 1, 42, 14, 233, DateTimeKind.Local).AddTicks(9470) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 236, DateTimeKind.Local).AddTicks(2215), new DateTime(2025, 8, 18, 1, 42, 14, 236, DateTimeKind.Local).AddTicks(2223), "3fd281c9-447c-4d9b-b307-0757915e4c87", new DateTime(2025, 8, 18, 1, 42, 14, 236, DateTimeKind.Local).AddTicks(2224) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 238, DateTimeKind.Local).AddTicks(2153), new DateTime(2025, 8, 18, 1, 42, 14, 238, DateTimeKind.Local).AddTicks(2161), "93659fc9-0af6-400e-9d47-170a6c1d6b1e", new DateTime(2025, 8, 18, 1, 42, 14, 238, DateTimeKind.Local).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 240, DateTimeKind.Local).AddTicks(96), new DateTime(2025, 8, 18, 1, 42, 14, 240, DateTimeKind.Local).AddTicks(102), "3927f6be-7b11-4216-a93f-90c957c5c0b8", new DateTime(2025, 8, 18, 1, 42, 14, 240, DateTimeKind.Local).AddTicks(103) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 241, DateTimeKind.Local).AddTicks(7667), new DateTime(2025, 8, 18, 1, 42, 14, 241, DateTimeKind.Local).AddTicks(7674), "0b68ebcb-b846-43c0-a35a-236f16e6022f", new DateTime(2025, 8, 18, 1, 42, 14, 241, DateTimeKind.Local).AddTicks(7675) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 243, DateTimeKind.Local).AddTicks(2704), new DateTime(2025, 8, 18, 1, 42, 14, 243, DateTimeKind.Local).AddTicks(2710), "181a1526-67ed-4711-909b-3c2cd7220871", new DateTime(2025, 8, 18, 1, 42, 14, 243, DateTimeKind.Local).AddTicks(2711) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 244, DateTimeKind.Local).AddTicks(7013), new DateTime(2025, 8, 18, 1, 42, 14, 244, DateTimeKind.Local).AddTicks(7018), "1c5b55c3-ed95-44e0-99d7-5c8d4ea74f02", new DateTime(2025, 8, 18, 1, 42, 14, 244, DateTimeKind.Local).AddTicks(7019) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 245, DateTimeKind.Local).AddTicks(9876), new DateTime(2025, 8, 18, 1, 42, 14, 245, DateTimeKind.Local).AddTicks(9880), "4d85a7d7-489e-4744-9253-bb41a31ecb7a", new DateTime(2025, 8, 18, 1, 42, 14, 245, DateTimeKind.Local).AddTicks(9881) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 247, DateTimeKind.Local).AddTicks(1795), new DateTime(2025, 8, 18, 1, 42, 14, 247, DateTimeKind.Local).AddTicks(1799), "9d474790-c733-468c-acd8-f15957d2c812", new DateTime(2025, 8, 18, 1, 42, 14, 247, DateTimeKind.Local).AddTicks(1799) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 248, DateTimeKind.Local).AddTicks(2920), new DateTime(2025, 8, 18, 1, 42, 14, 248, DateTimeKind.Local).AddTicks(2923), "bfb2d3e5-44f1-4e37-8ff3-db513300d910", new DateTime(2025, 8, 18, 1, 42, 14, 248, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 249, DateTimeKind.Local).AddTicks(5400), new DateTime(2025, 8, 18, 1, 42, 14, 249, DateTimeKind.Local).AddTicks(5406), "9f169fb8-85ba-4567-b6c3-2c0624d7adfb", new DateTime(2025, 8, 18, 1, 42, 14, 249, DateTimeKind.Local).AddTicks(5406) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 250, DateTimeKind.Local).AddTicks(6280), new DateTime(2025, 8, 18, 1, 42, 14, 250, DateTimeKind.Local).AddTicks(6281), "11444439-d732-4da2-ab53-681ba7c753b8", new DateTime(2025, 8, 18, 1, 42, 14, 250, DateTimeKind.Local).AddTicks(6282) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 251, DateTimeKind.Local).AddTicks(6079), new DateTime(2025, 8, 18, 1, 42, 14, 251, DateTimeKind.Local).AddTicks(6083), "ac8757d7-ecee-4881-ad82-10169a61a663", new DateTime(2025, 8, 18, 1, 42, 14, 251, DateTimeKind.Local).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 252, DateTimeKind.Local).AddTicks(6423), new DateTime(2025, 8, 18, 1, 42, 14, 252, DateTimeKind.Local).AddTicks(6424), "b32af151-0a2e-41ac-860d-3f2a2abfcc56", new DateTime(2025, 8, 18, 1, 42, 14, 252, DateTimeKind.Local).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 253, DateTimeKind.Local).AddTicks(8311), new DateTime(2025, 8, 18, 1, 42, 14, 253, DateTimeKind.Local).AddTicks(8316), "ac33f57c-30c9-4fd5-9c05-5cdceebc04b4", new DateTime(2025, 8, 18, 1, 42, 14, 253, DateTimeKind.Local).AddTicks(8317) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 255, DateTimeKind.Local).AddTicks(1506), new DateTime(2025, 8, 18, 1, 42, 14, 255, DateTimeKind.Local).AddTicks(1512), "7029bf0d-d7db-46db-b24f-876f7166d617", new DateTime(2025, 8, 18, 1, 42, 14, 255, DateTimeKind.Local).AddTicks(1513) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 264, DateTimeKind.Local).AddTicks(1085), new DateTime(2025, 8, 18, 1, 42, 14, 264, DateTimeKind.Local).AddTicks(1106), "a186fde8-bf8b-4129-8652-4f0697689c2e", new DateTime(2025, 8, 18, 1, 42, 14, 264, DateTimeKind.Local).AddTicks(1107) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2711), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2712), "012b5103-38dc-4ae3-80c8-5f59b815d682", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2713) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2787), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2788), "19b9a1d5-ef82-4806-bb11-d801b4efe1fe", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2788) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2805), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2806), "0f60ae31-3ad1-45ea-811e-ace001afcd1f", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2806) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2815), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2815), "870fa1ab-2538-45fb-8043-98f70566e669", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2816) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2836), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2837), "9e69f750-547a-4a15-808f-b782be1c7311", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2838) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2848), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2849), "f0279323-c40b-4fb7-8609-5fe36f39a16f", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2849) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2858), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2859), "aaea7dab-71c3-4cec-880c-3a923a870667", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2859) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2867), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2868), "b29ca956-c956-4c12-ab62-7d261c74de3f", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2868) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2886), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2886), "ba2bad16-9009-4e95-a36f-ab06ecd4adf2", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2887) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2956), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2957), "14830509-40ca-4758-8c31-9910ad703ac6", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2957) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2969), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2969), "7feeddbb-1678-49b2-aa26-40592c73fb52", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2978), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2979), "25efe6cd-a4d5-4c5e-9064-71db5ad10755", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2979) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2992), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2993), "bce1865d-266a-41e6-a231-fce17da60d3e", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3002), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3002), "2049a03d-b435-430e-be92-528a9e2fb165", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3003) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3011), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3011), "e4798f45-79ee-4a5a-ac65-d790f73aefe6", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3012) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3026), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3026), "109cab3e-136e-44c2-a380-1f331e25f496", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3027) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3042), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3042), "62750a0f-29a7-444b-a672-3addb43f3a16", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3043) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3052), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3053), "6cf5a463-dbbe-4a38-8b96-b830565c2d80", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3053) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3064), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3064), "36708287-980c-4307-acd6-824f949f80c1", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3065) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3078), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3079), "58b7589a-45d9-45bc-891e-627953a3839c", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3079) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3137), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3138), "f14717c8-c9ac-483f-8493-40f1ca314dbd", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3138) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3147), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3147), "e7a612e2-2daf-4903-8126-5706020ddef1", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3156), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3157), "ee8754b0-008b-4910-bcbd-8d517af00f9e", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3157) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3165), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3166), "7222f501-1bd5-46e7-bedb-7f6052bdae3f", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3179), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3180), "656f9bae-3bf3-435b-bb7e-6857fdf9a4e6", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3188), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3189), "8fa39d66-786b-4094-b275-3acaed17413f", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3199), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3200), "81607be9-074f-4939-9a13-59ce875b9fd7", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3208), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3209), "209e568e-8cea-46f1-b909-b98e970b5f3e", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3209) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3230), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3230), "12088ac2-2cd9-4d40-b1d2-8f10e8900424", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3231) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3245), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3246), "91500fbe-ff21-4a50-9d05-0b8a9534e132", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3256), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3256), "3066bb5f-54fe-45e2-80b1-da6507ca501e", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3257) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3265), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3265), "6249200e-3281-41d0-abd0-95de1123d0a3", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3266) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3274), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3275), "f2b69b33-3466-4098-adcb-09aa017eb5f8", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3285), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3285), "25d36f1b-522e-4396-a797-c87ff13335de", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3286) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3302), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3302), "e821119b-91a5-49aa-a5fb-1a9aa0e96263", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3303) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3311), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3312), "bd675e44-6be5-4e79-bd8a-d7bf37de8632", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3312) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3321), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3321), "7874b4c9-d77f-4a22-bf40-8ebe9679da24", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3330), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3330), "9faaa98a-c481-4297-aa2e-59074f61ada6", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3331) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3340), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3340), "ba2b7b13-a711-46f6-9fb5-d682c3794f8b", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3341) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3349), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3349), "6596c5ee-60a7-4e4c-842c-46109accb659", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3359), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3359), "d1b26de1-7e75-4e72-a040-5931ad53aa16", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3367), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3368), "41fb006b-dfb1-4bc2-87b7-62fc13d8d8ec", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3368) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3379), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3380), "a4b09f75-c9c4-4886-b8fc-ac59ac5c9aff", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3388), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3389), "8ea6b5d7-7e47-4d28-be86-4dfab357441b", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3389) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3397), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3397), "f0388800-96aa-44d2-9993-782c752a42ec", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3406), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3406), "ffd915fe-a8be-4b7a-9fd0-e334998c4681", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3407) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3416), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3416), "d6071957-079c-4315-9f5e-b3f835770c3e", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3417) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3467), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3467), "9f4027ec-49e6-43b1-8a9d-5cedd44ac39e", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3478), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3479), "08fa540e-a8ff-4a4c-b5ec-6593d6f82a50", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3479) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3488), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3489), "58ca47ef-df14-453c-84ae-7add184938cd", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3489) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3501), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3502), "984d7dac-9cea-4723-afae-ee3dc35220d7", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3502) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3510), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3511), "f6060810-e3ec-4491-b569-cb3170213aa8", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3511) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3521), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3521), "ea4c32cb-db77-4ea6-b932-fcd0f142028c", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3522) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3530), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3530), "17b0cc2f-c594-4590-a67f-cdd327f2eb6f", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3531) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3538), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3538), "d5fe5a8c-88db-4078-8a19-54a0a4a3db23", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3539) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3547), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3547), "812e92ac-5040-42fc-990d-61401e06116f", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3548) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3557), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3557), "8d573153-b77b-4787-8f39-0deb32b26aa5", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3558) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3566), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3566), "8739244c-26ab-41f8-b836-2dbbde2ea912", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3567) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3578), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3579), "944ab4e5-8fe6-43ca-9580-f3529224781b", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3579) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3587), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3588), "cf220a79-eca1-45c5-b12f-4776957f3052", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3588) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3597), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3597), "dfac93eb-90a9-42bd-82f0-4827271489ee", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3598) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3605), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3606), "4f6f857b-e5ae-4ab1-b8bc-c57e5a322f53", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3606) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3615), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3615), "46ed4c15-e086-49f6-a3dd-d9ac591c7561", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3623), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3624), "f5759d02-b390-4224-b6a3-53b05197e367", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3625) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3633), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3634), "5ea747f5-c8df-41c5-b008-0578d81b5964", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3643), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3644), "dc6f200e-6aab-4c21-9447-01d43df6fc41", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3644) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3655), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3655), "506c0e1e-29f7-4e93-8455-c7f7745fd196", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3656) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3664), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3664), "f304c393-4bbb-4585-b07d-e1fddcd3b341", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3665) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3674), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3674), "9a79b238-1f5d-4208-9648-80c544c16a0a", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3675) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3683), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3683), "1059b99f-958f-496d-9b52-c6f77c1dbe9b", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3684) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3754), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3755), "9f119f5e-6367-42c1-96ce-d20f92842a66", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3756) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3810), 11, new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3811), "73f1cee4-1c95-4dfc-9770-6e030996bab5", 2, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3812) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "ShiftDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3825), 12, new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3825), "d55c2c04-a18f-4d2d-82e4-47fd958962c2", new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3827) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3837), 11, new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3838), "0a05edbb-50f5-487e-9823-e78734440b12", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3838) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3913), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3914), "e975cea6-ce43-4c79-a542-8c94f3adb078", 1, new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3914) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3923), 12, new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3924), "f04dbb89-dd15-49b7-9f5d-b93ca50b2081", new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3924) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3934), 11, new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3935), "b156ba68-542f-470e-a02c-c2c3910eeabf", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3935) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "ShiftDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3949), 12, new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3950), "7fa1fc29-d128-4571-b2ce-f2f3537caf68", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3950) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3960), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3960), "9adc750f-5d27-4ae2-802b-ff2061e23392", 1, new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3961) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3973), 11, new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3974), "508f4242-c064-42d2-bf53-9af1506a57fb", 2, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3974) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3986), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3986), "b2654a6a-3a12-4e6a-9085-f9bbdc4df44b", 1, new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3987) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3995), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3996), "3069ccdf-768f-4d0a-b5d5-fc4baab612a9", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3996) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(4008), 12, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(4009), "7b87908f-2cdd-4f5e-bba6-da3a05fbe296", 1, new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(4009) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "ShiftDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(4024), 11, new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(4025), "b58f6595-757e-4423-8c89-026e59fde6a0", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(4025) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(4037), 12, new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(4038), "cc6e01a5-2600-4d37-9462-14a4e8a5a773", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(4051), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(4051), "b46f66c5-4f79-4d1a-a83b-aca588b3d5cb", new DateTime(2025, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(4052) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(4064), 11, new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(4065), "19066dac-2bab-4339-9b30-38420b43de0a", new DateTime(2025, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(4065) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(4073), 12, new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(4073), "6777a732-3932-4a29-b0da-37aff9bb23b0", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(4074) });
        }
    }
}

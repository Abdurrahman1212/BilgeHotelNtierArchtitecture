using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Init8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Jerelhaven", "Bahamas", new DateTime(2025, 8, 18, 1, 44, 41, 793, DateTimeKind.Local).AddTicks(1932), "32252 Miguel Stravenue, Port Jaquelinton, Philippines", "7", "MD548MZ100J2399782M18875", "1-964-908-8153 x3116", "Peyton.Feil@yahoo.com", new DateTime(2025, 8, 18, 1, 44, 41, 793, DateTimeKind.Local).AddTicks(1942), "Angelo", "Blick", "18c9c409-fb51-4614-b61a-d3a4fa4e59e2", "47489", new DateTime(2025, 8, 18, 1, 44, 41, 793, DateTimeKind.Local).AddTicks(1942) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Willmstown", "China", new DateTime(2025, 8, 18, 1, 44, 41, 793, DateTimeKind.Local).AddTicks(2765), "730 Ortiz Light, Port Ivaburgh, Macedonia", "2", "AE894520079487440532760", "1-606-649-9817", "Gavin99@gmail.com", new DateTime(2025, 8, 18, 1, 44, 41, 793, DateTimeKind.Local).AddTicks(2765), "Michelle", "Corwin", "45a27d88-4dd6-4725-a478-a5dad28f2670", "49753-5816", new DateTime(2025, 8, 18, 1, 44, 41, 793, DateTimeKind.Local).AddTicks(2765) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "East Yolandaside", "Uruguay", new DateTime(2025, 8, 18, 1, 44, 41, 793, DateTimeKind.Local).AddTicks(3045), "35027 Dickinson Land, North Lavinia, Venezuela", "3", "MR7197360014094640010019290", "1-772-912-6637 x16794", "Asa_Schimmel@yahoo.com", new DateTime(2025, 8, 18, 1, 44, 41, 793, DateTimeKind.Local).AddTicks(3046), "Hershel", "VonRueden", "b22375dc-3b17-44a5-9c2b-7662e38dd1fa", "41664-1731", new DateTime(2025, 8, 18, 1, 44, 41, 793, DateTimeKind.Local).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Collinsborough", "Sierra Leone", new DateTime(2025, 8, 18, 1, 44, 41, 793, DateTimeKind.Local).AddTicks(3287), "802 Joesph Burg, Clotildeberg, Rwanda", "3", "CZ3760380060805063270031", "858.750.9551 x4524", "Ashly.Schaefer40@hotmail.com", new DateTime(2025, 8, 18, 1, 44, 41, 793, DateTimeKind.Local).AddTicks(3288), "Angelina", "Langosh", "af5a9222-e6f0-4048-9ba8-dc2f2b5b5190", "63409", new DateTime(2025, 8, 18, 1, 44, 41, 793, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "East Jessyca", "Grenada", new DateTime(2025, 8, 18, 1, 44, 41, 793, DateTimeKind.Local).AddTicks(3546), "096 Hoeger Junction, Port Antonetteville, Indonesia", "4", "LB62447902252651F65T50J31598", "439-922-4353 x247", "Betty.Wyman46@gmail.com", new DateTime(2025, 8, 18, 1, 44, 41, 793, DateTimeKind.Local).AddTicks(3546), "Gudrun", "Williamson", "953812e2-fc03-44b6-b8ec-29b1d0d39d08", "70723", new DateTime(2025, 8, 18, 1, 44, 41, 793, DateTimeKind.Local).AddTicks(3546) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Zboncakborough", "Fiji", new DateTime(2025, 8, 18, 1, 44, 41, 793, DateTimeKind.Local).AddTicks(3786), "28142 Moen Stream, West Hiram, United Kingdom", "1", "AD4128870379Y5H69077394H", "259-570-8336 x987", "Maci_Jerde57@gmail.com", new DateTime(2025, 8, 18, 1, 44, 41, 793, DateTimeKind.Local).AddTicks(3786), "Darien", "Conroy", "1807b45a-7648-4be5-a836-21d48dfbf00d", "87013-5214", new DateTime(2025, 8, 18, 1, 44, 41, 793, DateTimeKind.Local).AddTicks(3787) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "West Wyatt", "Greece", new DateTime(2025, 8, 18, 1, 44, 41, 793, DateTimeKind.Local).AddTicks(4007), "494 Lambert Vista, Ernserville, Guyana", "1", "GI26WEWQ3F177E9O843NJ2C", "1-849-499-3689 x3495", "Johnny81@hotmail.com", new DateTime(2025, 8, 18, 1, 44, 41, 793, DateTimeKind.Local).AddTicks(4007), "Ora", "Brakus", "95b2f484-7701-4212-929e-d0829bc41b89", "93919-8649", new DateTime(2025, 8, 18, 1, 44, 41, 793, DateTimeKind.Local).AddTicks(4008) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Emanueltown", "El Salvador", new DateTime(2025, 8, 18, 1, 44, 41, 793, DateTimeKind.Local).AddTicks(4238), "19828 Friesen Dale, South Isaiahborough, Peru", "GB65OMPL40812000713759", "239.380.4845", "Colt_Satterfield@yahoo.com", new DateTime(2025, 8, 18, 1, 44, 41, 793, DateTimeKind.Local).AddTicks(4239), "Fausto", "Dach", "723e6184-3e31-4032-8d7e-f3b55b354016", "85397-4495", new DateTime(2025, 8, 18, 1, 44, 41, 793, DateTimeKind.Local).AddTicks(4239) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Maximeshire", "United States of America", new DateTime(2025, 8, 18, 1, 44, 41, 793, DateTimeKind.Local).AddTicks(4503), "5809 Victoria Plaza, South Irma, Brazil", "PL47550580620300617560295003", "867-350-9823", "Dixie_Runte@gmail.com", new DateTime(2025, 8, 18, 1, 44, 41, 793, DateTimeKind.Local).AddTicks(4503), "Elian", "Koepp", "b7458404-6191-4bd9-a516-4c3cf0fe9fcc", "79560", new DateTime(2025, 8, 18, 1, 44, 41, 793, DateTimeKind.Local).AddTicks(4503) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Ondrickamouth", "Barbados", new DateTime(2025, 8, 18, 1, 44, 41, 793, DateTimeKind.Local).AddTicks(4727), "522 Cordia Gardens, South Kenna, Holy See (Vatican City State)", "2", "SM04Q004778902475L120564883", "(296) 735-4019 x09109", "Emmitt.Strosin@hotmail.com", new DateTime(2025, 8, 18, 1, 44, 41, 793, DateTimeKind.Local).AddTicks(4727), "Pat", "Green", "cd9c7413-eba6-46fb-8c93-f1974d599308", "65549", new DateTime(2025, 8, 18, 1, 44, 41, 793, DateTimeKind.Local).AddTicks(4727) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Konya", "Johnston Atoll, Amerika", new DateTime(2025, 8, 18, 1, 44, 41, 865, DateTimeKind.Local).AddTicks(1066), "Gokcegol.Nalbantoglu70@yahoo.com", "Kaldırım Sokak 77, Eskişehir, Kanada", "Bögü", "Keseroğlu", "+90-111-723-9-436", new DateTime(2025, 8, 18, 1, 44, 41, 865, DateTimeKind.Local).AddTicks(1070), "67238cb9-95c0-485e-a936-37f70e076a11", "1", new DateTime(2025, 8, 18, 1, 44, 41, 865, DateTimeKind.Local).AddTicks(1070) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Muş", "Cape Verde", new DateTime(2025, 8, 18, 1, 44, 41, 865, DateTimeKind.Local).AddTicks(1806), "Balcar28@gmail.com", "Kocatepe Caddesi 175, Düzce, İsviçre", "Ekeç", "Dalkıran", "+90-312-570-66-24", new DateTime(2025, 8, 18, 1, 44, 41, 865, DateTimeKind.Local).AddTicks(1806), "2950ebc4-30d9-4659-9adf-f630d65404ff", "0", new DateTime(2025, 8, 18, 1, 44, 41, 865, DateTimeKind.Local).AddTicks(1806) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Yozgat", "Suudi Arabistan", new DateTime(2025, 8, 18, 1, 44, 41, 865, DateTimeKind.Local).AddTicks(1964), "Bitaybiki63@gmail.com", "Kocatepe Caddesi 06a, Elazığ, Ürdün", "Barçadoğdu", "Solmaz", "+90-651-325-08-70", new DateTime(2025, 8, 18, 1, 44, 41, 865, DateTimeKind.Local).AddTicks(1965), "78c22798-80d0-4fe6-ab39-ffd53d2616ab", new DateTime(2025, 8, 18, 1, 44, 41, 865, DateTimeKind.Local).AddTicks(1965) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Hakkari", "Kazakistan", new DateTime(2025, 8, 18, 1, 44, 41, 865, DateTimeKind.Local).AddTicks(2119), "Bayutmus.Egeli@gmail.com", "Bahçe Sokak 79, Nevşehir, Kamerun", "Bıtaybıkı", "Kuday", "+90-423-674-76-88", new DateTime(2025, 8, 18, 1, 44, 41, 865, DateTimeKind.Local).AddTicks(2121), "1442a6eb-9ec0-4d79-ade4-03c39788e696", "1", new DateTime(2025, 8, 18, 1, 44, 41, 865, DateTimeKind.Local).AddTicks(2121) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Osmaniye", "Afganistan", new DateTime(2025, 8, 18, 1, 44, 41, 865, DateTimeKind.Local).AddTicks(2251), "Alkaevli.Orge93@gmail.com", "Barış Sokak 68b, Bartın, Benin", "Aldemir", "Sezek", "+90-825-179-60-95", new DateTime(2025, 8, 18, 1, 44, 41, 865, DateTimeKind.Local).AddTicks(2252), "b5bae39a-540b-4802-8c72-c4bab0e981d2", "0", new DateTime(2025, 8, 18, 1, 44, 41, 865, DateTimeKind.Local).AddTicks(2252) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "İzmir", "Avustralya", new DateTime(2025, 8, 18, 1, 44, 41, 865, DateTimeKind.Local).AddTicks(2339), "Beceapa32@gmail.com", "Köypınar Sokak 83b, Çanakkale, Umman", "Gözde", "Solmaz", "+90-183-254-6-511", new DateTime(2025, 8, 18, 1, 44, 41, 865, DateTimeKind.Local).AddTicks(2340), "47494d12-11e5-45c1-9489-ae3816f3a603", "0", new DateTime(2025, 8, 18, 1, 44, 41, 865, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Kütahya", "Güney Kore", new DateTime(2025, 8, 18, 1, 44, 41, 865, DateTimeKind.Local).AddTicks(2454), "Alpyoruk_Elmastasoglu@hotmail.com", "Atatürk Bulvarı 523, Zonguldak, Turks ve Caicos Adaları, İngiltere", "Görün", "Tanrıkulu", "+90-909-265-29-95", new DateTime(2025, 8, 18, 1, 44, 41, 865, DateTimeKind.Local).AddTicks(2454), "ef8c94c7-ceab-43fa-b1bb-30e7db61e94a", new DateTime(2025, 8, 18, 1, 44, 41, 865, DateTimeKind.Local).AddTicks(2454) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Bartın", "Zimbabve", new DateTime(2025, 8, 18, 1, 44, 41, 866, DateTimeKind.Local).AddTicks(2513), "Badruk.Aydan40@hotmail.com", "Namık Kemal Caddesi 23c, Balıkesir, Filipinler", "Esen", "Arslanoğlu", "+90-602-185-2-915", new DateTime(2025, 8, 18, 1, 44, 41, 866, DateTimeKind.Local).AddTicks(2516), "33bbec77-8bc8-4b27-9c80-ba2e230b51ce", "1", new DateTime(2025, 8, 18, 1, 44, 41, 866, DateTimeKind.Local).AddTicks(2517) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Yalova", "Tunus", new DateTime(2025, 8, 18, 1, 44, 41, 866, DateTimeKind.Local).AddTicks(3077), "Colu60@yahoo.com", "Ergenekon Sokak   28a, Ordu, İsviçre", "Baybiçen", "Koyuncu", "+90-574-680-78-21", new DateTime(2025, 8, 18, 1, 44, 41, 866, DateTimeKind.Local).AddTicks(3077), "c468e21f-e0bd-483f-a3e6-a8a2242f5687", "0", new DateTime(2025, 8, 18, 1, 44, 41, 866, DateTimeKind.Local).AddTicks(3078) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Van", "Vanuatu", new DateTime(2025, 8, 18, 1, 44, 41, 866, DateTimeKind.Local).AddTicks(3240), "Burulgu83@gmail.com", "Kaldırım Sokak 35a, Karabük, Uganda", "Baydur", "Özkök ", "+90-304-965-5-977", new DateTime(2025, 8, 18, 1, 44, 41, 866, DateTimeKind.Local).AddTicks(3240), "be51495f-0234-4d4d-8a1a-88eeb400288a", "0", new DateTime(2025, 8, 18, 1, 44, 41, 866, DateTimeKind.Local).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Amasya", "Ruanda", new DateTime(2025, 8, 18, 1, 44, 41, 866, DateTimeKind.Local).AddTicks(3357), "Gulemen.Akisik21@yahoo.com", "Menekşe Sokak 36a, İzmir, Madagaskar", "Gündoğmuş", "Baykam", "+90-161-295-04-86", new DateTime(2025, 8, 18, 1, 44, 41, 866, DateTimeKind.Local).AddTicks(3358), "0412fdca-7b0b-4924-b7c7-f534fcff30e6", new DateTime(2025, 8, 18, 1, 44, 41, 866, DateTimeKind.Local).AddTicks(3358) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Mardin", "Gabon", new DateTime(2025, 8, 18, 1, 44, 41, 866, DateTimeKind.Local).AddTicks(3483), "Bilgekulucur.Paksut93@yahoo.com", "İbn-i Sina Sokak 7, Düzce, İran", "Buluk", "Sandalcı", "+90-728-784-86-46", new DateTime(2025, 8, 18, 1, 44, 41, 866, DateTimeKind.Local).AddTicks(3483), "4a7e2b65-bf71-43e4-bdd3-2611ce132147", new DateTime(2025, 8, 18, 1, 44, 41, 866, DateTimeKind.Local).AddTicks(3484) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "İçel (Mersin)", "Niue, Yeni Zelanda", new DateTime(2025, 8, 18, 1, 44, 41, 866, DateTimeKind.Local).AddTicks(3633), "Bagaturgerey65@yahoo.com", "Mevlana Sokak 32c, Ankara, Galler", "Bozkuş", "Çevik", "+90-251-771-0-605", new DateTime(2025, 8, 18, 1, 44, 41, 866, DateTimeKind.Local).AddTicks(3633), "7f4d4b6a-6374-482f-947a-0b736b15195f", "0", new DateTime(2025, 8, 18, 1, 44, 41, 866, DateTimeKind.Local).AddTicks(3633) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Diyarbakır", "Endonezya", new DateTime(2025, 8, 18, 1, 44, 41, 866, DateTimeKind.Local).AddTicks(3757), "Adli.Hakyemez@hotmail.com", "Fatih Sokak  45b, Mardin, Kanarya Adaları", "Bektür", "Erçetin", "+90-753-028-9-534", new DateTime(2025, 8, 18, 1, 44, 41, 866, DateTimeKind.Local).AddTicks(3757), "376f67b0-274a-4f15-9dbf-800c4e0cbde6", new DateTime(2025, 8, 18, 1, 44, 41, 866, DateTimeKind.Local).AddTicks(3757) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Ordu", "Ürdün", new DateTime(2025, 8, 18, 1, 44, 41, 866, DateTimeKind.Local).AddTicks(3864), "Adas10@yahoo.com", "Köypınar Sokak 892, Ankara, Vietnam", "Bağtaş", "Tüzün", "+90-021-258-81-85", new DateTime(2025, 8, 18, 1, 44, 41, 866, DateTimeKind.Local).AddTicks(3865), "7e44d380-f5cf-474a-9485-59eeca62f355", "1", new DateTime(2025, 8, 18, 1, 44, 41, 866, DateTimeKind.Local).AddTicks(3865) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Kastamonu", "Orta Afrika Cumhuriyeti", new DateTime(2025, 8, 18, 1, 44, 41, 866, DateTimeKind.Local).AddTicks(3986), "Ermen71@gmail.com", "Afyon Kaya Sokak 27b, Rize, Umman", "Bilgebayunçur", "Karaer", "+90-856-542-4-291", new DateTime(2025, 8, 18, 1, 44, 41, 866, DateTimeKind.Local).AddTicks(3987), "518a208a-4249-4183-a25e-8e3dcb00688e", new DateTime(2025, 8, 18, 1, 44, 41, 866, DateTimeKind.Local).AddTicks(3987) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Giresun", "Gabon", new DateTime(2025, 8, 18, 1, 44, 41, 866, DateTimeKind.Local).AddTicks(4090), "Bilgekan.Koybasi@gmail.com", "Bahçe Sokak 39a, Bitlis, Madagaskar", "Bergü", "Süleymanoğlu", "+90-604-427-96-36", new DateTime(2025, 8, 18, 1, 44, 41, 866, DateTimeKind.Local).AddTicks(4091), "66351c75-0d0b-4dde-8adf-6720221a3715", "1", new DateTime(2025, 8, 18, 1, 44, 41, 866, DateTimeKind.Local).AddTicks(4091) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Ardahan", "Virgin Adaları, İngiltere", new DateTime(2025, 8, 18, 1, 44, 41, 866, DateTimeKind.Local).AddTicks(4190), "Ikicitoyun_Toraman@hotmail.com", "Barış Sokak 91a, Afyon, Şili", "Barkın", "Kunter", "+90-839-906-94-46", new DateTime(2025, 8, 18, 1, 44, 41, 866, DateTimeKind.Local).AddTicks(4191), "3f225f79-ce4f-46f5-8a80-d2f3ca28cdcf", new DateTime(2025, 8, 18, 1, 44, 41, 866, DateTimeKind.Local).AddTicks(4191) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Burdur", "Bulgaristan", new DateTime(2025, 8, 18, 1, 44, 41, 867, DateTimeKind.Local).AddTicks(5626), "Belcir.Bademci94@yahoo.com", "Kocatepe Caddesi 70a, Trabzon, Grönland", "Buyan", "Çevik", "+90-903-108-95-20", new DateTime(2025, 8, 18, 1, 44, 41, 867, DateTimeKind.Local).AddTicks(5631), "f06b90cf-4f36-4abd-bb34-d41cafac5c82", new DateTime(2025, 8, 18, 1, 44, 41, 867, DateTimeKind.Local).AddTicks(5631) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Bingöl", "Güney Georgia ve Güney Sandviç Adaları, İngiltere", new DateTime(2025, 8, 18, 1, 44, 41, 867, DateTimeKind.Local).AddTicks(6333), "Atuncu.Alyanak@hotmail.com", "Bayır Sokak 2, Bitlis, Santa Vincent ve Grenadinler", "Akdemir", "Solmaz", "+90-535-968-77-80", new DateTime(2025, 8, 18, 1, 44, 41, 867, DateTimeKind.Local).AddTicks(6334), "a607d777-2fdb-413e-bc9d-b4c0bc05cf10", new DateTime(2025, 8, 18, 1, 44, 41, 867, DateTimeKind.Local).AddTicks(6334) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Artvin", "Svalbard, Norveç", new DateTime(2025, 8, 18, 1, 44, 41, 867, DateTimeKind.Local).AddTicks(6495), "Bayna2@hotmail.com", "Köypınar Sokak 46, Kocaeli, Mikronezya", "Buğday", "Ayverdi", "+90-279-251-84-90", new DateTime(2025, 8, 18, 1, 44, 41, 867, DateTimeKind.Local).AddTicks(6495), "1f71ef6a-57eb-4ebf-90ab-ca96ed249b29", "1", new DateTime(2025, 8, 18, 1, 44, 41, 867, DateTimeKind.Local).AddTicks(6496) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "K.maraş", "Yeni Kaledonya, Fransa", new DateTime(2025, 8, 18, 1, 44, 41, 867, DateTimeKind.Local).AddTicks(6639), "Belek_Akbulut@gmail.com", "İbn-i Sina Sokak 598, Uşak, Malta", "Akboğa", "Denkel", "+90-240-866-67-51", new DateTime(2025, 8, 18, 1, 44, 41, 867, DateTimeKind.Local).AddTicks(6639), "21fe9136-9be0-4075-b645-1701eee37f42", new DateTime(2025, 8, 18, 1, 44, 41, 867, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "İzmir", "Montserrat", new DateTime(2025, 8, 18, 1, 44, 41, 867, DateTimeKind.Local).AddTicks(6780), "Kimizalma.Cetiner@gmail.com", "Tevfik Fikret Caddesi 9, Karabük, Singapur", "Alp", "Berberoğlu", "+90-525-269-3-631", new DateTime(2025, 8, 18, 1, 44, 41, 867, DateTimeKind.Local).AddTicks(6780), "11153c57-709f-41e6-a3b9-62a96bde232e", new DateTime(2025, 8, 18, 1, 44, 41, 867, DateTimeKind.Local).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Ordu", "Fildişi Sahili", new DateTime(2025, 8, 18, 1, 44, 41, 867, DateTimeKind.Local).AddTicks(6910), "Buzac_Ercetin35@hotmail.com", "Harman Yolu Sokak  27a, Artvin, Svalbard, Norveç", "Alayunt", "Bademci", "+90-547-032-0-584", new DateTime(2025, 8, 18, 1, 44, 41, 867, DateTimeKind.Local).AddTicks(6910), "cb247909-f43f-4016-994a-568e1d0121d3", new DateTime(2025, 8, 18, 1, 44, 41, 867, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Aksaray", "Nijer", new DateTime(2025, 8, 18, 1, 44, 41, 867, DateTimeKind.Local).AddTicks(7019), "Arnac_Tekand10@yahoo.com", "30 Ağustos Caddesi 98a, Bitlis, Somali", "Gelin", "Elçiboğa", "+90-243-958-95-27", new DateTime(2025, 8, 18, 1, 44, 41, 867, DateTimeKind.Local).AddTicks(7020), "8aee5b44-169e-48fa-819c-85c52bc3f008", "0", new DateTime(2025, 8, 18, 1, 44, 41, 867, DateTimeKind.Local).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Adana", "Fransız Güney Eyaletleri (Kerguelen Adaları)", new DateTime(2025, 8, 18, 1, 44, 41, 867, DateTimeKind.Local).AddTicks(7179), "Baltaci.Tutuncu@yahoo.com", "İbn-i Sina Sokak 48b, Isparta, Amerikan Samoa", "Adaldı", "Velioğlu", "+90-072-628-10-42", new DateTime(2025, 8, 18, 1, 44, 41, 867, DateTimeKind.Local).AddTicks(7180), "8dce993e-c5a3-4b9d-8a7d-58415b5300c0", new DateTime(2025, 8, 18, 1, 44, 41, 867, DateTimeKind.Local).AddTicks(7180) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Uşak", "Mikronezya", new DateTime(2025, 8, 18, 1, 44, 41, 867, DateTimeKind.Local).AddTicks(7295), "Baskirt_Aykac@yahoo.com", "Ergenekon Sokak   22c, Kayseri, Palau Adaları", "Bilgiç", "Gürmen", "+90-650-625-5-799", new DateTime(2025, 8, 18, 1, 44, 41, 867, DateTimeKind.Local).AddTicks(7296), "ac7a0bf0-338c-41a0-b3c2-3a76631529cb", "1", new DateTime(2025, 8, 18, 1, 44, 41, 867, DateTimeKind.Local).AddTicks(7296) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Gaziantep", "Virgin Adaları, Amerika", new DateTime(2025, 8, 18, 1, 44, 41, 867, DateTimeKind.Local).AddTicks(7405), "Begcur.Topcuoglu19@yahoo.com", "Nalbant Sokak 3, Muğla, Çin", "Çolpan", "Erberk", "+90-933-127-6-870", new DateTime(2025, 8, 18, 1, 44, 41, 867, DateTimeKind.Local).AddTicks(7405), "c77473fe-4940-4394-9b09-5d2de2ae696d", "0", new DateTime(2025, 8, 18, 1, 44, 41, 867, DateTimeKind.Local).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Bayburt", "Mozambik", new DateTime(2025, 8, 18, 1, 44, 41, 867, DateTimeKind.Local).AddTicks(7522), "Baynal66@yahoo.com", "Yunus Emre Sokak 60b, Bayburt, Antigua ve Barbuda", "Ala", "Adan", "+90-448-820-77-52", new DateTime(2025, 8, 18, 1, 44, 41, 867, DateTimeKind.Local).AddTicks(7523), "d6c7d97f-bf15-4e8a-a57e-b8306b01b8be", new DateTime(2025, 8, 18, 1, 44, 41, 867, DateTimeKind.Local).AddTicks(7523) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Balıkesir", "Birmanya (Myanmar)", new DateTime(2025, 8, 18, 1, 44, 41, 868, DateTimeKind.Local).AddTicks(8116), "Begbars.Aybar22@gmail.com", "Sağlık Sokak 57a, Karabük, Slovenya", "Baybars", "Alpuğan", "+90-176-256-13-44", new DateTime(2025, 8, 18, 1, 44, 41, 868, DateTimeKind.Local).AddTicks(8120), "46cb28e5-538e-43db-afe6-0b94de59a013", new DateTime(2025, 8, 18, 1, 44, 41, 868, DateTimeKind.Local).AddTicks(8120) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Tunceli", "Karadağ", new DateTime(2025, 8, 18, 1, 44, 41, 868, DateTimeKind.Local).AddTicks(8665), "Irtis_Erginsoy@gmail.com", "Dağınık Evler Sokak 65a, Kilis, Honduras", "Baybiçen", "Erbulak", "+90-033-108-08-49", new DateTime(2025, 8, 18, 1, 44, 41, 868, DateTimeKind.Local).AddTicks(8665), "46a208a5-d7b4-4513-8c89-70058ddb665d", new DateTime(2025, 8, 18, 1, 44, 41, 868, DateTimeKind.Local).AddTicks(8665) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Düzce", "Guam, Amerika", new DateTime(2025, 8, 18, 1, 44, 41, 868, DateTimeKind.Local).AddTicks(8796), "Ayitmis.Berberoglu36@yahoo.com", "Kocatepe Caddesi 22c, Ankara, Doğu Timor", "İldike", "Evliyaoğlu", "+90-714-123-7-647", new DateTime(2025, 8, 18, 1, 44, 41, 868, DateTimeKind.Local).AddTicks(8796), "242c1716-fa5c-40f5-8246-852c86a2cf1f", "1", new DateTime(2025, 8, 18, 1, 44, 41, 868, DateTimeKind.Local).AddTicks(8797) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Karabük", "Letonya", new DateTime(2025, 8, 18, 1, 44, 41, 868, DateTimeKind.Local).AddTicks(8916), "Arslanboru_Catalbas@hotmail.com", "Dar Sokak 34a, Kastamonu, Burundi", "Aydoğan", "Ekici", "+90-148-258-7-399", new DateTime(2025, 8, 18, 1, 44, 41, 868, DateTimeKind.Local).AddTicks(8917), "b20ff925-a2a6-442c-b75a-2d5842e4e7e4", new DateTime(2025, 8, 18, 1, 44, 41, 868, DateTimeKind.Local).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Hakkari", "Bulgaristan", new DateTime(2025, 8, 18, 1, 44, 41, 868, DateTimeKind.Local).AddTicks(9054), "Akbay_Dogan@hotmail.com", "İbn-i Sina Sokak 716, Manisa, Güney Kıbrıs Rum Yönetimi", "Boğaçuk", "Akşit", "+90-503-336-26-15", new DateTime(2025, 8, 18, 1, 44, 41, 868, DateTimeKind.Local).AddTicks(9055), "5dbd5f93-00f2-4ef2-be1a-4e374117312e", new DateTime(2025, 8, 18, 1, 44, 41, 868, DateTimeKind.Local).AddTicks(9055) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Yalova", "Anguilla, İngiltere", new DateTime(2025, 8, 18, 1, 44, 41, 868, DateTimeKind.Local).AddTicks(9173), "Begdilli63@gmail.com", "Lütfi Karadirek Caddesi 39, Samsun, Güney Afrika", "Baymünke", "Çevik", "+90-118-902-24-72", new DateTime(2025, 8, 18, 1, 44, 41, 868, DateTimeKind.Local).AddTicks(9173), "38d19826-8a77-4388-a9e5-48cd1e388170", new DateTime(2025, 8, 18, 1, 44, 41, 868, DateTimeKind.Local).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Kırşehir", "Kuzey Maryana Adaları", new DateTime(2025, 8, 18, 1, 44, 41, 868, DateTimeKind.Local).AddTicks(9281), "Arikdoruk.Cevik6@gmail.com", "Oğuzhan Sokak 04c, Bolu, Tanzanya", "Buzaç", "Alpuğan", "+90-256-259-1-273", new DateTime(2025, 8, 18, 1, 44, 41, 868, DateTimeKind.Local).AddTicks(9281), "7bfa2379-a912-499d-920e-742dd53bec98", new DateTime(2025, 8, 18, 1, 44, 41, 868, DateTimeKind.Local).AddTicks(9282) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Şanlıurfa", "Güney Kıbrıs Rum Yönetimi", new DateTime(2025, 8, 18, 1, 44, 41, 868, DateTimeKind.Local).AddTicks(9388), "Atakagan_Elicin@yahoo.com", "Sıran Söğüt Sokak 41b, Diyarbakır, Aruba, Hollanda", "Kepez", "Tekelioğlu", "+90-297-163-01-09", new DateTime(2025, 8, 18, 1, 44, 41, 868, DateTimeKind.Local).AddTicks(9388), "3e808e75-c154-4264-9cbc-62c0b7fb07f4", "0", new DateTime(2025, 8, 18, 1, 44, 41, 868, DateTimeKind.Local).AddTicks(9388) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Osmaniye", "Mozambik", new DateTime(2025, 8, 18, 1, 44, 41, 868, DateTimeKind.Local).AddTicks(9604), "Akbay.Ercetin@yahoo.com", "İsmet Paşa Caddesi 17a, Sinop, Finlandiya", "Balta", "Okur", "+90-950-984-75-05", new DateTime(2025, 8, 18, 1, 44, 41, 868, DateTimeKind.Local).AddTicks(9605), "ba04a873-0591-4b21-8c59-ded717210f30", "1", new DateTime(2025, 8, 18, 1, 44, 41, 868, DateTimeKind.Local).AddTicks(9606) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Düzce", "Norveç", new DateTime(2025, 8, 18, 1, 44, 41, 868, DateTimeKind.Local).AddTicks(9722), "Ant6@yahoo.com", "Sevgi Sokak 544, Elazığ, Slovakya", "Aydınalp", "Denkel", "+90-252-978-3-020", new DateTime(2025, 8, 18, 1, 44, 41, 868, DateTimeKind.Local).AddTicks(9722), "77f9691f-51f3-4f05-b0e7-5155b5691e14", new DateTime(2025, 8, 18, 1, 44, 41, 868, DateTimeKind.Local).AddTicks(9723) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Konya", "Sierra Leone", new DateTime(2025, 8, 18, 1, 44, 41, 868, DateTimeKind.Local).AddTicks(9828), "Artut_Kilicci@hotmail.com", "Fatih Sokak  03b, Kütahya, Guadalup, Fransa", "Beğkulu", "Çörekçi", "+90-554-398-01-26", new DateTime(2025, 8, 18, 1, 44, 41, 868, DateTimeKind.Local).AddTicks(9828), "90a6d55d-12bd-47e8-99cc-6b4219e7531d", new DateTime(2025, 8, 18, 1, 44, 41, 868, DateTimeKind.Local).AddTicks(9829) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Balıkesir", "Küba", new DateTime(2025, 8, 18, 1, 44, 41, 868, DateTimeKind.Local).AddTicks(9921), "Keklik.Ozdogan@yahoo.com", "Fatih Sokak  67b, Kayseri, Estonya", "İrtiş", "Erbulak", "+90-704-216-6-601", new DateTime(2025, 8, 18, 1, 44, 41, 868, DateTimeKind.Local).AddTicks(9922), "571bd956-9eed-4f65-93f2-e4c3cb7b7743", "0", new DateTime(2025, 8, 18, 1, 44, 41, 868, DateTimeKind.Local).AddTicks(9922) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Şırnak", "Wake Adaları, Amerika", new DateTime(2025, 8, 18, 1, 44, 41, 869, DateTimeKind.Local).AddTicks(24), "Baltar_Kunter4@hotmail.com", "Dar Sokak 2, Ordu, Maldiv Adaları", "Altmışkara", "Nalbantoğlu", "+90-249-494-0-878", new DateTime(2025, 8, 18, 1, 44, 41, 869, DateTimeKind.Local).AddTicks(24), "b43e8924-8e3d-45d5-b4c5-76b3d42fef3e", new DateTime(2025, 8, 18, 1, 44, 41, 869, DateTimeKind.Local).AddTicks(25) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Sakarya", "Hindistan", new DateTime(2025, 8, 18, 1, 44, 41, 869, DateTimeKind.Local).AddTicks(9828), "Bilgeisbara.Kaplangi@gmail.com", "Sarıkaya Caddesi 01b, Denizli, Singapur", "Bükebuyruç", "Balcı", "+90-663-687-4-914", new DateTime(2025, 8, 18, 1, 44, 41, 869, DateTimeKind.Local).AddTicks(9832), "f4e790e2-057b-4461-b892-598f99c11ab1", new DateTime(2025, 8, 18, 1, 44, 41, 869, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Şırnak", "Benin", new DateTime(2025, 8, 18, 1, 44, 41, 871, DateTimeKind.Local).AddTicks(213), "Bekec_Kaya30@hotmail.com", "Nalbant Sokak 28, Karaman, Botswana", "Asartegin", "Kavaklıoğlu", "+90-351-024-93-71", new DateTime(2025, 8, 18, 1, 44, 41, 871, DateTimeKind.Local).AddTicks(216), "9fee7b8a-c7a3-4b88-b88e-062764033f55", "0", new DateTime(2025, 8, 18, 1, 44, 41, 871, DateTimeKind.Local).AddTicks(216) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(4840), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(4843), 576.71m, new DateTime(2025, 3, 30, 2, 15, 29, 66, DateTimeKind.Local).AddTicks(734), "Deserunt mollitia eos.", "Refined Frozen Pizza", "b5bb8fbd-49d4-4d9e-8f71-2768d994ff17", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(4844) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(5086), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(5087), 810.44m, new DateTime(2025, 6, 19, 6, 56, 41, 998, DateTimeKind.Local).AddTicks(2336), "Ea repudiandae expedita blanditiis doloremque ab non eligendi quos reiciendis.", "Incredible Soft Soap", "aca40aae-99a2-4b04-855d-dec502ccafbb", 1, new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(5087) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(5169), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(5170), 94.25m, new DateTime(2024, 12, 10, 17, 31, 3, 36, DateTimeKind.Local).AddTicks(4673), "İmpedit eos labore ut.", "Rustic Metal Sausages", "84be1a3d-0597-4e2e-bc43-225eeab29eee", 5, new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(5200), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(5200), 214.93m, new DateTime(2025, 2, 27, 22, 39, 55, 862, DateTimeKind.Local).AddTicks(8760), "Ea veniam sit iure.", "Tasty Soft Ball", "1a9f9e60-90dd-4eca-b91e-c1a9f2f3e19e", 8, new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(5201) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(5235), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(5236), 526.34m, new DateTime(2024, 12, 11, 11, 16, 23, 566, DateTimeKind.Local).AddTicks(6505), "Consequuntur saepe maiores voluptatem.", "Rustic Fresh Shirt", "8e459228-879b-4095-a697-e99ffade3698", 6, new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(5236) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(5264), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(5265), 46.18m, new DateTime(2025, 7, 24, 3, 1, 43, 181, DateTimeKind.Local).AddTicks(5092), "Dolor commodi eum.", "Unbranded Metal Pizza", "3afd425b-c126-49a6-a7fd-be631eef2cd7", 2, new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(5290), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(5291), 467.16m, new DateTime(2025, 4, 22, 1, 25, 44, 396, DateTimeKind.Local).AddTicks(3927), "Assumenda alias perspiciatis nemo possimus possimus quae.", "Generic Soft Pants", "2c390398-7e4b-4c61-aa3e-36b307d3b56f", 7, new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(5291) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(5351), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(5351), 362.33m, new DateTime(2025, 4, 5, 10, 7, 50, 804, DateTimeKind.Local).AddTicks(4480), "Eligendi occaecati fugit aut quo beatae modi molestias.", "Fantastic Metal Tuna", "0b26d388-f9af-4364-992d-6b8d924e7791", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(5352) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(5394), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(5394), 93.99m, new DateTime(2025, 1, 14, 3, 6, 19, 341, DateTimeKind.Local).AddTicks(2957), "Quibusdam quia tempore sed ut deleniti.", "Fantastic Plastic Salad", "b3b65988-6297-44cc-ae17-35c82d9d0de8", 4, new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(5394) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(5427), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(5427), 319.83m, new DateTime(2025, 1, 6, 0, 56, 12, 195, DateTimeKind.Local).AddTicks(1688), "Sint qui et ea porro autem quia ea.", "Handmade Fresh Computer", "661d604b-820a-4dd3-bfc6-224eac499d44", 9, new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(5428) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 8, 16, 7, 40, 46, 877, DateTimeKind.Local).AddTicks(2210), new DateTime(2027, 2, 26, 9, 22, 53, 906, DateTimeKind.Local).AddTicks(7697), new DateTime(2025, 8, 18, 1, 44, 41, 872, DateTimeKind.Local).AddTicks(3244), 9, new DateTime(2025, 8, 18, 1, 44, 41, 872, DateTimeKind.Local).AddTicks(3245), "112369a7-14f7-4956-aeea-adcef6e6a228", 31, 2079.04m, new DateTime(2025, 8, 18, 1, 44, 41, 872, DateTimeKind.Local).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 7, 9, 3, 22, 11, 997, DateTimeKind.Local).AddTicks(1247), new DateTime(2026, 7, 27, 8, 33, 27, 977, DateTimeKind.Local).AddTicks(9801), new DateTime(2025, 8, 18, 1, 44, 41, 872, DateTimeKind.Local).AddTicks(3464), 3, new DateTime(2025, 8, 18, 1, 44, 41, 872, DateTimeKind.Local).AddTicks(3464), "1aaf1922-e4eb-4e9b-943f-5be17f4e8cf3", 12, 1732.56m, new DateTime(2025, 8, 18, 1, 44, 41, 872, DateTimeKind.Local).AddTicks(3464) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 9, 30, 3, 16, 34, 715, DateTimeKind.Local).AddTicks(9604), new DateTime(2025, 10, 8, 23, 37, 30, 739, DateTimeKind.Local).AddTicks(3761), new DateTime(2025, 8, 18, 1, 44, 41, 872, DateTimeKind.Local).AddTicks(3492), 6, new DateTime(2025, 8, 18, 1, 44, 41, 872, DateTimeKind.Local).AddTicks(3492), "a0671cb4-9fed-4ebe-b55f-0911e0bbd8b5", 23, 2460.22m, new DateTime(2025, 8, 18, 1, 44, 41, 872, DateTimeKind.Local).AddTicks(3492) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 12, 19, 17, 40, 283, DateTimeKind.Local).AddTicks(1552), new DateTime(2026, 4, 26, 19, 44, 26, 447, DateTimeKind.Local).AddTicks(9675), new DateTime(2025, 8, 18, 1, 44, 41, 872, DateTimeKind.Local).AddTicks(3507), 7, new DateTime(2025, 8, 18, 1, 44, 41, 872, DateTimeKind.Local).AddTicks(3507), "57c826a0-31ea-4741-a916-23187f662f8e", 45, 1637.77m, new DateTime(2025, 8, 18, 1, 44, 41, 872, DateTimeKind.Local).AddTicks(3507) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 7, 26, 21, 34, 59, 937, DateTimeKind.Local).AddTicks(3980), new DateTime(2026, 12, 8, 15, 10, 50, 898, DateTimeKind.Local).AddTicks(541), new DateTime(2025, 8, 18, 1, 44, 41, 872, DateTimeKind.Local).AddTicks(3521), 10, new DateTime(2025, 8, 18, 1, 44, 41, 872, DateTimeKind.Local).AddTicks(3521), "f4264157-c725-4748-b24d-a46d37f26a35", 1, 1635.68m, new DateTime(2025, 8, 18, 1, 44, 41, 872, DateTimeKind.Local).AddTicks(3522) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 29, 7, 30, 31, 667, DateTimeKind.Local).AddTicks(91), new DateTime(2026, 6, 9, 23, 40, 35, 444, DateTimeKind.Local).AddTicks(8342), new DateTime(2025, 8, 18, 1, 44, 41, 872, DateTimeKind.Local).AddTicks(3557), 6, new DateTime(2025, 8, 18, 1, 44, 41, 872, DateTimeKind.Local).AddTicks(3557), "f089ad21-8178-48ad-ae58-10f1855344c1", 38, 2183.80m, new DateTime(2025, 8, 18, 1, 44, 41, 872, DateTimeKind.Local).AddTicks(3557) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 12, 16, 9, 52, 59, 71, DateTimeKind.Local).AddTicks(5654), new DateTime(2025, 12, 23, 15, 13, 48, 611, DateTimeKind.Local).AddTicks(5298), new DateTime(2025, 8, 18, 1, 44, 41, 872, DateTimeKind.Local).AddTicks(3573), 2, new DateTime(2025, 8, 18, 1, 44, 41, 872, DateTimeKind.Local).AddTicks(3573), "bba6b85e-8f12-4689-b593-92644525ba21", 14, 1511.05m, new DateTime(2025, 8, 18, 1, 44, 41, 872, DateTimeKind.Local).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 10, 6, 33, 15, 168, DateTimeKind.Local).AddTicks(2799), new DateTime(2026, 1, 17, 17, 22, 29, 82, DateTimeKind.Local).AddTicks(5612), new DateTime(2025, 8, 18, 1, 44, 41, 872, DateTimeKind.Local).AddTicks(3586), 1, new DateTime(2025, 8, 18, 1, 44, 41, 872, DateTimeKind.Local).AddTicks(3586), "c0871134-f69e-4d5e-ab5f-bf33f7d6fafa", 25, 1808.39m, new DateTime(2025, 8, 18, 1, 44, 41, 872, DateTimeKind.Local).AddTicks(3587) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 6, 27, 5, 28, 16, 688, DateTimeKind.Local).AddTicks(4398), new DateTime(2026, 7, 12, 15, 24, 44, 855, DateTimeKind.Local).AddTicks(6815), new DateTime(2025, 8, 18, 1, 44, 41, 872, DateTimeKind.Local).AddTicks(3600), 7, new DateTime(2025, 8, 18, 1, 44, 41, 872, DateTimeKind.Local).AddTicks(3600), "755224f2-249c-47e2-8e51-e7be2a02c17b", 48, 1547.12m, new DateTime(2025, 8, 18, 1, 44, 41, 872, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 5, 26, 13, 15, 34, 157, DateTimeKind.Local).AddTicks(2904), new DateTime(2027, 3, 14, 21, 18, 15, 636, DateTimeKind.Local).AddTicks(5449), new DateTime(2025, 8, 18, 1, 44, 41, 872, DateTimeKind.Local).AddTicks(3614), 6, new DateTime(2025, 8, 18, 1, 44, 41, 872, DateTimeKind.Local).AddTicks(3615), "2f8ead1d-7e63-4c72-a202-039a88e76103", 3, 1890.22m, new DateTime(2025, 8, 18, 1, 44, 41, 872, DateTimeKind.Local).AddTicks(3615) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 794, DateTimeKind.Local).AddTicks(7454), new DateTime(2025, 8, 18, 1, 44, 41, 794, DateTimeKind.Local).AddTicks(7459), "28783093-91b3-44c2-95ea-47ede7123803", new DateTime(2025, 8, 18, 1, 44, 41, 794, DateTimeKind.Local).AddTicks(7460) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 795, DateTimeKind.Local).AddTicks(7923), new DateTime(2025, 8, 18, 1, 44, 41, 795, DateTimeKind.Local).AddTicks(7931), "25210a41-b6f5-4592-acf3-74898bcd4a12", new DateTime(2025, 8, 18, 1, 44, 41, 795, DateTimeKind.Local).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 796, DateTimeKind.Local).AddTicks(6799), new DateTime(2025, 8, 18, 1, 44, 41, 796, DateTimeKind.Local).AddTicks(6801), "1445a03f-ec44-470e-abd4-a44d3a48e602", new DateTime(2025, 8, 18, 1, 44, 41, 796, DateTimeKind.Local).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 797, DateTimeKind.Local).AddTicks(5787), new DateTime(2025, 8, 18, 1, 44, 41, 797, DateTimeKind.Local).AddTicks(5791), "e7dd69e0-fa54-4b99-8e6f-bfd80e247630", new DateTime(2025, 8, 18, 1, 44, 41, 797, DateTimeKind.Local).AddTicks(5791) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 798, DateTimeKind.Local).AddTicks(4629), new DateTime(2025, 8, 18, 1, 44, 41, 798, DateTimeKind.Local).AddTicks(4630), "0be03932-9005-4b0c-b230-08c3cf21dc37", new DateTime(2025, 8, 18, 1, 44, 41, 798, DateTimeKind.Local).AddTicks(4630) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 799, DateTimeKind.Local).AddTicks(4021), new DateTime(2025, 8, 18, 1, 44, 41, 799, DateTimeKind.Local).AddTicks(4025), "c67cc5ef-5c30-4d75-be76-aecb45c05547", new DateTime(2025, 8, 18, 1, 44, 41, 799, DateTimeKind.Local).AddTicks(4025) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 800, DateTimeKind.Local).AddTicks(2323), new DateTime(2025, 8, 18, 1, 44, 41, 800, DateTimeKind.Local).AddTicks(2324), "35e85b3d-2b3b-4d53-af85-7423e5661023", new DateTime(2025, 8, 18, 1, 44, 41, 800, DateTimeKind.Local).AddTicks(2324) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 801, DateTimeKind.Local).AddTicks(756), new DateTime(2025, 8, 18, 1, 44, 41, 801, DateTimeKind.Local).AddTicks(760), "387f69fd-e179-4187-8dd8-f4b68735ef06", new DateTime(2025, 8, 18, 1, 44, 41, 801, DateTimeKind.Local).AddTicks(760) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 801, DateTimeKind.Local).AddTicks(9193), new DateTime(2025, 8, 18, 1, 44, 41, 801, DateTimeKind.Local).AddTicks(9194), "e3c9ee53-5d9b-4959-9bf8-b7c1bbbd3dc1", new DateTime(2025, 8, 18, 1, 44, 41, 801, DateTimeKind.Local).AddTicks(9194) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 802, DateTimeKind.Local).AddTicks(7969), new DateTime(2025, 8, 18, 1, 44, 41, 802, DateTimeKind.Local).AddTicks(7972), "8aba092d-a37f-4059-81bb-e0c3d82a76c1", new DateTime(2025, 8, 18, 1, 44, 41, 802, DateTimeKind.Local).AddTicks(7973) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 803, DateTimeKind.Local).AddTicks(6864), new DateTime(2025, 8, 18, 1, 44, 41, 803, DateTimeKind.Local).AddTicks(6865), "94421c8d-ca49-431e-b5dc-98cfb502f654", new DateTime(2025, 8, 18, 1, 44, 41, 803, DateTimeKind.Local).AddTicks(6865) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 804, DateTimeKind.Local).AddTicks(5674), new DateTime(2025, 8, 18, 1, 44, 41, 804, DateTimeKind.Local).AddTicks(5677), "954ed801-782b-4920-bcab-86181afbed94", new DateTime(2025, 8, 18, 1, 44, 41, 804, DateTimeKind.Local).AddTicks(5678) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 805, DateTimeKind.Local).AddTicks(4310), new DateTime(2025, 8, 18, 1, 44, 41, 805, DateTimeKind.Local).AddTicks(4313), "10f8b551-6b07-4892-8569-cb9395c2793c", new DateTime(2025, 8, 18, 1, 44, 41, 805, DateTimeKind.Local).AddTicks(4314) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 806, DateTimeKind.Local).AddTicks(2567), new DateTime(2025, 8, 18, 1, 44, 41, 806, DateTimeKind.Local).AddTicks(2570), "78cbc4bc-7abd-4f28-9b8b-3dfdf85867bc", new DateTime(2025, 8, 18, 1, 44, 41, 806, DateTimeKind.Local).AddTicks(2571) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 807, DateTimeKind.Local).AddTicks(957), new DateTime(2025, 8, 18, 1, 44, 41, 807, DateTimeKind.Local).AddTicks(958), "7351bed3-8c57-43eb-a7dd-b290e3ac806e", new DateTime(2025, 8, 18, 1, 44, 41, 807, DateTimeKind.Local).AddTicks(958) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 807, DateTimeKind.Local).AddTicks(8993), new DateTime(2025, 8, 18, 1, 44, 41, 807, DateTimeKind.Local).AddTicks(8994), "63ae72b3-f469-411f-bc00-c0fbcb149871", new DateTime(2025, 8, 18, 1, 44, 41, 807, DateTimeKind.Local).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 808, DateTimeKind.Local).AddTicks(7692), new DateTime(2025, 8, 18, 1, 44, 41, 808, DateTimeKind.Local).AddTicks(7695), "2106efdf-e0af-4b11-b21b-8d62a1c1dedb", new DateTime(2025, 8, 18, 1, 44, 41, 808, DateTimeKind.Local).AddTicks(7696) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 809, DateTimeKind.Local).AddTicks(5677), new DateTime(2025, 8, 18, 1, 44, 41, 809, DateTimeKind.Local).AddTicks(5678), "f528fce7-76e6-48ed-997c-24b1b3458d17", new DateTime(2025, 8, 18, 1, 44, 41, 809, DateTimeKind.Local).AddTicks(5678) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 810, DateTimeKind.Local).AddTicks(4346), new DateTime(2025, 8, 18, 1, 44, 41, 810, DateTimeKind.Local).AddTicks(4349), "d657bb7a-7213-4fe3-b868-6d4d5f321909", new DateTime(2025, 8, 18, 1, 44, 41, 810, DateTimeKind.Local).AddTicks(4349) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 811, DateTimeKind.Local).AddTicks(2725), new DateTime(2025, 8, 18, 1, 44, 41, 811, DateTimeKind.Local).AddTicks(2726), "1a0aa810-c63a-4d04-b134-bb75a670f546", new DateTime(2025, 8, 18, 1, 44, 41, 811, DateTimeKind.Local).AddTicks(2727) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 812, DateTimeKind.Local).AddTicks(1920), new DateTime(2025, 8, 18, 1, 44, 41, 812, DateTimeKind.Local).AddTicks(1926), "e49c573f-325c-4cac-9d1b-ca6cb560c607", new DateTime(2025, 8, 18, 1, 44, 41, 812, DateTimeKind.Local).AddTicks(1926) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 813, DateTimeKind.Local).AddTicks(464), new DateTime(2025, 8, 18, 1, 44, 41, 813, DateTimeKind.Local).AddTicks(465), "714cbae1-ff7c-4c4a-a2be-7fc31dc9ea78", new DateTime(2025, 8, 18, 1, 44, 41, 813, DateTimeKind.Local).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 813, DateTimeKind.Local).AddTicks(8710), new DateTime(2025, 8, 18, 1, 44, 41, 813, DateTimeKind.Local).AddTicks(8711), "019709ae-e387-4d00-b347-63bae1435e14", new DateTime(2025, 8, 18, 1, 44, 41, 813, DateTimeKind.Local).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 814, DateTimeKind.Local).AddTicks(7666), new DateTime(2025, 8, 18, 1, 44, 41, 814, DateTimeKind.Local).AddTicks(7671), "3fd196cc-36c5-484b-b10f-f2a2c6effd94", new DateTime(2025, 8, 18, 1, 44, 41, 814, DateTimeKind.Local).AddTicks(7671) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 815, DateTimeKind.Local).AddTicks(6056), new DateTime(2025, 8, 18, 1, 44, 41, 815, DateTimeKind.Local).AddTicks(6058), "534ad3e1-75f5-49af-9c1b-64c38d11c9b0", new DateTime(2025, 8, 18, 1, 44, 41, 815, DateTimeKind.Local).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 816, DateTimeKind.Local).AddTicks(4696), new DateTime(2025, 8, 18, 1, 44, 41, 816, DateTimeKind.Local).AddTicks(4699), "9cfb4881-f9b7-45ae-8ce2-3cf3b99dd1ad", new DateTime(2025, 8, 18, 1, 44, 41, 816, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 817, DateTimeKind.Local).AddTicks(3253), new DateTime(2025, 8, 18, 1, 44, 41, 817, DateTimeKind.Local).AddTicks(3255), "dccde886-061b-41c3-ad59-03d9b306bc75", new DateTime(2025, 8, 18, 1, 44, 41, 817, DateTimeKind.Local).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 818, DateTimeKind.Local).AddTicks(2867), new DateTime(2025, 8, 18, 1, 44, 41, 818, DateTimeKind.Local).AddTicks(2871), "35bfe765-a90d-4e5f-9602-00345396dc7c", new DateTime(2025, 8, 18, 1, 44, 41, 818, DateTimeKind.Local).AddTicks(2872) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 819, DateTimeKind.Local).AddTicks(2123), new DateTime(2025, 8, 18, 1, 44, 41, 819, DateTimeKind.Local).AddTicks(2124), "bcb3730e-fdf0-4e8a-81f3-884b9efc1209", new DateTime(2025, 8, 18, 1, 44, 41, 819, DateTimeKind.Local).AddTicks(2124) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 820, DateTimeKind.Local).AddTicks(2239), new DateTime(2025, 8, 18, 1, 44, 41, 820, DateTimeKind.Local).AddTicks(2243), "148b8659-1955-4899-9608-4b24b4acaf35", new DateTime(2025, 8, 18, 1, 44, 41, 820, DateTimeKind.Local).AddTicks(2243) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 821, DateTimeKind.Local).AddTicks(1186), new DateTime(2025, 8, 18, 1, 44, 41, 821, DateTimeKind.Local).AddTicks(1188), "3c8b9132-6b0c-4d3a-bda6-f74fe377f1fe", new DateTime(2025, 8, 18, 1, 44, 41, 821, DateTimeKind.Local).AddTicks(1188) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 822, DateTimeKind.Local).AddTicks(28), new DateTime(2025, 8, 18, 1, 44, 41, 822, DateTimeKind.Local).AddTicks(32), "459dc3fa-398c-4a61-94ef-67024c263b0d", new DateTime(2025, 8, 18, 1, 44, 41, 822, DateTimeKind.Local).AddTicks(32) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 822, DateTimeKind.Local).AddTicks(8475), new DateTime(2025, 8, 18, 1, 44, 41, 822, DateTimeKind.Local).AddTicks(8475), "a538ce73-f84b-4cc9-82ef-fe049af44fdb", new DateTime(2025, 8, 18, 1, 44, 41, 822, DateTimeKind.Local).AddTicks(8476) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 823, DateTimeKind.Local).AddTicks(6947), new DateTime(2025, 8, 18, 1, 44, 41, 823, DateTimeKind.Local).AddTicks(6948), "d6fc0ba3-fb94-4955-9ab2-61e7b5d31495", new DateTime(2025, 8, 18, 1, 44, 41, 823, DateTimeKind.Local).AddTicks(6948) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 824, DateTimeKind.Local).AddTicks(5605), new DateTime(2025, 8, 18, 1, 44, 41, 824, DateTimeKind.Local).AddTicks(5609), "f302ef5f-384e-4289-adc6-b971b0366dc9", new DateTime(2025, 8, 18, 1, 44, 41, 824, DateTimeKind.Local).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 825, DateTimeKind.Local).AddTicks(4154), new DateTime(2025, 8, 18, 1, 44, 41, 825, DateTimeKind.Local).AddTicks(4155), "e2f9c839-8086-47cb-92d4-4c406b0798ad", new DateTime(2025, 8, 18, 1, 44, 41, 825, DateTimeKind.Local).AddTicks(4156) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 826, DateTimeKind.Local).AddTicks(2762), new DateTime(2025, 8, 18, 1, 44, 41, 826, DateTimeKind.Local).AddTicks(2764), "a6a99d32-4350-41bc-8ab3-16fec60417e6", new DateTime(2025, 8, 18, 1, 44, 41, 826, DateTimeKind.Local).AddTicks(2765) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 827, DateTimeKind.Local).AddTicks(901), new DateTime(2025, 8, 18, 1, 44, 41, 827, DateTimeKind.Local).AddTicks(903), "e7372278-052d-4c43-a22f-f203b4682d88", new DateTime(2025, 8, 18, 1, 44, 41, 827, DateTimeKind.Local).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 828, DateTimeKind.Local).AddTicks(356), new DateTime(2025, 8, 18, 1, 44, 41, 828, DateTimeKind.Local).AddTicks(361), "ee51b359-9726-47c2-8097-dd0a3baede89", new DateTime(2025, 8, 18, 1, 44, 41, 828, DateTimeKind.Local).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 828, DateTimeKind.Local).AddTicks(9784), new DateTime(2025, 8, 18, 1, 44, 41, 828, DateTimeKind.Local).AddTicks(9785), "5c1fa69d-1517-4ec5-9c17-bb6e43c11a8c", new DateTime(2025, 8, 18, 1, 44, 41, 828, DateTimeKind.Local).AddTicks(9785) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 829, DateTimeKind.Local).AddTicks(8486), new DateTime(2025, 8, 18, 1, 44, 41, 829, DateTimeKind.Local).AddTicks(8490), "a4d5eadc-2270-4699-a1fc-aaebda21e988", new DateTime(2025, 8, 18, 1, 44, 41, 829, DateTimeKind.Local).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 830, DateTimeKind.Local).AddTicks(7156), new DateTime(2025, 8, 18, 1, 44, 41, 830, DateTimeKind.Local).AddTicks(7157), "6cf1eb51-391d-49a0-abbb-0f10609d7737", new DateTime(2025, 8, 18, 1, 44, 41, 830, DateTimeKind.Local).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 831, DateTimeKind.Local).AddTicks(5572), new DateTime(2025, 8, 18, 1, 44, 41, 831, DateTimeKind.Local).AddTicks(5575), "655c80c6-9e7a-4b76-ac76-3b9ff50e7b52", new DateTime(2025, 8, 18, 1, 44, 41, 831, DateTimeKind.Local).AddTicks(5576) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 832, DateTimeKind.Local).AddTicks(3681), new DateTime(2025, 8, 18, 1, 44, 41, 832, DateTimeKind.Local).AddTicks(3683), "16055d88-410f-45e7-b0a6-96155a197b48", new DateTime(2025, 8, 18, 1, 44, 41, 832, DateTimeKind.Local).AddTicks(3683) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 833, DateTimeKind.Local).AddTicks(2121), new DateTime(2025, 8, 18, 1, 44, 41, 833, DateTimeKind.Local).AddTicks(2125), "92069575-c775-4e19-8e53-6c49474fc92e", new DateTime(2025, 8, 18, 1, 44, 41, 833, DateTimeKind.Local).AddTicks(2125) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 834, DateTimeKind.Local).AddTicks(131), new DateTime(2025, 8, 18, 1, 44, 41, 834, DateTimeKind.Local).AddTicks(132), "333d11dd-345c-4cb6-89e7-d60f8646224f", new DateTime(2025, 8, 18, 1, 44, 41, 834, DateTimeKind.Local).AddTicks(132) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 834, DateTimeKind.Local).AddTicks(8235), new DateTime(2025, 8, 18, 1, 44, 41, 834, DateTimeKind.Local).AddTicks(8236), "5655e430-fcd4-4e32-a27d-6ff946fc2afe", new DateTime(2025, 8, 18, 1, 44, 41, 834, DateTimeKind.Local).AddTicks(8236) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 835, DateTimeKind.Local).AddTicks(7374), new DateTime(2025, 8, 18, 1, 44, 41, 835, DateTimeKind.Local).AddTicks(7377), "76f995ed-f484-48a5-bd67-89a940087ff7", new DateTime(2025, 8, 18, 1, 44, 41, 835, DateTimeKind.Local).AddTicks(7377) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 836, DateTimeKind.Local).AddTicks(6855), new DateTime(2025, 8, 18, 1, 44, 41, 836, DateTimeKind.Local).AddTicks(6858), "e7a5f030-8ef5-4c5e-b313-8c3d481cddef", new DateTime(2025, 8, 18, 1, 44, 41, 836, DateTimeKind.Local).AddTicks(6858) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 837, DateTimeKind.Local).AddTicks(6096), new DateTime(2025, 8, 18, 1, 44, 41, 837, DateTimeKind.Local).AddTicks(6099), "384fcd0d-29ae-4150-b5b0-c31206b2cd8d", new DateTime(2025, 8, 18, 1, 44, 41, 837, DateTimeKind.Local).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 838, DateTimeKind.Local).AddTicks(4541), new DateTime(2025, 8, 18, 1, 44, 41, 838, DateTimeKind.Local).AddTicks(4542), "545c9620-4ccf-49c0-9de0-2aac47f894be", new DateTime(2025, 8, 18, 1, 44, 41, 838, DateTimeKind.Local).AddTicks(4542) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 839, DateTimeKind.Local).AddTicks(6572), new DateTime(2025, 8, 18, 1, 44, 41, 839, DateTimeKind.Local).AddTicks(6580), "8effe77a-28e7-48ef-b9af-bc2718b05852", new DateTime(2025, 8, 18, 1, 44, 41, 839, DateTimeKind.Local).AddTicks(6580) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 840, DateTimeKind.Local).AddTicks(5920), new DateTime(2025, 8, 18, 1, 44, 41, 840, DateTimeKind.Local).AddTicks(5924), "0cf8ffd7-eec5-4ba0-8889-a6c27e135f23", new DateTime(2025, 8, 18, 1, 44, 41, 840, DateTimeKind.Local).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 841, DateTimeKind.Local).AddTicks(5301), new DateTime(2025, 8, 18, 1, 44, 41, 841, DateTimeKind.Local).AddTicks(5305), "94fb8aab-c46c-4772-9cf0-e3c1e8bf4895", new DateTime(2025, 8, 18, 1, 44, 41, 841, DateTimeKind.Local).AddTicks(5305) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 842, DateTimeKind.Local).AddTicks(4506), new DateTime(2025, 8, 18, 1, 44, 41, 842, DateTimeKind.Local).AddTicks(4510), "2eaf298b-aba0-4fa1-87c4-7eb079fb0882", new DateTime(2025, 8, 18, 1, 44, 41, 842, DateTimeKind.Local).AddTicks(4511) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 843, DateTimeKind.Local).AddTicks(3346), new DateTime(2025, 8, 18, 1, 44, 41, 843, DateTimeKind.Local).AddTicks(3348), "020b4ec7-73da-492e-ab95-ed893ec97806", new DateTime(2025, 8, 18, 1, 44, 41, 843, DateTimeKind.Local).AddTicks(3348) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 844, DateTimeKind.Local).AddTicks(2235), new DateTime(2025, 8, 18, 1, 44, 41, 844, DateTimeKind.Local).AddTicks(2239), "c88d027b-092f-4acb-b5f6-a201548cafa5", new DateTime(2025, 8, 18, 1, 44, 41, 844, DateTimeKind.Local).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 845, DateTimeKind.Local).AddTicks(1640), new DateTime(2025, 8, 18, 1, 44, 41, 845, DateTimeKind.Local).AddTicks(1644), "5da8b72f-143d-45a3-8871-bb5c3193aef8", new DateTime(2025, 8, 18, 1, 44, 41, 845, DateTimeKind.Local).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 846, DateTimeKind.Local).AddTicks(425), new DateTime(2025, 8, 18, 1, 44, 41, 846, DateTimeKind.Local).AddTicks(429), "9b9e68f7-e493-4220-961a-54aa4d17ad62", new DateTime(2025, 8, 18, 1, 44, 41, 846, DateTimeKind.Local).AddTicks(429) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 846, DateTimeKind.Local).AddTicks(9217), new DateTime(2025, 8, 18, 1, 44, 41, 846, DateTimeKind.Local).AddTicks(9221), "013f4b4e-f9b2-4174-81cb-a5932f685d02", new DateTime(2025, 8, 18, 1, 44, 41, 846, DateTimeKind.Local).AddTicks(9222) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 847, DateTimeKind.Local).AddTicks(8054), new DateTime(2025, 8, 18, 1, 44, 41, 847, DateTimeKind.Local).AddTicks(8058), "c71caf65-ba1e-4ef7-8180-9a92d9e603cf", new DateTime(2025, 8, 18, 1, 44, 41, 847, DateTimeKind.Local).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 848, DateTimeKind.Local).AddTicks(7482), new DateTime(2025, 8, 18, 1, 44, 41, 848, DateTimeKind.Local).AddTicks(7485), "d87aa9d6-6360-4573-a140-d72c40d547e5", new DateTime(2025, 8, 18, 1, 44, 41, 848, DateTimeKind.Local).AddTicks(7486) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 849, DateTimeKind.Local).AddTicks(6277), new DateTime(2025, 8, 18, 1, 44, 41, 849, DateTimeKind.Local).AddTicks(6281), "5d1736e1-15db-4c4e-9c28-bdc8cd303721", new DateTime(2025, 8, 18, 1, 44, 41, 849, DateTimeKind.Local).AddTicks(6281) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 850, DateTimeKind.Local).AddTicks(5859), new DateTime(2025, 8, 18, 1, 44, 41, 850, DateTimeKind.Local).AddTicks(5862), "21d4cb42-41a6-4266-9bee-4f5bdf50e65e", new DateTime(2025, 8, 18, 1, 44, 41, 850, DateTimeKind.Local).AddTicks(5863) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 851, DateTimeKind.Local).AddTicks(5383), new DateTime(2025, 8, 18, 1, 44, 41, 851, DateTimeKind.Local).AddTicks(5387), "8e4373fc-7ac9-4e32-8d0a-111edcee4a6b", new DateTime(2025, 8, 18, 1, 44, 41, 851, DateTimeKind.Local).AddTicks(5388) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 852, DateTimeKind.Local).AddTicks(3746), new DateTime(2025, 8, 18, 1, 44, 41, 852, DateTimeKind.Local).AddTicks(3749), "e075f64a-5c32-4754-bb23-1d9f5a252198", new DateTime(2025, 8, 18, 1, 44, 41, 852, DateTimeKind.Local).AddTicks(3749) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 853, DateTimeKind.Local).AddTicks(2180), new DateTime(2025, 8, 18, 1, 44, 41, 853, DateTimeKind.Local).AddTicks(2183), "cd158266-2583-42a7-9759-08311564c496", new DateTime(2025, 8, 18, 1, 44, 41, 853, DateTimeKind.Local).AddTicks(2183) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 854, DateTimeKind.Local).AddTicks(759), new DateTime(2025, 8, 18, 1, 44, 41, 854, DateTimeKind.Local).AddTicks(762), "5022eb0a-5823-498a-8918-e21b33cd86a2", new DateTime(2025, 8, 18, 1, 44, 41, 854, DateTimeKind.Local).AddTicks(762) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 854, DateTimeKind.Local).AddTicks(9885), new DateTime(2025, 8, 18, 1, 44, 41, 854, DateTimeKind.Local).AddTicks(9889), "a2b79d52-eb3e-45f4-913a-808a30700c3b", new DateTime(2025, 8, 18, 1, 44, 41, 854, DateTimeKind.Local).AddTicks(9889) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 855, DateTimeKind.Local).AddTicks(9204), new DateTime(2025, 8, 18, 1, 44, 41, 855, DateTimeKind.Local).AddTicks(9205), "723528c0-72d8-4b42-8dd5-913c478ac74f", new DateTime(2025, 8, 18, 1, 44, 41, 855, DateTimeKind.Local).AddTicks(9205) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 856, DateTimeKind.Local).AddTicks(9077), new DateTime(2025, 8, 18, 1, 44, 41, 856, DateTimeKind.Local).AddTicks(9081), "07303b32-8c04-46c5-8561-2394d8b70c38", new DateTime(2025, 8, 18, 1, 44, 41, 856, DateTimeKind.Local).AddTicks(9081) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 857, DateTimeKind.Local).AddTicks(8610), new DateTime(2025, 8, 18, 1, 44, 41, 857, DateTimeKind.Local).AddTicks(8614), "bab95987-9b8a-4f83-a14e-0ff5f0e23965", new DateTime(2025, 8, 18, 1, 44, 41, 857, DateTimeKind.Local).AddTicks(8615) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 858, DateTimeKind.Local).AddTicks(7544), new DateTime(2025, 8, 18, 1, 44, 41, 858, DateTimeKind.Local).AddTicks(7547), "c408c7f4-a9bc-41ac-a6f2-a05e7fb1f321", new DateTime(2025, 8, 18, 1, 44, 41, 858, DateTimeKind.Local).AddTicks(7547) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 859, DateTimeKind.Local).AddTicks(6885), new DateTime(2025, 8, 18, 1, 44, 41, 859, DateTimeKind.Local).AddTicks(6888), "cde5ba35-7ab2-48f9-b0b3-2194eda52d3a", new DateTime(2025, 8, 18, 1, 44, 41, 859, DateTimeKind.Local).AddTicks(6889) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 860, DateTimeKind.Local).AddTicks(5570), new DateTime(2025, 8, 18, 1, 44, 41, 860, DateTimeKind.Local).AddTicks(5574), "57048d46-8fc2-4f40-8a77-8cb2f261f2d4", new DateTime(2025, 8, 18, 1, 44, 41, 860, DateTimeKind.Local).AddTicks(5574) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 861, DateTimeKind.Local).AddTicks(4112), new DateTime(2025, 8, 18, 1, 44, 41, 861, DateTimeKind.Local).AddTicks(4113), "85151f21-81c8-46b5-b31e-86627ddc5077", new DateTime(2025, 8, 18, 1, 44, 41, 861, DateTimeKind.Local).AddTicks(4113) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 862, DateTimeKind.Local).AddTicks(2889), new DateTime(2025, 8, 18, 1, 44, 41, 862, DateTimeKind.Local).AddTicks(2893), "7cf03eca-3103-4638-9062-43325b819117", new DateTime(2025, 8, 18, 1, 44, 41, 862, DateTimeKind.Local).AddTicks(2893) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8044), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8045), "bf0f02cc-8f82-41af-a8e9-5f0915bf3b62", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8045) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8068), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8068), "b627ccc9-caf6-4a17-8e1d-0a253b9b630c", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8074), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8074), "f76505da-3c66-454f-ad83-afd59d5b11f7", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8074) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8078), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8078), "53e7d14f-0734-45bf-ad8b-69c65045a51f", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8089), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8089), "583865be-9eb5-4582-9af1-b3a6531de2d2", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8090) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8095), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8095), "87428ef8-d43b-408f-92c3-d786f2071d41", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8095) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8099), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8099), "e204f253-a755-4a7d-b731-511644506213", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8103), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8104), "1cc4473f-2a1d-43f4-9f99-d99ee9a3cdb5", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8111), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8111), "c4d5c83b-1aa1-40cc-9051-94632ffea03e", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8112) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8116), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8116), "6e695053-4cc4-4f45-90c1-e3b3d5d9d1cf", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8116) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8121), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8121), "3ded4a5e-568d-4cca-ba15-5631702c77c0", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8121) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8125), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8125), "81c04bf2-ad63-486f-aa0a-ddb38caa7786", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8125) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8160), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8161), "23fd5c77-885a-4ad5-8327-fb49a237e22b", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8161) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8166), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8166), "e3f1d137-46a1-4867-bcbb-2a8ad14a0ae4", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8166) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8171), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8171), "26b3016b-c4d4-4437-bf67-f069006e4a12", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8171) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8175), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8176), "534fa7f9-b510-4a42-ab43-623f684e0a99", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8176) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8183), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8183), "13380e47-ca5d-4483-b687-14ed8e04792f", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8183) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8187), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8188), "790acdb0-9c74-41f9-b808-2da64cacdc7c", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8188) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8193), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8193), "0fdb1996-fbca-4127-8f1d-c5941f6d5ae9", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8193) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8197), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8197), "de45d661-47c1-4a7a-bc2e-83345d58e000", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8197) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8204), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8205), "56cf3a83-7a1e-46d6-a2d7-1f68042c57d7", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8205) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8208), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8209), "3e5aec4f-ce37-435d-87e5-df1ead273c64", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8209) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8213), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8214), "f2f9a820-8661-4631-8eda-54e35e97e1d4", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8214) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8218), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8218), "77ed55cf-00a3-4a74-896c-12d4bf4f832f", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8218) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8225), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8225), "9f81d1ff-4efa-49b9-91ea-ac47e7dfa97b", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8225) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8229), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8230), "491f9465-b92e-41a9-987e-0ba309c54e4f", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8234), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8234), "0e6a078a-df35-4f76-a924-0e62a4ee246a", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8234) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8238), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8238), "607e8fd2-cde2-4070-8eb4-8a8e9d851e37", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8238) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8250), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8250), "8dc12c50-81a2-4551-b731-4ee324c2a0b3", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8250) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8255), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8255), "e9dd0e79-1161-44c1-899e-d3c7b5d42020", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8255) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8260), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8260), "c8b5086b-e9c4-4010-b3c0-60fcae59b3d4", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8260) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8264), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8264), "e1533c53-e62d-4a3c-9b78-a189ae132e79", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8264) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8268), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8269), "f32942e5-b55b-474c-b8ff-44f60672439c", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8273), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8273), "fe9c8cbd-ff1d-46fe-a4a3-bb2bc7825026", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8274) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8278), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8279), "9bdb5611-eedc-4d88-bd2e-37d834b5064f", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8279) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8283), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8283), "687e7d87-3a71-44d4-bab7-8982cd52549d", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8284) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8303), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8304), "ba6d0dfa-90c2-436c-b267-17fdf2bc051c", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8305) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8309), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8309), "2d4e0123-d997-4d6f-9004-281c1fbd2844", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8315), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8315), "9f92af5d-20d8-4db7-a413-3cec9945d352", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8319), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8319), "14c88245-6ce9-4aaa-bd2d-d91b1a0dd236", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8319) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8324), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8324), "ad667e01-d07a-4faa-b51f-ff7b2efcb302", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8324) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8328), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8328), "7ba03061-5750-479f-96f3-a6317a6c06d4", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8329) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8333), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8333), "310e5033-1939-48f4-9faf-ed3ef9a3e736", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8333) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8337), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8337), "b8b0cc98-976b-4c22-af49-215da4c431a2", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8337) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8342), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8342), "d1e71210-d72c-4777-b4d7-d81cc15acb48", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8343) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8346), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8346), "33feda1c-7799-4664-83d2-dfe34704635d", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8347) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8351), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8351), "b2951cbd-8ab6-449e-9464-bfd25f8e2830", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8352) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8355), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8355), "091f13c6-1f2f-4d1d-80fb-14d04d25ecca", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8356) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8360), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8360), "3de45877-5a74-4157-b614-eaa4268f550d", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8364), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8364), "ad04da45-29fe-464f-80af-2b09fdba7655", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8368), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8368), "27e9eb6a-f200-4f85-8b60-11ab88aaf609", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8372), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8373), "082aaabd-d5d1-48b2-b710-122a1f1e773c", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8373) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8379), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8379), "1aba2b77-6d02-4833-8ba1-7f9f5c88915b", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8379) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8383), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8384), "fa082143-102d-4ace-9a2e-92589da350c2", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8384) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8388), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8388), "479cd183-29c4-4e64-aab0-004ba3d78a83", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8388) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8392), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8392), "7fdb03d9-549d-4055-9385-21f7e4e4d636", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8392) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8396), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8396), "590666d2-5b42-4a82-8a08-78a69e609df8", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8397) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8400), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8400), "573cac76-d44e-4d17-9f8e-8eec651f3631", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8401) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8405), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8405), "29768bf2-c532-4e80-8d98-7ab0519ecc5e", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8405) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8409), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8409), "b8560216-713d-4ee0-8100-1c905680c6d4", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8409) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8414), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8414), "f8f66791-e133-42a6-ae95-56be2a266577", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8415) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8418), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8418), "11f39301-3491-4682-adb3-1339e0982c23", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8419) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8422), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8423), "1a3621f5-41cb-473d-8b6a-107a64d78148", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8423) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8426), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8427), "f4fcd55a-30de-40e3-930c-ac4a39f31026", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8427) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8431), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8431), "5ca4ea6e-717d-403d-9679-e7092d0c30d1", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8431) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8469), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8469), "c1f633a7-da23-467a-8c81-170b4d394978", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8469) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8475), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8475), "78693196-8678-4c2d-aa22-c70411023046", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8475) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8479), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8480), "1b58ca01-25c3-4e0c-8d0a-801290405f3b", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8485), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8486), "e8b33275-ceb0-43e1-9f1a-2d73879a7fc2", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8486) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8490), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8490), "ed39c49e-bec1-4598-94c1-133b5dd525af", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8531), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8532), "51452bd4-5897-4f35-ab44-ab66470544fc", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8532) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8542), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8542), "92ffc87c-6a1e-4a86-9b78-8e721b87d172", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8542) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8547), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8548), "bbb76761-d92c-4042-b450-35c660968f0f", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8548) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8554), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8554), "53f042c8-d43c-483b-b794-a68cec90adf8", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8555) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8560), 11, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8560), "3e8766e6-1be7-4162-8204-0bb8d060ae8b", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8566), 12, new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8566), "1e896be6-f9a5-4982-9cc1-10c9ad3464c9", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8567) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "ShiftDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8571), 11, new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8571), "07af4df3-f614-49d9-9e12-109597aca3db", new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8571) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8577), 12, new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8577), "72744006-bb56-41d2-ba2c-701aab3cb5b5", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8578) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8581), 12, new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8582), "667c84a0-6ccf-4b35-9e5c-0bafec920ad8", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8582) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8586), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8587), "81dead86-9aee-48f2-b25c-cd317bcda987", 3, new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8587) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8592), 11, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8592), "66235408-df92-410d-a8eb-1c5cb2029599", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8592) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8598), 12, new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8598), "72095461-080b-4deb-ba51-0e0502a238a5", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8598) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8603), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8604), "8c3e4f79-94c8-4b10-8a69-702edb5722f7", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8604) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8610), 11, new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8610), "6376c89f-091d-4f95-a4e2-df5f863e5d8c", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8614), 12, new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8614), "7c1e7ad6-c7b8-44d2-93dd-c2763f54b170", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8614) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8618), 12, new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8618), "d6676505-0760-4bc5-89dd-bdba79d9ce9b", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8618) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8622), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8623), "1f2243b1-2113-48aa-ab9f-1432a396d4cf", 3, new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8623) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8627), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8627), "d192dd0c-3048-4527-b3b2-c24c50b7c5ff", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8627) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8633), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8633), "dd9a9574-f62d-462b-8cbd-ff230bf933d6", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8633) });

            migrationBuilder.InsertData(
                table: "Shifts",
                columns: new[] { "Id", "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "SelectedStatus", "ShiftDate", "ShiftType", "StartTime", "UpdatedComputerName", "UpdatedDate" },
                values: new object[] { 90, new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8637), 12, new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8637), "1fc00407-7336-4b75-aa2b-524ba93bd4b1", 0, new DateTime(2025, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 18, 1, 44, 41, 863, DateTimeKind.Local).AddTicks(8638) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 90);

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
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Rocioberg", "Saint Lucia", new DateTime(2025, 8, 18, 1, 42, 39, 810, DateTimeKind.Local).AddTicks(656), "981 Macie Flat, Abdullahville, New Zealand", "CH1980535005H07Z92860", "(281) 815-1615", "Doris84@gmail.com", new DateTime(2025, 8, 18, 1, 42, 39, 810, DateTimeKind.Local).AddTicks(657), "George", "Towne", "ae324103-5caf-4c12-8562-0cad3dd5e391", "71885-9797", new DateTime(2025, 8, 18, 1, 42, 39, 810, DateTimeKind.Local).AddTicks(657) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "South Taurean", "French Polynesia", new DateTime(2025, 8, 18, 1, 42, 39, 810, DateTimeKind.Local).AddTicks(877), "061 Strosin Landing, Lake Fermin, French Polynesia", "CZ4031007034470060910013", "1-768-215-4604", "Hillary.Kutch3@yahoo.com", new DateTime(2025, 8, 18, 1, 42, 39, 810, DateTimeKind.Local).AddTicks(877), "Lamar", "Hackett", "b372b635-ea35-4f5c-990f-5218b7cec152", "67726", new DateTime(2025, 8, 18, 1, 42, 39, 810, DateTimeKind.Local).AddTicks(878) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Eskişehir", "Gine", new DateTime(2025, 8, 18, 1, 42, 39, 890, DateTimeKind.Local).AddTicks(794), "Barsboga.Denkel47@yahoo.com", "Gül Sokak 644, Tunceli, Dominik Cumhuriyeti", "Baytara", "Demirel", "+90-056-300-28-56", new DateTime(2025, 8, 18, 1, 42, 39, 890, DateTimeKind.Local).AddTicks(794), "ba494f7f-5194-49a7-abac-3f68a8485a19", "1", new DateTime(2025, 8, 18, 1, 42, 39, 890, DateTimeKind.Local).AddTicks(794) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Eskişehir", "Bulgaristan", new DateTime(2025, 8, 18, 1, 42, 39, 890, DateTimeKind.Local).AddTicks(1118), "Kirlangic26@gmail.com", "Sevgi Sokak 28c, Karaman, Kamboçya", "Ayas", "Bademci", "+90-141-664-6-739", new DateTime(2025, 8, 18, 1, 42, 39, 890, DateTimeKind.Local).AddTicks(1118), "c917944b-af83-4c63-ba97-32f352f637dc", "0", new DateTime(2025, 8, 18, 1, 42, 39, 890, DateTimeKind.Local).AddTicks(1118) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Yalova", "Palau Adaları", new DateTime(2025, 8, 18, 1, 42, 39, 890, DateTimeKind.Local).AddTicks(1252), "Al.Sepetci@hotmail.com", "Köypınar Sokak 04b, Hakkari, Tuvalu", "Alparsbeğ", "Dalkıran", "+90-050-335-27-69", new DateTime(2025, 8, 18, 1, 42, 39, 890, DateTimeKind.Local).AddTicks(1252), "acb55188-cc22-4e71-a4db-fefa06f9006c", "1", new DateTime(2025, 8, 18, 1, 42, 39, 890, DateTimeKind.Local).AddTicks(1252) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Aydın", "Togo", new DateTime(2025, 8, 18, 1, 42, 39, 890, DateTimeKind.Local).AddTicks(1374), "Bugduz.Ertepinar@hotmail.com", "Dağınık Evler Sokak 75, Erzurum, İsveç", "Bozbörü", "Özgörkey", "+90-021-066-4-082", new DateTime(2025, 8, 18, 1, 42, 39, 890, DateTimeKind.Local).AddTicks(1375), "1aadc93d-60c8-4747-8153-9ae71b4c1766", "1", new DateTime(2025, 8, 18, 1, 42, 39, 890, DateTimeKind.Local).AddTicks(1375) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Düzce", "Svaziland", new DateTime(2025, 8, 18, 1, 42, 39, 890, DateTimeKind.Local).AddTicks(1493), "Cabus_Nebioglu63@hotmail.com", "Dağınık Evler Sokak 33, Malatya, Vanuatu", "Arbuz", "Sandalcı", "+90-949-353-1-854", new DateTime(2025, 8, 18, 1, 42, 39, 890, DateTimeKind.Local).AddTicks(1494), "608208b5-cfd1-4d8c-931e-2b6e32a8e95d", new DateTime(2025, 8, 18, 1, 42, 39, 890, DateTimeKind.Local).AddTicks(1494) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Şırnak", "Fransız Güney Eyaletleri (Kerguelen Adaları)", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(2350), "Bortecine.Daglaroglu@yahoo.com", "Harman Yolu Sokak  81b, Bitlis, Ukrayna", "Gülegen", "Sarıoğlu", "+90-206-104-0-372", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(2353), "e9c79150-2993-467f-9929-b825b46e6b7c", "0", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(2354) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Amasya", "İrlanda", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(3009), "Bozok.Koyluoglu@yahoo.com", "Bayır Sokak 3, Edirne, Paraguay", "Beyrem", "Akışık", "+90-571-858-6-988", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(3009), "fa47a6d5-22eb-4857-9950-f9b095aa39c7", "1", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(3009) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Adıyaman", "Tonga", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(3432), "Bagatursepi15@yahoo.com", "Harman Yolu Sokak  14b, Nevşehir, El Salvador", "Abak", "Tanrıkulu", "+90-003-884-9-153", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(3433), "7eae303e-d7d8-44fa-b409-c7d829190933", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(3433) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Edirne", "İrlanda", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(4065), "Begdurmus_Cevik@hotmail.com", "Atatürk Bulvarı 008, Niğde, Venezuela", "Bumın", "Poçan", "+90-208-149-5-937", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(4065), "e54b2049-7710-4912-89c3-e4f56899fb99", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(4066) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Bingöl", "Gine", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(4172), "Atsiz_Menemencioglu@yahoo.com", "Ergenekon Sokak   45, Sakarya, Madagaskar", "Bastı", "Egeli", "+90-712-803-7-191", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(4172), "3414b135-816d-42ee-bad8-6378ea580e5f", "0", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(4173) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Kırşehir", "Doğu Timor", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(4290), "Baltir_Cetin@yahoo.com", "Sıran Söğüt Sokak 3, Antalya, Nikaragua", "Ebren", "Keçeci", "+90-508-236-4-006", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(4291), "b51a2b43-9bfc-4896-9c5a-18627e00ff66", new DateTime(2025, 8, 18, 1, 42, 39, 891, DateTimeKind.Local).AddTicks(4291) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Batman", "Makau (Makao)", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(5066), "Adberilgen.Kahveci62@yahoo.com", "Yunus Emre Sokak 65c, Yalova, Jamaika", "Bozan", "Dağlaroğlu", "+90-897-516-6-475", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(5070), "20b0dd93-4aea-4546-a9ce-3595645e4cfd", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(5071) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Çorum", "Mayotte, Fransa", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(5737), "Barmakli46@gmail.com", "Barış Sokak 67c, Sivas, Andorra", "Arslanargun", "Durmaz", "+90-313-931-41-39", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(5737), "e9211ab1-29a0-41a4-adb3-cee34efbf73e", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(5738) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Bursa", "Kiribati", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(5886), "Bogacuk_Baturalp@gmail.com", "Barış Sokak 249, Şanlıurfa, Güney Georgia ve Güney Sandviç Adaları, İngiltere", "Baysungur", "Poyrazoğlu", "+90-997-094-04-49", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(5887), "aa355579-58f8-4d09-be38-e92ba01af792", "0", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(5887) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Kırıkkale", "Güney Kıbrıs Rum Yönetimi", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(6003), "Barcadogdu.Bakircioglu@hotmail.com", "Lütfi Karadirek Caddesi 78b, Bitlis, Seyşeller", "Barkan", "Demirbaş", "+90-211-721-79-04", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(6003), "32c5f4fb-2b39-4429-8298-76a2b5c3a284", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(6004) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Trabzon", "Pakistan", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(6142), "Berginsenge_Akan29@gmail.com", "Fatih Sokak  069, Yozgat, Irak", "Bönek", "Öymen", "+90-213-464-9-519", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(6142), "8de47889-d491-465a-8495-be9a5db47c61", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(6143) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Denizli", "Brezilya", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(6507), "Baksi_Oztuna64@hotmail.com", "Alparslan Türkeş Bulvarı 9, Uşak, Küba", "Çıngır", "Erez", "+90-181-642-20-32", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(6507), "daeb3b6b-f225-4a3b-9991-bd44db85c502", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(6507) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Zonguldak", "Japonya", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(6739), "Bugrakarakagan82@yahoo.com", "Bayır Sokak 12, Burdur, İran", "Atsız", "Erçetin", "+90-141-107-13-67", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(6740), "5c598e1b-f4e8-450b-bc72-0f4705017226", "1", new DateTime(2025, 8, 18, 1, 42, 39, 892, DateTimeKind.Local).AddTicks(6740) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Şanlıurfa", "Portekiz", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(8013), "Bekec1@gmail.com", "Sağlık Sokak 65b, Uşak, Libya", "Erten", "Tekand", "+90-910-194-2-395", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(8017), "63ef3f3b-2925-4347-9afb-1b085b3c15b4", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(8017) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Çanakkale", "Cibuti", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(8911), "Buyat2@hotmail.com", "Tevfik Fikret Caddesi 9, Hakkari, Zimbabve", "Baltur", "Denkel", "+90-482-769-5-399", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(8911), "ee6252a3-616c-49c2-9f74-1c080cab7932", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(8911) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Muş", "Polonya", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9252), "Etil.Alpugan@hotmail.com", "Nalbant Sokak 53c, Isparta, Laos", "Akçora", "Dalkıran", "+90-652-432-0-532", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9252), "1b1a985c-84cd-4770-9ef3-eb03bec22d45", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9252) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Sivas", "Svalbard, Norveç", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9360), "Buke_Kunt80@hotmail.com", "Harman Altı Sokak 514, Kütahya, Laos", "Katun", "Tahincioğlu", "+90-099-191-92-52", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9360), "08a50c76-855b-4c8c-af59-188b0e067611", "1", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Kocaeli", "Cibuti", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9436), "Ayruk.Erez@hotmail.com", "Saygılı Sokak 51a, Uşak, Malavi", "Karaca", "Süleymanoğlu", "+90-047-042-0-690", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9436), "f4ef6ba5-aa6e-4ae7-a45b-f4c32fe68eeb", "0", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9436) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Adana", "Guyana", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9529), "Bozan_Tugluk97@hotmail.com", "Atatürk Bulvarı 38a, Şırnak, Ukrayna", "Başbuğ", "Adan", "+90-905-985-4-611", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9530), "bfb7799c-39ca-4d76-af1b-184f49403ed9", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9530) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Zonguldak", "Mozambik", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9651), "Ediz93@hotmail.com", "Kerimoğlu Sokak 70b, Antalya, Amerikan Samoa", "Katunkız", "Eronat", "+90-493-348-3-762", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9652), "21922f42-c19b-46fb-b00b-4a214a7e3c00", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Manisa", "Namibia", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9772), "Inci_Bademci39@gmail.com", "İsmet Attila Caddesi 8, Siirt, İspanya", "Boyan", "Tüzün", "+90-679-422-7-624", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9773), "4cdc72fe-9fb6-40f6-821c-1c2bd9767162", "1", new DateTime(2025, 8, 18, 1, 42, 39, 893, DateTimeKind.Local).AddTicks(9773) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Burdur", "Yemen", new DateTime(2025, 8, 18, 1, 42, 39, 895, DateTimeKind.Local).AddTicks(265), "Buyruc_Akaydin0@yahoo.com", "Bayır Sokak 23a, Eskişehir, Tuvalu", "Barkdoğdu", "Aykaç", "+90-646-688-82-35", new DateTime(2025, 8, 18, 1, 42, 39, 895, DateTimeKind.Local).AddTicks(269), "7a8b37f4-7c3d-427f-adf3-b1674feadc19", new DateTime(2025, 8, 18, 1, 42, 39, 895, DateTimeKind.Local).AddTicks(269) });

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
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(3251), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(3254), 631.24m, new DateTime(2024, 9, 1, 16, 48, 54, 697, DateTimeKind.Local).AddTicks(2766), "Et excepturi sint repellat aliquam.", "Refined Steel Sausages", "713672bc-1df9-4ec8-8adb-99a3803da62a", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(3255) });

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
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(3870), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(3871), 369.26m, new DateTime(2025, 5, 1, 12, 0, 52, 615, DateTimeKind.Local).AddTicks(1957), "Quia qui et.", "Unbranded Rubber Bike", "259a85e8-2b52-4f25-be82-4ca090c7d262", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(3871) });

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
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 8, 5, 20, 51, 51, 182, DateTimeKind.Local).AddTicks(1573), new DateTime(2027, 6, 27, 16, 31, 0, 757, DateTimeKind.Local).AddTicks(9348), new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5708), 8, new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5708), "9e4d6c40-79e0-481d-8da1-7d32154171e4", 50, 2458.05m, new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5709) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 6, 19, 4, 40, 58, 272, DateTimeKind.Local).AddTicks(769), new DateTime(2026, 10, 16, 9, 44, 13, 88, DateTimeKind.Local).AddTicks(239), new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5724), 1, new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5725), "1fbf6c51-b605-445f-bc60-93590a235b38", 22, 2189.41m, new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 6, 8, 7, 3, 35, 269, DateTimeKind.Local).AddTicks(7316), new DateTime(2026, 10, 22, 17, 53, 31, 319, DateTimeKind.Local).AddTicks(4830), new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5739), 3, new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5739), "7dfe5685-1306-475b-af75-26b896be077e", 35, 2205.39m, new DateTime(2025, 8, 18, 1, 42, 39, 897, DateTimeKind.Local).AddTicks(5739) });

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
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7239), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7239), "4e99d3fa-a428-4bee-817e-aed1ebaa1204", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7244), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7244), "024a5365-fffe-4383-b549-7830ae1e6fbb", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7245) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7251), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7251), "23c131c7-8af6-4baa-9197-6d813a0f820c", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7251) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7257), 12, new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7257), "8de6bc8f-3106-49d1-ab07-b4d65e7d87ba", new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7257) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7262), 11, new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7262), "06c947f2-caf1-4c7a-85d5-bad2faf1581a", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7263) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "ShiftDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7269), 12, new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7269), "54b798de-e171-4438-ab36-f97f0bf5fdc0", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7269) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7273), 11, new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7274), "aa43a90b-ee23-4b66-8231-e4cd349b31e8", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7274) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7280), 11, new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7280), "e4242fb5-9713-4453-8f79-6cd04fae5417", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7284), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7284), "994e27d9-9e54-4e32-bf97-b61992402b1c", 1, new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7285) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7288), 12, new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7289), "65fbfefc-20b3-4e10-85e7-c3dc47418835", new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7293), 11, new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7293), "36ba67d2-6d78-4eb0-9687-4eb73811a352", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7294) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7300), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7300), "2787a0ac-3722-49a8-af76-f2cea75903f6", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7304), 12, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7304), "bbba5c13-cebb-423e-a61c-5f457cafaeb0", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7305) });

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
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7315), 11, new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7315), "0a0d02f2-be1c-44a1-b207-fa53c3533251", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7319), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7320), "2fdfb96d-e567-40aa-84d4-2c8a1f695826", 1, new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7324), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7325), "274d1c4d-3228-45cf-b63b-7e69929b3f8e", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7325) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7331), new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7331), "6bf014fb-de62-471f-a649-2988526655dc", new DateTime(2025, 8, 18, 1, 42, 39, 888, DateTimeKind.Local).AddTicks(7331) });
        }
    }
}

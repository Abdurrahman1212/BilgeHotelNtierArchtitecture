using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Init6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "East Nikita", "Iraq", new DateTime(2025, 8, 18, 1, 42, 14, 152, DateTimeKind.Local).AddTicks(3253), "81195 Sidney Turnpike, Tessiefurt, New Caledonia", "GL1004171212522142", "(615) 226-6688", "Dannie.Kuhic40@hotmail.com", new DateTime(2025, 8, 18, 1, 42, 14, 152, DateTimeKind.Local).AddTicks(3254), "Hyman", "Pacocha", "78182680-ef4d-45cb-85a6-d559220086d2", "86952", new DateTime(2025, 8, 18, 1, 42, 14, 152, DateTimeKind.Local).AddTicks(3254) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Samsun", "Guadalup, Fransa", new DateTime(2025, 8, 18, 1, 42, 14, 273, DateTimeKind.Local).AddTicks(2369), "Bekazil46@hotmail.com", "Harman Yolu Sokak  79, Kırşehir, Guyana", "Bastuğrul", "Sinanoğlu", "+90-332-041-69-60", new DateTime(2025, 8, 18, 1, 42, 14, 273, DateTimeKind.Local).AddTicks(2375), "832df453-ac47-4733-88be-c252508c6cf3", "1", new DateTime(2025, 8, 18, 1, 42, 14, 273, DateTimeKind.Local).AddTicks(2376) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "İzmir", "Mayotte, Fransa", new DateTime(2025, 8, 18, 1, 42, 14, 273, DateTimeKind.Local).AddTicks(3114), "Akata_Demirel60@yahoo.com", "Nalbant Sokak 06, Van, Lüksemburg", "Bönge", "Öymen", "+90-362-974-8-596", new DateTime(2025, 8, 18, 1, 42, 14, 273, DateTimeKind.Local).AddTicks(3115), "2a19bd9d-4f60-4305-9c25-c629aa0e00a2", "0", new DateTime(2025, 8, 18, 1, 42, 14, 273, DateTimeKind.Local).AddTicks(3116) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Muş", "Santa Lucia", new DateTime(2025, 8, 18, 1, 42, 14, 273, DateTimeKind.Local).AddTicks(4166), "Imrem_Akyuz3@yahoo.com", "Dağınık Evler Sokak 21b, Muğla, Kuzey İrlanda", "Ekim", "Erbay", "+90-570-408-05-75", new DateTime(2025, 8, 18, 1, 42, 14, 273, DateTimeKind.Local).AddTicks(4167), "57fa62f3-198f-44e3-af4e-30edb2d58dd1", "1", new DateTime(2025, 8, 18, 1, 42, 14, 273, DateTimeKind.Local).AddTicks(4168) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Iğdır", "Amerikan Samoa", new DateTime(2025, 8, 18, 1, 42, 14, 273, DateTimeKind.Local).AddTicks(5121), "Kimizalmila_Keseroglu20@yahoo.com", "Mevlana Sokak 87c, Batman, Lübnan", "Anıl", "Hamzaoğlu", "+90-639-669-4-950", new DateTime(2025, 8, 18, 1, 42, 14, 273, DateTimeKind.Local).AddTicks(5122), "38669837-5d35-4ece-99b2-89d3ed36ea83", new DateTime(2025, 8, 18, 1, 42, 14, 273, DateTimeKind.Local).AddTicks(5122) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Batman", "Katar", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(1526), "Aldogan27@hotmail.com", "Bayır Sokak 2, Adana, Ekvator", "Belek", "Hamzaoğlu", "+90-366-022-9-674", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(1539), "020aaeab-bdce-4fdf-849d-ab113ec2cf7e", "0", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(1541) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Batman", "Dominik Cumhuriyeti", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(7078), "Aybalta0@yahoo.com", "Mevlana Sokak 12, Çorum, Andorra", "Bağaturipi", "Duygulu", "+90-688-031-97-10", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(7079), "bd8063c3-0a66-4417-964f-b2207fa4a56f", new DateTime(2025, 8, 18, 1, 42, 14, 278, DateTimeKind.Local).AddTicks(7080) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Manisa", "İsveç", new DateTime(2025, 8, 18, 1, 42, 14, 282, DateTimeKind.Local).AddTicks(9365), "Arslantegin.Alpugan88@gmail.com", "Bahçe Sokak 498, Aydın, Fransa", "Ayruk", "Samancı", "+90-984-120-8-346", new DateTime(2025, 8, 18, 1, 42, 14, 282, DateTimeKind.Local).AddTicks(9367), "5f9af7fb-60e8-4c04-a650-dfa837118709", new DateTime(2025, 8, 18, 1, 42, 14, 282, DateTimeKind.Local).AddTicks(9368) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Muş", "Tayvan", new DateTime(2025, 8, 18, 1, 42, 14, 282, DateTimeKind.Local).AddTicks(9856), "Buzactutuk_Ozdenak2@hotmail.com", "Köypınar Sokak 10c, Nevşehir, Mozambik", "Avşar", "Durak ", "+90-297-615-63-68", new DateTime(2025, 8, 18, 1, 42, 14, 282, DateTimeKind.Local).AddTicks(9857), "e47d193c-1d77-45cb-9a56-ee1e3b7855c8", "0", new DateTime(2025, 8, 18, 1, 42, 14, 282, DateTimeKind.Local).AddTicks(9858) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Tokat", "Ukrayna", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(264), "Ceykun.Kocabiyik56@hotmail.com", "Mevlana Sokak 34a, Nevşehir, Cape Verde", "Bıtaybıkı", "Özdoğan", "+90-375-368-5-179", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(265), "e46713d5-da0b-4b23-b68e-307b5d3d4e4b", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Ağrı", "Uganda", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(648), "Asantugrul_Evliyaoglu@gmail.com", "İsmet Paşa Caddesi 00, Uşak, Sudan", "Gökçiçek", "Ertepınar", "+90-128-060-99-11", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(649), "0d70499c-e3da-4478-aa41-cb8905810dcf", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(650) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Antalya", "Makau (Makao)", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(1021), "Adik.Sadiklar@hotmail.com", "İsmet Attila Caddesi 54b, Afyon, Midway Adaları, Amerika", "Azıl", "Adan", "+90-216-969-90-65", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(1022), "c1171fd6-96c5-4359-b1bb-58d0b54a0556", "0", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(1023) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Isparta", "İspanya", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(1780), "Arikdoruk_Pektemek26@hotmail.com", "Ülkü Sokak 288, Burdur, Antigua ve Barbuda", "Batuk", "Sepetçi", "+90-975-369-75-14", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(1781), "3bf69434-7446-4b69-bc02-2beea2d94c83", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(1782) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Kocaeli", "Peru", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(2151), "Askin.Cevik36@gmail.com", "Gül Sokak 68c, Artvin, Antigua ve Barbuda", "Eğrim", "Karadaş", "+90-835-612-92-98", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(2152), "cac87122-2d0f-4b1b-b6f2-aa8d834bf8ad", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(2153) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Düzce", "Cibuti", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(2844), "Ardic86@gmail.com", "Harman Altı Sokak 52a, Burdur, Grenada", "Artuk", "Abacı", "+90-231-140-84-87", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(2849), "b85ee7d8-e179-4afe-89ea-a9d7b1d80889", "1", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Isparta", "Kuveyt", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(3229), "Adberilgen_Tahincioglu8@yahoo.com", "Gül Sokak 22c, Kırıkkale, Küba", "Egemen", "Mertoğlu", "+90-419-234-66-94", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(3231), "d40cc4cb-9e3d-4680-89a3-3785594bac2e", "0", new DateTime(2025, 8, 18, 1, 42, 14, 283, DateTimeKind.Local).AddTicks(3231) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Bayburt", "Amerika Birleşik Devletleri", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(6522), "Buyruk_Aydan88@hotmail.com", "Sarıkaya Caddesi 21b, Bursa, Amerikan Samoa", "Atılgan", "Erez", "+90-231-739-34-11", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(6522), "0d4c82c1-c497-4f94-8979-01b35a6b9161", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(6523) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Zonguldak", "Montserrat", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(7213), "Cagribeg_Ilicali54@yahoo.com", "Sıran Söğüt Sokak 951, Tokat, Azerbaycan", "Aydoğan", "Limoncuoğlu", "+90-218-097-7-092", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(7214), "7d84c34a-4c7c-4682-9de5-53c39d1306cc", "0", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(7215) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Balıkesir", "Suudi Arabistan", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(8269), "Bumin_Tuzun45@yahoo.com", "Sağlık Sokak 54b, Malatya, Karadağ", "Balakatay", "Atan", "+90-778-616-08-22", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(8270), "4a94ff18-e991-46e5-a209-ab7b11a46fb6", "1", new DateTime(2025, 8, 18, 1, 42, 14, 287, DateTimeKind.Local).AddTicks(8271) });

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
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 267, DateTimeKind.Local).AddTicks(6460), new DateTime(2025, 8, 18, 1, 42, 14, 267, DateTimeKind.Local).AddTicks(6460), 564.01m, new DateTime(2025, 3, 25, 21, 40, 44, 749, DateTimeKind.Local).AddTicks(9693), "İd debitis nihil quis.", "Generic Fresh Tuna", "17d4d442-e12c-4bb7-b02f-afc75a0b2013", new DateTime(2025, 8, 18, 1, 42, 14, 267, DateTimeKind.Local).AddTicks(6461) });

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
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 267, DateTimeKind.Local).AddTicks(6773), new DateTime(2025, 8, 18, 1, 42, 14, 267, DateTimeKind.Local).AddTicks(6774), 592.09m, new DateTime(2025, 8, 17, 15, 59, 42, 353, DateTimeKind.Local).AddTicks(4344), "İd rem qui et dolorum.", "Sleek Cotton Shoes", "9b382480-3f79-4f2b-a32a-615ee914f841", new DateTime(2025, 8, 18, 1, 42, 14, 267, DateTimeKind.Local).AddTicks(6774) });

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
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 9, 38, 26, 290, DateTimeKind.Local).AddTicks(2314), new DateTime(2027, 3, 15, 23, 2, 38, 602, DateTimeKind.Local).AddTicks(569), new DateTime(2025, 8, 18, 1, 42, 14, 300, DateTimeKind.Local).AddTicks(9928), 8, new DateTime(2025, 8, 18, 1, 42, 14, 300, DateTimeKind.Local).AddTicks(9929), "0fd17a97-c608-4e24-a1c9-6a322dd99397", 37, 1959.00m, new DateTime(2025, 8, 18, 1, 42, 14, 300, DateTimeKind.Local).AddTicks(9929) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 5, 6, 42, 9, 256, DateTimeKind.Local).AddTicks(7119), new DateTime(2025, 10, 27, 19, 44, 28, 543, DateTimeKind.Local).AddTicks(7204), new DateTime(2025, 8, 18, 1, 42, 14, 300, DateTimeKind.Local).AddTicks(9963), 1, new DateTime(2025, 8, 18, 1, 42, 14, 300, DateTimeKind.Local).AddTicks(9963), "39850a76-c302-48f5-afb5-a8f48c3d1806", 25, 1955.29m, new DateTime(2025, 8, 18, 1, 42, 14, 300, DateTimeKind.Local).AddTicks(9964) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 11, 12, 13, 29, 48, 337, DateTimeKind.Local).AddTicks(2896), new DateTime(2026, 8, 12, 23, 28, 37, 729, DateTimeKind.Local).AddTicks(3102), new DateTime(2025, 8, 18, 1, 42, 14, 300, DateTimeKind.Local).AddTicks(9997), 3, new DateTime(2025, 8, 18, 1, 42, 14, 300, DateTimeKind.Local).AddTicks(9998), "66fd9193-2270-4cc3-bda1-39b5889f3045", 9, 1827.43m, new DateTime(2025, 8, 18, 1, 42, 14, 300, DateTimeKind.Local).AddTicks(9998) });

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
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3837), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3838), "0a05edbb-50f5-487e-9823-e78734440b12", 1, new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3838) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3913), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3914), "e975cea6-ce43-4c79-a542-8c94f3adb078", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3914) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3923), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3924), "f04dbb89-dd15-49b7-9f5d-b93ca50b2081", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3924) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3934), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3935), "b156ba68-542f-470e-a02c-c2c3910eeabf", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3935) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3949), 12, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3950), "7fa1fc29-d128-4571-b2ce-f2f3537caf68", 1, new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3950) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "ShiftDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3960), 11, new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3960), "9adc750f-5d27-4ae2-802b-ff2061e23392", new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3961) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3973), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3974), "508f4242-c064-42d2-bf53-9af1506a57fb", 2, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3974) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3986), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3986), "b2654a6a-3a12-4e6a-9085-f9bbdc4df44b", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3987) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3995), 11, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3996), "3069ccdf-768f-4d0a-b5d5-fc4baab612a9", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(3996) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(4008), 12, new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(4009), "7b87908f-2cdd-4f5e-bba6-da3a05fbe296", new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(4009) });

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
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(4037), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(4038), "cc6e01a5-2600-4d37-9462-14a4e8a5a773", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "ShiftDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(4051), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(4051), "b46f66c5-4f79-4d1a-a83b-aca588b3d5cb", new DateTime(2025, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 18, 1, 42, 14, 268, DateTimeKind.Local).AddTicks(4052) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "North Darrenfurt", "Anguilla", new DateTime(2025, 8, 18, 1, 38, 42, 454, DateTimeKind.Local).AddTicks(9588), "604 Kertzmann Underpass, East Rachelview, Marshall Islands", "8", "IE70636882003940050047", "813.598.8266 x220", "Yessenia_Torphy@yahoo.com", new DateTime(2025, 8, 18, 1, 38, 42, 454, DateTimeKind.Local).AddTicks(9588), "Florida", "Maggio", "89a42027-6be0-459f-942a-a972aff6e3b7", "80691", new DateTime(2025, 8, 18, 1, 38, 42, 454, DateTimeKind.Local).AddTicks(9589) });

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
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "West Kallie", "Mauritania", new DateTime(2025, 8, 18, 1, 38, 42, 455, DateTimeKind.Local).AddTicks(628), "1476 Miles Ramp, Lake Jaronburgh, Timor-Leste", "KW45PTYS9S50344605B53T230H1397", "344.645.8606 x955", "Joan_Zboncak@gmail.com", new DateTime(2025, 8, 18, 1, 38, 42, 455, DateTimeKind.Local).AddTicks(628), "Ulices", "Davis", "e10d9471-277b-4c90-ba3f-85d31ee84cf5", "60454", new DateTime(2025, 8, 18, 1, 38, 42, 455, DateTimeKind.Local).AddTicks(629) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Muş", "Montserrat", new DateTime(2025, 8, 18, 1, 38, 42, 636, DateTimeKind.Local).AddTicks(7192), "Baykoca.Paksut@gmail.com", "Harman Altı Sokak 07, Diyarbakır, Yeni Kaledonya, Fransa", "Bayankağan", "Küçükler", "+90-469-205-6-402", new DateTime(2025, 8, 18, 1, 38, 42, 636, DateTimeKind.Local).AddTicks(7197), "ba8b25fd-c97f-4436-bb3b-76ed72c788f6", "0", new DateTime(2025, 8, 18, 1, 38, 42, 636, DateTimeKind.Local).AddTicks(7197) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Isparta", "Svaziland", new DateTime(2025, 8, 18, 1, 38, 42, 636, DateTimeKind.Local).AddTicks(8366), "Araboga.Kuday63@gmail.com", "Kocatepe Caddesi 82b, Giresun, Katar", "Erinç", "Dağdaş", "+90-596-578-71-13", new DateTime(2025, 8, 18, 1, 38, 42, 636, DateTimeKind.Local).AddTicks(8366), "a48c15e0-a6e9-40eb-bad5-fd81f57d733b", "0", new DateTime(2025, 8, 18, 1, 38, 42, 636, DateTimeKind.Local).AddTicks(8367) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Manisa", "Kosova", new DateTime(2025, 8, 18, 1, 38, 42, 636, DateTimeKind.Local).AddTicks(9107), "Akin52@gmail.com", "Ergenekon Sokak   489, Erzurum, Galler", "Altan", "Günday", "+90-666-387-0-955", new DateTime(2025, 8, 18, 1, 38, 42, 636, DateTimeKind.Local).AddTicks(9108), "02f38f70-6182-4a0a-bee3-747ecc51d73e", "0", new DateTime(2025, 8, 18, 1, 38, 42, 636, DateTimeKind.Local).AddTicks(9108) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Bilecik", "Midway Adaları, Amerika", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(666), "Caglayan.Akbulut58@hotmail.com", "Ali Çetinkaya Caddesi 83, Elazığ, Makau (Makao)", "Baydemir", "Adıvar", "+90-426-106-2-308", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(667), "6c98fddc-46f5-4b6d-a2e2-35a04c29d6f7", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(667) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Rize", "San Marino", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(973), "Bilgeciksin_Catalbas@gmail.com", "Okul Sokak 40, Burdur, Saint Helena, İngiltere", "Aykağan", "Çetin", "+90-899-218-2-097", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(973), "75033240-164c-4f4c-883c-de7969b1514b", "1", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(974) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Kütahya", "Ürdün", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(1313), "Bozkus55@hotmail.com", "Yunus Emre Sokak 17a, Malatya, Antigua ve Barbuda", "Bilgetardu", "Mertoğlu", "+90-461-092-05-84", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(1314), "175bc9f0-b529-40f9-81ee-225cee9393cb", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(1314) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Burdur", "Grenada", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(1591), "Cokramayul.Erbay68@gmail.com", "Harman Yolu Sokak  05b, Aydın, Türkiye", "Berendey", "Tokgöz", "+90-891-483-2-384", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(1591), "98b292dd-50b7-4e2a-acf4-9b6ba38985db", "1", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(1592) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Bartın", "Honduras", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(2212), "Balaka63@gmail.com", "Sarıkaya Caddesi 90c, Iğdır, Polonya", "Basar", "Çamdalı", "+90-675-089-06-45", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(2213), "31c00037-d53d-4eb4-9b92-922633402b14", "0", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(2213) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Antalya", "Komorlar", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(2754), "Ikicitoyun.Alniacik79@hotmail.com", "Güven Yaka Sokak 76, Sivas, Portekiz", "Alpilig", "Kılıççı", "+90-399-373-19-65", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(2754), "154e79d6-3ddc-4f74-9b5d-783532db586d", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Rize", "Ermenistan", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(2973), "Bacman.Asikoglu@hotmail.com", "Sıran Söğüt Sokak 60, Niğde, Saint Helena, İngiltere", "Baltur", "Okur", "+90-679-253-52-63", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(2973), "7a339b27-dc00-43c3-b41a-57d170c4f1b9", new DateTime(2025, 8, 18, 1, 38, 42, 639, DateTimeKind.Local).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Afyon", "Cebelitarık, İngiltere", new DateTime(2025, 8, 18, 1, 38, 42, 641, DateTimeKind.Local).AddTicks(7137), "Asantugrul.Erez@hotmail.com", "Sağlık Sokak 20a, Balıkesir, Namibia", "Beğboğa", "Erkekli", "+90-639-863-83-45", new DateTime(2025, 8, 18, 1, 38, 42, 641, DateTimeKind.Local).AddTicks(7145), "0e0ce23f-771e-4114-9a17-13c2cd586932", "0", new DateTime(2025, 8, 18, 1, 38, 42, 641, DateTimeKind.Local).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Aydın", "Bangladeş", new DateTime(2025, 8, 18, 1, 38, 42, 641, DateTimeKind.Local).AddTicks(8272), "Akata.Keseroglu@yahoo.com", "Kerimoğlu Sokak 21c, Kayseri, İsrail", "Çocukbörü", "Örge", "+90-403-490-4-253", new DateTime(2025, 8, 18, 1, 38, 42, 641, DateTimeKind.Local).AddTicks(8273), "0655bd03-8a38-416e-89ce-d902add577b8", new DateTime(2025, 8, 18, 1, 38, 42, 641, DateTimeKind.Local).AddTicks(8274) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Iğdır", "Fiji", new DateTime(2025, 8, 18, 1, 38, 42, 641, DateTimeKind.Local).AddTicks(8602), "Azganaz.Karaer27@hotmail.com", "Ülkü Sokak 956, Şırnak, Turks ve Caicos Adaları, İngiltere", "Belgüc", "Abadan", "+90-890-121-45-10", new DateTime(2025, 8, 18, 1, 38, 42, 641, DateTimeKind.Local).AddTicks(8603), "f01de683-f2c1-4419-ab93-c63c6508da90", "1", new DateTime(2025, 8, 18, 1, 38, 42, 641, DateTimeKind.Local).AddTicks(8603) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Gaziantep", "Yeni Kaledonya, Fransa", new DateTime(2025, 8, 18, 1, 38, 42, 641, DateTimeKind.Local).AddTicks(9067), "Altintamgantarkan.Adan27@yahoo.com", "Harman Yolu Sokak  599, Bartın, Jamaika", "Bozok", "Aybar", "+90-270-942-48-82", new DateTime(2025, 8, 18, 1, 38, 42, 641, DateTimeKind.Local).AddTicks(9070), "f9f2d8d4-fbb1-4749-a67f-9c7efba0da79", new DateTime(2025, 8, 18, 1, 38, 42, 641, DateTimeKind.Local).AddTicks(9071) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Bingöl", "Kosta Rika", new DateTime(2025, 8, 18, 1, 38, 42, 641, DateTimeKind.Local).AddTicks(9797), "Irmak.Mertoglu@hotmail.com", "İsmet Attila Caddesi 220, Hakkari, Gine", "Alkış", "Kavaklıoğlu", "+90-196-416-84-80", new DateTime(2025, 8, 18, 1, 38, 42, 641, DateTimeKind.Local).AddTicks(9798), "6a27cbb8-0be2-462e-acbb-60b437caa651", "1", new DateTime(2025, 8, 18, 1, 38, 42, 641, DateTimeKind.Local).AddTicks(9799) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Bingöl", "Paraguay", new DateTime(2025, 8, 18, 1, 38, 42, 642, DateTimeKind.Local).AddTicks(654), "Isilay.Aksit22@hotmail.com", "İbn-i Sina Sokak 08c, Van, Güney Georgia ve Güney Sandviç Adaları, İngiltere", "Alakurt", "Ilıcalı", "+90-780-327-61-57", new DateTime(2025, 8, 18, 1, 38, 42, 642, DateTimeKind.Local).AddTicks(655), "5c9482cc-8f68-4df8-8f4b-d4be90e38c26", new DateTime(2025, 8, 18, 1, 38, 42, 642, DateTimeKind.Local).AddTicks(656) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Çankırı", "Kosova", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(659), "Avsar_Adal@gmail.com", "Mevlana Sokak 05a, Bingöl, Cibuti", "Börübars", "Velioğlu", "+90-183-862-8-702", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(668), "dc3f2168-5900-4e65-9b45-09764cf55d15", "0", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(669) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Bilecik", "Beyaz Rusya", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(2073), "Gokcen36@hotmail.com", "Okul Sokak 07, Şanlıurfa, Güney Georgia ve Güney Sandviç Adaları, İngiltere", "Akaş", "Türkyılmaz", "+90-069-319-30-35", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(2075), "7a5a7106-9ffa-460e-aa19-a25a4f6abf73", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(2076) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Bitlis", "Aruba, Hollanda", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(3062), "Buzactutuk54@gmail.com", "Güven Yaka Sokak 5, Yalova, İran", "Ağalak", "Hakyemez", "+90-409-011-6-305", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(3063), "e21f7965-03a5-49ec-bfc5-c6d3b6d733f1", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(3064) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Bolu", "Yeni Kaledonya, Fransa", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(4753), "Itil_Kavaklioglu70@gmail.com", "Gül Sokak 91a, Uşak, Christmas Adası , Avusturalya", "Bilgiç", "Tazegül", "+90-103-032-2-828", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(4754), "718e5ce3-04c8-456c-9891-a5ffc92ad00b", "1", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(4755) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Kocaeli", "Hindistan", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(5042), "Colman_Akyurek@hotmail.com", "Kekeçoğlu Sokak 414, Elazığ, Sırbistan", "Arbay", "Adal", "+90-211-290-2-967", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(5043), "7fde8bfa-48d7-469f-ad4f-e1c00ed7641e", "0", new DateTime(2025, 8, 18, 1, 38, 42, 644, DateTimeKind.Local).AddTicks(5043) });

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
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 632, DateTimeKind.Local).AddTicks(8813), new DateTime(2025, 8, 18, 1, 38, 42, 632, DateTimeKind.Local).AddTicks(8814), 481.19m, new DateTime(2025, 6, 18, 21, 23, 34, 194, DateTimeKind.Local).AddTicks(244), "Tenetur facilis voluptas at omnis consequuntur incidunt rem enim earum.", "Rustic Rubber Salad", "0b194cbb-0d34-4b36-a70f-1a5fd63a36f3", 5, new DateTime(2025, 8, 18, 1, 38, 42, 632, DateTimeKind.Local).AddTicks(8816) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 632, DateTimeKind.Local).AddTicks(8986), new DateTime(2025, 8, 18, 1, 38, 42, 632, DateTimeKind.Local).AddTicks(8987), 882.78m, new DateTime(2025, 7, 20, 2, 35, 14, 839, DateTimeKind.Local).AddTicks(5056), "İpsa rerum est voluptatem et.", "Licensed Wooden Chair", "948ab479-26de-4e2c-80a3-3de862326b33", new DateTime(2025, 8, 18, 1, 38, 42, 632, DateTimeKind.Local).AddTicks(8988) });

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
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 632, DateTimeKind.Local).AddTicks(9582), new DateTime(2025, 8, 18, 1, 38, 42, 632, DateTimeKind.Local).AddTicks(9583), 136.70m, new DateTime(2024, 10, 16, 8, 20, 41, 583, DateTimeKind.Local).AddTicks(9234), "Porro praesentium assumenda.", "Refined Frozen Shoes", "1354777d-6c41-42a3-99fc-56e4f2adaadf", new DateTime(2025, 8, 18, 1, 38, 42, 632, DateTimeKind.Local).AddTicks(9584) });

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
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 8, 18, 13, 18, 341, DateTimeKind.Local).AddTicks(8661), new DateTime(2026, 11, 4, 19, 45, 2, 948, DateTimeKind.Local).AddTicks(5780), new DateTime(2025, 8, 18, 1, 38, 42, 652, DateTimeKind.Local).AddTicks(8620), 2, new DateTime(2025, 8, 18, 1, 38, 42, 652, DateTimeKind.Local).AddTicks(8620), "0346f085-5438-4734-9f89-06c4993b183e", 11, 2002.38m, new DateTime(2025, 8, 18, 1, 38, 42, 652, DateTimeKind.Local).AddTicks(8621) });

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
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3247), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3247), "7514ee98-eb0a-434f-a4a2-ba87c73d5b84", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3247) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3253), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3253), "d360857b-b310-41f7-bb67-892a15ce60ec", new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3254) });

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
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3268), 11, new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3269), "db20f62b-0075-42a3-8b46-83fc0866e1d7", 2, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "ShiftDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3304), 12, new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3305), "7058b6a4-5e33-484b-812c-92383b6815c5", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3305) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3311), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3311), "1a542680-1145-4455-adbb-ed4aa8184212", 1, new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3312) });

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
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "ShiftDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3343), 12, new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3344), "0da66123-2b44-4c31-ab1a-4d53129a9367", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3357), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3358), "ec348c17-4625-44e8-b37a-cce48809f6d7", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3358) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "ShiftDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3367), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3367), "7f397c13-8e3f-4d84-ae80-5c0405a5f2ec", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3368) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3376), 12, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3376), "cc472eb3-550f-4589-b1cf-9f5a0ab8380c", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 38, 42, 634, DateTimeKind.Local).AddTicks(3376) });

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
    }
}

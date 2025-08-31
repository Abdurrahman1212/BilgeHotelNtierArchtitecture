using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Rennerburgh", "Mayotte", new DateTime(2025, 8, 10, 22, 38, 24, 303, DateTimeKind.Local).AddTicks(4127), "359 Kohler Place, Lake Callieburgh, Singapore", "8", "FR078110200285840442EW90257", "453.615.4108", "Alberto55@hotmail.com", new DateTime(2025, 8, 10, 22, 38, 24, 303, DateTimeKind.Local).AddTicks(4142), "Jeromy", "Hane", "f8905259-3b2c-4445-8c79-ab5ce4d63a5d", "50373-9412", new DateTime(2025, 8, 10, 22, 38, 24, 303, DateTimeKind.Local).AddTicks(4143) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Lake Itzelview", "Liechtenstein", new DateTime(2025, 8, 10, 22, 38, 24, 303, DateTimeKind.Local).AddTicks(5438), "186 Keven Extension, Quigleyhaven, Netherlands", "1", "XK210413173008004975", "254-888-7522", "Kiera45@yahoo.com", new DateTime(2025, 8, 10, 22, 38, 24, 303, DateTimeKind.Local).AddTicks(5442), "Geovany", "Hagenes", "1c0c3822-871d-485b-9bfc-a533267ba7bf", "06670", new DateTime(2025, 8, 10, 22, 38, 24, 303, DateTimeKind.Local).AddTicks(5443) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "New Nicolette", "Botswana", new DateTime(2025, 8, 10, 22, 38, 24, 303, DateTimeKind.Local).AddTicks(5936), "732 Candelario Mission, Lake Ashleigh, Lebanon", "5", "CY939002681838439108L3603332", "833.234.9817 x982", "Ernie.Mosciski48@hotmail.com", new DateTime(2025, 8, 10, 22, 38, 24, 303, DateTimeKind.Local).AddTicks(5938), "Julianne", "Mayer", "e59f327d-11ba-49b2-b42e-800012828cc7", "92750-0683", new DateTime(2025, 8, 10, 22, 38, 24, 303, DateTimeKind.Local).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Port Jacintostad", "Lesotho", new DateTime(2025, 8, 10, 22, 38, 24, 303, DateTimeKind.Local).AddTicks(6404), "1546 Schimmel Estates, Ignatiusview, Martinique", "8", "PT90519087494900401500938", "1-607-547-2120", "Rodrick_Rodriguez74@hotmail.com", new DateTime(2025, 8, 10, 22, 38, 24, 303, DateTimeKind.Local).AddTicks(6406), "Demetrius", "Macejkovic", "85529c76-4a28-4c90-a8bb-0d291cf8dc60", "95304-2399", new DateTime(2025, 8, 10, 22, 38, 24, 303, DateTimeKind.Local).AddTicks(6407) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "North Montana", "Dominican Republic", new DateTime(2025, 8, 10, 22, 38, 24, 303, DateTimeKind.Local).AddTicks(6885), "4884 Koch Mount, Windlerstad, Uruguay", "5", "SA390754110Q03DL091M2634", "(416) 517-3118 x42522", "Alexandrea_Carter32@gmail.com", new DateTime(2025, 8, 10, 22, 38, 24, 303, DateTimeKind.Local).AddTicks(6887), "Zoie", "Frami", "3f0c2ff8-2c7e-4882-b6a3-7d8e8bb0379f", "86267-5627", new DateTime(2025, 8, 10, 22, 38, 24, 303, DateTimeKind.Local).AddTicks(6887) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "North Leoraborough", "Cayman Islands", new DateTime(2025, 8, 10, 22, 38, 24, 303, DateTimeKind.Local).AddTicks(7372), "5233 Koelpin Overpass, East Mack, Australia", "5", "HR3783350070075043026", "(390) 257-5208 x01104", "Denis34@yahoo.com", new DateTime(2025, 8, 10, 22, 38, 24, 303, DateTimeKind.Local).AddTicks(7374), "Clifton", "Wyman", "3abc64a5-f0ea-4973-be7d-333f98438a4f", "25361-5424", new DateTime(2025, 8, 10, 22, 38, 24, 303, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Beckermouth", "Gabon", new DateTime(2025, 8, 10, 22, 38, 24, 303, DateTimeKind.Local).AddTicks(7827), "157 Willms Skyway, New Davonte, Finland", "4", "ES7576303654090398070670", "967.751.4753 x055", "Yasmeen_Hahn@hotmail.com", new DateTime(2025, 8, 10, 22, 38, 24, 303, DateTimeKind.Local).AddTicks(7829), "Raphael", "Herzog", "4ec83813-9567-451d-9587-b806daf4acee", "39959", new DateTime(2025, 8, 10, 22, 38, 24, 303, DateTimeKind.Local).AddTicks(7830) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "North Royal", "Democratic People's Republic of Korea", new DateTime(2025, 8, 10, 22, 38, 24, 303, DateTimeKind.Local).AddTicks(8248), "42281 Lueilwitz Via, West Myrtlefurt, Anguilla", "10", "PT75501058578309359079114", "378-461-6531 x664", "Olga48@yahoo.com", new DateTime(2025, 8, 10, 22, 38, 24, 303, DateTimeKind.Local).AddTicks(8250), "Vada", "Cronin", "9bb023a4-e81a-4d5d-aeb8-08f3d296598f", "10326-7960", new DateTime(2025, 8, 10, 22, 38, 24, 303, DateTimeKind.Local).AddTicks(8251) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "West Ivorymouth", "Puerto Rico", new DateTime(2025, 8, 10, 22, 38, 24, 303, DateTimeKind.Local).AddTicks(8626), "7237 Mohr Highway, Mayertown, Niue", "2", "AL2437366005A535S1897MM42503", "339-623-7073 x51731", "Beatrice_Bergstrom@yahoo.com", new DateTime(2025, 8, 10, 22, 38, 24, 303, DateTimeKind.Local).AddTicks(8628), "Leta", "Morissette", "c95937b0-1590-48bf-8ef2-27a7f946705d", "96453-6350", new DateTime(2025, 8, 10, 22, 38, 24, 303, DateTimeKind.Local).AddTicks(8629) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Bayermouth", "Syrian Arab Republic", new DateTime(2025, 8, 10, 22, 38, 24, 303, DateTimeKind.Local).AddTicks(9166), "586 Dedric Village, East Dudleyville, Italy", "11", "LT433036820300230095", "1-349-552-5448 x9811", "Jacky.Abbott@yahoo.com", new DateTime(2025, 8, 10, 22, 38, 24, 303, DateTimeKind.Local).AddTicks(9169), "Aiden", "Schinner", "3ba44b7e-6f2e-483a-b869-744603a75062", "55441", new DateTime(2025, 8, 10, 22, 38, 24, 303, DateTimeKind.Local).AddTicks(9169) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Nevşehir", "Brunei", new DateTime(2025, 8, 10, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(38), "Astalogul_Erbulak@yahoo.com", "Harman Yolu Sokak  8, Hatay, Amerikan Samoa", "Bayur", "Kıraç ", "+90-320-722-5-989", new DateTime(2025, 8, 10, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(42), "168c030d-a549-4cbc-96c9-53bcd1b5e73a", "0", new DateTime(2025, 8, 10, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(42) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Afyon", "Johnston Atoll, Amerika", new DateTime(2025, 8, 10, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(970), "Azak.Koyuncu17@hotmail.com", "Ergenekon Sokak   6, Bitlis, Polonya", "Çağru", "Özkök ", "+90-874-022-7-111", new DateTime(2025, 8, 10, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(971), "83ec69a4-b38c-44f7-b440-3c97de2308b5", "1", new DateTime(2025, 8, 10, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Bolu", "Aruba, Hollanda", new DateTime(2025, 8, 10, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(1139), "Bukaktutuk_Gumuspala12@hotmail.com", "Tevfik Fikret Caddesi 0, Zonguldak, Grönland", "Büktegin", "Limoncuoğlu", "+90-753-584-0-947", new DateTime(2025, 8, 10, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(1139), "753add87-ee98-4e9a-b89b-fee7a6d71476", new DateTime(2025, 8, 10, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Balıkesir", "Benin", new DateTime(2025, 8, 10, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(1283), "Alpis.Erkekli@hotmail.com", "Saygılı Sokak 25c, Düzce, Letonya", "Esin", "Önür", "+90-216-919-0-426", new DateTime(2025, 8, 10, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(1284), "1c9ae8d0-4258-4dde-aaed-378394901775", "0", new DateTime(2025, 8, 10, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(1284) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Çorum", "Cebelitarık, İngiltere", new DateTime(2025, 8, 10, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(1400), "Aladag_Menemencioglu@yahoo.com", "Nalbant Sokak 25c, Mardin, İrlanda", "Barmaklak", "Akşit", "+90-014-871-10-54", new DateTime(2025, 8, 10, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(1400), "feb72734-773b-47ea-af03-a8d5a5aa9050", new DateTime(2025, 8, 10, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(1401) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Iğdır", "Papua Yeni Gine", new DateTime(2025, 8, 10, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(1618), "Alpdogan.Limoncuoglu9@gmail.com", "Kerimoğlu Sokak 62, Karaman, Kosova", "Buçan", "Kutlay", "+90-819-996-1-210", new DateTime(2025, 8, 10, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(1619), "ca715eeb-1106-48f6-9ae6-356cebe4eb98", "1", new DateTime(2025, 8, 10, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Kilis", "Burundi", new DateTime(2025, 8, 10, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(1773), "Bakagul_Yetkiner36@hotmail.com", "Fatih Sokak  07a, Kırıkkale, Liberya", "Ay", "Balcı", "+90-024-153-58-40", new DateTime(2025, 8, 10, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(1773), "9798942d-85a2-4327-a96d-0e8b4447eae7", new DateTime(2025, 8, 10, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(1773) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Erzurum", "Çek Cumhuriyeti", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(4060), "Barlas.Agaoglu@yahoo.com", "Güven Yaka Sokak 62b, Afyon, Reunion, Fransa", "Atıgay", "Sarıoğlu", "+90-091-489-16-37", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(4107), "996fd882-bc54-4b7f-a112-6502223899cb", "1", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(4109) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Kırıkkale", "Virgin Adaları, Amerika", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(4879), "Ay.Kaplangi27@yahoo.com", "Kerimoğlu Sokak 035, Erzurum, Vanuatu", "Beğbars", "Karadaş", "+90-775-401-89-22", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(4879), "68fe72b5-ee9e-4aec-894c-698423fea415", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(4880) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Afyon", "Porto Riko, Amerika", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5030), "Buktegin_Erginsoy@gmail.com", "Oğuzhan Sokak 640, Isparta, Hollanda Antilleri", "Bakağul", "Aydan", "+90-415-105-69-46", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5030), "750a1ec0-9d32-41d4-9220-893204944bdf", "1", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "İçel (Mersin)", "Botswana", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5157), "Ikicitoyun.Elmastasoglu@gmail.com", "Okul Sokak 07a, Manisa, Hollanda Antilleri", "Barkdurmuş", "Koçoğlu", "+90-828-375-83-54", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5158), "f4782128-8af1-4739-b0fe-e2d4fbc7b04b", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5158) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Çorum", "Birleşik Arap Emirlikleri", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5291), "Bidin40@hotmail.com", "Sevgi Sokak 71a, Isparta, Cezayir", "Ağakağan", "Yetkiner", "+90-888-674-4-260", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5292), "7fc3a774-9e88-4f74-ab89-c0c5d4bd475f", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5292) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Tekirdağ", "Kenya", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5418), "Agabay.Akaydin85@yahoo.com", "İsmet Paşa Caddesi 24b, Sivas, Guatemala", "Altankan", "Karadaş", "+90-027-372-4-534", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5419), "da657e44-89e2-4c41-9063-470507a85736", "0", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5419) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Adana", "Guam, Amerika", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5536), "Azgan_Yesilkaya82@gmail.com", "Oğuzhan Sokak 408, Hakkari, Sudan", "Barkdoğdu", "Kocabıyık", "+90-864-284-2-109", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5537), "1085964c-e85a-4179-9fcc-3ea19de1d820", "0", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5537) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Bursa", "Bahama Adaları", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5652), "Esen_Yesilkaya97@yahoo.com", "Güven Yaka Sokak 7, Sivas, Ekvator", "Baksı", "Adal", "+90-174-455-89-79", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5653), "581b6702-b1f9-4b4a-8996-70a8d397e8f3", "0", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5653) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "İçel (Mersin)", "Monako", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5756), "Belgi.Erturk68@yahoo.com", "Okul Sokak 6, Osmaniye, Amerikan Samoa", "Ekin", "Evliyaoğlu", "+90-434-055-80-23", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5756), "6398fb0b-e6dc-4411-8e83-28bfd9e7bd2c", "1", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5756) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Hatay", "Angola", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5874), "Boran46@gmail.com", "Sağlık Sokak 93c, Erzurum, Ermenistan", "Bayboğa", "Kuday", "+90-078-930-26-95", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5874), "41929193-4a07-4f57-8883-f753ccd0030d", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Manisa", "Namibia", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5991), "Beker.Atakol@yahoo.com", "Bayır Sokak 63b, Konya, Malezya", "İrinçköl", "Ertürk", "+90-931-828-56-10", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5991), "18fb1638-cfc9-4f76-abd1-17ce242a7ba3", "0", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5992) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Artvin", "Mısır", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(1349), "Bastar.Yetkiner@gmail.com", "Bandak Sokak 22a, Siirt, Türkiye", "Akıbudak", "Oraloğlu", "+90-659-613-6-431", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(1359), "4b1cb20c-cce6-4d52-a9a0-628012585b35", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Diyarbakır", "Grenada", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(2379), "Bayincur.Ozbey@hotmail.com", "Sarıkaya Caddesi 06c, Muş, Güney Kıbrıs Rum Yönetimi", "Buğrakarakağan", "Ekici", "+90-287-051-7-768", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(2380), "6f03cae5-f1ca-447a-aef3-9cb5e410e962", "0", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Karaman", "Burundi", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(2579), "Bukusboga.Demirbas50@hotmail.com", "Harman Yolu Sokak  54a, Mardin, Ürdün", "Apa", "Ekşioğlu", "+90-397-397-6-785", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(2580), "18a1f97e-c198-4485-995e-36aa0854bef7", "1", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(2580) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Tekirdağ", "Saint Helena, İngiltere", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(2728), "Irinckol_Kececi1@gmail.com", "Barış Sokak 75c, K.maraş, Angola", "Karaca", "Adal", "+90-735-640-64-59", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(2729), "5f687b54-027c-41c8-b7cf-8741ee98a4be", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(2729) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Trabzon", "Çin", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(2855), "Barsgan.Aydan77@hotmail.com", "Harman Yolu Sokak  30, Kırklareli, Surinam", "Bögde", "Gürmen", "+90-219-975-73-40", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(2856), "513e69ef-30e9-4207-82f1-c63d9595d39e", "0", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(2856) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Hatay", "Tayvan", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(2974), "Alparsbeg_Solmaz64@yahoo.com", "Okul Sokak 98c, Osmaniye, Palau Adaları", "Çemen", "Erkekli", "+90-187-500-1-429", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(2975), "c64f0a46-1f99-494a-b5af-8fe3a5d4cd0d", "1", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(2975) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Nevşehir", "Ruanda", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(3099), "Isig.Balaban@yahoo.com", "Fatih Sokak  4, Şırnak, Galler", "Ekeç", "Topaloğlu", "+90-187-295-62-37", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(3099), "8505668c-a0f5-4f03-9951-b717512809b5", "0", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(3099) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "İstanbul", "Afganistan", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(3223), "Batur.Kocyigit@hotmail.com", "Alparslan Türkeş Bulvarı 2, Gümüşhane, Dominika", "Arpat", "Saygıner", "+90-129-046-59-56", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(3223), "7708eac6-4da7-46f4-b8ff-4f7c8d51edb7", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Ankara", "Küba", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(3327), "Boga_Alniacik@yahoo.com", "Kaldırım Sokak 71, Bingöl, Benin", "Buğrakarakağan", "Koç", "+90-549-296-6-283", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(3327), "ac4b7d10-839e-40ae-8345-dbd388102a5f", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(3328) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Gaziantep", "Ekvator Ginesi", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(3474), "Alpulug_Karaduman@hotmail.com", "Güven Yaka Sokak 69c, Şırnak, Malezya", "Kançı", "Aykaç", "+90-941-117-2-355", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(3474), "7f5a43fb-7bb9-48eb-a794-264463ec20e5", "0", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(3474) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Kırşehir", "Lübnan", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(3601), "Cagritegin.Erberk@hotmail.com", "Kaldırım Sokak 32b, Gaziantep, Liechtenstein", "Boylakutlutarkan", "Korol", "+90-222-377-06-92", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(3601), "b9aca361-ef06-4133-93ec-fd88fc4b8527", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(3601) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Çankırı", "Lüksemburg", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(2222), "Atakan_Kocyigit@gmail.com", "Ali Çetinkaya Caddesi 82a, Bingöl, İtalya", "Kımızın", "Hamzaoğlu", "+90-135-973-1-770", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(2239), "cdb1d45e-718d-40df-aa17-f4cd5a9ebd2d", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(2240) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Antalya", "Bhutan", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(4014), "Engin24@hotmail.com", "Oğuzhan Sokak 51, Zonguldak, Cebelitarık, İngiltere", "Gündoğmuş", "Paksüt", "+90-416-807-29-26", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(4020), "442cfc00-3da7-4e37-bf8c-7675d1102f90", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(4021) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Çankırı", "Bulgaristan", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(4242), "Alpaya4@hotmail.com", "İbn-i Sina Sokak 19c, Edirne, Meksika", "Bağatursepi", "Erberk", "+90-116-890-05-50", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(4243), "13a96514-093c-4514-a199-2331c0713f01", "0", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(4243) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Karaman", "Guadalup, Fransa", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(4377), "Akbudak.Asikoglu10@hotmail.com", "Ergenekon Sokak   2, Edirne, Senegal", "Alabörü", "Kuzucu", "+90-281-296-6-763", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(4377), "1e9174bc-64d8-402a-9f82-4de88089edef", "0", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(4377) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Ağrı", "Anguilla, İngiltere", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(4526), "Argun_Karadas@hotmail.com", "Oğuzhan Sokak 9, Edirne, Güney Afrika", "Arkış", "Gümüşpala", "+90-754-059-36-71", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(4527), "b4ab6332-b8e8-46e4-b2b2-f4ac5b7e5f57", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(4527) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Burdur", "Arjantin", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(4645), "Barimtay.Balci@hotmail.com", "Sevgi Sokak 98, Uşak, K.K.T.C.", "Bökde", "Nalbantoğlu", "+90-962-514-2-257", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(4645), "d9374cee-3932-461c-927d-3bc385e809c0", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(4645) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Mardin", "Mısır", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(4794), "Inanc_Erberk53@gmail.com", "Atatürk Bulvarı 02b, Van, Cezayir", "Ayluçtarkan", "Okumuş", "+90-718-058-1-270", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(4795), "45dda85f-f59e-4341-90ff-036b0200a874", "0", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(4795) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Niğde", "Cebelitarık, İngiltere", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(4933), "Altay23@yahoo.com", "İbn-i Sina Sokak 25b, Çorum, Uganda", "Borlukçu", "Özdenak", "+90-880-097-8-422", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(4934), "5505cb1b-68c6-46ce-a9e9-3bac1b23aee9", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(4934) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Bilecik", "Bolivya", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(5079), "Arademir_Sadiklar93@gmail.com", "Tevfik Fikret Caddesi 309, Trabzon, Tanzanya", "Abılay", "Adan", "+90-374-850-81-24", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(5079), "8f0bcecc-579d-4112-b339-b5c4ab26d027", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(5079) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Muğla", "Saint Pierre ve Miquelon, Fransa", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(5205), "Cokramayul96@yahoo.com", "Güven Yaka Sokak 392, Afyon, El Salvador", "Burunduk", "Orbay", "+90-279-978-6-967", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(5206), "918911b8-93e2-4707-9d48-c322c34b36b7", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(5206) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Edirne", "Hindistan", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(5348), "Atilgan70@hotmail.com", "Dağınık Evler Sokak 97, Erzincan, Letonya", "Ayban", "Türkyılmaz", "+90-275-234-3-874", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(5349), "8c0f339d-18e9-4bf8-9ff1-5da4ad167d5c", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(5349) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "City", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Sivas", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(5514), "Boyankulu.Capanoglu92@gmail.com", "Sıran Söğüt Sokak 65, Kırklareli, Filipinler", "Azganaz", "Nalbantoğlu", "+90-654-629-5-368", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(5514), "a80c44e6-828d-4176-9ff9-632efc475516", "1", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(5514) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Bolu", "El Salvador", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(5639), "Buyruc_Yesilkaya90@hotmail.com", "Nalbant Sokak 73b, K.maraş, Dominik Cumhuriyeti", "Buluş", "Poçan", "+90-011-674-7-839", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(5639), "5f4a3a4f-0e6f-4ac2-a282-df2311b95132", "1", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Düzce", "Svaziland", new DateTime(2025, 8, 10, 22, 38, 24, 407, DateTimeKind.Local).AddTicks(9386), "Caglayan45@yahoo.com", "İbn-i Sina Sokak 63c, Burdur, Ekvator Ginesi", "Batu", "Bademci", "+90-776-957-0-917", new DateTime(2025, 8, 10, 22, 38, 24, 407, DateTimeKind.Local).AddTicks(9403), "7067e476-1f62-4adf-a494-c504d5d3a401", new DateTime(2025, 8, 10, 22, 38, 24, 407, DateTimeKind.Local).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Zonguldak", "San Marino", new DateTime(2025, 8, 10, 22, 38, 24, 410, DateTimeKind.Local).AddTicks(7644), "Aybeg90@yahoo.com", "Bahçe Sokak 14, Yozgat, Eritre", "Akın", "Çevik", "+90-299-171-24-76", new DateTime(2025, 8, 10, 22, 38, 24, 410, DateTimeKind.Local).AddTicks(7656), "f1f90e1d-7eca-4157-bb84-91ccb557f068", "0", new DateTime(2025, 8, 10, 22, 38, 24, 410, DateTimeKind.Local).AddTicks(7657) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(1082), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(1090), 310.06m, new DateTime(2025, 4, 1, 21, 6, 20, 454, DateTimeKind.Local).AddTicks(3417), "Consectetur molestiae consequatur fugiat veniam corporis iusto aliquid necessitatibus.", "Handmade Plastic Table", "df63b6f3-b092-4923-a398-ea93c18a78b9", new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(1091) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(1376), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(1376), 225.73m, new DateTime(2025, 7, 8, 20, 5, 3, 729, DateTimeKind.Local).AddTicks(5866), "Saepe repudiandae explicabo labore incidunt asperiores odio consequuntur laborum modi.", "Small Rubber Fish", "0c476d6a-82ff-454d-a0dc-d88a55f37edb", 9, new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(1377) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(1506), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(1506), 53.34m, new DateTime(2025, 4, 19, 10, 13, 9, 95, DateTimeKind.Local).AddTicks(4748), "Sit alias suscipit.", "Practical Concrete Ball", "8813e510-646f-4696-a393-a9292e40da3d", 9, new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(1507) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(1537), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(1538), 810.16m, new DateTime(2024, 11, 16, 12, 18, 44, 198, DateTimeKind.Local).AddTicks(9906), "Dolore placeat voluptatibus id qui quas.", "Ergonomic Soft Chips", "69eff4cd-caa1-4d9f-8ab6-deb412c600de", 1, new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(1538) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(1581), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(1581), 593.86m, new DateTime(2024, 11, 6, 20, 50, 24, 410, DateTimeKind.Local).AddTicks(7942), "Fuga aut quasi vitae.", "Practical Granite Shoes", "ae5de7f2-bc5c-4554-abb5-a47ed96df82e", 9, new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(1609), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(1610), 395.24m, new DateTime(2025, 4, 8, 17, 27, 9, 653, DateTimeKind.Local).AddTicks(599), "İn alias quis voluptas doloribus nesciunt rerum et.", "Sleek Wooden Hat", "320aa52d-e3a8-4ef4-bb0d-1f9d016a309f", 10, new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(1610) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(1646), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(1646), 868.47m, new DateTime(2025, 1, 4, 18, 34, 22, 523, DateTimeKind.Local).AddTicks(512), "İpsum cupiditate ex veritatis et.", "Gorgeous Soft Pizza", "1c4b281c-5547-4dec-a6f6-8882cee7115b", 5, new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(1646) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(1707), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(1707), 302.93m, new DateTime(2025, 5, 21, 5, 0, 8, 719, DateTimeKind.Local).AddTicks(4462), "Rerum autem qui sint nihil quasi expedita est voluptatem cupiditate.", "Intelligent Concrete Chicken", "a6b3bfc3-e624-4dc3-97e7-35c37e23b6e0", 1, new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(1707) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(1751), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(1751), 435.20m, new DateTime(2024, 8, 12, 2, 58, 21, 96, DateTimeKind.Local).AddTicks(7345), "Rerum rerum quis sit dolorem.", "Unbranded Steel Hat", "d113c2a1-9180-4875-86f6-b20c2379d45a", 3, new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(1752) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(1780), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(1781), 31.11m, new DateTime(2025, 1, 18, 2, 6, 19, 312, DateTimeKind.Local).AddTicks(5683), "Porro omnis quis laudantium aliquam praesentium.", "Rustic Rubber Bike", "f8c82175-34e6-48fd-a329-e34c26c826ef", 9, new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(1781) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "PaymentId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 9, 11, 15, 30, 18, 857, DateTimeKind.Local).AddTicks(9430), new DateTime(2026, 5, 8, 21, 23, 50, 240, DateTimeKind.Local).AddTicks(5862), new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(8723), 8, new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(8726), "dcbee4cb-aa98-4ce8-912e-810e0580ce26", 0, 25, 1948.30m, new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "EntryDate", "MasterId", "PaymentId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 11, 8, 16, 7, 36, 285, DateTimeKind.Local).AddTicks(4235), new DateTime(2026, 11, 6, 1, 1, 15, 360, DateTimeKind.Local).AddTicks(4596), new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9216), new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9216), "74bcf47d-7c1c-4043-9f78-21621e4825c1", 0, 9, 1715.70m, new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9216) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "PaymentId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 9, 28, 5, 34, 8, 479, DateTimeKind.Local).AddTicks(7514), new DateTime(2026, 9, 12, 19, 19, 10, 80, DateTimeKind.Local).AddTicks(8229), new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9251), 2, new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9251), "b77d101a-df10-4801-9928-712342650f8a", 0, 23, 1615.75m, new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9252) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "PaymentId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 7, 0, 37, 47, 471, DateTimeKind.Local).AddTicks(4325), new DateTime(2026, 12, 31, 2, 47, 46, 1, DateTimeKind.Local).AddTicks(5321), new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9277), 6, new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9277), "443ea41d-53b3-49ed-b5e4-86162d1d2da6", 0, 9, 2270.25m, new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "PaymentId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 11, 27, 21, 17, 28, 655, DateTimeKind.Local).AddTicks(6150), new DateTime(2026, 8, 9, 2, 34, 19, 661, DateTimeKind.Local).AddTicks(7123), new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9302), 9, new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9302), "c43ad181-a71c-4788-8ece-88817d727228", 0, 21, 2371.28m, new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9303) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "PaymentId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 8, 17, 33, 53, 575, DateTimeKind.Local).AddTicks(4811), new DateTime(2026, 9, 27, 2, 10, 1, 626, DateTimeKind.Local).AddTicks(9536), new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9331), 1, new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9331), "28fbdf89-2f5b-4c9f-8990-2307465238f6", 0, 17, 1753.17m, new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "PaymentId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 9, 17, 11, 6, 55, 265, DateTimeKind.Local).AddTicks(4976), new DateTime(2026, 5, 24, 23, 31, 43, 311, DateTimeKind.Local).AddTicks(4826), new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9355), 8, new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9355), "39663358-61e7-43a7-ac52-1b2d34f3147d", 0, 30, 2323.75m, new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9356) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "EntryDate", "MasterId", "PaymentId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 5, 25, 0, 13, 33, 897, DateTimeKind.Local).AddTicks(7040), new DateTime(2026, 12, 7, 14, 40, 39, 72, DateTimeKind.Local).AddTicks(76), new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9426), new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9427), "7699413c-037f-472a-a507-d4d6e23c734a", 0, 7, 1826.99m, new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9427) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "PaymentId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 8, 7, 13, 10, 57, 680, DateTimeKind.Local).AddTicks(9698), new DateTime(2026, 12, 24, 9, 5, 34, 731, DateTimeKind.Local).AddTicks(4164), new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9450), 8, new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9451), "d367e25d-5fef-4b92-a881-ce4e202142ed", 0, 13, 1889.13m, new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9451) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "PaymentId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 8, 9, 6, 41, 45, 744, DateTimeKind.Local).AddTicks(1496), new DateTime(2027, 7, 12, 4, 27, 30, 729, DateTimeKind.Local).AddTicks(9350), new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9478), 9, new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9479), "384598d6-a3ef-4eab-a250-4a8f81ffe861", 0, 13, 2007.71m, new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 306, DateTimeKind.Local).AddTicks(3564), new DateTime(2025, 8, 10, 22, 38, 24, 306, DateTimeKind.Local).AddTicks(3582), "1aafc357-d368-4b54-b21b-c6008b5097d6", new DateTime(2025, 8, 10, 22, 38, 24, 306, DateTimeKind.Local).AddTicks(3583) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 308, DateTimeKind.Local).AddTicks(2358), new DateTime(2025, 8, 10, 22, 38, 24, 308, DateTimeKind.Local).AddTicks(2363), "be53fd30-51b8-44d8-bc9a-5173e5a88339", new DateTime(2025, 8, 10, 22, 38, 24, 308, DateTimeKind.Local).AddTicks(2364) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 309, DateTimeKind.Local).AddTicks(9709), new DateTime(2025, 8, 10, 22, 38, 24, 309, DateTimeKind.Local).AddTicks(9720), "474469ef-cf56-4090-a6f1-df3531dca530", new DateTime(2025, 8, 10, 22, 38, 24, 309, DateTimeKind.Local).AddTicks(9722) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 312, DateTimeKind.Local).AddTicks(1075), new DateTime(2025, 8, 10, 22, 38, 24, 312, DateTimeKind.Local).AddTicks(1080), "d8a07556-e1e7-4157-a64d-ea8ca2791838", new DateTime(2025, 8, 10, 22, 38, 24, 312, DateTimeKind.Local).AddTicks(1082) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 313, DateTimeKind.Local).AddTicks(9489), new DateTime(2025, 8, 10, 22, 38, 24, 313, DateTimeKind.Local).AddTicks(9495), "b4d5054b-8f06-4577-89d6-6439e8f1c371", new DateTime(2025, 8, 10, 22, 38, 24, 313, DateTimeKind.Local).AddTicks(9497) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 315, DateTimeKind.Local).AddTicks(1064), new DateTime(2025, 8, 10, 22, 38, 24, 315, DateTimeKind.Local).AddTicks(1068), "cc755c6a-4837-4b27-b28e-a60e2b89a74d", new DateTime(2025, 8, 10, 22, 38, 24, 315, DateTimeKind.Local).AddTicks(1069) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 316, DateTimeKind.Local).AddTicks(3277), new DateTime(2025, 8, 10, 22, 38, 24, 316, DateTimeKind.Local).AddTicks(3281), "1db40806-c9d4-473a-add8-d57edabfc5f5", new DateTime(2025, 8, 10, 22, 38, 24, 316, DateTimeKind.Local).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 317, DateTimeKind.Local).AddTicks(4675), new DateTime(2025, 8, 10, 22, 38, 24, 317, DateTimeKind.Local).AddTicks(4679), "d872ea7a-3d3d-4e5f-bdcf-248c22e3ee8b", new DateTime(2025, 8, 10, 22, 38, 24, 317, DateTimeKind.Local).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 318, DateTimeKind.Local).AddTicks(6445), new DateTime(2025, 8, 10, 22, 38, 24, 318, DateTimeKind.Local).AddTicks(6450), "c0a361b9-05a9-449d-82e8-141f0121b3dd", new DateTime(2025, 8, 10, 22, 38, 24, 318, DateTimeKind.Local).AddTicks(6451) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 320, DateTimeKind.Local).AddTicks(2273), new DateTime(2025, 8, 10, 22, 38, 24, 320, DateTimeKind.Local).AddTicks(2280), "e98224c7-eeab-41ba-b285-dc1ca5d05e44", new DateTime(2025, 8, 10, 22, 38, 24, 320, DateTimeKind.Local).AddTicks(2281) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 321, DateTimeKind.Local).AddTicks(4784), new DateTime(2025, 8, 10, 22, 38, 24, 321, DateTimeKind.Local).AddTicks(4793), "99dd4715-5720-46e2-9e6e-4a3304fdbdb5", new DateTime(2025, 8, 10, 22, 38, 24, 321, DateTimeKind.Local).AddTicks(4793) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 323, DateTimeKind.Local).AddTicks(2279), new DateTime(2025, 8, 10, 22, 38, 24, 323, DateTimeKind.Local).AddTicks(2285), "f2c8552d-3603-49c4-afae-92e85cb90cc2", new DateTime(2025, 8, 10, 22, 38, 24, 323, DateTimeKind.Local).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 324, DateTimeKind.Local).AddTicks(3294), new DateTime(2025, 8, 10, 22, 38, 24, 324, DateTimeKind.Local).AddTicks(3301), "f286c5b1-e6a3-4994-9302-5b13aa9d2c2a", new DateTime(2025, 8, 10, 22, 38, 24, 324, DateTimeKind.Local).AddTicks(3302) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 325, DateTimeKind.Local).AddTicks(3832), new DateTime(2025, 8, 10, 22, 38, 24, 325, DateTimeKind.Local).AddTicks(3838), "c4c428cc-40b4-4abe-9759-45fb532dd69f", new DateTime(2025, 8, 10, 22, 38, 24, 325, DateTimeKind.Local).AddTicks(3838) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 326, DateTimeKind.Local).AddTicks(7102), new DateTime(2025, 8, 10, 22, 38, 24, 326, DateTimeKind.Local).AddTicks(7106), "2b4e6d1e-3d57-47bf-86e8-1ee8a7d4972d", new DateTime(2025, 8, 10, 22, 38, 24, 326, DateTimeKind.Local).AddTicks(7106) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 327, DateTimeKind.Local).AddTicks(9054), new DateTime(2025, 8, 10, 22, 38, 24, 327, DateTimeKind.Local).AddTicks(9058), "5825afcc-bb5d-4480-8118-a13249e3d95b", new DateTime(2025, 8, 10, 22, 38, 24, 327, DateTimeKind.Local).AddTicks(9059) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 328, DateTimeKind.Local).AddTicks(9678), new DateTime(2025, 8, 10, 22, 38, 24, 328, DateTimeKind.Local).AddTicks(9686), "a846f0de-5666-47cb-99fe-df8ea47239be", new DateTime(2025, 8, 10, 22, 38, 24, 328, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 330, DateTimeKind.Local).AddTicks(550), new DateTime(2025, 8, 10, 22, 38, 24, 330, DateTimeKind.Local).AddTicks(554), "0a9e3e7b-6f87-4643-92b2-58cb57acdec9", new DateTime(2025, 8, 10, 22, 38, 24, 330, DateTimeKind.Local).AddTicks(554) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 331, DateTimeKind.Local).AddTicks(1565), new DateTime(2025, 8, 10, 22, 38, 24, 331, DateTimeKind.Local).AddTicks(1569), "f0f1e200-d4c7-419c-aa0d-8c1adda0e5b7", new DateTime(2025, 8, 10, 22, 38, 24, 331, DateTimeKind.Local).AddTicks(1569) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 332, DateTimeKind.Local).AddTicks(2558), new DateTime(2025, 8, 10, 22, 38, 24, 332, DateTimeKind.Local).AddTicks(2562), "fc85f864-5441-47ac-b686-12c3c9f0a765", new DateTime(2025, 8, 10, 22, 38, 24, 332, DateTimeKind.Local).AddTicks(2563) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 333, DateTimeKind.Local).AddTicks(6354), new DateTime(2025, 8, 10, 22, 38, 24, 333, DateTimeKind.Local).AddTicks(6361), "15571720-bbff-4169-ab2f-4078da0b51e3", new DateTime(2025, 8, 10, 22, 38, 24, 333, DateTimeKind.Local).AddTicks(6361) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 335, DateTimeKind.Local).AddTicks(1227), new DateTime(2025, 8, 10, 22, 38, 24, 335, DateTimeKind.Local).AddTicks(1232), "a2eb0fad-2389-4fb8-85ae-b2f7d94111cf", new DateTime(2025, 8, 10, 22, 38, 24, 335, DateTimeKind.Local).AddTicks(1233) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 336, DateTimeKind.Local).AddTicks(3953), new DateTime(2025, 8, 10, 22, 38, 24, 336, DateTimeKind.Local).AddTicks(3957), "5357fae3-aaae-451d-905d-e6b1d659630b", new DateTime(2025, 8, 10, 22, 38, 24, 336, DateTimeKind.Local).AddTicks(3957) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 337, DateTimeKind.Local).AddTicks(5792), new DateTime(2025, 8, 10, 22, 38, 24, 337, DateTimeKind.Local).AddTicks(5797), "3480e1b4-19b9-43f1-a418-887e94940b03", new DateTime(2025, 8, 10, 22, 38, 24, 337, DateTimeKind.Local).AddTicks(5797) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 338, DateTimeKind.Local).AddTicks(6817), new DateTime(2025, 8, 10, 22, 38, 24, 338, DateTimeKind.Local).AddTicks(6822), "33876c3c-e4a4-4ec4-9462-5ffe32414c68", new DateTime(2025, 8, 10, 22, 38, 24, 338, DateTimeKind.Local).AddTicks(6822) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 339, DateTimeKind.Local).AddTicks(7757), new DateTime(2025, 8, 10, 22, 38, 24, 339, DateTimeKind.Local).AddTicks(7762), "9e52a869-0f0b-41cd-9548-7022ef3bcbf1", new DateTime(2025, 8, 10, 22, 38, 24, 339, DateTimeKind.Local).AddTicks(7762) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 340, DateTimeKind.Local).AddTicks(9513), new DateTime(2025, 8, 10, 22, 38, 24, 340, DateTimeKind.Local).AddTicks(9517), "afc8f0c8-c00f-442f-a197-eea16cfd3c9b", new DateTime(2025, 8, 10, 22, 38, 24, 340, DateTimeKind.Local).AddTicks(9518) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 342, DateTimeKind.Local).AddTicks(914), new DateTime(2025, 8, 10, 22, 38, 24, 342, DateTimeKind.Local).AddTicks(917), "fffc0065-b0c8-46e1-bb85-d1462a26a68f", new DateTime(2025, 8, 10, 22, 38, 24, 342, DateTimeKind.Local).AddTicks(918) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 343, DateTimeKind.Local).AddTicks(2091), new DateTime(2025, 8, 10, 22, 38, 24, 343, DateTimeKind.Local).AddTicks(2094), "40897942-0df3-4147-b8a8-c20c78e0ffac", new DateTime(2025, 8, 10, 22, 38, 24, 343, DateTimeKind.Local).AddTicks(2095) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 344, DateTimeKind.Local).AddTicks(2904), new DateTime(2025, 8, 10, 22, 38, 24, 344, DateTimeKind.Local).AddTicks(2907), "25ba0061-50ee-4de1-bd4b-4e2ed3e56bdb", new DateTime(2025, 8, 10, 22, 38, 24, 344, DateTimeKind.Local).AddTicks(2908) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 345, DateTimeKind.Local).AddTicks(4357), new DateTime(2025, 8, 10, 22, 38, 24, 345, DateTimeKind.Local).AddTicks(4361), "8610c1f5-3a96-4efa-84e7-390f4f0bec2d", new DateTime(2025, 8, 10, 22, 38, 24, 345, DateTimeKind.Local).AddTicks(4362) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 346, DateTimeKind.Local).AddTicks(4547), new DateTime(2025, 8, 10, 22, 38, 24, 346, DateTimeKind.Local).AddTicks(4564), "4586b962-3187-46eb-8df3-8960464f051d", new DateTime(2025, 8, 10, 22, 38, 24, 346, DateTimeKind.Local).AddTicks(4565) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 347, DateTimeKind.Local).AddTicks(5519), new DateTime(2025, 8, 10, 22, 38, 24, 347, DateTimeKind.Local).AddTicks(5523), "d10070a7-3ff5-41ed-8944-7596b815f944", new DateTime(2025, 8, 10, 22, 38, 24, 347, DateTimeKind.Local).AddTicks(5524) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 348, DateTimeKind.Local).AddTicks(5188), new DateTime(2025, 8, 10, 22, 38, 24, 348, DateTimeKind.Local).AddTicks(5191), "c5915744-a2d3-42f0-b149-4ab94cf0998b", new DateTime(2025, 8, 10, 22, 38, 24, 348, DateTimeKind.Local).AddTicks(5192) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 349, DateTimeKind.Local).AddTicks(4116), new DateTime(2025, 8, 10, 22, 38, 24, 349, DateTimeKind.Local).AddTicks(4117), "6924dc04-d038-474a-9907-b011e4bd37a4", new DateTime(2025, 8, 10, 22, 38, 24, 349, DateTimeKind.Local).AddTicks(4117) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 350, DateTimeKind.Local).AddTicks(3406), new DateTime(2025, 8, 10, 22, 38, 24, 350, DateTimeKind.Local).AddTicks(3409), "bdb1ba7c-7f73-4fe1-8e70-be9bddca30bb", new DateTime(2025, 8, 10, 22, 38, 24, 350, DateTimeKind.Local).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 351, DateTimeKind.Local).AddTicks(3016), new DateTime(2025, 8, 10, 22, 38, 24, 351, DateTimeKind.Local).AddTicks(3017), "f6a0f285-abb5-4b61-8209-0e19ed5f0389", new DateTime(2025, 8, 10, 22, 38, 24, 351, DateTimeKind.Local).AddTicks(3017) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 352, DateTimeKind.Local).AddTicks(4449), new DateTime(2025, 8, 10, 22, 38, 24, 352, DateTimeKind.Local).AddTicks(4453), "53117146-92c3-4b15-9256-840c75e49eb7", new DateTime(2025, 8, 10, 22, 38, 24, 352, DateTimeKind.Local).AddTicks(4454) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 353, DateTimeKind.Local).AddTicks(7686), new DateTime(2025, 8, 10, 22, 38, 24, 353, DateTimeKind.Local).AddTicks(7690), "ae94d72b-175d-4a2a-9cbd-435a356d886f", new DateTime(2025, 8, 10, 22, 38, 24, 353, DateTimeKind.Local).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 355, DateTimeKind.Local).AddTicks(1812), new DateTime(2025, 8, 10, 22, 38, 24, 355, DateTimeKind.Local).AddTicks(1819), "4025d5c5-9a8b-442a-8faf-94052a43439b", new DateTime(2025, 8, 10, 22, 38, 24, 355, DateTimeKind.Local).AddTicks(1820) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 356, DateTimeKind.Local).AddTicks(4476), new DateTime(2025, 8, 10, 22, 38, 24, 356, DateTimeKind.Local).AddTicks(4480), "2fdd7a65-8e6c-4fe8-88ca-1cc36df16c8d", new DateTime(2025, 8, 10, 22, 38, 24, 356, DateTimeKind.Local).AddTicks(4481) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 357, DateTimeKind.Local).AddTicks(6299), new DateTime(2025, 8, 10, 22, 38, 24, 357, DateTimeKind.Local).AddTicks(6304), "0064305b-58a8-41a0-a571-155848bf73f4", new DateTime(2025, 8, 10, 22, 38, 24, 357, DateTimeKind.Local).AddTicks(6305) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 358, DateTimeKind.Local).AddTicks(8048), new DateTime(2025, 8, 10, 22, 38, 24, 358, DateTimeKind.Local).AddTicks(8049), "ee1776bd-661a-4cf2-b0e5-2d40a4d7013f", new DateTime(2025, 8, 10, 22, 38, 24, 358, DateTimeKind.Local).AddTicks(8049) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 359, DateTimeKind.Local).AddTicks(8398), new DateTime(2025, 8, 10, 22, 38, 24, 359, DateTimeKind.Local).AddTicks(8402), "9c01892f-1a60-4c0b-b18c-6343aee0c69c", new DateTime(2025, 8, 10, 22, 38, 24, 359, DateTimeKind.Local).AddTicks(8402) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 361, DateTimeKind.Local).AddTicks(259), new DateTime(2025, 8, 10, 22, 38, 24, 361, DateTimeKind.Local).AddTicks(266), "11d62a20-f1d8-4175-b07d-beaa2fdd6fd9", new DateTime(2025, 8, 10, 22, 38, 24, 361, DateTimeKind.Local).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 362, DateTimeKind.Local).AddTicks(6165), new DateTime(2025, 8, 10, 22, 38, 24, 362, DateTimeKind.Local).AddTicks(6172), "df8c5b44-2863-4860-bcb3-09775cc677bc", new DateTime(2025, 8, 10, 22, 38, 24, 362, DateTimeKind.Local).AddTicks(6173) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 363, DateTimeKind.Local).AddTicks(8615), new DateTime(2025, 8, 10, 22, 38, 24, 363, DateTimeKind.Local).AddTicks(8622), "b64712b4-126e-4d86-8c4a-290abbce7d30", new DateTime(2025, 8, 10, 22, 38, 24, 363, DateTimeKind.Local).AddTicks(8623) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 365, DateTimeKind.Local).AddTicks(1407), new DateTime(2025, 8, 10, 22, 38, 24, 365, DateTimeKind.Local).AddTicks(1412), "8570aca1-18b3-4182-a243-bcfddef3a9d9", new DateTime(2025, 8, 10, 22, 38, 24, 365, DateTimeKind.Local).AddTicks(1414) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 366, DateTimeKind.Local).AddTicks(4260), new DateTime(2025, 8, 10, 22, 38, 24, 366, DateTimeKind.Local).AddTicks(4266), "c1a20695-a084-4fbf-9c0d-fb3346307616", new DateTime(2025, 8, 10, 22, 38, 24, 366, DateTimeKind.Local).AddTicks(4268) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 367, DateTimeKind.Local).AddTicks(6312), new DateTime(2025, 8, 10, 22, 38, 24, 367, DateTimeKind.Local).AddTicks(6317), "0ae65b2a-6b92-4f0c-b787-e7edb1dec73c", new DateTime(2025, 8, 10, 22, 38, 24, 367, DateTimeKind.Local).AddTicks(6317) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 369, DateTimeKind.Local).AddTicks(986), new DateTime(2025, 8, 10, 22, 38, 24, 369, DateTimeKind.Local).AddTicks(994), "6527ab89-cdcb-49cb-80d1-cb4c6e2738e9", new DateTime(2025, 8, 10, 22, 38, 24, 369, DateTimeKind.Local).AddTicks(995) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 370, DateTimeKind.Local).AddTicks(4185), new DateTime(2025, 8, 10, 22, 38, 24, 370, DateTimeKind.Local).AddTicks(4191), "cfc3ff5e-8cfb-4b5a-a01c-9f5289953011", new DateTime(2025, 8, 10, 22, 38, 24, 370, DateTimeKind.Local).AddTicks(4192) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 371, DateTimeKind.Local).AddTicks(5178), new DateTime(2025, 8, 10, 22, 38, 24, 371, DateTimeKind.Local).AddTicks(5181), "6f75f235-5f5c-4901-938c-7e50a4cda54e", new DateTime(2025, 8, 10, 22, 38, 24, 371, DateTimeKind.Local).AddTicks(5181) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 372, DateTimeKind.Local).AddTicks(6447), new DateTime(2025, 8, 10, 22, 38, 24, 372, DateTimeKind.Local).AddTicks(6452), "9798395d-90fd-4a04-a513-f63df181ae1c", new DateTime(2025, 8, 10, 22, 38, 24, 372, DateTimeKind.Local).AddTicks(6452) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 373, DateTimeKind.Local).AddTicks(7532), new DateTime(2025, 8, 10, 22, 38, 24, 373, DateTimeKind.Local).AddTicks(7535), "921fc60d-11c3-4d5a-b843-6ce5823f0161", new DateTime(2025, 8, 10, 22, 38, 24, 373, DateTimeKind.Local).AddTicks(7536) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 374, DateTimeKind.Local).AddTicks(7786), new DateTime(2025, 8, 10, 22, 38, 24, 374, DateTimeKind.Local).AddTicks(7793), "e0ab8d17-dbc0-42ee-86a2-c4819c46cc8a", new DateTime(2025, 8, 10, 22, 38, 24, 374, DateTimeKind.Local).AddTicks(7795) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 376, DateTimeKind.Local).AddTicks(988), new DateTime(2025, 8, 10, 22, 38, 24, 376, DateTimeKind.Local).AddTicks(997), "f3be833b-d402-4d43-805d-3098bfa91448", new DateTime(2025, 8, 10, 22, 38, 24, 376, DateTimeKind.Local).AddTicks(998) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 377, DateTimeKind.Local).AddTicks(2036), new DateTime(2025, 8, 10, 22, 38, 24, 377, DateTimeKind.Local).AddTicks(2045), "d5237a3f-ee8a-42e2-ba8d-f2b55fa2a9af", new DateTime(2025, 8, 10, 22, 38, 24, 377, DateTimeKind.Local).AddTicks(2046) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 378, DateTimeKind.Local).AddTicks(3356), new DateTime(2025, 8, 10, 22, 38, 24, 378, DateTimeKind.Local).AddTicks(3363), "16fb2268-b618-498a-8485-91f9694ee84d", new DateTime(2025, 8, 10, 22, 38, 24, 378, DateTimeKind.Local).AddTicks(3364) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 379, DateTimeKind.Local).AddTicks(4422), new DateTime(2025, 8, 10, 22, 38, 24, 379, DateTimeKind.Local).AddTicks(4427), "1e81843d-bcf5-43e4-bf6e-b81098225587", new DateTime(2025, 8, 10, 22, 38, 24, 379, DateTimeKind.Local).AddTicks(4427) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 380, DateTimeKind.Local).AddTicks(5084), new DateTime(2025, 8, 10, 22, 38, 24, 380, DateTimeKind.Local).AddTicks(5088), "205ea19e-53ef-4aa8-8ad0-96498ee57b3c", new DateTime(2025, 8, 10, 22, 38, 24, 380, DateTimeKind.Local).AddTicks(5089) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 381, DateTimeKind.Local).AddTicks(5142), new DateTime(2025, 8, 10, 22, 38, 24, 381, DateTimeKind.Local).AddTicks(5146), "340c6ba9-c43f-4a9d-a669-eee836de91f6", new DateTime(2025, 8, 10, 22, 38, 24, 381, DateTimeKind.Local).AddTicks(5146) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 382, DateTimeKind.Local).AddTicks(5817), new DateTime(2025, 8, 10, 22, 38, 24, 382, DateTimeKind.Local).AddTicks(5821), "0add08cc-014f-4c52-a1a0-9ef7c801618f", new DateTime(2025, 8, 10, 22, 38, 24, 382, DateTimeKind.Local).AddTicks(5821) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 383, DateTimeKind.Local).AddTicks(5959), new DateTime(2025, 8, 10, 22, 38, 24, 383, DateTimeKind.Local).AddTicks(5962), "9035b4ba-f000-4aa8-a9bd-7db9b8ccdccb", new DateTime(2025, 8, 10, 22, 38, 24, 383, DateTimeKind.Local).AddTicks(5963) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 384, DateTimeKind.Local).AddTicks(6641), new DateTime(2025, 8, 10, 22, 38, 24, 384, DateTimeKind.Local).AddTicks(6644), "2bedb9e2-bce4-4004-bb9d-7f4ced34b5ec", new DateTime(2025, 8, 10, 22, 38, 24, 384, DateTimeKind.Local).AddTicks(6645) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 385, DateTimeKind.Local).AddTicks(6921), new DateTime(2025, 8, 10, 22, 38, 24, 385, DateTimeKind.Local).AddTicks(6925), "4854cc8f-5677-49b5-93fb-bfeea9b98d67", new DateTime(2025, 8, 10, 22, 38, 24, 385, DateTimeKind.Local).AddTicks(6926) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 386, DateTimeKind.Local).AddTicks(6346), new DateTime(2025, 8, 10, 22, 38, 24, 386, DateTimeKind.Local).AddTicks(6349), "8b217661-35cc-4ca6-b627-f8501cc50c01", new DateTime(2025, 8, 10, 22, 38, 24, 386, DateTimeKind.Local).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 387, DateTimeKind.Local).AddTicks(5655), new DateTime(2025, 8, 10, 22, 38, 24, 387, DateTimeKind.Local).AddTicks(5658), "8a0f0177-8067-4dc0-a17c-f799eca5aaff", new DateTime(2025, 8, 10, 22, 38, 24, 387, DateTimeKind.Local).AddTicks(5659) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 388, DateTimeKind.Local).AddTicks(5253), new DateTime(2025, 8, 10, 22, 38, 24, 388, DateTimeKind.Local).AddTicks(5257), "5f189247-d500-4e20-ae85-bd5b71824613", new DateTime(2025, 8, 10, 22, 38, 24, 388, DateTimeKind.Local).AddTicks(5258) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 389, DateTimeKind.Local).AddTicks(5566), new DateTime(2025, 8, 10, 22, 38, 24, 389, DateTimeKind.Local).AddTicks(5571), "0ee74478-a615-40ee-99ef-66fd6c72efba", new DateTime(2025, 8, 10, 22, 38, 24, 389, DateTimeKind.Local).AddTicks(5571) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 390, DateTimeKind.Local).AddTicks(5914), new DateTime(2025, 8, 10, 22, 38, 24, 390, DateTimeKind.Local).AddTicks(5919), "a43eb664-9cd4-4b48-aad4-83405b7149e9", new DateTime(2025, 8, 10, 22, 38, 24, 390, DateTimeKind.Local).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 391, DateTimeKind.Local).AddTicks(5796), new DateTime(2025, 8, 10, 22, 38, 24, 391, DateTimeKind.Local).AddTicks(5799), "8ba26106-3d8c-41ee-ba39-eacfa0861cf3", new DateTime(2025, 8, 10, 22, 38, 24, 391, DateTimeKind.Local).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 392, DateTimeKind.Local).AddTicks(4861), new DateTime(2025, 8, 10, 22, 38, 24, 392, DateTimeKind.Local).AddTicks(4864), "c4d71bbe-6715-459a-ad0e-2927bdece1c3", new DateTime(2025, 8, 10, 22, 38, 24, 392, DateTimeKind.Local).AddTicks(4864) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 393, DateTimeKind.Local).AddTicks(3903), new DateTime(2025, 8, 10, 22, 38, 24, 393, DateTimeKind.Local).AddTicks(3907), "2fa765b8-a2aa-46a0-8ef8-80e08634acca", new DateTime(2025, 8, 10, 22, 38, 24, 393, DateTimeKind.Local).AddTicks(3907) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 394, DateTimeKind.Local).AddTicks(3063), new DateTime(2025, 8, 10, 22, 38, 24, 394, DateTimeKind.Local).AddTicks(3067), "e4a2cea1-8cb6-472c-9a83-74d48525cdde", new DateTime(2025, 8, 10, 22, 38, 24, 394, DateTimeKind.Local).AddTicks(3067) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 395, DateTimeKind.Local).AddTicks(1833), new DateTime(2025, 8, 10, 22, 38, 24, 395, DateTimeKind.Local).AddTicks(1835), "abff8dd3-5b59-4199-b40b-86b3d84e7efe", new DateTime(2025, 8, 10, 22, 38, 24, 395, DateTimeKind.Local).AddTicks(1836) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 396, DateTimeKind.Local).AddTicks(6289), new DateTime(2025, 8, 10, 22, 38, 24, 396, DateTimeKind.Local).AddTicks(6296), "666c89c8-2b60-4390-a2a0-ee22a9fa12b5", new DateTime(2025, 8, 10, 22, 38, 24, 396, DateTimeKind.Local).AddTicks(6297) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4229), 2, new DateTime(2025, 8, 10, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4229), "7d4bf273-9582-4746-ba62-0967ca0ca639", new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4251), 3, new DateTime(2025, 8, 10, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4251), "2b5fa106-283d-41df-a3dd-cadaf7de0f12", new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4251) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4257), 4, new DateTime(2025, 8, 10, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4257), "0ece2e16-c976-4d53-9383-5914fdc16e18", new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4257) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4261), 5, new DateTime(2025, 8, 10, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4262), "dfb15c93-2477-41c9-8ccd-1e230a5f7354", new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4262) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4274), new DateTime(2025, 8, 11, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4274), "bc10f853-ac02-4227-b8ee-ee8735ef9cc1", new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 11, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4274) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4280), 3, new DateTime(2025, 8, 11, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4280), "86fd2d57-7860-4bf4-98d4-3b1d2ab268a7", new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 11, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4281) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4285), 4, new DateTime(2025, 8, 11, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4285), "9bf09732-02c6-41fc-8c67-c7187ad21f15", new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 11, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4285) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4289), 5, new DateTime(2025, 8, 11, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4290), "ab34f57a-0700-4e22-b2c0-96966a36c03b", new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 11, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4296), 1, new DateTime(2025, 8, 12, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4297), "8c9b6735-f3ac-4de4-9e0c-1d6e1096a693", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 12, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4343), 2, new DateTime(2025, 8, 12, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4344), "9ba528ab-d876-4d3e-9068-de5bb6ed0170", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 12, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4344) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4348), new DateTime(2025, 8, 12, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4348), "d2a0d53f-9153-4c36-b839-33eccf0fa27d", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 12, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4349) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4352), new DateTime(2025, 8, 12, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4353), "0b8ff700-9bd5-411a-8d74-d093e3ab24cf", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 12, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4353) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4361), new DateTime(2025, 8, 13, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4361), "555be205-e69b-4df7-977c-cc99ad016fe4", new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 13, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4362) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4366), 2, new DateTime(2025, 8, 13, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4367), "0d46fbc1-8807-4608-bda3-2ac585852efc", new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 13, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4367) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4371), 3, new DateTime(2025, 8, 13, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4371), "57f73360-0a92-437d-9576-5deebd3ef6a8", new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 13, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4371) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4375), new DateTime(2025, 8, 13, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4376), "e10c0149-6843-41a9-bae2-b932305a9b52", new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 13, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4382), new DateTime(2025, 8, 14, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4383), "917955df-99c2-40c8-88cf-d63b374bd691", new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 14, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4383) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4388), new DateTime(2025, 8, 14, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4388), "59629afb-47e1-41d1-93a0-e949b7b3884a", new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 14, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4389) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4393), 3, new DateTime(2025, 8, 14, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4393), "74723bc8-5703-4fbb-8f29-9c49b92c2f2d", new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 14, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4393) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4397), 4, new DateTime(2025, 8, 14, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4397), "574262e2-a167-455e-abbe-5f114944761d", new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 14, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4398) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4405), new DateTime(2025, 8, 15, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4405), "7698555c-9d56-4b8c-9446-77fd1f2e73a2", new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 15, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4406) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4410), new DateTime(2025, 8, 15, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4410), "cd2c06fb-2992-4bca-b9cb-f3752b999c14", new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 15, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4410) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4414), new DateTime(2025, 8, 15, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4414), "b2c30b3e-206f-4b7b-b81f-dff7ab8241a4", new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 15, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4415) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4418), 4, new DateTime(2025, 8, 15, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4419), "065652b9-1783-4f20-9b3c-85d9d264e160", new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 15, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4419) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4426), new DateTime(2025, 8, 16, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4426), "6675c717-b00e-459a-805f-7336dceb0394", new DateTime(2025, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 16, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4426) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4431), new DateTime(2025, 8, 16, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4431), "2061cd6d-3a3c-42df-ad0e-f8a43a2ca881", new DateTime(2025, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 16, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4431) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4435), new DateTime(2025, 8, 16, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4435), "dd0db2be-0f98-4e1f-af26-ba6a25bbeb03", new DateTime(2025, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 16, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4435) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4439), new DateTime(2025, 8, 16, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4439), "11a18999-462f-44d5-b94d-9800f4917941", new DateTime(2025, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 16, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4451), new DateTime(2025, 8, 10, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4451), "2bc4cad7-619c-4c59-99a4-432b0afe7f11", new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4451) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4456), new DateTime(2025, 8, 10, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4457), "b9924672-fb09-4675-9be8-3a8602228c25", new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4457) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4462), new DateTime(2025, 8, 10, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4462), "fef8e949-f635-4235-beb3-76e2cbd4bb48", new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4462) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4466), new DateTime(2025, 8, 10, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4466), "bd36760a-041a-42af-a402-e2253ad047da", new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4467) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4471), new DateTime(2025, 8, 10, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4471), "730f8c45-fcec-4fd1-842b-ffe55c7f6c93", new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4521), new DateTime(2025, 8, 10, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4521), "3089003b-bc7e-4c39-9a3e-37833c458976", new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4521) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4527), new DateTime(2025, 8, 11, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4527), "307baea6-ca37-433e-a30b-cd6e6a585dbc", new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 11, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4527) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4532), new DateTime(2025, 8, 11, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4532), "f97da083-9d88-40cd-8eb0-f78ddbbd8f83", new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 11, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4532) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4538), new DateTime(2025, 8, 11, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4538), "854b2464-8fb5-4902-96e6-a1be481a2cbd", new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 11, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4539) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4543), new DateTime(2025, 8, 11, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4543), "a7147ae0-ed85-4c0a-9f39-d5aa75bb7021", new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 11, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4544) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4548), new DateTime(2025, 8, 11, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4549), "ec2aade9-789c-4b7f-8583-cb7f4791b7c1", new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 11, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4549) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4552), new DateTime(2025, 8, 11, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4553), "31236e52-3898-4a45-9877-c7d255461fe5", new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 11, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4553) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4557), new DateTime(2025, 8, 12, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4557), "855d73ce-5184-4709-89f5-69b3b153ea21", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 12, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4558) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4561), new DateTime(2025, 8, 12, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4561), "df0667bc-76f7-42ff-ae46-d8f08b821670", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 12, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4562) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4566), new DateTime(2025, 8, 12, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4566), "f5719fd3-4457-4bd4-92fe-5626c2346e99", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 12, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4566) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4570), new DateTime(2025, 8, 12, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4570), "d6e0801f-ede8-4274-b04e-faf2bff53c80", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 12, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4575), new DateTime(2025, 8, 12, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4576), "d79244e6-675c-4335-b076-8dfe6d2f4b31", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 12, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4576) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4580), new DateTime(2025, 8, 12, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4580), "f874fe7c-d509-4c13-bf3f-37c4ecfc9c71", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 12, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4584), new DateTime(2025, 8, 13, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4585), "90ca60dd-3a94-4da7-8c57-d19734352d87", new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 13, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4585) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4589), new DateTime(2025, 8, 13, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4589), "d15e1aac-ced8-45d0-bd27-4c368f5df153", new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 13, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4589) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4593), new DateTime(2025, 8, 13, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4593), "4a41ec79-aa4b-4f85-a03e-560be0704cc7", new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 13, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4594) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4598), new DateTime(2025, 8, 13, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4598), "8a27bfc1-1096-4618-a6c1-28ffcda09a7f", new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 13, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4598) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4603), new DateTime(2025, 8, 13, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4603), "02500854-dcf0-4a0e-8df5-e4847e5bb451", new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 13, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4603) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4607), new DateTime(2025, 8, 13, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4607), "85163f8f-a010-4512-acb3-5726dae92a9f", new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 13, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4607) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4613), new DateTime(2025, 8, 14, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4613), "32784afc-b575-414a-81e3-080e6998d070", new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 14, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4613) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4617), new DateTime(2025, 8, 14, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4618), "14225da0-f6ba-44f9-93d1-049f9947210e", new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 14, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4618) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4622), new DateTime(2025, 8, 14, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4622), "9a09a1c9-10e7-48fa-a647-9922cd4b973b", new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 14, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4622) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4627), new DateTime(2025, 8, 14, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4627), "7a34f353-238f-428c-96c8-1e8eccd43675", new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 14, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4632), new DateTime(2025, 8, 14, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4632), "ad4c82fa-9fbe-49fd-9dcb-3ba5541136ac", new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 14, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4632) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4636), new DateTime(2025, 8, 14, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4636), "2b3a82c8-b95c-4eba-b553-ab480d0597b3", new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 14, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4636) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4641), new DateTime(2025, 8, 15, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4641), "dbf485a1-52c5-49c7-a946-1de8e32c0610", new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 15, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4641) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4646), new DateTime(2025, 8, 15, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4646), "f40f17bc-481d-46d1-9f40-46e7811a3e2d", new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 15, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4646) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4652), new DateTime(2025, 8, 15, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4652), "90a592f7-b99c-4764-ada8-da8e7efbf6aa", new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 15, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4652) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4656), new DateTime(2025, 8, 15, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4656), "eefda25d-de1d-47ac-9a24-b150f5b654f1", new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 15, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4656) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4661), new DateTime(2025, 8, 15, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4661), "4a374400-8f5f-49b2-b438-8fe7a0a139fc", new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 15, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4662) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4665), new DateTime(2025, 8, 15, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4665), "85bff37e-8e9d-4074-906b-01755acc93d8", new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 15, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4666) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4696), new DateTime(2025, 8, 16, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4696), "9b331184-cc2b-4f71-b945-97333c7ce1fe", new DateTime(2025, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 16, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4702), new DateTime(2025, 8, 16, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4702), "ae6f7b76-1036-4b1e-a27a-075a5c164931", new DateTime(2025, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 16, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4702) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4707), new DateTime(2025, 8, 16, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4708), "bbac0b09-1242-48b2-8aa0-9680734835ac", new DateTime(2025, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 16, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4708) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4712), new DateTime(2025, 8, 16, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4713), "af93d33c-136c-4c9c-bf30-a7713f1799b2", new DateTime(2025, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 16, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4713) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4719), new DateTime(2025, 8, 16, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4719), "bbcc0b24-1f94-4d71-8971-2e91ff29dbbd", new DateTime(2025, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 16, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4719) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4723), new DateTime(2025, 8, 16, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4723), "603ce4a2-1c6b-4405-b464-118f039b8290", new DateTime(2025, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 16, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4724) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4766), new DateTime(2025, 8, 10, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4767), "95d86d81-3f73-4567-88db-e26173c03576", new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4767) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4775), 11, new DateTime(2025, 8, 10, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4776), "3856ef31-b43b-40a9-b0df-428dedb96d0b", new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 10, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4781), 12, new DateTime(2025, 8, 10, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4781), "4b3ce814-030e-4c5f-b925-3310a6ee1e76", new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4781) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4785), new DateTime(2025, 8, 10, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4785), "40da6e7f-0df8-4b89-a3fd-82d149553116", new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 10, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4785) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4792), new DateTime(2025, 8, 11, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4792), "273a48da-d20f-4ea7-b4fd-8e6fbef983bd", new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 11, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4798), new DateTime(2025, 8, 11, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4799), "74ead18e-7ca6-4339-964a-1856c7f2f741", new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 11, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4799) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4803), new DateTime(2025, 8, 12, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4803), "cb1155a6-db45-48f9-b7f0-fd7dc3e31ada", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 12, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4803) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4809), new DateTime(2025, 8, 12, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4809), "ef466bfa-82ba-4143-8ff8-5538842d1941", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 12, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4809) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4814), new DateTime(2025, 8, 13, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4814), "9607c2d3-bbfe-4913-b387-af077a5a6e30", new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 13, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4814) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4820), 11, new DateTime(2025, 8, 13, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4820), "20db737b-b0b2-4832-8201-6bb834693843", new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 13, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4820) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4824), 12, new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4824), "ad90f16c-5509-4565-bbc7-a966524b3096", new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4825) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4829), 11, new DateTime(2025, 8, 14, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4829), "7c5c0422-39b2-48a5-9586-df9477cbef9d", new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 14, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4829) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4835), 12, new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4835), "b1c97482-b7ca-4545-bda4-265efbe4831d", new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4835) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4839), new DateTime(2025, 8, 14, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4839), "74d735bb-021c-40aa-ad62-2b295bc17109", 2, new DateTime(2025, 8, 14, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4840) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4844), 11, new DateTime(2025, 8, 15, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4844), "ddd9dbde-b099-4796-870e-3bf7fd0d46be", new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 15, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4844) });

            migrationBuilder.InsertData(
                table: "Shifts",
                columns: new[] { "Id", "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "SelectedStatus", "ShiftDate", "ShiftType", "StartTime", "UpdatedComputerName", "UpdatedDate" },
                values: new object[,]
                {
                    { 86, new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4850), 12, new DateTime(2025, 8, 15, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4850), "93219543-8289-41d4-993a-c86abdff2845", 0, new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 15, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4850) },
                    { 87, new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4854), 11, new DateTime(2025, 8, 16, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4855), "d76a2870-38c7-4634-a5d9-608927b2199b", 0, new DateTime(2025, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 16, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4855) },
                    { 88, new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4860), 12, new DateTime(2025, 8, 16, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4861), "f136420f-6391-45da-84dd-4754c1214b96", 0, new DateTime(2025, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 16, 8, 0, 0, 0, DateTimeKind.Local), "DESKTOP-BC8DJ2E", new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4861) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "Reservations");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Lianastad", "Slovakia (Slovak Republic)", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(3894), "85154 Dickens Station, Port Cydney, Bulgaria", "2", "BG84ADFV006614G1925807", "500.831.7416 x12679", "Lance82@yahoo.com", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(3905), "Samanta", "Gerlach", "e12b2340-4cfa-4121-9b0f-df635c0c22b6", "54168", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(3905) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Keelytown", "Maldives", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(4774), "0048 O'Kon Bypass, Goodwinhaven, Guadeloupe", "6", "RS09676700558530337006", "916-365-6749 x072", "Felix.Ebert95@gmail.com", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(4774), "Bell", "Stamm", "53f811e1-22ec-43a7-8aee-d9660f805721", "06289-5895", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(4775) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Paucekberg", "Norfolk Island", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(4990), "27880 Dino Shoal, Allieview, Norfolk Island", "10", "LI403007332ZC750V04O6", "804.917.1977", "Edyth79@gmail.com", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(4990), "Arvilla", "Nitzsche", "a95d2666-e299-4902-a1ad-745dfb3afcf0", "32871-0120", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(4991) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Saigeside", "Swaziland", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(5176), "921 Marquardt Falls, West Ryley, Gambia", "11", "LU53005C6QG9R1034891", "950.491.2684", "Alexie_Lakin@gmail.com", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(5176), "Jevon", "Bailey", "b6e4cac4-494a-478d-877d-6bd8a987215c", "53777", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(5177) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Enatown", "Ecuador", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(5341), "208 Hackett Dam, Schmidtview, Israel", "11", "SM20Y00887002422691421A0P21", "1-678-268-1250 x199", "Kariane_Windler81@hotmail.com", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(5341), "Nick", "Connelly", "db3b2209-88a1-4334-9b90-2b4d1eea6538", "58350", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(5342) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "New Wavachester", "Iceland", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(5524), "077 Lesch Lodge, Katelynnmouth, French Guiana", "11", "ME91665006700833006396", "377.327.3141 x7190", "Corbin.Murazik73@yahoo.com", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(5524), "Tate", "Kirlin", "d512ceaa-01d3-4c65-afd7-fff739b5de9f", "42531", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(5524) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "New Lucyville", "Burundi", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(5689), "396 Cartwright Circles, West Brycen, Jordan", "10", "XK946478078600430774", "307-950-2423", "Cynthia87@gmail.com", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(5689), "Akeem", "Padberg", "96b74421-8c4d-4bf4-9947-f9012d2b66e3", "21587", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "East Catalina", "Chad", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(5839), "0197 Crist Glens, New Rollin, Saint Kitts and Nevis", "3", "QA54HYBC7Z6340U21445U04S3R732", "790-942-5228 x51279", "Kiarra.Nader31@yahoo.com", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(5839), "Major", "Gutkowski", "35238ac1-c11a-4787-a706-a3c6acd8b078", "18603", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "South Maximillian", "Bosnia and Herzegovina", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(6003), "092 Karl Road, East Dellafurt, El Salvador", "4", "TR480699519718Z34912927996", "(546) 392-4175 x37887", "Natalia.Jacobi@yahoo.com", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(6004), "Bella", "Greenfelder", "e16774bf-d9d6-401b-8451-42e0b8db6e88", "24801", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(6004) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Lake Germaine", "Cameroon", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(6167), "162 Waylon Terrace, East Korey, Slovenia", "5", "RO62MMLH468194NZQ4L30436", "(607) 438-8896", "Jacynthe.Cartwright10@gmail.com", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(6167), "Forrest", "Abbott", "622a96ef-324a-4833-a43d-53a0b759ebdf", "35721-3455", new DateTime(2025, 8, 8, 12, 57, 53, 7, DateTimeKind.Local).AddTicks(6168) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Tekirdağ", "Libya", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(9839), "Aladogan99@yahoo.com", "Atatürk Bulvarı 53a, Ağrı, Kuzey İrlanda", "Çağatay", "Koçoğlu", "+90-149-018-90-21", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(9842), "1530f17d-d15d-4aeb-83ab-d1838228dea9", "1", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(9842) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Erzurum", "Libya", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(511), "Bukusboga.Elmastasoglu77@yahoo.com", "Lütfi Karadirek Caddesi 52c, Kastamonu, Reunion, Fransa", "Barsurungu", "Arslanoğlu", "+90-901-571-02-53", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(512), "1a44ffd6-6728-434c-a08b-832104d2d251", "0", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(512) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Nevşehir", "Dominik Cumhuriyeti", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(653), "Aglamis72@yahoo.com", "Bandak Sokak 65b, Ordu, Gambiya", "Akboğa", "Aybar", "+90-937-731-1-191", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(653), "a16d91f0-947a-4a74-bf51-118b0c225c70", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(654) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Nevşehir", "Haiti", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(748), "Barcadogmus_Akisik@hotmail.com", "İbn-i Sina Sokak 25a, Ankara, Antigua ve Barbuda", "Alayunt", "Küçükler", "+90-545-629-5-808", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(748), "e6175c16-1b0d-4ff8-b5da-88f4e8b6d51a", "1", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Hatay", "Mayotte, Fransa", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(841), "Aki56@yahoo.com", "İsmet Paşa Caddesi 2, Balıkesir, Tunus", "Babur", "Numanoğlu", "+90-943-378-6-909", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(842), "a63aea0c-ee5d-40af-a2dc-ecccfa1824fe", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(842) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Şanlıurfa", "Brezilya", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(932), "Akkus_Orge@yahoo.com", "Fatih Sokak  95c, İçel (Mersin), Slovakya", "Atmaca", "Yalçın", "+90-140-645-1-259", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(932), "d9cf0a47-79f2-4beb-93fd-6f8bbc95b620", "0", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(933) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Bolu", "Özbekistan", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(1014), "Alpilig_Akisik@yahoo.com", "Dağınık Evler Sokak 75c, Şırnak, Tunus", "Çağru", "Günday", "+90-090-815-07-76", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(1015), "fbe6f83b-7704-4207-93ec-33d22c6604ad", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(1015) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Sakarya", "Vanuatu", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(7865), "Karaca_Adivar18@gmail.com", "Gül Sokak 76a, Bilecik, Reunion, Fransa", "Apak", "Gürmen", "+90-423-012-51-26", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(7866), "d8d6bffb-1bd0-4e32-821d-28d4511ab21d", "0", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(7866) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Yalova", "Kuzey Kore", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8143), "Ebin.Babaoglu@hotmail.com", "Bayır Sokak 3, Kars, Gambiya", "Bornak", "Sadıklar", "+90-736-178-93-82", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8143), "26190860-4ad5-4b47-b1ca-85cb07b3d48d", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8144) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Burdur", "Gine-Bissau", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8242), "Bazir.Kuzucu25@yahoo.com", "Atatürk Bulvarı 05a, Bursa, Almanya", "Çaba", "Tokgöz", "+90-806-435-42-48", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8242), "9b14d6c7-d035-4928-a55d-9e365383e416", "0", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8243) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Edirne", "Kazakistan", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8330), "Azak66@yahoo.com", "Okul Sokak 903, Giresun, Güney Georgia ve Güney Sandviç Adaları, İngiltere", "Karaca", "Numanoğlu", "+90-274-445-6-848", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8330), "b53d2f3c-0efc-40c3-a784-9e298717363c", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8331) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Iğdır", "Zambiya", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8413), "Gokcegol_Koybasi@yahoo.com", "Sarıkaya Caddesi 19c, Yozgat, Kolombiya", "Barlas", "Akal", "+90-406-049-68-31", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8414), "23a277e9-7096-47c0-be77-88667977dfdc", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8414) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Niğde", "Sırbistan", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8497), "Barbulsun_Corekci@yahoo.com", "Ali Çetinkaya Caddesi 14b, Tunceli, Santa Kitts ve Nevis", "Bozkuş", "Koçoğlu", "+90-124-176-58-30", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8498), "840d85db-26e8-4de3-afc9-e8e53ebf57d2", "1", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8498) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Çankırı", "El Salvador", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8590), "Barbeg.Okur29@yahoo.com", "Tevfik Fikret Caddesi 275, Isparta, Grönland", "Bilgetamgacı", "Egeli", "+90-740-251-2-282", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8590), "0c93647b-524b-4e28-a0d0-0aa079cf9aa2", "1", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Muğla", "Gürcistan H", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8665), "Barkin63@hotmail.com", "Harman Yolu Sokak  73b, Rize, Svaziland", "Karak", "Karabulut", "+90-528-292-64-89", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8666), "ee1aaddd-e535-4aec-bbe2-bb5f7f67dcaf", "1", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8666) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Edirne", "Azerbaycan", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8742), "Arademir_Babacan8@gmail.com", "Gül Sokak 6, Balıkesir, Suudi Arabistan", "Kançı", "Tekelioğlu", "+90-463-128-84-01", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8743), "f621d790-472b-4800-ae4c-f184ddda2fa7", "0", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Malatya", "Cezayir", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8828), "Bek3@hotmail.com", "Tevfik Fikret Caddesi 34, Ağrı, Hırvatistan", "Kırlangıç", "Erberk", "+90-620-767-9-974", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8828), "6f973a85-1407-48d1-9087-0be294bc8c7c", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "K.maraş", "Uganda", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8907), "Bugrakarakagan.Egeli60@gmail.com", "Atatürk Bulvarı 09c, Manisa, Mısır", "Benlidemir", "Yazıcı", "+90-793-041-98-95", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8908), "c5f09b28-d88c-42d2-941c-edf30393755a", "1", new DateTime(2025, 8, 8, 12, 57, 53, 89, DateTimeKind.Local).AddTicks(8908) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Bolu", "Güney Kıbrıs Rum Yönetimi", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(783), "Bekbekec_Akgul@gmail.com", "Bayır Sokak 4, Samsun, Venezuela", "Ermen", "Balcı", "+90-233-701-5-015", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(788), "b68c32cf-c51b-4257-8bc7-88b3ad3fff9a", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(789) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Adıyaman", "Endonezya", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(5170), "Ardic24@gmail.com", "Mevlana Sokak 14a, Kilis, İran", "Belgi", "Velioğlu", "+90-917-113-2-928", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(5173), "91a21ad7-45b2-4ff3-bddb-b5ae1a29600b", "1", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(5174) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Bartın", "Botswana", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(5387), "Akata54@hotmail.com", "Gül Sokak 39b, Antalya, Paraguay", "Barlıbay", "Kurutluoğlu", "+90-600-464-55-96", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(5388), "013879c0-8beb-4660-8aba-7132992e9571", "0", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(5388) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Giresun", "Birmanya (Myanmar)", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(5513), "Bukak.Turkyilmaz47@gmail.com", "Kerimoğlu Sokak 258, Ordu, Christmas Adası , Avusturalya", "Aldıgerey", "Pekkan", "+90-782-344-2-068", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(5514), "021cf92d-72c5-4401-a281-36b44fff29c6", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(5514) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Kütahya", "Burkina Faso", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(5652), "Bakirsokum.Akgul24@gmail.com", "Güven Yaka Sokak 90c, Nevşehir, Brezilya", "Bağatur", "Korol", "+90-774-397-22-37", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(5653), "fff2db5c-f001-44ce-8e7c-2d872fdb6db4", "1", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(5653) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Çankırı", "Nijer", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(5773), "Basut_Ozkok@gmail.com", "Alparslan Türkeş Bulvarı 84b, Bolu, Singapur", "Bozan", "Kıraç ", "+90-202-111-16-04", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(5774), "3e32c5a9-2988-4522-ae63-89bd32236be2", "0", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(5774) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Balıkesir", "Cayman Adaları, İngiltere", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(5897), "Bilgetacam_Yildizoglu45@gmail.com", "Kaldırım Sokak 6, Manisa, Kanada", "Aprançur", "Türkdoğan", "+90-516-139-55-29", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(5897), "217f9ee0-d302-4fd2-9fc8-f768178f9758", "1", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(5898) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Ardahan", "Fas", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(6027), "Abak_Barbarosoglu@hotmail.com", "Gül Sokak 74, Sinop, Kamerun", "Alpurungututuk", "Sandalcı", "+90-394-731-7-595", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(6027), "dadfb48b-9f0d-444f-a6b4-67c6d70f5ec2", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(6028) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "K.maraş", "Vallis ve Futuna, Fransa", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(6146), "Katunkiz84@yahoo.com", "Tevfik Fikret Caddesi 16c, Muğla, Amerikan Samoa", "Barbeğ", "Karaer", "+90-887-402-03-60", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(6146), "5488ff68-e922-4039-880c-6ff6aeab0976", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(6147) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Rize", "Saint Pierre ve Miquelon, Fransa", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(6280), "Asikbulmus.Poyrazoglu@hotmail.com", "Saygılı Sokak 18b, Ordu, Mauritius", "Katunkız", "Sezek", "+90-062-771-79-05", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(6280), "8ce09946-2a9b-47c9-8fc4-e2a12b5a4ab0", "1", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(6281) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Diyarbakır", "İzlanda", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(6407), "Biligkongulsengun.Akbulut@yahoo.com", "Ülkü Sokak 87c, Ankara, Makau (Makao)", "Baçman", "Numanoğlu", "+90-979-859-33-11", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(6408), "84c3d4a8-aa42-4f64-9767-171137a5989e", new DateTime(2025, 8, 8, 12, 57, 53, 91, DateTimeKind.Local).AddTicks(6408) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Giresun", "Gambiya", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(7265), "Bogde94@hotmail.com", "Sevgi Sokak 818, Karaman, Uruguay", "Beğdemir", "Kuday", "+90-812-094-01-14", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(7269), "f437d655-a845-4e04-979a-bd5153983a17", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(7270) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Sinop", "Uruguay", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(7845), "Borubars19@hotmail.com", "Dağınık Evler Sokak 7, Elazığ, Arjantin", "Alpagut", "Erberk", "+90-055-475-0-204", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(7846), "9ff37e69-115e-4928-9bfd-0b4d8f265537", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Kilis", "Kamboçya", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8002), "Bortecine30@gmail.com", "İsmet Paşa Caddesi 9, Kırklareli, İsviçre", "Altankağan", "Abacı", "+90-035-952-19-15", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8002), "56115d0c-d130-4fb6-bdfa-176c936192fe", "1", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8003) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Giresun", "Brunei", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8136), "Altay96@hotmail.com", "Sıran Söğüt Sokak 53, Van, Seyşeller", "Aşkın", "Erbulak", "+90-399-931-76-48", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8137), "b425a7a7-780e-4d09-929d-f3c1a8a9098f", "1", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8137) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Burdur", "Panama", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8264), "Alptegin.Sayginer@gmail.com", "Fatih Sokak  63b, Çankırı, Turks ve Caicos Adaları, İngiltere", "Böke", "Adal", "+90-226-172-6-300", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8265), "9d70b7c9-c6ec-4f0c-af54-6b7fe779d7f5", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8265) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Muğla", "Avusturya", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8401), "Agakagan_Ozkok@yahoo.com", "Menekşe Sokak 47a, Tekirdağ, Haiti", "Esen", "Beşerler", "+90-145-166-11-75", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8401), "db6d7418-52c2-4eb2-8756-6d063106410a", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8402) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Sinop", "Gabon", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8538), "Abaka_Hakyemez34@gmail.com", "Ülkü Sokak 4, Erzincan, Çin", "Bayık", "Karadaş", "+90-253-278-9-300", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8539), "d9bdb59c-e188-410c-a95c-71da9b54b1f2", "1", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8539) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Ardahan", "Paraguay", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8665), "Gokce.Ozdogan55@gmail.com", "Fatih Sokak  56, Bartın, Johnston Atoll, Amerika", "Çolpan", "Öymen", "+90-936-641-3-778", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8666), "fb978233-633e-4abe-aebd-611b7253cddc", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8666) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "İçel (Mersin)", "Brunei", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8777), "Astalogul_Kunt55@hotmail.com", "Gül Sokak 911, Adana, Guatemala", "Begitutuk", "Gümüşpala", "+90-397-943-8-113", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8778), "ee888ac7-aa63-4edb-9849-9684e3b0eb6a", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Çankırı", "Belize", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8942), "Bazir.Yorulmaz29@yahoo.com", "Nalbant Sokak 962, Van, Hollanda", "Aykağan", "Çağıran", "+90-814-027-3-469", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8943), "47c30a54-ee91-4dd2-81e2-4efb74b785d3", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(8943) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Kütahya", "Folkland Adaları, İngiltere", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(9076), "Altinkan.Hamzaoglu@hotmail.com", "Menekşe Sokak 159, Tokat, Porto Riko, Amerika", "Bilgetonyukuk", "Karabulut", "+90-414-265-47-83", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(9076), "59c50a95-87ac-4a43-8e6f-ea632a4386dc", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(9077) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "City", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Kırşehir", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(9356), "Adikutlutas.Aclan@hotmail.com", "Oğuzhan Sokak 791, İzmir, Lübnan", "Böge", "Ayverdi", "+90-304-817-55-08", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(9356), "d068bde8-67a0-4971-8b9b-28c876b5cd72", "0", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(9357) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Aydın", "Litvanya", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(9486), "Bukebuyrac77@hotmail.com", "Güven Yaka Sokak 02c, Gümüşhane, Somali", "Abar", "Tahincioğlu", "+90-991-190-27-95", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(9487), "fff67ec1-7ee4-4ebd-96de-196672b7e945", "0", new DateTime(2025, 8, 8, 12, 57, 53, 92, DateTimeKind.Local).AddTicks(9487) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Tunceli", "Norveç", new DateTime(2025, 8, 8, 12, 57, 53, 94, DateTimeKind.Local).AddTicks(2554), "Alpertunga_Topcuoglu59@gmail.com", "Tevfik Fikret Caddesi 47, Ardahan, Kuzey İrlanda", "Armağan", "Doğan ", "+90-264-153-2-974", new DateTime(2025, 8, 8, 12, 57, 53, 94, DateTimeKind.Local).AddTicks(2558), "87eb72b8-2114-4c0b-8085-752eabed9c5c", new DateTime(2025, 8, 8, 12, 57, 53, 94, DateTimeKind.Local).AddTicks(2558) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Tekirdağ", "İzlanda", new DateTime(2025, 8, 8, 12, 57, 53, 95, DateTimeKind.Local).AddTicks(4062), "Alpertunga_Akgul@yahoo.com", "Fatih Sokak  20b, Bolu, Gana", "Arslan", "Sepetçi", "+90-489-314-5-056", new DateTime(2025, 8, 8, 12, 57, 53, 95, DateTimeKind.Local).AddTicks(4066), "ac690689-136c-46ae-881b-371f4f1dee7c", "1", new DateTime(2025, 8, 8, 12, 57, 53, 95, DateTimeKind.Local).AddTicks(4067) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(7678), new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(7683), 620.38m, new DateTime(2025, 5, 31, 23, 4, 13, 578, DateTimeKind.Local).AddTicks(4319), "Non necessitatibus modi est consequatur perspiciatis quod magnam magnam repudiandae.", "Unbranded Soft Pants", "4912855f-cd15-454e-981d-5bca229535f3", new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(7683) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(7898), new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(7898), 766.91m, new DateTime(2025, 2, 14, 21, 13, 43, 88, DateTimeKind.Local).AddTicks(3290), "İusto nihil eius natus perferendis similique.", "Unbranded Cotton Sausages", "e818e884-226b-4de0-971b-f465b986df45", 3, new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(7899) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(7941), new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(7941), 312.41m, new DateTime(2024, 8, 15, 12, 49, 15, 98, DateTimeKind.Local).AddTicks(1310), "Ullam quisquam dolor accusantium voluptatem dolores labore.", "Small Granite Soap", "5419a93c-b8cc-44ec-80a8-bb1ebd078998", 10, new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(7941) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(7974), new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(7975), 637.93m, new DateTime(2025, 5, 4, 13, 19, 25, 54, DateTimeKind.Local).AddTicks(2493), "Velit vel dolor aut vero ab vel qui et.", "Small Granite Pizza", "74a42255-8293-4646-b1ae-b9a0c65da986", 6, new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(7975) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(8012), new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(8012), 813.11m, new DateTime(2025, 7, 7, 11, 4, 33, 8, DateTimeKind.Local).AddTicks(8776), "Voluptatem rem ut veritatis ipsa facere cum ut.", "Handcrafted Frozen Bacon", "b5fbce5d-1bb8-4616-aa59-d7903cda7b72", 5, new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(8012) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(8046), new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(8047), 798.61m, new DateTime(2024, 10, 12, 11, 14, 41, 792, DateTimeKind.Local).AddTicks(6351), "Ea cumque exercitationem mollitia aspernatur quia sint illo sunt.", "Handcrafted Steel Chicken", "f4878c54-852f-4122-b05f-48f50212221a", 2, new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(8081), new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(8082), 910.47m, new DateTime(2024, 10, 23, 7, 21, 56, 38, DateTimeKind.Local).AddTicks(820), "Aut dolores ut ut ipsum labore adipisci delectus ducimus.", "Generic Steel Mouse", "20178d84-7e4f-40f3-ab7a-4f5d544ca5ee", 9, new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(8082) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(8114), new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(8114), 945.10m, new DateTime(2025, 2, 17, 23, 52, 39, 365, DateTimeKind.Local).AddTicks(4588), "Ab debitis rem praesentium.", "Awesome Concrete Car", "f3ad3be6-6e37-4bd8-bbbc-8abf284598c6", 10, new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(8138), new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(8138), 358.93m, new DateTime(2024, 10, 8, 7, 11, 5, 296, DateTimeKind.Local).AddTicks(6474), "Recusandae ut et natus quae autem et.", "Ergonomic Wooden Ball", "9e2c382e-3bb9-4d71-ba33-2bb8f3ba5786", 7, new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(8138) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(8165), new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(8165), 813.00m, new DateTime(2025, 7, 24, 7, 7, 32, 207, DateTimeKind.Local).AddTicks(4243), "Ut cumque vitae.", "Gorgeous Granite Sausages", "cfe58693-c708-47ff-bc06-9c8983c8425e", 4, new DateTime(2025, 8, 8, 12, 57, 53, 87, DateTimeKind.Local).AddTicks(8166) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 11, 23, 0, 3, 18, 211, DateTimeKind.Local).AddTicks(7245), new DateTime(2026, 9, 1, 20, 0, 22, 403, DateTimeKind.Local).AddTicks(127), new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(8816), 4, new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(8817), "d8622786-7268-449d-9cd1-878c07291ee7", 2, 2213.45m, new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(8818) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 8, 2, 6, 55, 16, 377, DateTimeKind.Local).AddTicks(8330), new DateTime(2027, 7, 6, 3, 36, 23, 241, DateTimeKind.Local).AddTicks(9008), new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9228), new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9228), "7822f192-033a-4e88-a3a6-ef6a8b4bcd56", 34, 1959.22m, new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9229) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 5, 3, 21, 55, 28, 40, DateTimeKind.Local).AddTicks(6156), new DateTime(2026, 8, 8, 20, 43, 16, 8, DateTimeKind.Local).AddTicks(2163), new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9331), 5, new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9331), "7aa31c93-de45-4aff-b022-2c378161ca9f", 44, 1589.91m, new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 9, 29, 17, 50, 25, 386, DateTimeKind.Local).AddTicks(7402), new DateTime(2026, 1, 20, 5, 56, 5, 117, DateTimeKind.Local).AddTicks(5507), new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9357), 3, new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9357), "79ce297d-cbe7-48c3-ae6c-a1b8ddc25aef", 38, 1710.44m, new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9357) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 10, 3, 38, 38, 730, DateTimeKind.Local).AddTicks(3260), new DateTime(2027, 3, 4, 9, 44, 10, 473, DateTimeKind.Local).AddTicks(7695), new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9382), 5, new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9382), "cf3b33c0-dea4-419d-a8f1-773c674979b2", 16, 1733.10m, new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9382) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 9, 24, 6, 14, 4, 312, DateTimeKind.Local).AddTicks(9562), new DateTime(2026, 4, 22, 15, 40, 3, 431, DateTimeKind.Local).AddTicks(6105), new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9407), 3, new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9407), "4af55c3e-5c95-4a93-9367-7789d6e1d800", 18, 1567.47m, new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 5, 25, 12, 37, 34, 600, DateTimeKind.Local).AddTicks(4344), new DateTime(2026, 6, 15, 18, 4, 51, 620, DateTimeKind.Local).AddTicks(5389), new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9432), 10, new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9433), "f2fa75f5-06b9-464d-8a3e-e18e227307de", 20, 2326.20m, new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9433) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 16, 2, 23, 9, 678, DateTimeKind.Local).AddTicks(4791), new DateTime(2026, 10, 5, 12, 26, 4, 244, DateTimeKind.Local).AddTicks(6009), new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9457), new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9458), "6463386a-4c23-49c9-91c9-352d65f5b774", 44, 2101.44m, new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9458) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 6, 5, 0, 18, 10, 614, DateTimeKind.Local).AddTicks(5153), new DateTime(2027, 1, 28, 20, 22, 49, 612, DateTimeKind.Local).AddTicks(5385), new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9483), 7, new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9484), "723081e6-13b8-46c4-9978-f3ab35c2f43f", 17, 1805.58m, new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 6, 23, 21, 22, 21, 950, DateTimeKind.Local).AddTicks(5238), new DateTime(2027, 3, 29, 6, 23, 5, 898, DateTimeKind.Local).AddTicks(7493), new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9509), 5, new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9509), "e6645de4-d0aa-4155-9f47-a3b6561c9712", 43, 1635.22m, new DateTime(2025, 8, 8, 12, 57, 53, 96, DateTimeKind.Local).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 9, DateTimeKind.Local).AddTicks(2398), new DateTime(2025, 8, 8, 12, 57, 53, 9, DateTimeKind.Local).AddTicks(2405), "f795e9e1-8464-40b8-a7eb-3a30ba7baf94", new DateTime(2025, 8, 8, 12, 57, 53, 9, DateTimeKind.Local).AddTicks(2405) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 10, DateTimeKind.Local).AddTicks(1894), new DateTime(2025, 8, 8, 12, 57, 53, 10, DateTimeKind.Local).AddTicks(1896), "39abfcef-a3a4-4b15-8bc8-490cf32df06b", new DateTime(2025, 8, 8, 12, 57, 53, 10, DateTimeKind.Local).AddTicks(1897) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 11, DateTimeKind.Local).AddTicks(1396), new DateTime(2025, 8, 8, 12, 57, 53, 11, DateTimeKind.Local).AddTicks(1399), "236e5e4a-754d-4898-9cd3-a535a097303e", new DateTime(2025, 8, 8, 12, 57, 53, 11, DateTimeKind.Local).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 11, DateTimeKind.Local).AddTicks(9392), new DateTime(2025, 8, 8, 12, 57, 53, 11, DateTimeKind.Local).AddTicks(9395), "74374b30-2552-46b4-aea6-eed685901b27", new DateTime(2025, 8, 8, 12, 57, 53, 11, DateTimeKind.Local).AddTicks(9396) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 12, DateTimeKind.Local).AddTicks(9015), new DateTime(2025, 8, 8, 12, 57, 53, 12, DateTimeKind.Local).AddTicks(9017), "b60a13b0-4db8-4da5-9fac-b873e554ed84", new DateTime(2025, 8, 8, 12, 57, 53, 12, DateTimeKind.Local).AddTicks(9017) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 13, DateTimeKind.Local).AddTicks(8172), new DateTime(2025, 8, 8, 12, 57, 53, 13, DateTimeKind.Local).AddTicks(8176), "ac9697b6-5cb0-4743-91c7-bd6860c7c247", new DateTime(2025, 8, 8, 12, 57, 53, 13, DateTimeKind.Local).AddTicks(8176) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 14, DateTimeKind.Local).AddTicks(7032), new DateTime(2025, 8, 8, 12, 57, 53, 14, DateTimeKind.Local).AddTicks(7033), "f355703c-a706-4068-8d52-18225eebc911", new DateTime(2025, 8, 8, 12, 57, 53, 14, DateTimeKind.Local).AddTicks(7034) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 15, DateTimeKind.Local).AddTicks(9504), new DateTime(2025, 8, 8, 12, 57, 53, 15, DateTimeKind.Local).AddTicks(9508), "76ac2fcd-77d7-437c-ae5a-d9d8b32268b1", new DateTime(2025, 8, 8, 12, 57, 53, 15, DateTimeKind.Local).AddTicks(9508) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 26, DateTimeKind.Local).AddTicks(8075), new DateTime(2025, 8, 8, 12, 57, 53, 26, DateTimeKind.Local).AddTicks(8085), "1d40b396-5c57-4b8f-8b9d-8d32879abeee", new DateTime(2025, 8, 8, 12, 57, 53, 26, DateTimeKind.Local).AddTicks(8086) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 27, DateTimeKind.Local).AddTicks(8399), new DateTime(2025, 8, 8, 12, 57, 53, 27, DateTimeKind.Local).AddTicks(8404), "fab16e72-8ef7-4342-be90-d1e2745fb554", new DateTime(2025, 8, 8, 12, 57, 53, 27, DateTimeKind.Local).AddTicks(8405) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 29, DateTimeKind.Local).AddTicks(8006), new DateTime(2025, 8, 8, 12, 57, 53, 29, DateTimeKind.Local).AddTicks(8012), "b500b60a-52d0-4b1e-9461-5a17f265b6c5", new DateTime(2025, 8, 8, 12, 57, 53, 29, DateTimeKind.Local).AddTicks(8013) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 30, DateTimeKind.Local).AddTicks(8596), new DateTime(2025, 8, 8, 12, 57, 53, 30, DateTimeKind.Local).AddTicks(8600), "bce7e30b-2215-4d8a-b827-01ddbccf8994", new DateTime(2025, 8, 8, 12, 57, 53, 30, DateTimeKind.Local).AddTicks(8601) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 32, DateTimeKind.Local).AddTicks(973), new DateTime(2025, 8, 8, 12, 57, 53, 32, DateTimeKind.Local).AddTicks(979), "2e673749-5a8a-47e5-8cc2-5a343de1d554", new DateTime(2025, 8, 8, 12, 57, 53, 32, DateTimeKind.Local).AddTicks(979) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 32, DateTimeKind.Local).AddTicks(9108), new DateTime(2025, 8, 8, 12, 57, 53, 32, DateTimeKind.Local).AddTicks(9112), "2a839ae5-a524-46db-a3e2-3d4eb20c77d7", new DateTime(2025, 8, 8, 12, 57, 53, 32, DateTimeKind.Local).AddTicks(9112) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 33, DateTimeKind.Local).AddTicks(8308), new DateTime(2025, 8, 8, 12, 57, 53, 33, DateTimeKind.Local).AddTicks(8312), "312e8e8a-23e0-4817-a281-10349458f67b", new DateTime(2025, 8, 8, 12, 57, 53, 33, DateTimeKind.Local).AddTicks(8313) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 34, DateTimeKind.Local).AddTicks(8861), new DateTime(2025, 8, 8, 12, 57, 53, 34, DateTimeKind.Local).AddTicks(8865), "032261cd-ee50-41cc-8011-10a5ae8f8b40", new DateTime(2025, 8, 8, 12, 57, 53, 34, DateTimeKind.Local).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 36, DateTimeKind.Local).AddTicks(2626), new DateTime(2025, 8, 8, 12, 57, 53, 36, DateTimeKind.Local).AddTicks(2631), "42afceab-4cdb-4a0a-9911-f5241b9dae17", new DateTime(2025, 8, 8, 12, 57, 53, 36, DateTimeKind.Local).AddTicks(2632) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 37, DateTimeKind.Local).AddTicks(993), new DateTime(2025, 8, 8, 12, 57, 53, 37, DateTimeKind.Local).AddTicks(996), "7d13dbc1-b603-4eed-8dca-c653dae035cf", new DateTime(2025, 8, 8, 12, 57, 53, 37, DateTimeKind.Local).AddTicks(997) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 37, DateTimeKind.Local).AddTicks(8524), new DateTime(2025, 8, 8, 12, 57, 53, 37, DateTimeKind.Local).AddTicks(8527), "7710ed51-3d08-4c63-a54b-d51467f62ac8", new DateTime(2025, 8, 8, 12, 57, 53, 37, DateTimeKind.Local).AddTicks(8528) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 38, DateTimeKind.Local).AddTicks(7369), new DateTime(2025, 8, 8, 12, 57, 53, 38, DateTimeKind.Local).AddTicks(7373), "1818e7b6-ab17-4c16-a8c5-0e74ade34e19", new DateTime(2025, 8, 8, 12, 57, 53, 38, DateTimeKind.Local).AddTicks(7373) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 39, DateTimeKind.Local).AddTicks(6875), new DateTime(2025, 8, 8, 12, 57, 53, 39, DateTimeKind.Local).AddTicks(6878), "2a2dbcf9-5367-43a5-97b3-ad50123a6d68", new DateTime(2025, 8, 8, 12, 57, 53, 39, DateTimeKind.Local).AddTicks(6879) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 40, DateTimeKind.Local).AddTicks(6137), new DateTime(2025, 8, 8, 12, 57, 53, 40, DateTimeKind.Local).AddTicks(6140), "52807bff-97ed-4928-a76e-8fd730dec266", new DateTime(2025, 8, 8, 12, 57, 53, 40, DateTimeKind.Local).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 41, DateTimeKind.Local).AddTicks(5663), new DateTime(2025, 8, 8, 12, 57, 53, 41, DateTimeKind.Local).AddTicks(5666), "4ca2a5ab-51b6-4ab7-bf20-1bfc2f5bd087", new DateTime(2025, 8, 8, 12, 57, 53, 41, DateTimeKind.Local).AddTicks(5667) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 42, DateTimeKind.Local).AddTicks(4974), new DateTime(2025, 8, 8, 12, 57, 53, 42, DateTimeKind.Local).AddTicks(4975), "c33a80e2-6e6c-41ac-9989-e2604fb75564", new DateTime(2025, 8, 8, 12, 57, 53, 42, DateTimeKind.Local).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 45, DateTimeKind.Local).AddTicks(3077), new DateTime(2025, 8, 8, 12, 57, 53, 45, DateTimeKind.Local).AddTicks(3084), "1c85a1cf-1fd8-485a-b813-6eda80e699ce", new DateTime(2025, 8, 8, 12, 57, 53, 45, DateTimeKind.Local).AddTicks(3085) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 46, DateTimeKind.Local).AddTicks(136), new DateTime(2025, 8, 8, 12, 57, 53, 46, DateTimeKind.Local).AddTicks(139), "94c619a7-9b17-43aa-b928-c491e97ba1c1", new DateTime(2025, 8, 8, 12, 57, 53, 46, DateTimeKind.Local).AddTicks(139) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 46, DateTimeKind.Local).AddTicks(6470), new DateTime(2025, 8, 8, 12, 57, 53, 46, DateTimeKind.Local).AddTicks(6471), "f53b721f-db14-435f-8787-8bb5e51100b6", new DateTime(2025, 8, 8, 12, 57, 53, 46, DateTimeKind.Local).AddTicks(6471) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 47, DateTimeKind.Local).AddTicks(3041), new DateTime(2025, 8, 8, 12, 57, 53, 47, DateTimeKind.Local).AddTicks(3041), "a53de25c-0a99-4ae0-9f55-b20d648128db", new DateTime(2025, 8, 8, 12, 57, 53, 47, DateTimeKind.Local).AddTicks(3041) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 47, DateTimeKind.Local).AddTicks(9760), new DateTime(2025, 8, 8, 12, 57, 53, 47, DateTimeKind.Local).AddTicks(9762), "7917743c-c838-421b-b5cb-96f0c0cb325d", new DateTime(2025, 8, 8, 12, 57, 53, 47, DateTimeKind.Local).AddTicks(9763) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 48, DateTimeKind.Local).AddTicks(5934), new DateTime(2025, 8, 8, 12, 57, 53, 48, DateTimeKind.Local).AddTicks(5935), "da962b47-a23d-4cdd-a400-c744beeb4263", new DateTime(2025, 8, 8, 12, 57, 53, 48, DateTimeKind.Local).AddTicks(5935) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 49, DateTimeKind.Local).AddTicks(2639), new DateTime(2025, 8, 8, 12, 57, 53, 49, DateTimeKind.Local).AddTicks(2642), "7c4d3b6f-1e99-47af-8d42-f9934c0e0aad", new DateTime(2025, 8, 8, 12, 57, 53, 49, DateTimeKind.Local).AddTicks(2642) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 50, DateTimeKind.Local).AddTicks(5965), new DateTime(2025, 8, 8, 12, 57, 53, 50, DateTimeKind.Local).AddTicks(5969), "e6d5f2a3-f19a-408d-8bff-ad36e140001d", new DateTime(2025, 8, 8, 12, 57, 53, 50, DateTimeKind.Local).AddTicks(5969) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 51, DateTimeKind.Local).AddTicks(2452), new DateTime(2025, 8, 8, 12, 57, 53, 51, DateTimeKind.Local).AddTicks(2453), "1de98cde-d2f1-4df9-a615-c6cb1b7e4606", new DateTime(2025, 8, 8, 12, 57, 53, 51, DateTimeKind.Local).AddTicks(2453) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 51, DateTimeKind.Local).AddTicks(8863), new DateTime(2025, 8, 8, 12, 57, 53, 51, DateTimeKind.Local).AddTicks(8866), "0c5495df-79c7-421c-924a-822f675663ec", new DateTime(2025, 8, 8, 12, 57, 53, 51, DateTimeKind.Local).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 52, DateTimeKind.Local).AddTicks(5228), new DateTime(2025, 8, 8, 12, 57, 53, 52, DateTimeKind.Local).AddTicks(5229), "91fc2784-359f-4501-9976-b51cc1f0d40b", new DateTime(2025, 8, 8, 12, 57, 53, 52, DateTimeKind.Local).AddTicks(5229) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 53, DateTimeKind.Local).AddTicks(1546), new DateTime(2025, 8, 8, 12, 57, 53, 53, DateTimeKind.Local).AddTicks(1547), "ddba2f2a-1ea9-48ce-aff5-66a4b862f23a", new DateTime(2025, 8, 8, 12, 57, 53, 53, DateTimeKind.Local).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 53, DateTimeKind.Local).AddTicks(7934), new DateTime(2025, 8, 8, 12, 57, 53, 53, DateTimeKind.Local).AddTicks(7937), "58f1d12d-8f0f-4db8-b101-4997f7fa2958", new DateTime(2025, 8, 8, 12, 57, 53, 53, DateTimeKind.Local).AddTicks(7938) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 54, DateTimeKind.Local).AddTicks(4336), new DateTime(2025, 8, 8, 12, 57, 53, 54, DateTimeKind.Local).AddTicks(4337), "d9b89f55-049d-41a1-8828-acd36b093549", new DateTime(2025, 8, 8, 12, 57, 53, 54, DateTimeKind.Local).AddTicks(4337) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 55, DateTimeKind.Local).AddTicks(764), new DateTime(2025, 8, 8, 12, 57, 53, 55, DateTimeKind.Local).AddTicks(765), "e121dbbd-8296-4292-aa24-0f49a604c677", new DateTime(2025, 8, 8, 12, 57, 53, 55, DateTimeKind.Local).AddTicks(765) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 55, DateTimeKind.Local).AddTicks(7138), new DateTime(2025, 8, 8, 12, 57, 53, 55, DateTimeKind.Local).AddTicks(7141), "f6a944a8-fd79-4303-8841-794c9b8e44ab", new DateTime(2025, 8, 8, 12, 57, 53, 55, DateTimeKind.Local).AddTicks(7141) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 59, DateTimeKind.Local).AddTicks(493), new DateTime(2025, 8, 8, 12, 57, 53, 59, DateTimeKind.Local).AddTicks(499), "5fda8e39-7a6c-4ecf-91a5-02f9cd828f6b", new DateTime(2025, 8, 8, 12, 57, 53, 59, DateTimeKind.Local).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 60, DateTimeKind.Local).AddTicks(2181), new DateTime(2025, 8, 8, 12, 57, 53, 60, DateTimeKind.Local).AddTicks(2186), "d1b638a5-d7bb-4058-b03d-f537a095b0af", new DateTime(2025, 8, 8, 12, 57, 53, 60, DateTimeKind.Local).AddTicks(2187) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 61, DateTimeKind.Local).AddTicks(1514), new DateTime(2025, 8, 8, 12, 57, 53, 61, DateTimeKind.Local).AddTicks(1516), "b1f78d20-eb83-434e-95a1-352a588b09e8", new DateTime(2025, 8, 8, 12, 57, 53, 61, DateTimeKind.Local).AddTicks(1517) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 62, DateTimeKind.Local).AddTicks(901), new DateTime(2025, 8, 8, 12, 57, 53, 62, DateTimeKind.Local).AddTicks(904), "4a45de28-d911-4813-b595-b410e0c5871d", new DateTime(2025, 8, 8, 12, 57, 53, 62, DateTimeKind.Local).AddTicks(905) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 63, DateTimeKind.Local).AddTicks(111), new DateTime(2025, 8, 8, 12, 57, 53, 63, DateTimeKind.Local).AddTicks(113), "c277158e-71e8-40d1-bcbd-aa37aba9182f", new DateTime(2025, 8, 8, 12, 57, 53, 63, DateTimeKind.Local).AddTicks(114) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 64, DateTimeKind.Local).AddTicks(4611), new DateTime(2025, 8, 8, 12, 57, 53, 64, DateTimeKind.Local).AddTicks(4614), "6b301c82-7f04-4322-9117-075f3b916f2a", new DateTime(2025, 8, 8, 12, 57, 53, 64, DateTimeKind.Local).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 65, DateTimeKind.Local).AddTicks(1164), new DateTime(2025, 8, 8, 12, 57, 53, 65, DateTimeKind.Local).AddTicks(1165), "52e5e702-20f9-4d90-a80b-5f384478975e", new DateTime(2025, 8, 8, 12, 57, 53, 65, DateTimeKind.Local).AddTicks(1165) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 65, DateTimeKind.Local).AddTicks(7590), new DateTime(2025, 8, 8, 12, 57, 53, 65, DateTimeKind.Local).AddTicks(7593), "563f41b9-fcaf-47db-b799-70be164480cf", new DateTime(2025, 8, 8, 12, 57, 53, 65, DateTimeKind.Local).AddTicks(7594) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 66, DateTimeKind.Local).AddTicks(4112), new DateTime(2025, 8, 8, 12, 57, 53, 66, DateTimeKind.Local).AddTicks(4113), "ab82d2b7-52d5-4d38-9cc9-2412d35868e8", new DateTime(2025, 8, 8, 12, 57, 53, 66, DateTimeKind.Local).AddTicks(4113) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 67, DateTimeKind.Local).AddTicks(534), new DateTime(2025, 8, 8, 12, 57, 53, 67, DateTimeKind.Local).AddTicks(534), "ff6b5802-ced6-4d12-a63e-3616b5cd4772", new DateTime(2025, 8, 8, 12, 57, 53, 67, DateTimeKind.Local).AddTicks(535) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 67, DateTimeKind.Local).AddTicks(6907), new DateTime(2025, 8, 8, 12, 57, 53, 67, DateTimeKind.Local).AddTicks(6909), "066564c1-a5c0-4302-a460-9aa2f8208ee9", new DateTime(2025, 8, 8, 12, 57, 53, 67, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 68, DateTimeKind.Local).AddTicks(3374), new DateTime(2025, 8, 8, 12, 57, 53, 68, DateTimeKind.Local).AddTicks(3375), "275007a8-74e8-45c0-9561-e9676bc6e16b", new DateTime(2025, 8, 8, 12, 57, 53, 68, DateTimeKind.Local).AddTicks(3375) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 68, DateTimeKind.Local).AddTicks(9709), new DateTime(2025, 8, 8, 12, 57, 53, 68, DateTimeKind.Local).AddTicks(9710), "ab01ec16-f6ed-43a5-b9cd-7592ac8a2f34", new DateTime(2025, 8, 8, 12, 57, 53, 68, DateTimeKind.Local).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 69, DateTimeKind.Local).AddTicks(5757), new DateTime(2025, 8, 8, 12, 57, 53, 69, DateTimeKind.Local).AddTicks(5758), "a89176c0-5f8c-48b4-bdb9-256994afe06d", new DateTime(2025, 8, 8, 12, 57, 53, 69, DateTimeKind.Local).AddTicks(5758) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 70, DateTimeKind.Local).AddTicks(2368), new DateTime(2025, 8, 8, 12, 57, 53, 70, DateTimeKind.Local).AddTicks(2372), "d14d6511-884e-40c9-8d8a-240286d4fab3", new DateTime(2025, 8, 8, 12, 57, 53, 70, DateTimeKind.Local).AddTicks(2372) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 71, DateTimeKind.Local).AddTicks(4137), new DateTime(2025, 8, 8, 12, 57, 53, 71, DateTimeKind.Local).AddTicks(4142), "c24cc6c8-d33e-4455-8e76-8defe7a59a14", new DateTime(2025, 8, 8, 12, 57, 53, 71, DateTimeKind.Local).AddTicks(4143) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 72, DateTimeKind.Local).AddTicks(7276), new DateTime(2025, 8, 8, 12, 57, 53, 72, DateTimeKind.Local).AddTicks(7282), "8f577f5a-e4a5-4d43-b7d1-47d2c00b076d", new DateTime(2025, 8, 8, 12, 57, 53, 72, DateTimeKind.Local).AddTicks(7282) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 73, DateTimeKind.Local).AddTicks(3947), new DateTime(2025, 8, 8, 12, 57, 53, 73, DateTimeKind.Local).AddTicks(3948), "b5c71b98-6f92-4550-a154-0618bd249163", new DateTime(2025, 8, 8, 12, 57, 53, 73, DateTimeKind.Local).AddTicks(3948) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 74, DateTimeKind.Local).AddTicks(629), new DateTime(2025, 8, 8, 12, 57, 53, 74, DateTimeKind.Local).AddTicks(632), "ff6b98f7-66b2-4620-a020-c3f7d61211bc", new DateTime(2025, 8, 8, 12, 57, 53, 74, DateTimeKind.Local).AddTicks(633) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 74, DateTimeKind.Local).AddTicks(6753), new DateTime(2025, 8, 8, 12, 57, 53, 74, DateTimeKind.Local).AddTicks(6754), "00429214-708d-49af-91e5-07812d476294", new DateTime(2025, 8, 8, 12, 57, 53, 74, DateTimeKind.Local).AddTicks(6755) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 75, DateTimeKind.Local).AddTicks(3959), new DateTime(2025, 8, 8, 12, 57, 53, 75, DateTimeKind.Local).AddTicks(3962), "386e5985-6a82-425c-ba9f-21d71d587a9f", new DateTime(2025, 8, 8, 12, 57, 53, 75, DateTimeKind.Local).AddTicks(3962) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 76, DateTimeKind.Local).AddTicks(297), new DateTime(2025, 8, 8, 12, 57, 53, 76, DateTimeKind.Local).AddTicks(297), "c97d7788-9fa9-4e82-a081-19e8705e0792", new DateTime(2025, 8, 8, 12, 57, 53, 76, DateTimeKind.Local).AddTicks(298) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 76, DateTimeKind.Local).AddTicks(6288), new DateTime(2025, 8, 8, 12, 57, 53, 76, DateTimeKind.Local).AddTicks(6289), "e404e774-515f-41c6-9138-b2962cc755a5", new DateTime(2025, 8, 8, 12, 57, 53, 76, DateTimeKind.Local).AddTicks(6289) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 77, DateTimeKind.Local).AddTicks(3858), new DateTime(2025, 8, 8, 12, 57, 53, 77, DateTimeKind.Local).AddTicks(3862), "c461b6b0-cd20-45d5-8934-018597bc2ee1", new DateTime(2025, 8, 8, 12, 57, 53, 77, DateTimeKind.Local).AddTicks(3862) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 78, DateTimeKind.Local).AddTicks(3868), new DateTime(2025, 8, 8, 12, 57, 53, 78, DateTimeKind.Local).AddTicks(3871), "692ab4f7-6a35-48f0-8b91-aaa2b006e7ff", new DateTime(2025, 8, 8, 12, 57, 53, 78, DateTimeKind.Local).AddTicks(3872) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 79, DateTimeKind.Local).AddTicks(758), new DateTime(2025, 8, 8, 12, 57, 53, 79, DateTimeKind.Local).AddTicks(761), "d5ae7bb9-c8a0-4db1-981d-460a34877c7c", new DateTime(2025, 8, 8, 12, 57, 53, 79, DateTimeKind.Local).AddTicks(761) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 79, DateTimeKind.Local).AddTicks(6734), new DateTime(2025, 8, 8, 12, 57, 53, 79, DateTimeKind.Local).AddTicks(6735), "908447ba-4f42-41e2-bba5-f1991cb51766", new DateTime(2025, 8, 8, 12, 57, 53, 79, DateTimeKind.Local).AddTicks(6735) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 80, DateTimeKind.Local).AddTicks(3043), new DateTime(2025, 8, 8, 12, 57, 53, 80, DateTimeKind.Local).AddTicks(3044), "7ad15694-3c86-414f-9a7b-185c00cb235d", new DateTime(2025, 8, 8, 12, 57, 53, 80, DateTimeKind.Local).AddTicks(3044) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 80, DateTimeKind.Local).AddTicks(9665), new DateTime(2025, 8, 8, 12, 57, 53, 80, DateTimeKind.Local).AddTicks(9668), "dac14300-bc30-4cab-ae67-0df446117118", new DateTime(2025, 8, 8, 12, 57, 53, 80, DateTimeKind.Local).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 81, DateTimeKind.Local).AddTicks(5751), new DateTime(2025, 8, 8, 12, 57, 53, 81, DateTimeKind.Local).AddTicks(5751), "572124e8-f735-4552-9301-82c1921935dd", new DateTime(2025, 8, 8, 12, 57, 53, 81, DateTimeKind.Local).AddTicks(5752) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 82, DateTimeKind.Local).AddTicks(2066), new DateTime(2025, 8, 8, 12, 57, 53, 82, DateTimeKind.Local).AddTicks(2067), "dd60eb81-c3ae-4cbb-b979-861688fc975d", new DateTime(2025, 8, 8, 12, 57, 53, 82, DateTimeKind.Local).AddTicks(2067) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 82, DateTimeKind.Local).AddTicks(8381), new DateTime(2025, 8, 8, 12, 57, 53, 82, DateTimeKind.Local).AddTicks(8384), "55a7842d-8365-4241-add1-1810e573df4d", new DateTime(2025, 8, 8, 12, 57, 53, 82, DateTimeKind.Local).AddTicks(8384) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 83, DateTimeKind.Local).AddTicks(8482), new DateTime(2025, 8, 8, 12, 57, 53, 83, DateTimeKind.Local).AddTicks(8483), "b9f5b6fa-2150-4773-a3f5-e38cf4b7a322", new DateTime(2025, 8, 8, 12, 57, 53, 83, DateTimeKind.Local).AddTicks(8484) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 84, DateTimeKind.Local).AddTicks(8712), new DateTime(2025, 8, 8, 12, 57, 53, 84, DateTimeKind.Local).AddTicks(8715), "4ec0317e-8e5c-4ec8-ac90-596abc7e38e0", new DateTime(2025, 8, 8, 12, 57, 53, 84, DateTimeKind.Local).AddTicks(8715) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 85, DateTimeKind.Local).AddTicks(5383), new DateTime(2025, 8, 8, 12, 57, 53, 85, DateTimeKind.Local).AddTicks(5384), "77d037ed-bb70-4da4-bfe6-b903d881fda1", new DateTime(2025, 8, 8, 12, 57, 53, 85, DateTimeKind.Local).AddTicks(5384) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 86, DateTimeKind.Local).AddTicks(1733), new DateTime(2025, 8, 8, 12, 57, 53, 86, DateTimeKind.Local).AddTicks(1733), "eebb5929-7c82-4af1-8d83-1391b1608706", new DateTime(2025, 8, 8, 12, 57, 53, 86, DateTimeKind.Local).AddTicks(1734) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 86, DateTimeKind.Local).AddTicks(8100), new DateTime(2025, 8, 8, 12, 57, 53, 86, DateTimeKind.Local).AddTicks(8103), "c53108a1-cb44-4085-8cb3-ffc2d11bd5b9", new DateTime(2025, 8, 8, 12, 57, 53, 86, DateTimeKind.Local).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(15), 1, new DateTime(2025, 8, 8, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(16), "100dbc27-8d1f-41bb-b0e5-a57ba0fe08ca", new DateTime(2025, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(16) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(33), 2, new DateTime(2025, 8, 8, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(34), "4f9587bb-f75b-42c1-ad0a-be2f3ede502c", new DateTime(2025, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(34) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(39), 3, new DateTime(2025, 8, 8, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(39), "3df4ded6-c9f8-4558-aefc-c654843aadda", new DateTime(2025, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(44), 4, new DateTime(2025, 8, 8, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(44), "401cb937-c797-49d5-b9b4-9536ef869ada", new DateTime(2025, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(44) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(52), new DateTime(2025, 8, 9, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(52), "dac1e9d8-94bc-4b58-a44d-3c28c91e53e5", new DateTime(2025, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 9, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(53) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(57), 2, new DateTime(2025, 8, 9, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(58), "35c1b88b-1f52-4a3b-b66f-8c8fd899d03d", new DateTime(2025, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 9, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(58) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(62), 3, new DateTime(2025, 8, 9, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(63), "9397e890-81d4-4a10-b4b7-6d3b4bdd0912", new DateTime(2025, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 9, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(63) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(70), 4, new DateTime(2025, 8, 9, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(71), "adea4366-fb8c-4b80-aa96-2e92732638ca", new DateTime(2025, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 9, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(71) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(78), 2, new DateTime(2025, 8, 10, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(79), "ab45fd2c-f71b-498f-bad1-d8c089d80fa9", new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(79) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(84), 3, new DateTime(2025, 8, 10, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(84), "5de56dc1-30e9-401c-900b-3fd395ce0968", new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(84) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(88), new DateTime(2025, 8, 10, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(88), "48f7772f-1ef1-472e-a598-bbb24e178c0c", new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(89) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(92), new DateTime(2025, 8, 10, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(93), "6c889334-8807-4794-b9b0-beda163c196f", new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(93) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(99), new DateTime(2025, 8, 11, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(99), "0ca7ffc8-43c7-466c-9360-2288a5058051", new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 11, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(99) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(104), 3, new DateTime(2025, 8, 11, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(104), "fd988c3a-4a46-4332-b8a9-a99fbb926460", new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 11, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(104) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(108), 4, new DateTime(2025, 8, 11, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(108), "80edb942-f006-4bf5-b50f-097284e37147", new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 11, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(109) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(114), new DateTime(2025, 8, 11, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(114), "3032fb80-86a4-4bf9-96b6-dd5cfe9e9d98", new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 11, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(114) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(120), new DateTime(2025, 8, 12, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(120), "3a9f6b4c-0a85-4be6-abcd-4de67b936f04", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 12, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(125), new DateTime(2025, 8, 12, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(125), "c731cf9b-d199-4b52-8159-cd0e2baf8af7", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 12, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(125) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(130), 4, new DateTime(2025, 8, 12, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(130), "33ecc0f2-dee4-4dae-8f59-c787d45da354", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 12, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(130) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(134), 5, new DateTime(2025, 8, 12, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(134), "45d9cda4-7344-44d4-a584-6a14ed04473d", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 12, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(135) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(141), new DateTime(2025, 8, 13, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(141), "9fe054ed-8728-4c92-a5d0-7988963f9500", new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 13, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(141) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(149), new DateTime(2025, 8, 13, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(150), "5dbf14ba-cd24-4ce1-a6dc-ca35c73e6b96", new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 13, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(155), new DateTime(2025, 8, 13, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(155), "15bdb9d3-932a-4a04-825b-945d3683caa7", new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 13, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(155) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(161), 5, new DateTime(2025, 8, 13, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(161), "70605f49-c23c-445b-921f-d15c008a2900", new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 13, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(161) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(167), new DateTime(2025, 8, 14, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(167), "4b39fa17-a27a-4316-9eb7-699216d73b5b", new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 14, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(168) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(172), new DateTime(2025, 8, 14, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(172), "dd505076-2033-456d-ae60-28f29e76d2a1", new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 14, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(172) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(176), new DateTime(2025, 8, 14, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(176), "889d70cc-aa7b-4ffd-a38a-09e7ae2d97ac", new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 14, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(177) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(180), new DateTime(2025, 8, 14, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(181), "18f65640-d47a-44cc-9b98-4fb649922291", new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 14, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(181) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(189), new DateTime(2025, 8, 8, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(190), "8dd6b16e-e7ba-4dca-8280-70caf3513d69", new DateTime(2025, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(195), new DateTime(2025, 8, 8, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(195), "774391aa-f85e-4529-a296-7d7e63208c53", new DateTime(2025, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(196) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(200), new DateTime(2025, 8, 8, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(200), "1b9e3483-ba57-4afa-b933-7698727f3760", new DateTime(2025, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(201) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(206), new DateTime(2025, 8, 8, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(206), "9a387171-d16c-43e5-95b5-d07434ace63e", new DateTime(2025, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(206) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(211), new DateTime(2025, 8, 8, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(211), "402665bf-9bd4-4403-affa-127a897b0c2d", new DateTime(2025, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(212) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(216), new DateTime(2025, 8, 8, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(216), "b9bf8da8-b100-48dd-8419-2482fe1a2d83", new DateTime(2025, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(217) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(221), new DateTime(2025, 8, 9, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(222), "97ae99fd-61f6-4184-b64a-4ed431ed1ded", new DateTime(2025, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 9, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(222) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(226), new DateTime(2025, 8, 9, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(226), "5fab67cb-6050-4785-9d06-8c4b907fe320", new DateTime(2025, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 9, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(226) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(230), new DateTime(2025, 8, 9, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(230), "00a678a4-29fe-4c20-a5e8-05feb790da7d", new DateTime(2025, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 9, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(231) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(234), new DateTime(2025, 8, 9, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(234), "c6473e53-cee9-40a7-aedf-5cc1e8b0cc2c", new DateTime(2025, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 9, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(235) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(238), new DateTime(2025, 8, 9, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(239), "8c578426-c5a0-4f4a-8b9a-7836b32dc090", new DateTime(2025, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 9, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(239) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(244), new DateTime(2025, 8, 9, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(244), "f7fc3a3b-d973-4160-9767-6fcab22fcd91", new DateTime(2025, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 9, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(245) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(249), new DateTime(2025, 8, 10, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(249), "83bb2c1f-6eca-452b-9a24-7f4b07f3c465", new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(249) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(253), new DateTime(2025, 8, 10, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(253), "15d5580f-457b-47ff-a5bf-6372ff3ac602", new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(257), new DateTime(2025, 8, 10, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(257), "733c27ab-bb9d-46d9-a360-df4d9c0bf422", new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(258) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(261), new DateTime(2025, 8, 10, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(262), "e76500c8-5efb-4d09-a33f-32f719c33159", new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(262) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(266), new DateTime(2025, 8, 10, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(266), "64076f44-a287-47c9-84a2-f3341619afee", new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(266) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(270), new DateTime(2025, 8, 10, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(270), "4f31662a-1a10-4d24-b070-806185780fab", new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(270) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(274), new DateTime(2025, 8, 11, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(275), "232f2e1b-30f6-4e01-a6e7-b23f5c2065b0", new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 11, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(275) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(280), new DateTime(2025, 8, 11, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(280), "c3c7ba31-f599-46c4-8f2d-7427b8298787", new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 11, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(284), new DateTime(2025, 8, 11, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(284), "3795eb0b-476e-40b5-bc96-5fecdeb0b1d1", new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 11, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(284) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(288), new DateTime(2025, 8, 11, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(288), "56e6154f-33ee-4a49-b83c-b57e8560f7a0", new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 11, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(289) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(295), new DateTime(2025, 8, 11, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(296), "cd71861c-e158-424f-88f7-20656a81d231", new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 11, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(296) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(300), new DateTime(2025, 8, 11, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(300), "74444a75-6822-485b-bc90-7eade4992841", new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 11, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(305), new DateTime(2025, 8, 12, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(305), "fa17725e-eea7-454e-906c-351651b8143a", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 12, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(305) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(309), new DateTime(2025, 8, 12, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(309), "42e9ba84-9041-4f13-b803-c88fbe8fcf5e", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 12, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(309) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(313), new DateTime(2025, 8, 12, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(314), "079f8770-b33e-489b-8c92-0bac8420f98f", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 12, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(314) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(319), new DateTime(2025, 8, 12, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(319), "61bf6a31-ff6b-463d-9c3d-34dbac0aa388", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 12, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(319) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(323), new DateTime(2025, 8, 12, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(323), "a1a0f189-e3d4-4d03-8665-20a0ead0f035", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 12, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(323) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(327), new DateTime(2025, 8, 12, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(327), "967026de-94f8-49ee-85b5-48a7c285198e", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 12, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(327) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(331), new DateTime(2025, 8, 13, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(332), "f26f6866-ab52-4ee4-b908-235923aa6460", new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 13, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(332) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(335), new DateTime(2025, 8, 13, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(336), "804c629a-f599-48fb-8ae3-57c47365cb47", new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 13, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(336) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(340), new DateTime(2025, 8, 13, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(340), "f5b6f062-f833-4c92-a46d-a70e5e460fc1", new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 13, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(344), new DateTime(2025, 8, 13, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(344), "17b7ae27-2305-407b-8a7d-0db16ee3fbef", new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 13, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(344) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(348), new DateTime(2025, 8, 13, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(348), "050f86f0-f07e-4204-be53-63139ac5fb65", new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 13, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(349) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(353), new DateTime(2025, 8, 13, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(354), "a70a9529-3f26-4bff-b5f6-47c20748383f", new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 13, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(354) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(358), new DateTime(2025, 8, 14, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(358), "43b461ff-43ff-47ac-b539-b80721d7fee5", new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 14, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(358) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(363), new DateTime(2025, 8, 14, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(363), "7a55c298-6798-4c73-821c-a13911a51e5d", new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 14, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(363) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(367), new DateTime(2025, 8, 14, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(368), "4d927aba-e6f7-421b-9d62-d7dc2cbbac5d", new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 14, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(368) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(372), new DateTime(2025, 8, 14, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(372), "0db5376b-2e59-4a91-b8de-fb2be88a571a", new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 14, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(376), new DateTime(2025, 8, 14, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(376), "de57f733-4860-48e2-9209-2773c2867a99", new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 14, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(376) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(380), new DateTime(2025, 8, 14, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(380), "ace25970-d543-4129-b0c9-5127a2e6a336", new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 14, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(381) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(428), new DateTime(2025, 8, 8, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(428), "e86c9fa9-3d46-4c15-9191-ef621d077ed6", new DateTime(2025, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(428) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(437), 12, new DateTime(2025, 8, 8, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(438), "b0652750-46e7-4112-b432-9c7d63649098", new DateTime(2025, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 8, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(438) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(443), 11, new DateTime(2025, 8, 9, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(443), "0a837edc-37c6-45b3-8d54-760fc87bab80", new DateTime(2025, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 9, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(443) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(449), new DateTime(2025, 8, 9, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(450), "a06e7235-45e7-4f1a-83b5-331b14c239a4", new DateTime(2025, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 9, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(450) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(454), new DateTime(2025, 8, 10, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(454), "6dabb742-9a24-4abf-b50f-325d05538bfa", new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(455) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(460), new DateTime(2025, 8, 10, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(460), "54a3966e-c8e1-4df0-9436-9fc92179ddcc", new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(461) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(465), new DateTime(2025, 8, 11, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(465), "6a6754cb-28a1-4a1b-9243-f24ebea71b5b", new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 11, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(474), new DateTime(2025, 8, 11, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(474), "6ede634d-5ea0-444d-af45-eb43fefe02ad", new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 11, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(474) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(478), new DateTime(2025, 8, 12, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(479), "585425d3-0656-42f3-aa6a-d9a4703525da", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 12, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(479) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(484), 12, new DateTime(2025, 8, 12, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(485), "4ece81a6-755d-4cfd-95b6-052b8683dc35", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 12, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(485) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(489), 11, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(489), "7fd0f1d7-4ce7-427e-b025-7bd0106264ba", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(495), 12, new DateTime(2025, 8, 13, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(495), "97ba3ef2-8d66-4eb6-867e-f3d562b82a6f", new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 13, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(496) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "EmployeeId", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(500), 11, new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(500), "3901159f-68eb-49a3-8490-f65ea2e14f74", new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(506), new DateTime(2025, 8, 14, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(506), "e8a94509-28a3-4156-85d5-9161a5582937", 1, new DateTime(2025, 8, 14, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(510), 12, new DateTime(2025, 8, 14, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(511), "cfd91fe6-f0ce-4a25-980b-301914d28221", new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 14, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 8, 12, 57, 53, 88, DateTimeKind.Local).AddTicks(511) });
        }
    }
}

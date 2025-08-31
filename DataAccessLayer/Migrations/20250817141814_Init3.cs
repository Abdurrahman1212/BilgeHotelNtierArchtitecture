using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "Reservations");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "West Jordi", "Germany", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(678), "82243 Marvin Lake, Greggport, Lao People's Democratic Republic", "FI4215009305700295", "473-745-4897 x8259", "Fae_Stark@yahoo.com", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(694), "Meredith", "Stiedemann", "c5cde954-7934-4e83-9924-224d6f358663", "42674", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(695) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Port Bertrand", "Barbados", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(1808), "420 Konopelski Hills, Vivianhaven, Bangladesh", "5", "TL646848005040932007009", "471-215-2192", "Wade.Batz29@gmail.com", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(1808), "Savion", "Jerde", "47d4e4fb-9f71-4fa3-8f0f-7b176229917e", "58093", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(1809) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Port Deebury", "Madagascar", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(2205), "95467 Dickens Roads, South Shayna, Barbados", "2", "CR74155825006278202801", "202-212-5377 x11631", "Angus2@hotmail.com", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(2206), "Alan", "Hyatt", "92c142fd-1843-482d-afa0-1986693e94ab", "67651-4434", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "South Tyrellstad", "Guam", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(2598), "29248 Wunsch Mountain, Lake Jadonview, Georgia", "5", "DK1200400324718840", "1-964-744-5902", "Rodrick_Cruickshank77@gmail.com", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(2598), "Nora", "Toy", "3f2b8d5b-9f76-48ce-a752-6e925bc18b38", "53043", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(2599) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "North Stewart", "Bulgaria", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(3246), "76334 Daniel Rapid, Dickinsonfort, Iceland", "PK76E3DV0306706300579006", "1-853-919-6007 x1364", "Braden_Rutherford@gmail.com", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(3248), "Cassidy", "Predovic", "73f8de2e-1964-44c3-b40e-5edd9c7c3177", "59106", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(3249) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "New Kristy", "Bosnia and Herzegovina", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(3698), "85015 Layla Mount, West Briana, Saint Pierre and Miquelon", "3", "HR2117996494100780713", "878-567-9702 x596", "Nicklaus50@hotmail.com", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(3699), "Pearl", "Parisian", "d87ef8f2-9b36-4535-a0ba-a00b6dce55a6", "78412", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(3699) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "New Dawn", "Bahrain", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(4031), "4060 Mohr Fort, Morarville, Saint Helena", "1", "PK5790107026520065304361", "(910) 631-6633 x509", "Raina_Daugherty92@yahoo.com", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(4031), "Sonny", "Nitzsche", "1c110573-9c81-4f2c-89b6-5aa88b821466", "82052-8318", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(4032) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Lake Alyciaside", "Isle of Man", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(4354), "257 Brekke Fords, Kiarraburgh, Cote d'Ivoire", "5", "SA706183332VK6209J80U5G3", "(237) 833-7816 x21318", "Mikayla91@yahoo.com", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(4355), "Jacinthe", "Schimmel", "9494dc0f-c471-444d-87c8-4dfeab07cd45", "30279-2586", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(4355) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Clarkborough", "Armenia", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(4741), "9226 Bosco Islands, Rowefurt, Afghanistan", "1", "BH05AVSN822979E666F116", "(408) 573-3764 x969", "Kellen61@yahoo.com", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(4742), "Aracely", "Schinner", "f0f76fd3-6891-4339-bfc6-ffdb20a39ccd", "93651-3234", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(4742) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "West Mitchell", "France", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(5083), "658 Randal Ville, Webermouth, Somalia", "5", "LT032600919060072787", "204.677.9162", "Adell.Walsh97@yahoo.com", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(5084), "Gideon", "Dietrich", "3b65b87a-1ee3-4ed9-83a7-c36f84954205", "89460", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(5084) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Kırklareli", "Bahreyn", new DateTime(2025, 8, 17, 17, 18, 12, 778, DateTimeKind.Local).AddTicks(9336), "Batrak16@gmail.com", "Sıran Söğüt Sokak 4, Kırklareli, Pakistan", "Barçadoğmuş", "Yeşilkaya", "+90-866-115-5-848", new DateTime(2025, 8, 17, 17, 18, 12, 778, DateTimeKind.Local).AddTicks(9345), "1aa2b6c1-d5ed-4265-b954-3cd8aadf394a", "1", new DateTime(2025, 8, 17, 17, 18, 12, 778, DateTimeKind.Local).AddTicks(9346) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Samsun", "Nijer", new DateTime(2025, 8, 17, 17, 18, 12, 779, DateTimeKind.Local).AddTicks(763), "Aybars73@yahoo.com", "Okul Sokak 31a, Kırşehir, Suudi Arabistan", "Bayraç", "Ertürk", "+90-464-093-1-558", new DateTime(2025, 8, 17, 17, 18, 12, 779, DateTimeKind.Local).AddTicks(764), "e540e296-4522-4ef7-ab7a-adf9094ca5ea", "0", new DateTime(2025, 8, 17, 17, 18, 12, 779, DateTimeKind.Local).AddTicks(765) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "K.maraş", "Kosova", new DateTime(2025, 8, 17, 17, 18, 12, 779, DateTimeKind.Local).AddTicks(1083), "Aykan.Corekci@gmail.com", "Menekşe Sokak 4, Tokat, K.K.T.C.", "Aladoğan", "Sözeri", "+90-566-619-71-24", new DateTime(2025, 8, 17, 17, 18, 12, 779, DateTimeKind.Local).AddTicks(1083), "a749bc9f-5e1f-4faa-bf7b-980e2dd0d4dc", "0", new DateTime(2025, 8, 17, 17, 18, 12, 779, DateTimeKind.Local).AddTicks(1084) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Bitlis", "Nepal", new DateTime(2025, 8, 17, 17, 18, 12, 779, DateTimeKind.Local).AddTicks(1352), "Basut_Cetin@yahoo.com", "30 Ağustos Caddesi 77c, Muğla, Birleşik Arap Emirlikleri", "Irmak", "Sinanoğlu", "+90-744-682-7-979", new DateTime(2025, 8, 17, 17, 18, 12, 779, DateTimeKind.Local).AddTicks(1353), "ccd5963e-ec1e-4353-acbc-921a1749e0bc", "1", new DateTime(2025, 8, 17, 17, 18, 12, 779, DateTimeKind.Local).AddTicks(1354) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Düzce", "Ukrayna", new DateTime(2025, 8, 17, 17, 18, 12, 779, DateTimeKind.Local).AddTicks(1601), "Buyancuk.Yildirim@yahoo.com", "Sevgi Sokak 612, Erzurum, Avustralya", "Bağan", "Aclan", "+90-895-243-3-000", new DateTime(2025, 8, 17, 17, 18, 12, 779, DateTimeKind.Local).AddTicks(1602), "f7f5ed67-0d02-4014-a58e-6393b43083a2", "1", new DateTime(2025, 8, 17, 17, 18, 12, 779, DateTimeKind.Local).AddTicks(1603) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "İçel (Mersin)", "Nepal", new DateTime(2025, 8, 17, 17, 18, 12, 779, DateTimeKind.Local).AddTicks(1848), "Atalmis.Oraloglu52@gmail.com", "Lütfi Karadirek Caddesi 716, Afyon, Belize", "Barkan", "Elmastaşoğlu", "+90-243-854-4-383", new DateTime(2025, 8, 17, 17, 18, 12, 779, DateTimeKind.Local).AddTicks(1849), "14146648-ebb0-4b47-915b-3c9a9156cf4c", "0", new DateTime(2025, 8, 17, 17, 18, 12, 779, DateTimeKind.Local).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Uşak", "Birleşik Arap Emirlikleri", new DateTime(2025, 8, 17, 17, 18, 12, 779, DateTimeKind.Local).AddTicks(2326), "Ayiz_Baykam32@yahoo.com", "Ali Çetinkaya Caddesi 24b, İstanbul, Türkiye", "Bayurku", "Okur", "+90-357-223-9-147", new DateTime(2025, 8, 17, 17, 18, 12, 779, DateTimeKind.Local).AddTicks(2330), "104fb463-339e-4c20-bb32-8236954021be", "1", new DateTime(2025, 8, 17, 17, 18, 12, 779, DateTimeKind.Local).AddTicks(2331) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Sivas", "Turks ve Caicos Adaları, İngiltere", new DateTime(2025, 8, 17, 17, 18, 12, 781, DateTimeKind.Local).AddTicks(7919), "Butak.Balci81@gmail.com", "Köypınar Sokak 756, Tokat, Kuzey Maryana Adaları", "Baltacı", "Sinanoğlu", "+90-632-464-8-315", new DateTime(2025, 8, 17, 17, 18, 12, 781, DateTimeKind.Local).AddTicks(7928), "cb8d12aa-6a07-4112-b402-c51ef5e70319", new DateTime(2025, 8, 17, 17, 18, 12, 781, DateTimeKind.Local).AddTicks(7929) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Kocaeli", "Ekvator", new DateTime(2025, 8, 17, 17, 18, 12, 781, DateTimeKind.Local).AddTicks(9165), "Bayruk39@yahoo.com", "Okul Sokak 7, Bingöl, Karadağ", "Barçadoğmuş", "Kuzucu", "+90-416-690-0-853", new DateTime(2025, 8, 17, 17, 18, 12, 781, DateTimeKind.Local).AddTicks(9166), "08327f68-f37c-4be5-9938-bb08c96d2ab2", "0", new DateTime(2025, 8, 17, 17, 18, 12, 781, DateTimeKind.Local).AddTicks(9167) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Kayseri", "Makedonya", new DateTime(2025, 8, 17, 17, 18, 12, 781, DateTimeKind.Local).AddTicks(9471), "Begdilli_Okur6@hotmail.com", "Okul Sokak 96c, Iğdır, Liberya", "Aşantuğrul", "Karaböcek", "+90-912-169-08-75", new DateTime(2025, 8, 17, 17, 18, 12, 781, DateTimeKind.Local).AddTicks(9472), "20c6364b-9b1a-41b3-9c45-9198464511af", new DateTime(2025, 8, 17, 17, 18, 12, 781, DateTimeKind.Local).AddTicks(9473) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Hakkari", "Togo", new DateTime(2025, 8, 17, 17, 18, 12, 781, DateTimeKind.Local).AddTicks(9734), "Bure_Kasapoglu27@gmail.com", "Sıran Söğüt Sokak 29c, Muğla, Nijer", "Karaça", "Atan", "+90-216-989-70-59", new DateTime(2025, 8, 17, 17, 18, 12, 781, DateTimeKind.Local).AddTicks(9735), "1b1a0d38-50d5-43f3-976d-f4fd80a346b6", new DateTime(2025, 8, 17, 17, 18, 12, 781, DateTimeKind.Local).AddTicks(9735) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Ankara", "Kazakistan", new DateTime(2025, 8, 17, 17, 18, 12, 782, DateTimeKind.Local).AddTicks(219), "Bayrin.Tugluk73@yahoo.com", "Namık Kemal Caddesi 15c, Isparta, Endonezya", "Basademir", "Dağlaroğlu", "+90-917-660-14-08", new DateTime(2025, 8, 17, 17, 18, 12, 782, DateTimeKind.Local).AddTicks(223), "62f8a510-2cc4-46a1-a819-0f23c0497527", "0", new DateTime(2025, 8, 17, 17, 18, 12, 782, DateTimeKind.Local).AddTicks(224) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Yozgat", "Yemen", new DateTime(2025, 8, 17, 17, 18, 12, 782, DateTimeKind.Local).AddTicks(606), "Ayaci51@yahoo.com", "Saygılı Sokak 56c, Erzurum, Vietnam", "Boğaç", "Eronat", "+90-175-202-0-979", new DateTime(2025, 8, 17, 17, 18, 12, 782, DateTimeKind.Local).AddTicks(607), "9108e01a-d956-40ee-bf18-bf3fd5c728d5", new DateTime(2025, 8, 17, 17, 18, 12, 782, DateTimeKind.Local).AddTicks(608) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Iğdır", "Kosta Rika", new DateTime(2025, 8, 17, 17, 18, 12, 782, DateTimeKind.Local).AddTicks(877), "Abi_Tekand@gmail.com", "Ali Çetinkaya Caddesi 35b, Bolu, Moldavya", "Gürbüz", "Yılmazer", "+90-935-416-5-993", new DateTime(2025, 8, 17, 17, 18, 12, 782, DateTimeKind.Local).AddTicks(878), "9760db8e-2616-47f4-8bda-c5f6c3d84965", "1", new DateTime(2025, 8, 17, 17, 18, 12, 782, DateTimeKind.Local).AddTicks(879) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Yalova", "Hindistan", new DateTime(2025, 8, 17, 17, 18, 12, 782, DateTimeKind.Local).AddTicks(1109), "Baybars_Elicin@gmail.com", "Barış Sokak 84b, Muş, Birleşik Arap Emirlikleri", "Baybiçen", "Elmastaşoğlu", "+90-260-155-0-249", new DateTime(2025, 8, 17, 17, 18, 12, 782, DateTimeKind.Local).AddTicks(1110), "bf9ec652-e7ba-4c45-ae36-a692b39deb19", "1", new DateTime(2025, 8, 17, 17, 18, 12, 782, DateTimeKind.Local).AddTicks(1110) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Ardahan", "Surinam", new DateTime(2025, 8, 17, 17, 18, 12, 782, DateTimeKind.Local).AddTicks(1434), "Asri_Tunceri40@yahoo.com", "Sıran Söğüt Sokak 629, Amasya, Fransız Guyanası", "Bardıbay", "Atakol", "+90-485-280-12-90", new DateTime(2025, 8, 17, 17, 18, 12, 782, DateTimeKind.Local).AddTicks(1435), "2ccfda16-85db-47c6-a17c-78d731f457f5", "0", new DateTime(2025, 8, 17, 17, 18, 12, 782, DateTimeKind.Local).AddTicks(1436) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Sinop", "Fransa", new DateTime(2025, 8, 17, 17, 18, 12, 782, DateTimeKind.Local).AddTicks(1678), "Ilacin.Nebioglu24@yahoo.com", "Bayır Sokak 76b, Samsun, Makedonya", "Bağaturipi", "Özbir", "+90-242-622-83-55", new DateTime(2025, 8, 17, 17, 18, 12, 782, DateTimeKind.Local).AddTicks(1679), "387d240e-c84f-4905-b552-3aaf77cd4675", "0", new DateTime(2025, 8, 17, 17, 18, 12, 782, DateTimeKind.Local).AddTicks(1679) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Eskişehir", "Bolivya", new DateTime(2025, 8, 17, 17, 18, 12, 782, DateTimeKind.Local).AddTicks(1926), "Alpurungututuk_Gumuspala@hotmail.com", "Sağlık Sokak 8, Aydın, Malta", "Basut", "Körmükçü", "+90-369-661-83-90", new DateTime(2025, 8, 17, 17, 18, 12, 782, DateTimeKind.Local).AddTicks(1927), "32059472-2541-4926-9712-b9af89d114e6", "1", new DateTime(2025, 8, 17, 17, 18, 12, 782, DateTimeKind.Local).AddTicks(1928) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Şırnak", "Gana", new DateTime(2025, 8, 17, 17, 18, 12, 784, DateTimeKind.Local).AddTicks(7987), "Ayban68@yahoo.com", "Sarıkaya Caddesi 5, Tekirdağ, Surinam", "Boğa", "Atakol", "+90-839-180-92-21", new DateTime(2025, 8, 17, 17, 18, 12, 784, DateTimeKind.Local).AddTicks(7999), "17e552bf-b65a-4b1c-8cb8-92b26eebfca3", new DateTime(2025, 8, 17, 17, 18, 12, 784, DateTimeKind.Local).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Siirt", "Makau (Makao)", new DateTime(2025, 8, 17, 17, 18, 12, 784, DateTimeKind.Local).AddTicks(9193), "Burcak31@hotmail.com", "Lütfi Karadirek Caddesi 3, Çorum, Brunei", "Atlı", "Çetiner", "+90-751-552-0-407", new DateTime(2025, 8, 17, 17, 18, 12, 784, DateTimeKind.Local).AddTicks(9194), "47f11c6d-ff68-4c62-8bb4-c0b13cba1275", new DateTime(2025, 8, 17, 17, 18, 12, 784, DateTimeKind.Local).AddTicks(9195) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Kırıkkale", "Vallis ve Futuna, Fransa", new DateTime(2025, 8, 17, 17, 18, 12, 784, DateTimeKind.Local).AddTicks(9530), "Aydin_Sepetci@gmail.com", "Harman Yolu Sokak  21c, Karabük, Tonga", "Adlı", "Aşıkoğlu", "+90-720-452-9-788", new DateTime(2025, 8, 17, 17, 18, 12, 784, DateTimeKind.Local).AddTicks(9531), "1b4cbde5-8fab-4652-8c75-b500a864ab86", "0", new DateTime(2025, 8, 17, 17, 18, 12, 784, DateTimeKind.Local).AddTicks(9532) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Çankırı", "Senegal", new DateTime(2025, 8, 17, 17, 18, 12, 784, DateTimeKind.Local).AddTicks(9814), "Bayik_Karaduman9@gmail.com", "Okul Sokak 84b, Iğdır, İran", "Ağlamış", "Tekelioğlu", "+90-246-405-1-883", new DateTime(2025, 8, 17, 17, 18, 12, 784, DateTimeKind.Local).AddTicks(9815), "1015be07-0a8c-4cda-9a40-013813e11e39", new DateTime(2025, 8, 17, 17, 18, 12, 784, DateTimeKind.Local).AddTicks(9815) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Kırklareli", "Niue, Yeni Zelanda", new DateTime(2025, 8, 17, 17, 18, 12, 785, DateTimeKind.Local).AddTicks(74), "Gokcegol56@hotmail.com", "Tevfik Fikret Caddesi 3, Bingöl, Ürdün", "Dilek", "Sinanoğlu", "+90-240-398-23-78", new DateTime(2025, 8, 17, 17, 18, 12, 785, DateTimeKind.Local).AddTicks(75), "3e31f6c7-dbef-438b-9f60-af6f4044026e", new DateTime(2025, 8, 17, 17, 18, 12, 785, DateTimeKind.Local).AddTicks(76) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Kilis", "Arjantin", new DateTime(2025, 8, 17, 17, 18, 12, 785, DateTimeKind.Local).AddTicks(373), "Ayas38@gmail.com", "Alparslan Türkeş Bulvarı 875, K.maraş, Tonga", "Bünül", "Atan", "+90-912-860-08-28", new DateTime(2025, 8, 17, 17, 18, 12, 785, DateTimeKind.Local).AddTicks(373), "af3a565a-b9d3-4fb4-a96e-473d2d89e990", "0", new DateTime(2025, 8, 17, 17, 18, 12, 785, DateTimeKind.Local).AddTicks(374) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Hatay", "Angola", new DateTime(2025, 8, 17, 17, 18, 12, 785, DateTimeKind.Local).AddTicks(619), "Bagaturipi.Cevik28@yahoo.com", "İsmet Attila Caddesi 92a, Batman, Mali", "Alkan", "Orbay", "+90-332-225-60-68", new DateTime(2025, 8, 17, 17, 18, 12, 785, DateTimeKind.Local).AddTicks(620), "c8904301-3bd3-4941-8985-8466284512bf", new DateTime(2025, 8, 17, 17, 18, 12, 785, DateTimeKind.Local).AddTicks(621) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Gaziantep", "Romanya", new DateTime(2025, 8, 17, 17, 18, 12, 785, DateTimeKind.Local).AddTicks(920), "Kanci.Durak96@gmail.com", "Kerimoğlu Sokak 64a, Bayburt, Komorlar", "Berk", "Öztonga", "+90-144-183-92-48", new DateTime(2025, 8, 17, 17, 18, 12, 785, DateTimeKind.Local).AddTicks(921), "58def4cb-5a2d-46d7-b059-ca027e860e27", new DateTime(2025, 8, 17, 17, 18, 12, 785, DateTimeKind.Local).AddTicks(922) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Eskişehir", "Ermenistan", new DateTime(2025, 8, 17, 17, 18, 12, 785, DateTimeKind.Local).AddTicks(1186), "Busulgan.Topaloglu24@hotmail.com", "30 Ağustos Caddesi 62, Bolu, Afganistan", "Barbeğ", "Yıldırım ", "+90-793-616-9-104", new DateTime(2025, 8, 17, 17, 18, 12, 785, DateTimeKind.Local).AddTicks(1186), "6e28e9dd-242e-4a8c-b7f5-70c43edf9d28", "0", new DateTime(2025, 8, 17, 17, 18, 12, 785, DateTimeKind.Local).AddTicks(1187) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Bartın", "Beyaz Rusya", new DateTime(2025, 8, 17, 17, 18, 12, 785, DateTimeKind.Local).AddTicks(1743), "Cokramayul96@hotmail.com", "Yunus Emre Sokak 69b, Siirt, Montserrat", "Berginsenge", "Tunaboylu", "+90-299-370-68-38", new DateTime(2025, 8, 17, 17, 18, 12, 785, DateTimeKind.Local).AddTicks(1746), "05e77fb8-bec5-4eec-8182-8d1fa011d52c", "1", new DateTime(2025, 8, 17, 17, 18, 12, 785, DateTimeKind.Local).AddTicks(1748) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Ordu", "Rusya Federasyonu", new DateTime(2025, 8, 17, 17, 18, 12, 785, DateTimeKind.Local).AddTicks(2104), "Bagatur_Alpugan@gmail.com", "Oğuzhan Sokak 499, İçel (Mersin), Litvanya", "Adberilgen", "Ekşioğlu", "+90-527-458-80-76", new DateTime(2025, 8, 17, 17, 18, 12, 785, DateTimeKind.Local).AddTicks(2105), "6d475bee-abe1-4734-a1c7-0b2857e4bfaf", "0", new DateTime(2025, 8, 17, 17, 18, 12, 785, DateTimeKind.Local).AddTicks(2105) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Düzce", "İran", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(6407), "Colman.Sepetci@yahoo.com", "İbn-i Sina Sokak 25a, Tekirdağ, Sri Lanka", "Gönül", "Poçan", "+90-207-796-23-14", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(6416), "da95706a-790d-415d-9409-6d2725ce9502", "1", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(6417) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Çorum", "Sierra Leone", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(7436), "Kirlangic_Berberoglu@gmail.com", "Menekşe Sokak 96c, Yozgat, Makedonya", "Bornak", "Ertürk", "+90-721-646-17-75", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(7437), "f20a25fb-3faf-42eb-8357-7416805ccc3c", "1", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(7438) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Erzincan", "Japonya", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(7742), "Baytas11@hotmail.com", "İsmet Attila Caddesi 33c, Balıkesir, Danimarka", "Baltar", "Solmaz", "+90-613-970-02-08", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(7743), "e609ff26-5e72-4faf-a389-05e95eb586ae", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Kars", "Güney Afrika", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(7972), "Akkunlu41@hotmail.com", "Kekeçoğlu Sokak 7, Tunceli, Turks ve Caicos Adaları, İngiltere", "Amrak", "Özdoğan", "+90-578-442-23-04", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(7973), "384c3de7-af59-4f0f-9b8a-917ab9c905a7", "1", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(7974) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Ordu", "Çek Cumhuriyeti", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(8185), "Kirlangic95@yahoo.com", "Bandak Sokak 341, Sivas, İspanya", "Bölükbaşı", "Barbarosoğlu", "+90-461-078-58-42", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(8186), "86babcde-074a-468d-886b-eecd92098278", "0", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(8187) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Aksaray", "Vanuatu", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(8408), "Azganaz.Egeli57@hotmail.com", "Köypınar Sokak 842, Elazığ, Palau Adaları", "Barsgan", "Özberk", "+90-256-594-08-64", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(8409), "6e627d79-540b-4472-b318-a8eead45ca60", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(8409) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Uşak", "Türkiye", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(8629), "Buyan52@hotmail.com", "Kaldırım Sokak 13c, Nevşehir, Paraguay", "Atasu", "Polat", "+90-526-914-6-713", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(8630), "d429a0e1-19d0-4bd0-9197-f76a4ad0737a", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(8631) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Kırklareli", "Gine-Bissau", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(8848), "Balcar64@gmail.com", "Bahçe Sokak 81a, Malatya, Santa Kitts ve Nevis", "Alpuluğ", "Samancı", "+90-960-894-0-958", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(8848), "c16304bc-2967-41b8-ae42-d596f44ba244", "0", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(8849) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Çanakkale", "Galler", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(9067), "Ergene_Alpugan@yahoo.com", "Tevfik Fikret Caddesi 33, Düzce, Kiribati", "İdil", "Yılmazer", "+90-219-400-4-520", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(9067), "97fdaf64-9c98-4048-afbd-8f0cf13df261", "0", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(9068) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Balıkesir", "Kongo Demokratik Cumhuriyeti", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(9294), "Bagatur.Tuglu@gmail.com", "Ülkü Sokak 7, Bursa, Hollanda", "Baybars", "Dağlaroğlu", "+90-055-185-82-48", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(9295), "4f196571-1f33-4dcc-95cc-2c10c3da891b", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(9295) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Yozgat", "Kazakistan", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(9518), "Bay.Keseroglu@yahoo.com", "Saygılı Sokak 1, Adıyaman, Küba", "Boyan", "Toraman", "+90-800-085-25-77", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(9519), "1973294d-a8a2-401f-9f49-243a6aeac60d", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Ankara", "Marşal Adaları", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(9732), "Burgucan_Ilicali88@gmail.com", "Alparslan Türkeş Bulvarı 55b, Amasya, Türkmenistan", "Apak", "Köybaşı", "+90-217-879-8-542", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(9732), "d27cbae0-128b-44fe-80b4-7237b1a86279", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(9733) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Şanlıurfa", "Seyşeller", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(9958), "Asantugrul.Kormukcu@gmail.com", "Ali Çetinkaya Caddesi 31b, Rize, Somali", "Ergenekatun", "Kurutluoğlu", "+90-648-491-22-12", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(9959), "664860d1-a2ef-4353-9408-d029c4146c57", "0", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(9959) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Uşak", "Mısır", new DateTime(2025, 8, 17, 17, 18, 12, 790, DateTimeKind.Local).AddTicks(3615), "Bilgekulucur53@hotmail.com", "Mevlana Sokak 9, Karaman, Kanada", "Bozbörü", "Yılmazer", "+90-926-872-7-314", new DateTime(2025, 8, 17, 17, 18, 12, 790, DateTimeKind.Local).AddTicks(3625), "891ff8a3-8e82-4c71-bdaa-00b33c53920f", "1", new DateTime(2025, 8, 17, 17, 18, 12, 790, DateTimeKind.Local).AddTicks(3626) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Muş", "Kenya", new DateTime(2025, 8, 17, 17, 18, 12, 792, DateTimeKind.Local).AddTicks(4520), "Egrim.Tazegul13@yahoo.com", "Yunus Emre Sokak 2, Rize, Japonya", "Babır", "Okur", "+90-381-261-60-67", new DateTime(2025, 8, 17, 17, 18, 12, 792, DateTimeKind.Local).AddTicks(4528), "46c7f93f-d8aa-4322-aaff-a353848083bc", "1", new DateTime(2025, 8, 17, 17, 18, 12, 792, DateTimeKind.Local).AddTicks(4529) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 774, DateTimeKind.Local).AddTicks(8029), new DateTime(2025, 8, 17, 17, 18, 12, 774, DateTimeKind.Local).AddTicks(8037), 34.20m, new DateTime(2025, 1, 21, 3, 45, 30, 477, DateTimeKind.Local).AddTicks(9142), "Sed reiciendis praesentium ipsa qui eum ea.", "Licensed Metal Chicken", "a46055bf-b538-493a-a14a-adc43aa617a6", 8, new DateTime(2025, 8, 17, 17, 18, 12, 774, DateTimeKind.Local).AddTicks(8038) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 774, DateTimeKind.Local).AddTicks(8439), new DateTime(2025, 8, 17, 17, 18, 12, 774, DateTimeKind.Local).AddTicks(8440), 59.51m, new DateTime(2025, 1, 25, 0, 41, 52, 852, DateTimeKind.Local).AddTicks(3483), "Optio vel similique.", "Ergonomic Steel Salad", "8a7957e8-01ff-4bb5-be97-9bccb0846aef", 4, new DateTime(2025, 8, 17, 17, 18, 12, 774, DateTimeKind.Local).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 774, DateTimeKind.Local).AddTicks(8500), new DateTime(2025, 8, 17, 17, 18, 12, 774, DateTimeKind.Local).AddTicks(8501), 450.74m, new DateTime(2025, 3, 13, 5, 53, 40, 435, DateTimeKind.Local).AddTicks(7988), "Quod et quod dignissimos pariatur.", "Intelligent Metal Car", "21501f59-bec6-46b2-a6b4-db238ad919ad", 7, new DateTime(2025, 8, 17, 17, 18, 12, 774, DateTimeKind.Local).AddTicks(8502) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 774, DateTimeKind.Local).AddTicks(8615), new DateTime(2025, 8, 17, 17, 18, 12, 774, DateTimeKind.Local).AddTicks(8616), 369.11m, new DateTime(2024, 9, 8, 1, 37, 13, 366, DateTimeKind.Local).AddTicks(3845), "Quia voluptate et voluptas sit ab est eveniet.", "Rustic Soft Shoes", "6234a291-657c-4749-9f60-b05424a4193e", 8, new DateTime(2025, 8, 17, 17, 18, 12, 774, DateTimeKind.Local).AddTicks(8616) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 774, DateTimeKind.Local).AddTicks(8807), new DateTime(2025, 8, 17, 17, 18, 12, 774, DateTimeKind.Local).AddTicks(8809), 418.17m, new DateTime(2024, 12, 24, 8, 3, 45, 530, DateTimeKind.Local).AddTicks(4199), "Atque aut earum at aut aperiam et voluptate reprehenderit facilis.", "Unbranded Cotton Bacon", "742f9082-9abc-4b27-929e-d3dc3745e5b9", 8, new DateTime(2025, 8, 17, 17, 18, 12, 774, DateTimeKind.Local).AddTicks(8811) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 774, DateTimeKind.Local).AddTicks(8927), new DateTime(2025, 8, 17, 17, 18, 12, 774, DateTimeKind.Local).AddTicks(8928), 837.16m, new DateTime(2025, 5, 29, 22, 4, 47, 585, DateTimeKind.Local).AddTicks(7446), "İncidunt et sint quae.", "Intelligent Steel Gloves", "f988c4bd-6a02-40ee-a7bc-e4ffe94d7e6a", 6, new DateTime(2025, 8, 17, 17, 18, 12, 774, DateTimeKind.Local).AddTicks(8928) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 774, DateTimeKind.Local).AddTicks(8981), new DateTime(2025, 8, 17, 17, 18, 12, 774, DateTimeKind.Local).AddTicks(8981), 881.28m, new DateTime(2024, 12, 10, 7, 12, 3, 177, DateTimeKind.Local).AddTicks(8546), "Quo veritatis quos provident qui ea eum ratione quia voluptatem.", "Generic Granite Mouse", "4fb0c846-a57c-4144-b42d-a30b55fb804e", 6, new DateTime(2025, 8, 17, 17, 18, 12, 774, DateTimeKind.Local).AddTicks(8982) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 774, DateTimeKind.Local).AddTicks(9060), new DateTime(2025, 8, 17, 17, 18, 12, 774, DateTimeKind.Local).AddTicks(9061), 623.50m, new DateTime(2025, 7, 3, 2, 49, 47, 923, DateTimeKind.Local).AddTicks(5420), "Optio fuga ullam laborum.", "Small Soft Pants", "6ea80e93-7485-4687-be7b-e05c405b7f6e", 6, new DateTime(2025, 8, 17, 17, 18, 12, 774, DateTimeKind.Local).AddTicks(9061) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 774, DateTimeKind.Local).AddTicks(9161), new DateTime(2025, 8, 17, 17, 18, 12, 774, DateTimeKind.Local).AddTicks(9162), 978.14m, new DateTime(2025, 4, 2, 18, 48, 7, 477, DateTimeKind.Local).AddTicks(375), "Reiciendis id corrupti.", "Refined Granite Soap", "f5d083bf-ea71-4f8f-89f9-2b0144f4da46", 1, new DateTime(2025, 8, 17, 17, 18, 12, 774, DateTimeKind.Local).AddTicks(9163) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 774, DateTimeKind.Local).AddTicks(9760), new DateTime(2025, 8, 17, 17, 18, 12, 774, DateTimeKind.Local).AddTicks(9763), 570.35m, new DateTime(2025, 3, 20, 17, 37, 49, 334, DateTimeKind.Local).AddTicks(8880), "Eum laudantium quia et aspernatur aut voluptatibus laborum qui.", "Small Rubber Cheese", "1c4b873d-81d8-4791-8564-2e2102fe694e", 7, new DateTime(2025, 8, 17, 17, 18, 12, 774, DateTimeKind.Local).AddTicks(9764) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 5, 12, 19, 55, 20, 549, DateTimeKind.Local).AddTicks(7208), new DateTime(2027, 3, 24, 22, 1, 25, 661, DateTimeKind.Local).AddTicks(190), new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(6830), 9, new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(6831), "9630df5e-83d3-4b45-a4ed-874c94d83c70", 16, 2177.41m, new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(6832) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 5, 4, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(8341), new DateTime(2026, 6, 17, 9, 57, 15, 14, DateTimeKind.Local).AddTicks(211), new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(7154), 2, new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(7154), "53b4a94b-c3ed-4c88-8789-4abdd1073966", 44, 2486.28m, new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(7155) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 27, 11, 33, 35, 895, DateTimeKind.Local).AddTicks(9550), new DateTime(2026, 8, 24, 5, 40, 50, 818, DateTimeKind.Local).AddTicks(2558), new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(7192), 6, new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(7192), "1256022f-c7b7-4b15-9edc-29ef9c7f5ef1", 26, 1902.39m, new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 22, 20, 41, 1, 134, DateTimeKind.Local).AddTicks(4498), new DateTime(2026, 11, 24, 11, 17, 16, 536, DateTimeKind.Local).AddTicks(4751), new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(7218), 3, new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(7218), "137645b2-540b-4a24-a00a-30ccd9f06c10", 36, 2164.64m, new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 7, 16, 33, 44, 331, DateTimeKind.Local).AddTicks(234), new DateTime(2026, 3, 27, 15, 10, 47, 888, DateTimeKind.Local).AddTicks(8763), new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(7240), 8, new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(7240), "21890b32-58b2-4b9f-9771-2860eb31f50f", 10, 1930.35m, new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(7241) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 14, 6, 29, 649, DateTimeKind.Local).AddTicks(4411), new DateTime(2026, 5, 2, 19, 14, 44, 471, DateTimeKind.Local).AddTicks(6573), new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(7270), new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(7270), "9990728b-62ed-4ab5-80e4-04d3c5f1e433", 27, 2400.95m, new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(7271) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 12, 18, 16, 27, 54, 563, DateTimeKind.Local).AddTicks(4577), new DateTime(2026, 10, 9, 2, 8, 42, 744, DateTimeKind.Local).AddTicks(8234), new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(7363), 6, new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(7363), "1d2228ed-a40e-4062-83ec-eeff4c096a23", 11, 2355.90m, new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(7364) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 6, 13, 10, 1, 24, 371, DateTimeKind.Local).AddTicks(4244), new DateTime(2026, 12, 10, 6, 3, 14, 193, DateTimeKind.Local).AddTicks(4276), new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(7386), 7, new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(7386), "cb05f504-aba4-42c7-9c28-eeddc0032e36", 14, 2057.56m, new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(7387) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 4, 22, 33, 41, 168, DateTimeKind.Local).AddTicks(1015), new DateTime(2025, 12, 10, 4, 10, 13, 307, DateTimeKind.Local).AddTicks(3460), new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(7408), 7, new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(7408), "5eefc946-e4b3-41c5-b646-a3c5762885c7", 2200.66m, new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(7409) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 1, 4, 3, 8, 64, DateTimeKind.Local).AddTicks(172), new DateTime(2026, 9, 13, 13, 36, 1, 767, DateTimeKind.Local).AddTicks(8333), new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(7434), 6, new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(7435), "13985669-0d79-4de9-9a09-18d71b0b726f", 46, 2088.64m, new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(7435) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 683, DateTimeKind.Local).AddTicks(5545), new DateTime(2025, 8, 17, 17, 18, 12, 683, DateTimeKind.Local).AddTicks(5556), "4cc2a3af-5e43-432e-abb9-5fe79749b91b", new DateTime(2025, 8, 17, 17, 18, 12, 683, DateTimeKind.Local).AddTicks(5556) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 685, DateTimeKind.Local).AddTicks(23), new DateTime(2025, 8, 17, 17, 18, 12, 685, DateTimeKind.Local).AddTicks(33), "c01e7fa0-60b1-4141-8d93-6255c97ede02", new DateTime(2025, 8, 17, 17, 18, 12, 685, DateTimeKind.Local).AddTicks(34) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 686, DateTimeKind.Local).AddTicks(3961), new DateTime(2025, 8, 17, 17, 18, 12, 686, DateTimeKind.Local).AddTicks(3969), "7368ada2-8eb2-4825-ae4b-603d540613ac", new DateTime(2025, 8, 17, 17, 18, 12, 686, DateTimeKind.Local).AddTicks(3970) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 688, DateTimeKind.Local).AddTicks(97), new DateTime(2025, 8, 17, 17, 18, 12, 688, DateTimeKind.Local).AddTicks(103), "b01427d8-c637-412d-bf56-304422359cc9", new DateTime(2025, 8, 17, 17, 18, 12, 688, DateTimeKind.Local).AddTicks(104) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 689, DateTimeKind.Local).AddTicks(6782), new DateTime(2025, 8, 17, 17, 18, 12, 689, DateTimeKind.Local).AddTicks(6788), "7be86815-78ee-435a-9d06-502bc8df69dd", new DateTime(2025, 8, 17, 17, 18, 12, 689, DateTimeKind.Local).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 691, DateTimeKind.Local).AddTicks(2712), new DateTime(2025, 8, 17, 17, 18, 12, 691, DateTimeKind.Local).AddTicks(2718), "34a3ce3c-71f3-4b5f-bc16-6a87b15c7a2e", new DateTime(2025, 8, 17, 17, 18, 12, 691, DateTimeKind.Local).AddTicks(2719) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 693, DateTimeKind.Local).AddTicks(1418), new DateTime(2025, 8, 17, 17, 18, 12, 693, DateTimeKind.Local).AddTicks(1424), "602f169a-ac7d-4bf0-bc64-e8903043e305", new DateTime(2025, 8, 17, 17, 18, 12, 693, DateTimeKind.Local).AddTicks(1425) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 694, DateTimeKind.Local).AddTicks(8437), new DateTime(2025, 8, 17, 17, 18, 12, 694, DateTimeKind.Local).AddTicks(8442), "dce7c6cd-ad83-4ed1-af3e-1634b49f2dcd", new DateTime(2025, 8, 17, 17, 18, 12, 694, DateTimeKind.Local).AddTicks(8443) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 696, DateTimeKind.Local).AddTicks(3306), new DateTime(2025, 8, 17, 17, 18, 12, 696, DateTimeKind.Local).AddTicks(3311), "c5bb4857-7a2e-438d-8f2b-f2888fccd48b", new DateTime(2025, 8, 17, 17, 18, 12, 696, DateTimeKind.Local).AddTicks(3312) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 697, DateTimeKind.Local).AddTicks(7439), new DateTime(2025, 8, 17, 17, 18, 12, 697, DateTimeKind.Local).AddTicks(7444), "3a081a69-8412-4643-bbb9-4c4d6702a603", new DateTime(2025, 8, 17, 17, 18, 12, 697, DateTimeKind.Local).AddTicks(7445) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 699, DateTimeKind.Local).AddTicks(1375), new DateTime(2025, 8, 17, 17, 18, 12, 699, DateTimeKind.Local).AddTicks(1379), "59d71846-a3f3-4da1-b660-7ac0cb2f8bfb", new DateTime(2025, 8, 17, 17, 18, 12, 699, DateTimeKind.Local).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 700, DateTimeKind.Local).AddTicks(3992), new DateTime(2025, 8, 17, 17, 18, 12, 700, DateTimeKind.Local).AddTicks(3997), "14a6d282-7d93-42de-a797-5f4bb3bd1dcb", new DateTime(2025, 8, 17, 17, 18, 12, 700, DateTimeKind.Local).AddTicks(3997) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 701, DateTimeKind.Local).AddTicks(6298), new DateTime(2025, 8, 17, 17, 18, 12, 701, DateTimeKind.Local).AddTicks(6302), "6e583d59-a3c0-4726-9789-986a1949cc43", new DateTime(2025, 8, 17, 17, 18, 12, 701, DateTimeKind.Local).AddTicks(6302) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 702, DateTimeKind.Local).AddTicks(9540), new DateTime(2025, 8, 17, 17, 18, 12, 702, DateTimeKind.Local).AddTicks(9544), "1f80a70a-fb0b-46a1-b131-d76f8e13f36f", new DateTime(2025, 8, 17, 17, 18, 12, 702, DateTimeKind.Local).AddTicks(9545) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 704, DateTimeKind.Local).AddTicks(3908), new DateTime(2025, 8, 17, 17, 18, 12, 704, DateTimeKind.Local).AddTicks(3914), "3fe3de22-9f65-47c2-834a-ada2dbe43db6", new DateTime(2025, 8, 17, 17, 18, 12, 704, DateTimeKind.Local).AddTicks(3915) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 705, DateTimeKind.Local).AddTicks(9938), new DateTime(2025, 8, 17, 17, 18, 12, 705, DateTimeKind.Local).AddTicks(9945), "566d371b-1a78-4bcc-aceb-ffec8ed32d2f", new DateTime(2025, 8, 17, 17, 18, 12, 705, DateTimeKind.Local).AddTicks(9946) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 707, DateTimeKind.Local).AddTicks(6512), new DateTime(2025, 8, 17, 17, 18, 12, 707, DateTimeKind.Local).AddTicks(6518), "88c33ccf-9033-43bb-b80e-2f0dccdcdb20", new DateTime(2025, 8, 17, 17, 18, 12, 707, DateTimeKind.Local).AddTicks(6518) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 709, DateTimeKind.Local).AddTicks(156), new DateTime(2025, 8, 17, 17, 18, 12, 709, DateTimeKind.Local).AddTicks(162), "d748f116-4ff7-4acd-b212-d30ca0b011e9", new DateTime(2025, 8, 17, 17, 18, 12, 709, DateTimeKind.Local).AddTicks(163) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 710, DateTimeKind.Local).AddTicks(4767), new DateTime(2025, 8, 17, 17, 18, 12, 710, DateTimeKind.Local).AddTicks(4771), "44ebc36e-3a7a-4e14-9271-fa6a523c5f6d", new DateTime(2025, 8, 17, 17, 18, 12, 710, DateTimeKind.Local).AddTicks(4772) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 711, DateTimeKind.Local).AddTicks(8328), new DateTime(2025, 8, 17, 17, 18, 12, 711, DateTimeKind.Local).AddTicks(8332), "8a7c50a4-e034-4bc1-a427-d7522db5f8e0", new DateTime(2025, 8, 17, 17, 18, 12, 711, DateTimeKind.Local).AddTicks(8333) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 713, DateTimeKind.Local).AddTicks(1032), new DateTime(2025, 8, 17, 17, 18, 12, 713, DateTimeKind.Local).AddTicks(1037), "1c0bb4c4-b06c-456d-a633-519251cc4627", new DateTime(2025, 8, 17, 17, 18, 12, 713, DateTimeKind.Local).AddTicks(1039) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 714, DateTimeKind.Local).AddTicks(2823), new DateTime(2025, 8, 17, 17, 18, 12, 714, DateTimeKind.Local).AddTicks(2828), "2ff2e588-cfeb-43f2-93dd-a62882075702", new DateTime(2025, 8, 17, 17, 18, 12, 714, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 715, DateTimeKind.Local).AddTicks(3748), new DateTime(2025, 8, 17, 17, 18, 12, 715, DateTimeKind.Local).AddTicks(3752), "d7376cf6-5491-4ac5-bbd5-d856c43bb9de", new DateTime(2025, 8, 17, 17, 18, 12, 715, DateTimeKind.Local).AddTicks(3752) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 716, DateTimeKind.Local).AddTicks(3871), new DateTime(2025, 8, 17, 17, 18, 12, 716, DateTimeKind.Local).AddTicks(3874), "b255ec78-0bcd-47cb-8901-dd265dd9a006", new DateTime(2025, 8, 17, 17, 18, 12, 716, DateTimeKind.Local).AddTicks(3875) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 717, DateTimeKind.Local).AddTicks(3181), new DateTime(2025, 8, 17, 17, 18, 12, 717, DateTimeKind.Local).AddTicks(3184), "f5b438b7-3320-41eb-bb60-a4cba575d128", new DateTime(2025, 8, 17, 17, 18, 12, 717, DateTimeKind.Local).AddTicks(3185) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 718, DateTimeKind.Local).AddTicks(2398), new DateTime(2025, 8, 17, 17, 18, 12, 718, DateTimeKind.Local).AddTicks(2401), "2d09fe07-29a5-4123-bed7-d720494ba2a3", new DateTime(2025, 8, 17, 17, 18, 12, 718, DateTimeKind.Local).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 719, DateTimeKind.Local).AddTicks(1671), new DateTime(2025, 8, 17, 17, 18, 12, 719, DateTimeKind.Local).AddTicks(1674), "e4aae309-e0d2-4657-8340-44e95ec50cc6", new DateTime(2025, 8, 17, 17, 18, 12, 719, DateTimeKind.Local).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 720, DateTimeKind.Local).AddTicks(1846), new DateTime(2025, 8, 17, 17, 18, 12, 720, DateTimeKind.Local).AddTicks(1849), "d86645fc-2c61-43f0-8b0d-280e5d146362", new DateTime(2025, 8, 17, 17, 18, 12, 720, DateTimeKind.Local).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 721, DateTimeKind.Local).AddTicks(837), new DateTime(2025, 8, 17, 17, 18, 12, 721, DateTimeKind.Local).AddTicks(840), "3fa0ab2d-dd9d-4ffa-8da4-77a2c37d7f05", new DateTime(2025, 8, 17, 17, 18, 12, 721, DateTimeKind.Local).AddTicks(841) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 721, DateTimeKind.Local).AddTicks(9656), new DateTime(2025, 8, 17, 17, 18, 12, 721, DateTimeKind.Local).AddTicks(9659), "35953deb-65e1-4e58-b5da-0b79fb0c5e80", new DateTime(2025, 8, 17, 17, 18, 12, 721, DateTimeKind.Local).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 722, DateTimeKind.Local).AddTicks(8770), new DateTime(2025, 8, 17, 17, 18, 12, 722, DateTimeKind.Local).AddTicks(8773), "4746f59c-ff2e-49d8-b20c-19ea7f7fe1ff", new DateTime(2025, 8, 17, 17, 18, 12, 722, DateTimeKind.Local).AddTicks(8774) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 723, DateTimeKind.Local).AddTicks(7552), new DateTime(2025, 8, 17, 17, 18, 12, 723, DateTimeKind.Local).AddTicks(7555), "9969762f-91d8-4097-b55d-0e66f5b5f140", new DateTime(2025, 8, 17, 17, 18, 12, 723, DateTimeKind.Local).AddTicks(7555) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 724, DateTimeKind.Local).AddTicks(6559), new DateTime(2025, 8, 17, 17, 18, 12, 724, DateTimeKind.Local).AddTicks(6562), "f9b6b290-56a2-4bab-84e3-6735990d0514", new DateTime(2025, 8, 17, 17, 18, 12, 724, DateTimeKind.Local).AddTicks(6562) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 725, DateTimeKind.Local).AddTicks(5494), new DateTime(2025, 8, 17, 17, 18, 12, 725, DateTimeKind.Local).AddTicks(5497), "a90ebdc9-980d-4946-af52-b81069357a68", new DateTime(2025, 8, 17, 17, 18, 12, 725, DateTimeKind.Local).AddTicks(5497) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 726, DateTimeKind.Local).AddTicks(4840), new DateTime(2025, 8, 17, 17, 18, 12, 726, DateTimeKind.Local).AddTicks(4844), "5f66723c-f2f7-4f01-80c6-e473c7afb471", new DateTime(2025, 8, 17, 17, 18, 12, 726, DateTimeKind.Local).AddTicks(4844) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 727, DateTimeKind.Local).AddTicks(4775), new DateTime(2025, 8, 17, 17, 18, 12, 727, DateTimeKind.Local).AddTicks(4778), "2b3579ed-1122-468d-ae41-7e84a0d2dc91", new DateTime(2025, 8, 17, 17, 18, 12, 727, DateTimeKind.Local).AddTicks(4778) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 728, DateTimeKind.Local).AddTicks(3535), new DateTime(2025, 8, 17, 17, 18, 12, 728, DateTimeKind.Local).AddTicks(3537), "aed5579e-6b48-4a8e-a2cf-7550087e5234", new DateTime(2025, 8, 17, 17, 18, 12, 728, DateTimeKind.Local).AddTicks(3538) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 729, DateTimeKind.Local).AddTicks(2728), new DateTime(2025, 8, 17, 17, 18, 12, 729, DateTimeKind.Local).AddTicks(2731), "481e0e29-2578-4bec-b1f1-f8578b9ca4fd", new DateTime(2025, 8, 17, 17, 18, 12, 729, DateTimeKind.Local).AddTicks(2732) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 730, DateTimeKind.Local).AddTicks(1753), new DateTime(2025, 8, 17, 17, 18, 12, 730, DateTimeKind.Local).AddTicks(1755), "7952040a-7606-4066-8512-c3c96d0b8d48", new DateTime(2025, 8, 17, 17, 18, 12, 730, DateTimeKind.Local).AddTicks(1756) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 731, DateTimeKind.Local).AddTicks(549), new DateTime(2025, 8, 17, 17, 18, 12, 731, DateTimeKind.Local).AddTicks(552), "78cffbb7-a279-4193-87fd-deec74e7dc94", new DateTime(2025, 8, 17, 17, 18, 12, 731, DateTimeKind.Local).AddTicks(552) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 731, DateTimeKind.Local).AddTicks(9526), new DateTime(2025, 8, 17, 17, 18, 12, 731, DateTimeKind.Local).AddTicks(9529), "95cd27c1-8cdd-40a4-9816-fe0792ff4be8", new DateTime(2025, 8, 17, 17, 18, 12, 731, DateTimeKind.Local).AddTicks(9529) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 732, DateTimeKind.Local).AddTicks(8597), new DateTime(2025, 8, 17, 17, 18, 12, 732, DateTimeKind.Local).AddTicks(8600), "0979ccfd-70e6-4d47-92fc-76b4b8eed124", new DateTime(2025, 8, 17, 17, 18, 12, 732, DateTimeKind.Local).AddTicks(8601) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 733, DateTimeKind.Local).AddTicks(9257), new DateTime(2025, 8, 17, 17, 18, 12, 733, DateTimeKind.Local).AddTicks(9261), "9d10db8d-0c06-414c-b964-8fd4ac7321fb", new DateTime(2025, 8, 17, 17, 18, 12, 733, DateTimeKind.Local).AddTicks(9262) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 734, DateTimeKind.Local).AddTicks(8413), new DateTime(2025, 8, 17, 17, 18, 12, 734, DateTimeKind.Local).AddTicks(8415), "70a4d431-0792-4b8a-afe9-17c2acc4f34d", new DateTime(2025, 8, 17, 17, 18, 12, 734, DateTimeKind.Local).AddTicks(8416) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 735, DateTimeKind.Local).AddTicks(7440), new DateTime(2025, 8, 17, 17, 18, 12, 735, DateTimeKind.Local).AddTicks(7442), "9cfde314-e7a9-4cd0-8164-5a9505e2be98", new DateTime(2025, 8, 17, 17, 18, 12, 735, DateTimeKind.Local).AddTicks(7443) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 736, DateTimeKind.Local).AddTicks(6487), new DateTime(2025, 8, 17, 17, 18, 12, 736, DateTimeKind.Local).AddTicks(6490), "c3669515-b271-48db-9a38-488aeb315963", new DateTime(2025, 8, 17, 17, 18, 12, 736, DateTimeKind.Local).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 737, DateTimeKind.Local).AddTicks(5421), new DateTime(2025, 8, 17, 17, 18, 12, 737, DateTimeKind.Local).AddTicks(5424), "626392e4-bd3f-4d26-902b-26667226891c", new DateTime(2025, 8, 17, 17, 18, 12, 737, DateTimeKind.Local).AddTicks(5424) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 738, DateTimeKind.Local).AddTicks(4364), new DateTime(2025, 8, 17, 17, 18, 12, 738, DateTimeKind.Local).AddTicks(4367), "10aa2c88-6961-4a4d-b3c7-b5d49599ebd2", new DateTime(2025, 8, 17, 17, 18, 12, 738, DateTimeKind.Local).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 739, DateTimeKind.Local).AddTicks(3548), new DateTime(2025, 8, 17, 17, 18, 12, 739, DateTimeKind.Local).AddTicks(3551), "e61f415c-cc47-4aeb-841a-90cae27411e5", new DateTime(2025, 8, 17, 17, 18, 12, 739, DateTimeKind.Local).AddTicks(3552) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 740, DateTimeKind.Local).AddTicks(2884), new DateTime(2025, 8, 17, 17, 18, 12, 740, DateTimeKind.Local).AddTicks(2887), "425435a7-a8e2-4b24-bb0f-9c33137a8155", new DateTime(2025, 8, 17, 17, 18, 12, 740, DateTimeKind.Local).AddTicks(2888) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 741, DateTimeKind.Local).AddTicks(3613), new DateTime(2025, 8, 17, 17, 18, 12, 741, DateTimeKind.Local).AddTicks(3617), "9690b00f-5ca7-4ac2-8c62-977129df3fb9", new DateTime(2025, 8, 17, 17, 18, 12, 741, DateTimeKind.Local).AddTicks(3618) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 742, DateTimeKind.Local).AddTicks(2864), new DateTime(2025, 8, 17, 17, 18, 12, 742, DateTimeKind.Local).AddTicks(2867), "3bf39f29-5e21-405a-9e5e-d77a20f7f08c", new DateTime(2025, 8, 17, 17, 18, 12, 742, DateTimeKind.Local).AddTicks(2868) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 743, DateTimeKind.Local).AddTicks(2108), new DateTime(2025, 8, 17, 17, 18, 12, 743, DateTimeKind.Local).AddTicks(2111), "bacccabd-3fa6-4281-a164-f39538d6cbc0", new DateTime(2025, 8, 17, 17, 18, 12, 743, DateTimeKind.Local).AddTicks(2112) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 744, DateTimeKind.Local).AddTicks(1110), new DateTime(2025, 8, 17, 17, 18, 12, 744, DateTimeKind.Local).AddTicks(1113), "d6149f0e-f272-444f-b4c6-10374a87e5d8", new DateTime(2025, 8, 17, 17, 18, 12, 744, DateTimeKind.Local).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 745, DateTimeKind.Local).AddTicks(126), new DateTime(2025, 8, 17, 17, 18, 12, 745, DateTimeKind.Local).AddTicks(129), "0c69c98f-7bc9-41d7-be17-adccba5aebdd", new DateTime(2025, 8, 17, 17, 18, 12, 745, DateTimeKind.Local).AddTicks(130) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 745, DateTimeKind.Local).AddTicks(9211), new DateTime(2025, 8, 17, 17, 18, 12, 745, DateTimeKind.Local).AddTicks(9214), "c908ff9c-055a-4345-93c8-96670075a003", new DateTime(2025, 8, 17, 17, 18, 12, 745, DateTimeKind.Local).AddTicks(9214) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 746, DateTimeKind.Local).AddTicks(8168), new DateTime(2025, 8, 17, 17, 18, 12, 746, DateTimeKind.Local).AddTicks(8170), "17998d65-b6b6-414a-8aea-e0d2929e30cc", new DateTime(2025, 8, 17, 17, 18, 12, 746, DateTimeKind.Local).AddTicks(8171) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 747, DateTimeKind.Local).AddTicks(8625), new DateTime(2025, 8, 17, 17, 18, 12, 747, DateTimeKind.Local).AddTicks(8630), "0335b123-e191-47b5-9eb7-6c62171edb42", new DateTime(2025, 8, 17, 17, 18, 12, 747, DateTimeKind.Local).AddTicks(8632) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 748, DateTimeKind.Local).AddTicks(7911), new DateTime(2025, 8, 17, 17, 18, 12, 748, DateTimeKind.Local).AddTicks(7914), "5aaa8300-92e9-46b3-a371-eeb841b70e53", new DateTime(2025, 8, 17, 17, 18, 12, 748, DateTimeKind.Local).AddTicks(7915) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 749, DateTimeKind.Local).AddTicks(7459), new DateTime(2025, 8, 17, 17, 18, 12, 749, DateTimeKind.Local).AddTicks(7461), "49bcac0b-020f-4d49-ad53-cf12566b8dd7", new DateTime(2025, 8, 17, 17, 18, 12, 749, DateTimeKind.Local).AddTicks(7462) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 750, DateTimeKind.Local).AddTicks(7552), new DateTime(2025, 8, 17, 17, 18, 12, 750, DateTimeKind.Local).AddTicks(7557), "a4b1da32-b508-4f29-aa46-99e702052013", new DateTime(2025, 8, 17, 17, 18, 12, 750, DateTimeKind.Local).AddTicks(7557) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 751, DateTimeKind.Local).AddTicks(6645), new DateTime(2025, 8, 17, 17, 18, 12, 751, DateTimeKind.Local).AddTicks(6649), "7c44283a-094a-43b1-b4fb-d6e468301324", new DateTime(2025, 8, 17, 17, 18, 12, 751, DateTimeKind.Local).AddTicks(6649) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 752, DateTimeKind.Local).AddTicks(5719), new DateTime(2025, 8, 17, 17, 18, 12, 752, DateTimeKind.Local).AddTicks(5722), "869171c7-9af1-4f11-9e0c-6cb85a7a7546", new DateTime(2025, 8, 17, 17, 18, 12, 752, DateTimeKind.Local).AddTicks(5723) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 753, DateTimeKind.Local).AddTicks(4884), new DateTime(2025, 8, 17, 17, 18, 12, 753, DateTimeKind.Local).AddTicks(4887), "11879ae6-1910-48ab-9a9e-ca9dd147d4f8", new DateTime(2025, 8, 17, 17, 18, 12, 753, DateTimeKind.Local).AddTicks(4888) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 754, DateTimeKind.Local).AddTicks(6019), new DateTime(2025, 8, 17, 17, 18, 12, 754, DateTimeKind.Local).AddTicks(6023), "9fd46890-fc88-4560-a9a2-7be3833477d3", new DateTime(2025, 8, 17, 17, 18, 12, 754, DateTimeKind.Local).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 755, DateTimeKind.Local).AddTicks(7163), new DateTime(2025, 8, 17, 17, 18, 12, 755, DateTimeKind.Local).AddTicks(7168), "e18bab8d-a341-4ef4-a3b9-21d936aea39d", new DateTime(2025, 8, 17, 17, 18, 12, 755, DateTimeKind.Local).AddTicks(7169) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 756, DateTimeKind.Local).AddTicks(7620), new DateTime(2025, 8, 17, 17, 18, 12, 756, DateTimeKind.Local).AddTicks(7624), "5b10c163-e519-42fe-9831-04af796d2fee", new DateTime(2025, 8, 17, 17, 18, 12, 756, DateTimeKind.Local).AddTicks(7624) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 757, DateTimeKind.Local).AddTicks(8772), new DateTime(2025, 8, 17, 17, 18, 12, 757, DateTimeKind.Local).AddTicks(8776), "f5a73e63-6840-4e85-8a3d-be2f08d944aa", new DateTime(2025, 8, 17, 17, 18, 12, 757, DateTimeKind.Local).AddTicks(8777) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 759, DateTimeKind.Local).AddTicks(1512), new DateTime(2025, 8, 17, 17, 18, 12, 759, DateTimeKind.Local).AddTicks(1516), "b0069f86-5575-493e-b012-2bd74eca8d4b", new DateTime(2025, 8, 17, 17, 18, 12, 759, DateTimeKind.Local).AddTicks(1517) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 760, DateTimeKind.Local).AddTicks(4969), new DateTime(2025, 8, 17, 17, 18, 12, 760, DateTimeKind.Local).AddTicks(4974), "6533cb40-6c85-46d3-b5cc-6913de82604d", new DateTime(2025, 8, 17, 17, 18, 12, 760, DateTimeKind.Local).AddTicks(4975) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 762, DateTimeKind.Local).AddTicks(1322), new DateTime(2025, 8, 17, 17, 18, 12, 762, DateTimeKind.Local).AddTicks(1332), "924a0632-9395-46e0-99be-7c662613e86a", new DateTime(2025, 8, 17, 17, 18, 12, 762, DateTimeKind.Local).AddTicks(1332) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 763, DateTimeKind.Local).AddTicks(7369), new DateTime(2025, 8, 17, 17, 18, 12, 763, DateTimeKind.Local).AddTicks(7375), "81c1e46a-903e-4381-8bac-06d33aa529a2", new DateTime(2025, 8, 17, 17, 18, 12, 763, DateTimeKind.Local).AddTicks(7376) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 765, DateTimeKind.Local).AddTicks(5504), new DateTime(2025, 8, 17, 17, 18, 12, 765, DateTimeKind.Local).AddTicks(5510), "2faacbb6-142e-4bf0-83d9-f3b1a77fbea3", new DateTime(2025, 8, 17, 17, 18, 12, 765, DateTimeKind.Local).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 767, DateTimeKind.Local).AddTicks(1204), new DateTime(2025, 8, 17, 17, 18, 12, 767, DateTimeKind.Local).AddTicks(1211), "b7ddf963-d07c-4482-a918-dd8ffdb93777", new DateTime(2025, 8, 17, 17, 18, 12, 767, DateTimeKind.Local).AddTicks(1212) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 770, DateTimeKind.Local).AddTicks(1172), new DateTime(2025, 8, 17, 17, 18, 12, 770, DateTimeKind.Local).AddTicks(1185), "bcdeb609-a981-4d90-a677-8bca44657a36", new DateTime(2025, 8, 17, 17, 18, 12, 770, DateTimeKind.Local).AddTicks(1186) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 771, DateTimeKind.Local).AddTicks(9886), new DateTime(2025, 8, 17, 17, 18, 12, 771, DateTimeKind.Local).AddTicks(9892), "7bb849cb-ea81-4c43-8cbc-30fd2b67be2b", new DateTime(2025, 8, 17, 17, 18, 12, 771, DateTimeKind.Local).AddTicks(9892) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 773, DateTimeKind.Local).AddTicks(584), new DateTime(2025, 8, 17, 17, 18, 12, 773, DateTimeKind.Local).AddTicks(588), "917a546b-85ec-4334-9245-4235eb0d9322", new DateTime(2025, 8, 17, 17, 18, 12, 773, DateTimeKind.Local).AddTicks(589) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4270), new DateTime(2025, 8, 17, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4271), "7a6aa9c2-43dc-4789-b066-5308f7075ff1", new DateTime(2025, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4272) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4323), new DateTime(2025, 8, 17, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4324), "bd3af0d5-7d77-4126-a5e3-65c09a40f80d", new DateTime(2025, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4334), new DateTime(2025, 8, 17, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4335), "edffcdd8-0b72-4b91-8359-783363a68fd7", new DateTime(2025, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4335) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4344), new DateTime(2025, 8, 17, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4344), "06b40a5a-2174-4021-8914-917d79b378b2", new DateTime(2025, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4344) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4361), new DateTime(2025, 8, 18, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4361), "45252421-8fdb-452c-b42f-771633a82994", new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 18, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4362) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4371), new DateTime(2025, 8, 18, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4371), "6592006a-f93e-4bde-be61-b80466d7dfa5", new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 18, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4372) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4386), new DateTime(2025, 8, 18, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4386), "32b98eb4-67bb-4192-8fe5-6d96898531cd", new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 18, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4387) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4394), new DateTime(2025, 8, 18, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4394), "75b048ba-7852-4424-b6c0-c25760997f99", new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 18, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4395) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4407), new DateTime(2025, 8, 19, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4407), "3a0fefe6-9283-420d-b06d-82304eb93123", new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 19, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4408) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4416), new DateTime(2025, 8, 19, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4416), "8f68d73e-1cf0-42b2-9ebf-8fa71a0c6c01", new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 19, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4417) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4424), new DateTime(2025, 8, 19, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4424), "5d343c7a-ef46-4744-adbd-cf74fd3460a9", new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 19, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4425) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4431), new DateTime(2025, 8, 19, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4432), "6137e05a-656a-44a1-af5e-c5cbda1ee1cc", new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 19, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4432) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4444), new DateTime(2025, 8, 20, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4445), "99f0651f-52a2-433a-9261-19fa9b67bf74", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 20, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4445) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4532), new DateTime(2025, 8, 20, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4533), "922899ad-6744-4699-969c-75bb7699aa56", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 20, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4533) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4545), new DateTime(2025, 8, 20, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4546), "081f2363-1d19-4563-b625-cbbf6bfdac89", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 20, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4546) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4553), new DateTime(2025, 8, 20, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4554), "9c17f224-18ab-4b4b-8ea1-adb5b37964cc", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 20, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4554) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4566), new DateTime(2025, 8, 21, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4566), "80356117-9303-48c5-a68e-b84233a9f404", new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 21, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4567) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4576), new DateTime(2025, 8, 21, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4576), "45f48bcc-15b6-4e77-95d2-ead3295281b7", new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 21, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4584), new DateTime(2025, 8, 21, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4584), "be11324c-c037-4483-9f05-6a2d2405745a", new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 21, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4584) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4591), new DateTime(2025, 8, 21, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4592), "af130b01-1a5a-40a7-9541-302adb93f6f6", new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 21, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4592) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4603), new DateTime(2025, 8, 22, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4603), "12ad4a6f-e74e-4bee-80ea-a98e36307220", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 22, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4604) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4610), new DateTime(2025, 8, 22, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4611), "b62e97df-37bb-4937-ac1b-8255af9cc239", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 22, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4611) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4620), new DateTime(2025, 8, 22, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4621), "ac2bb37c-0b80-46d1-9c42-4e6bd6222cfe", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 22, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4621) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4627), new DateTime(2025, 8, 22, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4628), "198a0f7b-ab69-4577-962d-d53385f847d4", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 22, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4639), new DateTime(2025, 8, 23, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4640), "8744e540-b76a-4563-8cdb-e16b7e2c68fb", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 23, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4640) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4646), new DateTime(2025, 8, 23, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4647), "33ca7a74-f50c-4ad2-8803-11ddab0c811d", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 23, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4647) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4654), new DateTime(2025, 8, 23, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4654), "18fe73fa-b610-4651-9245-fb13e4e91571", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 23, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4655) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4661), new DateTime(2025, 8, 23, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4662), "4b32a169-5539-4972-8de5-340076b00e21", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 23, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4662) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4678), new DateTime(2025, 8, 17, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4678), "50ba1894-f80c-4dc1-9221-c24393683eaf", new DateTime(2025, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4679) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4687), new DateTime(2025, 8, 17, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4688), "c63c3dab-b0ef-4a39-a456-3e2611f437f7", new DateTime(2025, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4688) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4699), new DateTime(2025, 8, 17, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4699), "6921e125-d032-4614-ac22-25cc00619b30", new DateTime(2025, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4707), new DateTime(2025, 8, 17, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4707), "0e63dec2-e153-43a4-968c-5c88c792a6fd", new DateTime(2025, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4708) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4715), new DateTime(2025, 8, 17, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4715), "3f7a69a7-0439-4827-b0dc-b0bc3132bd13", new DateTime(2025, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4716) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4724), new DateTime(2025, 8, 17, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4725), "1651349a-d8f3-430c-88f1-f4dfbf01205b", new DateTime(2025, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4725) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4733), new DateTime(2025, 8, 18, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4733), "80f71765-1e7b-4d8d-98a7-4379dc224cce", new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 18, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4734) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4741), new DateTime(2025, 8, 18, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4741), "0390a370-a982-4af7-9ea2-18d5c96027cc", new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 18, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4742) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4749), new DateTime(2025, 8, 18, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4749), "60408318-bf25-45fd-b90a-01b8f6ebb4f2", new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 18, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4750) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4756), new DateTime(2025, 8, 18, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4757), "abef833c-7932-49f6-936f-b1c54193ddf9", new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 18, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4757) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5059), new DateTime(2025, 8, 18, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5065), "90c52c6e-2fd6-4026-8ea4-00f46da12a42", new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 18, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5066) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5178), new DateTime(2025, 8, 18, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5178), "fd3b0584-70c8-4724-9e98-1c348a189568", new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 18, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5201), new DateTime(2025, 8, 19, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5202), "0a06b65f-57d4-4834-9684-ca685787c8c0", new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 19, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5202) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5210), new DateTime(2025, 8, 19, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5210), "fc2a63eb-a5a6-49ae-b8d4-835f8e4adeb9", new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 19, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5211) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5219), new DateTime(2025, 8, 19, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5219), "9a22ad01-c2e3-4dce-92f7-6ac3d0084ab0", new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 19, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5227), new DateTime(2025, 8, 19, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5227), "19e6ddd0-ce32-4e05-950e-a740eae91ed8", new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 19, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5228) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5235), new DateTime(2025, 8, 19, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5235), "59e88ca4-3e59-4b75-9b02-ce179081a726", new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 19, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5236) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5243), new DateTime(2025, 8, 19, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5243), "561e9982-8c32-4209-910d-bbadac12e42a", new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 19, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5244) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5259), new DateTime(2025, 8, 20, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5260), "e8b0a54a-406b-484a-9ae0-fbee9813d0f9", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 20, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5267), new DateTime(2025, 8, 20, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5267), "63403563-d78a-4014-b1fd-d94ce970bec6", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 20, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5268) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5275), new DateTime(2025, 8, 20, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5275), "4d3237d6-661d-43b0-b20a-e990a066ded6", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 20, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5276) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5282), new DateTime(2025, 8, 20, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5283), "0dd5e728-5811-4dcf-9351-efdf3f031aa4", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 20, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5283) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5290), new DateTime(2025, 8, 20, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5291), "fd3b5fd3-063a-4581-a834-80108dcb8998", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 20, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5291) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5297), new DateTime(2025, 8, 20, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5298), "658e2b4e-52d0-4ee1-9555-f7b0c35dac05", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 20, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5298) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5306), new DateTime(2025, 8, 21, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5306), "6ff658be-c36f-4de6-8e04-2a00b401b7cb", new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 21, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5307) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5313), new DateTime(2025, 8, 21, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5313), "1f39748c-1aa9-4c53-b47e-956e72848992", new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 21, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5314) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5323), new DateTime(2025, 8, 21, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5324), "04ab0f5e-1fcc-46a0-94cf-5da377eb35f2", new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 21, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5324) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5330), new DateTime(2025, 8, 21, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5331), "2ae2a847-2213-4d09-ac52-bb6b64149726", new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 21, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5331) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5338), new DateTime(2025, 8, 21, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5339), "9f8bcaff-1557-4f4c-8a70-cc7007169086", new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 21, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5339) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5345), new DateTime(2025, 8, 21, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5346), "7d72232b-dd14-4cd0-91c4-a77ec864257a", new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 21, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5346) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5354), new DateTime(2025, 8, 22, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5354), "5ab6da5f-5db8-4aad-844d-51f42cdb1514", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 22, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5362), new DateTime(2025, 8, 22, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5362), "80990df2-bc8d-4dd7-a266-6e4cdb2828b2", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 22, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5363) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5370), new DateTime(2025, 8, 22, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5370), "50436aea-8c83-4702-a7fd-ce15b1f7ce83", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 22, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5371) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5377), new DateTime(2025, 8, 22, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5378), "4fe6060a-ab81-4fce-925a-91b896f7add8", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 22, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5378) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5387), new DateTime(2025, 8, 22, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5387), "9fad9fd2-ec9e-4f2e-bbc5-837a86c4f869", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 22, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5388) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5394), new DateTime(2025, 8, 22, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5395), "95fc2e20-59a4-423f-9865-d0ac996a5b72", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 22, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5395) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5403), new DateTime(2025, 8, 23, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5403), "56e09e6e-dbcf-4aae-a151-c0a1099979f7", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 23, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5404) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5424), new DateTime(2025, 8, 23, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5424), "d05b4758-148a-4c45-8750-c50f4d23a59a", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 23, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5424) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5478), new DateTime(2025, 8, 23, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5479), "0f362f66-2a51-4d5c-919c-9bb01b4e2a40", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 23, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5479) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5488), new DateTime(2025, 8, 23, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5489), "f621f5c0-e311-4425-b99b-e669d81e4ebb", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 23, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5489) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5496), new DateTime(2025, 8, 23, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5497), "38944b6b-3914-4fb0-a7b7-0f78bee217ca", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 23, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5497) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5504), new DateTime(2025, 8, 23, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5504), "48b07133-b265-432f-b7cb-203a48da1547", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 23, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5505) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5570), new DateTime(2025, 8, 17, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5571), "afa68388-316e-4fdd-acc0-9c9c3bbe1ead", new DateTime(2025, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5571) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5586), 12, new DateTime(2025, 8, 17, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5587), "a89ffcb0-84be-4bc8-8327-86fb94840ae4", new DateTime(2025, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 17, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5587) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5596), 11, new DateTime(2025, 8, 18, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5596), "66a97d00-e132-4772-bfcc-b19c9168ccfc", new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 18, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5597) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5606), 11, new DateTime(2025, 8, 18, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5607), "e4e25df8-81a9-4d60-a08e-5755c7c06b3e", new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 18, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5607) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5616), 12, new DateTime(2025, 8, 18, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5616), "d01f25e5-4764-45fd-92ef-bdfce76eb9ac", new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 18, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5617) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5624), 11, new DateTime(2025, 8, 19, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5625), "b76b6b8c-a7f0-432d-82c9-57b33be6aeac", new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 19, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5625) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5636), new DateTime(2025, 8, 19, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5637), "1458d725-2339-4dc9-8908-337dae9f7c1a", new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 19, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5644), new DateTime(2025, 8, 19, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5644), "84ce650a-2242-4d04-8d3d-98859ea6a624", new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 19, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5645) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5651), new DateTime(2025, 8, 20, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5652), "3fbfdf09-5a9a-433f-9102-85d74a2e3258", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 20, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5652) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5662), 12, new DateTime(2025, 8, 20, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5663), "c68aea79-b7ae-46dd-89f6-660ebc5843b6", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 20, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5663) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5670), 11, new DateTime(2025, 8, 21, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5671), "01d44356-6cf0-4a01-8d96-a8f48252ab13", new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 21, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5671) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5681), new DateTime(2025, 8, 21, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5682), "40c0c15f-c762-4510-8054-0a27c34afda6", new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 21, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5682) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5688), new DateTime(2025, 8, 21, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5689), "34d5282c-5db9-49a0-8781-1c8c4dafd55a", new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 21, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5689) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5696), 11, new DateTime(2025, 8, 22, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5697), "ba3eead9-131b-42d8-a709-cd2b7d4f3528", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 22, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5697) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5707), 12, new DateTime(2025, 8, 22, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5708), "053013f6-2fd4-4839-aa66-6f53761745a8", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 22, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5708) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5715), 11, new DateTime(2025, 8, 23, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5716), "7f54221b-ad18-43df-936d-b5cf42a0bc52", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 23, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5716) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5727), new DateTime(2025, 8, 23, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5727), "c5d6a6ae-7065-4f45-bbb1-1813665ae5df", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 23, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5728) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5734), new DateTime(2025, 8, 23, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5735), "02c51aa3-63dd-4b94-a1a3-788ce9fbbf3c", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 23, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5735) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Rennerburgh", "Mayotte", new DateTime(2025, 8, 10, 22, 38, 24, 303, DateTimeKind.Local).AddTicks(4127), "359 Kohler Place, Lake Callieburgh, Singapore", "FR078110200285840442EW90257", "453.615.4108", "Alberto55@hotmail.com", new DateTime(2025, 8, 10, 22, 38, 24, 303, DateTimeKind.Local).AddTicks(4142), "Jeromy", "Hane", "f8905259-3b2c-4445-8c79-ab5ce4d63a5d", "50373-9412", new DateTime(2025, 8, 10, 22, 38, 24, 303, DateTimeKind.Local).AddTicks(4143) });

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
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "North Montana", "Dominican Republic", new DateTime(2025, 8, 10, 22, 38, 24, 303, DateTimeKind.Local).AddTicks(6885), "4884 Koch Mount, Windlerstad, Uruguay", "SA390754110Q03DL091M2634", "(416) 517-3118 x42522", "Alexandrea_Carter32@gmail.com", new DateTime(2025, 8, 10, 22, 38, 24, 303, DateTimeKind.Local).AddTicks(6887), "Zoie", "Frami", "3f0c2ff8-2c7e-4882-b6a3-7d8e8bb0379f", "86267-5627", new DateTime(2025, 8, 10, 22, 38, 24, 303, DateTimeKind.Local).AddTicks(6887) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Bolu", "Aruba, Hollanda", new DateTime(2025, 8, 10, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(1139), "Bukaktutuk_Gumuspala12@hotmail.com", "Tevfik Fikret Caddesi 0, Zonguldak, Grönland", "Büktegin", "Limoncuoğlu", "+90-753-584-0-947", new DateTime(2025, 8, 10, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(1139), "753add87-ee98-4e9a-b89b-fee7a6d71476", "1", new DateTime(2025, 8, 10, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(1139) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Çorum", "Cebelitarık, İngiltere", new DateTime(2025, 8, 10, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(1400), "Aladag_Menemencioglu@yahoo.com", "Nalbant Sokak 25c, Mardin, İrlanda", "Barmaklak", "Akşit", "+90-014-871-10-54", new DateTime(2025, 8, 10, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(1400), "feb72734-773b-47ea-af03-a8d5a5aa9050", "0", new DateTime(2025, 8, 10, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(1401) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Kilis", "Burundi", new DateTime(2025, 8, 10, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(1773), "Bakagul_Yetkiner36@hotmail.com", "Fatih Sokak  07a, Kırıkkale, Liberya", "Ay", "Balcı", "+90-024-153-58-40", new DateTime(2025, 8, 10, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(1773), "9798942d-85a2-4327-a96d-0e8b4447eae7", "0", new DateTime(2025, 8, 10, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(1773) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Erzurum", "Çek Cumhuriyeti", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(4060), "Barlas.Agaoglu@yahoo.com", "Güven Yaka Sokak 62b, Afyon, Reunion, Fransa", "Atıgay", "Sarıoğlu", "+90-091-489-16-37", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(4107), "996fd882-bc54-4b7f-a112-6502223899cb", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(4109) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Kırıkkale", "Virgin Adaları, Amerika", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(4879), "Ay.Kaplangi27@yahoo.com", "Kerimoğlu Sokak 035, Erzurum, Vanuatu", "Beğbars", "Karadaş", "+90-775-401-89-22", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(4879), "68fe72b5-ee9e-4aec-894c-698423fea415", "1", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(4880) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Afyon", "Porto Riko, Amerika", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5030), "Buktegin_Erginsoy@gmail.com", "Oğuzhan Sokak 640, Isparta, Hollanda Antilleri", "Bakağul", "Aydan", "+90-415-105-69-46", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5030), "750a1ec0-9d32-41d4-9220-893204944bdf", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5030) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Çorum", "Birleşik Arap Emirlikleri", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5291), "Bidin40@hotmail.com", "Sevgi Sokak 71a, Isparta, Cezayir", "Ağakağan", "Yetkiner", "+90-888-674-4-260", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5292), "7fc3a774-9e88-4f74-ab89-c0c5d4bd475f", "1", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5292) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Tekirdağ", "Kenya", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5418), "Agabay.Akaydin85@yahoo.com", "İsmet Paşa Caddesi 24b, Sivas, Guatemala", "Altankan", "Karadaş", "+90-027-372-4-534", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5419), "da657e44-89e2-4c41-9063-470507a85736", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5419) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Hatay", "Angola", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5874), "Boran46@gmail.com", "Sağlık Sokak 93c, Erzurum, Ermenistan", "Bayboğa", "Kuday", "+90-078-930-26-95", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5874), "41929193-4a07-4f57-8883-f753ccd0030d", "1", new DateTime(2025, 8, 10, 22, 38, 24, 401, DateTimeKind.Local).AddTicks(5874) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Diyarbakır", "Grenada", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(2379), "Bayincur.Ozbey@hotmail.com", "Sarıkaya Caddesi 06c, Muş, Güney Kıbrıs Rum Yönetimi", "Buğrakarakağan", "Ekici", "+90-287-051-7-768", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(2380), "6f03cae5-f1ca-447a-aef3-9cb5e410e962", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(2380) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Trabzon", "Çin", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(2855), "Barsgan.Aydan77@hotmail.com", "Harman Yolu Sokak  30, Kırklareli, Surinam", "Bögde", "Gürmen", "+90-219-975-73-40", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(2856), "513e69ef-30e9-4207-82f1-c63d9595d39e", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(2856) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Nevşehir", "Ruanda", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(3099), "Isig.Balaban@yahoo.com", "Fatih Sokak  4, Şırnak, Galler", "Ekeç", "Topaloğlu", "+90-187-295-62-37", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(3099), "8505668c-a0f5-4f03-9951-b717512809b5", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(3099) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Ankara", "Küba", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(3327), "Boga_Alniacik@yahoo.com", "Kaldırım Sokak 71, Bingöl, Benin", "Buğrakarakağan", "Koç", "+90-549-296-6-283", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(3327), "ac4b7d10-839e-40ae-8345-dbd388102a5f", "1", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(3328) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Kırşehir", "Lübnan", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(3601), "Cagritegin.Erberk@hotmail.com", "Kaldırım Sokak 32b, Gaziantep, Liechtenstein", "Boylakutlutarkan", "Korol", "+90-222-377-06-92", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(3601), "b9aca361-ef06-4133-93ec-fd88fc4b8527", "1", new DateTime(2025, 8, 10, 22, 38, 24, 403, DateTimeKind.Local).AddTicks(3601) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Çankırı", "Lüksemburg", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(2222), "Atakan_Kocyigit@gmail.com", "Ali Çetinkaya Caddesi 82a, Bingöl, İtalya", "Kımızın", "Hamzaoğlu", "+90-135-973-1-770", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(2239), "cdb1d45e-718d-40df-aa17-f4cd5a9ebd2d", "0", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(2240) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Antalya", "Bhutan", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(4014), "Engin24@hotmail.com", "Oğuzhan Sokak 51, Zonguldak, Cebelitarık, İngiltere", "Gündoğmuş", "Paksüt", "+90-416-807-29-26", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(4020), "442cfc00-3da7-4e37-bf8c-7675d1102f90", "0", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(4021) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Çankırı", "Bulgaristan", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(4242), "Alpaya4@hotmail.com", "İbn-i Sina Sokak 19c, Edirne, Meksika", "Bağatursepi", "Erberk", "+90-116-890-05-50", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(4243), "13a96514-093c-4514-a199-2331c0713f01", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(4243) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Ağrı", "Anguilla, İngiltere", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(4526), "Argun_Karadas@hotmail.com", "Oğuzhan Sokak 9, Edirne, Güney Afrika", "Arkış", "Gümüşpala", "+90-754-059-36-71", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(4527), "b4ab6332-b8e8-46e4-b2b2-f4ac5b7e5f57", "1", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(4527) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Mardin", "Mısır", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(4794), "Inanc_Erberk53@gmail.com", "Atatürk Bulvarı 02b, Van, Cezayir", "Ayluçtarkan", "Okumuş", "+90-718-058-1-270", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(4795), "45dda85f-f59e-4341-90ff-036b0200a874", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(4795) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Niğde", "Cebelitarık, İngiltere", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(4933), "Altay23@yahoo.com", "İbn-i Sina Sokak 25b, Çorum, Uganda", "Borlukçu", "Özdenak", "+90-880-097-8-422", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(4934), "5505cb1b-68c6-46ce-a9e9-3bac1b23aee9", "1", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(4934) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Bilecik", "Bolivya", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(5079), "Arademir_Sadiklar93@gmail.com", "Tevfik Fikret Caddesi 309, Trabzon, Tanzanya", "Abılay", "Adan", "+90-374-850-81-24", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(5079), "8f0bcecc-579d-4112-b339-b5c4ab26d027", "1", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(5079) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Sivas", "Çin", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(5514), "Boyankulu.Capanoglu92@gmail.com", "Sıran Söğüt Sokak 65, Kırklareli, Filipinler", "Azganaz", "Nalbantoğlu", "+90-654-629-5-368", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(5514), "a80c44e6-828d-4176-9ff9-632efc475516", new DateTime(2025, 8, 10, 22, 38, 24, 405, DateTimeKind.Local).AddTicks(5514) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Düzce", "Svaziland", new DateTime(2025, 8, 10, 22, 38, 24, 407, DateTimeKind.Local).AddTicks(9386), "Caglayan45@yahoo.com", "İbn-i Sina Sokak 63c, Burdur, Ekvator Ginesi", "Batu", "Bademci", "+90-776-957-0-917", new DateTime(2025, 8, 10, 22, 38, 24, 407, DateTimeKind.Local).AddTicks(9403), "7067e476-1f62-4adf-a494-c504d5d3a401", "0", new DateTime(2025, 8, 10, 22, 38, 24, 407, DateTimeKind.Local).AddTicks(9405) });

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
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(1082), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(1090), 310.06m, new DateTime(2025, 4, 1, 21, 6, 20, 454, DateTimeKind.Local).AddTicks(3417), "Consectetur molestiae consequatur fugiat veniam corporis iusto aliquid necessitatibus.", "Handmade Plastic Table", "df63b6f3-b092-4923-a398-ea93c18a78b9", 10, new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(1091) });

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
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "PaymentId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 11, 8, 16, 7, 36, 285, DateTimeKind.Local).AddTicks(4235), new DateTime(2026, 11, 6, 1, 1, 15, 360, DateTimeKind.Local).AddTicks(4596), new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9216), 10, new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9216), "74bcf47d-7c1c-4043-9f78-21621e4825c1", 0, 9, 1715.70m, new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9216) });

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
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "EntryDate", "MasterId", "PaymentId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 8, 17, 33, 53, 575, DateTimeKind.Local).AddTicks(4811), new DateTime(2026, 9, 27, 2, 10, 1, 626, DateTimeKind.Local).AddTicks(9536), new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9331), new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9331), "28fbdf89-2f5b-4c9f-8990-2307465238f6", 0, 17, 1753.17m, new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9331) });

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
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "PaymentId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 5, 25, 0, 13, 33, 897, DateTimeKind.Local).AddTicks(7040), new DateTime(2026, 12, 7, 14, 40, 39, 72, DateTimeKind.Local).AddTicks(76), new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9426), 10, new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9427), "7699413c-037f-472a-a507-d4d6e23c734a", 0, 7, 1826.99m, new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9427) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "PaymentId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 8, 7, 13, 10, 57, 680, DateTimeKind.Local).AddTicks(9698), new DateTime(2026, 12, 24, 9, 5, 34, 731, DateTimeKind.Local).AddTicks(4164), new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9450), 8, new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9451), "d367e25d-5fef-4b92-a881-ce4e202142ed", 0, 1889.13m, new DateTime(2025, 8, 10, 22, 38, 24, 412, DateTimeKind.Local).AddTicks(9451) });

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
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4229), new DateTime(2025, 8, 10, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4229), "7d4bf273-9582-4746-ba62-0967ca0ca639", new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4251), new DateTime(2025, 8, 10, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4251), "2b5fa106-283d-41df-a3dd-cadaf7de0f12", new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4251) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4257), new DateTime(2025, 8, 10, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4257), "0ece2e16-c976-4d53-9383-5914fdc16e18", new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4257) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4261), new DateTime(2025, 8, 10, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4262), "dfb15c93-2477-41c9-8ccd-1e230a5f7354", new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4262) });

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
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4280), new DateTime(2025, 8, 11, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4280), "86fd2d57-7860-4bf4-98d4-3b1d2ab268a7", new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 11, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4281) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4285), new DateTime(2025, 8, 11, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4285), "9bf09732-02c6-41fc-8c67-c7187ad21f15", new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 11, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4285) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4289), new DateTime(2025, 8, 11, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4290), "ab34f57a-0700-4e22-b2c0-96966a36c03b", new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 11, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4296), new DateTime(2025, 8, 12, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4297), "8c9b6735-f3ac-4de4-9e0c-1d6e1096a693", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 12, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4343), new DateTime(2025, 8, 12, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4344), "9ba528ab-d876-4d3e-9068-de5bb6ed0170", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 12, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4344) });

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
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4366), new DateTime(2025, 8, 13, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4367), "0d46fbc1-8807-4608-bda3-2ac585852efc", new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 13, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4367) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4371), new DateTime(2025, 8, 13, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4371), "57f73360-0a92-437d-9576-5deebd3ef6a8", new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 13, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4371) });

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
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4393), new DateTime(2025, 8, 14, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4393), "74723bc8-5703-4fbb-8f29-9c49b92c2f2d", new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 14, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4393) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4397), new DateTime(2025, 8, 14, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4397), "574262e2-a167-455e-abbe-5f114944761d", new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 14, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4398) });

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
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4418), new DateTime(2025, 8, 15, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4419), "065652b9-1783-4f20-9b3c-85d9d264e160", new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 15, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4419) });

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
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4785), 12, new DateTime(2025, 8, 10, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4785), "40da6e7f-0df8-4b89-a3fd-82d149553116", new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4785) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4792), 11, new DateTime(2025, 8, 11, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4792), "273a48da-d20f-4ea7-b4fd-8e6fbef983bd", new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 11, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4798), 12, new DateTime(2025, 8, 11, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4799), "74ead18e-7ca6-4339-964a-1856c7f2f741", new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 11, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4799) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4803), new DateTime(2025, 8, 12, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4803), "cb1155a6-db45-48f9-b7f0-fd7dc3e31ada", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 12, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4803) });

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
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4824), 12, new DateTime(2025, 8, 13, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4824), "ad90f16c-5509-4565-bbc7-a966524b3096", new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 13, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4825) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4829), new DateTime(2025, 8, 14, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4829), "7c5c0422-39b2-48a5-9586-df9477cbef9d", new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 14, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4829) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4835), new DateTime(2025, 8, 14, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4835), "b1c97482-b7ca-4545-bda4-265efbe4831d", new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 14, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4835) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4839), 12, new DateTime(2025, 8, 14, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4839), "74d735bb-021c-40aa-ad62-2b295bc17109", new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 14, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4840) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4844), 11, new DateTime(2025, 8, 15, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4844), "ddd9dbde-b099-4796-870e-3bf7fd0d46be", new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 15, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4844) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4850), 12, new DateTime(2025, 8, 15, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4850), "93219543-8289-41d4-993a-c86abdff2845", new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 15, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4850) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4854), new DateTime(2025, 8, 16, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4855), "d76a2870-38c7-4634-a5d9-608927b2199b", new DateTime(2025, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 16, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4855) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4860), new DateTime(2025, 8, 16, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4861), "f136420f-6391-45da-84dd-4754c1214b96", new DateTime(2025, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 16, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 10, 22, 38, 24, 398, DateTimeKind.Local).AddTicks(4861) });
        }
    }
}

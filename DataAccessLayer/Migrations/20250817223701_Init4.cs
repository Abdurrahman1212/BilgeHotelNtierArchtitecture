using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeOnly>(
                name: "StartTime",
                table: "Shifts",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<TimeOnly>(
                name: "EndTime",
                table: "Shifts",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Adalineton", "Eritrea", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(4505), "316 Hoppe Rest, North Boydshire, Uzbekistan", "TL730081423610060041068", "578.249.8629 x4123", "Maryam73@yahoo.com", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(4514), "Celestino", "Carroll", "17d87dc4-b246-4047-9666-0108eaed6fef", "73460-4325", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(4514) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Ratkeborough", "Luxembourg", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(5277), "56548 Jerde Route, Destinmouth, Luxembourg", "CH272703078WNV199BK37", "1-818-717-2887 x1787", "Katelin98@gmail.com", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(5278), "Lincoln", "Cremin", "f1073bfa-4776-46b8-8536-4a6a27d59cd0", "11654", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(5278) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Martinebury", "Serbia", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(5557), "390 Velva Bridge, New Stanleyview, Armenia", "ME53068020300500044972", "396-729-6517", "Laurence_Walsh1@gmail.com", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(5558), "Ibrahim", "Mitchell", "3fc8b495-0dfe-44bd-a90e-3b490affb862", "12817", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(5558) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Staceyport", "Bosnia and Herzegovina", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(5792), "616 Brown Loaf, Petraport, Comoros", "8", "FO7270011800903632", "272-858-6882 x45971", "Zion.Mueller@yahoo.com", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(5792), "Emilia", "Schinner", "5aadcc86-f0eb-490d-ba57-21e3d5f7e9c6", "16539-2004", new DateTime(2025, 8, 18, 1, 37, 0, 847, DateTimeKind.Local).AddTicks(5793) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Mardin", "Maldiv Adaları", new DateTime(2025, 8, 18, 1, 37, 0, 920, DateTimeKind.Local).AddTicks(5769), "Berdibeg.Arslanoglu@yahoo.com", "Kocatepe Caddesi 26b, Siirt, Avustralya", "Burslan", "Kulaksızoğlu", "+90-117-073-23-97", new DateTime(2025, 8, 18, 1, 37, 0, 920, DateTimeKind.Local).AddTicks(5772), "fd30f15d-14d1-423a-9937-9c1e6ae10a71", "0", new DateTime(2025, 8, 18, 1, 37, 0, 920, DateTimeKind.Local).AddTicks(5773) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Batman", "Tacikistan", new DateTime(2025, 8, 18, 1, 37, 0, 920, DateTimeKind.Local).AddTicks(6667), "Gunay84@gmail.com", "Saygılı Sokak 5, Aydın, Svaziland", "Bıçkıcı", "Yazıcı", "+90-962-118-98-19", new DateTime(2025, 8, 18, 1, 37, 0, 920, DateTimeKind.Local).AddTicks(6667), "bcae07f3-17a0-4207-97e3-ecce7fcbbb5b", new DateTime(2025, 8, 18, 1, 37, 0, 920, DateTimeKind.Local).AddTicks(6668) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Antalya", "Orta Afrika Cumhuriyeti", new DateTime(2025, 8, 18, 1, 37, 0, 920, DateTimeKind.Local).AddTicks(6767), "Alpulug.Sozeri@yahoo.com", "Namık Kemal Caddesi 45, Rize, Yemen", "Bengi", "Akman", "+90-146-509-28-31", new DateTime(2025, 8, 18, 1, 37, 0, 920, DateTimeKind.Local).AddTicks(6768), "84f6afa9-9a3a-43a1-b9b4-4ff8197fc595", "0", new DateTime(2025, 8, 18, 1, 37, 0, 920, DateTimeKind.Local).AddTicks(6768) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Bilecik", "Yeni Kaledonya, Fransa", new DateTime(2025, 8, 18, 1, 37, 0, 920, DateTimeKind.Local).AddTicks(6875), "Bukduz89@hotmail.com", "Kaldırım Sokak 67, Elazığ, Santa Kitts ve Nevis", "Arslanyabgu", "Özgörkey", "+90-127-281-73-32", new DateTime(2025, 8, 18, 1, 37, 0, 920, DateTimeKind.Local).AddTicks(6876), "3b0d8880-36ec-48bd-b86f-8db54e880e0a", "0", new DateTime(2025, 8, 18, 1, 37, 0, 920, DateTimeKind.Local).AddTicks(6876) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Adıyaman", "Midway Adaları, Amerika", new DateTime(2025, 8, 18, 1, 37, 0, 920, DateTimeKind.Local).AddTicks(6987), "Barboga.Nebioglu@gmail.com", "Menekşe Sokak 177, Adana, Amerikan Samoa", "Gökçen", "Keseroğlu", "+90-540-704-61-87", new DateTime(2025, 8, 18, 1, 37, 0, 920, DateTimeKind.Local).AddTicks(6988), "959d77a4-0c3d-4d76-a842-8693a97771c1", "1", new DateTime(2025, 8, 18, 1, 37, 0, 920, DateTimeKind.Local).AddTicks(6988) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Tekirdağ", "Filistin", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(7740), "Akcakoca35@yahoo.com", "Oğuzhan Sokak 75a, Çorum, Cebelitarık, İngiltere", "Altınkan", "Çağıran", "+90-696-176-46-59", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(7740), "c8c9815e-7900-421f-9ae7-d1077d1595ae", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(7741) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Şanlıurfa", "İspanya", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(8064), "Egemen_Dusenkalkar@gmail.com", "Atatürk Bulvarı 64c, Bayburt, Singapur", "Beğ", "Karadaş", "+90-162-821-5-226", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(8064), "66b8be1d-97a2-45e2-af3f-0c2a85a3485e", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(8065) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Antalya", "Libya", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(8176), "Bindir.Okur52@hotmail.com", "İsmet Attila Caddesi 39, Muğla, Sudan", "Adalan", "Akay", "+90-509-542-1-062", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(8177), "ea1b9570-4d0c-4ac0-b39e-201988efd7a1", "1", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(8177) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Karabük", "Monako", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(8295), "Basci_Abaci@yahoo.com", "Bayır Sokak 37, Bartın, Kongo", "Arsıl", "Akbulut", "+90-242-613-29-59", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(8295), "139b576f-7431-4154-b6a9-9d2400dbc864", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(8295) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "K.maraş", "Azerbaycan", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(8531), "Alpgerey71@gmail.com", "Namık Kemal Caddesi 12, Bilecik, Almanya", "Baltacı", "Kaya ", "+90-263-313-11-33", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(8531), "a0d3ee21-5bbf-4418-a0d6-97c6a9757a40", "0", new DateTime(2025, 8, 18, 1, 37, 0, 921, DateTimeKind.Local).AddTicks(8531) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Bingöl", "Nijerya", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(9303), "Balaka_Sepetci@hotmail.com", "İsmet Attila Caddesi 834, Batman, Eritre", "Bağaturçigşi", "Kocabıyık", "+90-795-536-17-28", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(9304), "47fe4498-bcbf-4401-9300-a397d306c900", "1", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(9304) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Bingöl", "Malezya", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(9677), "Baytara.Besok@yahoo.com", "Kocatepe Caddesi 16a, Burdur, Barbados", "Bolun", "Akar ", "+90-179-751-42-63", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(9677), "4615a5d4-8a5c-475e-b974-56ddb04f43b1", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Kars", "Kuveyt", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(9782), "Colman.Onur75@gmail.com", "Nalbant Sokak 93, K.maraş, Monako", "Bağatur", "Mayhoş", "+90-317-700-6-685", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(9783), "5e892c99-a880-45e5-ba68-699949481834", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(9783) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Afyon", "Gine", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(9985), "Batuk.Kuzucu@yahoo.com", "Sarıkaya Caddesi 575, Şırnak, Fransız Guyanası", "Alpgerey", "Tunaboylu", "+90-581-566-3-399", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(9986), "c2d992b3-b83f-499b-97ab-6e3b64f42577", new DateTime(2025, 8, 18, 1, 37, 0, 922, DateTimeKind.Local).AddTicks(9986) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Kırklareli", "Çad", new DateTime(2025, 8, 18, 1, 37, 0, 923, DateTimeKind.Local).AddTicks(98), "Ayaci_Baykam@yahoo.com", "Menekşe Sokak 835, Batman, Lübnan", "İnci", "Ekici", "+90-911-479-62-65", new DateTime(2025, 8, 18, 1, 37, 0, 923, DateTimeKind.Local).AddTicks(98), "b21bb670-bd16-468b-9e9c-5cea97831e2a", new DateTime(2025, 8, 18, 1, 37, 0, 923, DateTimeKind.Local).AddTicks(99) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Niğde", "Peru", new DateTime(2025, 8, 18, 1, 37, 0, 923, DateTimeKind.Local).AddTicks(203), "Bartu_Menemencioglu17@gmail.com", "Bayır Sokak 05c, Edirne, Nijerya", "Altay", "Akyüz", "+90-177-766-7-603", new DateTime(2025, 8, 18, 1, 37, 0, 923, DateTimeKind.Local).AddTicks(204), "a6c5bb35-633f-4042-ac25-f93acf7b3782", new DateTime(2025, 8, 18, 1, 37, 0, 923, DateTimeKind.Local).AddTicks(204) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Bolu", "Libya", new DateTime(2025, 8, 18, 1, 37, 0, 924, DateTimeKind.Local).AddTicks(8323), "Buluc9@hotmail.com", "Yunus Emre Sokak 94, Bilecik, Moldavya", "Basanyalavaç", "Yıldırım ", "+90-629-536-7-444", new DateTime(2025, 8, 18, 1, 37, 0, 924, DateTimeKind.Local).AddTicks(8329), "84e11488-4583-472b-bf36-e20daab48a5c", "0", new DateTime(2025, 8, 18, 1, 37, 0, 924, DateTimeKind.Local).AddTicks(8330) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Antalya", "Virgin Adaları, Amerika", new DateTime(2025, 8, 18, 1, 37, 0, 924, DateTimeKind.Local).AddTicks(9626), "Alpis.Dizdar82@hotmail.com", "Güven Yaka Sokak 67c, Uşak, Vallis ve Futuna, Fransa", "Bağtaş", "Çevik", "+90-926-874-9-112", new DateTime(2025, 8, 18, 1, 37, 0, 924, DateTimeKind.Local).AddTicks(9627), "5ad9398b-b53d-4afd-9073-928950efe5b6", new DateTime(2025, 8, 18, 1, 37, 0, 924, DateTimeKind.Local).AddTicks(9627) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Bolu", "Eritre", new DateTime(2025, 8, 18, 1, 37, 0, 924, DateTimeKind.Local).AddTicks(9761), "Adraman_Aybar19@gmail.com", "Sağlık Sokak 15, Muş, Virgin Adaları, Amerika", "Bilgetamgacı", "Erkekli", "+90-045-482-30-36", new DateTime(2025, 8, 18, 1, 37, 0, 924, DateTimeKind.Local).AddTicks(9762), "1ab098f1-bcf3-46ce-b144-addb9678be5c", new DateTime(2025, 8, 18, 1, 37, 0, 924, DateTimeKind.Local).AddTicks(9762) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Edirne", "Malta", new DateTime(2025, 8, 18, 1, 37, 0, 924, DateTimeKind.Local).AddTicks(9916), "Burulgu88@gmail.com", "30 Ağustos Caddesi 01b, Muğla, Moğolistan", "Boğaçuk", "Tazegül", "+90-501-805-2-700", new DateTime(2025, 8, 18, 1, 37, 0, 924, DateTimeKind.Local).AddTicks(9916), "6d963e6a-ebf2-4ab6-9f14-f00d2bc47be9", "0", new DateTime(2025, 8, 18, 1, 37, 0, 924, DateTimeKind.Local).AddTicks(9916) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Antalya", "Peru", new DateTime(2025, 8, 18, 1, 37, 0, 925, DateTimeKind.Local).AddTicks(175), "Beltir_Ozansoy@yahoo.com", "Harman Altı Sokak 08, Rize, Tayland", "Atakağan", "Örge", "+90-671-626-7-019", new DateTime(2025, 8, 18, 1, 37, 0, 925, DateTimeKind.Local).AddTicks(176), "0dfc6cf9-2508-4554-a3a2-c6819f02a036", "1", new DateTime(2025, 8, 18, 1, 37, 0, 925, DateTimeKind.Local).AddTicks(176) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Balıkesir", "Makau (Makao)", new DateTime(2025, 8, 18, 1, 37, 0, 925, DateTimeKind.Local).AddTicks(296), "Baksi32@yahoo.com", "Lütfi Karadirek Caddesi 71a, Manisa, Rusya Federasyonu", "Büke", "Çapanoğlu", "+90-482-566-03-83", new DateTime(2025, 8, 18, 1, 37, 0, 925, DateTimeKind.Local).AddTicks(297), "60fba879-53e3-4642-9b68-4ed693a4b14d", new DateTime(2025, 8, 18, 1, 37, 0, 925, DateTimeKind.Local).AddTicks(297) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Bilecik", "Svaziland", new DateTime(2025, 8, 18, 1, 37, 0, 925, DateTimeKind.Local).AddTicks(428), "Kaynak80@gmail.com", "Bandak Sokak 00b, Çankırı, Monako", "Atlıkağan", "Tuğluk", "+90-188-836-14-66", new DateTime(2025, 8, 18, 1, 37, 0, 925, DateTimeKind.Local).AddTicks(429), "ed34a702-cdf6-499a-b8e8-f54108c1a0e9", "1", new DateTime(2025, 8, 18, 1, 37, 0, 925, DateTimeKind.Local).AddTicks(429) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "K.maraş", "Kosova", new DateTime(2025, 8, 18, 1, 37, 0, 925, DateTimeKind.Local).AddTicks(668), "Bukey6@hotmail.com", "Atatürk Bulvarı 078, Karabük, Libya", "Balçar", "Akışık", "+90-575-519-8-301", new DateTime(2025, 8, 18, 1, 37, 0, 925, DateTimeKind.Local).AddTicks(669), "5d92bef9-e6a7-4ca8-bfa0-0057d35bfed0", new DateTime(2025, 8, 18, 1, 37, 0, 925, DateTimeKind.Local).AddTicks(669) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Zonguldak", "Mısır", new DateTime(2025, 8, 18, 1, 37, 0, 925, DateTimeKind.Local).AddTicks(747), "Bayna.Erbay72@yahoo.com", "Tevfik Fikret Caddesi 08a, Eskişehir, Somali", "Beğtegin", "Aybar", "+90-915-987-10-55", new DateTime(2025, 8, 18, 1, 37, 0, 925, DateTimeKind.Local).AddTicks(748), "f795d6e7-a179-43d0-ab53-80ff35da5a2c", "1", new DateTime(2025, 8, 18, 1, 37, 0, 925, DateTimeKind.Local).AddTicks(748) });

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
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(421), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(422), 853.74m, new DateTime(2025, 7, 7, 19, 21, 59, 673, DateTimeKind.Local).AddTicks(4929), "Eligendi eos et debitis et aut omnis.", "Generic Fresh Chicken", "a4cede44-5c50-43a9-a17d-d249cb843bdd", 5, new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(422) });

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
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(571), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(572), 235.89m, new DateTime(2024, 8, 27, 19, 21, 27, 362, DateTimeKind.Local).AddTicks(8214), "İmpedit in excepturi doloremque omnis qui voluptatem ea incidunt sit.", "Rustic Concrete Towels", "2bb9eac4-cf56-4559-938f-f7b5d6414bdc", new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(572) });

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
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(680), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(681), 256.78m, new DateTime(2025, 1, 27, 11, 26, 29, 427, DateTimeKind.Local).AddTicks(6455), "Provident rem molestiae autem accusantium cum ut.", "b2e4858b-fb8a-4213-b82f-9715181c899a", 10, new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(681) });

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
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 3, 10, 12, 11, 68, DateTimeKind.Local).AddTicks(6429), new DateTime(2026, 8, 28, 12, 11, 37, 984, DateTimeKind.Local).AddTicks(7534), new DateTime(2025, 8, 18, 1, 37, 0, 928, DateTimeKind.Local).AddTicks(8899), 2, new DateTime(2025, 8, 18, 1, 37, 0, 928, DateTimeKind.Local).AddTicks(8899), "03c86b70-5022-4111-b8c9-d15d33dd4ea9", 1626.39m, new DateTime(2025, 8, 18, 1, 37, 0, 928, DateTimeKind.Local).AddTicks(8899) });

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
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(2948), 1, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(2948), "3184395d-ed2e-4404-8728-a39fed1e1835", new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(2982), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(2982), "251c3242-c1e9-4d66-a116-e7f490fabe1d", new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(2988), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(2988), "114d618e-2e36-4b13-8984-63fafd5563f5", new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(2992), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(2993), "9a66f406-3684-428b-a8da-bdc3c978c9e1", new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3002), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3002), "997e2fdc-c757-4761-b795-fc25c849aa23", new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3002) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3007), 2, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3007), "b920617a-bd15-4a67-bd1f-a23639413f40", new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3007) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3015), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3015), "1df861d4-f2e4-465d-a03d-87ca554ddafb", new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3016) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3019), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3020), "7238a964-946a-4a3f-99f9-b1dc6054a5a7", new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3020) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3027), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3027), "445a3a6d-d0c1-420c-8333-3b3d59fd6dfd", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3027) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3032), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3032), "b2340ec2-e09b-4a9e-a89c-d524132bd405", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3032) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3036), 3, new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3036), "e1f6dfa8-9bc9-4b7f-8d1f-a4922166726a", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3037) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3040), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3040), "f6aaab05-466c-4e36-b3a5-3326f3bb8717", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3041) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3075), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3075), "c6d485be-cda0-4359-a0f5-cfc965699488", new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3075) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3080), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3080), "8ad83259-5b77-4152-b462-bfcdd89029be", new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3086), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3086), "fd07b2c2-739b-4028-a07d-04c5580fd9c5", new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3086) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3090), 4, new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3090), "790a1c83-f213-4cc1-b097-9dbbd9df6617", new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3090) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3097), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3097), "25957a12-7b94-4348-a127-41b736b23280", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3097) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3102), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3102), "f8a6f300-6a2b-490b-ad1d-72beb31cda1a", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3102) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3107), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3107), "3a07f6cd-bae6-4572-8578-2d4c8bca0210", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3107) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3111), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3111), "e59554ce-135f-42fb-b8e0-5f34595ec35c", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3111) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3117), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3118), "6f9845f5-75b3-4c98-9620-1429664e0d5e", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3118) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3122), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3122), "2c2312c1-7875-4965-a660-3d1555c3ed0f", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3122) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3128), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3128), "402be473-b850-4ce3-b0f9-915c083faaff", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3128) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3132), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3132), "c062764e-13f4-4d56-85fa-0d330c19882c", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3133) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3139), 2, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3140), "1f379b7b-5e36-4c4e-aaa3-500361d66f4e", new DateTime(2025, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3140) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3143), 3, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3144), "2e83a98c-4585-4978-ab1c-99cb71e62ab2", new DateTime(2025, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3148), 4, new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3148), "58b14e40-1c2d-4389-921b-f17da2bd1aec", new DateTime(2025, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3152), 5, new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3152), "54f58d5a-09f1-43c7-b33b-d885d4fe1e48", new DateTime(2025, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3152) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3162), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3162), "d1337846-b33d-4f32-899c-c5f3fd59628f", new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3163) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3167), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3167), "6657ecea-5aa2-4cf9-8135-629729e730d9", new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3168) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3173), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3174), "d913e19c-059c-49ff-ae64-24d2c8180132", new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3177), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3178), "4b92b40a-e1f6-4b6b-a8e5-4a4722bdb898", new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3178) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3182), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3182), "4a3b233f-dca6-40dc-9969-ac83ab6e9c57", new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3182) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3187), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3187), "209eb4ee-afb5-4500-8d56-add80fd37308", new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3187) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3192), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3192), "d275ec2c-9947-4c3c-ba60-2449f82f6ddb", new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3192) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3196), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3196), "dad38d35-c41c-45f4-a3d8-8f48b1a43f7e", new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3197) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3201), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3201), "f3a10d1e-d50e-4e58-be55-0691dd616be1", new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3202) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3231), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3231), "cea29569-ed4d-4a5f-b172-4f9bc435436c", new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3231) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3237), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3238), "2590aaf9-de33-486d-bbfd-9a52eec0194e", new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3242), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3242), "502e2d44-1761-43aa-bd11-ed3d334a1196", new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3247), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3247), "de73f892-497d-433f-98a3-3d888ebf1442", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3247) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3252), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3252), "f1384514-41ac-4cc5-81a3-8c64932c4ad7", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3252) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3256), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3256), "a37016ca-55f9-44bf-a30b-299db10934fe", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3257) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3260), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3261), "db962e8a-17c4-4d6a-b3a8-2b3b99122f49", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3265), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3265), "6d1c6ea4-8557-4fe7-9c7c-f101184e8718", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3265) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3269), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3270), "e5d2b4f9-e541-47ac-bfbc-a8fd00e7c514", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3275), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3276), "2582549f-14a4-44c4-8268-a9371cdfa7af", new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3276) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3279), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3279), "3813784e-8597-4b7e-842a-cd32e10d5652", new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3284), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3284), "cd1e4fe1-0abe-433c-ae9f-7abec470deca", new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3284) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3288), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3288), "7ac02c27-26e9-450f-bbdd-fd8056c444a9", new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3292), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3292), "d111e54d-f2c1-46be-a131-af177142656d", new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3292) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3296), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3296), "b34444e6-c4a6-4011-9e99-9396771d59bf", new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3296) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3300), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3301), "e6ea6f52-abe1-465b-acb6-d34a0ce2ef49", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3301) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3304), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3305), "3d6aef8c-9333-4b2c-b4e5-42a06a99c13d", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3305) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3310), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3310), "6f236508-68eb-420d-b69f-559f884470aa", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3314), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3314), "c2d19c44-9854-4c97-b7eb-2f25804289a8", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3314) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3318), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3319), "9ad97ead-cb19-4a06-b986-b09c4a5d9546", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3319) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3322), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3322), "c0289c3d-7db9-4d5f-92f4-9d411b87f315", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3323) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3327), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3327), "26cdfaf3-7fe6-492d-9815-f3fb5e0d51cf", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3331), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3331), "e3a99a5e-3226-4c97-afec-0bfb63f399b7", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3331) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3335), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3335), "bf8fa534-3f88-4f53-80b1-6baa4bb5c784", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3336) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3339), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3339), "9b84ab12-7a16-48c0-a1c7-2291442f6835", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3339) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3344), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3345), "849cae85-2e37-4069-b73b-824f1c2b9ee8", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3345) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3348), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3349), "206b276f-7ed8-49a7-8a58-15be0fe07cc7", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3349) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3353), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3353), "c19d955d-29a5-4d27-84da-4c8a3abc2d66", new DateTime(2025, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3382), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3382), "ca5e7029-7318-47e2-923c-890c4db2d832", new DateTime(2025, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3383) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3387), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3388), "b594f56c-26cf-4b83-9528-b1ef90a06946", new DateTime(2025, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3388) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3392), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3393), "0bfa1c19-4c2e-406a-9188-2fbd60c6f838", new DateTime(2025, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3397), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3397), "dbd5b2bf-5e27-4f2b-8deb-df75b874dc73", new DateTime(2025, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3401), new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3401), "1f3ab5df-3b18-402a-b477-419a23087f45", new DateTime(2025, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3402) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3449), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3449), "35d56d07-a995-4e5f-816c-897337e60d4f", new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3449) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3458), 11, new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3458), "66a95ee3-9180-4119-8ca7-e97c00286ce7", new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3458) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3463), 12, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3463), "26ddd517-f2fe-4819-8542-144014013980", new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3463) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3468), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3469), "0a5b9308-1dc1-4251-a681-56a8eaed38d4", new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3469) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3474), 11, new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3475), "6159324a-3a14-41ad-9dbe-a574f637cb51", new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3475) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3478), 12, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3479), "624b5698-080d-49d6-b4ab-3813b8c6c26d", new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3479) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3484), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3485), "a4b1868f-c9d6-4408-931c-0fb8473342d1", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3485) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3490), 11, new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3490), "cd7f2484-a764-433f-b70a-edcebfad6e74", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3491) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3494), 12, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3494), "e372ea16-5731-4939-b48f-808c7b8576a3", new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3495) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3499), 11, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3499), "f32cb245-8d5a-4c3a-b4ec-737b32fc6180", new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3500) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3505), 12, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3506), "81b05f23-12fa-4998-9dc5-ac69d424cbc2", new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3506) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3510), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3510), "39951d5c-8b7c-4960-bc18-89ba8d81994d", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3511) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3516), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3516), "03b3a1be-9266-43b4-91ac-74e4d40c4ee7", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3517) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3520), 12, new TimeOnly(0, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3520), "c2bf4f7a-edd4-459f-870b-bf27604339f9", 2, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3521) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3526), 11, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3526), "e688fce5-a870-4f38-8741-b6053cd3ec3b", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3526) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3531), 12, new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3532), "825b0b5e-be5e-4509-9a9a-3d9cafb07de0", new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3532) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3536), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3536), "17639627-cdb2-40f8-9d3e-293778bae976", new DateTime(2025, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3536) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3542), new TimeOnly(16, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3542), "06632e61-42f8-4e8c-b97e-c0a0fa2d1424", new DateTime(2025, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), new TimeOnly(8, 0, 0), new DateTime(2025, 8, 18, 1, 37, 0, 919, DateTimeKind.Local).AddTicks(3542) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Shifts",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(TimeOnly),
                oldType: "time");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Shifts",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(TimeOnly),
                oldType: "time");

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
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Port Bertrand", "Barbados", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(1808), "420 Konopelski Hills, Vivianhaven, Bangladesh", "TL646848005040932007009", "471-215-2192", "Wade.Batz29@gmail.com", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(1808), "Savion", "Jerde", "47d4e4fb-9f71-4fa3-8f0f-7b176229917e", "58093", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(1809) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Port Deebury", "Madagascar", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(2205), "95467 Dickens Roads, South Shayna, Barbados", "CR74155825006278202801", "202-212-5377 x11631", "Angus2@hotmail.com", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(2206), "Alan", "Hyatt", "92c142fd-1843-482d-afa0-1986693e94ab", "67651-4434", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(2206) });

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
                columns: new[] { "City", "County", "CreatedDate", "CustomerAddress", "CustomerIdentityNumber", "CustomerPaymentDetails", "CustomerPhone", "Email", "EntryDate", "FirstName", "LastName", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "North Stewart", "Bulgaria", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(3246), "76334 Daniel Rapid, Dickinsonfort, Iceland", "5", "PK76E3DV0306706300579006", "1-853-919-6007 x1364", "Braden_Rutherford@gmail.com", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(3248), "Cassidy", "Predovic", "73f8de2e-1964-44c3-b40e-5edd9c7c3177", "59106", new DateTime(2025, 8, 17, 17, 18, 12, 681, DateTimeKind.Local).AddTicks(3249) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Samsun", "Nijer", new DateTime(2025, 8, 17, 17, 18, 12, 779, DateTimeKind.Local).AddTicks(763), "Aybars73@yahoo.com", "Okul Sokak 31a, Kırşehir, Suudi Arabistan", "Bayraç", "Ertürk", "+90-464-093-1-558", new DateTime(2025, 8, 17, 17, 18, 12, 779, DateTimeKind.Local).AddTicks(764), "e540e296-4522-4ef7-ab7a-adf9094ca5ea", new DateTime(2025, 8, 17, 17, 18, 12, 779, DateTimeKind.Local).AddTicks(765) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "K.maraş", "Kosova", new DateTime(2025, 8, 17, 17, 18, 12, 779, DateTimeKind.Local).AddTicks(1083), "Aykan.Corekci@gmail.com", "Menekşe Sokak 4, Tokat, K.K.T.C.", "Aladoğan", "Sözeri", "+90-566-619-71-24", new DateTime(2025, 8, 17, 17, 18, 12, 779, DateTimeKind.Local).AddTicks(1083), "a749bc9f-5e1f-4faa-bf7b-980e2dd0d4dc", new DateTime(2025, 8, 17, 17, 18, 12, 779, DateTimeKind.Local).AddTicks(1084) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Uşak", "Birleşik Arap Emirlikleri", new DateTime(2025, 8, 17, 17, 18, 12, 779, DateTimeKind.Local).AddTicks(2326), "Ayiz_Baykam32@yahoo.com", "Ali Çetinkaya Caddesi 24b, İstanbul, Türkiye", "Bayurku", "Okur", "+90-357-223-9-147", new DateTime(2025, 8, 17, 17, 18, 12, 779, DateTimeKind.Local).AddTicks(2330), "104fb463-339e-4c20-bb32-8236954021be", new DateTime(2025, 8, 17, 17, 18, 12, 779, DateTimeKind.Local).AddTicks(2331) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Sivas", "Turks ve Caicos Adaları, İngiltere", new DateTime(2025, 8, 17, 17, 18, 12, 781, DateTimeKind.Local).AddTicks(7919), "Butak.Balci81@gmail.com", "Köypınar Sokak 756, Tokat, Kuzey Maryana Adaları", "Baltacı", "Sinanoğlu", "+90-632-464-8-315", new DateTime(2025, 8, 17, 17, 18, 12, 781, DateTimeKind.Local).AddTicks(7928), "cb8d12aa-6a07-4112-b402-c51ef5e70319", "1", new DateTime(2025, 8, 17, 17, 18, 12, 781, DateTimeKind.Local).AddTicks(7929) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Kocaeli", "Ekvator", new DateTime(2025, 8, 17, 17, 18, 12, 781, DateTimeKind.Local).AddTicks(9165), "Bayruk39@yahoo.com", "Okul Sokak 7, Bingöl, Karadağ", "Barçadoğmuş", "Kuzucu", "+90-416-690-0-853", new DateTime(2025, 8, 17, 17, 18, 12, 781, DateTimeKind.Local).AddTicks(9166), "08327f68-f37c-4be5-9938-bb08c96d2ab2", new DateTime(2025, 8, 17, 17, 18, 12, 781, DateTimeKind.Local).AddTicks(9167) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Iğdır", "Kosta Rika", new DateTime(2025, 8, 17, 17, 18, 12, 782, DateTimeKind.Local).AddTicks(877), "Abi_Tekand@gmail.com", "Ali Çetinkaya Caddesi 35b, Bolu, Moldavya", "Gürbüz", "Yılmazer", "+90-935-416-5-993", new DateTime(2025, 8, 17, 17, 18, 12, 782, DateTimeKind.Local).AddTicks(878), "9760db8e-2616-47f4-8bda-c5f6c3d84965", new DateTime(2025, 8, 17, 17, 18, 12, 782, DateTimeKind.Local).AddTicks(879) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Siirt", "Makau (Makao)", new DateTime(2025, 8, 17, 17, 18, 12, 784, DateTimeKind.Local).AddTicks(9193), "Burcak31@hotmail.com", "Lütfi Karadirek Caddesi 3, Çorum, Brunei", "Atlı", "Çetiner", "+90-751-552-0-407", new DateTime(2025, 8, 17, 17, 18, 12, 784, DateTimeKind.Local).AddTicks(9194), "47f11c6d-ff68-4c62-8bb4-c0b13cba1275", "0", new DateTime(2025, 8, 17, 17, 18, 12, 784, DateTimeKind.Local).AddTicks(9195) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Çankırı", "Senegal", new DateTime(2025, 8, 17, 17, 18, 12, 784, DateTimeKind.Local).AddTicks(9814), "Bayik_Karaduman9@gmail.com", "Okul Sokak 84b, Iğdır, İran", "Ağlamış", "Tekelioğlu", "+90-246-405-1-883", new DateTime(2025, 8, 17, 17, 18, 12, 784, DateTimeKind.Local).AddTicks(9815), "1015be07-0a8c-4cda-9a40-013813e11e39", "0", new DateTime(2025, 8, 17, 17, 18, 12, 784, DateTimeKind.Local).AddTicks(9815) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Kilis", "Arjantin", new DateTime(2025, 8, 17, 17, 18, 12, 785, DateTimeKind.Local).AddTicks(373), "Ayas38@gmail.com", "Alparslan Türkeş Bulvarı 875, K.maraş, Tonga", "Bünül", "Atan", "+90-912-860-08-28", new DateTime(2025, 8, 17, 17, 18, 12, 785, DateTimeKind.Local).AddTicks(373), "af3a565a-b9d3-4fb4-a96e-473d2d89e990", new DateTime(2025, 8, 17, 17, 18, 12, 785, DateTimeKind.Local).AddTicks(374) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Eskişehir", "Ermenistan", new DateTime(2025, 8, 17, 17, 18, 12, 785, DateTimeKind.Local).AddTicks(1186), "Busulgan.Topaloglu24@hotmail.com", "30 Ağustos Caddesi 62, Bolu, Afganistan", "Barbeğ", "Yıldırım ", "+90-793-616-9-104", new DateTime(2025, 8, 17, 17, 18, 12, 785, DateTimeKind.Local).AddTicks(1186), "6e28e9dd-242e-4a8c-b7f5-70c43edf9d28", new DateTime(2025, 8, 17, 17, 18, 12, 785, DateTimeKind.Local).AddTicks(1187) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Bartın", "Beyaz Rusya", new DateTime(2025, 8, 17, 17, 18, 12, 785, DateTimeKind.Local).AddTicks(1743), "Cokramayul96@hotmail.com", "Yunus Emre Sokak 69b, Siirt, Montserrat", "Berginsenge", "Tunaboylu", "+90-299-370-68-38", new DateTime(2025, 8, 17, 17, 18, 12, 785, DateTimeKind.Local).AddTicks(1746), "05e77fb8-bec5-4eec-8182-8d1fa011d52c", new DateTime(2025, 8, 17, 17, 18, 12, 785, DateTimeKind.Local).AddTicks(1748) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Ordu", "Rusya Federasyonu", new DateTime(2025, 8, 17, 17, 18, 12, 785, DateTimeKind.Local).AddTicks(2104), "Bagatur_Alpugan@gmail.com", "Oğuzhan Sokak 499, İçel (Mersin), Litvanya", "Adberilgen", "Ekşioğlu", "+90-527-458-80-76", new DateTime(2025, 8, 17, 17, 18, 12, 785, DateTimeKind.Local).AddTicks(2105), "6d475bee-abe1-4734-a1c7-0b2857e4bfaf", new DateTime(2025, 8, 17, 17, 18, 12, 785, DateTimeKind.Local).AddTicks(2105) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Erzincan", "Japonya", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(7742), "Baytas11@hotmail.com", "İsmet Attila Caddesi 33c, Balıkesir, Danimarka", "Baltar", "Solmaz", "+90-613-970-02-08", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(7743), "e609ff26-5e72-4faf-a389-05e95eb586ae", "0", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Kars", "Güney Afrika", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(7972), "Akkunlu41@hotmail.com", "Kekeçoğlu Sokak 7, Tunceli, Turks ve Caicos Adaları, İngiltere", "Amrak", "Özdoğan", "+90-578-442-23-04", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(7973), "384c3de7-af59-4f0f-9b8a-917ab9c905a7", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(7974) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Ordu", "Çek Cumhuriyeti", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(8185), "Kirlangic95@yahoo.com", "Bandak Sokak 341, Sivas, İspanya", "Bölükbaşı", "Barbarosoğlu", "+90-461-078-58-42", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(8186), "86babcde-074a-468d-886b-eecd92098278", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(8187) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Aksaray", "Vanuatu", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(8408), "Azganaz.Egeli57@hotmail.com", "Köypınar Sokak 842, Elazığ, Palau Adaları", "Barsgan", "Özberk", "+90-256-594-08-64", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(8409), "6e627d79-540b-4472-b318-a8eead45ca60", "1", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(8409) });

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
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "UpdatedDate" },
                values: new object[] { "Çanakkale", "Galler", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(9067), "Ergene_Alpugan@yahoo.com", "Tevfik Fikret Caddesi 33, Düzce, Kiribati", "İdil", "Yılmazer", "+90-219-400-4-520", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(9067), "97fdaf64-9c98-4048-afbd-8f0cf13df261", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(9068) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "City", "Country", "CreatedDate", "Email", "EmployeeAddres", "EmployeeFirstName", "EmployeeLastName", "EmployeePhoneNumber", "EntryDate", "MasterId", "PostalCode", "UpdatedDate" },
                values: new object[] { "Balıkesir", "Kongo Demokratik Cumhuriyeti", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(9294), "Bagatur.Tuglu@gmail.com", "Ülkü Sokak 7, Bursa, Hollanda", "Baybars", "Dağlaroğlu", "+90-055-185-82-48", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(9295), "4f196571-1f33-4dcc-95cc-2c10c3da891b", "0", new DateTime(2025, 8, 17, 17, 18, 12, 787, DateTimeKind.Local).AddTicks(9295) });

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
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "ExpenseName", "MasterId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 774, DateTimeKind.Local).AddTicks(8807), new DateTime(2025, 8, 17, 17, 18, 12, 774, DateTimeKind.Local).AddTicks(8809), 418.17m, new DateTime(2024, 12, 24, 8, 3, 45, 530, DateTimeKind.Local).AddTicks(4199), "Atque aut earum at aut aperiam et voluptate reprehenderit facilis.", "Unbranded Cotton Bacon", "742f9082-9abc-4b27-929e-d3dc3745e5b9", new DateTime(2025, 8, 17, 17, 18, 12, 774, DateTimeKind.Local).AddTicks(8811) });

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
                columns: new[] { "CreatedDate", "EntryDate", "ExpenseAmount", "ExpenseDate", "ExpenseDescription", "MasterId", "ReservationId", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 774, DateTimeKind.Local).AddTicks(9060), new DateTime(2025, 8, 17, 17, 18, 12, 774, DateTimeKind.Local).AddTicks(9061), 623.50m, new DateTime(2025, 7, 3, 2, 49, 47, 923, DateTimeKind.Local).AddTicks(5420), "Optio fuga ullam laborum.", "6ea80e93-7485-4687-be7b-e05c405b7f6e", 6, new DateTime(2025, 8, 17, 17, 18, 12, 774, DateTimeKind.Local).AddTicks(9061) });

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
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 14, 6, 29, 649, DateTimeKind.Local).AddTicks(4411), new DateTime(2026, 5, 2, 19, 14, 44, 471, DateTimeKind.Local).AddTicks(6573), new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(7270), 1, new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(7270), "9990728b-62ed-4ab5-80e4-04d3c5f1e433", 27, 2400.95m, new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(7271) });

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
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "RoomId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 4, 22, 33, 41, 168, DateTimeKind.Local).AddTicks(1015), new DateTime(2025, 12, 10, 4, 10, 13, 307, DateTimeKind.Local).AddTicks(3460), new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(7408), 7, new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(7408), "5eefc946-e4b3-41c5-b646-a3c5762885c7", 13, 2200.66m, new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(7409) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerId", "EntryDate", "MasterId", "TotalAmount", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 1, 4, 3, 8, 64, DateTimeKind.Local).AddTicks(172), new DateTime(2026, 9, 13, 13, 36, 1, 767, DateTimeKind.Local).AddTicks(8333), new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(7434), 6, new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(7435), "13985669-0d79-4de9-9a09-18d71b0b726f", 2088.64m, new DateTime(2025, 8, 17, 17, 18, 12, 794, DateTimeKind.Local).AddTicks(7435) });

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
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4270), 2, new DateTime(2025, 8, 17, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4271), "7a6aa9c2-43dc-4789-b066-5308f7075ff1", new DateTime(2025, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4272) });

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
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4371), 3, new DateTime(2025, 8, 18, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4371), "6592006a-f93e-4bde-be61-b80466d7dfa5", new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 18, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4372) });

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
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4424), 4, new DateTime(2025, 8, 19, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4424), "5d343c7a-ef46-4744-adbd-cf74fd3460a9", new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 19, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4425) });

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
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4553), 5, new DateTime(2025, 8, 20, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4554), "9c17f224-18ab-4b4b-8ea1-adb5b37964cc", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 20, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4554) });

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
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4639), 1, new DateTime(2025, 8, 23, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4640), "8744e540-b76a-4563-8cdb-e16b7e2c68fb", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 23, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4640) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4646), 2, new DateTime(2025, 8, 23, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4647), "33ca7a74-f50c-4ad2-8803-11ddab0c811d", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 23, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4647) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4654), 3, new DateTime(2025, 8, 23, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4654), "18fe73fa-b610-4651-9245-fb13e4e91571", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 23, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4655) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4661), 4, new DateTime(2025, 8, 23, 23, 59, 59, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4662), "4b32a169-5539-4972-8de5-340076b00e21", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 23, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(4662) });

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
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5596), 11, new DateTime(2025, 8, 18, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5596), "66a97d00-e132-4772-bfcc-b19c9168ccfc", new DateTime(2025, 8, 18, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5597) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5606), new DateTime(2025, 8, 18, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5607), "e4e25df8-81a9-4d60-a08e-5755c7c06b3e", new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2025, 8, 18, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5607) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5616), 12, new DateTime(2025, 8, 18, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5616), "d01f25e5-4764-45fd-92ef-bdfce76eb9ac", new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 18, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5617) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5624), 11, new DateTime(2025, 8, 19, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5625), "b76b6b8c-a7f0-432d-82c9-57b33be6aeac", new DateTime(2025, 8, 19, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5625) });

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
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5644), 12, new DateTime(2025, 8, 19, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5644), "84ce650a-2242-4d04-8d3d-98859ea6a624", new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2025, 8, 19, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5645) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5651), 11, new DateTime(2025, 8, 20, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5652), "3fbfdf09-5a9a-433f-9102-85d74a2e3258", new DateTime(2025, 8, 20, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5652) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftDate", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5662), 12, new DateTime(2025, 8, 20, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5663), "c68aea79-b7ae-46dd-89f6-660ebc5843b6", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 20, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5663) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5670), 11, new DateTime(2025, 8, 21, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5671), "01d44356-6cf0-4a01-8d96-a8f48252ab13", new DateTime(2025, 8, 21, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5671) });

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
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "ShiftType", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5696), 11, new DateTime(2025, 8, 22, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5697), "ba3eead9-131b-42d8-a709-cd2b7d4f3528", 1, new DateTime(2025, 8, 22, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5697) });

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
                columns: new[] { "CreatedDate", "EmployeeId", "EndTime", "EntryDate", "MasterId", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5715), 11, new DateTime(2025, 8, 23, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5716), "7f54221b-ad18-43df-936d-b5cf42a0bc52", new DateTime(2025, 8, 23, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 8, 17, 17, 18, 12, 775, DateTimeKind.Local).AddTicks(5716) });

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
    }
}

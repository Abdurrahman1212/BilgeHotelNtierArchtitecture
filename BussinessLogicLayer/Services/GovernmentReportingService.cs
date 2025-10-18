using Models.Entities;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace BussinessLogicLayer.Services
{
    public class GovernmentReportingService
    {
        public string GenerateDailyGuestReportXml(DateTime reportDate, List<Customer> customers)
        {
            var report = new DailyGuestReport
            {
                ReportDate = reportDate,
                TotalGuests = customers.Count,
                TurkishGuests = customers.Count(c => IsTurkishCitizen(c.CustomerIdentityNumber)),
                ForeignGuests = customers.Count(c => !IsTurkishCitizen(c.CustomerIdentityNumber))
            };

            var xml = new XElement("DailyGuestReport",
                new XElement("ReportDate", reportDate.ToString("yyyy-MM-dd")),
                new XElement("HotelInfo",
                    new XElement("Name", "Bilge Hotel"),
                    new XElement("Address", "Kemer, Antalya"),
                    new XElement("Phone", "+90 242 814 50 00")
                ),
                new XElement("Summary",
                    new XElement("TotalGuests", report.TotalGuests),
                    new XElement("TurkishGuests", report.TurkishGuests),
                    new XElement("ForeignGuests", report.ForeignGuests)
                ),
                new XElement("Guests",
                    customers.Select(customer => new XElement("Guest",
                        new XElement("IdentityNumber", customer.CustomerIdentityNumber),
                        new XElement("FirstName", customer.FirstName),
                        new XElement("LastName", customer.LastName),
                        new XElement("BirthDate", GetBirthDateFromIdentityNumber(customer.CustomerIdentityNumber)),
                        new XElement("Gender", GetGenderFromIdentityNumber(customer.CustomerIdentityNumber)),
                        new XElement("Nationality", GetNationalityFromIdentityNumber(customer.CustomerIdentityNumber)),
                        new XElement("Phone", customer.CustomerPhone),
                        new XElement("Email", customer.Email),
                        new XElement("Address", $"{customer.CustomerAddress}, {customer.City}, {customer.County}")
                    ))
                )
            );

            return xml.ToString();
        }

        public async Task<bool> SendReportToGovernment(string xmlContent, string endpointUrl)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var content = new StringContent(xmlContent, Encoding.UTF8, "application/xml");
                    var response = await httpClient.PostAsync(endpointUrl, content);

                    return response.IsSuccessStatusCode;
                }
            }
            catch (Exception ex)
            {
                // Log the error
                Console.WriteLine($"Error sending report to government: {ex.Message}");
                return false;
            }
        }

        public List<Customer> GetGuestsForDate(DateTime date)
        {
            // Bu kısım veritabanından belirtilen tarihte otelde kalan müşterileri getirecek
            // Şimdilik örnek veri döndürüyoruz
            return new List<Customer>
            {
                new Customer
                {
                    Id = 1,
                    FirstName = "Ahmet",
                    LastName = "Yılmaz",
                    CustomerIdentityNumber = "12345678901",
                    CustomerPhone = "+90 555 123 4567",
                    Email = "ahmet@example.com",
                    CustomerAddress = "İstanbul",
                    City = "İstanbul",
                    County = "Kadıköy"
                },
                new Customer
                {
                    Id = 2,
                    FirstName = "Maria",
                    LastName = "Schmidt",
                    CustomerIdentityNumber = "A123456789",
                    CustomerPhone = "+49 30 12345678",
                    Email = "maria@example.com",
                    CustomerAddress = "Berlin",
                    City = "Berlin",
                    County = "Mitte"
                }
            };
        }

        private bool IsTurkishCitizen(string identityNumber)
        {
            // Türk vatandaşı kimlik numarası kontrolü
            return !string.IsNullOrEmpty(identityNumber) &&
                   identityNumber.Length == 11 &&
                   identityNumber.All(char.IsDigit) &&
                   identityNumber.StartsWith("1") || identityNumber.StartsWith("2") ||
                   identityNumber.StartsWith("3") || identityNumber.StartsWith("4") ||
                   identityNumber.StartsWith("5") || identityNumber.StartsWith("6");
        }

        private string GetBirthDateFromIdentityNumber(string identityNumber)
        {
            if (string.IsNullOrEmpty(identityNumber) || identityNumber.Length < 9)
                return "";

            // TC Kimlik numarasından doğum yılı çıkarma (basitleştirilmiş)
            var yearPart = identityNumber.Substring(0, 2);
            var monthPart = identityNumber.Substring(2, 2);
            var dayPart = identityNumber.Substring(4, 2);

            if (int.TryParse(yearPart, out int year) && int.TryParse(monthPart, out int month) && int.TryParse(dayPart, out int day))
            {
                var birthYear = year < 50 ? 2000 + year : 1900 + year;
                return new DateTime(birthYear, month, day).ToString("yyyy-MM-dd");
            }

            return "";
        }

        private string GetGenderFromIdentityNumber(string identityNumber)
        {
            if (string.IsNullOrEmpty(identityNumber) || identityNumber.Length < 9)
                return "Unknown";

            // TC Kimlik numarasının 8. hanesi cinsiyet bilgisi içerir (tek: erkek, çift: kadın)
            var genderDigit = identityNumber.Substring(7, 1);
            return genderDigit == "1" || genderDigit == "3" || genderDigit == "5" || genderDigit == "7" || genderDigit == "9" ? "Male" : "Female";
        }

        private string GetNationalityFromIdentityNumber(string identityNumber)
        {
            if (IsTurkishCitizen(identityNumber))
                return "Turkish";

            // Basit bir kontrol - gerçek uygulamada daha karmaşık olabilir
            if (identityNumber.StartsWith("A") || identityNumber.StartsWith("B"))
                return "German";
            if (identityNumber.StartsWith("C") || identityNumber.StartsWith("D"))
                return "British";
            if (identityNumber.StartsWith("E") || identityNumber.StartsWith("F"))
                return "French";

            return "Other";
        }

        public async Task<bool> GenerateAndSendDailyReport(DateTime reportDate, string governmentEndpoint)
        {
            var guests = GetGuestsForDate(reportDate);
            var xmlContent = GenerateDailyGuestReportXml(reportDate, guests);

            var report = new DailyGuestReport
            {
                ReportDate = reportDate,
                XmlContent = xmlContent,
                TotalGuests = guests.Count,
                TurkishGuests = guests.Count(c => IsTurkishCitizen(c.CustomerIdentityNumber)),
                ForeignGuests = guests.Count(c => !IsTurkishCitizen(c.CustomerIdentityNumber)),
                SentToGovernment = true,
                SentDate = DateTime.Now
            };

            return await SendReportToGovernment(xmlContent, governmentEndpoint);
        }
    }
}

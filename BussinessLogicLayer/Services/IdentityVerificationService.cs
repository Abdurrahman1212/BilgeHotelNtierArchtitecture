using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BussinessLogicLayer.Services
{
    public class IdentityVerificationService
    {
        private readonly HttpClient _httpClient;
        private const string NVIEndpoint = "https://tckimlik.nvi.gov.tr/Service/KPSPublic.asmx";

        public IdentityVerificationService()
        {
            _httpClient = new HttpClient();
            _httpClient.Timeout = TimeSpan.FromSeconds(30);
        }

        public async Task<IdentityVerificationResult> VerifyIdentityAsync(string firstName, string lastName, string birthYear, string identityNumber)
        {
            try
            {
                var soapEnvelope = CreateSoapEnvelope(firstName, lastName, birthYear, identityNumber);

                var content = new StringContent(soapEnvelope, Encoding.UTF8, "text/xml");

                var response = await _httpClient.PostAsync(NVIEndpoint, content);
                response.EnsureSuccessStatusCode();

                var responseContent = await response.Content.ReadAsStringAsync();

                return ParseVerificationResponse(responseContent);
            }
            catch (Exception ex)
            {
                return new IdentityVerificationResult
                {
                    IsValid = false,
                    ErrorMessage = $"Doğrulama hatası: {ex.Message}",
                    IdentityNumber = identityNumber
                };
            }
        }

        public async Task<string> GetIdentityNumberAsync(string firstName, string lastName, string birthYear)
        {
            try
            {
                // Bu kısım NVI'nın kimlik no sorgulama servisi ile entegre edilecek
                // Şimdilik örnek bir kimlik no döndürüyoruz
                // Gerçek uygulamada NVI web servisi kullanılacak

                var soapEnvelope = CreateIdentityQueryEnvelope(firstName, lastName, birthYear);

                var content = new StringContent(soapEnvelope, Encoding.UTF8, "text/xml");

                var response = await _httpClient.PostAsync(NVIEndpoint, content);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    return ParseIdentityQueryResponse(responseContent);
                }

                return null;
            }
            catch (Exception ex)
            {
                // Log the error
                Console.WriteLine($"Identity query error: {ex.Message}");
                return null;
            }
        }

        private string CreateSoapEnvelope(string firstName, string lastName, string birthYear, string identityNumber)
        {
            return $@"<?xml version=""1.0"" encoding=""utf-8""?>
<soap12:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap12=""http://www.w3.org/2003/05/soap-envelope"">
  <soap12:Body>
    <TCKimlikNoDogrula xmlns=""http://tckimlik.nvi.gov.tr/WS"">
      <TCKimlikNo>{identityNumber}</TCKimlikNo>
      <Ad>{firstName}</Ad>
      <Soyad>{lastName}</Soyad>
      <DogumYili>{birthYear}</DogumYili>
    </TCKimlikNoDogrula>
  </soap12:Body>
</soap12:Envelope>";
        }

        private string CreateIdentityQueryEnvelope(string firstName, string lastName, string birthYear)
        {
            return $@"<?xml version=""1.0"" encoding=""utf-8""?>
<soap12:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap12=""http://www.w3.org/2003/05/soap-envelope"">
  <soap12:Body>
    <KisiSorgula xmlns=""http://tckimlik.nvi.gov.tr/WS"">
      <Ad>{firstName}</Ad>
      <Soyad>{lastName}</Soyad>
      <DogumYili>{birthYear}</DogumYili>
    </KisiSorgula>
  </soap12:Body>
</soap12:Envelope>";
        }

        private IdentityVerificationResult ParseVerificationResponse(string responseContent)
        {
            try
            {
                var xmlDoc = XDocument.Parse(responseContent);
                var resultElement = xmlDoc.Descendants().FirstOrDefault(e => e.Name.LocalName == "TCKimlikNoDogrulaResult");

                if (resultElement != null)
                {
                    var isValid = bool.Parse(resultElement.Value);

                    return new IdentityVerificationResult
                    {
                        IsValid = isValid,
                        ErrorMessage = isValid ? null : "Kimlik bilgileri doğrulanamadı",
                        IdentityNumber = null // Doğrulama başarılı ise null döndür
                    };
                }

                return new IdentityVerificationResult
                {
                    IsValid = false,
                    ErrorMessage = "Yanıt işlenemedi",
                    IdentityNumber = null
                };
            }
            catch (Exception ex)
            {
                return new IdentityVerificationResult
                {
                    IsValid = false,
                    ErrorMessage = $"Yanıt işleme hatası: {ex.Message}",
                    IdentityNumber = null
                };
            }
        }

        private string ParseIdentityQueryResponse(string responseContent)
        {
            try
            {
                var xmlDoc = XDocument.Parse(responseContent);
                var resultElement = xmlDoc.Descendants().FirstOrDefault(e => e.Name.LocalName == "KisiSorgulaResult");

                if (resultElement != null)
                {
                    // Bu kısım gerçek NVI yanıtına göre uyarlanacak
                    // Şimdilik örnek kimlik no döndürüyoruz
                    return "12345678901";
                }

                return null;
            }
            catch
            {
                return null;
            }
        }

        public bool ValidateIdentityNumberFormat(string identityNumber)
        {
            if (string.IsNullOrEmpty(identityNumber) || identityNumber.Length != 11)
                return false;

            if (!identityNumber.All(char.IsDigit))
                return false;

            // TC Kimlik numarası algoritması kontrolü
            var digits = identityNumber.Select(c => int.Parse(c.ToString())).ToArray();

            // İlk 9 hanenin toplamının 10'a göre modu
            var sum1 = digits[0] + digits[1] + digits[2] + digits[3] + digits[4] +
                      digits[5] + digits[6] + digits[7] + digits[8];

            var mod1 = sum1 % 10;
            if (digits[9] != mod1)
                return false;

            // İlk 10 hanenin toplamının 10'a göre modu
            var sum2 = sum1 + digits[9];
            var mod2 = sum2 % 10;
            if (digits[10] != mod2)
                return false;

            return true;
        }
    }

    public class IdentityVerificationResult
    {
        public bool IsValid { get; set; }
        public string ErrorMessage { get; set; }
        public string IdentityNumber { get; set; }
    }
}

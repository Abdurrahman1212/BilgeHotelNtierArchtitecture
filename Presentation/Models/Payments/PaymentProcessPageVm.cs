using Presentation.Models.Payments.RequestModels;
using Presentation.Models.Payments.ResponseModels;

namespace Presentatiton.Models.PageVms.Payments
{
    /// <summary>
    /// Ödeme işlemi sayfası için Page View Model.
    /// PaymentProcessRequestModel'ı ve API'den dönen PaymentProcessResponseModel'ı içerir.
    /// </summary>
    public class PaymentProcessPageVm 
    {
        public PaymentProcessPageVm()
        {
            PageTitle = "Ödeme İşlemi";
            HelpText = "Kart bilgilerinizi giriniz.";
            PaymentProcessRequest = new PaymentProcessRequestModel();
        }

        /// <summary>
        /// Ödeme işlemi için gönderilen pure request model.
        /// </summary>
        public PaymentProcessRequestModel PaymentProcessRequest { get; set; }

        /// <summary>
        /// API'den dönen response model.
        /// </summary>
        public PaymentProcessPageVM? PaymentProcessResponse { get; set; }

        /// <summary>
        /// Sayfa başlığı.
        /// </summary>
        public string PageTitle { get; set; }

        /// <summary>
        /// Yardım metni veya açıklama.
        /// </summary>
        public string? HelpText { get; set; }

        /// <summary>
        /// Ek hata mesajları.
        /// </summary>
        public string? ErrorMessage { get; set; }
    }
}

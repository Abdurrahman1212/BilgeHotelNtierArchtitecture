using Presentation.Models.Payments.RequestModels;
using Presentation.Model.Payments.ResponseModels;

namespace Presentatiton.Models.PageVms.Payments
{
    /// <summary>
    /// Ödeme Checkout sayfası için Page View Model.
    /// Pure modelleri (PaymentCheckoutRequest ve PaymentCheckoutResponse) UI’ya özgü ek verilerle sarmalar.
    /// </summary>
    public class PaymentCheckoutPageVm 
    {
        public PaymentCheckoutPageVm()
        {
            PageTitle = "Ödeme İşlemi";
            HelpText = "Ödeme bilgilerinizi giriniz.";
            PaymentCheckoutRequest = new PaymentCheckoutRequestModel();
        }

        /// <summary>
        /// Ödeme için kullanılacak pure request model.
        /// </summary>
        public PaymentCheckoutRequestModel PaymentCheckoutRequest { get; set; }

        /// <summary>
        /// API'den dönen response model (varsa).
        /// </summary>
        public PaymentCheckoutResponseModel? PaymentCheckoutResponse { get; set; }

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

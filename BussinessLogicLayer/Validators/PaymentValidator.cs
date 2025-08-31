using FluentValidation;
using BussinessLogicLayer.DtoClasses;

namespace BussinessLogicLayer.Validators
{
    public class PaymentValidator : AbstractValidator<PaymentDTO>
    {
        public PaymentValidator()
        {
            RuleFor(x => x.ReservationId)
                .GreaterThan(0)
                .WithMessage("Geçerli bir rezervasyon ID'si giriniz");

            RuleFor(x => x.PaymentAmount)
                .GreaterThan(0)
                .WithMessage("Ödeme tutarı 0'dan büyük olmalıdır");

            RuleFor(x => x.PaymentMethod)
                .IsInEnum()
                .WithMessage("Geçerli bir ödeme yöntemi seçiniz");

            RuleFor(x => x.PaymentDate)
                .NotEmpty()
                .WithMessage("Ödeme tarihi zorunludur")
                .LessThanOrEqualTo(DateTime.Now)
                .WithMessage("Ödeme tarihi gelecek bir tarih olamaz");

            RuleFor(x => x.CardNumber)
                .NotEmpty()
                .WithMessage("Kart numarası zorunludur")
                .Length(13, 16)
                .WithMessage("Kart numarası 13-16 karakter olmalıdır")
                .Matches(@"^\d+$")
                .WithMessage("Kart numarası sadece rakam içermelidir");

            RuleFor(x => x.TotalAmount)
                .GreaterThan(0)
                .WithMessage("Toplam tutar 0'dan büyük olmalıdır");

            RuleFor(x => x.PaymentDetails)
                .MaximumLength(500)
                .WithMessage("Ödeme detayları 500 karakterden uzun olamaz");
        }
    }
}

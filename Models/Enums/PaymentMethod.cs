using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Enums
{
    public enum PaymentMethod
    {
        CreditCard = 1,  // Kredi Kartı ile ödeme.
        Cash = 2,        // Nakit ödeme.
        BankTransfer = 3 // Banka Havalesi ile ödeme.
    }
}

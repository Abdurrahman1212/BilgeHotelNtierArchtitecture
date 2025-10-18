using Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class CurrencyRate : BaseEntity
    {
        public string CurrencyCode { get; set; } // USD, EUR, GBP, vb.
        public string CurrencyName { get; set; }
        public decimal Rate { get; set; } // TL karşısındaki değer
        public DateTime LastUpdated { get; set; }
        public string Source { get; set; } // TCMB, ECB, vb.
    }
}

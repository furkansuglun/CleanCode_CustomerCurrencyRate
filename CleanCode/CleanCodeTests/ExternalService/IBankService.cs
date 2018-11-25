using CleancodeDemo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleancodeDemo.ExternalService
{
    public interface IBankService
    {
        decimal ConvertRate(CurrencyRateDTO currencyRateDTO);
        decimal CalculateDiscount(CustomerDiscountDTO customerDiscountDTO);
    }
}

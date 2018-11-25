using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleancodeDemo.DTO;

namespace CleancodeDemo.ExternalService
{
    public class FakeBankService : IBankService
    {
        public decimal CalculateDiscount(CustomerDiscountDTO customerDiscountDTO)
        {
            decimal discountedPrice = 0.0m;
            if (customerDiscountDTO.IsStudent)
                discountedPrice = customerDiscountDTO.Price * customerDiscountDTO.DiscountRate;
            else if (customerDiscountDTO.IsOfficer)
                discountedPrice = customerDiscountDTO.Price * customerDiscountDTO.DiscountRate;
            else
                discountedPrice = customerDiscountDTO.Price;
            return discountedPrice;
        }

        public decimal ConvertRate(CurrencyRateDTO currencyRateDTO)
        {
            return currencyRateDTO.Price / 5.30m;
        }
    }
}

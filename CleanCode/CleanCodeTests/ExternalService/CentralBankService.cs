using CleancodeDemo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleancodeDemo.ExternalService
{
    public class CentralBankService
    {
        public decimal CurrencyConverter(CurrencyRateDTO currencyRateDTO)
        {
            return currencyRateDTO.Price / 5.27m;
        }

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
    }
}

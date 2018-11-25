using CleancodeDemo.DTO;
using CleancodeDemo.ExternalService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleancodeDemo.ExternalServiceAdapters
{
    public class IsBankServiceAdapter : IBankService
    {
        IsBankService isBankService = new IsBankService();

        public decimal CalculateDiscount(CustomerDiscountDTO customerDiscountDTO)
        {
            return isBankService.CalculateDiscount(customerDiscountDTO);
        }

        public decimal ConvertRate(CurrencyRateDTO currencyRateDTO)
        {
            return isBankService.ConvertCurrency(currencyRateDTO.Price, currencyRateDTO.Currency);
        }
    }
}

using CleancodeDemo.DTO;
using CleancodeDemo.ExternalService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleancodeDemo.ExternalServiceAdapters
{
    public class CentralBankServiceAdaptor : IBankService
    {
        CentralBankService centralBankService = new CentralBankService();

        public decimal CalculateDiscount(CustomerDiscountDTO customerDiscountDTO)
        {
            return centralBankService.CalculateDiscount(customerDiscountDTO);
        }

        public decimal ConvertRate(CurrencyRateDTO currencyRateDTO)
        {
            return centralBankService.CurrencyConverter(currencyRateDTO);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleancodeDemo.DTO;
using CleancodeDemo.Entities;
using CleancodeDemo.ExternalService;

namespace CleancodeDemo.BAL
{
    public class ProductService : IProductService
    {
        private IBankService _bankService;

        public ProductService(IBankService bankService)
        {
            _bankService = bankService;
        }

        public void Sell(Product product, Customer customer)
        {
            decimal price = product.Price;
            decimal discountRate = customer.DiscountRate;
            //if (customer.IsStudent)
            //    price = product.Price * 0.90m;
            //if (customer.IsOfficer)
            //    price = product.Price * 0.80m;

            price = _bankService.CalculateDiscount(new CustomerDiscountDTO { Price = price, DiscountRate = discountRate, IsOfficer = customer.IsOfficer, IsStudent = customer.IsStudent });


            // burada currency = 1 ise dolara dönüştürme işlemi için değer yazıldı (0,1,2 vs. kontrolü yok)
            price = _bankService.ConvertRate(new CurrencyRateDTO { Price = price, Currency = 1 });

            Console.WriteLine(price);
        }
    }
}

using CleancodeDemo.BAL;
using CleancodeDemo.Entities;
using CleancodeDemo.ExternalService;
using CleancodeDemo.ExternalServiceAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleancodeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // IProductService productService = new ProductService(new FakeBankService());
            // productService.Sell(new Product { Id = 1, Name = "Laptop", Price = 1000 },
            //new Customer { Id = 1, Name = "Furkan", IsStudent = true, IsOfficer = false, DiscountRate = 0.90m });

            IProductService productService = new ProductService(new CentralBankServiceAdaptor());
            productService.Sell(new Product { Id = 1, Name = "Laptop", Price = 1000 },
           new Customer { Id = 1, Name = "Furkan", IsStudent = true, IsOfficer = false, DiscountRate = 0.90m});

            //IProductService productService = new ProductService(new IsBankServiceAdapter());
            //productService.Sell(new Product { Id = 1, Name = "Laptop", Price = 1000 },
            //new Customer { Id = 1, Name = "Furkan", IsStudent = false, IsOfficer = false, DiscountRate = 0.90m });

            Console.Read();
        }
    }
}

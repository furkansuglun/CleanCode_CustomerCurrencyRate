using CleancodeDemo.BAL;
using CleancodeDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleancodeDemo.BAL
{
    public interface IProductService
    {
        void Sell(Product product, Customer customer);
    }
}

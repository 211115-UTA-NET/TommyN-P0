using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project0Logic
{
    public interface IProductInfo
    {
        int ProductId { get; }
        string ProductName { get; }
        double Price { get; }
        string StoreLocation { get; }
        int ProductCount { get; set; }
        int ProductLimit { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project0Logic
{
    public interface IProductInfo
    {
        string ProductName { get; }
        string Description { get; }
        string StoreLocation { get; }
        int ProductId { get; } 
        double Price { get; }
        int ProductCount { get; set; }
        int ProductLimit { get; }
    }
}

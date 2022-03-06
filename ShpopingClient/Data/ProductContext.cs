using ShpopingClient.Models;
using System.Collections.Generic;

namespace ShpopingClient.Data
{
    public class ProductContext
    {
        public static readonly List<Product> product = new List<Product>
        {
            new Product()
            {
                Name = "iPhone X",
                Description =  " SmartPhone iPhone x",
                Image ="iphonex.png",
                price = 950.00M,
                Category = "smart phone"
            },
            new Product()
            {
                Name = "iPhone XR",
                Description =  " SmartPhone iPhone xr",
                Image ="iphonexr.png",
                price = 1000.00M,
                Category = "smart phone"
            }
        };
    }
}

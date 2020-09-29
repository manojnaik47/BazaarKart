using System;
using System.Collections.Generic;
using System.Text;
using BKart.Domain.Product;

namespace BKart.Services.Product
{
    public interface IProductService
    {
        void AddProduct(BKart.Domain.Product.Product product);
    }
}

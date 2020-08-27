using eShop.CoreBusiness.Models;
using System.Collections.Generic;

namespace eShop.UseCases.SearchProductScreen
{
    public interface ISearchProduct
    {
        IEnumerable<Product> Execute(string filter = null);
    }
}
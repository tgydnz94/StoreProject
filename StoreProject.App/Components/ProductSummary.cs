using Microsoft.AspNetCore.Mvc;
using StoreProject.Dal.Context;
using StoreProject.Services.Abstract;

namespace StoreProject.App.Components
{
    public class ProductSummaryViewComponent : ViewComponent
    {
        private readonly IProductService _productService;

        public ProductSummaryViewComponent(IProductService productService)
        {
            _productService= productService;
        }

        public string Invoke()
        {
            return _productService.GetAllProducts(false).Count().ToString();
        }
    }
}

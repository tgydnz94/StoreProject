using Microsoft.AspNetCore.Mvc;
using StoreProject.Services.Abstract;

namespace StoreProject.App.Views.Shared.Components.Products.Summary
{
    [ViewComponent(Name = "ProductSummary")]
    public class ProductSummaryViewComponent : ViewComponent
    {
        private readonly IProductService _productService;

        public ProductSummaryViewComponent(IProductService productService)
        {
            _productService = productService;
        }

        public string Invoke()
        {
            return _productService.GetAllProducts(false).Count().ToString();
        }
    }
}

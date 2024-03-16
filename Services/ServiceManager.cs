using Services.Contracts;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        public IProductService ProductService => _productService;

        public ICategoryService CategoryService => _categoryService;

        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ServiceManager(ICategoryService categoryService, IProductService productService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
    }
}
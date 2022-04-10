using E_Commerce.Domain.ViewModels.ProductVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Persistence.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<ProductsVM> GetAll()
        {
            var products = _unitOfWork.Product.GetAll(null,"Category");
            var productsVM = new List<ProductsVM>();
            
            return productsVM;
            
        }
    }
}

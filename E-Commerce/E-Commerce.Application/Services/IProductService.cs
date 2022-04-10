
namespace E_Commerce.Application.Services
{
    public interface IProductService
    {
        IEnumerable<ProductsVM> GetAll();
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaloniaApp.Services;

public interface IProductsService
{
    Task<IEnumerable<Product>> GetProducts();
}

public class ProductsService : IProductsService
{
    public async Task<IEnumerable<Product>> GetProducts()
    {
        return await Task.FromResult(Enumerable.Empty<Product>());
    }
}

public class Product
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
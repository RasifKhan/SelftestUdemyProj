using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entites;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        //  Task<IReadOnlyList<Product>> GetProductAsync();


        // Task<IReadOnlyList<Product>> GetProductAsync(string? brand,string? type); //we will pass prameters here 

        Task<IReadOnlyList<Product>> GetProductAsync(string? brand,string? type,string? sort); //we will pass prameters here 

        Task<Product?> GetProductByIdAsync(int id);

        Task<IReadOnlyList<string>> GetBrandsAsync();  

        Task<IReadOnlyList<string>> GetTypesAsync(); 

        void AddProduct(Product product);

        void UpdateProduct(Product product);

        void DeleteProduct(Product product);

        bool ProductExists(int id);

        Task<bool> SaveChangesAsync();
    }
}
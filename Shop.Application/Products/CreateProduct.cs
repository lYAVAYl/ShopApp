using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Shop.Database;
using Shop.Domain.Models;

namespace Shop.Application.Products
{
    public class CreateProduct
    {
        private ApplicationDbContext _context;

        public CreateProduct(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Do(ProductVM productVM)
        {
            await _context.Products.AddAsync(
                new Product
                {
                    Name = productVM.Name, 
                    Description = productVM.Description, 
                    Value = Convert.ToDecimal(productVM.Value)
                });
            await _context.SaveChangesAsync();
        }
        
    }
}

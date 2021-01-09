using System;
using System.Collections.Generic;
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

        public async Task Do(string name, string description, decimal value)
        {
            await _context.Products.AddAsync(new Product{Name = name, Description = description, Value = value});
            await _context.SaveChangesAsync();
        }
    }
}

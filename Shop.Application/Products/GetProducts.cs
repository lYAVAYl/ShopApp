using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shop.Database;

namespace Shop.Application.Products
{
    public class GetProducts
    {
        private ApplicationDbContext _ctx;

        public GetProducts(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<ProductVM> Do() => 
            _ctx.Products.ToList().Select(x => new ProductVM(x.Name, x.Description, "$ " + x.Value.ToString("N2")));
        
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Application.Products;
using Shop.Database;

namespace ShopApp.UI.Pages
{
    public class IndexModel : PageModel
    {
        private ApplicationDbContext _ctx;

        public IndexModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        [BindProperty]
        public ProductVM Product { get; set; }

        public class ProductVM
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Value { get; set; } 
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            await new CreateProduct(_ctx).Do(Product.Name, Product.Description, Product.Value);

            return RedirectToPage("Index");
        }
    }
}

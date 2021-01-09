using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Application.Products
{
    public class ProductVM
    {
        public ProductVM(string name, string description, string value)
        {
            Name = name;
            Description = description;
            Value = value;
        }
        public ProductVM(){}

        public string Name { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
    }
}

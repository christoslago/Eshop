using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eshop.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public ICollection<Product> Products { get; set; }
        public int CompanyId { get; set; }

    }
}
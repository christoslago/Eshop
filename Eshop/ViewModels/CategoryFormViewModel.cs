using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Eshop.Models;

namespace Eshop.ViewModels
{
    public class CategoryFormViewModel
    {
        public Category Category { get; set; }
        public List<Company> Companies { get; set; }
       
    }
}
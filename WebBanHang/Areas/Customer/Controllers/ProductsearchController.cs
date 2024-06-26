using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHang.Models;

namespace PhoneStore.Areas.Customer.Controllers
    {[Area("Customer")]
    public class ProductsearchController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ProductsearchController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult ProductSearch(string searchTerm)
        {
            var product = _db.Products.Where(x => x.Name.Contains(searchTerm)).ToList();
            ViewBag.SearchTerm = searchTerm;
            return View(product);
        }

    }
}

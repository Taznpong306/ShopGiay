using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHang.Models;

namespace PhoneStore.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ProductdetailController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ProductdetailController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Productdetail(string id)
        {
            var product = _db.Products.FirstOrDefault(x => x.Id == int.Parse(id));
            return View(product);
        }
    }
}

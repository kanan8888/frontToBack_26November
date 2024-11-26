using Microsoft.AspNetCore.Mvc;
using WebApp_FrontToBack_25November.DAL;
using WebApp_FrontToBack_25November.Models;

namespace WebApp_FrontToBack_25November.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext db;
        public HomeController(AppDbContext db)
        {
            this.db = db;
        }


        public IActionResult Index()
        {
            List<Product> products = db.Products.ToList();
            return View(products);
        }


    }
}

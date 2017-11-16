using Microsoft.AspNetCore.Mvc;

namespace InspiniaNetCore.Controllers
{
    public class SaleController : Controller
    {
        public IActionResult SalePage(){
            return View();
        }
        public IActionResult SaleHistory(){
            return View();
        }
    }
}
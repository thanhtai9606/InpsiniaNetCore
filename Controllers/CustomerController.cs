using Microsoft.AspNetCore.Mvc;
namespace InspiniaNetCore.Controllers
{
    public class CustomerController : Controller
    {
       public IActionResult Contacts()
       {
           return View();
       }
       public IActionResult Contacts_v2()
       {
           return View();
       }
       public IActionResult Contact_List()
       {
           return View();
       }
       public IActionResult Index()
       {
           return View();
       }
       public IActionResult Profile()
       {
           return View();
       }
    }
}
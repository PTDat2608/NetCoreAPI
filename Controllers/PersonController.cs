using DemoMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMvc.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Person ps)
        {
            string strOutput = "Xin Chao" + ps.PersonId + "-" + ps.Fullname + "-" + ps.Address;
            ViewBag.infoPerson = strOutput;
            return View();
        }
    }
}
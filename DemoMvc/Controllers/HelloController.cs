using Microsoft.AspNetCore.Mvc;
using DemoMvc.Models;
using DemoMvc.Models.Entities;
namespace DemoMvc.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
         public IActionResult Index( Student ps)
         {
            string strOutput = "Xin chao" + ps.StudentID + "-" + ps.FullName ;
            ViewBag.Message = strOutput;
            return View();
            
         }
    }

}
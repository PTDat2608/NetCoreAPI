using DemoMvc.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace  DemoMvc.Controllers

{
    public class PersonControlle : Controller
    {
        public IActionResult Index()
        { 
            return View();
        }
        [HttpPost]
         public IActionResult Index( Person ps)
         {
            string strOutput = "Xin chao" + ps.PersonID + "-" + ps.FullName +"-" + ps.Diachi    ;
            ViewBag.infoPerson = strOutput;
            return View();
            
         }
    }
}
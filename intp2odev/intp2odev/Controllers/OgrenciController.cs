using intp2odev.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace intp2odev.Controllers
{
    public class OgrenciController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult OgrenciEkle()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult OgrenciEkle(Ogrenci o)
        {
            if (o!=null)
            {
            using (var ctx = new OkulContext())
            {
                ctx.Ogrenciler.Add(o);
                ctx.SaveChanges();
            }
            }
            return View();
        }
    }
   
}

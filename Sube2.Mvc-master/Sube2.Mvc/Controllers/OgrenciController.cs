using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sube2.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sube2.Mvc.Controllers
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
        public IActionResult OgrenciEkle(Ogrenci ogr)
        {
            if (ogr != null)
            {
                using (var ctx = new OkulDbContext())
                {
                    ctx.Ogrenciler.Add(ogr);
                    ctx.SaveChanges();
                }
            }
            return View();
        }

        public IActionResult OgrenciListe()
        {
            List<Ogrenci> lst = null;
            using (var ctx = new OkulDbContext())
            {
                lst = ctx.Ogrenciler.ToList();
            }
            return View(lst);
        }

        public IActionResult OgrenciSil(int? id)
        {
            using (var ctx = new OkulDbContext())
            {
                var ogr = ctx.Ogrenciler.Find(id);
                ctx.Remove(ogr);
                ctx.SaveChanges();
            }
            return RedirectToAction("OgrenciListe");
        }

        public IActionResult OgrenciDetay(int id)
        {
            Ogrenci ogr = null;
            using (var ctx = new OkulDbContext())
            {
                ogr = ctx.Ogrenciler.Find(id);
            }
            return View(ogr);
        }

        [HttpPost]
        public IActionResult OgrenciDetay(Ogrenci ogr)
        {
            using (var ctx = new OkulDbContext())
            {
                ctx.Entry(ogr).State = EntityState.Modified;
                ctx.SaveChanges();
            }
            return RedirectToAction("OgrenciListe");
        }
    }
}

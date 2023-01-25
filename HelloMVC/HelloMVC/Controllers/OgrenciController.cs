using Microsoft.AspNetCore.Mvc;

namespace HelloMVC.Controllers
{
    public class OgrenciController : Controller
    {
        public ViewResult Index() //Action metod
        {
            return View();
        }
       public ViewResult OgrenciListe()//ctrl+m,g
        {
            ViewBag.Ad2 = "Berk";
            ViewBag.Soyad2 = "Özgül";
            ViewBag.Numara2 = 123;
            //ViewBag arka planda viewdata kulllanır değişkenler keyler unic olmalı.
            ViewData["Ad"] = "Ali";
            ViewData["Soyad"]="Veli";
            ViewData["Numara"] = 123;
            ViewData["Ad1"] = "Okan";
            ViewData["Soyad1"] = "Erdem";
            ViewData["Numara1"] = 1907;


            return View();
;        }
        //Koleksiyon - Collection
        //ViewData Collection
        //Key:String
        //Value:
        public string OgrenciBilgi(int id)
        {
            string ogrenci="ID Gelmedi!";
            if (id==1)
            {
                ogrenci = "Ali Veli";
            }
            else if (id == 2)
            {
                ogrenci = "Osman";
            }  
            return ogrenci;
        }

        
    }
}//Internet Information Services: Microsoft'un web sunucusudur.

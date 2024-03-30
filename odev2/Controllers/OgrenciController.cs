using Microsoft.AspNetCore.Mvc;
using odev2.Models.Ogrenciler;

namespace odev2.Controllers
{
    public class OgrenciController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Listele()
        {
            ViewData["Baslik"] = "ÖĞRENCİ LİSTESİ";
            return View(Ogrenciler.kOgrenci);

        }
        public IActionResult YeniKayit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniKayit(Models.OgrenciBil _ogrenci)
        {
            Ogrenciler.kOgrenci.Add(_ogrenci);
            return RedirectToAction("Listele");
        }
    }
}

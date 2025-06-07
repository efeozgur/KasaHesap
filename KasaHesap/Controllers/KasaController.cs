using KasaHesap.Context;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace KasaHesap.Controllers
{
    public class KasaController : Controller
    {
        MyContext _context;
        public KasaController(MyContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = _context.KasaHesap.FirstOrDefault(p=> p.Id == 1);         
            var emanetfark = model.PortalEmanet - model.BankaEmanet;
            var harcfark = model.PortalHarc - model.BankaHarc;

            var eldeBulunmasiGereken = emanetfark + harcfark + model.GelirVergisi + model.DamgaVergisi;
            var eldeBulunanMiktar = model.EldeSayilanMiktar + model.SlipToplam + model.ProvizyondaBekleyenTutar;
            float sonuc = eldeBulunmasiGereken - eldeBulunanMiktar;

            ViewBag.EldeBulunmasiGereken = eldeBulunmasiGereken.ToString("0.00");
            ViewBag.EldeSayilanMiktar = eldeBulunanMiktar.ToString("0.00");
            ViewBag.sonuc = sonuc.ToString("0.00", CultureInfo.InvariantCulture);


           

            ViewBag.Sonuc = sonuc;
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(Models.KasaHesap model)
        {
            Console.WriteLine(model.PortalEmanet);
            if (ModelState.IsValid)
            {
                var existingModel = _context.KasaHesap.FirstOrDefault(p => p.Id == 1);
                if (existingModel != null)
                {
                    existingModel.PortalEmanet = model.PortalEmanet;
                    existingModel.BankaEmanet = model.BankaEmanet;
                    existingModel.PortalHarc = model.PortalHarc;
                    existingModel.BankaHarc = model.BankaHarc;
                    existingModel.GelirVergisi = model.GelirVergisi;
                    existingModel.DamgaVergisi = model.DamgaVergisi;
                    existingModel.EldeSayilanMiktar = model.EldeSayilanMiktar;
                    existingModel.ProvizyondaBekleyenTutar = model.ProvizyondaBekleyenTutar;
                    existingModel.SlipToplam = model.SlipToplam;
                    
                    _context.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }
    }
}

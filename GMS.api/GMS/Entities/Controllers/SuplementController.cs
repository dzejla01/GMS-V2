using GMS.Data;
using GMS.Entities.Models;
using GMS.Entities.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GMS.Entities.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SuplementController : Controller
    {
        private readonly ApplicationDbContext db;
        public SuplementController(ApplicationDbContext dbContext)
        {
            db = dbContext;
        }

        [HttpPost]

        public Suplement Add([FromBody] SuplementAddVM x)
        {
            var noviZapis = new Suplement
            {
                Naziv = x.Naziv,
                Cijena = x.Cijena,
                Gramaza = x.Gramaza,
                Opis = x.Opis,
                //Slika = x.Slika,
                DobavljacID = x.DobavljacID,
                KategorijaID = x.KategorijaID
               

            };

            db.Add(noviZapis);
            db.SaveChanges();
            return noviZapis;
        }

        [HttpGet]

        public object GetAll()
        {
            var sviZapisi = db.Suplement.Include("Dobavljac").Include("Kategorija")
                .Select(x => new
                {
                    ID = x.ID,
                    Naziv = x.Naziv,
                    Cijena = x.Cijena,
                    Gramaza = x.Gramaza,
                    Opis = x.Opis,
                    Dobavljac = x.Dobavljac,
                    Kategorija = x.Kategorija
                }
                ).ToList();

            return sviZapisi;
        }

    }
}

using GMS.Data;
using GMS.Entities.Models;
using GMS.Entities.ViewModels;
using Microsoft.AspNetCore.Mvc;

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
                Cijena = x.Cijena
               

            };

            db.Add(noviZapis);
            db.SaveChanges();
            return noviZapis;
        }

        [HttpGet]

        public object GetAll()
        {
            var sviZapisi = db.Suplement
                .Select(x => new
                {
                    ID = x.ID,
                    Naziv = x.Naziv,
                    Cijena = x.Cijena
                }
                ).ToList();

            return sviZapisi;
        }

    }
}

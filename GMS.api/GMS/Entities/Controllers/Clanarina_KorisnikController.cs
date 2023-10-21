using GMS.Data;
using GMS.Entities.Models;
using GMS.Entities.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GMS.Entities.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")] 
    public class Clanarina_KorisnikController : ControllerBase
    {
        private readonly ApplicationDbContext db;
        public Clanarina_KorisnikController(ApplicationDbContext dbContext)
        {
            db = dbContext;
        }


        [HttpPost]
        public Korisnik_Clanarina Add([FromBody] Korisnik_ClanarinaAddVM x)
        {
            var novaKorisnikClanarina = new Korisnik_Clanarina
            {
                KorisnikID= x.KorisnikID,
                ClanarinaID=x.ClanarinaID,
                DatumUplate = x.DatumUplate,
                DatumIsteka = x.DatumIsteka
            };

            db.Korisnik_Clanarina.Add(novaKorisnikClanarina);
            db.SaveChanges();
            return novaKorisnikClanarina;

        }

        [HttpGet]

        public object GetAll()
        {
            var sviKorisniciClanarine = db.Korisnik_Clanarina
                .Select(x => new
                {
                    Korisnik = x.Korisnik,
                    Clanarina = x.Clanarina,
                    DatumUplate = x.DatumUplate,
                    DatumIsteka = x.DatumIsteka,
                }
                ).ToList();

            return sviKorisniciClanarine;
        }

    }
}

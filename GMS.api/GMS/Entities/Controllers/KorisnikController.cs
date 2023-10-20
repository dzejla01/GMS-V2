using GMS.Data;
using GMS.Entities.Models;
using GMS.Entities.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GMS.Entities.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class KorisnikController : ControllerBase
    {

        private readonly ApplicationDbContext db;

        public KorisnikController(ApplicationDbContext dbContext)
        {
            this.db = dbContext;
        }

        [HttpPost]

        public Korisnik Add([FromBody] KorisnikAddVM x)
        {
            var noviZapis = new Korisnik
            {
                Ime = x.Ime,
                Prezime = x.Prezime,
                //Username = x.Username,
                //Password = x.Password,
                //Slika = x.Slika,
                //BrojTelefona = x.BrojTelefona,
                //Tezina = x.Tezina,
                //Visina = x.Visina,
                GradID = x.GradID
            };

            db.Add(noviZapis);
            db.SaveChanges();
            return noviZapis;
        }

        [HttpGet]

        public object GetAll()
        {
            var sviKorisnici = db.Korisnik.OrderBy(x => x.Ime)
                .Select(x => new
                {
                    ID = x.ID,
                    Ime = x.Ime,
                    Prezime = x.Prezime,
                    //Username = x.Username,
                    //Password = x.Password,
                    //Slika = x.Slika,
                    //BrojTelefona = x.BrojTelefona,
                    //Visina = x.Visina,
                    //Tezina = x.Tezina,
                    //GradID = x.GradID,
                    Grad = x.Grad
                }
                ).AsQueryable();


            return sviKorisnici.ToList();
        }
    }
}

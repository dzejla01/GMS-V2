﻿using GMS.Data;
using GMS.Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace GMS.Entities.Generator
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PodaciGenerator : ControllerBase
    {
        private readonly ApplicationDbContext db;

        public PodaciGenerator(ApplicationDbContext dbContext)
        {
            db = dbContext;
        }

        //[HttpGet]
        //public ActionResult Count()
        //{
        //    Dictionary<string, int> data = new Dictionary<string, int>();
        //    data.Add("Grad", db.Grad.Count());
        //    //data.Add("Spol", db.Spol.Count());
        //    //data.Add("Teretana", db.Teretana.Count());
        //    //data.Add("Korisnik", db.Korisnik.Count());
        //    //data.Add("Predmet", db.Predmet.Count());

        //    return Ok(data);
        //}

        [HttpPost]
        public ActionResult Generisi()
        {
            var gradovi = new List<Grad>();
            var spolovi = new List<Spol>();
            var teretane = new List<Teretana>();
            var korisnici = new List<Korisnik>();
            var clanarine = new List<Clanarina>();
            var korisnici_clanarine = new List<Korisnik_Clanarina>();
            var administratori = new List<Administrator>();
            var suplementi = new List<Suplement>();

            gradovi.Add(new Grad { Naziv = "Mostar" });
            gradovi.Add(new Grad { Naziv = "Sarajevo" });
            gradovi.Add(new Grad { Naziv = "Tuzla" });
            gradovi.Add(new Grad { Naziv = "Zenica" });
            gradovi.Add(new Grad { Naziv = "Banja Luka" });
            gradovi.Add(new Grad { Naziv = "Konjic" });
            gradovi.Add(new Grad { Naziv = "Jablanica" });
            gradovi.Add(new Grad { Naziv = "Bihać" });
            gradovi.Add(new Grad { Naziv = "Bosanski Brod" });
            gradovi.Add(new Grad { Naziv = "Neum" });
            gradovi.Add(new Grad { Naziv = "Kalesija" });
            gradovi.Add(new Grad { Naziv = "Cazin" });
            gradovi.Add(new Grad { Naziv = "Trebinje" });
            gradovi.Add(new Grad { Naziv = "Doboj" });
            gradovi.Add(new Grad { Naziv = "Goražde" });
            gradovi.Add(new Grad { Naziv = "Livno" });
            gradovi.Add(new Grad { Naziv = "Visoko" });
            gradovi.Add(new Grad { Naziv = "Široki Brijeg" });
            gradovi.Add(new Grad { Naziv = "Ljubuški" });



            spolovi.Add(new Spol { Naziv = "Muški" });
            spolovi.Add(new Spol { Naziv = "Ženski" });


            teretane.Add(new Teretana { Naziv = "Bodyline", Adresa = "Zalik 1, Mostar 88000" });
            teretane.Add(new Teretana { Naziv = "Body Art", Adresa = "Kolodvorska 12, Sarajevo 71000" });
            teretane.Add(new Teretana { Naziv = "Shark", Adresa = "Kalbunar bb, Travnik 72270" });



            korisnici.Add(new Korisnik { Ime = "Vedad", Prezime = "Keskin", Username = "vedadke", Password = "bayern123", Tezina = 80, Visina = 170, BrojTelefona = "0644076290", SpolID = 1, TeretanaID = 1, GradID = 1 });
            korisnici.Add(new Korisnik { Ime = "Džejla", Prezime = "Palalić", Username = "dzejlap", Password = "frizider12", Tezina = 57, Visina = 164, BrojTelefona = "062123123", SpolID = 2, TeretanaID = 2, GradID = 4 });
            korisnici.Add(new Korisnik { Ime = "Said", Prezime = "Keskin", Username = "saidke", Password = "bullet2001", Tezina = 64, Visina = 180, BrojTelefona = "06407232", SpolID = 1, TeretanaID = 1, GradID = 1 });


            clanarine.Add(new Clanarina { Naziv = "Standardna", Cijena = 50 });
            clanarine.Add(new Clanarina { Naziv = "Studenti", Cijena = 30 });
            clanarine.Add(new Clanarina { Naziv = "Dijeca", Cijena = 20 });
            clanarine.Add(new Clanarina { Naziv = "Stariji", Cijena = 25 });
            clanarine.Add(new Clanarina { Naziv = "Parovi", Cijena = 25 });



            //korisnici_clanarine.Add(new Korisnik_Clanarina
            //{
            //    KorisnikID = 1,
            //    ClanarinaID = 2,
            //    DatumUplate = new DateTime(2023, 11, 01, 9, 15, 0),
            //    DatumIsteka = new DateTime(2023, 12, 01, 9, 15, 0)
            //});
            //korisnici_clanarine.Add(new Korisnik_Clanarina
            //{
            //    KorisnikID = 1,
            //    ClanarinaID = 2,
            //    DatumUplate = new DateTime(2023, 12, 01, 9, 15, 0),
            //    DatumIsteka = new DateTime(2024, 01, 01, 9, 15, 0)
            //});
            //korisnici_clanarine.Add(new Korisnik_Clanarina
            //{
            //    KorisnikID = 2,
            //    ClanarinaID = 2,
            //    DatumUplate = new DateTime(2023, 11, 01, 9, 15, 0),
            //    DatumIsteka = new DateTime(2023, 12, 01, 9, 15, 0)
            //});



            administratori.Add(new Administrator { Username = "admin", Password = "admin" });
            administratori.Add(new Administrator { Username = "host", Password = "host" });



            suplementi.Add(new Suplement { Naziv = "Kreatin Monohidrat", Cijena = 80 });
            suplementi.Add(new Suplement { Naziv = "Protein Monohidrat", Cijena = 120 });
            suplementi.Add(new Suplement { Naziv = "BCAA Energentski napitak", Cijena = 5 });
            suplementi.Add(new Suplement { Naziv = "Taurin Thro Pre-Workout", Cijena = 40 });
            suplementi.Add(new Suplement { Naziv = "Purbear Protein Bar", Cijena = 4 });



            db.AddRange(gradovi);
            db.AddRange(spolovi);
            db.AddRange(teretane);
            //db.AddRange(korisnici);
            db.AddRange(clanarine);
            //db.AddRange(korisnici_clanarine);
            db.AddRange(administratori);

            db.SaveChanges();

            return Ok();
        }
    }
}

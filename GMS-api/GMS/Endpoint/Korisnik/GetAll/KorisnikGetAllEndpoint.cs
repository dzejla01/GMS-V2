using GMS.Controllers.Drzava.Add;
using GMS.Data;
using GMS.Endpoint.Drzava.Search;
using GMS.Entities.Models;
using GMS.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GMS.Controllers
{
    [Route("Korisnik-GetAll")]
    public class KorisnikGetAllEndpoint : MyBaseEndpoint<KorisnikGetAllRequest, KorisnikGetAllResponse>
    {
    private readonly ApplicationDbContext db;

    public KorisnikGetAllEndpoint(ApplicationDbContext db)
    {
        this.db = db;
    }

    [HttpGet]
        public override async Task<KorisnikGetAllResponse> Handle([FromQuery] KorisnikGetAllRequest request)
        {

            var korisnici = await db.Korisnik
                .Select(x => new KorisnikGetAllResponseRow
                {
                    ID = x.ID,
                    Ime = x.Ime,
                    Prezime = x.Prezime,
                    Visina = x.Visina,
                    Tezina = x.Tezina,
                    GradNaziv = x.Grad.Naziv,
                    TeretanaNaziv = x.Teretana.Naziv,
                    SpolNaziv = x.Spol.Naziv
                }).ToListAsync();

            return new KorisnikGetAllResponse
            {
                Korisnici = korisnici
            };

        }

    }
}

using GMS.Controllers.Drzava.Add;
using GMS.Data;
using GMS.Endpoint.Drzava.Search;
using GMS.Entities.Models;
using GMS.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GMS.Controllers
{
    [Route("Korisnik-Search")]
    public class KorisnikSearchEndpoint : MyBaseEndpoint<KorisnikSearchRequest, KorisnikSearchResponse>
    {
    private readonly ApplicationDbContext db;

    public KorisnikSearchEndpoint(ApplicationDbContext db)
    {
        this.db = db;
    }

    [HttpGet]
        public override async Task<KorisnikSearchResponse> Handle([FromQuery] KorisnikSearchRequest request)
        {
            var korisnik = await db.Korisnik.Where(x => request.Pretraga == null ||
            (x.Ime + " " + x.Prezime).StartsWith(request.Pretraga) ||
            (x.Prezime + " " + x.Ime).StartsWith(request.Pretraga))
                .Select(x=> new KorisnikSearchResponseRow
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

            return new KorisnikSearchResponse
            {
                Korisnici = korisnik
            };
        }

    }
}

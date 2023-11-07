using GMS.Data;
using GMS.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GMS.Endpoint.Suplement.GetAll
{
    [Route("Suplement-GetAll")]

    public class SuplementGetAllEndpoint : MyBaseEndpoint<SuplementGetAllRequest, SuplementGetAllResponse>
    {
        private readonly ApplicationDbContext db;

        public SuplementGetAllEndpoint(ApplicationDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
<<<<<<< HEAD
        public override async Task<SuplementGetAllResponse> Handle([FromQuery] SuplementGetAllRequest request)
=======
        public override async Task<SuplementGetAllResponse> Handle([FromQuery]SuplementGetAllRequest request)
>>>>>>> 15dfdf123f81952173c277a0cb9ffa83f79011bf
        {
            var suplementi = await db.Suplement
                .Select(x => new SuplementGetAllResponseRow
                {
<<<<<<< HEAD
                    ID = x.ID,
                    Naziv = x.Naziv,
                    Cijena = x.Cijena,
                    Gramaža = x.Gramaza,
                    Opis = x.Opis,
                    NazivDobavljaca = x.Dobavljac.Naziv,
                    NazivKategorija = x.Kategorija.Naziv
=======
                    ID=x.ID,
                    Naziv=x.Naziv,
                    Cijena=x.Cijena,
                    Gramaža=x.Gramaza,
                    Opis=x.Opis,
                    NazivDobavljaca=x.Dobavljac.Naziv,
                    NazivKategorija=x.Kategorija.Naziv  
>>>>>>> 15dfdf123f81952173c277a0cb9ffa83f79011bf
                }).ToListAsync();

            return new SuplementGetAllResponse
            {
                Suplementi = suplementi
            };

        }
    }
}

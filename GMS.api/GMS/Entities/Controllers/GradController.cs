using GMS.Data;
using GMS.Entities.Models;
using GMS.Entities.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GMS.Entities.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class GradController : ControllerBase
    {

        private readonly ApplicationDbContext db;

        public GradController(ApplicationDbContext dbContext)
        {
            this.db = dbContext;
        }

        [HttpPost]

        public Grad Add([FromBody] GradAddVM x)
        {
            var noviGrad = new Grad
            {
                Naziv = x.Naziv
            };

            db.Add(noviGrad);
            db.SaveChanges();
            return noviGrad;
        }

        [HttpGet]

        public object GetAll()
        {
            var sviGradovi = db.Grad.OrderBy(x => x.Naziv)
                .Select(x => new
                {
                    ID = x.ID,
                    Naziv = x.Naziv
                }
                ).AsQueryable();

            return sviGradovi.ToList();
        }


    }
}

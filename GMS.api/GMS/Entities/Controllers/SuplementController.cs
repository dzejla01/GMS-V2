﻿using GMS.Data;
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
                DobavljacID = x.DobavljacID
               

            };

            db.Add(noviZapis);
            db.SaveChanges();
            return noviZapis;
        }

        [HttpGet]

        public object GetAll()
        {
            var sviZapisi = db.Suplement.Include("Dobavljac")
                .Select(x => new
                {
                    ID = x.ID,
                    Naziv = x.Naziv,
                    Cijena = x.Cijena,
                    Dobavljac = x.Dobavljac
                }
                ).ToList();

            return sviZapisi;
        }

    }
}

﻿using GMS.Entities.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GMS.Entities.ViewModels
{
    public class KorisnikAddVM
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        //public string Username { get; set; }
        //public string Password { get; set; }
        //public byte[]? Slika { get; set; }

        //public PhoneAttribute BrojTelefona { get; set; }
        //public float Visina { get; set; }
        //public float Tezina { get; set; }

        public int GradID { get; set; }

    }
}

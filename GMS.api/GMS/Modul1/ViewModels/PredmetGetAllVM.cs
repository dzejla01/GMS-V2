﻿using GMS.Modul1.Models;

namespace GMS.Modul1.ViewModels
{
    public class PredmetGetAllVM
    {
        

        public int ID { get; set; }
        public string Naziv { get; set; }
        public string ECTS { get; set; }
        public string Sifra { get; set; }
        public double? ProsjecnaOcjena { get; set; }
    }
}

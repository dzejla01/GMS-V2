using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GMS.Modul0_Autentifikacija.Models;

namespace GMS.Modul1.Models
{
    public class Obavijest
    {

        [Key]
        public int ID {get;set;}
        public string Naslov  {get;set;}
        public string Tekst {get;set;}
        public DateTime DatumKreiranja { get; set; }

        [ForeignKey(nameof(EvidentiraoKorisnik))]
        public int EvidentiraoKorisnikID { get; set; }
        public KorisnickiNalog EvidentiraoKorisnik { get; set; }


        [ForeignKey(nameof(IzmijenioKorisnik))]
        public int? IzmijenioKorisnikID { get; set; }
        public KorisnickiNalog IzmijenioKorisnik { get; set; }
        
        
        public DateTime? DatumUpdate  { get; set; }

    }
}

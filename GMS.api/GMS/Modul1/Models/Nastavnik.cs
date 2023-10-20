using System.ComponentModel.DataAnnotations.Schema;
using GMS.Modul0_Autentifikacija.Models;

namespace GMS.Modul1.Models
{
    [Table("Nastavnik")]
    public class Nastavnik:KorisnickiNalog
    {
        public string Ime { get; set; }
        public string Prezime{ get; set; }
     
    }
}

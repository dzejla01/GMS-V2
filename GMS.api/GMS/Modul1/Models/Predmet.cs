using System.ComponentModel.DataAnnotations;

namespace GMS.Modul1.Models
{
    public class Predmet
    {
        [Key]
        public int ID { get; set; }
        public string Naziv { get; set; }   
        public string Sifra { get; set; }   
        public int Ects { get; set; }

    }
}

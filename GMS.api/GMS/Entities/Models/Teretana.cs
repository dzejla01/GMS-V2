using System.ComponentModel.DataAnnotations;

namespace GMS.Entities.Models
{
    public class Teretana
    {
        [Key]
        public int ID { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
    }
}

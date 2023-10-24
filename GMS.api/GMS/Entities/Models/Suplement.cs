using System.ComponentModel.DataAnnotations.Schema;

namespace GMS.Entities.Models
{
    public class Suplement
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public float Cijena { get; set; }

        [ForeignKey(nameof(Dobavljac))]
        public int DobavljacID { get; set; }
        public Dobavljac Dobavljac { get; set; }

        // public IFormFile Slika { get; set; }
    }
}

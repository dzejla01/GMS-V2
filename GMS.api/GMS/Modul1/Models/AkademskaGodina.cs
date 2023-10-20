using System.ComponentModel.DataAnnotations;

namespace GMS.Modul1.Models
{
    public class AkademskaGodina
    {
        [Key]
        public int ID{ get; set; }
        public string Opis { get; set; }
    }
}

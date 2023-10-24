using GMS.Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GMS.Configuration
{
    public class KorisnikConfiguration : IEntityTypeConfiguration<Korisnik>
    {
        public void Configure(EntityTypeBuilder<Korisnik> builder)
        {
            builder.HasData(
                new Korisnik
                {
                    ID = 1,
                    Ime = "Vedad",
                    Prezime = "Keskin",
                    Username = "vedadke",
                    Password = "bayern123",
                    BrojTelefona = "0644076290",
                    Visina = 170,
                    Tezina = 80,
                    SpolID = 1,
                    GradID = 18,
                    TeretanaID = 2
                },
                new Korisnik
                {
                    ID = 2,
                    Ime = "Džejla",
                    Prezime = "Palalić",
                    Username = "dzejlap",
                    Password = "fit2023",
                    BrojTelefona = "062709689",
                    Visina = 164,
                    Tezina = 57,
                    SpolID = 2,
                    GradID = 26,
                    TeretanaID = 2
                });
                
        }
    }
}

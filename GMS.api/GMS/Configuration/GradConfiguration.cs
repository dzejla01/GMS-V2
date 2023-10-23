using GMS.Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GMS.Configuration
{
    public class GradConfiguration : IEntityTypeConfiguration<Grad>
    {
        public void Configure(EntityTypeBuilder<Grad> builder)
        {
            builder.HasData(
                new Grad
                {
                    ID = 1,
                    Naziv = "Mostar",
                },
                new Grad
                {
                    ID = 2,
                    Naziv = "Sarajevo",
                },
                new Grad
                {
                    ID = 3,
                    Naziv = "Zenica",
                },
                new Grad
                {
                    ID = 4,
                    Naziv = "Livno",
                },
                new Grad
                {
                    ID = 5,
                    Naziv = "Tuzla",
                },
                new Grad
                {
                    ID = 6,
                    Naziv = "Bihać",
                },
                new Grad
                {
                    ID = 7,
                    Naziv = "Banja Luka",
                },
                new Grad
                {
                    ID = 8,
                    Naziv = "Zavidovići",
                },
                new Grad
                {
                    ID = 9,
                    Naziv = "Maglaj",
                },
                new Grad
                {
                    ID = 10,
                    Naziv = "Jajce",
                },
                new Grad
                {
                    ID = 11,
                    Naziv = "Travnik",
                },
                new Grad
                {
                    ID = 12,
                    Naziv = "Zvornik",
                },
                new Grad
                {
                    ID = 13,
                    Naziv = "Doboj",
                },
                new Grad
                {
                    ID = 14,
                    Naziv = "Višegrad",
                },
                new Grad
                {
                    ID = 15,
                    Naziv = "Podgorica",
                },
                new Grad
                {
                    ID = 16,
                    Naziv = "Konjic",
                },
                new Grad
                {
                    ID = 17,
                    Naziv = "Bijelo Polje",
                },
                new Grad
                {
                    ID = 18,
                    Naziv = "Zvornik",
                },
                new Grad
                {
                    ID = 19,
                    Naziv = "Stolac",
                },
                new Grad
                {
                    ID = 20,
                    Naziv = "Novi Sad",
                },
                new Grad
                {
                    ID = 21,
                    Naziv = "Sjenica",
                },
                new Grad
                {
                    ID = 22,
                    Naziv = "Novi Pazar",
                },
                new Grad
                {
                    ID = 23,
                    Naziv = "Prijepolje",
                },
                new Grad
                {
                    ID = 24,
                    Naziv = "Skoplje",
                },
                new Grad
                {
                    ID = 25,
                    Naziv = "Ljubljana",
                },
                new Grad
                {
                    ID = 26,
                    Naziv = "Maribor",
                },
                new Grad
                {
                    ID = 27,
                    Naziv = "Zagreb",
                },
                new Grad
                {
                    ID = 28,
                    Naziv = "Rijeka",
                },
                new Grad
                {
                    ID = 29,
                    Naziv = "Split",
                },
                new Grad
                {
                    ID = 30,
                    Naziv = "Sofija",
                },
                new Grad
                {
                    ID = 31,
                    Naziv = "Ankara",
                },
                new Grad
                {
                    ID = 32,
                    Naziv = "Istanbul",
                });
        }
    }
}

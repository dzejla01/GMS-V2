using GMS.Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GMS.Configuration
{
    public class Korisnik_ClanarinaConfiguration : IEntityTypeConfiguration<Korisnik_Clanarina>
    {
        public void Configure(EntityTypeBuilder<Korisnik_Clanarina> builder)
        {
            builder.HasData(
                new Korisnik_Clanarina
                {
                    KorisnikID = 1,
                    ClanarinaID = 2,
                    DatumUplate = new DateTime(2023, 09, 01, 9, 15, 0),
                    DatumIsteka = new DateTime(2023, 10, 01, 9, 15, 0)
                },
                new Korisnik_Clanarina
                {
                    KorisnikID = 2,
                    ClanarinaID = 2,
                    DatumUplate = new DateTime(2023, 09, 01, 9, 15, 0),
                    DatumIsteka = new DateTime(2023, 10, 01, 9, 15, 0)
                },
                new Korisnik_Clanarina
                {
                    KorisnikID = 1,
                    ClanarinaID = 2,
                    DatumUplate = new DateTime(2023, 10, 01, 7, 15, 0),
                    DatumIsteka = new DateTime(2023, 11, 01, 7, 15, 0)
                },
                new Korisnik_Clanarina
                {
                    KorisnikID = 2,
                    ClanarinaID = 2,
                    DatumUplate = new DateTime(2023, 10, 01, 7, 15, 0),
                    DatumIsteka = new DateTime(2023, 11, 01, 7, 15, 0)
                });
        }
    }
}

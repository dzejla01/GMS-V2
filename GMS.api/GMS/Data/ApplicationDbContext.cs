using GMS.Entities.Models;
using GMS.Modul0_Autentifikacija.Models;
using GMS.Modul1.Models;
using Microsoft.EntityFrameworkCore;

namespace GMS.Data
{
    public class ApplicationDbContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Korisnik_Clanarina>().HasKey(x => new { x.ClanarinaID, x.KorisnikID, x.DatumUplate });

          
        }
        public DbSet<Drzava> Drzava { get; set; }
        public DbSet<Predmet> Predmet { get; set; }
        public DbSet<Opstina> Opstina { get; set; }
        public DbSet<Student> Student { get; set; }

        public DbSet<AutentifikacijaToken> AutentifikacijaToken { get; set; }
        public DbSet<Nastavnik> Nastavnik { get; set; }
        public DbSet<KorisnickiNalog> KorisnickiNalog { get; set; }
        public DbSet<Obavijest> Obavijest { get; set; }
        public DbSet<AkademskaGodina> AkademskaGodina { get; set; }
        public DbSet<Grad> Grad { get; set; }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<Korisnik_Clanarina> Korisnik_Clanarina { get; set; }
        public DbSet<Clanarina> Clanarina { get; set; }


        public ApplicationDbContext(
            DbContextOptions options) : base(options)
        {
        }
    }
}

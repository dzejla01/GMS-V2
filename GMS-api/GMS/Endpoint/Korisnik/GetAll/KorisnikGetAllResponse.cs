namespace GMS.Endpoint.Drzava.Search
{
    public class KorisnikGetAllResponse
    {
        public List<KorisnikGetAllResponseRow> Korisnici { get; set; }
    }

    public class KorisnikGetAllResponseRow // samo se radi kada je rezultat lista a ne jedan zapis 
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string TeretanaNaziv { get; set; }
        public string GradNaziv { get; set; }
        public string SpolNaziv { get; set; }
        public float Tezina { get; set; }
        public float Visina { get; set; }
    }

}

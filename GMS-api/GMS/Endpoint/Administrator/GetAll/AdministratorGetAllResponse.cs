using GMS.Endpoint.Recenzije.GetAll;

namespace GMS.Endpoint.Administrator.GetAll
{
    public class AdministratorGetAllResponse
    {
        public List<AdministratorGetAllResponseRow> Administrator { get; set; }
        public List<RecenzijeGetAllResponseRow> Recenzije { get; internal set; }
    }

    public class AdministratorGetAllResponseRow // samo se radi kada je rezultat lista a ne jedan zapis 
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}

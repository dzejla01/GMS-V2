﻿namespace GMS.Endpoint.Suplement.GetAll
{
    public class SuplementGetAllResponse
    {
        public List<SuplementGetAllResponseRow> Suplementi { get; set; }
    }
<<<<<<< HEAD


    public class SuplementGetAllResponseRow // samo se radi kada je rezultat lista a ne jedan zapis 
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public float Cijena { get; set; }
        public float Gramaža { get; set; }
        public string Opis { get; set; }
        public string NazivDobavljaca { get; set; }
        public string NazivKategorija { get; set; }
    }
}
=======
        

        public class SuplementGetAllResponseRow // samo se radi kada je rezultat lista a ne jedan zapis 
        {
            public int ID { get; set; }
            public string Naziv { get; set; }
            public float Cijena { get; set; }
            public float Gramaža { get; set; }
            public string Opis { get; set; }
            public string NazivDobavljaca { get; set; }
            public string NazivKategorija { get; set; }
        }
 }

>>>>>>> 15dfdf123f81952173c277a0cb9ffa83f79011bf

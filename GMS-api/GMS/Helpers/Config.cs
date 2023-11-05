namespace GMS.Helpers
{
    public class Config
    {
        public static string AplikacijURL = "https://restapiexample.wrd.app.fit.ba/"; // zasad
        public static string Slike => "img/";

        public static string Slike2 => "profile_images/";
        public static string SlikeURL => AplikacijURL + Slike2;

        public static string SlikeFolder => "wwwroot/" + Slike;

        //  SlikaKorisnika = Config.SlikeURL + "empty.png"  za sliku je on pohranjivao 
    }
}

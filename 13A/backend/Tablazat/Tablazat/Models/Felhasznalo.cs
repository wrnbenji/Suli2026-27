namespace Tablazat.Models
{
    public class Felhasznalo
    {
        public string nev { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public static List<Felhasznalo> felhasznalo { get; set; } = new();
        public Felhasznalo(string nev, string email, string password)
        {
            this.nev = nev;
            this.email = email;
            this.password = password;
        }
    }
}

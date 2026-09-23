using System.ComponentModel.DataAnnotations;

namespace RegistracioGyakorlas.Modles
{
    public class Adat
    {
        public static List<Adat> adatok = new List<Adat>();
        [Required (ErrorMessage ="Kötelező kitölteni") ]
        public string Nev { get; set; }
        [Required(ErrorMessage = "Kötelező kitölteni")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Kötelező kitölteni")]
        public DateOnly SzuletesiDatum { get; set; }
        public bool Diak { get; set; }
        [Range(30,50, ErrorMessage ="30 és 50 között legyen a tappancsméret"), Required(ErrorMessage = "Kötelező kitölteni")]
        public int CipoMeret { get; set; }
        [Required(ErrorMessage = "Kötelező kitölteni")]
        public int Sorszam { get; set; }

        public Adat()
        {
            Sorszam = adatok.Count;
           
        }



    }
}

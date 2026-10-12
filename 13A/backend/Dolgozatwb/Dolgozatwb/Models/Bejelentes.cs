namespace Dolgozatwb.Models
{
    public class Bejelentes
    {
        public int Id { get; set; }
        public string BejelentoNeve { get; set; }
        public string Email { get; set; }
        public string EszkozTipus { get; set; }
        public string HibaLeiras { get; set; }
        public bool Surgos { get; set; }
        public DateTime BejelentesDatuma { get; set; }

        public Bejelentes()
        {
            BejelentesDatuma = DateTime.Now;
        }

       


    }
}

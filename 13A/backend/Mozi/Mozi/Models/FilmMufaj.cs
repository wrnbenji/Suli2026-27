namespace Mozi.Models
{
    public class FilmMufaj
    {
        public int FilmId { get; set; }
        public Film Film { get; set; }
        public int MufajId { get; set; }
        public Mufaj Mufaj { get; set; }
    }
}

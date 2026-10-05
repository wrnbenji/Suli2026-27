using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Mozi.Models
{
    public class Film
    {
        [Key]
        public int Id { get; set; }
        public string Cim { get; set; }
        public int Hossz { get; set; }
        public byte Korhatar { get; set; }
        public int KiadasiEv { get; set; }

       public Mufaj Mufaj { get; set; }
        public Kiado Kiado { get; set; }
        public ICollection<Mufaj> Mufajok { get; set; }
    }
}

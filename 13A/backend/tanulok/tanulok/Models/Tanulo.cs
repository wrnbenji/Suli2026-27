using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tanulok.Models
{
    [Table("Students")]
    public class Tanulo
    {
     
        [Key, Required(ErrorMessage = "Kötelező kitölteni")]
        public int azon { get; set; }

        [Required]
        public string nev { get; set; }
        [Required(ErrorMessage = "Kötelező kitölteni")]
        public string Osztaly { get; set; }
        [Column("KitunoTanulo")]
        public bool kituno { get; set; }
        [Required(ErrorMessage = "Kötelező kitölteni")]
        public string? elozoIskola { get; set; }
    }
}

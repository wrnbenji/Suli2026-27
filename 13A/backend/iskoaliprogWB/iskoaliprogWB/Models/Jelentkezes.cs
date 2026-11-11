using System.ComponentModel.DataAnnotations;

namespace iskoaliprogWB.Models
{
    public class Jelentkezes
    {
        [Key]
        public int id { get; set; }

        [Required, MinLength(3)]
        public string TanuloNeve { get; set; }
        [Required]
        public string Osztaly { get; set; }
        [Required]
        public string Email { get; set; }
       [Required, AllowedValues("Robotika szakkör bemutatója", "Pályaorientációs nap", "Iskolai sportnap", "Múzeumlátogatás", "Tavaszi kirándulás")]
        public string ProgramTipusa { get; set; }
        
        public int ResztvevokSzama { get; set; }

        public string? Megjegyzes { get; set; }
        public DateTime JelentkezesIdeje { get; set; }
        public Jelentkezes()
        {
            JelentkezesIdeje = DateTime.Now;
        }
    }
}

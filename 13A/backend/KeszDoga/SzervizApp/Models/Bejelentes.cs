using System.ComponentModel.DataAnnotations;

namespace SzervizApp.Models
{
    public class Bejelentes
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A bejelentő neve kötelező.")]
        [MinLength(3, ErrorMessage = "A névnek legalább 3 karakterből kell állnia.")]
        public string BejelentoNeve { get; set; } = "";

        [Required(ErrorMessage = "Az e-mail-cím kötelező.")]
        [EmailAddress(ErrorMessage = "Nem megfelelő e-mail-formátum.")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Válassz eszköztípust!")]
        [AllowedValues("Laptop", "Asztali számítógép", "Monitor", "Nyomtató", "Egyéb",
            ErrorMessage = "Érvénytelen eszköztípus.")]
        public string EszkozTipus { get; set; } = "";

        [Required(ErrorMessage = "A hiba leírása kötelező.")]
        [MinLength(10, ErrorMessage = "A hiba leírásának legalább 10 karakterből kell állnia.")]
        public string HibaLeiras { get; set; } = "";

        public bool Surgos { get; set; }

        // Nem az űrlapról jön, mentéskor a szerver állítja be
        public DateTime BejelentesDatuma { get; set; }
    }
}

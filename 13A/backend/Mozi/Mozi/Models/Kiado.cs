using System.ComponentModel.DataAnnotations;

namespace Mozi.Models
{
    public class Kiado
    {
        [Key]
        public int Id { get; set; }

        public string KiadoNev { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Mozi.Models
{
    public class Mufaj
    {
        [Key]
        public int Id { get; set; }
        public string MufajNev { get; set; }
    }
}

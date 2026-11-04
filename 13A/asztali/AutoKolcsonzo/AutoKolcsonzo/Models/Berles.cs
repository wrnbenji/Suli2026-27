using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKolcsonzoLibrary.Models
{
    public class Berles
    {
        public int Id { get; set; }
        public int AutoId { get; set; }
        public Auto Auto { get; set; }
        public int UgyfelId { get; set; }
        public Ugyfel Ugyfel { get; set; }
        public DateOnly Kezdete { get; set; }
        public DateOnly Hatarido { get; set; }
        public DateOnly? Visszahozva { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvtarLibrary.Models
{
    [Table("Szerzok")]
    public class Szerzo
    {
        public int Id { get; set; }
        public string Nev { get; set; } = "";

    }
}

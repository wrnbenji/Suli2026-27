using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvtarLibrary.Models
{
    [Table("Konyvek")]
    public class Konyv
    {
        public int Id { get; set; }
        public string Cim { get; set; } = "";
        public int SzerzoId { get; set; }
        public int KategoriaId { get; set; }
        public int KiadasEve { get; set; }
    }
}

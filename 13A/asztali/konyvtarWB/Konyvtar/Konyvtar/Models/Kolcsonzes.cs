using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvtarLibrary.Models
{
    [Table("Kolcsonzesek")]
    public class Kolcsonzes
    {
        public int Id { get; set; }
        public int KonyvId { get; set; }
        public int OlvasoId { get; set; }
        public DateOnly Kezdete { get; set; }
        public DateOnly Hatarido { get; set; }
        public DateOnly? Visszahozva { get; set; }
    }
}

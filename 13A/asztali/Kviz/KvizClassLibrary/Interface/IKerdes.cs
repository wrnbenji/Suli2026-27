using System.ComponentModel.DataAnnotations.Schema;

namespace Kviz.Interface;

public interface IKerdes
{
    [Column("temakor")]
    public string Temakor { get; set; }
    
}
using System.ComponentModel.DataAnnotations.Schema;
using Kviz.Interface;

namespace Kviz;

[Table("igaz_hamis_kerdesek")]
public class IgazHamisKerdes : Kerdes, IKerdes
{ 
    public List<IgazHamisKerdes> IgazHamisKerdesek = new List<IgazHamisKerdes>();
    [Column("helyes_valasz")]
    public bool HelyesValasz { get; set; }
    
    

    public override byte Ellenorzes(object v)
    {
        bool ih;
        if (v?.ToString()?.Trim().ToUpper() == "I")
            ih = true;
        else
        {
            ih = false;
        }
        
        if (ih == (bool)HelyesValasz)
        {
            
            return Pontszam;
        }

        return 0;
    }

    public string Temakor { get; set; }
}
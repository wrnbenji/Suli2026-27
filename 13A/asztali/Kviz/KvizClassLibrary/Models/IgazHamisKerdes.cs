using System.ComponentModel.DataAnnotations.Schema;
using Kviz.Interface;

namespace Kviz;

[Table("igaz_hamis_kerdesek")]
public class IgazHamisKerdes : Kerdes, IKerdes
{ 
    public List<IgazHamisKerdes> IgazHamisKerdesek = new List<IgazHamisKerdes>();
    public bool HelyesValasz { get; set; }
    
    

    protected override byte Ellenorzes(object v)
    {
        if ((bool)v == HelyesValasz)
        {
            
            return Pontszam;
        }

        return 0;
    }

    public string Temakor { get; set; }
}
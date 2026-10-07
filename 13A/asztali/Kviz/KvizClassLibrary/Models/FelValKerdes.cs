using System.ComponentModel.DataAnnotations.Schema;
using Kviz.Interface;

namespace Kviz;

[Table("feleletvalasztos_kerdesek")]
public class FelValKerdes : Kerdes, IKerdes
{
    public List<FelValKerdes> FelValKerdesek = new List<FelValKerdes>();
    public List<string> ValaszLehetosegek { get; set; } = new List<string>();

    [Column("valasz_1")]
    public string Valasz1 { get; set; }
    [Column( "valasz_2")]
    public string Valasz2 { get; set; }
    [Column( "valasz_3")]
    public string Valasz3 { get; set; }
    
    [Column( "valasz_4")]
    public string Valasz4 { get; set; }
    
    public string Temakor { get; set; }
    
    [Column("helyes_valasz_index")]
    public int HelyesValaszIndex { get; set; }

    public FelValKerdes()
    {
        ValaszLehetosegek.Add(Valasz1);
        ValaszLehetosegek.Add(Valasz2);
        ValaszLehetosegek.Add(Valasz3);
        ValaszLehetosegek.Add(Valasz4);
        
        
       
        
       
    }

    protected override byte Ellenorzes(object v)
    {
        if ((int)v == HelyesValaszIndex)
        {
            
            return Pontszam;
        }
      
        return 0;
    }
    
}
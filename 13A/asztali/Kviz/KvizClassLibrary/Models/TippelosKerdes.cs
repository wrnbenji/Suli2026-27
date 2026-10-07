using System.ComponentModel.DataAnnotations.Schema;
using Kviz.Interface;

namespace Kviz;
[Table("tippelos_kerdesek")]
public class TippelosKerdes : Kerdes, IKerdes
{
    public List<TippelosKerdes> TippelosKerdesek = new List<TippelosKerdes>();
    [Column("helyes_valasz")]
    public double HelyesValasz { get; set; }
    
    [Column("tolerancia_szazalek")]
    public byte SzazalekElteres { get; set; }
    
    public string Temakor { get; set; }
    
    protected override byte Ellenorzes(object v)
    {
        double tipp = (double)v;
        double maxElteres = Math.Abs(HelyesValasz) * SzazalekElteres / 100;

        if (Math.Abs(tipp - HelyesValasz) <= maxElteres)
        {
            
            return Pontszam;
        }
       
        return 0;
    }
    
}
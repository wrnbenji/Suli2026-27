using System.ComponentModel.DataAnnotations.Schema;
using Kviz.Interface;

namespace Kviz;
[Table("tippelos_kerdesek")]
public class TippelosKerdes : Kerdes, IKerdes
{
    public List<TippelosKerdes> TippelosKerdesek = new List<TippelosKerdes>();
    [Column("helyes_valasz")]
    public decimal HelyesValasz { get; set; }
    
    [Column("tolerancia_szazalek")]
    public decimal SzazalekElteres { get; set; }
    
    public string Temakor { get; set; }
    
    public override byte Ellenorzes(object v)
    {
        decimal tipp = decimal.Parse(v.ToString().Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture);
        decimal maxElteres = Math.Abs(HelyesValasz) * SzazalekElteres / 100;

        if (Math.Abs(tipp - HelyesValasz) <= maxElteres)
        {
            
            return Pontszam;
        }
       
        return 0;
    }
    
}
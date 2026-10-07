using System.ComponentModel.DataAnnotations.Schema;

namespace Kviz;

public abstract class Kerdes
{
    [Column("id")]
    public int id { get; set; }
    
    [Column("kerdes")]
    public string KerdesSzoveg { get; set; } 
    
    [Column("pontszam")]
    public byte Pontszam { get; set; }
    
    
    
    abstract protected byte Ellenorzes(object v);
    }
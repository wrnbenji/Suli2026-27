using KonyvtarLibrary.Models;

namespace KonyvtarLibrary.Services;


public interface IKonyvtarService
{
    List<Konyv> Konyvek();
    List<Konyv> ElerhetoKonyvek();
    List<Olvaso> Olvasok();
    bool UjOlvaso(string nev, string email);

    //ÁTÍRHATÓ: könyv és olvasó objektumokra
    bool UjKolcsonzes(int konyvId, int olvasoId, DateOnly kezdet);

    bool Visszahozatal(int kolcsonzesId, DateOnly datum);
    List<Kolcsonzes> AktivKolcsonzesek();
    List<Kolcsonzes> Kesesek(DateOnly datum);

    //Minden (visszahozott és kint lévők összesen)
    Dictionary<string,  int > OlvasoStatisztika();

    //BŐVÍTHETŐ...


}

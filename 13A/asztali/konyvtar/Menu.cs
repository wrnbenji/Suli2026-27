


public class Menu
{
 
   //a könyvtár service használata...

    public void Futtatas()
    {
        string? valasztas;
        do
        {
            Console.Clear();
            Console.WriteLine("========== KÖNYVTÁR ==========");
            Console.WriteLine("1. Könyvek listázása");
            Console.WriteLine("2. Elérhető könyvek");
            Console.WriteLine("3. Olvasók listázása");
            Console.WriteLine("4. Új olvasó rögzítése");
            Console.WriteLine("5. Kölcsönzés rögzítése");
            Console.WriteLine("6. Könyv visszahozatala");
            Console.WriteLine("7. Aktív kölcsönzések");
            Console.WriteLine("8. Késedelmes kölcsönzések");
            Console.WriteLine("9. Olvasói statisztika");
            Console.WriteLine("0. Kilépés");
            Console.Write("Választás: ");
            valasztas = Console.ReadLine();
            Console.Clear();

            switch (valasztas)
            {
                case "1": Konyvek(); break;
                case "2": ElerhetoKonyvek(); break;
                case "3": Olvasok(); break;
                case "4": UjOlvaso(); break;
                case "5": UjKolcsonzes(); break;
                case "6": Visszahozatal(); break;
                case "7": AktivKolcsonzesek(); break;
                case "8": Kesesek(); break;
                case "9": Statisztika(); break;
                case "0": break;
                default: Console.WriteLine("Érvénytelen menüpont!"); break;
            }
            if (valasztas != "0")
            {
                Console.WriteLine("\nEnter a folytatáshoz...");
                Console.ReadLine();
            }
        } while (valasztas != "0");
    }


    private void Konyvek()
    {
        // A könyvek listája minden alapadatával
       

    }

    private void ElerhetoKonyvek()
    {
	        

    }

    private void Olvasok()
    {
        
	//A könyvtár olvasóinak listája, jelölve az aktív és inaktív olvasókat

    }

    private void UjOlvaso()
    {
        Console.Write("Olvasó neve: ");
        string nev = Console.ReadLine();
        Console.Write("E-mail címe: ");
        string email = Console.ReadLine();
        
	//Új olvasó rögzítése (ha lehetséges)


    }

    private void UjKolcsonzes()
    {

	//Kölcsönözhető könyvek listája
	int konyvId = EgeszSzam("Könyv azonosítója: ");

	//olvasók listája
        int olvasoId = EgeszSzam("Olvasó azonosítója: ");

	//kezdet: az aktuális dátum
        
	//kölcsönzés rögzítése

    }

    private void Visszahozatal()
    {

	//aktív kölcsönzések listája
        int id = EgeszSzam("Kölcsönzés azonosítója: ");
        
	//visszahozatal az aktuális dátum

	//a kölcsönzés "lezárása"
    }

    private void AktivKolcsonzesek()
    {
        //kölcsönzések adatai, határidővel
    }

    private void Kesesek()
    {
        
	//kölcsönzések, amik a határidőn túl vannak (a mai naphoz viszonyítva)
    }

    private void Statisztika()
    {
        
	//az olvasóink, hány könyvet kölcsönöztek eddig

    }

    

    //HA SZÜKSÉGÉT ÉRZED, AKKOR HASZNÁLD....
    private static DateOnly Datum(string szoveg)
    {
        while (true)
        {
            Console.Write(szoveg);
            if (DateOnly.TryParseExact(Console.ReadLine(), "yyyy-MM-dd",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out var datum))
                return datum;
            Console.WriteLine("Hibás dátum!");
        }
    }
}

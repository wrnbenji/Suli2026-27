using Konyvtar.ConsoleApp;
using Konyvtar.Services;


using var db = new KonyvtarDbContext();
IKonyvtarService service = new KonyvtarService(db);
new Menu(service).Futtatas();

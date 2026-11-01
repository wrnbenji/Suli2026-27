# Szervizbejelentő – javított megoldás

A `Dolgozatwb` dolgozat helyes megoldása (ASP.NET Core Razor Pages + EF Core + MySQL).

## Indítás

1. Indítsd el a MySQL-t (XAMPP), a connection string az `appsettings.json`-ban van (`root` / `root`).
2. Visual Studióban: **Tools → NuGet Package Manager → Package Manager Console**, majd:
   ```
   Add-Migration Init
   Update-Database
   ```
   (vagy terminálból: `dotnet ef migrations add Init` és `dotnet ef database update`)
3. Futtasd a projektet, az űrlap a `/Bejelentes`, a lista a `/Bejelentesek` címen van.

## Mi változott a dolgozathoz képest

- `_ViewImports.cshtml` hozzáadva, így működnek a tag helperek (`asp-for`, `asp-validation-for`).
- Validáció: `[Required]`, `[MinLength]`, `[EmailAddress]`, `[AllowedValues]` + `ModelState.IsValid`.
- `OnPost` → `IActionResult`, sikeres mentés után `RedirectToPage("/Bejelentesek")`.
- A dátumot az `OnPost` állítja be mentéskor (nem a konstruktor).
- Hibaleírás `<textarea>`, a legördülő listában `-- Válassz! --` üres opció.
- Lista: inicializált lista, `OrderByDescending`, `<tr>` a cikluson belül, „Nincs megjeleníthető bejelentés.” üzenet.
- Connection string az `appsettings.json`-ban, DbContext konstruktoros `DbContextOptions`-szel.

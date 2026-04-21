# AcrylShop - Semestralni .NET projekt

Ovaj repo sadrži gotovu osnovu profesionalnog web shopa za prodaju akrilnih boja, izrađenu fokusirano na .NET tehnologije:

- **ASP.NET Core MVC** (frontend + server-side rendering)
- **ASP.NET Core Identity** (login/registracija)
- **Web API** (`/api/products`)
- **Blazor Server komponenta** unutar MVC početne stranice
- Dodatni kosturi projekata za **MAUI**, **WPF** i **Web Forms**

## Početna datoteka projekta
Glavna ulazna datoteka za cijeli projekt je **`AcrylShop.sln`** (otvori nju u Visual Studio-u) jer povezuje web, WPF, MAUI i Web Forms projekte na jednom mjestu.

## Pokretanje web aplikacije
1. Instaliraj .NET 8 SDK.
2. Uđi u `src/AcrylShop.Web`.
3. Pokreni:
   ```bash
   dotnet restore
   dotnet run
   ```
4. Otvori URL koji ispiše konzola.

## WPF build (Desktop)
Ako dobiješ grešku tipa `project.assets.json not found`, pokreni restore prije builda:

```bash
cd src/AcrylShop.Desktop.Wpf
dotnet restore
dotnet build
```
## Ključne funkcionalnosti
- Početna stranica s akcijama i najprodavanijim proizvodima.
- Stranica svih proizvoda s filtriranjem (vrsta, pretraga) i sortiranjem (cijena, vrsta).
- Login i registracija korisnika.
- REST API za dohvat proizvoda.

## Napomena za MAUI/WPF/WebForms
U ovom repozitoriju su uključeni početni projekti (`src/AcrylShop.Mobile.Maui`, `src/AcrylShop.Desktop.Wpf`, `src/AcrylShop.WebForms`) kao osnova za proširenje istog domenskog modela i API integracije.

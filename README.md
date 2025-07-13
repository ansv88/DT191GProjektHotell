# Dalsjöns Gårdshotell

En webbapplikation för hotellbokning utvecklad som projekt för kursen DT191G vid Mittuniversitetet.
Projektet är byggt med Blazor Web App (Server) i .NET 9 och riktar sig till både hotellgäster och administratörer.

## Om projektet

Webbapplikationen digitaliserar och förenklar bokningsprocessen på det fiktiva Dalsjöns Gårdshotell. Gäster kan boka rum, läsa om aktiviteter och restaurangen, lämna recensioner och kontakta hotellet.
Administratörer får ett inloggat gränssnitt för att hantera bokningar, rum, gäster och kontaktmeddelanden.

## Funktioner

### För gäster
- Boka rum online med tillgänglighetskontroll
- Läs om aktiviteter och restaurangen
- Lämna och läs recensioner
- Kontakta hotellet via formulär

### För administratörer
- Hantera bokningar (skapa, ändra, ta bort)
- Administrera rum (kapacitet, status, priser)
- Hantera gäster och kontaktmeddelanden
- Statistikpanel med realtidsöversikt

## Teknisk översikt

- **Frontend**: Blazor Server Components (.NET 9)
- **Backend**: ASP.NET Core 9.0
- **Databas**: SQL Server med Entity Framework Core
- **Autentisering**: ASP.NET Core Identity
- **Design**: Bootstrap 5 + Google Fonts + Font Awesome + Logo.com
- **Bilder**: Bilder från pixabay.com

## Installation och setup

### Förutsättningar
- .NET 9 SDK
- SQL Server (LocalDB)
- Visual Studio 2022 eller VS Code

### Kom igång
1. **Klona projektet**
   - git clone [repository-url]
   - cd DT191GProjektHotell

2. **Konfigurera databas**
   - Uppdatera connection string i `appsettings.json`
   - Kör: dotnet ef database update

3. **Konfigurera admin-konto**
   - Lägg till admin-uppgifter i `appsettings.json`: { "AdminAccount": { "Email": "admin@example.com", "Password": "AdminPassword123!" } }

4. **Starta applikationen**
   - dotnet run

## Användning

- **Gäster**: Utforska hotellet, boka rum, lämna recension och skicka meddelanden.

- **Admin**: Logga in via adminpanelen och hantera bokningar, rum, gäster och kontaktmeddelanden.

## Förslag på vidareutveckling

- Prisvisning i bokningsflödet
- Automatiska e-postbekräftelser
- Bättre pakethantering
- Onlinebetalning
- Mobilapp

---
## Författare

Det här projektet är utvecklat av [Annelie Svensson] som en del av kursen DT191G Webbutveckling med .NET vid Mittuniversitetet.
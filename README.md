# Dalsj�ns G�rdshotell

En webbapplikation f�r hotellbokning utvecklad som projekt f�r kursen DT191G vid Mittuniversitetet.
Projektet �r byggt med Blazor Web App (Server) i .NET 9 och riktar sig till b�de hotellg�ster och administrat�rer.

## Om projektet

Webbapplikationen digitaliserar och f�renklar bokningsprocessen p� det fiktiva Dalsj�ns G�rdshotell. G�ster kan boka rum, l�sa om aktiviteter och restaurangen, l�mna recensioner och kontakta hotellet.
Administrat�rer f�r ett inloggat gr�nssnitt f�r att hantera bokningar, rum, g�ster och kontaktmeddelanden.

## Funktioner

### F�r g�ster
- Boka rum online med tillg�nglighetskontroll
- L�s om aktiviteter och restaurangen
- L�mna och l�s recensioner
- Kontakta hotellet via formul�r

### F�r administrat�rer
- Hantera bokningar (skapa, �ndra, ta bort)
- Administrera rum (kapacitet, status, priser)
- Hantera g�ster och kontaktmeddelanden
- Statistikpanel med realtids�versikt

## Teknisk �versikt

- **Frontend**: Blazor Server Components (.NET 9)
- **Backend**: ASP.NET Core 9.0
- **Databas**: SQL Server med Entity Framework Core
- **Autentisering**: ASP.NET Core Identity
- **Design**: Bootstrap 5 + Google Fonts + Font Awesome + Logo.com
- **Bilder**: Bilder fr�n pixabay.com

## Installation och setup

### F�ruts�ttningar
- .NET 9 SDK
- SQL Server (LocalDB)
- Visual Studio 2022 eller VS Code

### Kom ig�ng
1. **Klona projektet**
   - git clone [repository-url]
   - cd DT191GProjektHotell

2. **Konfigurera databas**
   - Uppdatera connection string i `appsettings.json`
   - K�r: dotnet ef database update

3. **Konfigurera admin-konto**
   - L�gg till admin-uppgifter i `appsettings.json`: { "AdminAccount": { "Email": "admin@example.com", "Password": "AdminPassword123!" } }

4. **Starta applikationen**
   - dotnet run

## Anv�ndning

- **G�ster**: Utforska hotellet, boka rum, l�mna recension och skicka meddelanden.

- **Admin**: Logga in via adminpanelen och hantera bokningar, rum, g�ster och kontaktmeddelanden.

## F�rslag p� vidareutveckling

- Prisvisning i bokningsfl�det
- Automatiska e-postbekr�ftelser
- B�ttre pakethantering
- Onlinebetalning
- Mobilapp

---
## F�rfattare

Det h�r projektet �r utvecklat av [Annelie Svensson] som en del av kursen DT191G Webbutveckling med .NET vid Mittuniversitetet.
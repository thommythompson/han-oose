[Terug](/README.md)

# How to get started?

## Tooling
Tooling die gebruikt word binnen het team.
- Visual Studio Code (met meraid extension): voor het opstellen van de markdown documentatie.
- Azure Data Studio: voor database beheer.
- Rider: Als IDE.
- Fork: als visuele git client.

## Database
De applicatie heeft een database nodig, deze kan je starten via docker, dit vereist wel dat je Docker desktop geinstalleerd hebt. Onderstaande het commando voor het starten van deze SQL container.
```bash

```

Mocht je al een lokale database hebben draaien dan kan je deze natuurlijk ook gebruiken, zorg dat je de connection string aanpast in onderstaande appsettings template.

## Appsettings 
Gebruik onderstaande appsettings om je `appsettings.development.json` te vullen bij het beginnen van ontwikkeling. Deze file dient niet binnen git gecommit te worden, dit omdat iedereen andere development waardes kan hebben en deze anders steeds overschreven worden door commits van anderen.
```json
{
    ...
}
```
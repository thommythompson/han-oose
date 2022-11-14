[Terug](/README.md)

# How to get started?

## Tooling
Tooling die gebruikt word binnen het team.
- Visual Studio Code: voor het opstellen van de markdown documentatie.
    - Required extensions: `.vscode/extensions.json`
    - Settings: `.vscode/settings.json`
- Azure Data Studio: voor database beheer.
- Rider: Als IDE.
- Fork: als visuele git client.


```bash
# to run plantuml server locally:
docker run -d -p 8888:8080 plantuml/plantuml-server
```

## Database
De applicatie heeft een database nodig, deze kan je starten via docker, dit vereist wel dat je Docker desktop geinstalleerd hebt. Onderstaande het commando voor het starten van deze SQL container.
```bash
docker run --cap-add SYS_PTRACE -e 'ACCEPT_EULA=1' -e 'MSSQL_SA_PASSWORD=P@ssw0rd' -p 1433:1433 --name azuresqledge -d mcr.microsoft.com/azure-sql-edge -v icde-db:/var/opt/mssql
```

Mocht je al een lokale database hebben draaien dan kan je deze natuurlijk ook gebruiken, zorg dat je de connection string aanpast in onderstaande appsettings template.

## Appsettings 
Gebruik onderstaande appsettings om je `appsettings.development.json` te vullen bij het beginnen van ontwikkeling. Deze file dient niet binnen git gecommit te worden, dit omdat iedereen andere development waardes kan hebben en deze anders steeds overschreven worden door commits van anderen.
```json
{
    ...
}
```
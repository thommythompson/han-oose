## Inhoudsopgave
- [De werkwijze]()
- [Requirement Gathering (Ookwel bekend als vragen document)]()
- [Requirements Specification]()
- [Functioneel Ontwerp]()
- [Technisch Ontwerp]()

## Project structure
Domain-centric architecture: Clean Architecture

```
.
├── HICT.ICDETool.Application --> Application > Stuurt het domein aan
|   ├── Interfaces
|       ├── Repositiries > Interfaces voor persisitentie
|       ├── Services > Interfaces voor andere infrastructurele benodigdheden
├── HICT.ICDETool.SharedKernel --> Shared kernel > gebruikt in meerdere projecten, zoals value objects
├── HICT.ICDETool.Domain --> Domain logic > Domein werkt op zichzelf, en beheert eigen consistentie.
├── HICT.ICDETool.Infrastructure --> Implementatie van applicatie interfaces voor persistentie en services (onder andere EF CORE)
├── HICT.ICDETool.Api (entrypoint) --> Presentatie logica only, aanbieden van een rest api en deze aansturen middels swagger 
├── HICT.ICDETool.Tests (entrypoint voor tests)

|── HICT.ICDETool.Web --> (minste prio) Losse MVC app: het aanbieden van een javascript webapp die de swagger api consumeert.
```

## Bespreken:
- Eventueel docs in markdown uitwerken met modellen via mermaid?
    - Voldoet mermaid, zijn er alternatieve; John even raadplegen.
- Kickoff meeting met team over onze app architectuur.

## Priority
1. Eerst de inrichting kant van de domein laag uitwerken
    - Voor iedere methode ook direct de test schrijven in test project
2. De uitwerking kant van de domein laag uitwerken
    - Wederom denk aan de tests
3. Ieders zijn complexe use case uitwerken in applicatie laag.
4. repo interface in applicatie uitwerken
5. repo interface implementeren
    - Dependency naar domain laag: types uit domein laag gebruiken, mapping voorkomen.
    - met in memory data (niet teveel tijd in steken)
    - of met EF CORE?
6. Api zo uitwerken dat je de complexe use cases via de swagger gui kan testen
7. Tijd over, een los web project maken met eigen user interface
    - of plain javascript, ajax, bootstrap
    - of angular met material UI.
8. Heel veel tijd over?
    1. overige crud use cases uitwerken
    2. Authenticatie implementeren via AzureAD

- volgens mij hebben we geen services

## Tech stack/Frameworks
- .NET 6 / C#10

- ORM framwork: EF Core 6
- Presentatie framwork: MVC
- Ardalis https://github.com/ardalis/Specification
- Test Framework:
- Dependency Injection:
- Build management: github actions
- Javascript/Ajax/Jquery

## Hosting environment
- SqlServer
- Docker
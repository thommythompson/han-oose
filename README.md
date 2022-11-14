# ICDE-Tool


## Getting started
Informatie omtrend werkwijze staat vastgelegd in de onderstaande twee documenten. 
1. Allereerst dien je het ["Way of work" document](./docs/wow.md) door te nemen zodat je op de hoogte ben van onze werkwijze.
2. In het ["How to get started?" document](./docs/htgs.md) staat vastgelegd hoe je het project lokaal zo kan inrichten zodat je bezig kan gaan met het ontwikkelen.

## Analyse & Design
- [Requirement Gathering (Ookwel bekend als vragen document)](./docs/invetarisatie/q&a.md)
- [Requirements Specification](./docs/invetarisatie/srs.md)
- [Functioneel Ontwerp](./docs/fo/index.md)
- [Technisch Ontwerp](./docs/to/index.md)

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


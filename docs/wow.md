[Terug](/README.md)

# Way of Work (WoW) Document
Dit document betreft de globale vastlegging van onze werkwijze.

## Belangrijke wijziging in werkwijze!
Documentatie word verplaatst naar github hier dien je je werk te comitten naar een feature branch, het work item moet gekoppeld worden en een pullrequest moet aangemaakt worden, je mag niet je eigen pullrequest goedkeuren.

Voorheen werd er gebruik gemaakt van word documenten en StarUML voor het maken van UML diagrammen, samenwerken verliep via ondedrive, deze bestanden zijn nogsteeds aanwezig, een gedeelte van deze inhoud is 1:1 overgezet naar github.

## Algemene afspraken
- Communicatie momenten.
    - Na afloop van de lessen.
    - Op zondag 10:00.
    - Bij stagneren direct vragen via WhatsApp of Teams.
- Planning staat vastgeled in github projects.
    - Verdeeld in items waar je individueel aan kan werken.
    - Werk moet af op afgesproken deadline.
    - Review vereist.
- We prefereren een iterative werkwijze ten opzichte van een waterfall werkwijze, dat houd in dat wij geen eenmalige documentatie en modulerings effort doen en vervolgens de documentatie links laten liggen. Wij stellen documentatie op die voldoende is om van start te gaan, bij nieuwe inzichten stellen wij ons ontwerp bij, voegen wij hier aan toe of schakelen wij de stakeholder bij om verdere details uit te vragen.


## Tooling
Bij de aanvang van het project is duidelijk dat wij onderstaande gaan gebruiken, verdere technische keuzes zullen later in het traject gemaakt worden wanneer de benodigde requirements in kaart gebruikt zijn.
- Github (Project mangement, CI/CD Pipeline & versie beheer.)
- Markdown documentatie
- Mermaid voor UML diagrams

## Documentatie werkwijze
Tijdens de analyse fase stellen wij in eerste instantie vragen aan de stakeholder op basis van de aangeleverde casus documenten. Deze vragen in combinatie met antwoord leggen wij vast in een vragen document, alle vragen in dit document zijn genummerd zodat wij hier eventueel later naar kunnen referen. Antwoorden roepen waarschijnlijk meer vragen op, wij zullen daarom meerdere malen een meeting plannen met de stakeholder en vervolgens weer de feedback/verkregen antwoorden verwerken, dit doen wij interatief, ieder vragen moment staat voor iteratie.

Op basis van de verkregen antwoorden stellen wij een document met requirements op, op basis van de requirements zullen wij vervolgens een functioneel ontwerpen opstellen. Niet functionele requirements in combinatie met het functionele ontwerp zullen het technisch ontwerp vervolgens voeden.

Belangrijk is dat de oorsprong van verschillende design keuzes te herlijden is, in onderstaande diagram word inzichtelijk gemaakt hoe deze documenten zicht tot elkaar verhouden..

```mermaid
flowchart LR
    Q&A -->|Vragen| SRS 
    SRS -->|Functionele Requirements| FO 
    SRS -->|Niet Functionele Requirements| TO
    FO --> TO 

```

Dan onderstaande een overzicht van alle documentatie die wij plannen op te leveren. Vanzelfsprekend dient alle vastlegging waar mogelijk ook onderbouwt te worden.
```
.
├── Question & Answers (Q&A)
├── Software Requirement Sepcification (SRS)
├── Functioneel ontwerp 
|   ├── Domein Model
|   ├── Use Cases
|       ├── Aangevuld met System Sequence Diagrams (SSD) waar handig
├── Development onboarding
├── Technisch Ontwerp
|   ├── Class Diagram
|   ├── Toegepaste patterns
|   ├── Sequence Diagrams (SD)
|   ├── Frameworks & Libraries
|   ├── Applicatie Architectuur
```

## Documentatie standaarden

Hier en daar in het document zal aangegeven worden aan welke criteria een specifieke sectie moet voldoen, deze dienen als richtlijn/handvat en dienen verwijderd te worden voor de uiteindelijke oplevering.

---
:warning: **_CRITERIA:_**
Het document moet aan x voldoen zodat x.

---

Eventuele notities kan je aangeven middels:

---
:warning: **_NOTITIE:_**
Het document moet aan x voldoen zodat x.

---


## Git werkwijze
- main --> bevat altijd een werkende versie
- develop --> is de versie waaraan gewerkt word , wanneer alle gewenste feature & bug branches gemerged zijn en deze volledig werkend is zetten we deze door naar de main branch middels een PR.
- feature/bug branches --> de onderscheiding tussen feature en bug spreken voor zich, feature & bugs representeren een work item uit het kanban bord. Merge de branch niet lokaal maar maak een pullrequest aan binnen github naar de develop branch, iemand anders zal dan PR dan moeten goedkeuren.

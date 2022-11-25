[Terug](/README.md)

---
:warning: **_NOTE:_**
Belangrijk voor het gehele document:

- Moet consistent zijn met FO!
- Indien binnen code afwekend wordt van TO moet dit grondig onderbouwd zijn.

---

# Technisch Ontwerp

**Opdrachtgever:** De HAN - Hoge School Arnhem Nijmegen</br>
**Datum**: 12-11-2022 </br>
**Studenten**: Thomas Hofman (622438), Ricardo de Wijs ({studentnr})</br>
**Versie**: v0.2 </br>
**Klas**: {klascode} </br>
**Locatie**: Arnhem
**Docent**: John Gorter

# Versiebeheer

|Versie|Beschrijving|Auteur|Datum|
|------|------------|------|-----|
|v0.1|Document opzet & inleidingen|Thomas Hofman|16-09-2022|
|v0.2|Converteren van docx naar markdown|Thomas Hofman|12-11-2022|
|v0.3|Concept H4, H5|Thomas Hofman|12-11-2022|

# Inhoudsopgave

1. [Inleiding](#1-inleiding) </br>
    1.1. [Aanleiding](#11-aanleiding) </br>
    1.2. [Doelstelling](#12-doelstelling) </br>
    1.3. [Doelgroep](#13-doelgroep) </br>
2. [Aanpak & Prioritering](#2-aanpak--prioritering) </br>
3. [Architectuur](#3-architectuur) </br>
    3.1. [Layering](#31-layering) </br>
    3.2. [Distribution](#32-distribution) </br>
    3.3. [Architectuur Patterns](#33-architectuur-patterns) </br>
4. [Technische keuzes](#4-technische-keuzes)
5. [Design](#5-design) </br>
    5.1. [Class Diagram](#51-class-diagram) </br>
        5.1.1. [Toelichting](#511-toelichting) </br>
        5.1.2. [Domein consistentie/inconsistentie](#512-domein-consistentieinconsistentie) </br>
    5.2. [UC15 - Start uitvoering](#52-uc-15-start-uitvoering) </br>
        5.2.1. [Design](#521-design) </br>
        5.2.2. [Toelichting](#522-toelichting) </br>
6. [Overige](#6-overige) </br>
    6.1. [Versiebeheer](#61-versiebeheer) </br>
    6.2. [Build Management (CI/CD)](#62-build-management-cicd) </br>
    6.3. [Unit-, Integratie- Tests](#63-unit--integratie--tests) </br>
7. [Bronnen](#7-bronnen)

# 1. Inleiding

## 1.1. Aanleiding

## 1.2. Doelstelling

## 1.3. Doelgroep

- Technische mensen

<font size="1">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>

# 2. Aanpak & Prioritering

---
:warning: **_NOTE:_**
must-have functionaliteit volledig zoals gespecificeerd voor een 8 een paar should haves voor een 10

---

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
    - of plain Javascript, Ajax, Bootstrap
    - of angular met material UI.
8. Heel veel tijd over?
    1. overige crud use cases uitwerken
    2. Authenticatie implementeren via AzureAD

<font size="1">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>

# 3. Architectuur

Domain-centric architecture: Clean Architecture

```raw
.
├── _HICT.ICDETool.Application --> Application > Stuurt het domein aan
|   └── _Interfaces
|       ├── Repositories > Interfaces voor persistentie
|       └── Services > Interfaces voor andere infrastructurele benodigdheden
├── HICT.ICDETool.SharedKernel --> Shared kernel > gebruikt in meerdere projecten, zoals value objects
├── HICT.ICDETool.Domain --> Domain logic > Domein werkt op zichzelf, en beheert eigen consistentie.
├── HICT.ICDETool.Infrastructure --> Implementatie van applicatie interfaces voor persistentie en services (onder andere EF CORE)
├── HICT.ICDETool.Api (entrypoint) --> Presentatie logica only, aanbieden van een rest api en deze aansturen middels swagger 
├── HICT.ICDETool.Tests (entrypoint voor tests)

.
└── HICT.ICDETool.Web --> (minste prioriteit) Losse MVC app: het aanbieden van een javascript webapp die de swagger api consumeert.
```

```mermaid
classDiagram
Api --> Application
Web --> Api
Application --> Domain
Infrastructure *..> Application : IRepository
```

## 3.1. Layering

## 3.2. Distribution

- Geen microservices

## 3.3. Architectuur Patterns

---
:warning: **_CRITERIA:_**
een variatie aan principes en patterns op correcte en onderbouwde manier toegepast voor een 10

---

<font size="1">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>

## 4. Technische keuzes

- .NET 6 / C#10
- ORM framework: EF Core 6
- Presentatie framework: MVC
- Swagger
- Frontend: Javascript/Ajax/Jquery/Bootstrap 5
- Project management: github projects
- Dependency Injection via host builder
- Configuration Management (IConfiguration)
- Database: MSSQL

Eventueel:

- Angular

---
:warning: **_CRITERIA:_**
alle frameworks, framework onderdelen en libraries correct gebruikt en volledig geïntegreerd, keuze voor deze onderbouwd voor een 10

---

<font size="1">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>

# 5. Design

## 5.1. Class Diagram

```mermaid
classDiagram

class Adres{
    + int Id
    + string Straat
    + string Huisnummer
    + string Toevoeging
    + string Postcode
    + string Plaatsnaam
}

class Beoordeling{
    + int Id
    + Student BeoordelingVoor
    + Docent BeoordeeldDoor
}
Beoordeling *--> TentamenUitvoering
Beoordeling --> Student
Beoordeling --> Docent

class BeoordelingsCriteria{
    + int Id
    + string Omschrijving
}

class BeroepsProduct{
    + int Id
    + string Titel
    + TentamenType Type
    + int Weging
    + int TeBehalenStudiepunten
    + IEnumberable<Rubric> Rubrics
    - IList<Rubrics> _rubrics
    + void AddRubrics(Rubrics)
}
BeroepsProduct --|> TentamenInrichting 
BeroepsProduct -- TentamenType
BeroepsProduct *--> Rubrics

class CourseBibliotheek{
    + IEnumberable<CourseInrichting> Courses
    - IList<CourseInrichting> _courses
    + void AddCourse(CourseInrichting)
}
CourseBibliotheek *--> CourseInrichting

class CourseInrichting {
    + int Id
    + string Titel
    + string Omschrijving
    + Docent AangemaaktDoor
    + CourseWeekPlanning Planning
    + bool IsDefinitief = false
    + ITijdDefinitie Duur
    + DateTimeOffset AanmaakDatum
    - DateTimeOffset _aanmaakDatum
    + IEnumerable<EenheidVanLeeruitkomsten> Evls
    - IList<EenheidVanLeeruitkomsten> _evls
    + IEnumerable<TentamenInrichting> Tentamen
    - IList<TentamenInrichting> _tentamen
    + IEnumerable<LesInrichting> Lessen
    - IList<LesInrichting> _lessen
    + void MaakDefinitief()
    + void AddEenheidVanLeeruitkomsten(EenheidVanLeeruitkomsten)
    + void AddTentamen(TentamenInrichting)
    + void AddLes(LesInrichting)
    + CourseUitvoering StartCourseUitvoering(DateTimeOffset)
}
CourseInrichting <--* CourseWeekPlanning
CourseInrichting -- ITijdDefinitie
CourseInrichting <--* EenheidVanLeeruitkomsten
CourseInrichting <--* TentamenInrichting
CourseInrichting <--* LesInrichting

class CourseUitvoering {
    + int Id
    + CourseInrichting CourseInrichting
    + IEnumerable<CourseWeekUitvoering> Weken
    - IList<CourseWeekUitvoering>
    + DateTimeOffset StartDatum
    - DateTimeOffset _startDatum
    - void creeerWeekUitvoeringen()
}
CourseUitvoering *--> CourseInrichting
CourseUitvoering <--* CourseWeekUitvoering

class CourseWeekInrichting{
    + int Id
    + IEnumerable<SchriftelijkeToets> SchriftelijkeToets 
    - IList<SchriftelijkeToets> _schriftelijkeToets
    + IEnumerable<BeroepsProduct> BeroepsProduct
    - IList<BeroepsProduct> _beroepsProduct 
    + IEnumerable<LesInrichting> Lessen
    - IList<LesInrichting> _lessen
    + void AddSchriftelijkeToets(SchriftelijkeToets)
    + void AddBeroepsProduct(BeroepsProduct)
    + void AddLes(LesInrichting)
}
CourseWeekInrichting <--* SchriftelijkeToets
CourseWeekInrichting <--* BeroepsProduct
CourseWeekInrichting <--* LesInrichting

class CourseWeekPlanning{
    + int Id
    + ITijdDefinitie Duur
    - ITijdDefinitie _duur
    + IEnumerable<CourseWeekInrichting> Weken
    - IList<CourseWeekInrichting> _weken 
    - void vulPlanningMetWeken()
}
CourseWeekPlanning -- ITijdDefinitie
CourseWeekPlanning <--* CourseWeekInrichting

class CourseWeekUitvoering{
    + int Id
    + DateTimeOffset Monday
    + CourseWeekInrichting CourseWeekInrichting
    - CourseWeekInrichting _courseWeekInrichting
    + IEnumerable<TentamenUitvoering> Tentamen
    - IList<TentamenUitvoering> _tentamen
    + IEnumerable<LesUitvoering> Lessen
    - IList<LesUitvoering> _lessen
    - void creeerTentamenUitvoeringen()
    - void creeerLesUitvoeringen()
}
CourseWeekUitvoering *--> CourseWeekInrichting
CourseWeekUitvoering --> TentamenUitvoering
CourseWeekUitvoering --> LesUitvoering


class EenheidVanLeeruitkomsten{
    + int Id
    + string Titel
    + string Omschrijving
    + IEnumerable<Leeruitkomst> Leeruitkomsten
    - IList<Leeruitkomst> _leeruitkomsten
    + void AddLeeruitkomst(Leeruitkomst)
}
EenheidVanLeeruitkomsten <--* Leeruitkomst

<<Interface>> ITijdDefinitie
class ITijdDefinitie{
    + int DuurInWeken
    + int TeBehalenStudiepunten
}

class Klas{
    + int Id
    + string Code
    + Docent mentor
    + IEnumerable<Student> Studenten
    - IList<Student> _studenten
    + void AddStudent(Student)
}
Klas --> Docent
Klas --> Student

class Leerdoel{
    + int Id
    + string Titel
    + string Omschrijving
    + IEnumerable<Rubric> GekoppeldeRubrics
    - IList<Rubric> _gekoppeldeRubrics
    + IEnumerable<LesInrichting> GekoppeldeLessen
    - IList<LesInrichting> _gekoppeldeLessen
    + IEnumerable<SchriftelijkeToets> GekoppeldeToetsen
    - IList<SchriftelijkeToets> _gekoppeldeToetsen
    + void KoppelRubrics(Rubric)
    + void OntkoppelRubric(Rubric)
    + void KoppelLes(LesInrichting)
    + void OntkoppelLes(LesInrichting)
    + void KoppelToets(SchriftelijkeToets)
    + void OntkoppelToets(SchriftelijkeToets)
}
Leerdoel --> Rubric
Leerdoel --> LesInrichting
leerdoel --> SchriftelijkeToets

class Leeruitkomst{
    + int Id
    + string Titel
    + string Omschrijving
    + public IEnumerable<Leerdoel> Leerdoelen
    - private IList<Leerdoel> _leerdoelen
    + void KoppelLeerdoel(Leerdoel)
}
Leeruitkomst --> Leerdoel

class LesInrichting{
    + int Id
    + string Titel
    + IEnumerable<LesMateriaal> LesMateriaal
    - IList<LesMateriaal> _lesMateriaal 
    + void AddLesMateriaal(LesMateriaal)
    + void RemoveLesMateriaal(LesMateriaal)
}
LesInrichting --> LesMateriaal

class LesMateriaal{
    + int Id
    + IEnumerable<LesMateriaalLine> Inhoud
    - IList<LesMateriaalLine> _inhoud
    - IList<LesMateriaalLine> genereerInhoud()
}
LesMateriaal --> LesMateriaalLine

class LesMateriaalLine{
    + int Id
    + string Line
}

class LesUitvoering{
    + int Id
    + LesInrichting LesInrichting
    + Docent Docent
    + Locatie Locatie
}
LesUitvoering *--> LesInrichting
LesUitvoering --> Docent
LesUitvoering --> Locatie

class Locatie{
    + int Id
    + string Naam
    + LocatieType Type
    + Adres Adres
}
Locatie -- LocatieType
Locatie --> Adres

class Opleiding{
    + int Id
    + string Naam
    + string Code
    + IEnumerable<OpleidingsProfiel> OpleidingsProfielen
    - IList<OpleidingsProfiel> _opleidingsProfielen
    + void AddOpleidingsProfiel(OpleidingsProfiel)
    + void RemoveOpleidingsProfiel(OpleidingsProfiel)
}
Opleiding <--* OpleidingsProfiel

class OpleidingsProfiel{
    + int Id
    + string Naam
    + string Code
}

Periode --|> ITijdDefinitie
Semester --|> ITijdDefinitie

class Persoon {
    + string Voornaam
    + string Achternaam
    + string Email
}

Docent --|> Persoon
Student --|> Persoon

class Rubric {
    + int Id
    + string Titel
    + int Weging
    + int VoldoendeThreshold
    + int KnockoutThreshold
    + IEnumerable<BeoordelingsCriteria> BeoordelingsCriteria
    - IList<BeoordelingsCriteria> _beoordelingsCriteria 
    + void AddBeoordelingsCriteria(BeoordelingsCriteria)
    + void RemoveBeoordelingsCriteria(BeoordelingsCriteria)
}
Rubrics <--* BeoordelingsCriteria

<<interface>> TentamenInrichting
class TentamenInrichting{
    + int Id
    + string Titel
    + TentamenType Type
    + int Weging
    + int TeBehalenStudiepunten
}

SchriftelijkeToets --|> TentamenInrichting


<<Enumeration>> TentamenType
<<Enumeration>> LocatieType


```

---
:warning: **_CRITERIA:_**
Correct toepassen standaard notatie en het diagram moet de volledig requirements afdekken.

---

### 5.1.1 Toelichting

---
:warning: **_CRITERIA:_**
Minimaal 1 extra diagram (geen class diagram) opnemen, diverse modellen vereist voor een 8

---

### 5.1.2. Domein consistentie/inconsistentie

---
:warning: **_CRITERIA:_**
Zowel inconsistenties als consistenties benoemd, inconsistenties volledig van relevante, onderbouwde verbetervoorstellen voorzien voor een 10

---

## 5.2 UC-15 Start Uitvoering

---
:warning: **_CRITERIA:_**
Ontwerp problemen identificeren en ontwerp keuzes onderbouwen met relevant alternatieven en overwegingen voor een 10

---

---
:warning: **_NOTE:_**
een variatie aan principes en patterns op correcte en onderbouwde manier toegepast voor een 10

---

### 5.2.1. Design

```mermaid
sequenceDiagram
    autonumber
    Client->>CourseInrichting: startUitvoering()
    activate CourseInrichting
    CourseInrichting->>CourseUitvoering: CourseUitvoering(this, date)
    deactivate CourseInrichting
    activate CourseUitvoering
    CourseUitvoering->>CourseUitvoering: creeerWeekUitvoeringen
    
    loop weken in planning
        CourseUitvoering->>CourseUitvoering: Weken.Add()
        CourseUitvoering->>CourseWeekUitvoering: CourseWeekUitvoering(week, date)
        deactivate CourseUitvoering
        activate CourseWeekUitvoering
        CourseWeekUitvoering->>DateOnly: StartOfWeek()
        
        CourseWeekUitvoering->>CourseWeekUitvoering: creeerTentamen()
        loop tentamen in week
            CourseWeekUitvoering->>CourseWeekUitvoering: _tentamen.Add()
            CourseWeekUitvoering ->> TentamenUitvoering: TentamenUitvoering(tentamen)
        end
        CourseWeekUitvoering->>CourseWeekUitvoering: creeerLessen()
        loop les in week
            CourseWeekUitvoering->>CourseWeekUitvoering: _les.Add()
            CourseWeekUitvoering ->> LesUitvoering: LesUitvoering(les)
        end
    end
    deactivate CourseWeekUitvoering
    
```

```mermaid
classDiagram

    class CourseInrichting {
        + CourseWeekPlanning Planning
        + StartCourseUitvoering(DateOnly date)
    }

    class CourseUitvoering {
        + CourseUitvoering(CourseInrichting inrichting, DateOnly date)
        - creeerWeekUitvoeringen(date)
    }

    class CourseWeekUitvoering {
        + CourseWeekUitvoering(CourseWeekInrichting inrichting, DateOnly date)
        - creeerTentamen()
        - creeerLessen()
    }

    class TentamenUitvoering {
        - TentamenInrichting _inrichting
        + TentamenUitvoering(TentamenInrichting inrichting)
    }

    class LesUitvoering {
        - LesInrichting _inrichting
        + LesUitvoering(LesInrichting inrichting)
    }

    class DateOnly {
        + StartOfWeek()
    }

    CourseInrichting "1" <--o "0..*" CourseUitvoering 
    CourseWeekUitvoering "1..*" o--> "1" CourseUitvoering 
    LesUitvoering "1..*" o--> "1" CourseWeekUitvoering
    TentamenUitvoering "1..*" o--> "1" CourseWeekUitvoering
```

---
:warning: **_NOTE:_**
Class Diagram en/of sequence diagram toegespitst op de use case.

---

### 5.2.2. Toelichting

---
:warning: **_NOTE:_**
Toelichten van gebruikte GoF patterns, SOLID principes & GRASP principes.

---

<font size="1">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>

# 6. Overige

## 6.1. Versiebeheer

- Version management: github repos

---
:warning: **_CRITERIA:_**
versiebeheer en build management toegepast voor een 10

---

## 6.2. Build Management (CI/CD)

- Build management: github actions
- CI --> build artifacts
- Runs tests
- CD --> build docker container & upload to repo

---
:warning: **_CRITERIA:_**
versiebeheer en build management toegepast voor een 10

---

## 6.3. Unit-, Integratie- Tests

- Test Framework: xUnit

---
:warning: **_CRITERIA:_**
unit- en integratietests dekken werking grotendeels af, werking gedemonstreerd voor een 10

---

<font size="1">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>

# 7. Bronnen

|APA Bronvermelding|
|------------------|
|{clean architecture}
|{DDD}
|{Pluralsight courses}
|{refactoring guru}

<font size="1">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>
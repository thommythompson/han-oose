[Terug](/README.md)

# Functioneel Ontwerp

**Opdrachtgever:** De HAN - Hoge School Arnhem Nijmegen</br>
**Datum**: 12-01-2023 </br>
**Studenten**: Thomas Hofman (622438), Ricardo de Wijs (498412)</br>
**Versie**: v1.0 </br>
**Locatie**: Arnhem </br>
**Docent**: John Gorter

# Versiebeheer

|Versie|Beschrijving|Auteur|Datum|
|------|------------|------|-----|
|v0.1|Document opzet & inleidingen|Thomas Hofman|16-09-2022|
|v0.2|H2.1|Ricardo de Wijs|28-09-2022|
|v0.3|Converteren van docx naar markdown|Thomas Hofman|12-11-2022|
|v0.4|CRUD Use Cases|Thomas Hofman|12-11-2022|
|v0.5|CRUD Use Cases|Thomas Hofman|12-11-2022|
|v0.6|Use Cases|Thomas Hofman|30-12-2022|
|v0.7|Use Cases|Thomas Hofman|31-12-2022|
|v0.8|Use Cases toevoegen |Ricardo de Wijs|08-01-2023|
|v1.0|Eerste versie |Thomas Hofman|12-01-2023|

# Inhoudsopgave

1. [Inleiding](#1-inleiding) </br>
    1.1. [Aanleiding](#11-aanleiding) </br>
    1.2. [Doelstelling](#12-doelstelling) </br>
    1.3. [Doelgroep](#13-doelgroep) </br>
2. [Functionele omschrijving](#2-functionele-omschrijving) </br>
    2.1. [Systeemfunctie](#21-systeemfunctie) </br>
3. [Use Cases](#3-use-cases) </br>
    3.1. [Systeem grens](#31-systeem-grens) </br>
    3.2. [Crud Identificatie](#32-crud-use-cases) </br>
    3.3. [Use Cases](#33-use-cases) </br>
    3.4. [Use Case Diagram](#34-use-case-diagram) </br>
4. [Domein Model](#4-domein-model) </br>
5. [Bronnen](#5-bronnen)

# 1. Inleiding

## 1.1. Aanleiding

De aanleiding voor het schrijven van dit functioneel ontwerp is de opdracht gegeven door de I-OOSE semester ontwikkelaars werkzaam bij de organisatie "De HAN" om een systeem te bouwen dat hun assisteert bij het ontwikkelen van een course.

## 1.2. Doelstelling

Het doel van het document is het in detail vastleggen van een functionele omschrijving, abstract van enige techniek of implementatie zodat het document kan dienen als input voor de ontwikkeling van een passende oplossing zonder hier zelf al invulling aan te geven.

## 1.3. Doelgroep

Stakeholders vanuit de HAN betrokken bij de casus ICDE en degene die de casus uitvoeren.

<font size="1">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>

# 2. Functionele Omschrijving

Om goed te begrijpen wat het te ontwikkelen systeem (SUD) moet gaan doen zijn er op basis van de initiële casus beschrijving: “Integrated Course Design Environment” (ICDE) en op basis van een domein onderzoek vragen gesteld aan de stakeholders. De uitkomsten resulteren in een functioneel eisenpakket, het software requirement specification (SRS) document. Als toevoeging op het SRS document is er in de volgende paragraaf een beknopte functionele beschrijving opgenomen.

## 2.1. Systeemfunctie

Dit systeem zal primair course ontwikkelaars ondersteunen met het ontwikkelen van één of meerdere courses. Om deze ondersteuning te kunnen bieden zal het systeem gevoed moeten worden met informatie over de vakken, beoordelingscriteria en lesmethoden. Onze aanname is ook dat het systeem ook een bibliotheek functie vervuld waaruit geput kan worden om een semester samen te stellen en vervolgens uit te voeren. Deze bibliotheek wordt gevuld door de semesterontwikkelaars zelf. Het systeem ziet erop toe dat het vullen op een eenduidige en consistente manier gebeurt.

Gedurende het gebruik van het systeem zal de bibliotheek groeien. De inhoud, lessen en tentamen, die onderdeel zijn van een semester/periode moet voldoen aan specifieke eisen (deze business logica ligt vast in de requirements), de tentamen zullen verbonden zijn aan een x aantal studiepunten, het totaal van de haalbare studiepunten zal gelijk moeten zijn aan een vooraf gestelde quota (Periode 15/Semester 30). Het systeem dwingt business logica als deze af om te garanderen dat courses in overeenstemming zijn met de business logica.

De voornaamste gebruikers van het systeem zullen docenten en studenten zijn. Docenten hebben de mogelijkheid om ontwikkelde courses uit te voeren en vervolgens de voortgang van de studenten bij te houden en bijvoorbeeld docenten toe te wijzen aan lessen. Een student kan de inrichting van de courses die hij/zij volgt en de bijhorende voortgang bekijken.

<font size="1">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>

# 3. Use Cases

Binnen het hoofdstuk use cases zullen wij ons richten op het identificeren en vastleggen van use cases. Het in kaart brengen doen wij volgens de Larman (Larman, 2005) methode, deze begint met het het vaststellen van de systeem grens. Vervolgens zullen wij over gaan tot de daadwerkelijke use case identificatie, dit doen wij middels de “User-Goal” en “Event Analysis” methoden. De data bronnen waarop wij deze technieken zullen toepassen zijn de "Questions & Answers" en "Software Requirements Specification" documenten.

De in kaart gebrachte use cases worden waar nodig uitgewerkt tot een daadwerkelijke tekstuele use case, ofte wijl een use case in fully dressed format. Vervolgens sluiten wij dit hoofdstuk af met een use case diagram, een visuele weergave van hoe de use cases zich tot elkaar verhouden.

## 3.1. Systeem grens

De focus van het systeem ligt rond het methodisch ontwerpen van courses die studenten zullen volgens. Met methodisch word gedoeld op een vaste structuur en handhaving van logica en door de HAN gedefinieerde eisen omtrent het ontwikkelen van courses. Denk hierbij aan hoeveel lessen mogen er per week gegeven worden, hoeveel studiepunten moet men kunnen halen, hoe lang mag een course duren en worden alle leerdoelen afgetoetst? De inrichting van de course zal ook moeten voorzien in een objectieve beoordelingswijze voor beroepsproducten.

Ontwikkelde courses (inrichtingen) kunnen ook binnen het systeem geinstantieerd worden (uitvoeringen). Voer uitvoeringen richt het systeem zich op een aantal specifieke aspecten:

- Het toewijzen van docent aan lessen of tentamen.
- Het toewijzen van locaties aan lessen of tentamen.
- Het toewijzen van studenten aan opleidingsprofielen.
- Het toewijzen van studenten aan course uitvoeringen.
- Het assisteren van docenten in het objectief beoordelen van beroepsproducten gemaakt door studenten.

Het systeem handhaaft een vaste structuur bij courses die ontwikkelt worden binnen "De HAN", voorziet in het bijhouden van resource allocatie, het bijhouden van beoordelingen en geeft studenten inzage in course informatie en lesmateriaal.

Bovenstaande schets een kader van wat er binnen het systeem zal (kunnen) vallen. Functionaliteiten die niet binnen dit kader vallen zoals bijvoorbeeld concrete planning, zullen gehuisvestigd moeten worden in een ander systeem. Ook diensten waarmee het systeem zal integreren (bijvoorbeeld externe authenticatie providers) vallen niet binnen de systeem grens. Mocht het gewenst zijn het kader uit te breiden zal er in overleg met de stakeholder een nieuwe systeem grens gedefinieerd moeten worden.

## 3.2. Crud Use Cases

Veel van de use cases bevatten overeenkomende functionaliteit, namelijk een standaard implementatie voor het aanmaken, lezen, updaten en verwijderen van data. Deze standaard implementatie hebben wij eenmalig vastgelegd in een viertal use cases, deze use cases zien [hier](./crud.md) in te zien.

## 3.3. Use Cases

Middels de “User-Goal” en “Event Analysis” use case identificatie technieken hebben wij belangrijke entiteiten, actoren en hun doelen weten te identificeren. Uit deze informatie hebben wij een aantal use cases weten te extraheren, waar nodig worden deze in het bijgevoegde use case document toegelicht middels een “fully dressed” formaat. Het fully dressed use case model is gebaseerd op het meest wijd geadopteerde template van Alistair Cockburn (Larman 2005).

Niet alle use cases zijn even complex, sommige use cases zijn gebaseerd op basis van de in hoofdstuk 3.2 gedefinieerd CRUD use cases. Voor deze use cases worden alleen afwijkingen/specificiteiten vastgelegd.

De uitwerkingen van alle use cases zijn [hier](usecases.md) in te zien.

## 3.4. Use Case Diagram

```plantuml
left to right direction
actor "Docent" as d
actor "Student" as s
rectangle ICDE-Tool {
    usecase "UC-11 Ontwikkel EVL" as UC11
    usecase "UC-10 Ontwikkel leeruitkomst" as UC10
    usecase "UC-12 Ontwikkel leerdoel" as UC12
    usecase "UC-13 Ontwikkel toets" as UC13
    usecase "UC-21 Ontwikkel beroepsproduct" as UC21
    usecase "UC-14 Maak rubriek" as UC14
    usecase "UC-22 Ontwikkel les" as UC22
    usecase "UC-1 Ontwikkel Course" as UC1
    usecase "UC-17 Maak weekplanning" as UC17
    usecase "UC-16 Maak course definitief" as UC16
    usecase "UC-15 Start uitvoering" as UC15
    usecase "UC-19 Beheer locaties" as UC19
    usecase "UC-4 Beheer klas" as UC4
    usecase "UC-8 Geef Beoordeling" as UC8
    usecase "UC-3 Voeg student aan toe aan klas" as UC3
    usecase "UC-7 Beheer Opleidingen" as UC7
    usecase "UC-9 Beheer Opleidingsprofielen" as UC9
    usecase "UC-5 Vraag course info op" as UC5
    usecase "UC-18 Exporteer informatie" as UC18
    usecase "UC-6 Vraag course planning op" as UC6
    usecase "UC-2 Bekijk Beoordelingen" as UC2
    usecase "UC-20 Aanmelden" as UC20
    usecase "UC-23 Nieuwe versie" as UC23
}

d --> UC11
d --> UC10
d --> UC12
d --> UC13
d --> UC21
UC21 <.. UC14 : <<extends>>
d --> UC22
d --> UC1
UC1 <.. UC17 : <<extends>>
UC1 <.. UC16 : <<extends>>
UC1 <.. UC23 : <<extends>>
d --> UC15
d --> UC19
d --> UC4
UC4 <.. UC3 : <<extends>>
d --> UC8
d --> UC7
d --> UC9
d --> UC5
s --> UC5
UC5 <.. UC18
UC5 <.. UC6
s --> UC2
```

<font size="1">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>

# 4. Domein Model

Binnen het domein model richten wij ons op het verstaan van de business taal, hetgeen dat van belang is de vastlegging van concepten, hun attributen en de relatie tussen deze concepten. Het domein model zelf is een visuele representatie van het business domein. De concepten hebben wij geïdentificeerd middels de "noun identification method" (Larman 2005), dat betekent dat wij alle zelfstandig naamwoorden in kaart hebben gebracht en als concepten hebben bestempelt. De verhoudingen en relevantie van deze concepten hebben wij gevalideerd met de stakeholders, deze communicatie is vastgelegd in het "Questions & Answers" document. Wij hebben alleen het resultaat relevant bevonden om op te nemen in een ontwerp document, de werkdocumenten waarin wij de "noun identification method" hebben toegepast zijn daarom achterwegen gelaten.

```plantuml
object CourseBibliotheek 
object CourseInrichting {
    Titel
    AantalStudiePunten
    DuurInWeken
}
object CourseWeekInrichting {
    WeekNr
}
object SchriftelijkeToets {
    Type
}
object EenheidVanLeeruitkomsten {
    Titel
    Omschrijving
}
object Leeruitkomst {
    Titel
    Omschrijving
}
object Leerdoel {
    Titel
    Omschrijving
}
object LesInrichting {
    ContactUren
}
object LesMateriaal
object Rubrics {
    Titel
    Weging
    AantalCriteria
    VoldoendeThreshold
    KnockoutThreshold
}
object BeroepsProduct {
    Type
}
object BeoordelingsCriteria {
    Omschrijving
}
object TentamenInrichting {
    Titel
    TypeBeoordeling
    Weging
    HaalbareStudiePunten
}
object Persoon {
    naam
}
object Docent
object Student
object CourseUitvoering
object Klas {
    Code
}
object Opleiding {
    Naam
}
object Opleidingsprofiel {
    Naam
}
object Beoordeling {
    BehaaldAantalPunten
}
object TentamenUitvoering {
    Datum
}
object CourseWeekUitvoering {
    SchoolWeekNr
    DatumMaandag
}
object LesUitvoering {
    Datum
}
object Locatie {
    Naam
    Adres
    IsOnline
}

CourseBibliotheek "1" -- "0..*" CourseInrichting : Staat in
EenheidVanLeeruitkomsten "1..*" -- "1" CourseInrichting : Is gericht op
EenheidVanLeeruitkomsten "1" -- "1..*" Leeruitkomst : Bevat
Leeruitkomst "1" -- "1..*" Leerdoel : Word behaald door
Leerdoel "0..*" -- "1..*" SchriftelijkeToets 
Leerdoel "1..*" -- "1..*" Rubrics 
Leerdoel "1..*" -- "1..*" LesInrichting
Rubrics "1" -- "1..*" BeoordelingsCriteria : Bestaat uit
Rubrics "1..*" -- "1" BeroepsProduct : Word beoordeeld middels
SchriftelijkeToets --|> TentamenInrichting : Is
BeroepsProduct --|> TentamenInrichting : Is
LesInrichting "1" -- "1..*" LesMateriaal : Bevat
LesInrichting "1" -- "0..*" LesUitvoering : Representeert
LesInrichting "1" -- "0..*" CourseWeekInrichting
CourseWeekInrichting "1" -- "0..*" TentamenInrichting : bevat
CourseWeekInrichting "1..*" -- "1" CourseInrichting : bevat
CourseWeekInrichting "1" -- "0..*" CourseWeekUitvoering : valt in
CourseInrichting "0..*" -- "1..*" Docent : maakt
CourseInrichting "1" -- "0..*" CourseUitvoering : Representeert
Docent  --|> Persoon : Is
Student  --|> Persoon : Is
TentamenInrichting "1" -- "0..*" TentamenUitvoering : Representeert
Docent "1" -- "0..*" LesUitvoering : Geeft
Docent "1" -- "0..*" TentamenUitvoering : Examineert
Docent "1" -- "0..*" Beoordeling : Geeft
Beoordeling "1..*" -- "1" TentamenUitvoering : Voor
Beoordeling "1" -- "0..*" Student : Krijgt
Klas "1..*" -- "1" Student : Zit in
Klas "1" -- "1..*" CourseUitvoering : Volgt
Klas "1" -- "0..*" Opleidingsprofiel : Volgt
Opleiding "1" -- "1..*" Opleidingsprofiel : Bevat
CourseWeekUitvoering "1..*" -- "1" CourseUitvoering : Bevat
CourseWeekUitvoering "1" -- "0..*" TentamenUitvoering : Valt in
CourseWeekUitvoering "1" -- "0..*" LesUitvoering : Valt in
Locatie "1" -- "1..*" LesUitvoering 
Locatie "1" -- "1..*" TentamenUitvoering
```

<font size="1">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>

# 5. Bronnen

|APA Bronvermelding|
|------------------|
|Larman, C., & Kruchten, P. (2005). Applying UML and Patterns: An Introduction to Object-oriented Analysis and Design and Iterative Development. Prentice Hall.


<font size="1">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>
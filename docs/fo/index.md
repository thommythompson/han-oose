[Terug](/README.md)

---
:warning: **_NOTE:_**
Voor het hele document geldt: het FO moet net zo gedetailleerd als het TO, daarnaast mogen in het FO geen technische keuzes gemaakt worden. (John)

---

# Functioneel Ontwerp

**Opdrachtgever:** De HAN - Hoge School Arnhem Nijmegen</br>
**Datum**: 12-11-2022 </br>
**Studenten**: Thomas Hofman (622438), Ricardo de Wijs ({studentnr})</br>
**Versie**: v0.4 </br>
**Klas**: {klascode} </br>
**Locatie**: Arnhem
**Docent**: John Gorter

# Versiebeheer

|Versie|Beschrijving|Auteur|Datum|
|------|------------|------|-----|
|v0.1|Document opzet & inleidingen|Thomas Hofman|16-09-2022|
|v0.2|H2.1|Ricardo de Wijs|28-09-2022|
|v0.3|Converteren van docx naar markdown|Thomas Hofman|12-11-2022|
|v0.4|CRUD Use Cases|Thomas Hofman|12-11-2022|

# Inhoudsopgave

1. [Inleiding](#1-inleiding) </br>
    1.1. [Aanleiding](#11-aanleiding) </br>
    1.2. [Doelstelling](#12-doelstelling) </br>
    1.3. [Doelgroep](#13-doelgroep) </br>
2. [Functionele omschrijving](#2-functionele-omschrijving) </br>
    2.1. [Systeemfunctie](#21-systeemfunctie) </br>
3. [Use Cases](#3-use-cases) </br>
    3.1. [Scope](#31-scope) </br>
    3.2. [Crud Identificatie](#32-crud-use-cases) </br>
    3.3. [Use Cases](#33-use-cases) </br>
    3.4. [Use Case Diagram](#34-use-case-diagram) </br>
4. [Domein Model](#4-domein-model) </br>
5. [Bronnen](#5-bronnen)

# 1. Inleiding

## 1.1. Aanleiding

De aanleiding voor het schrijven van dit functioneel ontwerp is de wens vanuit de organisatie de HAN namens semester ontwikkelaars om een systeem te kunnen gebruiken dat hun assisteert bij het ontwikkelen van een course.

## 1.2. Doelstelling

Het doel van het document is het in detail vastleggen van een functionele omschrijving, abstract van enige techniek of implementatie zodat het document kan dienen als input voor de ontwikkeling van een passende oplossing zonder hier zelf al invulling aan te geven.

## 1.3. Doelgroep

Stakeholders vanuit de HAN betrokken bij de casus ICDE en degene die de casus uitvoeren.

<font size="1">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>

# 2. Functionele Omschrijving

Om goed te begrijpen wat het te ontwikkelen systeem(SUD) moet gaan doen, zijn er op basis van de initiële casus beschrijving: “Intergrated Course Design Environment” en op basis van een domein onderzoek vragen gesteld aan de stakeholders. De uitkomsten resulteren in een functioneel eisenpakket. Als toevoeging van dit eisenpakket is er in de volgende paragraaf een beknopte functionele beschrijving opgenomen om te toetsen of de interpretatie van de klantvraag juist is.

## 2.1. Systeemfunctie

**Bilbiotheek** </br>
Dit systeem zal primair semesterontwikkelaars ondersteunen met het ontwikkelen van één of meerdere semesters. Om deze ondersteuning te kunnen bieden zal het systeem gevoed moeten worden met informatie over de vakken, beoordelingscriteria en lesmethoden. Onze aanname is ook dat het systeem ook een bibliotheek functie vervuld waaruit geput kan worden om een semester samen te stellen. Deze bibliotheek wordt gevuld door de semesterontwikkelaars zelf. Het systeem ziet erop toe dat het vullen op een eenduidige en consistente manier gebeurt.

**Ontwikkelproces** </br>
Tijdens het ontwikkelproces zal de bibliotheek groeien. Een semester moet voldoen aan voldoende inhoud, en deze inhoud moet op zijn beurt weer genoeg waarde hebben voor een bepaald aantal studiepunten (EC’S). Het systeem bewaakt de gestelde course eisen en zal deze eisen actief afdwingen.

**Kwaliteit** </br>
Om kwaliteit van het ontwikkelde semester of het semester in ontwikkeling te waarborgen zal het systeem de mogelijkheid bieden om inzagen te geven aan derden bijv. management, docenten of onderwijskundigen.

**Externe ondersteuning** </br>
Bij ontwikkelen van een semester wordt ook informatie verzameld over studiebelasting, beoordelingscriteria per vak of onderdeel en de samenstelling van een semester. Al deze informatie is nuttig voor studenten, roostermakers of voor marketing. Daarom zal het systeem voorbereid worden om deze informatie te distribueren naar andere systemen.

<font size="1">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>

# 3. Use Cases

Binnen het hoofdstuk use cases zullen wij ons richten op het identificeren en vastleggen van use cases. Het in kaart brengen doen wij volgens de Larman methode, deze begint met het het vaststellen van de scope. Vervolgens zullen wij over gaan tot de daadwerkelijke use case identificatie, dit doen wij middels de “User-Goal” en “Event Analysis” methoden. Het vastleggen van dit proces doen wij zodat de oorsprong van de use cases systematisch te herleiden valt.

De in kaart gebrachte use cases worden waar nodig uitgewerkt tot een daadwerkelijke tekstuele use case, ofte wijl een use case in fully dressed format. Vervolgens sluiten wij dit hoofdstuk af met een use case diagram, een visuele weergave van hoe de use cases zich tot elkaar verhouden. 

## 3.1. Scope

---
:warning: **_NOTE:_**
Kort toelichten wat externe en interne functionaliteit is.

---

## 3.2. Crud Use Cases

Veel van de use cases bevatten overeenkomende functionaliteit, namelijk een standaard implementatie voor het aanmaken, lezen, updaten en verwijderen van data. Deze standaard implementatie hebben wij eenmalig vastgelegd in een viertal use cases, deze use cases zien [hier](./crud.md) in te zien.

## 3.3. Use Cases

Middels verschillende use case identificatie technieken (zoals ..., ... &  ...) hebben wij belangrijke entiteiten, actoren en hun doelen weten te identificeren. Uit deze informatie hebben wij een aantal use cases weten te extraheren, waar nodig worden deze in onderstaande toegelicht middels een “fully dressed” formaat. Het fully dressed use case model is gebasseerd op het meest wijd geadoppteerde template van Alistair Cockburn (Larman 2004, 6.8).

Niet alle use cases zijn even complex, sommige use cases zijn gebasseerd op basis van de in hoofdstuk 3.2 gedefineerd CRUD use cases. Voor deze use cases worden alleen afwijkingen/specificiteiten vastlegd.

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
}

d --> UC11
d --> UC10
d --> UC12
d --> UC13
d --> UC21
UC21 <.. UC14 : extends
d --> UC22
d --> UC1
UC1 <.. UC17 : <<extends>>
UC1 <.. UC16 : extends
d --> UC15
d --> UC19
d --> UC4
UC4 <.. UC3 : extends
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

Binnen het domein model richten wij ons op het verstaan van de business taal, hetgeen dat van belang is de vastlegging van concepten, hun attributen en de relatie tussen deze concepten. Het domein model zelf is een visuele representatie van het business domein al zullen wij ons eerst richten op de identificatie van de concepten. De vastlegging hiervan is tekstueel, de reden voor de vastleggen is dat oorsprong van alle concepten zo te herleiden valt.

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

---
:warning: **_CRITERIA:_**
alle relevante domein-concepten volledig beschreven dmv. correct toegepaste standaard-notatie, implementatie-onafhankelijk, correctheid/compleetheid aantoonbaar onderbouwd voor een 10

---

<font size="1">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>

# 5. Bronnen

|APA Bronvermelding|
|------------------|
|{Larman}
|{Handboek Requirements, Nicole de Zwart}

<font size="1">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>
<style>
/* Use case table sytles */

.main {
    color: black;
    background-color: #95c9bb;
}

.secondary {
    color: white;
    background-color: #6c7875; 
}

.key {
    font-weight: bold;
}
</style>

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
1. [Inleiding](#1-inleiding-👆-inhoudsopgave) </br>
    1.1. [Aanleiding](#11-aanleiding) </br>
    1.2. [Doelstelling](#12-doelstelling) </br>
    1.3. [Doelgroep](#13-doelgroep) </br>
2. [Functionele omschrijving](#2-functionele-omschrijving-👆-inhoudsopgave) </br>
    2.1. [Systeemfunctie](#21-systeemfunctie) </br>
3. [Use Cases](#3-use-cases-👆-inhoudsopgave) </br>
    3.1. [Scope](#31-scope) </br>
    3.2. [Use Case Identificatie](#32-use-case-indentificatie) </br>
    3.3. [Crud Use Cases](#33-crud-use-cases) </br>
    3.4. [Use Cases](#34-use-cases) </br>
    3.5. [Use Case Diagram](#35-use-case-diagram) </br>
4. [Domein Model](#4-domain-model-👆-inhoudsopgave)) </br>
    4.1. [Concept Identificatie](#41-concept-identificatie) </br>
    4.2. [Het model](#42-het-model) </br>
5. [Prioritering (MoSCoW)](#5-prioritering-moscow-👆-inhoudsopgave) </br>
6. [Bronnen](#6-bronnen-👆-inhoudsopgave)

# 1. Inleiding <font size="2">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>

## 1.1. Aanleiding
De aanleiding voor het schrijven van dit functioneel ontwerp is de wens vanuit de organisatie de HAN namens semester ontwikkelaars om een systeem te kunnen gebruiken dat hun assisteert bij het ontwikkelen van een course.

## 1.2. Doelstelling
Het doel van het document is het in detail vastleggen van een functionele omschrijving, abstract van enige techniek of implementatie zodat het document kan dienen als input voor de ontwikkeling van een passende oplossing zonder hier zelf al invulling aan te geven.

## 1.3. Doelgroep
Stakeholders vanuit de HAN betrokken bij de casus ICDE en degene die de casus uitvoeren.

# 2. Functionele Omschrijving <font size="2">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>
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

# 3. Use Cases <font size="2">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>
Binnen het hoofdstuk use cases zullen wij ons richten op het identificeren en vastleggen van use cases. Het in kaart brengen doen wij volgens de Larman methode, deze begint met het het vaststellen van de scope. Vervolgens zullen wij over gaan tot de daadwerkelijke use case identificatie, dit doen wij middels de “User-Goal” en “Event Analysis” methoden. Het vastleggen van dit proces doen wij zodat de oorsprong van de use cases systematisch te herleiden valt.

De in kaart gebrachte use cases worden waar nodig uitgewerkt tot een daadwerkelijke tekstuele use case, ofte wijl een use case in fully dressed format. Vervolgens sluiten wij dit hoofdstuk af met een use case diagram, een visuele weergave van hoe de use cases zich tot elkaar verhouden. 

## 3.1. Scope

---
:warning: **_NOTE:_**
Kort toelichten wat externe en interne functionaliteit is.

---

## 3.2. Crud Use Cases

---
:warning: **_NOTE:_**
Nog valideren tegen over use case model dat in onderwijs online staat.

---

### 3.2.1 UC-## - Create
<table>
    <tr>
        <td class="main" colspan="2">UC-## - Create</td>
    </tr>
    <tr>
        <td class="key" >ID</td> <td>UC-##</td>
    </tr>
    <tr>
        <td class="key">Naam</td> <td>Create</td>
    </tr>
    <tr>
        <td class="key">Omschrijving</td> <td>Standaard "Create" use case</td>
    </tr>
    <tr>
        <td class="key">Pre-Conditities</td> <td>null</td>
    </tr>
    <tr>
        <td class="key">Succes definitie</td> <td>De data voor het desbetreffende object is persistent opgeslagen.</td>
    </tr>
    <tr>
        <td class="main" colspan="2">Main Success Scenario</td>
    </tr>
    <tr>
        <td class="secondary">Actor</td> <td class="secondary">System</td>
    </tr>
    <tr>
        <td>1. De gebruiker besluit data voor een gegeven object vast te leggen. </td> <td></td>
    </tr>
    <tr>
        <td></td> <td>2. Het systeem vraagt de gebruiker om de benodigde data in te vullen.</td>
    </tr>
    <tr>
        <td>3. De gebruiker voorziet het systeem van de benodigde data.</td> <td></td>
    </tr>
    <tr>
        <td>4. De gebruiker besluit de data persistent te willen maken.</td> <td></td>
    </tr>
    <tr>
        <td></td> <td>5. Het systeem voert validaties uit.</td>
    </tr>
    <tr>
        <td></td> <td>6. Het systeem persisteert de opgegeven data.</td>
    </tr>
    <tr>
        <td></td> <td>7. Het systeem attendeert de gebruiker op het feit dat de data succesvol is opgeslagen.</td>
    </tr>
    <tr>
        <td style="font-style: italic">De gebruiker herhaalt de stappen 1 t/m 7 totdat alle gewenste data is vastgelegd.</td> <td></td>
    </tr>
    <tr>
        <td class="main" colspan="2">Alternative Flow A</td>
    </tr>
    <tr>
        <td colspan="2">
        5a. [De gegevens blijken niet valide te zijn] <br>
            1.	Het systeem attendeert de gebruiker op het  feit dat de invoer niet valide is en de reden daarvoor.
        </td>
    </tr>
    <tr>
        <td colspan="2">
        6a. [De persistentie tier blijkt is niet beschikbaar] <br>
            1.	Het systeem geeft aan dat het object niet succesvol opgeslagen is.
        </td>
    </tr>
</table>

### 3.2.2 UC-## - Read
<table>
    <tr>
        <td class="main" colspan="2">UC-## - Read</td>
    </tr>
    <tr>
        <td class="key" >ID</td> <td>UC-##</td>
    </tr>
    <tr>
        <td class="key">Naam</td> <td>Read</td>
    </tr>
    <tr>
        <td class="key">Omschrijving</td> <td>Standaard "Read" use case</td>
    </tr>
    <tr>
        <td class="key">Pre-Conditities</td> <td>De create use case is doorlopen voor de objecten dat men wilt tonen.</td>
    </tr>
    <tr>
        <td class="key">Succes definitie</td> <td>Alle data van het desbetreffende object is aan de eindgebruiker getoont.</td>
    </tr>
    <tr>
        <td class="main" colspan="2">Main Success Scenario</td>
    </tr>
    <tr>
        <td class="secondary">Actor</td> <td class="secondary">System</td>
    </tr>
    <tr>
        <td>1. De gebruiker vraagt een overzicht van de gewenste objecten op. </td> <td></td>
    </tr>
    <tr>
        <td></td> <td>2. Het systeem toont een lijst van de opgevraagde informatie.</td>
    </tr>
    <tr>
        <td>3. De gebruiker kiest een object uit de lijst waar men gedetailleerde informatie van wilt zien.</td> <td></td>
    </tr>
    <tr>
        <td></td> <td>4. Het systeem toont alle beschikbare informatie voor het desbetreffende object.</td>
    </tr>
    <tr>
        <td style="font-style: italic">De gebruiker herhaalt de stappen 1 t/m 4 totdat alle gewenste data is gewijzigd.</td> <td></td>
    </tr>
    <tr>
        <td class="main" colspan="2">Alternative Flow A</td>
    </tr>
    <tr>
        <td colspan="2">
        2a/4a. [De persistentie tier blijkt is niet beschikbaar] <br>
            1.	Het systeem geeft aan dat de benodigde data niet opgehaald kon worden.
        </td>
    </tr>
</table>

### 3.2.3 UC-## - Update
<table>
    <tr>
        <td class="main" colspan="2">UC-## - Update</td>
    </tr>
    <tr>
        <td class="key" >ID</td> <td>UC-##</td>
    </tr>
    <tr>
        <td class="key">Naam</td> <td>Update</td>
    </tr>
    <tr>
        <td class="key">Omschrijving</td> <td>Standaard "Update" use case</td>
    </tr>
    <tr>
        <td class="key">Pre-Conditities</td> <td>De gebruiker heeft de read use case doorlopen.</td>
    </tr>
    <tr>
        <td class="key">Succes definitie</td> <td>De wijzigingen zijn persistent opgeslagen.</td>
    </tr>
    <tr>
        <td class="main" colspan="2">Main Success Scenario</td>
    </tr>
    <tr>
        <td class="secondary">Actor</td> <td class="secondary">System</td>
    </tr>
    <tr>
        <td>1. De gebruiker besluit het desbetreffende object te wijzigen. </td> <td></td>
    </tr>
    <tr>
        <td></td> <td>2. Het toont een formulier waarin men data kan wijzigen, het formulier is alvast ingevuld met de al aanwezige data. </td>
    </tr>
    <tr>
        <td>3. De gebruiker past de data naar wens aan.</td> <td></td>
    </tr>
    <tr>
        <td>4. De gebruiker besluit de data persistent te willen maken.</td> <td></td>
    </tr>
    <tr>
        <td></td> <td>5. Het systeem voert validaties uit.</td>
    </tr>
    <tr>
        <td></td> <td>6. Het systeem persisteert de opgegeven data.</td>
    </tr>
    <tr>
        <td></td> <td>7. Het systeem attendeert de gebruiker op het feit dat de data succesvol is opgeslagen.</td>
    </tr>
    <tr>
        <td style="font-style: italic">De gebruiker herhaalt de stappen 1 t/m 7 totdat alle gewenste data is gewijzigd.</td> <td></td>
    </tr>
    <tr>
        <td class="main" colspan="2">Alternative Flow A</td>
    </tr>
    <tr>
        <td colspan="2">
        5a [De gegevens blijken niet valide te zijn] <br>
            1.	Het systeem attendeert de gebruiker op het  feit dat de invoer niet valide is en de reden daarvoor.
        </td>
    </tr>
    <tr>
        <td colspan="2">
        6a. [De persistentie tier blijkt is niet beschikbaar] <br>
            1.	Het systeem geeft aan dat het object niet succesvol opgeslagen is.
        </td>
    </tr>
</table>

### 3.2.4 UC-## - Update
<table>
    <tr>
        <td class="main" colspan="2">UC-## - Delete</td>
    </tr>
    <tr>
        <td class="key" >ID</td> <td>UC-##</td>
    </tr>
    <tr>
        <td class="key">Naam</td> <td>Delete</td>
    </tr>
    <tr>
        <td class="key">Omschrijving</td> <td>Standaard "Delete" use case</td>
    </tr>
    <tr>
        <td class="key">Pre-Conditities</td> <td>De gebruiker heeft de "Read" use case doorlopen.</td>
    </tr>
    <tr>
        <td class="key">Succes definitie</td> <td>De data van het desbetreffende object is verwijderd.</td>
    </tr>
    <tr>
        <td class="main" colspan="2">Main Success Scenario</td>
    </tr>
    <tr>
        <td class="secondary">Actor</td> <td class="secondary">System</td>
    </tr>
    <tr>
        <td>1. De gebruiker besluit het desbetreffende object te verwijderen. </td> <td></td>
    </tr>
    <tr>
        <td></td> <td>2. Het systeem vraagt om een bevestiging. </td>
    </tr>
    <tr>
        <td>3. De gebruiker bevestigd het object te willen verwijderen.</td> <td></td>
    </tr>
    <tr>
        <td></td> <td>4. Het systeem voert validaties uit.</td>
    </tr>
    <tr>
        <td></td> <td>5. Het systeem verwijdert het object.</td>
    </tr>
    <tr>
        <td></td> <td>6. Het systeem attendeert de gebruiker op het feit dat het object succesvol verwijderd is.</td>
    </tr>
    <tr>
        <td style="font-style: italic">De gebruiker herhaalt de stappen 1 t/m 6 totdat alle gewenste verwijderingen zijn uitgevoerd.</td> <td></td>
    </tr>
    <tr>
        <td class="main" colspan="2">Alternative Flow A</td>
    </tr>
    <tr>
        <td colspan="2">
        4a [Het object blijkt (nog) niet verwijderd te kunnen worden.] <br>
            1.	1.	Het systeem attendeert de gebruiker op de reden waarom het object niet verwijderd kon worden.
        </td>
    </tr>
    <tr>
        <td colspan="2">
        5a. [De persistentie tier blijkt is niet beschikbaar] <br>
            1.	1.	Het systeem geeft aan dat het object niet succesvol verwijderd is.
        </td>
    </tr>
</table>

## 3.3. Use Cases
In het voorafgaande hoofdstuk hebben wij middels verschillende use case identificatie technieken belangrijke entiteiten, actoren en hun doelen weten te identificeren. Uit deze informatie hebben wij een aantal use cases weten te extraheren (2.2.3), waar nodig worden deze in onderstaande toegelicht middels een “fully dressed” formaat. Het fully dressed use case model is gebasseerd op het meest wijd geadoppteerde template van Alistair Cockburn (Larman 2004, 6.8).

### Use Case Overview
- [UC-1 - {Titel}](#331-uc-1-titel-👆-overview)


### 3.3.1 UC-1 {Titel} <font size="2">[:point_up_2: [Overview](#use-case-overview)]</font>
---
:warning: **_CRITERIA:_**
alle functionele requirements volledig, eenduidig, begrijpelijk en testbaar beschreven

---

---
:warning: **_NOTE:_**
- Use case nummeren maar ook binnen de use case. 
- alleen de compleze use cases 
- Bij complexe use cases een sequence diagram opnemen.

---

## 3.4. Use Case Diagram

---
:warning: **_NOTE:_**
Use case diagram maken, om verband tussen use cases inzichtelijk te maken. Hier wel alle use cases opnemen

---

# 4. Domain Model <font size="2">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>
Binnen het domein model richten wij ons op het verstaan van de business taal, hetgeen dat van belang is de vastlegging van concepten, hun attributen en de relatie tussen deze concepten. Het domein model zelf is een visuele representatie van het business domein al zullen wij ons eerst richten op de identificatie van de concepten. De vastlegging hiervan is tekstueel, de reden voor de vastleggen is dat oorsprong van alle concepten zo te herleiden valt.

---
:warning: **_CRITERIA:_**
alle relevante domein-concepten volledig beschreven dmv. correct toegepaste standaard-notatie, implementatie-onafhankelijk, correctheid/compleetheid aantoonbaar onderbouwd voor een 10

---


# 5. Prioritering (MoSCoW) <font size="2">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>
In onderstaande is een opsomming weergegeven van alle use cases gekoppeld aan de importantie op basis van de MoSCoW methode (Nicole de Zwart, Prioriteringstechnieken).

|#|Use Case|Prioriteit|Toelichting|
|-|--------|----------|-----------|
|1|{Titel}|{M, S, C, W}|{Toelichting}|


# 6. Bronnen <font size="2">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>
{Larman}
{Handboek Requirements, Nicole de Zwart}


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
| | |
|-|-|
| ID | UC-## |
| Naam | Create |
| Omschrijving | Standaard "Craete" use case |
| Pre-Conditities | null |
| Succes definitie | De data voor het desbetreffende object is persistent opgeslagen. |
| <font size="4"> **Main Success Scenario** </font>
| **Actor** | **System** |
| 1. De gebruiker besluit data voor een gegeven object vast te leggen. | |
| | 2. Het systeem vraagt de gebruiker om de benodigde data in te vullen. |
| 3. De gebruiker voorziet het systeem van de benodigde data. | |
| 4. De gebruiker besluit de data persistent te willen maken. | |
| | 5. Het systeem voert validaties uit.|
| | 6. Het systeem persisteert de opgegeven data. |
| | 7. Het systeem attendeert de gebruiker op het feit dat de data succesvol is opgeslagen. |
| *De gebruiker herhaalt de stappen 1 t/m 7 totdat alle gewenste data is vastgelegd.* | |
| <font size="4"> **Alternative Flow A** </font>
| 5a. [De gegevens blijken niet valide te zijn] <br> 1.	Het systeem attendeert de gebruiker op het  feit dat de invoer niet valide is en de reden daarvoor.
| 6a. [De persistentie tier blijkt is niet beschikbaar] <br> 1.	Het systeem geeft aan dat het object niet succesvol opgeslagen is.

### 3.2.2 UC-## - Read
| | |
|-|-|
| ID | UC-## |
| Naam | Read |
| Omschrijving | Standaard "Read" use case |
| Pre-Conditities | De create use case is doorlopen voor de objecten dat men wilt tonen. |
| Succes definitie | Alle data van het desbetreffende object is aan de eindgebruiker getoont. |
| <font size="4"> **Main Success Scenario** </font>
| **Actor** | **System** |
| 1. De gebruiker vraagt een overzicht van de gewenste objecten op.| |
| | 2. Het systeem toont een lijst van de opgevraagde informatie. |
| 3. De gebruiker kiest een object uit de lijst waar men gedetailleerde informatie van wilt zien. | |
| | 4. Het systeem toont alle beschikbare informatie voor het desbetreffende object. |
| *De gebruiker herhaalt de stappen 1 t/m 4 totdat alle gewenste data is gewijzigd.* | |
| <font size="4"> **Alternative Flow A** </font>
| 2a/4a. [De persistentie tier blijkt is niet beschikbaar] <br> 1.Het systeem geeft aan dat de benodigde data niet opgehaald kon worden.

### 3.2.3 UC-## - Update
| | |
|-|-|
| ID | UC-## |
| Naam | Update |
| Omschrijving | Standaard "Update" use case |
| Pre-Conditities | De gebruiker heeft de "Read" use case doorlopen. |
| Succes definitie | De wijzigingen zijn persistent opgeslagen. |
| <font size="4"> **Main Success Scenario** </font>
| **Actor** | **System** |
| 1. De gebruiker besluit het desbetreffende object te wijzigen.| |
| |2. Het toont een formulier waarin men data kan wijzigen, het formulier is alvast ingevuld met de al aanwezige data. |
| 3. De gebruiker past de data naar wens aan.| |
| 4. De gebruiker besluit de data persistent te willen maken. | |
| | 5. Het systeem voert validaties uit.|
| | 6. Het systeem persisteert de opgegeven data.|
| | 7. Het systeem attendeert de gebruiker op het feit dat de data succesvol is opgeslagen.|
| *De gebruiker herhaalt de stappen 1 t/m 7 totdat alle gewenste data is gewijzigd.* | |
| <font size="4"> **Alternative Flow A** </font>
|5a [De gegevens blijken niet valide te zijn] <br> 1.	Het systeem attendeert de gebruiker op het  feit dat de invoer niet valide is en de reden daarvoor. </td>
|6a. [De persistentie tier blijkt is niet beschikbaar] <br> 1.	Het systeem geeft aan dat het object niet succesvol opgeslagen is.

### 3.2.4 UC-## - Delete
| | |
|-|-|
| ID | UC-## |
| Naam | Delete |
| Omschrijving | Standaard "Delete" use case |
| Pre-Conditities | De gebruiker heeft de "Read" use case doorlopen. |
| Succes definitie | De data van het desbetreffende object is verwijderd. |
| <font size="4"> **Main Success Scenario** </font>
| **Actor** | **System** |
| 1. De gebruiker besluit het desbetreffende object te verwijderen.| |
| |2. Het systeem vraagt om een bevestiging. |
| 3. De gebruiker bevestigd het object te willen verwijderen.| |
| | 4. Het systeem voert validaties uit.|
| | 5. Het systeem verwijdert het object.|
| | 6. Het systeem attendeert de gebruiker op het feit dat het object succesvol verwijderd is.|
| *De gebruiker herhaalt de stappen 1 t/m 6 totdat alle gewenste verwijderingen zijn uitgevoerd.* | |
| <font size="4"> **Alternative Flow A** </font>
|4a [Het object blijkt (nog) niet verwijderd te kunnen worden.] <br> 1.	Het systeem attendeert de gebruiker op de reden waarom het object niet verwijderd kon worden. </td>
|5a. [De persistentie tier blijkt is niet beschikbaar] <br> 1.	Het systeem geeft aan dat het object niet succesvol verwijderd is.


## 3.3. Use Cases
In het voorafgaande hoofdstuk hebben wij middels verschillende use case identificatie technieken belangrijke entiteiten, actoren en hun doelen weten te identificeren. Uit deze informatie hebben wij een aantal use cases weten te extraheren (2.2.3), waar nodig worden deze in onderstaande toegelicht middels een “fully dressed” formaat. Het fully dressed use case model is gebasseerd op het meest wijd geadoppteerde template van Alistair Cockburn (Larman 2004, 6.8).

Bevat ook gedrag wat betreft de werking van het domein.

### Use Case Overview
- [UC-1 - {Titel}](#331-uc-1-titel-👆-overview)


### 3.3.10 UC-10 - Ontwikkel Leeruitkomst <font size="2">[:point_up_2: [Overview](#use-case-overview)]</font>
| | |
|-|-|
| ID | UC-10 |
| Naam | Ontwikkel Leeruitkomst  |
| Omschrijving | Deze use case is gebaseerd op het CRUD-template, binnen deze use case worden alleen uitzonderingen of specificiteit belicht. |
| Scope | ICDE-Tool |
| Trigger | Gebruikers Interactie |
| Level | User-Goal |
| Primary Actor | Docent |
| Belangen & belanghebbenden | -	Docent: Wil vast kunnen leggen welke leeruitkomsten er binnen deze EVL behaald moeten worden zodat men hier passende leerdoelen aan kan verbinden. </br> -	Student: Wil deze vastlegging kunnen inzien zodat men weet wat de beoogde leeruitkomsten zijn.
 |
| Pre-Condities | -	De gebruiker is geauthentiseerd als docent. (UC-20) </br> -	De EVL waaraan de leeruitkomst gekoppeld dient te worden bestaat al.
 |
| Requirement| FR-9 |
| <font size="4"> **Afwijkende specificiteiten** </font>
| **Create/Update:** De benodigde data zijn een titel, omschrijving & EVL waaronder de leeruitkomst zal vallen, het systeem valideert of in deze databehoefte voorzien is.
| **Delete:** Het systeem controleer of er nog leerdoelen verbonden zijn aan de leeruitkomst, een leeruitkomst kan alleen verwijderd worden indien dit niet het geval is.


### 3.3.12 UC-12 - Ontwikkel leerdoelen <font size="2">[:point_up_2: [Overview](#use-case-overview)]</font>
| | |
|-|-|
| ID | UC-12 |
| Naam | Ontwikkel Leerdoelen  |
| Omschrijving | Deze use case is gebaseerd op het CRUD-template, binnen deze use case worden alleen uitzonderingen of specificiteit belicht. |
| Scope | ICDE-Tool |
| Trigger | Gebruikers Interactie |
| Level | User-Goal |
| Primary Actor | Docent |
| Belangen & belanghebbenden | -	Docent: Wil kunnen vastleggen welke leerdoelen er behaald moeten worden om tot een bepaalde leeruitkomst te kunnen komen. </br> -	Student: Wil kunnen inzien wat de beoogde leerdoelen zijn. |
| Pre-Condities | -	De docent is geauthentiseerd. (UC-20) </br> -	De leeruitkomst waaraan het leerdoel verbonden zal worden bestaat al. |
| Requirement| FR-11 |
| <font size="4"> **Afwijkende specificiteiten** </font>
| **Create/Update:** De benodigde data zijn een titel, omschrijving & leeruitkomst waaraan het leerdoel gerelateerd is, het systeem valideert of in deze databehoefte voorzien is.
| **Delete:** Het systeem controleer of er nog lessen of tentamens verbonden zijn aan het leerdoel, een leerdoel kan alleen verwijderd worden indien dit niet het geval is.

### 3.3.4 UC-4 - Beheer Klassen<font size="2">[:point_up_2: [Overview](#use-case-overview)]</font>
| | |
|-|-|
| ID | UC-4 |
| Naam | Beheer Klassen  |
| Omschrijving | Deze use case is gebaseerd op het CRUD template, binnen deze use case worden alleen uitzonderingen of specificiteit belicht. |
| Scope | ICDE-Tool |
| Trigger | Gebruikers Interactie |
| Level | User-Goal |
| Primary Actor | Docent |
| Belangen & belanghebbenden | -	Docent: Wil een klas registratie kunnen bijhouden zodat deze klas een course kan volgen. </br> -	Student: Wil onderdeel kunnen zijn van een klas registratie zodat hij/zij de course informatie van de courses die de klas volgt kan inzien. |
| Pre-Condities | -	De docent is geauthentiseerd. (UC-20) </br> -	Het benodigde opleidingsprofiel is al aangemaakt. (UC-9) |
| Requirement| FR-29 |
| <font size="4"> **Afwijkende specificiteiten** </font>
| **Create/Update:** De benodigde data zijn een klas-id een naam voor de klas en een opleidingsprofiel dat de klas volgt, het systeem valideert of in deze databehoefte voorzien is.
| **Delete:** Het systeem controleer of er nog student onderdeel zijn van de klas en als deze gekoppeld is aan een course, een klas kan alleen verwijderd worden indien dit niet het geval is.

---
:warning: **_NOTE:_**
Een klas volgt een course maar technisch gezet wordt er tijdens het toevoegen van de klas aan de course iedere student individueel aan de course verbonden een student kan namelijk wisselen van klas en of blijven zitten. --> verwerken in UC-15 “Start Uitvoering”

---

### 3.3.3 UC-3 - Beheer Gebruikers <font size="2">[:point_up_2: [Overview](#use-case-overview)]</font>
| | |
|-|-|
| ID | UC-3 |
| Naam | Beheer Gebruikers  |
| Omschrijving | Deze use case is gebaseerd op het CRUD-template, binnen deze use case worden alleen uitzonderingen of specificiteit belicht. |
| Scope | ICDE-Tool |
| Trigger | Gebruikers Interactie |
| Level | User-Goal |
| Primary Actor | Docent |
| Belangen & belanghebbenden | -	Docent: Wil een klas indeling kunnen bijhouden zodat studenten toegang krijgen tot het bijhorende course materiaal. </br> -	Student: Wil onderdeel zijn van een klas zodat men toegang krijgt tot het bijhorende course materiaal. |
| Pre-Condities | -	De docent is geauthentiseerd. (UC-20) </br>-	De desbetreffende klas waarvan de student lid moet worden bestaat al. (UC-4) |
| Requirement| FR-4 |
| <font size="4"> **Afwijkende specificiteiten** </font>
| **Create/Update:** De benodigde data zijn een naam, email adres en in het geval van een student ook een klas, het systeem valideert of in deze databehoefte voorzien is.
| **Delete:** In het geval van een student verwijdert het systeem de student en alle persoons informatie zoals eventuele beoordelingen voor tentamens die hij/zij behaalt heeft. In het geval van een docent wordt er gekeken of de docent gerelateerd is aan een entiteit binnen het systeem, zoals een beoordeling, les of tentaminering, als dit een geval is kan de docent niet verwijderd worden.

### 3.3.7 UC-7 - Beheer Opleidingen <font size="2">[:point_up_2: [Overview](#use-case-overview)]</font>
| | |
|-|-|
| ID | UC-7 |
| Naam | Beheer Opleidingen  |
| Omschrijving | Deze use case is gebaseerd op het CRUD template, binnen deze use case worden alleen uitzonderingen of specificiteit belicht. |
| Scope | ICDE-Tool |
| Trigger | Gebruikers Interactie |
| Level | User-Goal |
| Primary Actor | Docent |
| Belangen & belanghebbenden | - Docent: Wil beschikbare opleidingen kunnen bijhouden zodat … |
| Pre-Condities | - De docent is geauthentiseerd. (UC-20) |
| Requirement| FR-29 |
| <font size="4"> **Afwijkende specificiteiten** </font>
| **Create/Update:** De benodigde data zijn een id en een naam, het systeem valideert of in deze databehoefte voorzien is.
| **Delete:** Het systeem controleert of er nog opleidingsprofielen gekoppeld zijn, een opleiding kan alleen verwijderd worden indien dit niet het geval is.

### 3.3.9 UC-9 - Beheer Opleidingsprofielen <font size="2">[:point_up_2: [Overview](#use-case-overview)]</font>
| | |
|-|-|
| ID | UC-9 |
| Naam | Beheer Opleidingsprofielen  |
| Omschrijving | Deze use case is gebaseerd of het CRUD-template, binnen deze use case worden alleen uitzonderingen of specificiteit belicht.|
| Scope | ICDE-Tool |
| Trigger | Gebruikers Interactie |
| Level | User-Goal |
| Primary Actor | Docent |
| Belangen & belanghebbenden | - Docent: Wil beschikbare opleidingsprofielen kunnen bijhouden zodat … |
| Pre-Condities | -	De docent is geauthentiseerd. (UC-20) </br>- De desbetreffende opleiding waarvan onderdeel moet zijn bestaat al. (UC-7) |
| Requirement | FR-29 |
| <font size="4"> **Afwijkende specificiteiten** </font>
| **Create/Update:** De benodigde data zijn een id en een naam, het systeem valideert of in deze databehoefte voorzien is.
| **Delete:** Het systeem controleert of er nog klassen gekoppeld zijn aan het huidige profiel, een opleidingsprofiel kan alleen verwijderd worden indien dit niet het geval is.

### 3.3.20 UC-20 - Aanmelden <font size="2">[:point_up_2: [Overview](#use-case-overview)]</font>
| | |
|-|-|
| ID | UC-20 |
| Naam | Aanmelden |
| Omschrijving | Deze use case is verantwoordelijk voor het autoriseren en eventueel registreren van systeem gebruikers. Authenticatie valt buiten de scope van deze use case. |
| Scope | ICDE-Tool |
| Trigger | Authenticatie service |
| Level | User-Goal |
| Primary Actor | Student / Docent |
| Belangen & belanghebbenden | -	Student / Docent: Wil kunnen inloggen en de acties waar tot zij bevoegd is kunnen uitvoeren. </br> - Docent: Wil studenten kunnen toevoegen aan een klas en docenten kunnen verbinden aan een les en of tentamen. |
| Pre-Condities | -	Authenticatie is afgehandeld; gebruiker is bevoegd om op het systeem in te loggen. |
| Succes definitie| -	Een representatie van de desbetreffende gebruiker is persistent opgeslagen. </br> -	Er is een bevoegdheid toegekend aan de gebruiker voor de resterende duur van het bezoek. |
| Requirement| Van toepassing op vrijwel alle requirements |
| <font size="4"> **Main Success Scenario** </font>
| **Actor** | **System** |
| *[Bezoeker is doorverwezen door extern authenticatie systeem en heeft een claim verkregen]* </br> 1. Verzend authenticatie claim naar systeem. | |
| | 2. Het systeem bekijkt op basis van de van het authenticatie systeem verkregen gegevens wat van type gebruiker het betreft; docent of student. |
| | 3. Het systeem bekijkt of de gebruiker al bestaat binnen het systeem op basis van het email adres. </br> *[De gebruiker bestaat nog niet]* |
| | 4. Het systeem registreert de gebruiker|
| | 5. Het systeem verleent de gebruiker toegang voor de duur van het bezoek. |
| | 6. De gebruiker wordt verwezen naar de plek die men initieel bezocht. |
| *x* 
| <font size="4"> **Alternative Flow A** </font>
| 3a. *[De gebruiker bestaat al]* </br> 1.	Het systeem controleert of het gebruikerstype gewijzigd is. </br> *[Het gebruiker type is gewijzigd]* </br> 2.	Het systeem overschrijft het huidige gebruikerstype met het nieuwe gebruikerstype. </br> *Ga verder bij stap 5.*
| 3b. *[De gebruiker bestaat al]* </br> 1.	Het systeem controleert of het gebruikerstype gewijzigd is. </br> *[Het gebruiker type is niet gewijzigd]* </br> *Ga verder bij stap 5*

### 3.3.2 UC-2 - Bekijken beoordelingen <font size="2">[:point_up_2: [Overview](#use-case-overview)]</font>
| | |
|-|-|
| ID | UC-2 |
| Naam | Bekijken beoordelingen |
| Omschrijving | Deze use case is verantwoordelijk voor het inzichtelijk maken van beoordelingen voor studenten. |
| Scope | ICDE-Tool |
| Trigger | Gebruikers Interactie |
| Level | User-Goal |
| Primary Actor | Student |
| Belangen & belanghebbenden | - Student: Wil zijn/haar voorgang en behaalde resultaten kunnen bekijken. |
| Pre-Condities | -	Authenticatie is afgehandeld; gebruiker is bevoegd om op het systeem in te loggen. |
| Succes definitie| -	Er word een overzicht getoond van de course voortang in de vorm van een lijst van behaalde resultaten en het aantal behaalde studiepunten ten opzichte van het totaal haalbare aantal studiepunten.  |
| Requirement| FR-38 |
| <font size="4"> **Main Success Scenario** </font>
| **Actor** | **System** |
| 1. De student vraagt aan het systeem om een overzicht van alle beoordelingen. | |
| | 2. Het systeem haalt alle tentamineringen van de student op (ook die waarvoor nog geen beoordeling behaald is). |
| | 3. Het systeem categoriseert de beoordelingen per course uitvoering. |
| | 4. Het systeem berekent per course uitvoering het behaalde aantal studiepunten en de eindbeoordeling voor de course. (Een optelsom van de voorgeschreven studiepunten van de tentamineringen die onderdeel zijn van de desbetreffende course en voldoende afgerond zijn door de student) |
| | 5. Het systeem toont een overzicht van alle beoordelingen. |
| <font size="4"> **Alternative Flow A** </font>
| 2. *[De student heeft nog geen enkele course gevolgd]* </br> 1. Het systeem toont dat er geen resultaten gevonden zijn.

### 3.3.17 UC-17 - Maak Weekplanning <font size="2">[:point_up_2: [Overview](#use-case-overview)]</font>
| | |
|-|-|
| ID | UC-17 |
| Naam | Maak Weekplanning |
| Omschrijving | In een weekplanning worden lessen en tentamens verbonden aan een courseweek. |
| Scope | ICDE-Tool |
| Trigger | Gebruikers Interactie |
| Level | User-Goal |
| Primary Actor | Docent |
| Belangen & belanghebbenden | - Docent: wil een weekplanning maken van alle lessen, toetsen en tentamens in een course |
| Pre-Condities | - Course met alle bijbehorende onderdelen is aangemaakt |
| Requirement| FR-1, FR-18 |
| <font size="4"> **Main Success Scenario** </font>
| **Actor** | **System** |
| 1. De docent geeft aan een planning op te willen stellen. | |
| | 2. Het systeem toont een lijst van alle course weken en vraagt de gebruiker lessen en/of tentamens toe te wijzen aan deze weken. |
| 3. De docent wijst alle lessen en tentamens toe aan een lesweek. | |
| 4. De docent geeft aan de planning te willen opslaan. | |
| | 5. Het systeem controleert of elke les en alle tentamens toegewezen zijn aan een week. |
| | 6. Het systeem controleert of de tentamens voor een leerdoel ingepland zijn na alle lessen voor het gegeven gegeven lesdoel. |
| | 7. Het lesdoel wordt persistent opgeslagen. |
| | 8. Het systeem stelt de gebruiker op de hoogte van het feit dat de planning succesvol is opgeslagen. |
| <font size="4"> **Alternative Flow A** </font>
| 5a. *[Niet alle lessen of tentamens zijn toegewezen]* </br> 1. Het systeem attendeert de gebruiker op het feit dat niet alle tentamens en of lessen toegewezen zijn.
| 6a. *[een of meerdere tentamens zijn ingepland voor dat alle bijhorende lessen zijn ingepland]* </br> 1. Het systeem attendeert de gebruiker op het feit dat tentamens alleen ingepland kunnen worden nadat alle lessen voor de aan het tentamen verbonden leerdoelen gegeven zijn. 

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
@startuml
left to right direction
actor "Food Critic" as fc
rectangle Restaurant {
  usecase "Eat Food" as UC1
  usecase "Pay for Food" as UC2
  usecase "Drink" as UC3
}
fc --> UC1
fc --> UC2
fc --> UC3
@enduml


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


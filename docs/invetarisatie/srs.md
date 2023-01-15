[Terug](/README.md)

# Software Requirement Specification

**Opdrachtgever:** De HAN - Hoge School Arnhem Nijmegen</br>
**Datum**: 12-01-2023 </br>
**Studenten**: Thomas Hofman (622438), Ricardo de Wijs (498412)</br>
**Versie**: v0.6 </br>
**Locatie**: Arnhem </br>
**Docent**: John Gorter

# Versiebeheer

|Versie|Beschrijving|Auteur|Datum|
|------|------------|------|-----|
|v0.1|Document opzet & inleidingen|Thomas Hofman|16-09-2022|
|v0.2|Functionele requirements opgezet|Ricardo de Wijs|28-09-2022|
|v0.3|Niet functionele requirements toegevoegd|Thomas Hofman|29-09-2022|
|v0.4|Herformuleren van requirements naar SMART|Thomas Hofman|14-10-2022|
|v0.5|Requirements koppelen aan use cases|Ricardo de Wijs|15-10-2022|
|v0.6|Converteren van docx naar markdown|Thomas Hofman|12-11-2022|
|v1.0|Eerste versie|Thomas Hofman|12-01-2023|

# Inhoudsopgave

1. [Inleiding](#1-inleiding) </br>
    1.1. [Doelstelling](#11-doelstelling) </br>
    1.2. [Doelgroep](#12-doelgroep) </br>
2. [Functional Requirements](#2-functional-requirements) </br>
3. [Non-Functional Requirements (SMART)](#3-non-functional-requirements-smart) </br>
    3.1. [Usability](#31-usability) </br>
    3.2. [Reliability](#32-reliability) </br>
    3.3. [Performance](#33-performance) </br>
    3.4. [Supportability](#34-supportability) </br>
    3.5. [Plus](#35-plus) </br>
4. [Bronnen](#4-bronnen)

# 1. Inleiding

Dit document betreft het software requirements specification document en voorziet in de vastlegging van de functionele en niet functionele eisen, de functionele eisen zijn vastgelegd als user stories, de niet functionele eisen zijn vastgelegd middels de SMART- methode (Specifiek, Meetbaar, Acceptabel, Realistisch, Tijdgebonden). Het SRS-document is een bijlage van zowel het technisch- als het functioneel- ontwerp. De functionele eisen voeden het functioneel ontwerp, het functioneel ontwerp en de non-functional requirements fungeren gezamenlijk als fundering voor het technisch ontwerp.

## 1.1. Doelstelling

Het doel van het document is de vastlegging van de met de stakeholder overeengekomen functionele en niet functionele eisen. De eisen zijn genummerde met FR, Functional Requirement en NFR, Non-Functional Requirement, met het gebruik van deze nummering kan vanuit andere documenten gerefereerd worden naar de desbetreffende requirement.

## 1.2. Doelgroep

Stakeholders vanuit de HAN betrokken bij de casus ICDE en degene die de casus uitvoeren.

<font size="1">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>

# 2. Functional Requirements

In onderstaande zijn de systeem features ofte wijl functional requirements omschreven als user stories. Het user stories format dwingt af dat er context rondom de requirement geboden word door de wie, wat en waarom vragen te beantwoorden. Verbonden aan iedere requirement zijn een of meer vragen uit het "Questions & Answers" document en een of meer use cases waarin de requirement geïmplementeerd word.

|FR-#|Requirement|Prio|Related Question|Related Use Case|
|----|-----------|----|----------------|----------------|
|1|Als docent wil ik een courses kunnen ontwikkelen zodat studenten deze courses kunnen volgen.|Must|1-2|1, 11, 10, 12, 13, 14, 17, 16|
|2|Als docent wil ik de inhoud van een course kunnen bekijken zodat ik relevant data van de course die ik geef kan achterhalen en vorderingen van studenten kan bijwerken.|Must|1-3|5|
|3|Als student wil ik de inhoud van een course kunnen bekijken zodat ik relevant data van de course die ik volg kan achterhalen. |Must|1-3|5|
|4|Als docent wil ik een studenten en klassen registratie kunnen bijhouden zodat ik middels een klas studenten aan een course kan koppelen.|Must|1-4|3,4|
|5|Als docent wil ik kunnen inzien welke lessen ik moet geven zodat ik deze lessen kan voorbereiden.|Must|1-4|5, 6|
|6|Als docent wil ik kunnen inzien welke tentamens ik moet examineren zodat ik weet bij welke tentamens ik aanwezig moet zijn. |Must|1-4|6|
|7|Als docent wil ik beoordelingen voor door studenten gemaakte tentamen kunnen vastleggen zodat ik deze niet hoef te onthouden.|Must|1-4, 2-7|8|
|8|Als student wil ik een course kunnen volgen zodat ik inzage krijg in gerelateerde data en mijn vorderingen. |Must|1-4, 2-6, 2-7|2, 5, 6|
|9|Als docent wil ik leeruitkomsten kunnen bepalen voor de course zodat duidelijk is wat de gewenste uitkomst van de course is.|Must|1-6|10|
|10|Als docent wil ik leeruitkomsten kunnen groeperen in een EVL zodat een course met vele leeruitkomsten overzichtelijk blijft.|Should|1-6|11|
|11|Als docent wil ik leerdoelen kunnen bepalen die bijdragen aan het behalen van een leeruitkomst zodat ik de inhoud van de course kan richten op het behalen van deze doelen.|Must|1-6|12|
|12|Als docent wil ik tentamen in de vorm van schriftelijke toetsen en/of beroepsproducten kunnen toevoegen aan een course zodat ik de leerdoelen binnen de course kan aftoetsen.|Must|1-6, 3-1|13, 14, 21|
|13|Als docent wil ik rubrieken met beoordelingscriteria kunnen bepalen voor een beroepsproduct zodat deze systematisch en objectief is na te kijken|Must|1-6|14|
|14|Als docent wil ik rubrieken kunnen verbinden aan leerdoelen zodat er afgedwongen wordt dat een rubriek een leerdoel af toets|Must|1-6|14|
|15|Als docent wil ik lessen kunnen verbinden aan leerdoelen zodat ik zeker weet dat er voor alle leerdoelen lessen gegeven worden|Must|1-6|22|
|16|Als docent wil ik schriftelijke toetsen kunnen verbinden aan leerdoelen zodat er afgedwongen word dat een schriftelijke toets minimaal een leerdoel aftoetst.|Must|1-6|13|
|17|Als docent kan ik zelf aangeven om wat van type tentamen het gaat zodat duidelijk is wat van soort tentamen men kan verwachten.|Should|1-8|13, 21|
|18|Als docent kan ik aangeven in welke week van de course een les of tentamen plaats vind zodat duidelijk is wanneer de les of het tentamen plaats zal vinden.|Should|1-10|17|
|19|Als docent kan ik zelfstudie uren en contact uren verbinden aan lessen en tentamens zodat de studielast inzichtelijk word.|Should|1-10|13, 21, 22|
|20|Als docent wil ik dat invoer gecontroleerd wordt zodat menselijke invoerfouten voorkomen worden.|Must|1-11|\*|
|21|Als docent wil ik een variabel aantal beoordelingscriteria kunnen toevoegen aan een rubriek (minimaal 2 en maximaal 5) zodat deze rubrieken systematisch afgetoetst kunnen worden. |Must|1-12|14|
|22|Als docent wil ik een weging kunnen specificeren voor rubrieken zodat ik belangrijkere rubrieken zwaarder kan laten meetellen in de eindbeoordeling.|Should|1-12|14|
|23|Als docent wil ik de mogelijkheid hebben om per rubriek een knock-out grens te zetten zodat ik kan afdwingen dat studenten op bepaalde rubrieken een minimale score moeten behalen.|Should|1-12, 1-13|14|
|24|Als docent wil ik commentaar/feedback kunnen toevoegen aan een beoordeling als zodat een student mijn onderbouwing voor de beoordeling kan inzien. |Should|1-13|8|
|25|Als docent/student wil ik een lesmateriaal kunnen exporten naar meerdere formaten zodat ik deze data offline kan consumeren in een format naar keuze.|Could|1-15|18|
|26|Als docent wil ik samen aan een course kunnen werken zodat ik de course niet in mijn eentje hoef te ontwikkelen.|Must|2-1, 2-2|\*|
|27|Als docent wil ik oudere versies van een course kunnen blijven inzien zodat de course inhoud van uitvoeringen gebaseerd op oudere versies van de course inzichtelijk blijven.|Must|2-3|1, 5|
|28|Als docent wil ik alle beschikbare course templates kunnen inzien zodat ik eenvoudig een course kan starten gebaseerd op een van deze templates.|Must|2-4, 2-7|1|
|29|Als docent wil ik een klas kunnen verbinden aan een opleidingsprofiel dat onderdanig is aan een opleiding zodat voor mij duidelijk is in welke context de klas de course volgt. En middels deze klas leerlingen als groep kunnen verbinden aan een course uitvoering.|Would|2-5|4|
|30|Als docent wil ik de inrichting van een course template meerdere malen kunnen uitvoeren zodat de course data niet voor elke uitvoering opnieuw hoef in te voeren. |Must|2-6|15, 16|
|31|Als docent wil ik de inrichting van een course kunnen hergebruiken als basis voor een nieuwere versie zodat ik niet alle inhoud opnieuw hoef aan te maken wanneer ik een soort gelijke course wil ontwikkelen.|Won’t|2-3|23|
|32|Als docent wil ik een course template kunnen uitvoeren zodat ik hier uitvoering gerelateerde data aan kan verbinden zoals een klas, les/tentamen locaties & docenten, beoordelingen en datums.|Must|2-6|15|
|33|Als docent wil ik een locatie kunnen verbinden aan een tentamen en/of les zodat duidelijk is waar dit tentamen of deze les plaats zal vinden.|Should|2-8|15, 19|
|34|Als docent wil ik dat er gecontroleerd wordt of aan elk leerdoel een les en tentamen (schriftelijke toets of beroepsproduct) verbonden is zodat ik zeker weet dat voor elke leerdoel les gegeven is en dat dit afgetoetst word.|Must|2-9|16|
|35|Als docent wil ik lesmateriaal als onderdeel van de lesinhoud kunnen uploaden zodat ik deze inhoud centraal vast leg en eenvoudig kan delen met de studenten.|Should|2-10|22|
|36|Als docent wil ik dat er gecontroleerd wordt of er niet te weinig of teveel studiepunten te behalen zijn voor de duur van de course zodat een passende studielast gegarandeerd word.|Should|2-11|16|
|37|Als docent wil ik een weging voor een tentaminering kunnen bepalen zodat belangrijke toetsen zwaarder wegen in de eindbeoordeling van de course.|Should|1-12|13, 21|
|38|Als student mag ik alleen mijn eigen courses, en beoordelingen inzien zodat ik niet onnodig geïnformeerd word en mijn informatie niet ongewild gedeeld word met mede studenten. |Must|1-4|2, 5, 20|
|39|Als docent wil ik beroepsproducten kunnen beoordelen op basis van de rubrieken met bijhorende beoordelingscriteria zodat ik niet handmatig de eindbeoordeling hoef te berekenen.|Should|1-12|8|
|40|Als student wil ik zien hoeveel studiepunten ik tot nu toe behaald heb zodat ik mijn course progressie kan bijhouden.|Should|2-11|2|

\* *geld voor het gehele systeem.*

<font size="1">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>

# 3. Non-Functional Requirements (SMART)

In onderstaande zijn de non-functional requirements omschreven, deze requirements zijn onderverdeeld in de categorieën volgens het FURPS+ model (Larman 2005) (Functional, Usability, Reliability, Performance, Supportability, Plus).

## 3.1. Usability

|NFR-#|Requirement|Prio|
|-----|-----------|----|
|1|Als docent/student wil ik de applicatie kunnen gebruiken ongeacht mijn locatie zo lang ik een internetverbinding heb.|Must|
|2|Een gebruiker zal zonder voorkennis van het systeem binnen 15 minuten een course inrichting met een toets, en een les kunnen registeren. |Should|
|3|Als docent/student wil ik de applicatie kunnen gebruiken op mijn laptop, tablet en smartphone zonder dat installatie van additionele software vereist is.|Should|

## 3.2. Reliability

|NFR-#|Requirement|Prio|
|-----|-----------|----|
|4|Het systeem moet 95 procent van de tijd beschikbaar zijn per maand gedurende werktijden (9-17).|Would|

## 3.3. Performance

|NFR-#|Requirement|Prio|
|-----|-----------|----|
|5|Weergaven van het systeem moeten laden binnen 1.5 seconden binnen een moderne browser/client met uitzondering van het eerste verzoek per sessie wanneer de applicatie belast word met 100 server verzoeken per seconden. |Must|
|6|Het systeem moet zowel verticaal als horizontaal schaalbaar zijn om bij een toename van load extra resources te kunnen toekennen en een hogere beschikbaarheid te kunnen behalen. |Would|
|7|De applicatie mag zonder gebruikers (idle) niet meer dan 1GB-ram en 1-cpu core vereisen. |Must|

## 3.4. Supportability

|NFR-#|Requirement|Prio|
|-----|-----------|----|
|8|De functionaliteit van de applicatie moet identiek zijn zo lang de client voorzien is van een iOS, iPadOS OSX, Windows of Android versie die niet ouder is dan 2020.|Must|
|9|Het systeem moet van logging voorzien zijn zodat fouten getraceerd kunnen worden.|Would|
|10|Alle use cases dienen afgetest te worden met op zijn minst een unit test.|Must|

## 3.5 Plus

|NFR-#|Requirement|Prio|
|-----|-----------|----|
|11|Het systeem moet kunnen draaien op een AMD64 processor architectuur.|Must|
|12|De data van de applicatie wordt persistent opgeslagen.|Must|
|13|Het systeem moet een interface beschikbaar stellen zodat andere software de mogelijkheid heeft met het systeem te integreren.|Must|
|14|Als gebruiker wil ik kunnen inloggen met mijn bestaande HAN account.|Should|

<font size="1">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>

# 4. Bronnen

|APA Bronvermelding|
|------------------|
|Larman, C., & Kruchten, P. (2005). Applying UML and Patterns: An Introduction to Object-oriented Analysis and Design and Iterative Development. Prentice Hall.
|Swart, N. de, & de Swart, N. (2017). Handboek Requirements: Leidraad voor analisten in agile, traditionele en hybride omgevingen. Reed Business Education.

<font size="1">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>

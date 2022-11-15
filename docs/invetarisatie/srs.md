[Terug](/README.md)

---
:warning: **_CRITERIA:_**
alle functionele requirements volledig, eenduidig, begrijpelijk en testbaar beschreven

---

# Software Requirement Specification

**Opdrachtgever:** De HAN - Hoge School Arnhem Nijmegen</br>
**Datum**: 12-11-2022 </br>
**Studenten**: Thomas Hofman (622438), Ricardo de Wijs ({studentnr})</br>
**Versie**: v0.6 </br>
**Klas**: {klascode} </br>
**Locatie**: Arnhem
**Docent**: John Gorter

# Versiebeheer

|Versie|Beschrijving|Auteur|Datum|
|------|------------|------|-----|
|v0.1|Document opzet & inleidingen|Thomas Hofman|16-09-2022|
|v0.2|Functionele requirements opgezet|Ricardo de Wijs|28-09-2022|
|v0.3|Niet functionele requirements toegevoegd|Thomas Hofman|29-09-2022|
|v0.4|Refactoren van requirements naar smart|Thomas Hofman|14-10-2022|
|v0.5|Requirements koppelen aan use cases|Ricardo de Wijs|15-10-2022|
|v0.6|Converteren van docx naar markdown|Thomas Hofman|12-11-2022|

# Inhoudsopgave

1. [Inleiding](#1-inleiding) </br>
    1.1. [Doelstelling](#11-doelstelling) </br>
    1.2. [Doelgroep](#12-doelgroep) </br>
2. [Functional Requirements (SMART)](#2-functional-requirements-smart) </br>
3. [Non-Functional Requirements (SMART)](#3-non-functional-requirements-smart) </br>
    3.1. [Usability](#31-usability) </br>
    3.2. [Reliability](#32-reliability) </br>
    3.3. [Performance](#33-performance) </br>
    3.4. [Supportability](#34-supportability) </br>
    3.5. [Plus](#35-plus) </br>
4. [Bronnen](#4-bronnen)

# 1. Inleiding

Dit document betreft het software requirements specification document en voorziet in de vastlegging van de functionele en niet functionele eisen, dit is gedaan middels de SMART- methode (Specifiek, Meetbaar, Acceptabel, Realistisch, Tijdgebonden). Het SRS-document is een bijlage van zowel het technisch- als het functioneel- ontwerp. De functionele eisen voeden het functioneel ontwerp, het functioneel ontwerp en de non-functional requirements fungeren gezamenlijk als fundering voor het technisch ontwerp.

## 1.1. Doelstelling

Het doel van het document is de vastlegging van de met de stakeholder overeengekomen functionele en niet functionele eisen. De eisen zijn genummerde met FR, Functional Requirement en NFR, Non-Functional Requirement, met het gebruik van deze nummering kan vanuit andere documenten gerefereerd worden naar de desbetreffende requirement.

## 1.2. Doelgroep

Stakeholders vanuit de HAN betrokken bij de casus ICDE en degene die de casus uitvoeren.

<font size="1">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>

# 2. Functional Requirements (SMART)

In onderstaande zijn de systeem features ofte wijl functional requirements omschreven.

---
:warning: **_CRITERIA:_**
alle functionele requirements volledig, eenduidig, begrijpelijk en testbaar beschreven voor een 10.

---

|FR-#|Requirement|Prio|Related Question|Related Use Case|
|----|-----------|----|----------------|----------------|
|1|Als docent wil ik een courses kunnen ontwikkelen zodat studenten deze courses kunnen volgen.|Must|1-2|1, 11, 10, 12, 13, 14, 17, 16|
|2|Als docent wil ik de inhoud van een course kunnen bekijken zodat …|Must|1-3|5|
|3|Als student wil ik de inhoud van een course kunnen bekijken zodat …|Must|1-3|5|
|4|Als docent wil ik een studenten en klassen registratie kunnen bijhouden zodat ik middels een klas studenten aan een course kan koppelen.|Must|1-4|3,4|
|5|Als docent wil ik kunnen inzien welke lessen ik moet geven zodat ik deze lessen kan voorbereiden.|Must|1-4|5, 6|
|6|Als docent wil ik kunnen inzien welke tentamens ik moet examineren zodat ik weet bij welke tentamens ik aanwezig moet zijn. |Must|1-4|6|
|7|Als docent wil ik beoordelingen voor door studenten gemaakte tentamen kunnen vastleggen zodat ik deze niet hoef te onthouden.|Must|1-4, 2-7|8|
|8|Als student wil ik een course kunnen volgen zodat …|Must|1-4, 2-6, 2-7|2, 5, 6|
|9|Als docent wil ik leeruitkomsten kunnen bepalen voor de course zodat duidelijk is wat de gewenste uitkomst van de course is.|Must|1-6|10|
|10|Als docent wil ik leeruitkomsten kunnen groeperen in een EVL zodat een course met vele leeruitkomsten overzichtelijk blijft.|Should|1-6|11|
|11|Als docent wil ik leerdoelen kunnen bepalen die bijdragen aan het behalen van een leeruitkomst zodat ik de inhoud van de course kan richten op het behalen van deze doelen.|Must|1-6|12|
|12|Als docent wil ik tentamen in de vorm van schriftelijke toetsen en/of beroepsproducten kunnen toevoegen aan een course zodat ik de leerdoelen binnen de course kan aftoetsen.|Must|1-6, 3-1|13, 14, 21|
|13|Als docent wil ik rubrieken met beoordelingscriteria kunnen bepalen voor een beroepsproduct zodat deze systematisch en objectief is na te kijken|Must|1-6|14|
|14|Als docent wil ik rubrieken kunnen verbinden aan leerdoelen zodat er afgedwongen wordt dat een rubriek een leerdoel aftoets|Must|1-6|14|
|15|Als docent wil ik lessen kunnen verbinden aan leerdoelen zodat ik zeker weet dat er voor alle leerdoelen lessen gegeven worden|Must|1-6|22|
|16|Als docent wil ik schriftelijke toetsen kunnen verbinden aan leerdoelen zodat er afgedwongen word dat een schriftelijke toets minimaal een leerdoel aftoetst.|Must|1-6|13|
|17|Als docent kan ik zelf aangeven om wat van type tentamen het gaat zodat duidelijk is wat van soort tentamen men kan verwachten.|Should|1-8|13, 21|
|18|Als docent kan ik aangeven in welke week van de course een les of tentamen plaats vind zodat duidelijk is wanneer de les of het tentamen plaats zal vinden.|Should|1-10|17|
|19|Als docent kan ik zelfstudie uren en contact uren verbinden aan lessen en tentamens zodat de studielast inzichtelijk word.|Should|1-10|13, 21, 22|
|20|Als docent wil ik dat invoer gecontroleerd wordt zodat menselijke invoerfouten voorkomen worden.|Must|1-11|\*|
|21|Als docent wil ik een variabel aantal beoordelingscriteria kunnen toevoegen aan een rubriek, minimaal 2 en maximaal … zodat …|Must|1-12|14|
|22|Als docent wil ik een weging kunnen specifiëren voor rubrieken zodat ik belangrijkere rubrieken zwaarder kan laten meetellen in de eindbeoordeling.|Should|1-12|14|
|23|Als docent wil ik de mogelijkheid hebben om per rubriek een knock-out grens te zetten zodat ik kan afdwingen dat studenten op bepaalde rubrieken een minimale score moeten behalen.|Should|1-12, 1-13|14|
|24|Als docent wil ik commentaar/feedback kunnen toevoegen aan een beoordeling als zodat een student mijn onderbouwing voor de beoordeling kan inzien. |Should|1-13|8|
|25|Als docent/student wil ik een course kunnen exporten zodat ik deze data kan delen met personen/systemen die binnen het systeem geen toegang hebben tot deze data, bijvoorbeeld roosteraars.|Could|1-15|18|
|26|Als docent wil ik samen aan een course kunnen werken zodat ik de course niet in mijn eentje hoef te ontwikkelen.|Must|2-1, 2-2|\*|
|27|Als docent wil ik oudere versies van een course kunnen blijven inzien zodat de course inhoud van uitvoeringen gebaseerd op oudere versies van de course inzichtelijk blijven.|Must|2-3|1, 5|
|28|Als docent wil ik alle beschikbare course templates kunnen inzien zodat ik eenvoudig een course kan starten gebaseerd op een van deze templates.|Must|2-4, 2-7|1|
|29|Als docent wil ik een klas kunnen verbinden aan een opleidingsprofiel dat onderdanig is aan een opleiding zodat voor mij duidelijk is in welke context de klas de course volgt. En middels deze klas leerlingen als groep kunnen verbinden aan een course uitvoering.|Would|2-5|4|
|30|Als docent wil ik de inrichting van een course template meerdere malen kunnen uitvoeren zodat de course data niet voor elke uitvoering opnieuw hoef in te voeren. |Must|2-6|15, 16|
|31|Als docent wil ik de inrichting van een course kunnen hergebruiken als basis voor een nieuwere versie zodat ik niet alle inhoud opnieuw hoef aan te maken wanneer ik een soort gelijke course wil ontwikkelen.|Won’t|||
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

In onderstaande zijn de non-functional requirements omschreven, deze requirements zijn onderverdeeld in de categorieën volgens het FURPS+ model (Larman 2005, 5.4) Functional, Usability, Reliability, Performance en Supportability. 

---
:warning: **_CRITERIA:_**
alle non-functionele requirements volledig, eenduidig, begrijpelijk en testbaar beschreven voor een 10

---

## 3.1. Usability

|NFR-#|Requirement|Prio|Question|
|-----|-----------|----|--------|
|1|De tool moet han breed inzetbaar zijn.|||
|2|De tool moet vanaf x-locatie beschikbaar zijn|||
|3|De tool moet het voor een elke docent en docent mogelijk zijn om binnen x-tijd alle courses in te zien. |||

## 3.2. Reliability

|NFR-#|Requirement|Prio|Question|
|-----|-----------|----|--------|
|4|Het systeem moet zonder fouten zijn taak uitvoeren in x-procent van de use cases.|||
|5|Het systeem moet x-procent van de tijd beschikbaar zijn per maand gedurende werktijden (9-17).|||

## 3.3. Performance

|NFR-#|Requirement|Prio|Question|
|-----|-----------|----|--------|
|6|De reponse tijd voor de start pagina moet tot … users een reponse tijd hebben van … voor x browser/client. (Inclusief rendering)|||
|7|Het systeem moet kunnen schalen om … gelijktijdige users van dienst te kunnen zijn. |||
|8|De applicatie heeft minimaal x-cpu en x-memory nodig om x-aantal-users te kunnen afhandelen|||

## 3.4. Supportability

|NFR-#|Requirement|Prio|Question|
|-----|-----------|----|--------|
|9|De applicatie moet volledig werken in x-client/x-browser vanaf x-versie.|||
|10|Het systeem moet van logging voorzien zijn zodat fouten getraceert kunnen worden.|||

## 3.5 Plus

|NFR-#|Requirement|Prio|Question|
|-----|-----------|----|--------|
|11|Het gebruik van unit-tests is een vereiste, alle kern functionaliteit dient te voorzien zijn unit-tests.|||
|12|Het systeem moet een interface beschikbaar stellen zodat andere software de mogelijkheid heeft met het systeem te integreren.|||
|13|Het systeem moet kunnen draaien op een AMD64 processor architectuur.|||

<font size="1">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>


# 4. Bronnen

|APA Bronvermelding|
|------------------|
{larman}

<font size="1">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>

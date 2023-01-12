[Terug](/README.md)

# Questions & Answers

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
|v0.2|Vragen iteratie 1|Thomas Hofman|16-09-2022|
|v0.3|Review iteratie 1, vragen toegevoegd|Ricardo de Wijs|16-09-2022|
|v0.4|Notuleren iteratie 1|Ricardo de Wijs|20-09-2022|
|v0.5|Vragen iteratie 2|Thomas Hofman|23-09-2022|
|v0.6|Additionele vragen iteratie 2|Ricardo de Wijs, Thomas Hofman, Marco van de Kolk|02-10-2022|
|v0.7|Verwerken feedback iteratie 2|Thomas Hofman|07-10-2022|
|v0.8|Verwerken feedback klas|Thomas Hofman|14-10-2022|
|v0.9|Converteren van docx naar markdown|Thomas Hofman|12-11-2022|
|v1.0|Eerste versie|Thomas Hofman|12-01-2023|

# Inhoudsopgave

1. [Inleiding](#1-inleiding) </br>
    1.1. [Doelstelling](#11-doelstelling) </br>
    1.2. [Doelgroep](#12-doelgroep) </br>
2. [Vragen iteratie 1](#2-vragen-iteratie-1) </br>
    2.1. [Vragen aan de stakeholders](#21-vragen-aan-de-stakeholders) </br>
    2.2. [Vragen aan de opleidingscoördinatoren](#22-vragen-aan-de-opleidings-coordinatoren) </br>
3. [Vragen iteratie 2](#3-vragen-iteratie-2) </br>
    3.1. [Vragen aan de stakeholders](#31-vragen-aan-de-stakeholders) </br>
    3.2. [Vragen aan de opleidingscoördinatoren](#32-vragen-aan-de-opleidings-coordinatoren) </br>
4. [Vragen iteratie 3](#4-vragen-iteratie-3) </br>
    4.1. [Vragen aan de stakeholders](#41-vragen-aan-de-stakeholders) </br>
5. [Vragen iteratie 3](#5-vragen-iteratie-4) </br>
    5.1. [Vragen aan de stakeholders](#51-vragen-aan-de-stakeholders) </br>
6. [Bronnen](#6-bronnen)

# 1. Inleiding

Binnen dit document zijn de vragen en antwoorden vastgelegd die gesteld zijn aan de stakeholder van de casus ICDE of de coördinatoren van het vak I-OOSE.

Het is mogelijk om naar de vragen te refereren middels de nummering, Q (Question) representeert een vraag, A (Assumption) representeert een aanname.

Er zijn hier en daar ook vragen gesteld aan de coördinatoren van het vak I-OOSE, deze vragen hebben geen betrekking tot de inhoud van de casus en zijn aangeduid met QC (Question Coordinators).

## 1.1. Doelstelling

Het doel van het document is om de vragen die gesteld worden tijdens de analyse vast te leggen. De vragen en aannamen zullen dienen als fundering voor zowel het SRS- als het FO- document en zijn daarmee van groot belang, dit document maakt het mogelijk om te verwijzen naar een set van vraag en antwoord als onderbouwing binnen deze documenten.

## 1.2. Doelgroep

Stakeholders vanuit de HAN betrokken bij de casus ICDE en degene die de casus uitvoeren.

<font size="1">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>

# 2. Vragen Iteratie 1

## 2.1. Vragen aan de stakeholders

**Q1-1 - Het doel lijkt te zijn; tijd efficiëntie, consistentie en assistentie bij het generen van een methodische aanpak voor de course, klopt dit?** </br>
*Ronald: Ja dat klopt.*

**Q1-2 - In de casus wordt er gesproken over ontwikkelaars van semesters, wie zijn deze ontwikkelaars?** </br>
*Ronald: Ontwikkelaars zijn docenten die de courses ontwikkelen, dit kunnen zowel coördinatoren zijn als andere docenten.*

**Q1-3 - Zijn er naast deze ontwikkelaars nog andere gebruikers die belangen hebben bij- of gebruik willen maken van- het systeem (actoren)?** </br>
*Ronald: Docenten willen inzagen hebben in het systeem zodat zij de inhoud van de course kunnen bekijken. Ook leerlingen willen inzage in de course hebben zodat zij kunnen inzien waarop ze beoordeeld worden.*

**Q1-4 – Wat zijn de belangen/doelen van deze actoren?** </br>
*John: De enige actoren binnen het systeem zijn een docent en een student. Een docent geeft een les, examineert een tentamen en geeft hier een beoordeling. Een student zit in een klas en volgt een course, neemt deel aan tentamen en ontvangt daarvoor beoordelingen, een student zal niet de beoordelingen van een andere student moeten zien of courses kunnen inzien die hij/zij niet volgt. Een docent heeft inzage in course inrichtingen en kan deze instantiëren en templates ontwikkelen. Een student volgt slechts een course.*

**Q1-5 – Vanaf waar moet het systeem te benaderen zijn?** </br>
*Ronald: Een gebruiker moet de mogelijkheid hebben om vanaf remote locaties gebruik te maken van het systeem indien hij/zij een HAN-account heeft. Afhankelijk van functie krijg je bepaalde rechten. De tool moet grafisch zijn en bruikbaar zijn op laptop & smartphones.*

*John: De HAN-Accounts zijn gehuisvestigd in Azure AD, je mag met Azure AD integreren maar een lokaal authenticatie systeem is ook een optie. Er hoeft niet per se een lokaal fallback account te zijn zodat men kan inloggen indien Azure AD onbereikbaar is, gebruik van een van beide authenticatie mechanismen is afdoende.*

**Q1-6 – Welke methodes zijn er om vervolgens tot ontwikkelde course te komen?** </br>
*Overeengekomen met John: Er zit een vast patroon in het systeem voor het opstellen van een course, een course dient een aantal leeruitkomsten een bundel van leeruitkomsten met hoge cohesie noemt men een eenheid van leeruitkomsten. De leerdoelen dienen een of meerdere leeruitkomsten de leerdoelen zijn verbonden aan rubrieken Rubrieken zijn verbonden aan een beroepsproduct en worden afgetoetst, meerdere rubrieken kunnen gerelateerd zijn aan een enkel leerdoel. Een schriftelijke toets heeft geen rubrieken en krijgt simpelweg een beoordeling.*

**Q1-7 – Welke input hebben deze methodes nodig om tot een ontwikkelde course te komen? En kan deze vereiste input per methode verschillen?** </br>
*John: De ontwikkelaar stelt de course samen er is geen input die door een algoritme gehaald wordt waardoor er magische wijs een course samengesteld wordt.  De ontwikkelaar stelt voor de course een of meerdere eenheid van leeruitkomsten op, de leeruitkomsten die hieronder vallen zijn verbonden aan een of meerdere leerdoelen. Deze leerdoelen dienen afgetoetst te worden middels een beroepsproduct of een schriftelijke toets.*

**Q1-8 – Welke soort toets momenten/leeruitkomsten zijn er?** </br>
*Ronald: Tijdens het ontwikkelen van een course wordt dit bepaald, er zijn verschillende opties zoals een assessment, presentatie, verslag, theoretische toets, praktijk toets etc, waarschijnlijk komen er gedurende die applicatie lifetime opties bij.*

**Q1-9 – Zijn er voorbeelden van uitgewerkte beoordelingsdimensies en beoordelingscriteria beschikbaar voor naslag?** </br>
*Ronald: geen idee of dit beschikbaar is, vrij voor eigen interpretatie.*

**Q1-10 - Moet het systeem naast toets roosters ook bijpassende lesroosters kunnen maken?** </br>
*John: Het moet wel mogelijk zijn om op te geven binnen welke week van de course een toets valt, het daadwerkelijk inroosteren is buiten de scope van het systeem. Ook buiten de scope van het systeem zijn afhankelijkheden, zo hoef je niet te controleren of een tentaminering (BP, ST) voor de lessen worden gegeven die aan dezelfde leerdoelen verbonden zijn (Eventueel wel mogelijk als uitbreiding van de casus mocht de opdracht te klein blijken).*

*Wellicht is het wel handig om zelfstudie uren en contacturen te kunnen verbinden aan lessen of tentamens zodat een roosteraar deze contacturen kan inplannen en een student zijn studielast kan inzien.*

**Q1-11 - De Handmatige administratie was foutgevoelig; Tegen welke inconsistentie liep men aan?** </br>
*Ronald: kopieer en plakken, teksten worden niet goed aangepast, foutgevoeligheid in cijfers en weging. Concreet; manuele fouten gerelateerd aan gebruikersinvoer.*

**Q1-12 – Hoe worden beroepsproducten beoordeeld?** </br>
*Ronald: De beoordelingen van een beroepsproduct (BP) is een samenstelling van de beoordelingen van de rubrieken, aan elke rubriek wordt een weging gegeven, de totale weging moet 100% zijn. De beoordeling van een rubriek hoeft niet altijd 1 t/m 10 te zijn maar kan bijvoorbeeld ook 1 t/m 5 zijn. Per beoordelingscriteria moet een beschrijving toegevoegd die het mogelijk maakt objectief te beoordelen. Het is ook mogelijk om knock-out’s te markeren, per rubriek moet er ruimte zijn voor commentaar. Een tentamen kan eventueel voldoende afgerond worden of met een cijfer, een cijfer hoger dan een 5.5 komt neer op een voldoende. Aan tentamens onderling is ook een weging verbonden die geld tot op het EVL niveau. Het zal wenselijk zijn als de tool assisteert bij het beoordelen van beroepsproducten en dat ik als docent niet zelf de eindbeoordeling hoef te berekenen.*

**Q1-14 – Wat is een knock-out criteria?** </br>
*Ronald: Een wanneer je onder de grens van een knock-out criteria scoort dan heb je het tentamen per definitie niet gehaald ongeacht je score op de overige rubrieken.*

**Q1-15 - Aangeleverd zijn een tweetal voorbeelden; een tentamen in planning in Pdf-Formaat en CSV-Formaat. Wie is de doelgroep van deze exports en kunnen er eventueel exportformaten bijkomen?** </br>
*Ronald: Ik kan mij voorstellen dat het voor zowel een docent als een student handig kan zijn om een export te kunnen maken van de course. Ook zal dit handige input kunnen zijn voor een roosteraar die bijvoorbeeld de lessen en tentamen moet inplannen.*

**Q1-16 – Assessment driven course design - Bij het ontwikkelen van een nieuwe course, is het dan een functionele eis om dit af te dwingen? Zodat er niet eerst inhoud aan en course gegeven kan worden indien het beoogde resultaat nog niet bekend is?** </br>
*Ronald: Ja dat lijkt me een goede werkwijze.*

**Q1-17 – Hybrid Pedagogy - Domein onderzoek naar deze term heeft niks concreets opgeleverd, vragen aan de domeindeskundige.** </br>
*Ronald: Wellicht kun je deze vraag neerleggen bij een onderwijsdeskundige.*

**Q1-18 – Educational patterns - Hoewel de casus dit nu niet strikt beschrijft: Moet er functioneel rekening gehouden worden met het gebruik van deze patterns? Zo ja welke voor welke problemen gebruikt men nu welke patterns?** </br>
*Ronald: Geen flauw idee.*

## 2.2. Vragen aan de opleidings coordinatoren

**QC1-1 – Binnen het beoordelingen formulier wordt gevraagd om teamwork, in welke form dienen wij dit aan te tonen, commentaar in Word? Github versie beheer? Github project kanban? Way of work document?** </br>
*John: Dit wordt getoetst gedurende het proces, indien wij geen duidelijk beeld hebben van de samenwerking dan zullen wij hier extra naar vragen tijdens het assessment. Ook zul je het onderdeel samenwerking zelf moeten beoordelen in je zelfbeoordeling die je individueel invult.*

<font size="1">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>

# 3. Vragen Iteratie 2

## 3.1. Vragen aan de stakeholders

**Q2-1 – Binnen de features wordt verwezen naar versiebeheer en collaboratief werken, voor welk aspect van de applicatie geld dit?** </br>
***“er kan makkelijker collaboratief gewerkt worden zonder problemen met versiebeheer; (Versie beheer van wat?)”*** </br>
*Ronald: Voor de courses, men moet gezamenlijk aan een course kunnen werken en eerdere versies moeten inzichtelijk blijven.*

**Q2-2 – Dus iedere docent moet bijvoorbeeld gelijktijdig leerdoelen, lessen en rubrics voor een course kunnen toevoegen, en er is dus geen enkele course auteur?** </br>
*Ronald: Ja men moet gelijktijdig aan de course kunnen werken, echter hoeft men niet gelijktijdig hetzelfde dataveld te kunnen aanpassen.*

**Q2-3 – Dus oudere courses moeten inzichtelijk blijven, wij hebben een voorstel wat betreft de werking van versie beheer;** </br>
***“Wanneer een course aangemaakt wordt is dit in eerste instantie een concept, een concept is (gezamenlijk) te bewerken maar niet te instantiëren en hoeft nog niet volledig te zijn. Je hebt de mogelijkheid om een concept definitief te maken, dit betekent een versie 1. Een definitieve versie is niet meer te bewerken en kan uitgevoerd worden, wel heb je de mogelijkheid een nieuwe versie aan te maken voor een course. In dat geval wordt er een nieuw concept aangemaakt die in eerste instantie gevuld wordt met de data van de vorige versie, je kunt (gezamenlijk) je wijzigen aanbrengen en deze course vervolgens weer definitief maken, dit betreft dan een versie 2 en is uiteraard weer te instantiëren”*** </br>
*Ronald: Dat lijkt mij een prima implementatie.*

**Q2-4 - Op welke niveau’s moet men courses binnen het systeem kunnen delen? (opleiding profiel, opleiding, sector, organisatie breed?)** </br>
*John: Een organisatie brede course bibliotheek is afdoende.*

**Q2-5 - Wat precies is de definitie van opleidingsprofiel: Is het opleidingsprofiel b.v. BIM of software development?** </br>
*John: Ja, een profiel is onderdanig aan een opleiding, een klas volgt gezamenlijk een opleidingsprofiel.*

**Q2-6 – Genereert de tool slechts een course template of zijn deze templates binnen het systeem te instantiëren? Heeft een course instantie dan ook volgers (studenten) zodat docenten een beoordeling kunnen invoeren in het systeem?** </br>
*John: Ja een course moet geïnstantieerd kunnen worden. Een student moet in een klas kunnen zitten en een course moeten kunnen volgen, eventueel meerdere keren mocht men deze in eerste instantie niet halen.*

**Q2-7 – Zijn er verschillen in permissies, kan iedereen elkaars course opbouw zien maar niet aanpassen? Wie zijn de bewerkingsbevoegd? Wij bepalen er welke rechten een gebruiker bezit?** </br>
*John: De docenten zijn bewerkingsbevoegd en kunnen elkaars course bewerken, dat geld ook voor de cijfers en de instanties van de courses, eventueel kunnen permissies in een latere versie ingeperkt worden middels RBAC. De studenten hebben alleen inzage in hun eigen cijfers, bijhorende feedback en de course(s) die zij volgen.*

**Q2-8 – Moet het mogelijk zijn binnen het systeem op te geven of een les online of offline gegeven wordt?** </br>
*John: Bij het ontwikkelen van de course niet maar bij het inplannen van lessen en tentamens moet er wel een locatie gekoppeld kunnen worden.*

**Q2-9 – Welke validaties moeten er plaatsvinden?** </br>
***“Inconsistenties (tussen wat?) kunnen geautomatiseerd gedetecteerd worden, bijv. of er voldoende onderwijs voor alle beoordelingsdimensies wordt gegeven of dat er lessen zijn die niet bijdragen aan de leerdoelen;”*** </br>
*John: Aan een leerdoel moet altijd een tentamen zitten en minimaal een les. Er moet voorkomen worden dat er iets getoetst wordt op een leerdoel dat buiten de course valt of dat men toets op een leerdoel waar geen les in gegeven is. Daarnaast dient ieder leerdoel afgetoetst te worden. Valideren of de tentaminering afgenomen word nadat alle lessen voor het bijhorende lesdoel gegeven wordt valt buiten de scope.*

**Q2-10 – Moet het systeem ook de lesinhoud bevatten of puur aangeven welke/wat van soort lessen er gegeven moeten worden?** </br>
*John: Lesinhoud is wel relevant voor de inrichting van een course, wellicht een beschrijving van de les en optioneel lesmateriaal zoals bijvoorbeeld binnen onderwijsonline.*

**Q2-11 – Zijn studiepunten ook onderdeel van het systeem? Een semester (20 weken ofte wijl 2 onderwijsperioden) betreft vrijwel altijd 30 studiepunten bepaalt de duur ook het aantal studiepunten?** </br>
*John: Dat is in ieder geval wel het geval binnen jullie opleiding, het bijhouden van studiepunten bied je wel de mogelijkheid om je course progressie te tonen.*

**Q2-12 – Binnen de features wordt gevraagd om een scheiding tussen inhoud en vorm, zal je deze scheiding gedetailleerd komen omschrijven, waarop wordt hier gedoeld?** </br>
***“Inhoud (wat is de inhoud?) en vorm (wat is de vorm?) zijn gescheiden, wijzigingen in formaten (bijv. OWE-beschrijvingen, beoordelingsformulieren etc.) zijn zo veel makkelijker te realiseren omdat deze gegenereerd worden;”*** </br>
*John: De inhoud en vorm vertaal ik in jullie geval naar de inrichting van een course en de uitvoering daarvan.*

## 3.2. Vragen aan de opleidings coordinatoren

**QC2-1 – Worden er wireframes verwacht binnen het Technisch Ontwerp?** </br>
*John: Wellicht vereenvoudigt dit wel de communicatie met de stakeholder, het is zeker toegestaan maar niet vereist. In de realiteit wordt dit eigenlijk altijd verwacht door de stakeholder.*

<font size="1">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>

# 4. Vragen Iteratie 3

## 4.1. Vragen aan de stakeholders

**Q3-1 – Gegeven onderstaande, zijn er momenteel al wensen voor koppelingen? Moeten wij een API beschikbaar stellen?** </br>
“Gegevens uit het systeem zouden op lange termijn ook gekoppeld kunnen worden aan andere gebruikte systemen zoals onderwijsonline (bijv. automatisch genereren en plaatsen van OWE-beschrijvingen) of Alluris (eindbeoordelingen volgens de rubrics geautomatiseerd overnemen incl. onderbouwing). (Alleen integratie geïnitieerd vanuit het te maken systeem of zijn er ook externe systemen die onze data moeten kunnen consumeren?)” </br>
*John: Api Service aanbieden voor andere systemen en zelf consumeren.*

**Q3-2 – Hoeveel mensen zullen gebruik maken van het systeem en met welke frequentie? Zijn er verdere uitspraken te doen over de niet functionele eisen van het systeem:**

- Prestatie
- Bruikbaarheid
- Hosting/hardware requirements
- Browser/OS support
- Onder Houdbaarheid (Bijvoorbeeld logging)
- Unit test dekking
- API-standaarden
- Uptime

*John: Zelf realistische aannamens doen*

**O3-3 - Hebben wij genoeg complexe use cases aangezien wij met drie man zijn?**
*John: Wellicht kun je een extra validatie toevoegen: lessen voor een lesdoel moeten eerder ingepland worden dan de tentaminering voor het lesdoel, anders krijgen we boze leerlingen.*

# 5. Vragen Iteratie 4

## 5.1. Vragen aan de stakeholders

**A4-1 - Kan een docent zelf een type beroepsproduct of schriftelijke toets toevoegen of staat dit statisch gedefinieerd in het systeem?** </br>
*Aanname: statisch gedefinieerd binnen het systeem.*

**A4-2 – Hoe speelt weging een rol in de beoordeling? In het geval dat de rubriek voor 10/100 punten weegt in de beroepsproduct en deze met een voldoende is beoordeeld krijgt men dan 10/100 punten? Indien dezelfde rubriek met een cijfer beoordeeld zal worden en men krijgt een 8 voor de rubriek betekent dat dan dat men 8/100 punten krijgt? Is de weging op basis van percentage en moet de totale weging van rubrieken voor een enkel beroepsproduct dus tot 100 komen?** </br>
*Aanname: Dit is de correcte manier hoe weging werkt.*

**A4-3 – Zijn er verschillen tussen de course ontwikkeling voor voltijd en deeltijd?** </br>
*Aanname: Nee.*

**A4-4 – Moeten oudere versies van een course te instantiëren zijn, of kan je alleen de laatste versie instantiëren.** </br>
*Aanname: Alleen de laatste versie.*

**A4-5 – In de casus wordt een ontwikkelaar beschreven als iemand die een semester ontwikkelt, betekent dit dat een course altijd een semester duurt? Of terwijl 30 studiepunten en 20 weken per course?** </br>
*Aanname: Dit kan zowel een semester zijn (2 perioden/een half jaar) als een enkele periode (kwart jaar)*

**A4-6 – Moet er rekening gehouden worden met herkansingen?** </br>
*Aanname: Niet voor het MVP.*

**A4-7 – Aan lessen en tentamen zijn zowel zelfstudie als contacturen verbonden, moeten wij hier een wekelijks limiet aan contact/zelfstudie uren toepassen?** </br>
*Aanname: Nee, eventueel later mogelijk*

<font size="1">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>
[Terug](/README.md)

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
|v0.4|H2, H3|Thomas Hofman|30-12-2022|
|v0.5|H4|Thomas Hofman|31-12-2022|
|v0.5|H6|Thomas Hofman|31-12-2022|

# Inhoudsopgave

1. [Inleiding](#1-inleiding) </br>
    1.1. [Aanleiding](#11-aanleiding) </br>
    1.2. [Doelstelling](#12-doelstelling) </br>
    1.3. [Doelgroep](#13-doelgroep) </br>
2. [Aanpak & Prioritering](#2-aanpak--prioritering) </br>
3. [Architectuur](#3-architectuur) </br>
    3.1. [Layering](#31-layers) </br>
    3.2. [Distribution/Scalability](#32-distributionscalability) </br>
    3.3. [Architectuur Patterns](#33-architectuur-patterns) </br>
4. [Technische keuzes](#4-technische-keuzes)
5. [Design](#5-design) </br>
    5.1. [Api, Repository & Service Design](#51-api-repository--service-design) </br>
    5.2. [Domein Design](#52-domein-design) </br>
        5.2.1. [Toelichting](#521-toelichting) </br>
        5.2.2. [Domein consistentie/inconsistentie](#522-domein-consistentieinconsistentie) </br>
    5.3. [UC15 - Start uitvoering](#53-uc-15-start-uitvoering) </br>
        5.3.1. [Design](#531-design) </br>
        5.3.2. [Toelichting](#532-toelichting) </br>
    5.4. [UC-18 Exporteer Informatie](#54-uc-18-exporteer-informatie) </br>
        5.4.1. [Design](#541-design) </br>
        5.4.2. [Toelichting](#542-toelichting) </br>
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

Het project zal iteratief opgeleverd worden wat betekent dat er steeds nieuwe functionaliteit toegevoegd word aan het project en dat er tussentijds werkende versies opgeleverd worden. Voordat er werkende versies opgeleverd kunnen worden die voor de klant testbaar zijn dient er een minimum viable product (MVP)ogezet te worden. In onderstaande staat beschreven volgens welke stappen dit MVP opgezet word:

1. Eerst dient de domein laag, het core project, uitgewerkt te worden, attributen moeten bepaald worden en relaties tussen attributen moeten gedefineerd worden (middels attributen).
2. Vervolgens dient voor ieder van deze domein entiteiten creatie logica aangebracht te worden. Iedere entiteit moet gecreeerd kunnen worden inclusief bijhorende afhankelijkheden. Belangrijk is dat entiteiten via de constructor aangemaakt worden zodat vereiste parameters/data afgedwongen kan worden. Essentieel is dat deze logica getest word middels unit testen.
3. Nu de domein laag uitgewerkt is moet deze persistent opgeslagen kunnen worden. De service laag waarvan de presentatie laag (api) afhankelijk is op zijn beurt weer afhankelijk van een repository implementatie. Deze implementatie dient uitgewerkt te worden zodat alle domein data persistent opgeslagen kan worden. 
4. Nu er een repository implementatie beschikbaar is kan de service laag uitgewerkt worden en vervolgens de presentatie laag uitgewerkt worden. 

Middels swagger is het mogelijk om via een grafisch web interface de api te testen, voldoende om toekomstige iteratief toegevoegde functionaliteit af te testen. In totaal zijn er 22 use cases in kaart gebracht, uit deze 22 use cases hebben wij 5 use cases als "complex" bestempelt, deze use cases zullen als eerst geimplementeerd worden aangezien het succes van het project valt of staat met de uitwerking van deze use cases. De complexe use cases zijn als volgt:

1. UC-2 Bekijk Beoordelingen
2. UC-18 Exporteer informatie
3. UC-15 Start uitvoering
4. UC-16 Maak course definitief
5. UC-20 Aanmelden

Deze use cases dienen in bovenstaande volgorde opgeleverd te worden, de functionaliteit kan iteratief toegevoegd worden aan het bestaande MVP. Ook technisch ontwerp is onderdeel van onze iteratieve werkwijze om een grote voorafgaande documentatie effort te voorkomen, na mate het project vordert zal ook aan de overige use cases een prioriteit toegekend worden. 

<font size="1">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>

# 3. Architectuur

In onderstaande word de architectuur van de applicatie toegelicht, applicatie architectuur betreft het defineren van wat er in de applicatie zit en hoe deze componenten zich tot elkaar verhouden/met elkaar integreren. In een later hoofdstuk zal het design van deze componenten toegelicht worden.  

# 3.1. Layers

In de achitectuur die binnen dit project gehanteerd staat het domein centraal, het domein bestaat uit verschillende entiteiten deze zijn gehuisvestigd in het `HICT.ICDETool.Core` project, het core project is de domein laag. De domeinlaag houd zich alleen bezig met domein logica, elke entiteit representeert een concept uit het domein model en bevat de benodigde methodes om de staat van het domein te wijzigen, dit is de domein logica. 

Afhankelijk van het core project is het `HICT.ICDETool.Service` project, het service project heeft interactie met het project middels services. De rol van de service laag is het verbinden van de domein laag met de technische lagen zoals de infrastructuur laag en eventuele andere externe diensten. Het verbinden met deze lagen/diensten gebeurd via interfaces, de service laag defineert de interfaces en is zich niet bewust van de implementatie. Het is aan de daadwerkelijke implementatie om zich te conformeren aan deze interface. Dit principe heet dependency injecten en voorkomt dat de service laag direct gekoppelt word aan een implementatie. Dit zal het anders namelijk maken om later te wijzigen van implementatie of een mock implementatie te gebruiken voor unit testen.

De infrastructuur laag houdt zich bezig met infrastructurele zaken en bevind zich in het `HICT.ICDETool.Infratructuur`, binnen deze applicatie betreft dit alleen de data persistentie. De infrastructuur laag bevat een repository implementatie die die repository interface gedefineerd in de service laag implementeert.

De service laag wordt geconsumeerd door de presentatie laag, in dit geval betreft dit een HTTP rest API, deze is gehuisvestigd in het `HICT.ICDETool.Api` project. Deze laag maakt het mogelijk voor eindgebruiker of externe systemen om data uit het systeem te consumeren en hier bewerkingen op uit te voeren. In dit geval middel HTTP rest calls. 

De tot projecten/lagen die tot nu toe ten spraken zijn gekomen zijn allemaal aanwezig aan de server zijde. Een eindgebruiker zal echter niet direct met de API communiceren en verwacht een gebruikers interface. Deze interface bevind zich in het `HICT.ICDETool.Web` project, dit project is afhankelijk van het `HICT.ICDETool.ApiClient` project. De ApiClient bevat de daadwerkelijke logica om met de api te communiceren het web project bevat slechts de logica voor de presentatie daarvan. Het api client project is afhankelijk van het `HICT.ICDETool.Service` project, dit project zal namelijk de daadwerkelijke data transfer objects (DTO's) bevatten. 

Dan resten nog de projecten `HICT.ICDETool.SharedKernel`, `HICT.ICDETool.Tests.Unit` en `HICT.ICDETool.Tests.Integratie`. Het shared kernel project bevat logica die overkoepelend is voor de gehele applicatie. Het doel van de test projecten is om geautomatiseerde testen te schrijven zodat het eenvoudig is om herhaaldelijk te testen of de applicatie nog steeds de verwachte uitkomst genereert. Unit testen zullen in dit geval gericht voornamelijk gericht zijn op de werking van de domein laag, deze testen zijn onafhankelijk en kunnen dus zonder de benodigdheid van externe services draaien. De integratie testen richten zich juist op de integratie met externe services, in dit geval zal de werking van de api client getest worden, de externe service waarvan deze afhankelijk is is het api project.

Naar deze architectuur waarbij het domein centraal staat word verwezen als Clean Architecture. Clean Architecture is een vorm van Domain Centric design en is relatief toegankelijk. Er zijn andere vormen van Domain Centric design zoals Onion, Hexagonal en Domein Driven Design (DDD). Het gebruik van meerdere lagen maakt bepaalde aspecten van de applicatie herbruikbaar en bied richtlijnen in het onderverdelen van logica. 

```raw
.
├── HICT.ICDETool.Service
├── HICT.ICDETool.SharedKernel 
├── HICT.ICDETool.Domain 
├── HICT.ICDETool.Infrastructure 
├── HICT.ICDETool.Api
├── HICT.ICDETool.Tests.Unit
├── HICT.ICDETool.Tests.Integration 
├── HICT.ICDETool.ApiClient
└── HICT.ICDETool.Web 
```

```mermaid

classDiagram
Web --> ApiClient
ApiClient .. Api : HTTP Rest
Api --> Services
Services --> Domain
Infrastructure *..> Services : IRepository

```

## 3.2. Distribution/Scalability

De oplossing is gebaseerd op een client-server architectuur waarbij de client het web project is en de server side applicatie het api project is. De applicatie staat haar data persistent op in een relationele database. De web client word gedownload door de browser zodra men de webserver waar deze client op gehost word aanroept. Het voordeel van het gebruik van een aparte web client is dat niet voor iedere wijziging in de presentatie een http request vereist is. De web client kan een request doen naar de api server en vervolgens zelfstandig deze data presenteren in verschillende vormen, dit verminderd de load op de api server en ook op de daarbij horende database en verplaatst deze naar de client.

Er zijn dus 3 componenten die gehost dienen te worden, de web client moet aangeboden worden, de api dient beschikbaar te zijn en de api is afhankelijk van een database. Deze zijn ieders horizontaal (toevoegen van servers) als verticaal (toevoegen van resources) schaalbaar. Zo kan tegemoet gekomen worden aan de gestelde niet functionele requirements omtrent load en beschikbaarheid.

## 3.3. Architectuur Patterns

Binnen de applicatie word er gebruik gemaakt van een aantal  architectuur patterns, deze patterns hebben in grote impact op de structuur van de applicatie en worden in onderstaande toegelicht.

- Controller: Het Api project is een MVC project echter bevat het alleen controllers, iedere domein entiteit krijgt haar eigen controller. Middels URL routing word de request door de juiste controller opgevangen, de controller vraagt de service laag om de lees of schrijf bewerking uit te voeren en geeft vervolgens het resultaat (indien van toepassing) terug aan de eindgebruiker.
- Data transfer objects (DTO's): Data transfer objects zijn objecten geoptimaliseerd voor data communicatie, zo kan een DTO meer data bevatten dan normaal voor een view benodigd zal zijn. Door een web client via een DTO meer van meer informatie te voorzien kan een client langer zonder communicatie met de api server.
- Repository: Voor toegang tot data word een repository gebruikt, een repository is een abstractie voor de data persistentie laag en is verantwoordelijk voor de afhandeling van alle taken omtrent deze persistentie. Zo kan de applicatie met persistente data interacteren alsof het onderdeel is van de applicatie zelf terwijl het afkomstig uit uit een externe service namelijk een RDBMS.
- Specification: Het specification pattern maakt het mogelijk om database verzoeken vast te leggen in een aparte specificatie class. Deze class kan aan de repository meegegeven worden die vervolgens dit database verzoek uitvoert. Het gebruik van aparte specificatie classes maakt het mogelijk om data verzoeken onder te brengen in de domein laag en deze specificaties eenvoudig te herbruiken.
- Dependency Injection: Dependency injection maakt het mogelijk een type service eenmalig te registreren bij het opstarten van de applicatie zodat deze @ runtime geinjecteert kunnen worden via de constructuctor van een class. Dit voorkomt dat je zelf deze classes moet instanteren, middels de registratie is de applicatie namelijk op de hoogte van hoe deze geinstantieert moet worden en kan dit @ runtime voor je doen.
- Dependency Inversion: Dependency inversion keert een afhankelijkheid om door het gebruik van een interface. Dit doe je door een interface te specificeren voor de implementatie waarvan je onafhankelijk wilt zijn en de imlpementatie deze interface laat implementeren. Dit maakt het mogelijk om eenvoudig tussen implementaties te wisselen zo lang deze de gespcifieerde interface implementeren.
- Client-Server: Zoals eerder benoemd hanteert de applicatie een client-server architectuur. Dit verplaatst de load van het renderen van de html naar de client en verminderd (indien juist toegepast) de load naar de api server.
- Data Binding: Bij data binding word een bepaald component in de grafische interface direct verbonden aan een data variabele. Wanneer de data variabele wijzigt zal het component zich opnieuw renderen. Dit voorkomt dat een pagina geheel moet herladen en creeert een dynamische web ervaring.

<font size="1">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>

## 4. Technische keuzes

Het project zal geprogrammeerd worden in de laatste versie van C#, C# 10. C# is een "strongly typed" programmeer taal gebasseerd op het .NET framework. Er is voor deze programmeer taal gekozen omdat het team dat de opdracht zal uitvoeren het meest bekend is met deze programmeertaal. Voor C# zijn vele verschillende libraries beschikbaar, binnen C# heten deze NuGet packages, deze packages voorkomen dat veel voorkomende functionaliteit opnieuw ontworpen hoeft te worden en bevatten bestaande oplossingen die binnen je eigen applicatie te integreren zijn. In onderstaande worden deze packages en de keuze daarvoor toegelicht.

- Enitity Framework Core 6 SqlServer: Voor de persistentie van data maken wij gebruiken van een ORM framework. Alhoewel er alternatieven beschikbaar zijn is het meest gebruikte ORM framework voor C# Entity Framework (EF), dit ORM framework is ontwikkelt door Microsoft zelf. Het gebruik van een ORM framework voorkomt dat men zelf SQL queries moet schrijven voor het bewerken en ophalen van data in de database. Deze sql queries worden automatisch gegeneerd door EF wanneer aangegeven word dat de data gepersisteerd mag worden, dit gebeurd op basis van de gemaakte wijzigingen in de data sets die men gespecificeerd heeft. In dit geval hebben wij gekozen voor de SqlServer variant, deze package maakt het mogelijk om T-SQL queries te genereren voor Microsoft SQL Server en Azure SQL Edge. Wij kiezen in dit geval om bij dezelfde vendor (Microsoft) te blijven aangezien ervaring leert dat dit vaak zorgt voor de beste integratie.
- Ardalis Specification: De Ardalis Specification fungeert als een wrapper om de Entity Framework repository. Deze wrapper maakt het mogelijk om queries uit te voeren middels specifications daarnaast accepteert de wrapper een generic parameter die naar een DbSet refereert, dit vereenvoudigd het maken van een generieke service aangezien de repository bijhorend bij de service nu als een generic gespecificeerd kan worden.
- Microsoft MVC: Het Api project maakt gebruik van het Microsoft MVC framework. Dit framework bevat een groot scala aan functionaliteit, zo bevat het een gestandardiseerde oplossing voor dependency injection, maakt het ons mogelijk om controllers te gebruiken en bied het een configuration management oplossing aan die het mogelijk maakt de configuratie voor de applicatie via een extern bestand te beheren.
- Identity: Identity is net als MVC een groot scala aan gebundelde functionaliteiten, deze functionaliteiten zijn allen gericht op authenticatie en authorisatie. Het identity framework ontwikkelt door Microsoft bied een gestandaardiseerde oplossing voor gebruikersauthenticatie en het inloggen, registreren en uitloggen van deze gebruikers. Ook bied het mogelijkheden tot role based access, het gebruik van claims en JWT token en zelf de mogelijkheid om te integreren met externe authenticatie providers via OAuth2. Een mooie bijkomstigheid is dat het naadloos integreert met Microsoft MVC.
- Swagger: Swagger stelt een grafische interface beschikbaar die gegenereerd word op basis van de bestaande controllers en hun bijhorende methoden. Zo maakt Swagger grafisch inzichtelijk wat een request precies aan parameters of body verwacht en wat het format is van de bijhorende response. Swagger stelt de gebruikers zelfs in staat om middels te grafische interface de api aan te roepen en dus te testen. 
- AutoMapper: AutoMapper maakt het mogelijk om middels een vooraf gedefineerde mapping types te impliciet te casten. Dit is zeer handig bij het gebruik van request en response DTO waar de eigenschappen van een DTO en een entiteit op elkaar "gemapt" worden en voorkomt dat dat een zelfgemaakte implementatie benodigd is voor deze conversie.
- Newtonsoft Json: Voorziet in het serialiseren van objecten naar JSON en het deseraliseren van JSON naar objecten. 
- Blazor WASM: Blazor WASM is een web framework dat gebruikt maakt van web assembly. Blazor maakt het mogelijk om C# te compileren naar web assembly en deze code vervolgens uit te voeren in de browser van de eindgebruiker. Microsoft stuurt aan op het gebruik van Blazor Server en Blazor WASM als de nieuwe standaard voor web ontwikkeling binnen de Microsoft Suite. Gezien de mate waarin Microsoft het gebruik van Blazor stimuleert valt er te stellen dat dit voorlopig een toekomstbestendige oplossing is. De adoptatie van Blazor is eenvoudig voor een C# ontwikkelaar en voorkomt dat men de learning curve van een JavaScript framework als Angular, React of Vue moet ondergaan.
- Blazor Local Storage: Maakte het mogelijk om de lokale browser opslag aan de client zijde te gebruiken. Deze opslag blijft bewaard zelf na het sluiten van de browser en maakt het bijvoorbeeld mogelijk om authenticatie tokens voor langer gebruik op te slaan zodat men zich niet steeds hoeft te authenticeren.
- Blazor Authentication: Blazor Auhtentication maakt het mogelijk om gebruik te maken van de eigenschappen van een gebruikers identity binnen de gebruikers interface. Zo maakt het Blazor Authentication het mogelijk om gehele web pagina of bepaalde aspecten daarvan alleen beschikbaar te stellen aan geauthenticeerde gebruikers of gebruikers die een of meerdere specifieke rollen hebben.
- Bootstrap 5: Bootstrap 5 is een CSS framework en maakt het met relatief weinig effort en alleen HTML mogelijk om een mooie gebruikers interface te realiseren.
- Flurl: Flurl is een wrapper om de standaard HttpClient die met C# geleverd word. De wrapper maakt gebruik van een fluent syntax voor request/url building wat resulteert in een stuk gebruikersvriendelijke manier van het maken van HTTP request. Daarnaast is Flurl ook unit testbaar, je kan exact testen op de headers, body en url die Flurl zal gebruiken voor haar requesten.

<font size="1">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>

# 5. Design

## 5.1. Api, Repository & Service Design

```mermaid
classDiagram

class BaseController
class BaseService
class BaseRepository

```

## 5.2. Domein Design

```mermaid
classDiagram

class Adres{
    + Id : int
    + Straat : string
    + Huisnummer : string
    + Toevoeging : string [0..1]
    + Postcode : string
    + Plaatsnaam : string
    + Adres(Id : int, Straat : string, Huisnummer : string, Postcode : string, Plaatsnaam : string, Toevoeging : string = null)
}

class Beoordeling{
    + Id : int
    + Beoordeling(tentamenUitvoering : TentamenUitvoering, beoordelingVoor : Student,  beoordeeldDoor : Docent)
}
Beoordeling "*" --> "1" Student : BeoordelingVoor
Beoordeling "*" --> "1" Docent : BeoordeeldDoor

class BeoordelingsCriteria{
    + Id : int
    + Omschrijving : string
    + BeoordelingsCriteria(omschrijving : string)
}

class BeroepsProduct{
    + Id : int
    + Titel : string
    + Weging : int 
    + TeBehalenStudiepunten : int 
    + BeroepsProduct(titel : string)
    + void AddRubrics(rubric : Rubric)
    + void RemoveRubrics(rubric : Rubric)
}
BeroepsProduct "1" <--* "*" Rubric : Rubrics
BeroepsProduct "1" -- "1" TentamenType : TentamenType
BeroepsProduct "*" *--> "1" CourseInrichting
BeroepsProduct --|> TentamenInrichting

class CourseInrichting {
    + Id : int
    + Titel : string
    + Omschrijving : string 
    + IsDefinitief = false : bool
    + AanmaakDatum : DateTimeOffset 
    + CourseInrichting(title : string, omschrijving : string, aangemaaktDoor : Docent)
    + void MaakDefinitief()
    + void AddEenheidVanLeeruitkomsten(eenheidVanLeeruitkomsten : EenheidVanLeeruitkomsten)
    + void RemoveEenheidVanLeeruitkomsten(eenheidVanLeeruitkomsten : EenheidVanLeeruitkomsten)
    + void AddBeroepsProduct(beroepsProduct : BeroepsProduct)
    + void RemoveBeroepsProduct(beroepsProduct : BeroepsProduct)
    + void AddToets(toets : SchriftelijkeToets)
    + void RemoveToets(toets : SchriftelijkeToets)
    + void AddLes(lesInrichting : LesInrichting)
    + void RemoveLes(lesInrichting : LesInrichting)
    + void CreatePlanning(duur : ITijdDefinitie)
    + void RemovePlanning()
    + CourseUitvoering StartCourseUitvoering(date : DateTimeOffset)
}
CourseInrichting "*" <-- "1" Persoon : AangemaaktDoor
CourseInrichting "1" <--* "1" CourseWeekPlanning : Planning
CourseInrichting -- ITijdDefinitie
CourseInrichting "1" <--* "*" EenheidVanLeeruitkomsten : Evls
CourseInrichting "1" <--* "*" BeroepsProduct : BeroepsProducten
CourseInrichting "1" <--* "*" SchriftelijkeToets : Toetsen
CourseInrichting "1" <--* "*" LesInrichting : Lessen

class CourseUitvoering {
    + Id : int
    + StartDatum : DateTimeOffset
    + CourseUitvoering(courseInrichting : CourseInrichting, startdatum : DateTimeOffset)
    - void creeerWeekUitvoeringen()
}
CourseUitvoering "*" *--> "1" CourseInrichting : CourseInrichting
CourseUitvoering "1" <--* "*" CourseWeekUitvoering : Weken

class CourseWeekInrichting{
    + Id : int
    + void AddToets : SchriftelijkeToets)
    + void RemoveToets(schriftelijkeToets : SchriftelijkeToets)
    + void RemoveBeroepsProduct(beroepsProduct : BeroepsProduct)
    + void RemoveBeroepsProduct(beroepsProduct : BeroepsProduct)
    + void RemoveLes(les : LesInrichting)
    + void RemoveLes(les : LesInrichting)
}
CourseWeekInrichting "1" <--* "*" SchriftelijkeToets : SchriftelijkeToets 
CourseWeekInrichting "1" <--* "*" BeroepsProduct : BeroepsProduct
CourseWeekInrichting "1" <--* "*" LesInrichting : LesInrichting

class CourseWeekPlanning{
    + Id : int
    + CourseWeekPlanning(duur : ITijdDefinitie)
    - void vulPlanningMetWeken()
}
CourseWeekPlanning "*" --> "1" ITijdDefinitie : Duur
CourseWeekPlanning "1" <--* "*" CourseWeekInrichting : Weken

class CourseWeekUitvoering{
    + Id : int
    + Maandag : DateTimeOffset 
    + CourseWeekUitvoering(date : DateTimeOffset, courseWeekInrichting : CourseWeekInrichting)
    - void creeerTentamenUitvoeringen()
    - void creeerLesUitvoeringen()
}
CourseWeekUitvoering "*" *--> "1" CourseWeekInrichting : CourseWeekInrichting
CourseWeekUitvoering "1" --> "*" TentamenUitvoering : Tentamen
CourseWeekUitvoering "1" --> "*" LesUitvoering : Lessen

class EenheidVanLeeruitkomsten{
    + Id : int
    + Titel : string
    + Omschrijving : string
    + EenheidVanLeeruitkomsten(titel : string, omschrijving : string)
    + void AddLeeruitkomst(Leeruitkomst)
    + void RemoveLeeruitkomst(Leeruitkomst)
}
EenheidVanLeeruitkomsten "1" <--* "*" Leeruitkomst : Leeruitkomsten

<<Interface>> ITijdDefinitie
class ITijdDefinitie{
    + DuurInWeken : int
    + TeBehalenStudiepunten : int
}

class Klas{
    + Id : int
    + Code : string
    + void AddStudent(Student)
    + void RemoveStudent(Student)
}
Klas "1" --> "1" Persoon : Mentor
Klas "1" --> "*" Persoon : Studenten

class Leerdoel{
    + Id : int
    + Titel : string
    + Omschrijving : string
    - _lesEenheden : IEnumerable<Validator> 
    + Leerdoel(titel : string, omschrijving : string)
    + void KoppelRubrics(Rubric)
    + void OntkoppelRubric(Rubric)
    + void KoppelLes(LesInrichting)
    + void OntkoppelLes(LesInrichting)
    + void KoppelToets(SchriftelijkeToets)
    + void OntkoppelToets(SchriftelijkeToets)
}
Leerdoel "1" --> "*" Rubric : GekoppeldeRubrics
Leerdoel "1" --> "*" LesInrichting : GekoppeldeLessen
Leerdoel "1" --> "*" SchriftelijkeToets : GekoppeldeToetsen

class Leeruitkomst{
    + Id : int
    + Titel : string
    + Omschrijving : string
    + Leeruitkomst(titel : string, omschrijving : string)
    + void KoppelLeerdoel(leerdoel : Leerdoel)
    + void OntkoppelLeerdoel(leerdoel : Leerdoel)
}
Leeruitkomst "1" --> "*" Leerdoel : Leerdoelen

class LesInrichting{
    + Id : int
    + Titel : string
    + LesInrichting(titel : string)
    + void AddLesMateriaal(lesMateriaal : LesMateriaal)
    + void RemoveLesMateriaal(lesMateriaal : LesMateriaal)
}
LesInrichting "1" --> "*" LesMateriaal : LesMateriaal
LesInrichting --|> Validator

class LesMateriaal{
    + Id : int
    + LesMateriaal()
    - List<LesMateriaalLine> genereerInhoud()
}
LesMateriaal "1" --> "*" LesMateriaalLine : Inhoud

class LesMateriaalLine{
    + Id : int
    + Line : string
    + LesMateriaalLine(line : string)
}

class LesUitvoering{
    + int Id
    + LesUitvoering(lesInrichting : LesInrichting)
}
LesUitvoering "*" *--> "1" LesInrichting : LesInrichting
LesUitvoering "*" --> "1" Docent : Docent
LesUitvoering "*" --> "1" Locatie : Locatie

class Locatie{
    + Id : int
    + Naam : string
    + Locatie(naam : string, locatieType : string)
}
Locatie -- LocatieType : LocatieType
Locatie "1" --> "1" Adres : Adres

<<Enumeration>> LocatieType

class Opleiding{
    + Id : int
    + Naam : string
    + Code : string
    + Opleiding(naam : string, code : string)
    + void AddOpleidingsProfiel(profiel : OpleidingsProfiel)
    + void RemoveOpleidingsProfiel(profiel : OpleidingsProfiel)
}
Opleiding "1" <--* "*" OpleidingsProfiel : OpleidingsProfiel

class OpleidingsProfiel{
    + Id : int
    + Naam : string
    + Code : string
    + OpleidingsProfiel(naam : string, code : string)
}

class Periode {
    + DuurInWeken = 10
    + TeBehalenStudiepunten = 15
}
Periode --|> ITijdDefinitie

<<interface>> Persoon
class Persoon {
    + Voornaam : string
    + Achternaam : string
}
Persoon "*" --> "0..1" OpleidingsProfile : VolgtProfiel
Persoon "*" --> "0..1" CourseUitvoering : VolgtCourse

class Rubric {
    + Id : int
    + Titel : string
    + Weging = 0 : int
    + VoldoendeThreshold = 0 : int
    + int KnockoutThreshold = 0
    + Rubric(titel : string)
    + void AddBeoordelingsCriteria(BeoordelingsCriteria)
    + void RemoveBeoordelingsCriteria(BeoordelingsCriteria)
}
Rubric "1" <--* "*" BeoordelingsCriteria : BeoordelingsCriteria
Rubric --|> Validator

class SchriftelijkeToets {
    + SchriftelijkeToets(titel : string)
}
SchriftelijkeToets "*" --> "1" CourseInrichting
SchriftelijkeToets --|> TentamenInrichting
SchriftelijkeToets --|> Validator

class Semester {
    + DuurInWeken = 20 : int
    + TeBehalenStudiepunten = 30 : int
}
Semester --|> ITijdDefinitie

<<interface>> TentamenInrichting
class TentamenInrichting{
    + Id : int
    + Titel : string
    + Weging : int
    + TeBehalenStudiepunten : int
}
TentamenInrichting "*" --> "1" TentamenType : Type

<<Enumeration>> TentamenType

class TentamenUitvoering{
    + Id : int
    + TentamenUitvoering(schriftelijkeToets : SchriftelijkeToets)
    + TentamenUitvoering(beroepsProduct : BeroepsProduct)
}
TentamenUitvoering "*" --> "1" SchriftelijkeToets
TentamenUitvoering "*" --> "1" BeroepsProduct
TentamenUitvoering "*" --> "1" Locatie
TentamenUitvoering "*" --> "1" Docent

<<interface>> Validator
class Validator{
    + Validate()
}

```

---
:warning: **_CRITERIA:_**
Correct toepassen standaard notatie en het diagram moet de volledig requirements afdekken.

---

### 5.2.1 Toelichting

---
:warning: **_CRITERIA:_**
Minimaal 1 extra diagram (geen class diagram) opnemen, diverse modellen vereist voor een 8

---

### 5.2.2. Domein consistentie/inconsistentie

- additionele interfaces
- course bieb is weg
- ef core constructor
- persoon weg
  
---
:warning: **_CRITERIA:_**
Zowel inconsistenties als consistenties benoemd, inconsistenties volledig van relevante, onderbouwde verbetervoorstellen voorzien voor een 10

---

## 5.3 UC-15 Start Uitvoering

---
:warning: **_CRITERIA:_**
Ontwerp problemen identificeren en ontwerp keuzes onderbouwen met relevant alternatieven en overwegingen voor een 10

---

---
:warning: **_NOTE:_**
een variatie aan principes en patterns op correcte en onderbouwde manier toegepast voor een 10

---

### 5.3.1. Design

```mermaid
sequenceDiagram
    autonumber
    Client->>CourseInrichting: startUitvoering()
    activate CourseInrichting
    CourseInrichting->>CourseUitvoering: CourseUitvoering(this, date)
    deactivate CourseInrichting
    activate CourseUitvoering
    CourseUitvoering->>DateOnly: StartDate = GetMondayOfThisWeek()
    CourseUitvoering->>CourseUitvoering: creeerWeekUitvoeringen()
    
    loop week in CourseInrichting.Planning.Weken
        CourseUitvoering->>CourseWeekUitvoering: weekUitvoering = CourseWeekUitvoering(week, StartDate)
        CourseUitvoering->>CourseUitvoering: Weken.Add(weekUitvoering)
        deactivate CourseUitvoering

        activate CourseWeekUitvoering

        CourseWeekUitvoering->>CourseWeekUitvoering: creeerTentamen()
        loop schriftelijkeToets in CourseWeekInrichitng.SchiftelijkeToets
            CourseWeekUitvoering ->> TentamenUitvoering: tentamenUitvoering = TentamenUitvoering(schriftelijkeToets)
            CourseWeekUitvoering->>CourseWeekUitvoering: _tentamen.Add(tentamenUitvoering)
        end
        loop beroepsProduct in CourseWeekInrichitng.Beroepsproduct
            CourseWeekUitvoering ->> TentamenUitvoering: tentamenUitvoering = TentamenUitvoering(beroepsProduct)
            CourseWeekUitvoering->>CourseWeekUitvoering: _tentamen.Add(tentamenUitvoering)
        end

        CourseWeekUitvoering->>CourseWeekUitvoering: creeerLessen()
        loop les in CourseWeekInrichting.Lessen
            CourseWeekUitvoering->>LesUitvoering: lesUitvoering = new LesUitvoering(les);
            CourseWeekUitvoering->>CourseWeekUitvoering: _les.Add(lesUitvoering)
        end

    end
    deactivate CourseWeekUitvoering
    
```

```mermaid
classDiagram

    class CourseInrichting {
        + Planning : CourseWeekPlanning
        + StartCourseUitvoering(date : DateTimeOffset)
    }

    class CourseUitvoering {
        + CourseUitvoering(inrichting : CourseInrichting, date : DateTimeOffset)
        - creeerWeekUitvoeringen()
    }

    class CourseWeekUitvoering {
        + CourseWeekUitvoering(inrichting : CourseWeekInrichting, maandag : DateTimeOffset)
        - creeerTentamenUitvoeringen()
        - creeerLesUitvoeringen()
    }

    class TentamenUitvoering {
        + SchriftelijkeToets : SchriftelijkeToets [0..1]
        + BeroepsProduct : BeroepsProduct [0..1]
        + TentamenUitvoering(schriftelijkeToets : SchriftelijkeToets)
        + TentamenUitvoering(beroepsProduct : BeroepsProduct)
    }

    class LesUitvoering {
        - LesInrichting : LesInrichting
        + LesUitvoering(lesInrichting: LesInrichting)
    }


    class DateTimeOffset {
        + GetMondayOfThisWeek()
    }

    CourseUitvoering -- DateTimeOffset
    CourseInrichting "1" <--o "0..*" CourseUitvoering 
    CourseWeekUitvoering "1..*" o--> "1" CourseUitvoering 
    LesUitvoering "1..*" o--> "1" CourseWeekUitvoering
    TentamenUitvoering "1..*" o--> "1" CourseWeekUitvoering
```

---
:warning: **_NOTE:_**
Class Diagram en/of sequence diagram toegespitst op de use case.

---

### 5.3.2. Toelichting

---
:warning: **_NOTE:_**
Toelichten van gebruikte GoF patterns, SOLID principes & GRASP principes.

---

<font size="1">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>

## 5.4 UC-18 Exporteer Informatie

---
:warning: **_CRITERIA:_**
Ontwerp problemen identificeren en ontwerp keuzes onderbouwen met relevant alternatieven en overwegingen voor een 10

---

---
:warning: **_NOTE:_**
een variatie aan principes en patterns op correcte en onderbouwde manier toegepast voor een 10

---

### 5.4.1. Design

### 5.4.2. Toelichting

---
:warning: **_NOTE:_**
Toelichten van gebruikte GoF patterns, SOLID principes & GRASP principes.

---


# 6. Overige

## 6.1. Versiebeheer

De bron code word ondergebracht in Github, versie beheer word uitgevoerd door middel van Git. Binnen Git zal er gewerkt worden middels verschillende branches:

- Master: De master branch bevat altijd de laatste productie versie van de applicatie.
- Develop: De develop branch bevat altijd de versie van de applicatie die op het moment in ontwikkeling is.
- Feat/Fix: Een feature branch bevat de incrementele toevoeging van een feature aan de applicatie. Een fix branch bevat de aanpassingen om een bug op te lossen. 

Men dient altijd te programmeren in een feature of een fix branch, deze feature of fix branches zijn gebasseerd op de laatste versie van de develop branch. Wanneer een feature of fix afgerond is dient de ontwikkelaar een pull request aan te maken binnen Github die de feature of fix zal mergen in de develop branch. Wanneer de development versie gereed is voor productie dienst er een pull request aangemaakt te worden die de development branch merged in de master branch. 

```mermaid
  gitGraph
    commit id: "init main"
    branch develop
    commit id: "init develop"
    branch feat/uc15-start-uitvoering
    commit id: "changes for new feature"
    checkout develop
    merge feat/uc15-start-uitvoering
    checkout main
    merge develop
```

## 6.2. Build Management (CI/CD)

Door een pull request naar de master branch word een pipeline getriggerd, deze pipeline is ingericht in Github Actions en voert de volgende stappen uit.

1. De api applicatie word gebuild en bijhorende unit tests worden uitgevoerd, indien de testen falen word de pipeline gestopt.
2. De api dockerfile word gebuild, deze docker file build de applicatie en verpakt deze vervolgens in een container die geupload word naar een docker hub registry.
3. De web dockerfile word gebuild, deze docker file build de web applicatie, dit resulteert in een set statische files die vervolgens gekopieerd worden in de web root van een nginx container, deze nginx container word vervolgens geupload naar een docker hub repository.

## 6.3. Unit-, Integratie- Tests

Het project bevat zowel unit als integratie testen, deze testen zijn ondergebracht in de projecten `HAN.ICDETool.Tests.Unit` en `HAN.ICDETool.Tests.Integration`. Zowel de unit als de integratie testen maken gebruik van het nUnit test framework. De unit testen zijn gericht op de domein functionaliteit en de integratie testen op de integratie tussen de api client en de api server, deze testen vereisen dus dat het api project gestart is. Om te verzekeren dat er data aanwezig om de api client mee te testen word de database bij het starten van de api server automatisch geseed met dummy data indien deze leeg is.

## 6.4. Deployment

De web en api containers dienen gehost te worden, zowel de web als de api container zal beschikbaar zijn voor HTTP verzoeken via TCP poort 80. Mocht HTTPS gewenst zijn dan dient dit opgelost te worden middels een reverse proxy die het geencrypte verkeer zal offloaden. In de root van de code repository staat een `docker-compose.yml`, dit bestand beschrijft hoe de omgeving gehost kan worden, uiteraard ben je niet verbonden aan docker en zijn de container ook onder te brengen in bijvoorbeeld Kubernetes.

<font size="1">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>

# 7. Bronnen

|APA Bronvermelding|
|------------------|
|{clean architecture}
|{DDD}
|{Pluralsight courses}
|{refactoring guru}

<font size="1">[:point_up_2: [Inhoudsopgave](#inhoudsopgave)]</font>
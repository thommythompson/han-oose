[Terug](./index.md)

---
:warning: **_NOTE:_**
Nog valideren tegen over use case model dat in onderwijs online staat.

---

# CRUD Use Case Overview

- [Create](#create)
- [Read](#read)
- [Update](#update)
- [Delete](#delete)

# **Create**

| | |
|-|-|
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

# **Read**

| | |
|-|-|
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

# **Update**

| | |
|-|-|
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

# **Delete**

| | |
|-|-|
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
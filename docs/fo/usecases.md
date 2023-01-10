[Terug](./index.md)

# Use Case Overview

## CRUD Specificatie

- [X] [UC-1 - Ontwikkel Course](#uc-1-ontwikkel-course)
- [x] [UC-3 - Beheer Gebruikers](#uc-3-beheer-gebruikers)
- [x] [UC-4 - Beheer Klassen](#uc-4-beheer-klassen)
- [ ] [UC-5 - Vraag course info op](#uc-5-vraag-course-info-op)
- [ ] [UC-6 - Vraag course info op](#uc-6-vraag-courseplanning-op)
- [x] [UC-7 - Beheer Opleidingen](#uc-7-beheer-opleidingen)
- [ ] [UC-8 - Geef beoordeling](#uc-8-geef-beoordeling)
- [x] [UC-9 - Beheer Opleidingsprofielen](#uc-9-beheer-opleidingsprofielen)
- [x] [UC-10 - Ontwikkel Leeruitkomst](#uc-10-ontwikkel-leeruitkomst)
- [ ] [UC-11 - Ontwikkel EVL](#uc-11-ontwikkel-evl)
- [x] [UC-12 - Ontwikkel Leerdoelen](#uc-12-ontwikkel-leerdoelen)
- [ ] [UC-19 - Beheer Locaties](#uc-19-beheer-locaties)

## Fully Dressed

- [x] [UC-2 - Bekijken beoordelingen](#uc-2-bekijken-beoordelingen)
- [ ] [UC-13 - Ontwikkel toets](#uc-13-ontwikkel-toets)
- [ ] [UC-14 - Maak rubriek](#uc-14-maak-rubriek)
- [x] [UC-15 - Start Uitvoering](#uc-15-start-uitvoering)
- [x] [UC-16 - Maak course planning definitief](#uc-16-maak-course-template-definitief)
- [x] [UC-17 - Maak Weekplanning](#uc-17---maak-weekplanning)
- [ ] [UC-18 - Exporteer informatie](#uc-18-exporteer-informatie)
- [x] [UC-20 - Aanmelden](#uc-20-aanmelden)
- [ ] [UC-21 - Ontwikkel beroepsproduct](#uc-21-ontwikkel-beroepsproduct)
- [ ] [UC-22 - Ontwikkel Les](#uc-22-ontwikkel-les)

# **UC-1 Ontwikkel Course**

<table>
  <tbody>
    <tr>
      <td><strong>ID</strong></td>
      <td>&nbsp;UC-1</td>
    </tr>
    <tr>
      <td><strong>Naam</strong></td>
      <td>Ontwikkel Course</td>
    </tr>
    <tr>
      <td><strong>Omschrijving</strong></td>
      <td>
        <p>Een course dient als template voor een uitvoering. Deze template kan, wanneer de template definitief wordt
          gemaakt, gebruikt worden om een course te starten. Tijdens het proces kunnen de onderliggende objecten
          iteratief aangemaakt worden.</p>
        Deze use case is gebaseerd op het CRUD-template
      </td>
    </tr>
    <tr>
      <td><strong>Scope</strong></td>
      <td>&nbsp;ICDE-Tool</td>
    </tr>
    <tr>
      <td><strong>Trigger</strong></td>
      <td>&nbsp;Gebruikers Interactie</td>
    </tr>
    <tr>
      <td><strong>Level</strong></td>
      <td>&nbsp;User-Goal</td>
    </tr>
    <tr>
      <td><strong>Primary Actor</strong></td>
      <td>&nbsp;Docent</td>
    </tr>
    <tr>
      <td><strong>Belangen &amp; belanghebbenden</strong></td>
      <td>
        <div>- Docent: wil een course template maken en/of aanpassen.</div>
      </td>
    </tr>
    <tr>
      <td><strong>Pre-Condities</strong></td>
      <td>
        <p>- Gebruiker is aangemeld als docent</p>
      </td>
    </tr>
    <tr>
      <td><strong>Succes definitie</strong></td>
      <td>Er is een nieuw coursetemplate aangemaakt</td>
    </tr>
    <tr>
      <td><strong>Requirements</strong></td>
      <td>FR-1,28</td>
    </tr>
    <tr>
      <td colspan="2"><strong>Main Success Scenario</strong></td>
       <td></td>
    </tr>
    <tr>
      <td><strong>Create/Update:</strong></td>
      <td>&nbsp;</td>
    </tr>
    
  </tbody>
</table>

# **UC-2 Bekijken beoordelingen**

<table>
  <tbody>
    <tr>
      <td><strong>ID</strong></td>
      <td>&nbsp;UC-2</td>
    </tr>
    <tr>
      <td><strong>Naam</strong></td>
      <td>&nbsp;Bekijken beoordelingen</td>
    </tr>
    <tr>
      <td><strong>Omschrijving</strong></td>
      <td>&nbsp;Deze use case is verantwoordelijk voor het inzichtelijk maken van beoordelingen voor studenten.</td>
    </tr>
    <tr>
      <td><strong>Scope</strong></td>
      <td>&nbsp;ICDE-Tool</td>
    </tr>
    <tr>
      <td><strong>Trigger</strong></td>
      <td>&nbsp;Gebruikers Interactie</td>
    </tr>
    <tr>
      <td><strong>Level</strong></td>
      <td>&nbsp;User-Goal</td>
    </tr>
    <tr>
      <td><strong>Primary Actor</strong></td>
      <td>&nbsp;Student</td>
    </tr>
    <tr>
      <td><strong>Belangen &amp; belanghebbenden</strong></td>
      <td>&nbsp;- Student: Wil zijn/haar voorgang en behaalde resultaten kunnen bekijken.</td>
    </tr>
    <tr>
      <td><strong>Pre-Condities</strong></td>
      <td>&nbsp;- Authenticatie is afgehandeld; gebruiker is bevoegd om op het systeem in te loggen.</td>
    </tr>
    <tr>
      <td><strong>Succes definitie</strong></td>
      <td>&nbsp;- Er word een overzicht getoond van de course voortang in de vorm van een lijst van behaalde resultaten
        en het aantal behaalde studiepunten ten opzichte van het totaal haalbare aantal studiepunten.</td>
    </tr>
    <tr>
      <td><strong>Requirements</strong></td>
      <td>&nbsp;
        <div>
          <div>FR-38</div>
        </div>
      </td>
    </tr>
    <tr>
      <td colspan="2"><strong>Main Success Scenario</strong></td>
    </tr>
    <tr>
      <td><strong>Actor</strong></td>
      <td><strong>System</strong></td>
    </tr>
    <tr>
      <td>&nbsp;
        <div>
          <div>1. De student vraagt aan het systeem om een overzicht van alle beoordelingen.</div>
        </div>
      </td>
      <!-- 1.A  -->
      <td>&nbsp;</td>
      <!-- 1.B  -->
    </tr>
    <tr>
      <td>&nbsp;</td>
      <!-- 2.A  -->
      <td>&nbsp;
        <div>
          <div>2. Het systeem haalt alle tentamineringen van de student op (ook die waarvoor nog geen beoordeling
            behaald is).</div>
        </div>
      </td>
      <!-- 2.B  -->
    </tr>
    <tr>
      <td>&nbsp;</td>
      <!-- 3.A  -->
      <td>&nbsp;
        <div>
          <div>3. Het systeem categoriseert de beoordelingen per course uitvoering.</div>
        </div>
      </td>
      <!-- 3.B  -->
    </tr>
    <tr>
      <td>&nbsp;</td>
      <!-- 4.A  -->
      <td>&nbsp;
        <div>
          <div>4. Het systeem berekent per course uitvoering het behaalde aantal studiepunten en de eindbeoordeling voor
            de course. (Een optelsom van de voorgeschreven studiepunten van de tentamineringen die onderdeel zijn van de
            desbetreffende course en voldoende afgerond zijn door de student)</div>
        </div>
      </td>
      <!-- 4.B  -->
    </tr>
    <tr>
      <td>&nbsp;</td>
      <!-- 5.A  -->
      <td>&nbsp;
        <div>
          <div>5. Het systeem toont een overzicht van alle beoordelingen.</div>
        </div>
      </td>
      <!-- 5.B  -->
    </tr>
    
  </tbody>
</table>


<font size="1">[:point_up_2: [Overview](#use-case-overview)]</font>

# **UC-1 - Ontwikkel Course**

<table>
  <tbody>
    <tr>
      <td><strong>ID</strong></td>
      <td>&nbsp;UC-1</td>
    </tr>
    <tr>
      <td><strong>Naam</strong></td>
      <td>&nbsp;Docent</td>
    </tr>
    <tr>
      <td><strong>Omschrijving</strong></td>
      <td>&nbsp;Deze use case is gebaseerd op het CRUD-template, binnen deze use case worden alleen uitzonderingen of
        specificiteit belicht.</td>
    </tr>
    <tr>
      <td><strong>Scope</strong></td>
      <td>&nbsp;ICDE-Tool</td>
    </tr>
    <tr>
      <td><strong>Trigger</strong></td>
      <td>&nbsp;Gebruikers Interactie</td>
    </tr>
    <tr>
      <td><strong>Level</strong></td>
      <td>&nbsp;User-Goal</td>
    </tr>
    <tr>
      <td><strong>Primary Actor</strong></td>
      <td>&nbsp;Docent</td>
    </tr>
    <tr>
      <td><strong>Belangen &amp; belanghebbenden</strong></td>
      <td>
        <p>- Docent: wil een course template maken en/of aanpassen.
        </p>
        <p>- Student: </p>
      </td>
    </tr>
    <tr>
      <td><strong>Pre-Condities</strong></td>
      <td>&nbsp;- De docent is geauthentiseerd.
        <div>
          <div>- De desbetreffende klas waarvan de student lid moet worden bestaat al. (UC-4)</div>
        </div>
      </td>
    </tr>
    <tr>
      <td><strong>Succes definitie</strong></td>
      <td>&nbsp;</td>
    </tr>
    <tr>
      <td><strong>Requirements</strong></td>
      <td>&nbsp;FR-1,28,3</td>
    </tr>
    <tr>
      <td colspan="2"><strong>Main Success Scenario</strong></td>
    </tr>
    <tr>
      <td><strong>Actor</strong></td>
      <td><strong>System</strong></td>
    </tr>
    <tr>
      <td><strong>Create/Update:</strong></td>
      <td>&nbsp;De benodigde data zijn een naam, email adres en in het geval van een student ook een klas, het systeem
        valideert of in deze databehoefte voorzien is.</td>
    </tr>
    <tr>
      <td><strong>Delete:</strong></td>
      <td>&nbsp;In het geval van een student verwijdert het systeem de student en alle persoons informatie zoals
        eventuele beoordelingen voor tentamens die hij/zij behaalt heeft. In het geval van een docent wordt er gekeken
        of de docent gerelateerd is aan een entiteit binnen het systeem, zoals een beoordeling, les of tentaminering,
        als dit een geval is kan de docent niet verwijderd worden.</td>
    </tr>
  </tbody>
</table>




<font size="1">[:point_up_2: [Overview](#use-case-overview)]</font>

# **UC-3 Beheer Gebruikers**

<table>
  <tbody>
    <tr>
      <td><strong>ID</strong></td>
      <td>&nbsp;UC-3</td>
    </tr>
    <tr>
      <td><strong>Naam</strong></td>
      <td>&nbsp;Beheer Gebruikers</td>
    </tr>
    <tr>
      <td><strong>Omschrijving</strong></td>
      <td>&nbsp;Deze use case is gebaseerd op het CRUD-template, binnen deze use case worden alleen uitzonderingen of
        specificiteit belicht.</td>
    </tr>
    <tr>
      <td><strong>Scope</strong></td>
      <td>&nbsp;ICDE-Tool</td>
    </tr>
    <tr>
      <td><strong>Trigger</strong></td>
      <td>&nbsp;Gebruikers Interactie</td>
    </tr>
    <tr>
      <td><strong>Level</strong></td>
      <td>&nbsp;User-Goal</td>
    </tr>
    <tr>
      <td><strong>Primary Actor</strong></td>
      <td>&nbsp;Docent</td>
    </tr>
    <tr>
      <td><strong>Belangen &amp; belanghebbenden</strong></td>
      <td>
        <p>- Docent: Wil een klas indeling kunnen bijhouden zodat studenten toegang krijgen tot het bijhorende course
          materiaal.</p>
        <p>- Student: Wil onderdeel zijn van een klas zodat men toegang krijgt tot het bijhorende course materiaal.</p>
      </td>
    </tr>
    <tr>
      <td><strong>Pre-Condities</strong></td>
      <td>&nbsp;- De docent is geauthentiseerd.
        <div>
          <div>- De desbetreffende klas waarvan de student lid moet worden bestaat al. (UC-4)</div>
        </div>
      </td>
    </tr>
    <tr>
      <td><strong>Succes definitie</strong></td>
      <td>&nbsp;</td>
    </tr>
    <tr>
      <td><strong>Requirements</strong></td>
      <td>&nbsp;FR-4</td>
    </tr>
    <tr>
      <td colspan="2"><strong>Main Success Scenario</strong></td>
    </tr>
    <tr>
      <td><strong>Actor</strong></td>
      <td><strong>System</strong></td>
    </tr>
    <tr>
      <td><strong>Create/Update:</strong></td>
      <td>&nbsp;De benodigde data zijn een naam, email adres en in het geval van een student ook een klas, het systeem
        valideert of in deze databehoefte voorzien is.</td>
    </tr>
    <tr>
      <td><strong>Delete:</strong></td>
      <td>&nbsp;In het geval van een student verwijdert het systeem de student en alle persoons informatie zoals
        eventuele beoordelingen voor tentamens die hij/zij behaalt heeft. In het geval van een docent wordt er gekeken
        of de docent gerelateerd is aan een entiteit binnen het systeem, zoals een beoordeling, les of tentaminering,
        als dit een geval is kan de docent niet verwijderd worden.</td>
    </tr>
  </tbody>
</table>

<font size="1">[:point_up_2: [Overview](#use-case-overview)]</font>

# **UC-4 Beheer Klassen**

<table>
  <tbody>
    <tr>
      <td><strong>ID</strong></td>
      <td>&nbsp;UC-4</td>
    </tr>
    <tr>
      <td><strong>Naam</strong></td>
      <td>Beheer Klassen</td>
    </tr>
    <tr>
      <td><strong>Omschrijving</strong></td>
      <td>Deze use case is gebaseerd op het CRUD template, binnen deze use case worden alleen uitzonderingen of
        specificiteit belicht.</td>
    </tr>
    <tr>
      <td><strong>Scope</strong></td>
      <td>&nbsp;ICDE-Tool</td>
    </tr>
    <tr>
      <td><strong>Trigger</strong></td>
      <td>&nbsp;Gebruikers Interactie</td>
    </tr>
    <tr>
      <td><strong>Level</strong></td>
      <td>&nbsp;User-Goal</td>
    </tr>
    <tr>
      <td><strong>Primary Actor</strong></td>
      <td>&nbsp;Docent</td>
    </tr>
    <tr>
      <td><strong>Belangen &amp; belanghebbenden</strong></td>
      <td>
        <div>
          <div>- Docent: Wil een klas registratie kunnen bijhouden zodat deze klas een course kan volgen.</div>
          <div>- Student: Wil onderdeel kunnen zijn van een klas registratie zodat hij/zij de course informatie van de
            courses die de klas volgt kan inzien.</div>
        </div>
      </td>
    </tr>
    <tr>
      <td><strong>Pre-Condities</strong></td>
      <td>
        <div>
          <div>- De docent is geauthentiseerd. (UC-20)</div>
          <div>- Het benodigde opleidingsprofiel is al aangemaakt. (UC-9)</div>
        </div>
      </td>
    </tr>
    <tr>
      <td><strong>Succes definitie</strong></td>
      <td>&nbsp;</td>
    </tr>
    <tr>
      <td><strong>Requirements</strong></td>
      <td>
        <div>
          <div>FR-29</div>
        </div>
      </td>
    </tr>
    <tr>
      <td colspan="2"><strong>Main Success Scenario</strong></td>
    </tr>
    <tr>
      <td><strong>Actor</strong></td>
      <td><strong>System</strong></td>
    </tr>
    <tr>
      <td><strong>Create/Update:</strong></td>
      <td>
        <div>
          <div>De benodigde data zijn een klas-id een naam voor de klas en een opleidingsprofiel dat de klas volgt, het
            systeem valideert of in deze databehoefte voorzien is.</div>
        </div>
      </td>
    </tr>
    <tr>
      <td><strong>Delete:</strong></td>
      <td>
        <div>
          <div>Het systeem controleer of er nog student onderdeel zijn van de klas en als deze gekoppeld is aan een
            course, een klas kan alleen verwijderd worden indien dit niet het geval is.</div>
        </div>
      </td>
    </tr>
  </tbody>
</table>

---
:warning: **_NOTE:_**
Een klas volgt een course maar technisch gezet wordt er tijdens het toevoegen van de klas aan de course iedere student individueel aan de course verbonden een student kan namelijk wisselen van klas en of blijven zitten. --> verwerken in UC-15 “Start Uitvoering”

---

<font size="1">[:point_up_2: [Overview](#use-case-overview)]</font>
# **UC-5 Vraag course info op**

<table>
<td><strong>TODO!</Strong></td>
</Table>

<font size="1">[:point_up_2: [Overview](#use-case-overview)]</font>
# **UC-6 Vraag courseplanning op**

<table>
<td><strong>TODO!</Strong></td>
</Table>

<font size="1">[:point_up_2: [Overview](#use-case-overview)]</font>

# **UC-7 Beheer Opleidingen**

<table>
  <tbody>
    <tr>
      <td><strong>ID</strong></td>
      <td>&nbsp;UC-7</td>
    </tr>
    <tr>
      <td><strong>Naam</strong></td>
      <td>Beheer Opleidingen</td>
    </tr>
    <tr>
      <td><strong>Omschrijving</strong></td>
      <td>Deze use case is gebaseerd op het CRUD template, binnen deze use case worden alleen uitzonderingen of
        specificiteit belicht.</td>
    </tr>
    <tr>
      <td><strong>Scope</strong></td>
      <td>&nbsp;ICDE-Tool</td>
    </tr>
    <tr>
      <td><strong>Trigger</strong></td>
      <td>&nbsp;Gebruikers Interactie</td>
    </tr>
    <tr>
      <td><strong>Level</strong></td>
      <td>&nbsp;User-Goal</td>
    </tr>
    <tr>
      <td><strong>Primary Actor</strong></td>
      <td>&nbsp;Docent</td>
    </tr>
    <tr>
      <td><strong>Belangen &amp; belanghebbenden</strong></td>
      <td>
        <div>- Docent: Wil beschikbare opleidingen kunnen bijhouden zodat &hellip;</div>
      </td>
    </tr>
    <tr>
      <td><strong>Pre-Condities</strong></td>
      <td>
        <div>- De docent is geauthentiseerd. (UC-20)</div>
      </td>
    </tr>
    <tr>
      <td><strong>Succes definitie</strong></td>
      <td>&nbsp;</td>
    </tr>
    <tr>
      <td><strong>Requirements</strong></td>
      <td>
        <div>
          <div>FR-29</div>
        </div>
      </td>
    </tr>
    <tr>
      <td colspan="2"><strong>Main Success Scenario</strong></td>
    </tr>
    <tr>
      <td><strong>Actor</strong></td>
      <td><strong>System</strong></td>
    </tr>
    <tr>
      <td><strong>Create/Update:</strong></td>
      <td>
        <div>
          <div>De benodigde data zijn een id en een naam, het systeem valideert of in deze databehoefte voorzien is.
          </div>
        </div>
      </td>
    </tr>
    <tr>
      <td><strong>Delete:</strong></td>
      <td>
        <div>
          <div>Het systeem controleert of er nog opleidingsprofielen gekoppeld zijn, een opleiding kan alleen verwijderd
            worden indien dit niet het geval is.</div>
        </div>
      </td>
    </tr>
  </tbody>
</table>

<font size="1">[:point_up_2: [Overview](#use-case-overview)]</font>
# **UC-8 Geef Beoordeling**

<table>
<td><strong>TODO!</Strong></td>
</Table>

<font size="1">[:point_up_2: [Overview](#use-case-overview)]</font>

# **UC-9 Beheer Opleidingsprofielen**

<table>
  <tbody>
    <tr>
      <td><strong>ID</strong></td>
      <td>&nbsp;UC-9</td>
    </tr>
    <tr>
      <td><strong>Naam</strong></td>
      <td>Beheer Opleidingsprofielen</td>
    </tr>
    <tr>
      <td><strong>Omschrijving</strong></td>
      <td>
        <div>
          <div>Deze use case is gebaseerd of het CRUD-template, binnen deze use case worden alleen uitzonderingen of
            specificiteit belicht.</div>
        </div>
      </td>
    </tr>
    <tr>
      <td><strong>Scope</strong></td>
      <td>&nbsp;ICDE-Tool</td>
    </tr>
    <tr>
      <td><strong>Trigger</strong></td>
      <td>&nbsp;Gebruikers Interactie</td>
    </tr>
    <tr>
      <td><strong>Level</strong></td>
      <td>&nbsp;User-Goal</td>
    </tr>
    <tr>
      <td><strong>Primary Actor</strong></td>
      <td>&nbsp;Docent</td>
    </tr>
    <tr>
      <td><strong>Belangen &amp; belanghebbenden</strong></td>
      <td>
        <div>
          <div>- Docent: Wil beschikbare opleidingsprofielen kunnen bijhouden zodat &hellip;</div>
        </div>
      </td>
    </tr>
    <tr>
      <td><strong>Pre-Condities</strong></td>
      <td>
        <div>- De docent is geauthentiseerd. (UC-20)</div>
        <div>
          <div>
            <div>- De desbetreffende opleiding waarvan onderdeel moet zijn bestaat al. (UC-7)</div>
          </div>
        </div>
      </td>
    </tr>
    <tr>
      <td><strong>Succes definitie</strong></td>
      <td>&nbsp;</td>
    </tr>
    <tr>
      <td><strong>Requirements</strong></td>
      <td>
        <div>
          <div>FR-29</div>
        </div>
      </td>
    </tr>
    <tr>
      <td colspan="2"><strong>Main Success Scenario</strong></td>
    </tr>
    <tr>
      <td><strong>Actor</strong></td>
      <td><strong>System</strong></td>
    </tr>
    <tr>
      <td><strong>Create/Update:</strong></td>
      <td>
        <div>
          <div>De benodigde data zijn een id en een naam, het systeem valideert of in deze databehoefte voorzien is.
          </div>
        </div>
      </td>
    </tr>
    <tr>
      <td><strong>Delete:</strong></td>
      <td>
        <div>
          <div>Het systeem controleert of er nog klassen gekoppeld zijn aan het huidige profiel, een opleidingsprofiel
            kan alleen verwijderd worden indien dit niet het geval is.</div>
        </div>
      </td>
    </tr>
  </tbody>
</table>

<font size="1">[:point_up_2: [Overview](#use-case-overview)]</font>

# **UC-10 Ontwikkel Leeruitkomst**

<table>
  <tbody>
    <tr>
      <td><strong>ID</strong></td>
      <td>&nbsp;UC-10</td>
    </tr>
    <tr>
      <td><strong>Naam</strong></td>
      <td>
        <div>
          <div>Ontwikkel Leeruitkomst</div>
        </div>
      </td>
    </tr>
    <tr>
      <td><strong>Omschrijving</strong></td>
      <td>
        <div>
          <div>Deze use case is gebaseerd op het CRUD-template, binnen deze use case worden alleen uitzonderingen of
            specificiteit belicht.</div>
        </div>
      </td>
    </tr>
    <tr>
      <td><strong>Scope</strong></td>
      <td>&nbsp;ICDE-Tool</td>
    </tr>
    <tr>
      <td><strong>Trigger</strong></td>
      <td>&nbsp;Gebruikers Interactie</td>
    </tr>
    <tr>
      <td><strong>Level</strong></td>
      <td>&nbsp;User-Goal</td>
    </tr>
    <tr>
      <td><strong>Primary Actor</strong></td>
      <td>&nbsp;Docent</td>
    </tr>
    <tr>
      <td><strong>Belangen &amp; belanghebbenden</strong></td>
      <td>
        <div>
          <div>- Docent: Wil vast kunnen leggen welke leeruitkomsten er binnen deze EVL behaald moeten worden zodat men
            hier passende leerdoelen aan kan verbinden.&nbsp;</div>
          <div>- Student: Wil deze vastlegging kunnen inzien zodat men weet wat de beoogde leeruitkomsten zijn.</div>
        </div>
      </td>
    </tr>
    <tr>
      <td><strong>Pre-Condities</strong></td>
      <td>
        <div>
          <div>- De gebruiker is geauthentiseerd als docent. (UC-20)</div>
          <div>- De EVL waaraan de leeruitkomst gekoppeld dient te worden bestaat al.</div>
        </div>
      </td>
    </tr>
    <tr>
      <td><strong>Succes definitie</strong></td>
      <td>&nbsp;</td>
    </tr>
    <tr>
      <td><strong>Requirements</strong></td>
      <td>
        <div>
          <div>FR-9</div>
        </div>
      </td>
    </tr>
    <tr>
      <td colspan="2"><strong>Main Success Scenario</strong></td>
    </tr>
    <tr>
      <td><strong>Actor</strong></td>
      <td><strong>System</strong></td>
    </tr>
    <tr>
      <td><strong>Create/Update:</strong></td>
      <td>
        <div>
          <div>De benodigde data zijn een titel, omschrijving &amp; EVL waaronder de leeruitkomst zal vallen, het
            systeem valideert of in deze databehoefte voorzien is.</div>
        </div>
      </td>
    </tr>
    <tr>
      <td><strong>Delete:</strong></td>
      <td>
        <div>
          <div>Het systeem controleer of er nog leerdoelen verbonden zijn aan de leeruitkomst, een leeruitkomst kan
            alleen verwijderd worden indien dit niet het geval is.</div>
        </div>
      </td>
    </tr>
  </tbody>
</table>

<font size="1">[:point_up_2: [Overview](#use-case-overview)]</font>

# **UC-11 Ontwikkel EVL**

<table>
<td><strong>TODO!</Strong></td>
</Table>

<font size="1">[:point_up_2: [Overview](#use-case-overview)]</font>

# **UC-12 Ontwikkel leerdoelen**

<table>
  <tbody>
    <tr>
      <td><strong>ID</strong></td>
      <td>&nbsp;UC-12</td>
    </tr>
    <tr>
      <td><strong>Naam</strong></td>
      <td>
        <div>
          <div>Ontwikkel Leerdoelen</div>
        </div>
      </td>
    </tr>
    <tr>
      <td><strong>Omschrijving</strong></td>
      <td>
        <div>
          <div>Deze use case is gebaseerd op het CRUD-template, binnen deze use case worden alleen uitzonderingen of
            specificiteit belicht.</div>
        </div>
      </td>
    </tr>
    <tr>
      <td><strong>Scope</strong></td>
      <td>&nbsp;ICDE-Tool</td>
    </tr>
    <tr>
      <td><strong>Trigger</strong></td>
      <td>&nbsp;Gebruikers Interactie</td>
    </tr>
    <tr>
      <td><strong>Level</strong></td>
      <td>&nbsp;User-Goal</td>
    </tr>
    <tr>
      <td><strong>Primary Actor</strong></td>
      <td>&nbsp;Docent</td>
    </tr>
    <tr>
      <td><strong>Belangen &amp; belanghebbenden</strong></td>
      <td>
        <div>
          <div>- Docent: Wil kunnen vastleggen welke leerdoelen er behaald moeten worden om tot een bepaalde
            leeruitkomst te kunnen komen.</div>
          <div>- Student: Wil kunnen inzien wat de beoogde leerdoelen zijn.</div>
        </div>
      </td>
    </tr>
    <tr>
      <td><strong>Pre-Condities</strong></td>
      <td>
        <div>
          <div>- De docent is geauthentiseerd. (UC-20)</div>
          <div>- De leeruitkomst waaraan het leerdoel verbonden zal worden bestaat al.</div>
        </div>
      </td>
    </tr>
    <tr>
      <td><strong>Succes definitie</strong></td>
      <td>&nbsp;</td>
    </tr>
    <tr>
      <td><strong>Requirements</strong></td>
      <td>
        <div>
          <div>FR-11</div>
        </div>
      </td>
    </tr>
    <tr>
      <td colspan="2"><strong>Main Success Scenario</strong></td>
    </tr>
    <tr>
      <td><strong>Actor</strong></td>
      <td><strong>System</strong></td>
    </tr>
    <tr>
      <td><strong>Create/Update:</strong></td>
      <td>
        <div>
          <div>De benodigde data zijn een titel, omschrijving &amp; leeruitkomst waaraan het leerdoel gerelateerd is,
            het systeem valideert of in deze databehoefte voorzien is.</div>
        </div>
      </td>
    </tr>
    <tr>
      <td><strong>Delete:</strong></td>
      <td>
        <div>
          <div>Het systeem controleer of er nog lessen of tentamens verbonden zijn aan het leerdoel, een leerdoel kan
            alleen verwijderd worden indien dit niet het geval is.</div>
        </div>
      </td>
    </tr>
  </tbody>
</table>

<font size="1">[:point_up_2: [Overview](#use-case-overview)]</font>

# **UC-13 Ontwikkel toets**

<table>
<td><strong>TODO!</Strong></td>
</Table>

<font size="1">[:point_up_2: [Overview](#use-case-overview)]</font>

# **UC-14 Maak rubriek**

<table>
<td><strong>TODO!</Strong></td>
</Table>

<font size="1">[:point_up_2: [Overview](#use-case-overview)]</font>

# **UC-15 Start uitvoering**

<table>
    <tbody>
        <tr>
            <td><strong>ID</strong></td>
            <td>&nbsp;UC-15</td>
        </tr>
        <tr>
            <td><strong>Naam</strong></td>
            <td>&nbsp;Start uitvoering</td>
        </tr>
        <tr>
            <td><strong>Omschrijving</strong></td>
            <td>&nbsp;Een uitvoering maakt gebruik van een template. Hierbij worden de course weken ingepland in
                lesweken. Hierbij wordt elke les en toetsing voorzien van docent en locatie. Een klas wordt toegewezen
                aan de course waardoor de studenten inzage hebben in de course.</td>
        </tr>
        <tr>
            <td><strong>Scope</strong></td>
            <td>&nbsp;ICDE-Tool</td>
        </tr>
        <tr>
            <td><strong>Trigger</strong></td>
            <td>&nbsp;Gebruikers Interactie</td>
        </tr>
        <tr>
            <td><strong>Level</strong></td>
            <td>&nbsp;User-Goal</td>
        </tr>
        <tr>
            <td><strong>Primary Actor</strong></td>
            <td>&nbsp;Docent</td>
        </tr>
        <tr>
            <td><strong>Belangen &amp; belanghebbenden</strong></td>
            <td>- Docent wil op basis van een template een course uitvoering starten.<br />- Student wil een course
                kunnen volgen</td>
        </tr>
        <tr>
            <td><strong>Pre-Condities</strong></td>
            <td>- Template is definitief<br /> - Docenten zijn beschikbaar<br /> - Klassen zijn beschikbaar<br /> -
                Locaties zijn beschikbaar</td>
        </tr>
        <tr>
            <td><strong>Succes definitie</strong></td>
            <td>&nbsp;Er is een nieuwe course uitvoering waaraan een klas met studenten zit gekoppeld</td>
        </tr>
        <tr>
            <td><strong>Requirements</strong></td>
            <td>&nbsp;FR-30, 32, 33</td>
        </tr>
        <tr>
            <td colspan="2"><strong>Main Success Scenario</strong></td>
        </tr>
        <tr>
            <td><strong>Actor</strong></td>
            <td><strong>System</strong></td>
        </tr>
        <tr>
            <td>
                <p>1. Gebruiker geeft aan dat er een nieuwe course uitvoering aangemaakt kan worden</p>
            </td>
            <!-- 1.A  -->
            <td>&nbsp;</td>
            <!-- 1.B  -->
        </tr>
        <tr>
            <td>&nbsp;</td>
            <!-- 2.A  -->
            <td>&nbsp;2.&nbsp;Systeem vraagt om template en klas</td>
            <!-- 2.B  -->
        </tr>
        <tr>
            <td>&nbsp;3.&nbsp;Gebruiker kiest een template en klas</td>
            <!-- 3.A  -->
            <td>&nbsp;</td>
            <!-- 3.B  -->
        </tr>
        <tr>
            <td>&nbsp;</td>
            <!-- 4.A  -->
            <td>&nbsp;4.&nbsp;Systeem vraagt om de lessen te voorzien van docent</td>
            <!-- 4.B  -->
        </tr>
        <tr>
            <td>&nbsp;</td>
            <!-- 5.A  -->
            <td>&nbsp;</td>
            <!-- 5.B  -->
        </tr>
        <tr>
            <td>&nbsp;</td>
            <!-- 6.A  -->
            <td>&nbsp;6. Systeem vraagt om de lessen te voorzien van locatie</td>
            <!-- 6.B  -->
        </tr>
        <tr>
        <tr>
            <td>&nbsp;</td>
            <!-- 7.A  -->
            <td>&nbsp;</td>
            <!-- 7.B  -->
        </tr>
        <tr>
        <tr>
            <td>&nbsp;</td>
            <!-- 8.A  -->
            <td>&nbsp;8. Systeem mapped de course weken aan lesweken </td>
            <!-- 8.B  -->
        </tr>
        <tr>
            <td colspan="2"><strong>Alternative flow A</strong></td>
        </tr>
        <tr>
            <td colspan="2">6.a <em>[Les is online]</em><br>
                1. De les hoeft geen locatie te hebben <br>
                <em>Ga verder bij Stap 8</em>
            </td>
        </tr>
    </tbody>
</table>

<font size="1">[:point_up_2: [Overview](#use-case-overview)]</font>

# **UC-16 Maak course template definitief**

<table>
    <tbody>
        <tr style="height: 23px;">
            <td style="height: 23px;"><strong>ID</strong></td>
            <td style="height: 23px;">UC-16</td>
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;"><strong>Naam</strong></td>
            <td style="height: 23px;">Maak course template definitief</td>
        </tr>
        <tr style="height: 133px;">
            <td style="height: 133px;"><strong>Omschrijving</strong></td>
            <td style="height: 133px;">
                <p>Wanneer een course volledig ingericht is kan een docent deze definitief maken. Hierbij wordt de
                    inhoud van een course gevalideerd aan een aantal regels:<br /> - Elk leeruitkomst bevat een of
                    meerdere leerdoelen<br /> - Elk leerdoel is opgenomen in minimaal 1 les<br /> - Elk leerdoel wordt
                    getoetst door middel van een schriftelijke toets of een beroepsproduct<br /> - Een course bevat de
                    juiste hoeveelheid EC</p>
            </td>
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;"><strong>Scope</strong></td>
            <td style="height: 23px;">&nbsp;ICDE-Tool</td>
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;"><strong>Trigger</strong></td>
            <td style="height: 23px;">&nbsp;Gebruikers Interactie</td>
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;"><strong>Level</strong></td>
            <td style="height: 23px;">&nbsp;User-Goal</td>
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;"><strong>Primary Actor</strong></td>
            <td style="height: 23px;">&nbsp;Docent</td>
        </tr>
        <tr style="height: 43px;">
            <td style="height: 43px;"><strong>Belangen &amp; belanghebbenden</strong></td>
            <td style="height: 43px;">- Docent: wil een course template registreren als compleet. Hierdoor kan deze
                gebruikt worden als template voor een uitvoering</td>
        </tr>
        <tr style="height: 56px;">
            <td style="height: 56px;"><strong>Pre-Condities</strong></td>
            <td style="height: 56px;">- De template is voorzien van alle informatie<br /> - De gebruiker is ingelogd als
                docent</td>
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;"><strong>Succes definitie</strong></td>
            <td style="height: 23px;">De template is klaar om gebruikt te worden waardoor een nieuwe course uitvoering
                gestart kan worden.</td>
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;"><strong>Requirements</strong></td>
            <td style="height: 23px;">FR-1, 30, 34, 36</td>
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;" colspan="2"><strong>Main Success Scenario</strong></td>
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;"><strong>Actor</strong></td>
            <td style="height: 23px;"><strong>System</strong></td>
        </tr>
        <tr style="height: 53px;">
            <td style="height: 53px;">
                <p>1. Gebruiker navigeert naar een course template</p>
            </td>
            <!-- 1.A  -->
            <td style="height: 53px;">&nbsp;</td>
            <!-- 1.B  -->
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;">&nbsp;</td>
            <!-- 2.A  -->
            <td style="height: 23px;">&nbsp;2. Overzicht van de course wordt weergegeven</td>
            <!-- 2.B  -->
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;">&nbsp;3. Gebruiker geeft aan dat de course template definitief gemaakt kan worden.
            </td>
            <!-- 3.A  -->
            <td style="height: 23px;">&nbsp;</td>
            <!-- 3.B  -->
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;">&nbsp;</td>
            <!-- 4.A  -->
            <td style="height: 23px;">&nbsp;4. Systeem bepaald of de course EVL&rsquo;s bevat</td>
            <!-- 4.B  -->
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;">&nbsp;</td>
            <!-- 5.A  -->
            <td style="height: 23px;">&nbsp;5. Systeem bepaald of de som van EC&rsquo;s overeenkomt met minimaal 30
                EC&rsquo;s per semester (20 weken)</td>
            <!-- 5.B  -->
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;">&nbsp;</td>
            <!-- 6.A  -->
            <td style="height: 23px;">&nbsp;6. Systeem bepaald voor elk leeruitkomst of deze minimaal 1 leerdoel bevat
            </td>
            <!-- 6.B  -->
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;">&nbsp;</td>
            <!-- 7.A  -->
            <td style="height: 23px;">&nbsp;7.&nbsp;Systeem bepaald voor elk leerdoel in de leeruitkomst of deze
                verbonden is aan een les en toetsing</td>
            <!-- 7.B  -->
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;">&nbsp;</td>
            <!-- 8.A  -->
            <td style="height: 23px;">8. System persisteert de gegevens.</td>
            <!-- 8.B  -->
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;" colspan="2"><strong>Alternative flow A</strong></td>
        </tr>
        <tr style="height: 63px;">
            <td style="height: 63px;" colspan="2">4.a/5.a/6.a/7.a&nbsp;<em>[Validatie mislukt]</em><br /> 1. Het systeem
                geeft voor elke mislukte validatie de onderdelen weer die niet voldoen.</td>
        </tr>
    </tbody>
</table>

<font size="1">[:point_up_2: [Overview](#use-case-overview)]</font>

# **UC-17 - Maak Weekplanning**

<table>
  <tbody>
    <tr>
      <td><strong>ID</strong></td>
      <td>&nbsp;UC-17</td>
    </tr>
    <tr>
      <td><strong>Naam</strong></td>
      <td>
        <div>
          <div>Maak Weekplanning</div>
        </div>
      </td>
    </tr>
    <tr>
      <td><strong>Omschrijving</strong></td>
      <td>
        <div>
          <div>In een weekplanning worden lessen en tentamens verbonden aan een courseweek.</div>
        </div>
      </td>
    </tr>
    <tr>
      <td><strong>Scope</strong></td>
      <td>&nbsp;ICDE-Tool</td>
    </tr>
    <tr>
      <td><strong>Trigger</strong></td>
      <td>&nbsp;Gebruikers Interactie</td>
    </tr>
    <tr>
      <td><strong>Level</strong></td>
      <td>&nbsp;User-Goal</td>
    </tr>
    <tr>
      <td><strong>Primary Actor</strong></td>
      <td>
        <div>
          <div>Docent</div>
        </div>
      </td>
    </tr>
    <tr>
      <td><strong>Belangen &amp; belanghebbenden</strong></td>
      <td>
        <div>
          <div>- Docent: wil een weekplanning maken van alle lessen, toetsen en tentamens in een course</div>
        </div>
      </td>
    </tr>
    <tr>
      <td><strong>Pre-Condities</strong></td>
      <td>
        <div>
          <div>- Course met alle bijbehorende onderdelen is aangemaakt.</div>
        </div>
      </td>
    </tr>
    <tr>
      <td><strong>Succes definitie</strong></td>
      <td>&nbsp;</td>
    </tr>
    <tr>
      <td><strong>Requirements</strong></td>
      <td>&nbsp;FR-1, FR-18</td>
    </tr>
    <tr>
      <td colspan="2"><strong>Main Success Scenario</strong></td>
    </tr>
    <tr>
      <td><strong>Actor</strong></td>
      <td><strong>System</strong></td>
    </tr>
    <tr>
      <td>&nbsp;1. De docent geeft aan een planning op te willen stellen.
        <div>&nbsp;</div>
      </td>
      <!-- 1.A  -->
      <td>&nbsp;</td>
      <!-- 1.B  -->
    </tr>
    <tr>
      <td>&nbsp;</td>
      <!-- 2.A  -->
      <td>&nbsp;2. Het systeem toont een lijst van alle course weken en vraagt de gebruiker lessen en/of tentamens toe
        te wijzen aan deze weken.</td>
      <!-- 2.B  -->
    </tr>
    <tr>
      <td>&nbsp;3. De docent wijst alle lessen en tentamens toe aan een lesweek.</td>
      <!-- 3.A  -->
      <td>&nbsp;</td>
      <!-- 3.B  -->
    </tr>
    <tr>
      <td>
        <div>
          <div>4. De docent geeft aan de planning te willen opslaan.</div>
        </div>
      </td>
      <!-- 4.A  -->
      <td>&nbsp;</td>
      <!-- 4.B  -->
    </tr>
    <tr>
      <td>&nbsp;</td>
      <!-- 5.A  -->
      <td>&nbsp;
        <div>
          <div>
            <div>5. Het systeem controleert of elke les en alle tentamens toegewezen zijn aan een week.</div>
          </div>
        </div>
      </td>
      <!-- 5.B  -->
    </tr>
    <tr>
      <td>&nbsp;</td>
      <!-- 6.A  -->
      <td>6. Het systeem controleert of de tentamens voor een leerdoel ingepland zijn na alle lessen voor het gegeven
        gegeven lesdoel.</td>
      <!-- 6.B  -->
    </tr>
    <tr>
      <td>&nbsp;</td>
      <!-- 7.A  -->
      <td>7. Het lesdoel wordt persistent opgeslagen.</td>
      <!-- 7.B  -->
    </tr>
    <tr>
      <td>&nbsp;</td>
      <!-- 8.A  -->
      <td>8. Het systeem stelt de gebruiker op de hoogte van het feit dat de planning succesvol is opgeslagen.</td>
      <!-- 8.B  -->
    </tr>
    <tr>
      <td colspan="2"><strong>Alternative flow A</strong></td>
    </tr>
    <tr>
      <td colspan="2">5a. <em>[Niet alle lessen of tentamens zijn toegewezen]</em><br>
        1. Het systeem attendeert de gebruiker op het feit dat niet alle tentamens en of lessen toegewezen zijn.</td>
    </tr>
    <tr>
      <td colspan="2">6a. <em>[een of meerdere tentamens zijn ingepland voor dat alle bijhorende lessen zijn
          ingepland]</em><br>
        1. Het systeem attendeert de gebruiker op het feit dat tentamens alleen ingepland kunnen worden nadat alle
        lessen voor de aan het tentamen verbonden leerdoelen gegeven zijn. </td>
    </tr>
  </tbody>
</table>

## System Sequence Diagram (SSD)

```mermaid
sequenceDiagram
    actor Gebruiker
    participant Systeem
    Gebruiker->>+Systeem: 1. MaakPlanning
    Systeem-->>-Gebruiker: 2. ToonPlanning(weken, items)
    loop item : items
        Gebruiker->>Systeem: 3. WijsItemToeAanWeek(week, item)
    end
    Gebruiker->>+Systeem: 4. SlaPlanningOp
    Systeem->Systeem: 5. AlleItemZijnToegewezen
    Systeem->Systeem: 6. ControleerVolgorde
    Systeem->Systeem: 7. MaakPersistent
    Systeem-->>-Gebruiker: 8. Success Message
```

<font size="1">[:point_up_2: [Overview](#use-case-overview)]</font>
# **UC-18 Exporteer informatie**

<table>
<td><strong>TODO!</Strong></td>
</Table>


<font size="1">[:point_up_2: [Overview](#use-case-overview)]</font>


# **UC-19 Beheer Locaties**

<table>
  <tbody>
    <tr>
      <td><strong>ID</strong></td>
      <td>&nbsp;UC-19</td>
    </tr>
    <tr>
      <td><strong>Naam</strong></td>
      <td>
        <div>
          <div>Beheer Locaties</div>
        </div>
      </td>
    </tr>
    <tr>
      <td><strong>Omschrijving</strong></td>
      <td>Deze use-case is gebaseerd op het CRUD-template, binnen deze use-case worden alleen uitzonderingen of
        specificiteit belicht.</td>
    </tr>
    <tr>
      <td><strong>Scope</strong></td>
      <td>&nbsp;ICDE-Tool</td>
    </tr>
    <tr>
      <td><strong>Trigger</strong></td>
      <td>&nbsp;Gebruikers Interactie</td>
    </tr>
    <tr>
      <td><strong>Level</strong></td>
      <td>&nbsp;User-Goal</td>
    </tr>
    <tr>
      <td><strong>Primary Actor</strong></td>
      <td>&nbsp;Docent</td>
    </tr>
    <tr>
      <td><strong>Belangen &amp; belanghebbenden</strong></td>
      <td>
        <div>- Docent wil locaties kunnen beheren zodat deze beschikbaar zijn om een les of tentamen aan te koppelen
          tijdens het starten van een course.</div>
      </td>
    </tr>
    <tr>
      <td><strong>Pre-Condities</strong></td>
      <td>
        <p>- De docent is geauthentiseerd</p>
      </td>
    </tr>
    <tr>
      <td><strong>Succes definitie</strong></td>
      <td>&nbsp;</td>
    </tr>
    <tr>
      <td><strong>Requirements</strong></td>
      <td>FR-33</td>
    </tr>
    <tr>
      <td colspan="2"><strong>Main Success Scenario</strong></td>
    </tr>
    <tr>
      <td><strong>Create/Update:</strong></td>
      <td>&nbsp;</td>
    </tr>
    <tr>
      <td><strong>Delete:</strong></td>
      <td>Wanneer er nog locaties toegewijd zijn aan lessen uit een actieve Course Uitvoering kan de locatie niet
        verwijderd worden</td>
    </tr>
  </tbody>
</table>
<div id="gtx-trans" style="position: absolute; left: 118px; top: 306px;">&nbsp;</div>

<font size="1">[:point_up_2: [Overview](#use-case-overview)]</font>

# **UC-20 Aanmelden**

<table>
  <tr>
    <td><strong>ID</strong></td>
    <td>UC-20</td>
  </tr>
  <tr>
    <td><strong>Naam</strong></td>
    <td>Aanmelden</td>
  </tr>
  <tr>
    <td><strong>Omschrijving</strong></td>
    <td>Deze use case is verantwoordelijk voor het autoriseren en eventueel registreren van systeem gebruikers.
      Authenticatie valt buiten de scope van deze use case.</td>
  </tr>
  <tr>
    <td><strong>Scope</strong></td>
    <td>ICDE-Tool</td>
  </tr>
  <tr>
    <td><strong>Trigger</strong></td>
    <td>Authenticatie service</td>
  </tr>
  <tr>
    <td><strong>Level</strong></td>
    <td>User-Goal</td>
  </tr>
  <tr>
    <td><strong>Primary Actor</strong></td>
    <td>Student / Docent</td>
  </tr>
  <tr>
    <td><strong>Belangen & belanghebbenden</strong></td>
    <td>- Student / Docent: Wil kunnen inloggen en de acties waar tot zij bevoegd is kunnen uitvoeren </br> - Docent:
      Wil studenten kunnen toevoegen aan een klas en docenten kunnen verbinden aan een les en of tentamen.</td>
  </tr>
  <tr>
    <td><strong>Pre-Condities</strong></td>
    <td>- Authenticatie is afgehandeld; gebruiker is bevoegd om op het systeem in te loggen.</td>
  </tr>
  <tr>
    <td><strong>Succes definitie</strong></td>
    <td>- Een representatie van de desbetreffende gebruiker is persistent opgeslagen. </br> - Er is een bevoegdheid
      toegekend aan de gebruiker voor de resterende duur van het bezoek.</td>
  </tr>
  <tr>
    <td colspan="2"><strong>Main Success Scenario</strong></td>
  </tr>
  <tr>
    <td><strong>Actor</strong></td>
    <td><strong>System</strong></td>
  </tr>
  <tr>
    <td><em>[Bezoeker is doorverwezen door extern authenticatie systeem en heeft een claim verkregen]</em> </br> 1.
      Verzend authenticatie claim naar systeem.</td>
    <td></td>
  </tr>
  <tr>
    <td></td>
    <td>2. Het systeem bekijkt op basis van de van het authenticatie systeem verkregen gegevens wat van type gebruiker
      het betreft; docent of student.</td>
  </tr>
  <tr>
    <td></td>
    <td>3. Het systeem bekijkt of de gebruiker al bestaat binnen het systeem op basis van het email adres. </br><em>[De
        gebruiker bestaat nog niet]</em></td>
  </tr>
  <tr>
    <td></td>
    <td>4. Het systeem registreert de gebruiker</td>
  </tr>
  <tr>
    <td></td>
    <td>5. Het systeem verleent de gebruiker toegang voor de duur van het bezoek.</td>
  </tr>
  <tr>
    <td></td>
    <td>6. De gebruiker wordt verwezen naar de plek die men initieel bezocht.</td>
  </tr>
  <tr>
    <td colspan="2"><strong>Alternative flow A</strong></td>
  </tr>
  <tr>
    <td colspan="2">3a. <em>[De gebruiker bestaat al]</em> </br> 1. Het systeem controleert of het gebruikerstype
      gewijzigd is. </br> <em>[Het gebruiker type is gewijzigd]</em></br>2. Het systeem overschrijft het huidige
      gebruikerstype met het nieuwe gebruikerstype. </br><em>Ga verder bij stap 5.</em></td>
  </tr>
  <tr>
    <td colspan="2"><strong>Alternative flow B</strong></td>
  </tr>
  <tr>
    <td colspan="2">3a. <em>[De gebruiker bestaat al]</em> </br> 1. Het systeem controleert of het gebruikerstype
      gewijzigd is. </br> <em>[Het gebruiker type is niet gewijzigd]</em></br><em>Ga verder bij stap 5.</em></td>
  </tr>
</table>

## System Sequence Diagram (SSD)

```mermaid
sequenceDiagram
    actor Gebruiker
    participant Systeem
    Gebruiker->>+Systeem: 1. VerzendClaim(claim)
    
    loop groep : groeplidmaatschappen
        Gebruiker->>Systeem: 2. IsDocent(claim)
    end
    
    Systeem->Systeem: 3. bestaat = IsBestaandeGebruiker
    
    alt bestaat = false
        Systeem->Systeem: 4. RegistreerGebruiker
    else
        Systeem->Systeem: 4. UpdateGebruiker
    end

    Systeem->Systeem: 5. VerleenToegang
    
    Systeem-->>-Gebruiker: 6. Doorverwijzen
```

<font size="1">[:point_up_2: [Overview](#use-case-overview)]</font>

# **UC-21 Ontwikkel beroepsproduct**

<table>
<td><strong>TODO!</Strong></td>
</Table>



<font size="1">[:point_up_2: [Overview](#use-case-overview)]</font>

# **UC-22 Ontwikkel Les**

<table>
  <tbody>
    <tr >
      <td ><strong>ID</strong></td>
      <td >&nbsp;UC-22</td>
    </tr>
    <tr >
      <td ><strong>Naam</strong></td>
      <td >
        <div>
          <div>Ontwikkel Les</div>
        </div>
      </td>
    </tr>
    <tr >
      <td ><strong>Omschrijving</strong></td>
      <td >
        <p>Een les behandeld een of meerdere leerdoel(en). Ook kan een leerdoel over meerdere lessen uitgespreid worden.
          Een les bestaat uit verschillende onderwerpen en bevat leermateriaal.</p>
        <p>&nbsp;Deze use-case is gebaseerd op het CRUD-template</p>
      </td>
    </tr>
    <tr >
      <td ><strong>Scope</strong></td>
      <td >&nbsp;ICDE-Tool</td>
    </tr>
    <tr >
      <td ><strong>Trigger</strong></td>
      <td >&nbsp;Gebruikers Interactie</td>
    </tr>
    <tr >
      <td ><strong>Level</strong></td>
      <td >&nbsp;User-Goal</td>
    </tr>
    <tr >
      <td ><strong>Primary Actor</strong></td>
      <td >&nbsp;Docent</td>
    </tr>
    <tr >
      <td ><strong>Belangen &amp; belanghebbenden</strong></td>
      <td >
        <div>- Een docent wil een les aanmaken waaraan leermateriaal gekoppeld is</div>
      </td>
    </tr>
    <tr >
      <td ><strong>Pre-Condities</strong></td>
      <td >
        <p>- De leerdoelen welke betrekking hebben op de les zijn al aangemaakt</p>
        <p>- Gebruiker is ingelogd als Docent</p>
      </td>
    </tr>
    <tr >
      <td ><strong>Succes definitie</strong></td>
      <td >&nbsp;</td>
    </tr>
    <tr >
      <td ><strong>Requirements</strong></td>
      <td >FR-15, 19, 35</td>
    </tr>
    <tr >
      <td  colspan="2"><strong>Main Success Scenario</strong></td>
    </tr>
    <tr >
      <td ><strong>Create/Update:</strong></td>
      <td >&nbsp;</td>
    </tr>
    <tr >
      <td ><strong>Delete:</strong></td>
      <td >&nbsp;</td>
    </tr>
  </tbody>
</table>

<font size="1">[:point_up_2: [Overview](#use-case-overview)]</font>
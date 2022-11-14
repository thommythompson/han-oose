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

<table>
    <tbody>
        <tr>
            <td><strong>Naam</strong></td>
            <td>&nbsp;Create</td>
        </tr>
        <tr>
            <td><strong>Omschrijving</strong></td>
            <td>&nbsp;Standaard "Create" use case</td>
        </tr>
        <tr>
            <td><strong>Pre-Condities</strong></td>
            <td>&nbsp;null</td>
        </tr>
        <tr>
            <td><strong>Succes definitie</strong></td>
            <td>&nbsp;De data voor het desbetreffende object is persistent opgeslagen.</td>
        </tr>
        <tr>
            <td colspan="2"><strong>Main Success Scenario</strong></td>
        </tr>
        <tr>
            <td><strong>Actor</strong></td>
            <td><strong>System</strong></td>
        </tr>
        <tr>
            <td>&nbsp;1. De gebruiker besluit data voor een gegeven object vast te leggen.</td>
            <!-- 1.A  -->
            <td>&nbsp;</td>
            <!-- 1.B  -->
        </tr>
        <tr>
            <td>&nbsp;</td>
            <!-- 2.A  -->
            <td>&nbsp;2. Het systeem vraagt de gebruiker om de benodigde data in te vullen.</td>
            <!-- 2.B  -->
        </tr>
        <tr>
            <td>&nbsp;3. De gebruiker voorziet het systeem van de benodigde data.</td>
            <!-- 3.A  -->
            <td>&nbsp;</td>
            <!-- 3.B  -->
        </tr>
        <tr>
            <td>&nbsp;4. De gebruiker besluit de data persistent te willen maken.</td>
            <!-- 4.A  -->
            <td>&nbsp;</td>
            <!-- 4.B  -->
        </tr>
        <tr>
            <td>&nbsp;</td>
            <!-- 5.A  -->
            <td>&nbsp;5. Het systeem voert validaties uit.</td>
            <!-- 5.B  -->
        </tr>
        <tr>
            <td>&nbsp;</td>
            <!-- 6.A  -->
            <td>&nbsp;6. Het systeem persisteert de opgegeven data.</td>
            <!-- 6.B  -->
        </tr>
        <tr>
        <tr>
            <td>&nbsp;7. Het systeem attendeert de gebruiker op het feit dat de data succesvol is opgeslagen.</td>
            <!-- 7.A  -->
            <td>&nbsp;</td>
            <!-- 7.B  -->
        </tr>
        <tr>
        <tr>
            <td><em>De gebruiker herhaalt de stappen 1 t/m 7 totdat alle gewenste data is vastgelegd.</em></td>
            <!-- 8.A  -->
            <td>&nbsp;</td>
            <!-- 8.B  -->
        </tr>
        <tr>
            <td colspan="2"><strong>Alternative flow A</strong></td>
        </tr>
        <tr>
            <td colspan="2">
                5a. <em> [De gegevens blijken niet valide te zijn] </em><br>
                1. Het systeem attendeert de gebruiker op het feit dat de invoer niet valide is en de reden daarvoor.
            </td>
        </tr>
        <tr>
            <td colspan="2">
                6a. <em> [De persistentie tier blijkt is niet beschikbaar] </em><br>
                1. Het systeem geeft aan dat het object niet succesvol opgeslagen is.
            </td>
        </tr>
        <tr>
    </tbody>
</table>

<font size="1">[:point_up_2: [Inhoudsopgave](#crud-use-case-overview)]</font>

# **Read**

<table>
    <tbody>
        <tr style="height: 23.5px;">
            <td style="height: 23.5px;"><strong>Naam</strong></td>
            <td style="height: 23.5px;">
                <div>
                    <div>Read</div>
                </div>
            </td>
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;"><strong>Omschrijving</strong></td>
            <td style="height: 23px;">
                <div>
                    <div>Standaard "Read" use case</div>
                </div>
            </td>
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;"><strong>Pre-Condities</strong></td>
            <td style="height: 23px;">
                <div>
                    <div>De create use case is doorlopen voor de objecten dat men wilt tonen.</div>
                </div>
            </td>
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;"><strong>Succes definitie</strong></td>
            <td style="height: 23px;">
                <div>
                    <div>Alle data van het desbetreffende object is aan de eindgebruiker getoont.</div>
                </div>
            </td>
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;" colspan="2"><strong>Main Success Scenario</strong></td>
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;"><strong>Actor</strong></td>
            <td style="height: 23px;"><strong>System</strong></td>
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;">
                <div>
                    <div>1. De gebruiker vraagt een overzicht van de gewenste objecten op.</div>
                </div>
            </td>
            <!-- 1.A  -->
            <td style="height: 23px;">&nbsp;</td>
            <!-- 1.B  -->
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;">&nbsp;</td>
            <!-- 2.A  -->
            <td style="height: 23px;">
                <div>
                    <div>2. Het systeem toont een lijst van de opgevraagde informatie.</div>
                </div>
            </td>
            <!-- 2.B  -->
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;">
                <div>
                    <div>3. De gebruiker kiest een object uit de lijst waar men gedetailleerde informatie van wilt zien.
                    </div>
                </div>
            </td>
            <!-- 3.A  -->
            <td style="height: 23px;">&nbsp;</td>
            <!-- 3.B  -->
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;">&nbsp;</td>
            <!-- 4.A  -->
            <td style="height: 23px;">&nbsp;4. Het systeem toont alle beschikbare informatie voor het desbetreffende
                object.</td>
            <!-- 4.B  -->
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;">
                <div>
                    <div><em>De gebruiker herhaalt de stappen 1 t/m 4 totdat alle gewenste data is gewijzigd.</em></div>
                </div>
            </td>
            <!-- 8.A  -->
            <td style="height: 23px;">&nbsp;</td>
            <!-- 8.B  -->
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;" colspan="2"><strong>Alternative flow A</strong></td>
        </tr>
        <tr style="height: 43px;">
            <td style="height: 43px;" colspan="2">2a/4a. <em> [De persistentie tier blijkt is niet beschikbaar]
                </em><br /> 1.Het systeem geeft aan dat de benodigde data niet opgehaald kon worden.</td>
        </tr>
    </tbody>
</table>

<font size="1">[:point_up_2: [Inhoudsopgave](#crud-use-case-overview)]</font>

# **Update**

<table>
    <tbody>
        <tr style="height: 23px;">
            <td style="height: 23px;"><strong>Naam</strong></td>
            <td style="height: 23px;">
                <div>
                    <div>Update</div>
                </div>
            </td>
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;"><strong>Omschrijving</strong></td>
            <td style="height: 23px;">Standaard "Update" use case</td>
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;"><strong>Pre-Condities</strong></td>
            <td style="height: 23px;">
                <div>
                    <div>De gebruiker heeft de "Read" use case doorlopen.</div>
                </div>
            </td>
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;"><strong>Succes definitie</strong></td>
            <td style="height: 23px;">
                <div>
                    <div>De wijzigingen zijn persistent opgeslagen.</div>
                </div>
            </td>
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;" colspan="2"><strong>Main Success Scenario</strong></td>
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;"><strong>Actor</strong></td>
            <td style="height: 23px;"><strong>System</strong></td>
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;">
                <div>
                    <div>1. De gebruiker besluit het desbetreffende object te wijzigen.</div>
                </div>
            </td>
            <!-- 1.A  -->
            <td style="height: 23px;">&nbsp;</td>
            <!-- 1.B  -->
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;">&nbsp;</td>
            <!-- 2.A  -->
            <td style="height: 23px;">
                <div>
                    <div>2. Het toont een formulier waarin men data kan wijzigen, het formulier is alvast ingevuld met
                        de al aanwezige data.</div>
                </div>
            </td>
            <!-- 2.B  -->
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;">
                <div>
                    <div>3. De gebruiker past de data naar wens aan.</div>
                </div>
            </td>
            <!-- 3.A  -->
            <td style="height: 23px;">&nbsp;</td>
            <!-- 3.B  -->
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;">
                <div>
                    <div>4. De gebruiker besluit de data persistent te willen maken.</div>
                </div>
            </td>
            <!-- 4.A  -->
            <td style="height: 23px;">&nbsp;</td>
            <!-- 4.B  -->
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;">&nbsp;</td>
            <!-- 5.A  -->
            <td style="height: 23px;">
                <div>
                    <div>5. Het systeem voert validaties uit.</div>
                </div>
            </td>
            <!-- 5.B  -->
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;">&nbsp;</td>
            <!-- 6.A  -->
            <td style="height: 23px;">
                <div>
                    <div>6. Het systeem persisteert de opgegeven data.</div>
                </div>
            </td>
            <!-- 6.B  -->
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;">&nbsp;</td>
            <!-- 7.A  -->
            <td style="height: 23px;">&nbsp;7. Het systeem attendeert de gebruiker op het feit dat de data succesvol is
                opgeslagen.</td>
            <!-- 7.B  -->
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;"><em>De gebruiker herhaalt de stappen 1 t/m 7 totdat alle gewenste data is
                    gewijzigd.</em></td>
            <!-- 8.A  -->
            <td style="height: 23px;">&nbsp;</td>
            <!-- 8.B  -->
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px;" colspan="2"><strong>Alternative flow A</strong></td>
        </tr>
        <tr style="height: 43px;">
            <td style="height: 43px;" colspan="2">5a. <em> [De gegevens blijken niet valide te zijn] </em><br /> 1. Het
                systeem attendeert de gebruiker op het feit dat de invoer niet valide is en de reden daarvoor.</td>
        </tr>
        <tr style="height: 43px;">
            <td style="height: 43px;" colspan="2">6a. <em> [De persistentie tier blijkt is niet beschikbaar] </em><br />
                1. Het systeem geeft aan dat het object niet succesvol opgeslagen is.</td>
        </tr>
    </tbody>
</table>

<font size="1">[:point_up_2: [Inhoudsopgave](#crud-use-case-overview)]</font>

# **Delete**

<table>
    <tbody>
        <tr style="height: 23px;">
            <td style="height: 23px; width: 462.391px;"><strong>Naam</strong></td>
            <td style="height: 23px; width: 542.609px;">
                <div>
                    <div>Delete</div>
                </div>
            </td>
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px; width: 462.391px;"><strong>Omschrijving</strong></td>
            <td style="height: 23px; width: 542.609px;">
                <div>
                    <div>Standaard "Delete" use case</div>
                </div>
            </td>
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px; width: 462.391px;"><strong>Pre-Condities</strong></td>
            <td style="height: 23px; width: 542.609px;">
                <div>De gebruiker heeft de "Read" use case doorlopen.</div>
            </td>
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px; width: 462.391px;"><strong>Succes definitie</strong></td>
            <td style="height: 23px; width: 542.609px;">
                <div>
                    <div>De data van het desbetreffende object is verwijderd.</div>
                </div>
            </td>
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px; width: 1005px;" colspan="2"><strong>Main Success Scenario</strong></td>
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px; width: 462.391px;"><strong>Actor</strong></td>
            <td style="height: 23px; width: 542.609px;"><strong>System</strong></td>
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px; width: 462.391px;">
                <div>
                    <div>1. De gebruiker besluit het desbetreffende object te verwijderen.</div>
                </div>
            </td>
            <!-- 1.A  -->
            <td style="height: 23px; width: 542.609px;">&nbsp;</td>
            <!-- 1.B  -->
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px; width: 462.391px;">&nbsp;</td>
            <!-- 2.A  -->
            <td style="height: 23px; width: 542.609px;">
                <div>
                    <div>2. Het systeem vraagt om een bevestiging.</div>
                </div>
            </td>
            <!-- 2.B  -->
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px; width: 462.391px;">
                <div>
                    <div>3. De gebruiker bevestigd het object te willen verwijderen.</div>
                </div>
            </td>
            <!-- 3.A  -->
            <td style="height: 23px; width: 542.609px;">&nbsp;</td>
            <!-- 3.B  -->
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px; width: 462.391px;">
                <div>
                    <div>4. De gebruiker besluit de data persistent te willen maken.</div>
                </div>
            </td>
            <!-- 4.A  -->
            <td style="height: 23px; width: 542.609px;">4. Het systeem voert validaties uit.</td>
            <!-- 4.B  -->
        </tr>
        <tr style="height: 23.5px;">
            <td style="height: 23.5px; width: 462.391px;">&nbsp;</td>
            <!-- 5.A  -->
            <td style="height: 23.5px; width: 542.609px;">
                <div>
                    <div>5. Het systeem verwijdert het object.</div>
                </div>
            </td>
            <!-- 5.B  -->
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px; width: 462.391px;">&nbsp;</td>
            <!-- 6.A  -->
            <td style="height: 23px; width: 542.609px;">
                <div>
                    <div>6. Het systeem attendeert de gebruiker op het feit dat het object succesvol verwijderd is.
                    </div>
                </div>
            </td>
            <!-- 6.B  -->
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px; width: 462.391px;"><em>De gebruiker herhaalt de stappen 1 t/m 6 totdat alle
                    gewenste verwijderingen zijn uitgevoerd.</em>;</td>
            <!-- 7.A  -->
            <td style="height: 23px; width: 542.609px;">&nbsp;</td>
            <!-- 7.B  -->
        </tr>
        <tr style="height: 23px;">
            <td style="height: 23px; width: 1005px;" colspan="2"><strong>Alternative flow A</strong></td>
        </tr>
        <tr style="height: 43px;">
            <td style="height: 43px; width: 1005px;" colspan="2">1a. <em>[Het object blijkt (nog) niet verwijderd te
                    kunnen worden.]</em><br /> 1. Het systeem attendeert de gebruiker op de reden waarom het object niet
                verwijderd kon worden.</td>
        </tr>
        <tr style="height: 43px;">
            <td style="height: 43px; width: 1005px;" colspan="2">5a. <em> [De persistentie tier blijkt is niet
                    beschikbaar] </em><br /> 1. Het systeem geeft aan dat het object niet succesvol verwijderd is.</td>
        </tr>
    </tbody>
</table>

<font size="1">[:point_up_2: [Inhoudsopgave](#crud-use-case-overview)]</font>
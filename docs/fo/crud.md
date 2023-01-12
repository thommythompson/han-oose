[Terug](./index.md)

<h1>CRUD Use Case Overview</h1>

- [**Create**](#create)
- [**Read**](#read)
- [**Update**](#update)
- [**Delete**](#delete)

## **Create**

<table>
    <tbody>
        <tr>
            <td><strong>Naam</strong></td>
            <td>Create</td>
        </tr>
        <tr>
            <td><strong>Omschrijving</strong></td>
            <td>Standaard "Create" use case</td>
        </tr>
        <tr>
            <td><strong>Pre-Condities</strong></td>
            <td>null</td>
        </tr>
        <tr>
            <td><strong>Succes definitie</strong></td>
            <td>De data voor het desbetreffende object is persistent opgeslagen.</td>
        </tr>
        <tr>
            <td colspan="2"><strong>Main Success Scenario</strong></td>
        </tr>
        <tr>
            <td><strong>Actor</strong></td>
            <td><strong>System</strong></td>
        </tr>
        <tr>
            <td>1. De gebruiker besluit data voor een gegeven object vast te leggen.</td>
            <!-- 1.A  -->
            <td></td>
            <!-- 1.B  -->
        </tr>
        <tr>
            <td></td>
            <!-- 2.A  -->
            <td>2. Het systeem vraagt de gebruiker om de benodigde data in te vullen.</td>
            <!-- 2.B  -->
        </tr>
        <tr>
            <td>3. De gebruiker voorziet het systeem van de benodigde data.</td>
            <!-- 3.A  -->
            <td></td>
            <!-- 3.B  -->
        </tr>
        <tr>
            <td>4. De gebruiker besluit de data persistent te willen maken.</td>
            <!-- 4.A  -->
            <td></td>
            <!-- 4.B  -->
        </tr>
        <tr>
            <td></td>
            <!-- 5.A  -->
            <td>5. Het systeem voert validaties uit.</td>
            <!-- 5.B  -->
        </tr>
        <tr>
            <td></td>
            <!-- 6.A  -->
            <td>6. Het systeem persisteert de opgegeven data.</td>
            <!-- 6.B  -->
        </tr>
        <tr>
        <tr>
            <td>7. Het systeem attendeert de gebruiker op het feit dat de data succesvol is opgeslagen.</td>
            <!-- 7.A  -->
            <td></td>
            <!-- 7.B  -->
        </tr>
        <tr>
        <tr>
            <td><em>De gebruiker herhaalt de stappen 1 t/m 7 totdat alle gewenste data is vastgelegd.</em></td>
            <!-- 8.A  -->
            <td></td>
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

## **Read**

<table>
    <tbody>
        <tr >
            <td ><strong>Naam</strong></td>
            <td >
                <div>
                    <div>Read</div>
                </div>
            </td>
        </tr>
        <tr >
            <td ><strong>Omschrijving</strong></td>
            <td >
                <div>
                    <div>Standaard "Read" use case</div>
                </div>
            </td>
        </tr>
        <tr >
            <td ><strong>Pre-Condities</strong></td>
            <td >
                <div>
                    <div>De create use case is doorlopen voor de objecten dat men wilt tonen.</div>
                </div>
            </td>
        </tr>
        <tr >
            <td ><strong>Succes definitie</strong></td>
            <td >
                <div>
                    <div>Alle data van het desbetreffende object is aan de eindgebruiker getoont.</div>
                </div>
            </td>
        </tr>
        <tr >
            <td  colspan="2"><strong>Main Success Scenario</strong></td>
        </tr>
        <tr >
            <td ><strong>Actor</strong></td>
            <td ><strong>System</strong></td>
        </tr>
        <tr >
            <td >
                <div>
                    <div>1. De gebruiker vraagt een overzicht van de gewenste objecten op.</div>
                </div>
            </td>
            <!-- 1.A  -->
            <td ></td>
            <!-- 1.B  -->
        </tr>
        <tr >
            <td ></td>
            <!-- 2.A  -->
            <td >
                <div>
                    <div>2. Het systeem toont een lijst van de opgevraagde informatie.</div>
                </div>
            </td>
            <!-- 2.B  -->
        </tr>
        <tr >
            <td >
                <div>
                    <div>3. De gebruiker kiest een object uit de lijst waar men gedetailleerde informatie van wilt zien.
                    </div>
                </div>
            </td>
            <!-- 3.A  -->
            <td ></td>
            <!-- 3.B  -->
        </tr>
        <tr >
            <td ></td>
            <!-- 4.A  -->
            <td >4. Het systeem toont alle beschikbare informatie voor het desbetreffende
                object.</td>
            <!-- 4.B  -->
        </tr>
        <tr >
            <td >
                <div>
                    <div><em>De gebruiker herhaalt de stappen 1 t/m 4 totdat alle gewenste data is gewijzigd.</em></div>
                </div>
            </td>
            <!-- 8.A  -->
            <td ></td>
            <!-- 8.B  -->
        </tr>
        <tr >
            <td  colspan="2"><strong>Alternative flow A</strong></td>
        </tr>
        <tr >
            <td  colspan="2">2a/4a. <em> [De persistentie tier blijkt is niet beschikbaar]
                </em><br /> 1.Het systeem geeft aan dat de benodigde data niet opgehaald kon worden.</td>
        </tr>
    </tbody>
</table>

<font size="1">[:point_up_2: [Inhoudsopgave](#crud-use-case-overview)]</font>

## **Update**

<table>
    <tbody>
        <tr >
            <td ><strong>Naam</strong></td>
            <td >
                <div>
                    <div>Update</div>
                </div>
            </td>
        </tr>
        <tr >
            <td ><strong>Omschrijving</strong></td>
            <td >Standaard "Update" use case</td>
        </tr>
        <tr >
            <td ><strong>Pre-Condities</strong></td>
            <td >
                <div>
                    <div>De gebruiker heeft de "Read" use case doorlopen.</div>
                </div>
            </td>
        </tr>
        <tr >
            <td ><strong>Succes definitie</strong></td>
            <td >
                <div>
                    <div>De wijzigingen zijn persistent opgeslagen.</div>
                </div>
            </td>
        </tr>
        <tr >
            <td  colspan="2"><strong>Main Success Scenario</strong></td>
        </tr>
        <tr >
            <td ><strong>Actor</strong></td>
            <td ><strong>System</strong></td>
        </tr>
        <tr >
            <td >
                <div>
                    <div>1. De gebruiker besluit het desbetreffende object te wijzigen.</div>
                </div>
            </td>
            <!-- 1.A  -->
            <td ></td>
            <!-- 1.B  -->
        </tr>
        <tr >
            <td ></td>
            <!-- 2.A  -->
            <td >
                <div>
                    <div>2. Het toont een formulier waarin men data kan wijzigen, het formulier is alvast ingevuld met
                        de al aanwezige data.</div>
                </div>
            </td>
            <!-- 2.B  -->
        </tr>
        <tr >
            <td >
                <div>
                    <div>3. De gebruiker past de data naar wens aan.</div>
                </div>
            </td>
            <!-- 3.A  -->
            <td ></td>
            <!-- 3.B  -->
        </tr>
        <tr >
            <td >
                <div>
                    <div>4. De gebruiker besluit de data persistent te willen maken.</div>
                </div>
            </td>
            <!-- 4.A  -->
            <td ></td>
            <!-- 4.B  -->
        </tr>
        <tr >
            <td ></td>
            <!-- 5.A  -->
            <td >
                <div>
                    <div>5. Het systeem voert validaties uit.</div>
                </div>
            </td>
            <!-- 5.B  -->
        </tr>
        <tr >
            <td ></td>
            <!-- 6.A  -->
            <td >
                <div>
                    <div>6. Het systeem persisteert de opgegeven data.</div>
                </div>
            </td>
            <!-- 6.B  -->
        </tr>
        <tr >
            <td ></td>
            <!-- 7.A  -->
            <td >7. Het systeem attendeert de gebruiker op het feit dat de data succesvol is
                opgeslagen.</td>
            <!-- 7.B  -->
        </tr>
        <tr >
            <td ><em>De gebruiker herhaalt de stappen 1 t/m 7 totdat alle gewenste data is
                    gewijzigd.</em></td>
            <!-- 8.A  -->
            <td ></td>
            <!-- 8.B  -->
        </tr>
        <tr >
            <td  colspan="2"><strong>Alternative flow A</strong></td>
        </tr>
        <tr >
            <td  colspan="2">5a. <em> [De gegevens blijken niet valide te zijn] </em><br /> 1. Het
                systeem attendeert de gebruiker op het feit dat de invoer niet valide is en de reden daarvoor.</td>
        </tr>
        <tr >
            <td  colspan="2">6a. <em> [De persistentie tier blijkt is niet beschikbaar] </em><br />
                1. Het systeem geeft aan dat het object niet succesvol opgeslagen is.</td>
        </tr>
    </tbody>
</table>

<font size="1">[:point_up_2: [Inhoudsopgave](#crud-use-case-overview)]</font>

## **Delete**

<table>
    <tbody>
        <tr >
            <td ><strong>Naam</strong></td>
            <td >
                <div>
                    <div>Delete</div>
                </div>
            </td>
        </tr>
        <tr >
            <td ><strong>Omschrijving</strong></td>
            <td >
                <div>
                    <div>Standaard "Delete" use case</div>
                </div>
            </td>
        </tr>
        <tr >
            <td ><strong>Pre-Condities</strong></td>
            <td >
                <div>De gebruiker heeft de "Read" use case doorlopen.</div>
            </td>
        </tr>
        <tr >
            <td ><strong>Succes definitie</strong></td>
            <td >
                <div>
                    <div>De data van het desbetreffende object is verwijderd.</div>
                </div>
            </td>
        </tr>
        <tr >
            <td colspan="2"><strong>Main Success Scenario</strong></td>
        </tr>
        <tr >
            <td ><strong>Actor</strong></td>
            <td ><strong>System</strong></td>
        </tr>
        <tr >
            <td >
                <div>
                    <div>1. De gebruiker besluit het desbetreffende object te verwijderen.</div>
                </div>
            </td>
            <!-- 1.A  -->
            <td ></td>
            <!-- 1.B  -->
        </tr>
        <tr >
            <td ></td>
            <!-- 2.A  -->
            <td >
                <div>
                    <div>2. Het systeem vraagt om een bevestiging.</div>
                </div>
            </td>
            <!-- 2.B  -->
        </tr>
        <tr >
            <td >
                <div>
                    <div>3. De gebruiker bevestigd het object te willen verwijderen.</div>
                </div>
            </td>
            <!-- 3.A  -->
            <td ></td>
            <!-- 3.B  -->
        </tr>
        <tr >
            <td >
                <div>
                    <div>4. De gebruiker besluit de data persistent te willen maken.</div>
                </div>
            </td>
            <!-- 4.A  -->
            <td >4. Het systeem voert validaties uit.</td>
            <!-- 4.B  -->
        </tr>
        <tr >
            <td ></td>
            <!-- 5.A  -->
            <td >
                <div>
                    <div>5. Het systeem verwijdert het object.</div>
                </div>
            </td>
            <!-- 5.B  -->
        </tr>
        <tr >
            <td ></td>
            <!-- 6.A  -->
            <td >
                <div>
                    <div>6. Het systeem attendeert de gebruiker op het feit dat het object succesvol verwijderd is.
                    </div>
                </div>
            </td>
            <!-- 6.B  -->
        </tr>
        <tr >
            <td ><em>De gebruiker herhaalt de stappen 1 t/m 6 totdat alle
                    gewenste verwijderingen zijn uitgevoerd.</em>;</td>
            <!-- 7.A  -->
            <td ></td>
            <!-- 7.B  -->
        </tr>
        <tr >
            <td colspan="2"><strong>Alternative flow A</strong></td>
        </tr>
        <tr >
            <td colspan="2">1a. <em>[Het object blijkt (nog) niet verwijderd te
                    kunnen worden.]</em><br /> 1. Het systeem attendeert de gebruiker op de reden waarom het object niet
                verwijderd kon worden.</td>
        </tr>
        <tr >
            <td colspan="2">5a. <em> [De persistentie tier blijkt is niet
                    beschikbaar] </em><br /> 1. Het systeem geeft aan dat het object niet succesvol verwijderd is.</td>
        </tr>
    </tbody>
</table>

<font size="1">[:point_up_2: [Inhoudsopgave](#crud-use-case-overview)]</font>
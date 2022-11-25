namespace HAN.ICDETool.Tests;

public class TestAdres
{

    [SetUp]
    public void Setup()
    {
       
    }

    [Test]
    public void TestInitAttributes()
    {
        Adres adres = new Adres("Straat","4b","7141NP","Groenlo");
        
        Assert.That(adres.Straat, Is.EqualTo("Straat"));
        Assert.That(adres.Huisnummer, Is.EqualTo("4b"));
        Assert.That(adres.Plaatsnaam, Is.EqualTo("Groenlo"));
        Assert.That(adres.Postcode, Is.EqualTo("7141NP"));
    }
}
using HAN.ICDETool.ExporterService.HtmlConverter;

namespace HAN.ICDETool.Tests.Unit;

public class TestHtmlConverter
{
    private IHTMLConverter _htmlConverter;
    
    [SetUp]
    public void Setup()
    {
        _htmlConverter = new HTMLConverter();
    }

    [Test]
    public void TestCourseCreation()
    {
        IList<String> stringList = new List<string>();
        stringList.Add("Test1");
        stringList.Add("test2");

        String html = _htmlConverter.ConvertStringListToHtml(stringList);
        
        Assert.That(html, Is.EqualTo("<p>Test1</p></br><p>test2</p></br>"));
    }
}
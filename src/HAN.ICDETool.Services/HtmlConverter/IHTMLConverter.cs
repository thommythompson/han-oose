using HAN.ICDETool.Domain;

namespace HAN.ICDETool.Services.HtmlConverter;

public interface IHTMLConverter
{
    public String ConvertStringListToHtml(IList<String> lines);
}
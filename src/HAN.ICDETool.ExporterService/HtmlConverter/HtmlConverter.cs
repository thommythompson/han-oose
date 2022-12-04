using System.Text;
using HAN.ICDETool.Core.Entities;

namespace HAN.ICDETool.ExporterService.HtmlConverter;

public class HTMLConverter : IHTMLConverter
{
    public String ConvertStringListToHtml(IList<String> lines)
    {
        StringBuilder stringBuilder = new StringBuilder();

        foreach (String line in lines)
        {
            stringBuilder.Append("<p>" + line + "</p></br>");
        }

        return stringBuilder.ToString();
    }
}
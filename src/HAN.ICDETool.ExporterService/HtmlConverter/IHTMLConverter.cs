using HAN.ICDETool.Core.Entities;

namespace HAN.ICDETool.ExporterService.HtmlConverter;

public interface IHTMLConverter
{
    public String ConvertStringListToHtml(IList<String> lines);
}
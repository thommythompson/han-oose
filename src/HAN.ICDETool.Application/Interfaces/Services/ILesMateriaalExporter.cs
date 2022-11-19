using HAN.ICDETool.Domain;

namespace HAN.ICDETool.Application.Interfaces.Services;

public interface ILesMateriaalExporter
{
    public String ExportLesMateriaal(ExportFormaat formaat, LesMateriaal lesMateriaal);
}
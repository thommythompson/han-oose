using HAN.ICDETool.Domain;

namespace HAN.ICDETool.Application.Services.Interfaces;

public interface ILesMateriaalExporter
{
    public String ExportLesMateriaal(ExportFormaat formaat, LesMateriaal lesMateriaal);
}
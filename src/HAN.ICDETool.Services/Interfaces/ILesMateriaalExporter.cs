using HAN.ICDETool.Core.Entities;

namespace HAN.ICDETool.Services.Interfaces;

public interface ILesMateriaalExporter 
{
    public String ExportLesMateriaal(ExportFormaat formaat, LesMateriaal lesMateriaal);
}
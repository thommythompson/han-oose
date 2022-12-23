using HAN.ICDETool.Core.Entities;
using HAN.ICDETool.SharedKernel;

namespace HAN.ICDETool.Services.Interfaces;

public interface ILesMateriaalExporter 
{
    public CustomFile ExportLesMateriaal(ExportFormaat formaat, LesMateriaal lesMateriaal);
}
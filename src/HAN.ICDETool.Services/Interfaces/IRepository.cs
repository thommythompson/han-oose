using Ardalis.Specification;

namespace HAN.ICDETool.Application.Repositories.Interfaces;

public interface IRepository<T> : IRepositoryBase<T> where T : class
{
}
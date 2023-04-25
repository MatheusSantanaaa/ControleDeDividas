using Desafio.Core.DomainObjects;

namespace Desafio.Core.Data
{
    public interface IRepository<T> where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}

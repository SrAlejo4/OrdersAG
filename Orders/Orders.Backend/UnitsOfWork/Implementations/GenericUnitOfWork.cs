using Orders.Backend.Repositories.Implementations;
using Orders.Backend.Repositories.Interfaces;
using Orders.Backend.UnitsOfWork.Interfaces;
using Orders.Shared.Responses;

namespace Orders.Backend.UnitsOfWork.Implementations;

public class GenericUnitOfWork<T> : IGenericUnitOfWork<T> where T : class
{
    private readonly IGenericRepository<T> _repository;

    public GenericUnitOfWork(IGenericRepository<T> repository) // We make an injection from GenericRepository to UnitOfWork, it conects both
    {
        _repository = repository;
    }

    // Make a ByPass ??
    public virtual async Task<ActionResponse<T>> AddAsync(T entity) => await _repository.AddAsync(entity);

    public virtual async Task<ActionResponse<T>> DeleteAsync(int id) => await _repository.DeleteAsync(id);

    public virtual async Task<ActionResponse<T>> GetAsync(int id) => await _repository.GetAsync(id);

    public virtual async Task<ActionResponse<IEnumerable<T>>> GetAsync() => await _repository.GetAsync();

    public virtual async Task<ActionResponse<T>> UpdateAsync(T entity) => await _repository.UpdateAsync(entity);
}
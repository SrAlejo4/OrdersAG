using Orders.Shared.Responses;

namespace Orders.Backend.UnitsOfWork.Interfaces;

public interface IGenericUnitOfWork<T> where T : class
{
    Task<ActionResponse<T>> GetAsync(int id); // Get with an id as a parameter.

    Task<ActionResponse<IEnumerable<T>>> GetAsync(); // IEnumerable return a list of an entity.

    Task<ActionResponse<T>> AddAsync(T entity); // It recieves an entity and add it into DataBase.

    Task<ActionResponse<T>> DeleteAsync(int id); // Delete an entity with id as a parameter.

    Task<ActionResponse<T>> UpdateAsync(T entity); // Update entity.
}
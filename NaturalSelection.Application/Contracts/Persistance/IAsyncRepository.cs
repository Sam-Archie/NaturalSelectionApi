using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalSelection.Application.Contracts.Persistance
{
    public interface IAsyncRepository<T> where T : class
    {
        //This is a declaration of what an assync repo should be capable of
        //T should be a class hence where T : class
        Task<T> GetByIdAsync(Guid id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEvaluation.Core.Interfaces.IRepositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync<Tid>(Tid id);
        Task<bool> IsExists<Tvalue> (string key,Tvalue value);
        Task<T> CreateAsync(T model);
        Task CreateRange(List<T> model);
        Task<T> UpdateAsync(T model);
        Task DeleteAsync(T model);
        Task SaveChangeAsync();


    }
}

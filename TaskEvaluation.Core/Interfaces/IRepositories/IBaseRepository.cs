using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEvaluation.Core.Interfaces.IRepositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById<Tid>(Tid id);
        Task<bool> IsExists<Tvalue> (string key,Tvalue value);
        Task<T> Create(T model);
        Task CreateRange(List<T> model);
        Task<T> Update(T model);
        Task Delete(T model);
        Task SaveChangeAsync();


    }
}

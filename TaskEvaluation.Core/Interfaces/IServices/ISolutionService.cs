using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEvaluation.Core.Interfaces.IServices
{
    public interface ISolutionService
    {

        Task<IEnumerable<SolutionDTO>> GetSolutionsAsync();
        Task<SolutionDTO> GetSolutionByIdAsync(int id);
        Task<SolutionDTO> CreateSolutionAsync(SolutionDTO solutionDTO);
        Task UpdateSolutionAsync(SolutionDTO solutionDTO);
        Task DeleteSolutionAsync(int id);


    }
}

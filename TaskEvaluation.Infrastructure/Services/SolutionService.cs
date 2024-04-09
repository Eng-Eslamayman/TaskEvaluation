using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskEvaluation.Core.Entities.DTOs;
using TaskEvaluation.Core.Interfaces.IServices;

namespace TaskEvaluation.Infrastructure.Services
{
    public class SolutionService : ISolutionService
    {
        public Task<SolutionDTO> CreateSolutionAsync(SolutionDTO solutionDTO)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSolutionAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<SolutionDTO> GetSolutionByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SolutionDTO>> GetSolutionsAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateSolutionAsync(SolutionDTO solutionDTO)
        {
            throw new NotImplementedException();
        }
    }
}

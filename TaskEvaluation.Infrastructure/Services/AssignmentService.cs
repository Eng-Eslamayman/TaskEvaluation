using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskEvaluation.Core.Entities.Business;
using TaskEvaluation.Core.Entities.DTOs;
using TaskEvaluation.Core.Interfaces.IRepositories;
using TaskEvaluation.Core.Interfaces.IServices;

namespace TaskEvaluation.Infrastructure.Services
{
    internal class AssignmentService : IAssignmentService
    {
        private readonly IBaseRepository<Assignment> _assignmentRepository;

        public AssignmentService(IBaseRepository<Assignment> assignmentRepository)
        {
            _assignmentRepository = assignmentRepository;
        }

        public Task CreateAssignmentAsync(AssignmentDTO assignment)
        {
            throw new NotImplementedException();
        }

        public async Task DeletAsync(int id)
        {
            var assignmentToDelete = await _assignmentRepository.GetByIdAsync(id);
            if (assignmentToDelete != null)
            {
                await _assignmentRepository.DeleteAsync(assignmentToDelete);
                await _assignmentRepository.SaveChangeAsync();
            }
        }

        public Task DeleteAssignmentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AssignmentDTO>> GetAllAssignmentsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<AssignmentDTO> GetAssignmentByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAssignmentAsync(AssignmentDTO assignment)
        {
            throw new NotImplementedException();
        }
    }
}

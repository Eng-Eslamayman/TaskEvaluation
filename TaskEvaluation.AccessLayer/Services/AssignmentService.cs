using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskEvaluation.Core.Entities.Business;
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

        public async Task DeletAsync(int id)
        {
            var assignmentToDelete = await _assignmentRepository.GetByIdAsync(id);
            if (assignmentToDelete != null)
            {
                await _assignmentRepository.DeleteAsync(assignmentToDelete);
                await _assignmentRepository.SaveChangeAsync();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskEvaluation.Core.Entities.Business;
namespace TaskEvaluation.Core.Interfaces.IServices
{
    public interface IAssignmentService
    {
        Task<AssignmentDTO> GetAssignmentByIdAsync(int id);
        Task<IEnumerable<AssignmentDTO>> GetAllAssignmentsAsync();
        Task CreateAssignmentAsync(AssignmentDTO assignment);
        Task UpdateAssignmentAsync(AssignmentDTO assignment);
        Task DeleteAssignmentAsync(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TasksEvaluation.Core.DTOs;

namespace TasksEvaluation.Core.Interfaces.IServices
{
    public interface IEvaluatedAssignmentService
    {
        Task<IEnumerable<AssignmentDTO>> GetAssignmentsAsync();
        Task<AssignmentDTO> GetAssignmentAsync(int id);
        Task<IEnumerable<AssignmentDTO>> GetAssignmentsWithsolutionsAsync(int studentId);
        Task<IEnumerable<SolutionStudentDTO>> GetEvaluatedSolutionsAsync(int studentId);
        Task<SolutionStudentDTO> GetSolutionWithGradeAsync(int assignmentId, int studentId);
    }
}

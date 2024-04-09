using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
namespace TaskEvaluation.Core.Interfaces.IServices
{
    public interface IStudentService
    {
        Task<IEnumerable<StudentDTO>> GetStudentAsync(Expression<Func<StudentDTO, bool>>? filter = null);
        Task<StudentDTO> GetCourseByIdAsync(int id);
        Task UpdateAsync(StudentDTO model);
        Task<StudentDTO> AddAsync(StudentDTO model);
        Task DeletDeletAsync(int id);

    }
}

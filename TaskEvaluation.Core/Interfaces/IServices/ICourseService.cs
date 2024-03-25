using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEvaluation.Core.Interfaces.IServices
{
    public interface ICourseService
    {
        //Task<IEnumerable<CourseDTo>> GetCourses();
        //Task<CourseDTO> GetCourseByIdAsync(int id);
        //Task UpdateAsync(CourseDTO model);
        //Task<CourseDTO> CreateAsync(CourseDTO model);
        Task DeletAsync(int id);
    }
}

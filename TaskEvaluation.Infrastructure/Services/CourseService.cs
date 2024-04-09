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
    public class CourseService : ICourseService
    {
        private readonly IBaseRepository<Course> _courseRepository;

        public CourseService(IBaseRepository<Course> courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public Task<CourseDTO> CreateAsync(CourseDTO model)
        {
            throw new NotImplementedException();
        }

        public async Task DeletAsync(int id)
        {
            var courseToDelete = await _courseRepository.GetByIdAsync(id);
            if (courseToDelete != null)
            {
                await _courseRepository.DeleteAsync(courseToDelete);
            }
        }

        public Task<CourseDTO> GetCourseByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CourseDTO>> GetCourses()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(CourseDTO model)
        {
            throw new NotImplementedException();
        }
    }
}

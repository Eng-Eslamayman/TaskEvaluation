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
    internal class CourseService : ICourseService
    {
        private readonly IBaseRepository<Course> _courseRepository;

        public CourseService(IBaseRepository<Course> courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public async Task DeletAsync(int id)
        {
            var courseToDelete = await _courseRepository.GetByIdAsync(id);
            if (courseToDelete != null)
            {
                await _courseRepository.DeleteAsync(courseToDelete);
            }
        }
    }
}

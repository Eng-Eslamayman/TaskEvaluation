using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TaskEvaluation.Core.Entities.Business;
using TaskEvaluation.Core.Entities.DTOs;
using TaskEvaluation.Core.Interfaces.IRepositories;
using TaskEvaluation.Core.Interfaces.IServices;

namespace TaskEvaluation.Infrastructure.Services
{
    internal class StudentService : IStudentService
    {
        private readonly IBaseRepository<Student> _studentRepository;

        public StudentService(IBaseRepository<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public Task<StudentDTO> AddAsync(StudentDTO model)
        {
            throw new NotImplementedException();
        }

        public async Task DeletDeletAsync(int id)
        {
            var studentToDelete = await _studentRepository.GetByIdAsync(id);
            if (studentToDelete != null)
            {
                await _studentRepository.DeleteAsync(studentToDelete);
            }
        }

        public Task<StudentDTO> GetCourseByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

		public Task<IEnumerable<StudentDTO>> GetStudentAsync(Expression<Func<StudentDTO, bool>>? filter = null)
		{
			throw new NotImplementedException();
		}

		public Task UpdateAsync(StudentDTO model)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEvaluation.Core.Interfaces.IServices
{
    public interface ICourseService
    {
        Task Delet(int id);
    }
}

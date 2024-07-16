using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEvaluation.Core.Mapper
{
    using AutoMapper;
    using TaskEvaluation.Core.Entities.Business;

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Course, CourseDTO>().ReverseMap();
            
        }
    }

}

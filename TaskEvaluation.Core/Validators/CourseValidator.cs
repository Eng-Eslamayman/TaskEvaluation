using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskEvaluation.Core.Consts;
using TaskEvaluation.Core.Entities.Business;

namespace TaskEvaluation.Core.Validators
{
    public class CourseValidator : AbstractValidator<Course>
    {
        public CourseValidator()
        {
            RuleFor(course => course.Title)
                .NotNull().WithMessage(Errors.RequiredField);
        }
    }
}

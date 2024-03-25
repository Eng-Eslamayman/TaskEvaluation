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
    public class EvalutionGradeValidator : AbstractValidator<EvalutionGrade>
    {
        public EvalutionGradeValidator()
        {
            RuleFor(grade => grade.Grade)
           .NotNull().WithMessage(Errors.RequiredField);
        }
    }
}

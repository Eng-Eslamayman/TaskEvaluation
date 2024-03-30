using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskEvaluation.Core.Consts;
using TaskEvaluation.Core.Entities.Business;
using TaskEvaluation.Core.Entities.DTOs;

namespace TaskEvaluation.Core.Validators
{
    public class EvaluationGradeDTOValidator : AbstractValidator<EvaluationGardeDTO>
    {
        public EvaluationGradeDTOValidator()
        {
            RuleFor(g => g.Grade)
           .NotNull().WithMessage(Errors.RequiredField);
        }

    }
}

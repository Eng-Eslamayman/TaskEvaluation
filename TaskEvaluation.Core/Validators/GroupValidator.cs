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
    public class GroupValidator: AbstractValidator<Group>
    {
        public GroupValidator() 
        {
            RuleFor(group => group.Title)
                .NotNull().WithMessage(Errors.RequiredField);
        }

    }
}

using FluentValidation;
using TaskEvaluation.Core.Consts;
using TaskEvaluation.Core.Entities.Business;
using TaskEvaluation.Core.Entities.DTOs;
namespace TaskEvaluation.Core.Validators
{
    public class AssignmentDTOValidator: AbstractValidator<AssignmentDTO>
    {
        public AssignmentDTOValidator()
        {
            RuleFor(assign => assign.Title)
                .NotNull().WithMessage(Errors.RequiredField);
        }
    }
}

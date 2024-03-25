using FluentValidation;
using TaskEvaluation.Core.Consts;
using TaskEvaluation.Core.Entities.Business;
namespace TaskEvaluation.Core.Validators
{
    public class AssignmentValidator: AbstractValidator<Assignment>
    {
        public AssignmentValidator()
        {
            RuleFor(assign => assign.Title)
                .NotNull().WithMessage(Errors.RequiredField);
        }
    }
}

using FluentValidation;
using TaskEvaluation.Core.Entities.Business;
using TaskEvaluation.Core.Validators;

namespace TaskEvaluation.Web
{
    public static class FluentValidationSevicesRegisteration
    {
        public static void AddFluentValidationServices(this IServiceCollection Services)
        {
            Services.AddScoped<IValidator<Assignment>, AssignmentValidator>();
            Services.AddScoped<IValidator<Course>, CourseValidator>();
            Services.AddScoped<IValidator<EvaluationGrade>, EvalutionGradeValidator>();
            Services.AddScoped<IValidator<Core.Entities.Business.Group>, GroupValidator>();
            Services.AddScoped<IValidator<Solution>, SolutionValidator>();
            Services.AddScoped<IValidator<Student>, StudentValidator>();
        }
    }
}

using Entities.Concrete;
using FluentValidation;

namespace Business.Validation.FluentValidation
{
    public class DepartmentValidator : AbstractValidator<Department>
    {
        public DepartmentValidator()
        {
            RuleFor(r => r.Name).NotEmpty().WithMessage("Bölüm adı boş olamaz!");
            RuleFor(r=> r.Name).MinimumLength(3).WithMessage("Bölüm adı en az 3 karakter olmalıdır!");
            RuleFor(r => r.Name).MaximumLength(30).WithMessage("Bölüm adı en fazla 30 karakter olmalıdır!");
        }
    }
}

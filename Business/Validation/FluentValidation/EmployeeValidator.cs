using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validation.FluentValidation
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(r=> r.Name).NotEmpty().WithMessage("Personel adı boş olamaz!");
            RuleFor(r=> r.Name).MinimumLength(2).WithMessage("Personel adı en az iki karakter olmalıdır!");
            RuleFor(r => r.LastName).NotEmpty().WithMessage("Personel soyadı boş olamaz!");
            RuleFor(r => r.LastName).MinimumLength(2).WithMessage("Personel soyadı en az iki karakter olmalıdır!");
            RuleFor(r => r.Salary).GreaterThan(0).WithMessage("Personel maaşı asgari ücretten büyük olmalıdır!");
            RuleFor(r => r.BirthDate).LessThan(DateTime.Now.AddYears(-18)).WithMessage("Personel yaşı 18 yaşından büyük olmalıdır!");
            RuleFor(r => r.DepartmentId).GreaterThan(0).WithMessage("Personel departmanı seçilmelidir!");
        }
    }
}

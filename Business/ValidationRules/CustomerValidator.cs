using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validation
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator() 
        {
            RuleFor(x=>x.CompanyName).NotNull().NotEmpty().WithMessage("Firma İsmi Boş Olamaz!");
            RuleFor(x => x.TaxIdentificationNumber).MinimumLength(10).WithMessage("Lütfen geçerli VKN giriniz!");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen geçerli e-posta adresi yazınız!").When(x => !string.IsNullOrEmpty(x.Email));
        }
    }
}

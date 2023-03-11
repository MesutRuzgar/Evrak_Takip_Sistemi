using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class CommunicationValidator : AbstractValidator<Customer>
    {
        public CommunicationValidator()
        {
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen geçerli e-posta adresi yazınız!").When(x => !string.IsNullOrEmpty(x.Email));
        }

    }
}

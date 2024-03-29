﻿using Entities.Concrete;
using FluentValidation;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.CompanyName).NotNull().NotEmpty().WithMessage("Müşteri ünvanı boş olamaz!");
            RuleFor(x => x.TaxIdentificationNumber).MinimumLength(10).WithMessage("Lütfen geçerli VKN giriniz!");

            //Faaliyet belgesi tarihi bugüne eşit veya  küçük olması gerekir
            RuleFor(x => x.ActivityCertificateDate).LessThanOrEqualTo(DateTime.Now.Date)
            .WithMessage("Faaliyet belgesi tarihi bugünün tarihinden büyük olamaz.\nLütfen faaliyet belgenizin alındığı tarihi girdiğinizden emin olunuz!");

            //Vergi levhası yılı bir yıl geriden geldiği için en fazla günümüzün 1 yıl öncesi olacak şekilde kural düzenlendi
            //Cascade(CascadeMode.StopOnFirstFailure) bize kademeli olarak doğrulama sağlıyor bu sayede
            //2 hata mesajını aynı anda göstermek yerine aşamalı olarka kontrol edil o aşamaya göre
            //hata mesajı veriyor
            RuleFor(x => x.TaxPlateYear).Cascade(CascadeMode.StopOnFirstFailure).Must(yil => string.IsNullOrEmpty(yil) || int.TryParse(yil, out int yilSayisi)).WithMessage("Lütfen sadece sayı giriniz.").Must(yil => string.IsNullOrEmpty(yil) || (int.TryParse(yil, out int yilSayisi) && yilSayisi <= DateTime.Now.Year - 1)).WithMessage("Vergi levhası yılı, bugünkü yılın bir önceki yılına eşit veya küçük olabilir.");

            RuleFor(x => x.TaxPlateYear).MinimumLength(4).GreaterThan("1900").WithMessage("Vergi levhası yılını doğru girdiğinizden emin olunuz.").When(x => !string.IsNullOrEmpty(x.TaxPlateYear));
            RuleFor(x => x.ActivityCertificateDate).GreaterThanOrEqualTo(new DateTime(1900, 1, 1)).WithMessage("Faaliyet belgesi tarihi doğru girdiğinizden emin olunuz.");
            RuleFor(x => x.SignatureCircularDate).GreaterThanOrEqualTo(new DateTime(1900, 1, 1)).WithMessage("İmza sirküler tarihi doğru girdiğinizden emin olunuz.");



        }
    }
}

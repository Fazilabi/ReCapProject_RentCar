using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            
            RuleFor(cu => cu.CompanyName).MinimumLength(2).WithMessage("Company name must be min 2 characters"); ;
            RuleFor(cu => cu.UserId).NotEmpty();
        }
    }
}

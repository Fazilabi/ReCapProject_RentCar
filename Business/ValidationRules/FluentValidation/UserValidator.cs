using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    class UserValidator: AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Email).EmailAddress();
            RuleFor(u => u.Password).MinimumLength(4).WithMessage("Password must be min 4 characters"); ;
            RuleFor(u => u.FirstName).MinimumLength(2).WithMessage("First name must be min 2 characters"); ;
            RuleFor(u => u.LastName).MinimumLength(2).WithMessage("Last name must be min 2 characters"); ;
            

        }
    }
}

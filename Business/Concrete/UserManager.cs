using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userdal;

        public UserManager(IUserDal userdal)
        {
            _userdal = userdal;
        }
        [ValidationAspect(typeof(UserValidator))]
        public IResult Add(User user)
        {
            if (user.FirstName.Length < 2)
            {
                return new ErrorResult(Messages.UserFirstNameInvalid);
            }
            _userdal.Add(user);

            return new SuccessResult(Messages.UserAdded);           
            
        }

        public IResult Delete(User user)
        {
            _userdal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
           
            return new SuccessDataResult<List<User>>(_userdal.GetAll(), Messages.UserListed);
        }

        public IResult Update(User user)
        {
            _userdal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }
    }
}

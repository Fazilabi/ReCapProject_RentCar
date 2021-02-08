using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager:IBrandService
    {
        IBrandDal _BrandDal;
        public BrandManager(IBrandDal _brandDal)
        {
            _BrandDal = _brandDal;
            
        }

        public List<Brand> GetAll()
        {
           return _BrandDal.GetAll();
        }
    }
}

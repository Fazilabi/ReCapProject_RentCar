using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentContext>, ICarDal
    {
        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            using (CarRentContext carRentContext = new CarRentContext())
            {
                var result = from c in carRentContext.Cars
                             join b in carRentContext.Brands
                             on c.BrandId equals b.BrandId
                             select new CarDetailDto 
                             { 
                                 BrandId = c.BrandId, 
                                 BrandName = b.BrandName,
                                 Description = c.Descriptions, 
                                 DailyPrice = c.DailyPrice, 
                                 Id = c.CarId 
                             };
                return new SuccessDataResult<List<CarDetailDto>> (result.ToList());

            }
        }
    }
}

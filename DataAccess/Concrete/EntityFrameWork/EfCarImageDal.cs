using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfCarImageDal: EfEntityRepositoryBase <CarImage, CarRentContext>, ICarImageDal
    {
        //public IDataResult<List<CarImageDetailDto>> GetCarImageDetails()
        //{
        //    using (CarRentContext carRentContext = new CarRentContext())
        //    {
        //       

        //    }
        //}

    }
}

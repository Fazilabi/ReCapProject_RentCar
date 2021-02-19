using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetailDtos()
        {
            using (CarRentContext context = new CarRentContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.CarId equals b.BrandId
                             join r in context.Rentals
                             on c.CarId equals r.CarId
                             join customer in context.Customers
                             on r.CustomerId equals customer.CustomerId
                             join u in context.Users
                             on customer.UserId equals u.UserId
                             select new RentalDetailDto
                             {
                                  RentalId = r.RentalId,
                                  BrandName = b.BrandName,
                                  Description = c.Descriptions,
                                  CustomerName = u.FirstName +" ** "+u.LastName,
                                  RentDate = r.RentDate,
                                  ReturnDate = r.ReturnDate

                             };
                return result.ToList();
            }
        }
    }
}

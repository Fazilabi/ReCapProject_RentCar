using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice>0 && car.Descriptions.Length>2)
            {
                _carDal.Add(car);
                Console.WriteLine("new car successfully added");

            }
            else
            {
                Console.WriteLine("Please enter a valid data");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("car deleted successfully");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);
        }

        
        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId);
        }

        public void Update(Car car)
        {
            if (car.DailyPrice>0 && car.Descriptions.Length>2)
            {
                _carDal.Update(car);
                Console.WriteLine("Car updated successfully");
            }
            else
            {
                Console.WriteLine("Please enter a valid data");
            }
        }
    }
}

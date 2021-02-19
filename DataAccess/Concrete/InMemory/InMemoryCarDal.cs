using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
               new Car{ CarId = 1 , BrandId = 3, ColorId= 2 , ModelYear= "2018", DailyPrice= 100, Descriptions= "Opel econom"  },
               new Car{ CarId = 2 , BrandId = 1, ColorId= 1 , ModelYear= "2019", DailyPrice= 150, Descriptions= "Renault  econom"  },
               new Car{ CarId = 3 , BrandId = 2, ColorId= 3 , ModelYear= "2020", DailyPrice= 200, Descriptions= "Mercedes comfort"  },
               new Car{ CarId = 4 , BrandId = 3, ColorId= 5 , ModelYear= "2019", DailyPrice= 140, Descriptions= "BMW comfort"  },
               new Car{ CarId = 5 , BrandId = 1, ColorId= 4 , ModelYear= "2020", DailyPrice= 180, Descriptions= "Hyundai econom"  }
            };
        }
        

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(item=>item.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllById(int brandId)
        {
           return  _cars.Where(item => item.BrandId == brandId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCars()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(item => item.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Descriptions = car.Descriptions;

        }
    }
}

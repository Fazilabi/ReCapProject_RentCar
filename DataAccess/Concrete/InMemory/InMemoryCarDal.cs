using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
               new Car{ Id = 1 , BrandId = 3, ColorId= 2 , ModelYear= 2018, DailyPrice= 100, Description= "Opel econom"  },
               new Car{ Id = 2 , BrandId = 1, ColorId= 1 , ModelYear= 2019, DailyPrice= 150, Description= "Renault  econom"  },
               new Car{ Id = 3 , BrandId = 2, ColorId= 3 , ModelYear= 2020, DailyPrice= 200, Description= "Mercedes comfort"  },
               new Car{ Id = 4 , BrandId = 3, ColorId= 5 , ModelYear= 2019, DailyPrice= 140, Description= "BMW comfort"  },
               new Car{ Id = 5 , BrandId = 1, ColorId= 4 , ModelYear= 2020, DailyPrice= 180, Description= "Hyundai econom"  }
            };
        }
        

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(item=>item.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAllById(int brandId)
        {
           return  _cars.Where(item => item.BrandId == brandId).ToList();
        }

        public List<Car> GetCars()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(item => item.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;

        }
    }
}

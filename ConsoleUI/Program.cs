using Business.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("{0} -- {1} -- {2}", car.Id, car.BrandName, car.Description);

            }


            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.BrandName);

            //}

            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //foreach (var item in brandManager.GetAll())
            //{
            //    Console.WriteLine(item.BrandName);
            //}










        }
    }
}

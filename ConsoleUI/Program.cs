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

            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("{0} -- {1} -- {2} ", car.Id, car.BrandName, car.Description);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
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

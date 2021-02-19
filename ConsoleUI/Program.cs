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
            //TestGetCarDetails();
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            UserManager userManager = new UserManager(new EfUserDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            // ********************
            //foreach (var brand in brandManager.GetAll().Data)
            //{
            //    Console.WriteLine(brand.BrandName);
            //};
            // ********************
            //foreach (var user in userManager.GetAll().Data)
            //{
            //    Console.WriteLine(user.FirstName +" ** "+user.LastName );
            //}
            // ********************
            //foreach (var customer in customerManager.GetAll().Data)
            //{
            //    Console.WriteLine(customer.CompanyName);
            //}

            // ********************
            //foreach (var rental in rentalManager.GetAll().Data)
            //{
            //    Console.WriteLine(rental.CustomerId + " ** " +rental.RentDate );
            //}
            // ********************
            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.BrandName);

            //}
            // ********************

            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //foreach (var item in brandManager.GetAll())
            //{
            //    Console.WriteLine(item.BrandName);
            //}

            // ********************

            foreach (var rental in rentalManager.GetRentalDetails().Data)
            {
                Console.WriteLine(rental.BrandName +" - "+rental.CustomerName+" - "+rental.Description+" - "+ rental.RentDate );
            }










        }

        private static void TestGetCarDetails()
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
        }
    }
}

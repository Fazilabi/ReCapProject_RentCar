using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {   //Car
        public static string CarAdded = "Car added";
        public static string CarDeleted = "Car deleted";
        public static string CarUpdated = "Car updated";
        public static string CarListed = "Car listed";
        public static string CarListedById = "Car listed by id";
        public static string CarDetailListed = "Car detail listed";
        public static string CarByBrandIdListed = "Car updated";
        public static string CarDescriptionInvalid = "Car name invalid";
        //Brand
        public static string BrandAdded = "Brand added";
        public static string BrandUpdated = "Brand updated";
        public static string BrandDeleted = "Brand deleted";
        public static string BrandListed = "Brand listed";
        //Color
        public static string ColorAdded = "Color added";
        public static string ColorUpdated = "Color updated";
        public static string ColorDeleted = "Color deleted";
        public static string ColorListed = "Color listed";
        //User
        public static string UserListed = "User listed";
        public static string UserAdded = "User added";
        public static string UserUpdated = "User updated";
        public static string UserDeleted = "User deleted";
        public static string UserFirstNameInvalid = "User first name invalid";
        //Customer
        public static string CustomerListed = "Customer listed";
        public static string CustomerAdded = "Customer added";
        public static string CustomerUpdated = "Customer updated";
        public static string CustomerDeleted = "Customer deleted";
        public static string CustomerCompanyNameInvalid = "Customer company name invalid";
        //Rental
        public static string RentalListed = "Rental listed";
        public static string RentalAdded = "Rental added";
        public static string RentalUpdated = "Rental updated";
        public static string RentalDeleted = "Rental deleted";

        public static string MaintenanceTime = "Cars is loading";
    }
}

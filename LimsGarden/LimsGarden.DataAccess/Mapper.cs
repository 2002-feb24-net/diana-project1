using LimsGarden.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LimsGarden.DataAccess
{
    public static class Mapper
    {
        public static Customer MapCustomer(Model.Customer customer)
        {
            return new Customer
            {
                CustomerId = customer.CustomerId,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Username = customer.Username,
                Password = customer.Password,
            };
        }

        public static Model.Customer MapCustomer(Customer customer)
        {
            return new Model.Customer
            {
                CustomerId = customer.CustomerId,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Username = customer.Username,
                Password = customer.Password,
            };
        }
    }
}
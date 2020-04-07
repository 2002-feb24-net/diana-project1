using System.Collections.Generic;
using LimsGarden.Core.Model;

namespace LimsGarden.Core.Interfaces
{
        public interface ICustomerRepository
    {
       
        IEnumerable<Customer> GetCustomer(string search = null);

       
        Customer GetCustomerById(int id);

        
        void AddCustomer(Customer customer);

        
        void DeleteCustomer(int customerId);

        
        void UpdateCustomer(Customer customer);


    
        void Save();
    }
}

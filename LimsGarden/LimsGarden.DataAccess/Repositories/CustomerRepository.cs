using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using LimsGarden.DataAccess.Model;
using LimsGarden.Core.Interfaces;

namespace LimsGarden.DataAccess.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly LimsGardenContext _dbContext;

        private readonly ILogger<CustomerRepository> _logger;

        /// <summary>
        /// Initializes a new restaurant repository given a suitable restaurant data source.
        /// </summary>
        /// <param name="dbContext">The data source</param>
        /// <param name="logger">The logger</param>
        public CustomerRepository(LimsGardenContext dbContext, ILogger<CustomerRepository> logger)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        public void AddCustomer(Core.Model.Customer customer)
        {
           /* if (customer.Id != 0)
            {
                _logger.LogWarning("Customer to be added has an ID ({customerId}) already: ignoring.", customer.Id);
            }

            _logger.LogInformation("Adding customer");

            Customer entity = Mapper.MapRestaurantWithReviews(customer);
            entity.Id = 0;
            _dbContext.Add(entity); */
            throw new NotImplementedException();
        }

        public void DeleteCustomer(int customerId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Core.Model.Customer> GetCustomer(string search = null)
        {
            throw new NotImplementedException();
        }

        public Core.Model.Customer GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(Core.Model.Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}


using LimsGarden.Core.Interfaces;
using LimsGarden.Core.Model;
using LimsGarden.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;

namespace LimsGarden.Web.Controllers
{
    public class CustomerController : Controller
    {
        public ICustomerRepository Repo {get;}

        public CustomerController(ICustomerRepository repo) =>
            Repo = repo ?? throw new ArgumentException(nameof(repo));
        // GET: /Customer/
        public IActionResult Index([FromQuery] string search = "")
        {
            IEnumerable<Customer> customers = Repo.GetCustomers(search);
            IEnumerable<LimsGarden.Web.Models.CustomerViewModel> viewModels = customers.Select(a => new
                CustomerViewModel
                {
                    CustomerId = a.CustomerId,
                    FirstName = a.FirstName,
                    LastName = a.LastName,
                    Username = a.Username,
                    Password = a.Password

                });
            return View(viewModels);
        }

        // GET: /Customer/AddCustomer
        public string AddCustomer()
        {
            return "This is the Welcome action method...";
        }
    }
}
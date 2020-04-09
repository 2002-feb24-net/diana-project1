using LimsGarden.Core.Interfaces;
using LimsGarden.Core.Model;
using LimsGarden.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using LimsGarden.DataAccess.Model;
using System.Threading.Tasks;


namespace LimsGarden.Web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly LimsGardenContext _context = new LimsGardenContext();
        public ICustomerRepository Repo {get;}

        public CustomerController(ICustomerRepository repo) =>
            Repo = repo ?? throw new ArgumentException(nameof(repo));
        // GET: /Customer/
        public IActionResult Create()
        {     
            return View();      
            //throw new NotImplementedException();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
         public IActionResult Create([Bind("FirstName, LastName, Username, Password")]LimsGarden.Core.Model.Customer CreateCustomer)
        {     
            if(ModelState.IsValid)
            {
                var newCustomer = new LimsGarden.DataAccess.Model.Customer
                {
                    FirstName=CreateCustomer.FirstName, 
                    LastName=CreateCustomer.LastName,
                    Username=CreateCustomer.Username,
                    Password=CreateCustomer.Password
                };

                _context.Customer.Add(newCustomer);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            return View(CreateCustomer);      
            //throw new NotImplementedException();
        }

        public IActionResult Search(string SearchFirstName, string SearchLastName)
        {
            var Name = _context.Customer.Where(x => x.FirstName == SearchFirstName && x.LastName == SearchLastName);
            var Model = new CustomerViewModel
            {
                customers = Name.ToList()
            };
            return View("Index", Model);
        }



        public IActionResult Index()
        {
            var ViewModel = new CustomerViewModel
            {
                customers = _context.Customer.ToList()
            };
            return View(ViewModel);
        }

        // GET: /Customer/AddCustomer
        public string AddCustomer()
        {
            return "This is the Welcome action method...";
        }
    }
}
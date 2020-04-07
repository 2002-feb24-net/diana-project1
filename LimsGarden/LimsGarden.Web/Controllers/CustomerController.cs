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
        public IActionResult Create([FromQuery] string search = "")
        {            
            throw new NotImplementedException();
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
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
    ///<summary> 
    /// This Controller communicates information relating to Order Details.
    ///</summary>
    public class OrderDetailsController : Controller
    {
        private readonly LimsGardenContext _context = new LimsGardenContext();

        public IActionResult Index()
        {
            var ViewModel = new OrderDetailsViewModel
            {
                orders = _context.OrderDetails.ToList()
            };
            return View(ViewModel);
        }

    }
}

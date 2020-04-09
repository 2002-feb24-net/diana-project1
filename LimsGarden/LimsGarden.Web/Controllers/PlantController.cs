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
    public class PlantController : Controller
    {
        private readonly LimsGardenContext _context = new LimsGardenContext();

         public IActionResult Index()
        {
            var ViewModel = new PlantViewModel
            {
                plants = _context.Plant.ToList()
            };
            return View(ViewModel);
        }

    }
}

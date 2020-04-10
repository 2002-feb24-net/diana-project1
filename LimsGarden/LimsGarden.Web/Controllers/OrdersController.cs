using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using LimsGarden.DataAccess.Model;

namespace LimsGarden.Web.Controllers 
{
    ///<summary> 
    /// This Controller communicates information relating to the Orders.
    ///</summary>
    public class OrdersController : Controller
    {
        private readonly LimsGardenContext _context = new LimsGardenContext();

        public async Task<IActionResult> Index()
        {
            var LimsGardenContext = await _context.Orders.Include("Customer").Include("Location").ToListAsync();
            return View(LimsGardenContext);
        }

        public IActionResult CreateOrderItem()
        {
     
            int storeID = Convert.ToInt32(TempData["StoreID"]);
            TempData["StoreID"] = storeID;
            ViewData["Pid"] = new SelectList(_context.Plant, "PlantId", "PlantName", "Cost");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateOrderItem([Bind("OrderId", "Quantity", "PlantId")] OrderDetails item)
        {
            try
            {
                int oid = Convert.ToInt32(TempData["OrderID"]);
                item.OrderId = oid;
                _context.OrderDetails.Add(item);
                _context.Plant.First(p => p.PlantId == item.PlantId).InventoryCount = _context.Plant.First(p => p.PlantId == item.PlantId).InventoryCount - item.Quantity;
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
           catch
            {
               return View(item);
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult addMoreItems([Bind("OrderId", "Quantity", "PlantId")] OrderDetails item)
        {
            try
            {
                int oid = Convert.ToInt32(TempData["OrderID"]);
                item.OrderId = oid;
                _context.OrderDetails.Add(item);
                _context.Plant.First(p => p.PlantId == item.PlantId).InventoryCount = _context.Plant.First(p => p.PlantId == item.PlantId).InventoryCount - item.Quantity;
                _context.SaveChanges();
                return RedirectToAction("CreateOrderItem");
            }
           catch
            {
               return View(item);
            }

        }


        // GET: Orders and Create
        public IActionResult Create()
        {
           
            ViewData["LocId"] = new SelectList(_context.Location.ToList(), "LocationId", "BranchName");
            ViewData["CustId"] = new SelectList(_context.Customer.ToList(), "CustomerId", "Username");
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("CustomerId,LocationId,Username,Pwd")] Orders order)
        {
            if (ModelState.IsValid)
            {
                var new_order = new Orders
                {
                    LocationId = order.LocationId,
                    CustomerId = order.CustomerId,
                    OrderTotal = 0,
                };
                _context.Orders.Add(new_order);
                _context.SaveChanges();
                _context.Entry(new_order).Reload();
                TempData["OrderID"] = new_order.OrderId;
                TempData["StoreID"] = order.LocationId;
                return RedirectToAction("CreateOrderItem");
             
            }
            return View(order);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var order = _context.Orders.Include("Order").Include("Plant").FirstOrDefault(x => x.OrderId == Convert.ToInt32(id));
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

    }
}

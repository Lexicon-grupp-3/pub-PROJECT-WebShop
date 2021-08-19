using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nancy.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopReactCore.Data;
using WebShopReactCore.Models;
using System.Text.Json;

namespace WebShopReactCore.Controllers
{
    public class OrderController : Controller
    {

        private readonly AppStoreDbContext _context;

        public OrderController(AppStoreDbContext ctx)
        {
            _context = ctx;
        }

        [HttpPut]
        public int SaveOrder([FromBody] string data)
        {
            try
            {
                Order newOrder = JsonSerializer.Deserialize<Order>(data);
                DateTime tmp = DateTime.Now;
                //tmp = DateTime.UtcNow();
                newOrder.DueDate = tmp; //.AddDays(10);
                newOrder.PayDate = tmp;
                this._context.Orders.Add(newOrder);
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }

            return this._context.SaveChanges();
        }

        

        // GET: OrderController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        
        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

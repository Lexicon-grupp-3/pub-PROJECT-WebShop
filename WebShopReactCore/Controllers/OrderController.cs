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
        public string SaveOrder([FromBody] string data)
        {
            try
            {
                Order newOrder = JsonSerializer.Deserialize<Order>(data);
            }
            catch(Exception ex) {
                try
                {
                    Console.WriteLine(ex.Message);
                    List<OrderItem> items = JsonSerializer.Deserialize<List<OrderItem>>(data).ToList();
                }
                catch(Exception ext)
                {
                    Console.WriteLine(ext.Message);
                }
            }

            //OrderItem[] items = js.Deserialize<OrderItem[]>(data);
            //var keys = items.Keys;
            //foreach (var key in items.Keys)
            //{
                
            //        var tmp = items[key];
                
            //}

            string res="";

            return res ;
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

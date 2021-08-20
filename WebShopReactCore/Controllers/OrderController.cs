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
using Microsoft.AspNetCore.Authorization;

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

            
        [HttpGet]
        // [Authorize]
        public List<Order> GetOrders(string email)
        {
            var tmp = this._context.Orders.Where(x => x.userEmail == email).ToList<Order>();
            //var tmp = this._context.Orders.Where(x => x.userEmail == "chris@data4mat.com").ToList<Order>();

            return tmp;
        }
    }
}

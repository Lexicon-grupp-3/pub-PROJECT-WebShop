
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopReactCore.Data;
using WebShopReactCore.Models;

namespace WebShopReactCore.Controllers
{
    public class AuthorBookController : Controller
    {
        private readonly AppStoreDbContext _context;
        public AuthorBookController(AppStoreDbContext ctx)
        {
            _context = ctx;
        }


        [HttpGet]
        public IEnumerable<Author> Index()
        {
            //var rng = new Random();
            var x = Enumerable.Range(1, 5).Select(index => new Author
            {
                Id = index,
                FirstName = "Kalle",
                LastName = "Olsson"
            })
            .ToArray();
            //return Enumerable.Range(1, 5).Select(index => new Author
            //{
            //    Id = 1,
            //    FirstName = "Kalle",
            //    LastName = "Olsson"
            //})
            //.ToArray();
            return x;
        }





        // GET: AuthorBookController
        public ActionResult Index2()
        {
            //var rng = new Random();
            //return Enumerable.Range(1, 5).Select(index => new Author
            //{
            //    FirstName = "Kalle",
            //    LastName = "Olsson"
            //})
            //.ToArray();
            return View("text från AuthorBookController");
        }

        // GET: AuthorBookController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AuthorBookController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuthorBookController/Create
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

        // GET: AuthorBookController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AuthorBookController/Edit/5
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

        // GET: AuthorBookController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AuthorBookController/Delete/5
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

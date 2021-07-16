
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopReactCore.Data;

namespace WebShopReactCore.Controllers
{
    public class AuthorBookController : Controller
    {
        private readonly AppStoreDbContext _context;
        public AuthorBookController(AppStoreDbContext ctx)
        {
            _context = ctx;
        }
        // GET: AuthorBookController
        public ActionResult Index()
        {
            return View();
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

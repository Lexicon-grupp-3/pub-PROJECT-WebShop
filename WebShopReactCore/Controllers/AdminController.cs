using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopReactCore.Models;
using WebShopReactCore.Data;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace WebShopReactCore.Controllers.Admin
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private IPasswordHasher<ApplicationUser> _passwordHash;
        private ApplicationDbContext _context;
        private DataFunctions _dataFunctions;
        private List<AppUserData> _appUserDataList;

        public AdminController(UserManager<ApplicationUser> usrMgr, IPasswordHasher<ApplicationUser> pwHash, ApplicationDbContext ctx)
        {
            _userManager = usrMgr;
            _passwordHash = pwHash;
            _context = ctx;
            _dataFunctions = new DataFunctions(_context);
            _appUserDataList = new List<AppUserData>();
        }

        [HttpGet]
        public IActionResult Index()
        {
            foreach(ApplicationUser user in _userManager.Users)
            {
                AppUserData tmp = new AppUserData(user, _context);
                _appUserDataList.Add(new AppUserData(user, _context));
            }
            return View(_appUserDataList);
        }

        [HttpGet]
        public async Task<IActionResult> CreateUser()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> EditUser(string id)
        {
            ApplicationUser user = await _userManager.FindByIdAsync(id);
            AppUserData appUserData = new AppUserData(user, _context);
            if (user != null)
            {
                return View(appUserData);
            }
            //return RedirectToAction("Index"); // tmp code
            else
            {
                ModelState.AddModelError("", "Cannot find user");
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditUser(string Id, string FirstName, string LastName, string Email, string Password, string CityName, string CountryName)
        {
            try
            {
                ApplicationUser user = await _userManager.FindByIdAsync(Id);

                /***** Sections commented out below are not used in this application. *****/
            
                //var i_city = _dataFunctions.FindCityByName(CityName);
                //var i_country = _dataFunctions.FindCountryByName(CountryName);
                //if (i_country == null)
                //{
                //    if (_dataFunctions.CreateCountry(CountryName))
                //    {
                //        i_country = _dataFunctions.FindCountryByName(CountryName);
                //    }
                //    else
                //        ModelState.AddModelError("", "Could not create Country");
                //}
                //if (i_city == null && i_country != null)
                //{
                //    if (_dataFunctions.CreateCity(CityName, i_country.Id))
                //    {
                //        i_city = _dataFunctions.FindCityByName(CityName);
                //    }
                //    else
                //    {
                //        ModelState.AddModelError("", "Could not create City");
                //    }
                //}

                if (user != null)
                {
                    if (!string.IsNullOrEmpty(FirstName)) user.FirstName = FirstName;
                    else ModelState.AddModelError("", "First name cannot be empty");

                    if (!string.IsNullOrEmpty(LastName)) user.LastName = LastName;
                    else ModelState.AddModelError("", "Last name cannot be empty");

                    if (!string.IsNullOrEmpty(Email)) user.Email = Email;
                    else ModelState.AddModelError("", "Email cannot be empty");

                    //if (!string.IsNullOrEmpty(CityName)) user.CityId = i_city.Id;
                    //else ModelState.AddModelError("", "City cannot be empty");

                    //if (!string.IsNullOrEmpty(CountryName)) user.CountryId = i_country.Id;
                    //else ModelState.AddModelError("", "Country cannot be empty");

                    if (!string.IsNullOrEmpty(Id))
                    {
                        IdentityResult result = await _userManager.UpdateAsync(user);
                        if (result.Succeeded)
                            return RedirectToAction("Index");
                        else
                            Errors(result);
                    }
                }
                else
                    ModelState.AddModelError("", "User not found");

                return View(user);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeleteUser(string Id)
        {
            ApplicationUser user = await _userManager.FindByIdAsync(Id);
            _ = _userManager.DeleteAsync(user);
            return RedirectToAction("Index");
        }

        //[HttpGet]
        //public IActionResult ListCountries()
        //{
        //    Countries countries = new Countries();
        //    countries.LoadCountries(_context);
        //    return View(countries.List.OrderBy(c => c.Name));
        //}

        //[HttpGet]
        //public IActionResult CreateCountry()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult CreateCountry(string name)
        //{
        //    CountryClass country = new CountryClass();
        //    country.Name = name;
        //    _context.Countries.Add(country);
        //    _context.SaveChanges();

        //    return RedirectToAction("ListCountries");
        //}

        //[HttpGet]
        //public IActionResult EditCountry(int Id)
        //{
        //    return View(_context.Countries.Find(Id));
        //}

        //[HttpPost]
        //public async Task<IActionResult> EditCountry(int Id, string Name)
        //{
        //    CountryClass country = await _context.Countries.FindAsync(Id);
            
        //    if(country!=null)
        //    {
        //        if (!string.IsNullOrEmpty(Name)) country.Name = Name;
        //        else ModelState.AddModelError("", "Contry name can not be empty");

        //        if (!string.IsNullOrEmpty(Id.ToString()))
        //        {
        //            EntityEntry result = _context.Update<CountryClass>(country);
        //            _ = _context.SaveChanges();
        //        }
        //    }
        //    return RedirectToAction("ListCountries");
        //}

        //[HttpPost]
        //public IActionResult DeleteCountry(int id)
        //{
        //    CountryClass country = _context.Countries.Find(id);

        //    _ = _context.Remove<CountryClass>(country);
        //    _context.SaveChanges();
        //    return RedirectToAction("ListCountries");
        //}

        //[HttpGet]
        //public IActionResult ListCities()
        //{
        //    Cities cities = new();
        //    cities.LoadCities(_context);
        //    return View(cities.List.OrderBy(c => c.Name));
        //}

        //[HttpGet]
        //public IActionResult CreateCity()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult CreateCity(string name, string country)
        //{
        //    var i_country = _dataFunctions.FindCountryByName(country);
        //    if(i_country==null)
        //    {
        //        _dataFunctions.CreateCountry(country);
        //        i_country = _dataFunctions.FindCountryByName(country);
        //    }

        //    var i_city = _dataFunctions.FindCityByName(name);

        //    if (i_city == null)
        //    {
        //        _dataFunctions.CreateCity(name, i_country.Id);
        //        i_city = _dataFunctions.FindCityByName(name);
        //    }

        //    return RedirectToAction("ListCities");
        //}

        //[HttpGet]
        //public IActionResult EditCity(int id)
        //{
        //    CityClass cc = _context.Cities.Find(id);
        //    CityData city = new CityData(cc.CountryId, _context);
        //    city.Id = cc.Id;
        //    city.Name = cc.Name;

        //    return View(city);
        //}

        //[HttpPost]
        //public async Task<IActionResult> EditCity(int id, string name, string country, int countryId)
        //{
        //    CityClass city = await _context.Cities.FindAsync(id);

        //    if (city != null)
        //    {
        //        if (!string.IsNullOrEmpty(name)) city.Name = name;
        //        else ModelState.AddModelError("", "City name can not be empty");

        //        if (!string.IsNullOrEmpty(countryId.ToString())) city.CountryId = countryId;

        //        if (!string.IsNullOrEmpty(id.ToString()))
        //        {
        //            EntityEntry result = _context.Update<CityClass>(city);
        //            _ = _context.SaveChanges();
        //        }
        //    }
        //    return RedirectToAction("ListCities");
        //}

        //public IActionResult DeleteCity(int id)
        //{
        //    CityClass city = _context.Cities.Find(id);
        //    _ = _context.Remove<CityClass>(city);
        //    _context.SaveChanges();

        //    return RedirectToAction("ListCities");
        //}

        public void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
        }
    }
}

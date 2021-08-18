using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopReactCore.Data;

namespace WebShopReactCore.Models
{
    public class DataFunctions
    {
        private ApplicationDbContext _context { get; set; }

        public DataFunctions(ApplicationDbContext ctx)
        {
            this._context = ctx;
        }

        public List<ApplicationUser> GetUsers()
        {
            IQueryable<ApplicationUser> query = (IQueryable<ApplicationUser>)this._context.Users.OrderBy(x => x.UserName);

            return query.ToList<ApplicationUser>();
        }

        /***** The following section is not implemented in this application *****/

        /*
        public bool CreateCity(string name, int country_id = -1)
        {
            int res = -1;
            if (country_id != -1)
            {
                _context.Add<CityClass>(new CityClass
                {
                    Name = name,
                    CountryId = country_id
                });

                res = _context.SaveChanges();

            }
            if (res > 0) return true;
            else return false;
        }

        public bool CreateCountry(string name)
        {
            int res = -1;

            _context.Add<CountryClass>(new CountryClass
            {
                Name = name
            });

            res = _context.SaveChanges();

            if (res > 0) return true;
            else return false;
        }
        
        public CityClass FindCityByName(string name)
        {
            foreach (CityClass city in _context.Cities)
            {
                if (city.Name.ToLower() == name.ToLower())
                {
                    return city;
                }
            }

            return null;
        }

        public CountryClass FindCountryByName(string name)
        {
            foreach (CountryClass country in _context.Countries)
            {
                if (country.Name.ToLower() == name.ToLower())
                {
                    return country;
                }
            }

            return null;
        }
        */
    }
}

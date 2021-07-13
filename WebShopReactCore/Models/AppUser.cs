using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopReactCore.Models
{
    public class AppUser: ApplicationUser, IAppUser
    {
        public AppUser() : base() { }
    }

    public interface IAppUser
    {

    }

}

using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopReactCore.Models
{
    public class ApplicationUser : IdentityUser
    {
        private ApplicationUser user;

        public ApplicationUser() : base() { }

        public ApplicationUser(ApplicationUser user) : base()
        {
            this.user = user;
        }

        public ApplicationUser User { get { return this.user; } }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

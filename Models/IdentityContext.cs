using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IK.Auth.Models
{
    public class IdentityContext : IdentityDbContext<AppUser>
    {
        // Other part of codes still same 
        // You don't need to add AppUser and AppRole 
        // since automatically added by inheriting form IdentityDbContext<AppUser>

        public IdentityContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

    }
}
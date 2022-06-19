﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BookShop.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the BookShopUser class
    public class BookShopUser : IdentityUser
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public DateTime BirthDate { get; set; }
    }
}

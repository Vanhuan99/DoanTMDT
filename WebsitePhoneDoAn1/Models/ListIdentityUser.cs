using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebsitePhoneDoAn1.Models
{
    public class ListIdentityUser : Controller
    {
        public List<User> ListUser { get; set; }
        public enum RoleType
        {
            Admin, User, HR
        }
    }
}

using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebsitePhoneDoAn1.Models;

namespace WebsitePhoneDoAn1.Helper
{
    public class Helper : Profile
    {
        public Helper()
        {
            CreateMap<UserRegistrationModel, User>();
        }
    }
}

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hraci.Models
{
    public class Users
    {
       
        public void VratUziv(ApplicationUser ap)
        {
            Console.WriteLine(ap.Email);
        }
    }
}
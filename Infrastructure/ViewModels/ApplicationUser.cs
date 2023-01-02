using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ViewModels
{
    public class ApplicationUser :IdentityUser
    {

        public string UserName { get; set; }
        public string phone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime birthday { get; set; }

        public bool Enabled { get; set; }=true;


    }
}

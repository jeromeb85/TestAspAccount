using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAspAccount.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
    }
}

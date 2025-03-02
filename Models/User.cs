using Microsoft.AspNetCore.Identity;

namespace UserRegistrationLoginLogoutWithIdentity.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
    }
}

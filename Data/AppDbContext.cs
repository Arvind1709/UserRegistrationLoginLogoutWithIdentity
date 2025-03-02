using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserRegistrationLoginLogoutWithIdentity.Models;

namespace UserRegistrationLoginLogoutWithIdentity.Data
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}

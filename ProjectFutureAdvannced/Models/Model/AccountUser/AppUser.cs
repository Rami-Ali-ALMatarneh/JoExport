using Microsoft.AspNetCore.Identity;

namespace ProjectFutureAdvannced.Models.Model.AccountUser
    {
    public class AppUser:IdentityUser
        {
        public string? ImgUrl { get; set; }
        }
    }

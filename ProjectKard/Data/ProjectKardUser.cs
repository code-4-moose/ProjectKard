﻿using Microsoft.AspNetCore.Identity;

namespace ProjectKard.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ProjectKardUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}

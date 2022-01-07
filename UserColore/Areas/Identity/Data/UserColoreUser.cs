using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace UserColore.Areas.Identity.Data;

// Add profile data for application users by adding properties to the UserColoreUser class
public class UserColoreUser : IdentityUser
{
    public string? Nome { get; set; }
}


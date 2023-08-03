using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Identity;

namespace Nompilo.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    [Display(Name = "Name")]
    public string firstName { get; set; }
    [Display(Name = "Last Name")]
    public string lastName { get; set; }
    [Display(Name = "Gender")]
    public string gender { get; set; }
    [Display(Name = "Marital Status")]
    public string maritalStatus { get; set; }
    [Display(Name = "Identity Number")]
    public int IdNumber { get; set; }
    [Display(Name = "Contact Number")]
    public int contactNumber { get; set; }

    public ApplicationUser()
    {
        gender = "Not set";
        maritalStatus = "Not Set";

    }
}


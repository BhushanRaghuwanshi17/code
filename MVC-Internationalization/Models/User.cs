using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_Internationalization.Models
{
    public class UserViewModel
    {
        [Display(Name = "Username", ResourceType = typeof(ViewResources.Resource))]
        [Required(ErrorMessageResourceName = "UsernameRequired", ErrorMessageResourceType = typeof(ViewResources.Resource))]
        public string Username { get; set; }

        [Display(Name = "Name", ResourceType = typeof(ViewResources.Resource))]
        [Required(ErrorMessageResourceName = "NameRequired", ErrorMessageResourceType = typeof(ViewResources.Resource))]
        public string Name { get; set; }

        [Display(Name = "Password", ResourceType = typeof(ViewResources.Resource))]
        [Required(ErrorMessageResourceName = "PasswordRequired", ErrorMessageResourceType = typeof(ViewResources.Resource))]
        public string Password { get; set; }

        [Display(Name = "ConfirmPassword", ResourceType = typeof(ViewResources.Resource))]
        [Required(ErrorMessageResourceName = "ConfirmPasswordRequired", ErrorMessageResourceType = typeof(ViewResources.Resource))]
        [Compare("Password", ErrorMessageResourceName = "ConfirmPasswordCompare", ErrorMessageResourceType = typeof(ViewResources.Resource))]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Address", ResourceType = typeof(ViewResources.Resource))]
        [Required(ErrorMessageResourceName = "AddressRequired", ErrorMessageResourceType = typeof(ViewResources.Resource))]
        public string Address { get; set; }
    }
}
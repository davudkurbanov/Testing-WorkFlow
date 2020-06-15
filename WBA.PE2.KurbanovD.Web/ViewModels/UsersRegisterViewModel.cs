using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WBA.PE2.KurbanovD.Web.ViewModels
{
    public class UsersRegisterViewModel
    {
        [Required]
        [MinLength(6, ErrorMessage = "Username should be at least 6 charachters long!")]
        [MaxLength(23, ErrorMessage = "Username can't be longer than 23 characters")]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "First name should be at least 3 charachters long!")]
        [MaxLength(50, ErrorMessage = "First name can't be longer than 50 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Last name should be at least 3 charachters long!")]
        [MaxLength(50, ErrorMessage = "Last name can't be longer than 50 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,23}$", ErrorMessage =
            "Password should be: minimum eight characters, at least one letter, one number and one special character:")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare(nameof(Password), ErrorMessage = "Passwords don't match!")]
        [Display(Name = "Password confirmation ")]
        [DataType(DataType.Password)]
        public string PasswordConfirmation { get; set; }

        [Display(Name = "I Accept Privacy/Policy rules of this site.")]
        public bool PrivacyPolicyAccepted { get; set; }
    }
}

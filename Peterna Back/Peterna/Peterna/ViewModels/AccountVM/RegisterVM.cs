using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Peterna.ViewModels.AccountVM
{
    public class RegisterVM
    {[Required,DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Required,DataType(DataType.Password),Compare("Password", ErrorMessage = "Passwords are not match.")]
        public string ConfrimPassword { get; set; }
    }
}

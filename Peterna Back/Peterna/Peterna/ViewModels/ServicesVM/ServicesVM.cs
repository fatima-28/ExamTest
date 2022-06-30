using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Peterna.ViewModels.ServicesVM
{
    public class ServicesVM
    {
        public int Id { get; set; }
        public string Image { get; set; }
        [Required(ErrorMessage = "This field is REQUIRED")]
        public string Title { get; set; }
        [Required(ErrorMessage = "This field is REQUIRED")]
        public string Description { get; set; }
        [Required, NotMapped]
        public IFormFile Photo { get; set; }
    }
}

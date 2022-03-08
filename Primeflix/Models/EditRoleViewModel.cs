using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Primeflix.Models
{
    public class EditRoleViewModel
    {
        public string Id { get; set; }
        [Required(ErrorMessage ="RoleName is required")]
        public string RoleName { get; set; }
        public List<string> Users { get; set; } 
        public EditRoleViewModel()
        {
            Users = new List<string>();
        }
    }
}

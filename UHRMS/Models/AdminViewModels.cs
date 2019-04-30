using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UHRMS.Models
{
    public class ManageUserViewModel
    {
        [Required]
        [Display (Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display (Name = "Utech ID")]
        public string ID { get; set; }

        [Display (Name = "Roles")]
        public IList<string> Roles { get; set; }
    }
}
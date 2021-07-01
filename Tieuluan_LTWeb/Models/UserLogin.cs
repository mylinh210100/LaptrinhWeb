using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tieuluan_LTWeb.Models
{
    public class UserLogin
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Pass { get; set; }
    }
}
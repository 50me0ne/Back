using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Back.Models
{
    public class User
    {
        [Key]
        public int userId { get; set; }
        [Required]
        public string userName { get; set; }
        public string userNameDisplay { get; set; }
        [Required]
        public string Email { get; set; }
        public string password { get; set; }
    }
    public class Credential
    {
        public string userName { get; set; }
        public string password { get; set; }
    }
}

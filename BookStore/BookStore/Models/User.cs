using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    public class User
    {
        [Key]
        public string UserName { get; set; }
        [Required]
        private string password;
        public string Password { get => password; set => password = value; }
       
        public string Name { get; set; }
        [Phone]
        public int Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }



    }
}
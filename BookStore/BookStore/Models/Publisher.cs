using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Publisher
    {
        [Key]
        public int PublisherID { get; set; }


        public string Name { get; set; }
        [Phone]
        public int Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }

        [ForeignKey("FKAccessories")]
        public int AccID { get; set; }
        public Accessories FKAccessories { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public float Price { get; set; }
        public bool IsActive { get; set; }
    }
}
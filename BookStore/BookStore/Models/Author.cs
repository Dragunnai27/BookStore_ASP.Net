using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    public class Author
    {
        [Key]
        public int AuthorID { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
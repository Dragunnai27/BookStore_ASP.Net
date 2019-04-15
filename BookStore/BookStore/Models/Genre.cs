using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Genre
    {
        [Key]
        public int GenreID { get; set; }

        ICollection<BookInformation> BookInfo { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
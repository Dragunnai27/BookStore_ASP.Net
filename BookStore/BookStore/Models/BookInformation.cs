using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BookStore.Models
{
    public class BookInformation
    {
        [Key]
        public int BookInfoID { get; set; }

        [ForeignKey("FKBook")]
        public int BookID { get; set; }
        public Book FKBook { get; set; }

        [Required]
        public int ISBN { get; set; }

        public string Description { get; set; }
        public int PublishYear { get; set; }
        public int Page { get; set; }
        public string Language { get; set; }
        public string Size { get; set; }
        public float Weight { get; set; }
    }
}
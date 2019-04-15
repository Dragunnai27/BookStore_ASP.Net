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

        // Many comment
        public ICollection<Comment> Comments { get; set; }
        // Many author
        public ICollection<Author> Authors { get; set; }
        // Many publisher
        public ICollection<Publisher> Publishers { get; set; }
        // Many Genre
        public ICollection<Genre> Genres { get; set; }

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
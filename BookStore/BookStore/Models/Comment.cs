using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }

        [ForeignKey("FKBookInfo")]
        public int BookInfoID { get; set; }
        public BookInformation FKBookInfo { get; set; }

        [ForeignKey("FKUser")]
        public string UserName { get; set; }
        public User FKUser { get; set; }

        [Required]
        public string Content { get; set; }
        public int Star { get; set; } 
        public DateTime CommentDate { get; set; }
    }
}
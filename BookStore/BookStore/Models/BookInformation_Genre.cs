using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class BookInformation_Genre
    {
        [Key]
        public int ID { get; set; }

        public int GenreID { get; set; }
        public virtual Genre Genre { get; set; }

        public int BookInfoID { get; set; }
        public virtual BookInformation BookInformation { get; set; }
    }
}
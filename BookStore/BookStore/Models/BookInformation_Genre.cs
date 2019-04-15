using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class BookInformation_Genre
    {
        public int GenreID { get; set; }
        public virtual Genre Genre { get; set; }

        public int BookInfoID { get; set; }
        public virtual BookInformation BookInformation { get; set; }
    }
}
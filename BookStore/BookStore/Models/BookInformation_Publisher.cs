using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class BookInformation_Publisher
    {
        public int PublisherID { get; set; }
        public virtual Publisher Publisher { get; set; }

        public int BookInfoID { get; set; }
        public virtual BookInformation BookInformation { get; set; }
    }
}
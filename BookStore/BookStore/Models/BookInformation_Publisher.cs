using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class BookInformation_Publisher
    {

        [Key]
        public int ID { get; set; }

        public int PublisherID { get; set; }
        public virtual Publisher Publisher { get; set; }

        public int BookInfoID { get; set; }
        public virtual BookInformation BookInformation { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [ForeignKey("FKUser")]
        public string UserName { get; set; }
        public User FKUser { get; set; }
        public bool IsActive { get; set; }

    }
}
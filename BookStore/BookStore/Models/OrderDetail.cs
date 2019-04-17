using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailID { get; set; }

        [ForeignKey("FKOrder")]
        public int OrderID { get; set; }
        public Order FKOrder { get; set; }

        [ForeignKey("FKBook")]
        public int BookID { get; set; }
        public Book FKBook { get; set; }

        public int Quantity { get; set; }
        public float TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
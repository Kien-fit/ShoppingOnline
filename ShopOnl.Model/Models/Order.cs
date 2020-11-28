using ShopOnl.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopOnl.Model.Models
{
    [Table("Orders")]
    public class Order : AllableImpl
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [MaxLength(256)]
        public string CustomerName { set; get; }

        [MaxLength(256)]
        public string CustomerAddress { set; get; }

        [MaxLength(256)]
        public string CustomerEmail { set; get; }

        [MaxLength(256)]
        public string CustomerMobile { set; get; }

        [MaxLength(256)]
        public string CustomerMessage { set; get; }

        [MaxLength(256)]
        public string PaymentMethod { set; get; }

        //[MaxLength(256)]
        public string PaymentStatus { set; get; }

        //public int Status { set; get; }


        public virtual IEnumerable<Order> Orders { set; get; }
    }
}
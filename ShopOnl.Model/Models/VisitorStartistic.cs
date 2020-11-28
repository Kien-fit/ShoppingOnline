using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopOnl.Model.Models
{
    [Table("VisitorSatistics")]
    public class VisitorStartistic
    {
        [Key]
        public Guid ID { set; get; }

        [Required]
        [MaxLength(256)]
        public DateTime VisitedDate { set; get; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string IPAddress { set; get; }
    }
}
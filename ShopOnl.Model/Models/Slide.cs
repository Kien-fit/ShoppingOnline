using ShopOnl.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopOnl.Model.Models
{
    [Table("Slides")]
    public class Slide : AllableImpl
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [MaxLength(256)]
        public string Descriptio { set; get; }

        [Required]
        [MaxLength(256)]
        public string Image { set; get; }

        [Required]
        [MaxLength(256)]
        public string URL { set; get; }

        [MaxLength(256)]
        public int DisplayOrder { set; get; }
    }
}
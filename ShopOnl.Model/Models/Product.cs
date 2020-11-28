using ShopOnl.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ShopOnl.Model.Models
{
    [Table("Products")]
    public class Product : AllableImpl
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Required]
        [MaxLength(256)]
        public string Alias { set; get; }

        [MaxLength(50)]
        public int CategoryID { set; get; }
        
        public string Image { set; get; }

        public XElement MoreImage { set; get; }

        [MaxLength(50)]
        public decimal Price { set; get; }

        [MaxLength(50)]
        public decimal? PromotionPrice { set; get; }

        [MaxLength(50)]
        public int? Warranty { set; get; }

        [MaxLength(256)]
        public string Description { set; get; }
        
        public string Content { set; get; }
        
        public bool? HomeFlag { set; get; }
        
        public bool? HotFlag { set; get; }

        [MaxLength(50)]
        public int? ViewCount { set; get; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { set; get; }

        public virtual IEnumerable<Product> Products { set; get; }
    }
}
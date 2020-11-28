using ShopOnl.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopOnl.Model.Models
{
    [Table("ProductCategories")]
    public class ProductCategory : AllableImpl
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(100)]
        public string Name { set; get; }

        [Required]
        [MaxLength(100)]
        public string Alias { set; get; }

        [MaxLength(256)]
        public string Description { set; get; }

        [MaxLength(100)]
        public int? ParentID { set; get; }

        [MaxLength(100)]
        public int? DisplayOrder { set; get; }
        
        public string Image { set; get; }

        public bool? HomeFlag { set; get; }

        public virtual IEnumerable<Product> Products { set; get; }
    }
}
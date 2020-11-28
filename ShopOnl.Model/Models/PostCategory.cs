using ShopOnl.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopOnl.Model.Models
{
    [Table("PostCategories")]
    public class PostCategory : AllableImpl
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

        [MaxLength(256)]
        public string Description { set; get; }

        [MaxLength(50)]
        public int? ParentID { set; get; }

        [MaxLength(50)]
        public int? DisplayOrder { set; get; }
        
        public string Image { set; get; }

        public bool? HomeFlag { set; get; }
        
        public virtual IEnumerable<Post> Posts { set; get; }
    }
}
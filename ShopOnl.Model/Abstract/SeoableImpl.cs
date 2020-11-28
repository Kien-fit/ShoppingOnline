using System.ComponentModel.DataAnnotations;

namespace ShopOnl.Model.Abstract
{
    public abstract class SeoableImpl : Seoable
    {
        [MaxLength(256)]
        public string MetaKeyword { get; set; }

        [MaxLength(256)]
        public string MetaDescription { get; set; }
    }
}
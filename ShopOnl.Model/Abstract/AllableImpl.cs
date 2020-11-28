using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopOnl.Model.Abstract
{
    public abstract class AllableImpl : Allable
    {
        /// <summary>
        /// Auditable
        /// </summary>

        public DateTime? CreateDate { get; set; }

        [MaxLength(256)]
        [Column(TypeName = "varchar")]
        public string CreateBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        [MaxLength(256)]
        [Column(TypeName = "varchar")]
        public string UpdateBy { get; set; }

        /// <summary>
        /// Seoable
        /// </summary>

        [MaxLength(256)]
        public string MetaKeyword { get; set; }

        [MaxLength(256)]
        public string MetaDescription { get; set; }

        /// <summary>
        /// Switchable
        /// </summary>
        
        public bool Status { set; get; }
    }
}
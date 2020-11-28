using System;
using System.ComponentModel.DataAnnotations;

namespace ShopOnl.Model.Abstract
{
    public abstract class AuditableImpl : Auditable
    {
        public DateTime? CreateDate { get; set; }

        [MaxLength(256)]
        public string CreateBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        [MaxLength(256)]
        public string UpdateBy { get; set; }
    }
}
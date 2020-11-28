using System;

namespace ShopOnl.Model.Abstract
{
    public interface Allable
    {
        /// <summary>
        /// Auditable
        /// </summary>
        
        DateTime? CreateDate { set; get; }
        string CreateBy { set; get; }
        DateTime? UpdateDate { set; get; }
        string UpdateBy { set; get; }

        /// <summary>
        /// Seoable
        /// </summary>
        
        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }

        /// <summary>
        /// Switchable
        /// </summary>
        

        bool Status { set; get; }
    }
}
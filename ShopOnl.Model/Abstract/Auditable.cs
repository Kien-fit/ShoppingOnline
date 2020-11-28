using System;

namespace ShopOnl.Model.Abstract
{
    public interface Auditable
    {
        DateTime? CreateDate { set; get; }
        string CreateBy { set; get; }
        DateTime? UpdateDate { set; get; }
        string UpdateBy { set; get; }
    }
}
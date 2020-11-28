using ShopOnl.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnl.Model.Models
{
    [Table("Supportonlines")]
    public class SupportOnline : AllableImpl
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID		{set;get;}
        	
        [MaxLength(100)]
        public string Name	 	{set;get;}

        [MaxLength(100)]
        public string Department{set;get;}
        
        [MaxLength(100)]
        public string Skype { set; get; }

        [MaxLength(50)]
        public string Mobile	{set;get;}	

        [MaxLength(100)]
        public string Email		{set;get;} 

        [MaxLength(100)]
        public string Facebook	{set;get;} 
        
        [MaxLength(100)]
        public string Yahoo { set; get; }

    }
}

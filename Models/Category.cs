using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MobileZone.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        [DisplayName("Category")]
        [StringLength(15)]
        public string CategoryName { get; set; }

        //Navigation property
        public List<Mobile> Mobile { get; set; }
    }
}

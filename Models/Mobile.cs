using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MobileZone.Models
{
    public class Mobile
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Enter a mobile name.")]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }
        
        [Required]
        [StringLength(200, ErrorMessage = "Enter a mobile description.")]
        public string Description { get; set; }
         
        [Required]
        [DisplayName("Enrollment date.")]
        public DateTime ManufactureDate { get; set; }

        [Required]
        public bool IsInStock { get; set; }

        [Required]
        public int CategoryId { get; set; }
        //Navigation property
        public Category Category { get; set; }

        public string Slug =>
            Name?.Replace(' ', '-').ToLower() + '-' + ManufactureDate.ToString("yyyy");

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PocketRoofer.Models
{
    public class EstimateViewModel
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Estimate address:")]
        public string address { get; set; }
        
        [EmailAddress]
        [Display(Name = "Registered Email:")]
        public string Email { get; set; }
        [Display(Name = "Number of Bundles required:")]
        public decimal bundle { get; set; }
        [Display(Name = "Gutters")]
        public List<Gutter> gutters { get; set; }

    }
}
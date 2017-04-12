using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PocketRoofer.Models
{
    public class EstimateViewModels
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Address")]
        public string address { get; set; }
        
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Bundles")]
        public int bundle { get; set; }
        public Gutter gutter { get; set; }

    }
}
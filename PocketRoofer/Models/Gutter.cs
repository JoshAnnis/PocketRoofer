using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PocketRoofer.Models
{
    public class Gutter
    {
        [Key]
        public int Id { get; set; }
        public int Number { get; set; }
        public int Length { get; set; }

        [ForeignKey("EstimateViewModels")]
        public int EstimateViewModelsId { get; set; }
        public  EstimateViewModels EstimateViewModels { get; set; }

    }
}
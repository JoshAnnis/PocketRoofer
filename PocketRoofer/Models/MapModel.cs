using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PocketRoofer.Models
{
    public class MapModel
    {
        [Key]
        public int Id { get; set; }
        public decimal Lat { get; set; }
        public decimal Lng { get; set; }
        public int Zoom { get; set; }
    }
}
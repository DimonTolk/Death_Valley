using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DeathValley.Models
{
    public class UserData
    {
        [Required]
        [Display]
        public int UserDataId { get; set; }

        [Required]
        [Display]
        public int RangeFrom { get; set; }

        [Required]
        [Display]
        public int RangeTo { get; set; }

        [Required]
        [Display]
        public float step { get; set; }

        [Required]
        [Display]
        public int a { get; set; }

        [Required]
        [Display]
        public int b { get; set; }

        [Required]
        [Display]
        public int c { get; set; }
    }
}
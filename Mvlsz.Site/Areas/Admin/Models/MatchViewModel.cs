using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mvlsz.Site.Areas.Admin.Models
{
    public class MatchViewModel
    {
        [Required]
        [Display(Name = "Helyszín")]
        public string Place { get; set; }

        [Required]
        [Display(Name = "Időpont")]
        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }

        [Required]
        [Display(Name = "Osztály")]
        public string Division { get; set; }

        [Required]
        [Display(Name = "Hazai")]
        public string HomeTeam { get; set; }

        [Required]
        [Display(Name = "Vendég")]
        public string VisitorTeam { get; set; }
    }
}

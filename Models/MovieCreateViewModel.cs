using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MovieWeb.Models
{
    public class MovieCreateViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Required to fill in")]
        public string Title { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Required to fill in")]
        public string Description { get; set; }

        public DateTime ReleaseDate { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Required to fill in")]
        public string Genre { get; set; }


    }
}

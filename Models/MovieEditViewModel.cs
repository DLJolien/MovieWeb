using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWeb.Models
{
    public class MovieEditViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Required to fill in")]
        [MaxLength(30, ErrorMessage = "Max length is 30 characters")]
        public string Title { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Required to fill in")]
        [MaxLength(250, ErrorMessage = "Max length is 250 characters")]
        public string Description { get; set; }

        [DisplayName("Release Date")]
        [Range(typeof(DateTime), "01/01/1900", "31/12/2070",
        ErrorMessage = "Value must be between {1} and {2}")]
        public DateTime ReleaseDate { get; set; }

        [MaxLength(30, ErrorMessage = "Max length is 30 characters")]
        public string Genre { get; set; }
    }
}

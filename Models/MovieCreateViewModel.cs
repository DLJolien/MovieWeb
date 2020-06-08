using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MovieWeb.Models
{
    public class MovieCreateViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Required to fill in")]
        [MaxLength(30, ErrorMessage ="Max length is 30 characters")]
        public string Title { get; set; }

        [MaxLength(250, ErrorMessage = "Max length is 250 characters")]
        public string Description { get; set; }

        [DisplayName("Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Required to fill in")]
        [MaxLength(30, ErrorMessage = "Max length is 30 characters")]
        public string Genre { get; set; }


    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace AllSpice.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        [Required]
        [MinLength(3)]
        public string Title { get; set; }

        public string SubTitle { get; set; }

        public string Category { get; set; }

        [Url]
        public string ImgUrl { get; set; }
        public string CreatorId { get; set; }
        public Profile Creator { get; set; }
    }

    // TODO add ViewModel for favorites?
}
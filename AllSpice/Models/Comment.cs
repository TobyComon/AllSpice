using System;

namespace AllSpice.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string RecipeId { get; set; }
        public string CreatorId { get; set; }
        public Profile Creator { get; set; }
        public string Body { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
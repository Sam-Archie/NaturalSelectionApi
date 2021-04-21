using NaturalSelection.Data.Entites;
using System;
using System.Collections.Generic;

namespace NaturalSelection.Data
{
    public class Post
    {
        public Guid Id { get; set; }
        public User User { get; set; }
        public string Content { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public IList<Comment> Comments { get; set; }
        public IList<Image> Image { get; set; }
        public IList<Tag> Tags { get; set; }
    }
}

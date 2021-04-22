using NaturalSelection.Core.Common;
using NaturalSelection.Data.Entites;
using System;
using System.Collections.Generic;

namespace NaturalSelection.Data
{
    public class Post : AuditableEntity
    {
        public Guid Id { get; set; }
        public User User { get; set; }
        public string Content { get; set; }
        public IList<Comment> Comments { get; set; } = new List<Comment>();
        public IList<Tag> Tags { get; set; } = new List<Tag>();
        public IList<Image> Images { get; set; } = new List<Image>();
    }
}

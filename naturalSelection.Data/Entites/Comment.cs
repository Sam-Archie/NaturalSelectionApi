using NaturalSelection.Core.Common;
using System;
using System.Collections.Generic;

namespace NaturalSelection.Data.Entites
{
    public class Comment : AuditableEntity
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public User User { get; set; }
        public int Likes { get; set; }
        public IList<Comment> Replies { get; set; }
    }
}
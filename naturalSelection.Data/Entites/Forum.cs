using NaturalSelection.Core.General;
using NaturalSelection.Data;
using NaturalSelection.Data.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalSelection.Core.Entites
{
    public class Forum
    {
        public Guid ForumId { get; set; }
        public bool IsPrivate { get; set; }
        public string Name { get; set; }
        public IList<Post> Posts { get; set; }
        public IList<User> Users { get; set; }
        public IList<Tag> Tags { get; set; }
        public SecurityLevel SecurityLevels { get; set; }
    }
}

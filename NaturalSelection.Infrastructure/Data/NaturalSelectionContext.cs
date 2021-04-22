using Microsoft.EntityFrameworkCore;
using NaturalSelection.Core.Entites;
using NaturalSelection.Data;
using NaturalSelection.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NaturalSelection.Core.Data
{
    public class NaturalSelectionContext : DbContext
    {
        public NaturalSelectionContext(DbContextOptions<NaturalSelectionContext> options) : base(options)
        {

        }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Forum> Forums { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}

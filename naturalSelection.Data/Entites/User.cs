using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalSelection.Data.Entites
{
    public class User
    {
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        public string UserName { get; set; }
        public bool Active { get; set; }
        public string Email { get; set; }
        public bool IsSubscribed { get; set; }
        private bool IsAdmin { get; set; }
        public IList<Post> Posts { get; set; }
        public IList<Comment> Comments { get; set; }
        public IList<Tag> Tags { get; set; }
        public string Password { get; set; }
    }
}

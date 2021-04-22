using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalSelection.Core.Common
{
    //This class is used as a base class which contains base props that every other entity should have
    public class AuditableEntity
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}

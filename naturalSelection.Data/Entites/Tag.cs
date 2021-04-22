using NaturalSelection.Core.Common;
using System;
using System.Collections.Generic;

namespace NaturalSelection.Data.Entites
{
    public class Tag : AuditableEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
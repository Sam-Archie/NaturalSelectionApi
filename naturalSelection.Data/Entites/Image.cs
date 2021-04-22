using NaturalSelection.Core.Common;
using System;

namespace NaturalSelection.Data
{
    public class Image : AuditableEntity
    {
        public Guid Id { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
    }
}
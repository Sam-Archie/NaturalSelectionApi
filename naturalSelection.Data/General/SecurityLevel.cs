using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalSelection.Core.General
{
    [Flags]
    public enum SecurityLevel
    {
        Shared = 1,
        Private = 2,
        Admin = 4,
        CEO = 8,
    }
}
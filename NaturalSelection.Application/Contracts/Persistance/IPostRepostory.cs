﻿using NaturalSelection.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalSelection.Application.Contracts.Persistance
{
    interface IPostRepostory : IAsyncRepository<Post>
    {
    }
}
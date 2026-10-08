using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaDomain.Base
{
    public abstract class BaseEntity : IBaseEntity
    {
            public int Id { get; set; }

    }
}
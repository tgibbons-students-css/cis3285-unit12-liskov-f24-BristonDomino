﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtypeCovariance
{
    public interface IEntityRepository<out TEntity>
        where TEntity : Entity
    {
        TEntity GetByID(Guid id);
    }
}

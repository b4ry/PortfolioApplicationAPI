﻿using Microsoft.EntityFrameworkCore;
using PortfolioApplication.Api.DataTransferObjects;
using PortfolioApplication.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortfolioApplication.Api.CQRS.Queries
{
    public interface IQuery<TEntity, TDto> 
        where TEntity : BaseEntity
        where TDto : BaseDto
    {
        Task<TDto> Get(int id, Func<DbSet<TEntity>, Task<TEntity>> retrievalFunc);
        Task<IList<TDto>> Get(Func<DbSet<TEntity>, Task<List<TEntity>>> retrievalFunc);
    }
}

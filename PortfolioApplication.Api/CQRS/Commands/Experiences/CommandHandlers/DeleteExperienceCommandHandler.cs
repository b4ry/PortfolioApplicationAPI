﻿using Microsoft.Extensions.Caching.Distributed;
using PortfolioApplication.Api.CQRS.Commands.Experiences.Commands;
using PortfolioApplication.Entities.Entities;
using PortfolioApplication.Services.DatabaseContexts;

namespace PortfolioApplication.Api.CQRS.Commands.Experiences.CommandHandlers
{
    public class DeleteExperienceCommandHandler : DeleteEntityCommandHandler<DeleteExperienceCommand, ExperienceEntity>
    {
        public DeleteExperienceCommandHandler(IDatabaseSet databaseSet, IUnitOfWork unitOfWork, IDistributedCache redisCache) 
            : base(databaseSet, unitOfWork, redisCache)
        {
        }
    }
}

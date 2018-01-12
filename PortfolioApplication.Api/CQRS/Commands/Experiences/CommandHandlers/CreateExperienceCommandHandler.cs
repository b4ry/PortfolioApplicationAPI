﻿using AutoMapper;
using Microsoft.Extensions.Caching.Distributed;
using PortfolioApplication.Api.CQRS.Commands.Experiences.Commands;
using PortfolioApplication.Entities.Entities;
using PortfolioApplication.Services.DatabaseContexts;

namespace PortfolioApplication.Api.CQRS.Commands.Experiences.CommandHandlers
{
    public class CreateExperienceCommandHandler : CreateEntityCommandHandler<CreateExperienceCommand, ExperienceEntity>
    {
        public CreateExperienceCommandHandler(IDatabaseSet databaseSet, IUnitOfWork unitOfWork, IDistributedCache redisCache, IMapper mapper) 
            : base(databaseSet, unitOfWork, redisCache, mapper)
        {
        }
    }
}

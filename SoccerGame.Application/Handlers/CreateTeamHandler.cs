using MediatR;
using SoccerGame.Application.Commands;
using SoccerGame.Application.Mappers;
using SoccerGame.Application.Responses;
using SoccerGame.Core.Entities;
using SoccerGame.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SoccerGame.Application.Handlers
{
    public class CreateTeamHandler : IRequestHandler<CreateTeamCommand, TeamResponse>
    {
        private readonly ITeamRepository _teamRepo;
        public CreateTeamHandler(ITeamRepository teamRepository)
        {
            _teamRepo = teamRepository;
        }
        public async Task<TeamResponse> Handle(CreateTeamCommand request, CancellationToken cancellationToken)
        {
            var teamEntitiy = TeamMapper.Mapper.Map<Team>(request);
            if (teamEntitiy is null)
            {
                throw new ApplicationException("Issue with mapper");
            }
            var newTeam = await _teamRepo.AddAsync(teamEntitiy);
            var teamResponse = TeamMapper.Mapper.Map<TeamResponse>(newTeam);
            return teamResponse;
        }
    }
}

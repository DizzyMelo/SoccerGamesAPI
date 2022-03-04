using MediatR;
using SoccerGame.Application.Queries;
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
    public class GetAllTeamHandler : IRequestHandler<GetAllTeamQuery, List<Team>>
    {
        private readonly ITeamRepository _teamRepo;

        public GetAllTeamHandler(ITeamRepository employeeRepository)
        {
            _teamRepo = employeeRepository;
        }
        public async Task<List<Team>> Handle(GetAllTeamQuery request, CancellationToken cancellationToken)
        {
            return (List<Team>)await _teamRepo.GetAllAsync();
        }
    }
}

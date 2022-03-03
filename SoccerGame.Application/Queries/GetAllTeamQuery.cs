using MediatR;
using SoccerGame.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerGame.Application.Queries
{
    public class GetAllTeamQuery : IRequest<List<Team>>
    {

    }
}

using MediatR;
using SoccerGame.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerGame.Application.Commands
{
    public class CreateTeamCommand : IRequest<TeamResponse>
    {
        public string TeamName
        {
            get;
            set;
        }
        public string TeamImage
        {
            get;
            set;
        }
        public DateTime DateOfBirth
        {
            get;
            set;
        }
    }
}

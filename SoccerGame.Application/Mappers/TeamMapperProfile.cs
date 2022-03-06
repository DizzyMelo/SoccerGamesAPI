
using AutoMapper;
using SoccerGame.Application.Commands;
using SoccerGame.Application.Responses;
using SoccerGame.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerGame.Application.Mappers
{
    public class TeamMappingProfile : Profile
    {
        public TeamMappingProfile()
        {
            CreateMap<Team, TeamResponse>().ReverseMap();
            CreateMap<Team, CreateTeamCommand>().ReverseMap();
            CreateMap<Team, GetTeamByNameCommand>().ReverseMap();
        }
    }
}

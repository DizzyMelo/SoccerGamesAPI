using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoccerGame.Application.Commands;
using SoccerGame.Application.Queries;
using SoccerGame.Application.Responses;
using SoccerGame.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SoccerGame.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TeamController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<List<Team>> Get()
        {
            return await _mediator.Send(new GetAllTeamQuery());
        }

        //[HttpGet]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //public async Task<Team> GetTeamByName()
        //{
        //    return await _mediator.Send(new GetTeamByNameQuery());
        //}

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<TeamResponse>> CreateTeam([FromBody] CreateTeamCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}

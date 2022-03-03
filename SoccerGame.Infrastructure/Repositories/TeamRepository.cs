using Microsoft.EntityFrameworkCore;
using SoccerGame.Core.Entities;
using SoccerGame.Core.Repositories;
using SoccerGame.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerGame.Infrastructure.Repositories
{
    public class TeamRepository : Repository<Team>, ITeamRepository
    {
        public TeamRepository(TeamContext teamContext) : base(teamContext) { }
        public async Task<IEnumerable<Team>> GetTeamByName(string name)
        {
            return await _teamContext.Teams.Where(m => m.Name == name).ToListAsync();
        }
    }
}

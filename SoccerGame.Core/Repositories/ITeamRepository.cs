using SoccerGame.Core.Entities;
using SoccerGame.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerGame.Core.Repositories
{
    public interface ITeamRepository : IRepository <Team>
    {
        //custom operations here
        Task<IEnumerable<Team>> GetTeamByName(string name);
    }
}

using Microsoft.EntityFrameworkCore;
using SoccerGame.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerGame.Infrastructure.Data
{
    public class TeamContext : DbContext
    {
        public TeamContext(DbContextOptions<TeamContext> options) : base(options) { }
        public DbSet<Team> Teams
        {
            get;
            set;
        }
    }
}

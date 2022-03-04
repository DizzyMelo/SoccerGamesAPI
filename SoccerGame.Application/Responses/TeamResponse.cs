using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerGame.Application.Responses
{
    public class TeamResponse
    {
        public int TeamId
        {
            get;
            set;
        }
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

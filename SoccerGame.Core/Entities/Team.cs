using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerGame.Core.Entities
{
    public class Team
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 TeamId
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

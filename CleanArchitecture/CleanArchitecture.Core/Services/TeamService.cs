using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Services
{
    public class TeamService : ITeamService
    {
        public ITeamRepository _teamInterface { get; set; }
        public TeamService(ITeamRepository teamInterface)
        {
            _teamInterface = teamInterface;
        }
        public List<Team> GetAllTeams()
        {
            return _teamInterface.GetAllTeams();
        }
    }
}
